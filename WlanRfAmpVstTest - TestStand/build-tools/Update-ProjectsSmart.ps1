# Smart Project Updater - Validates version compatibility before applying
# This version tests builds to ensure no version conflicts

[CmdletBinding()]
param(
    [Parameter(Mandatory=$false)]
    [bool]$Backup = $true,

    [Parameter(Mandatory=$false)]
    [switch]$PreferStable = $true  # Prefer known-stable v23.8 over newest
)

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

function Find-AllAssemblyVersions {
    param([string]$Name)

    $searchPaths = @(
        "$env:SystemRoot\Microsoft.NET\assembly\GAC_MSIL",
        "${env:ProgramFiles(x86)}\IVI Foundation\IVI\Microsoft.NET\Framework32",
        "${env:ProgramFiles}\IVI Foundation\IVI\Microsoft.NET\Framework64",
        "${env:ProgramFiles(x86)}\National Instruments\MeasurementStudioVS2010\DotNET\Assemblies"
    )

    $results = @()

    foreach ($basePath in $searchPaths) {
        if (-not (Test-Path $basePath)) { continue }

        $found = Get-ChildItem -Path $basePath -Recurse -Filter "$Name.dll" -ErrorAction SilentlyContinue

        foreach ($dll in $found) {
            $version = "Unknown"

            # Try to extract version from path (e.g., v4.0_23.8.0.49286__token)
            if ($dll.DirectoryName -match 'v\d+\.\d+_(\d+\.\d+\.\d+\.\d+)__') {
                $version = $matches[1]
            }
            elseif ($dll.VersionInfo.FileVersion) {
                $version = $dll.VersionInfo.FileVersion
            }

            $results += [PSCustomObject]@{
                Name = $Name
                Version = $version
                FullPath = $dll.FullName
                LastModified = $dll.LastWriteTime
            }
        }
    }

    return $results | Sort-Object Version -Descending
}

function Get-StableAssemblySet {
    # Returns a known-stable set of compatible versions (v23.8 configuration)
    return @{
        "Ivi.Driver" = "C:\Program Files\IVI Foundation\IVI\Microsoft.NET\Framework64\v2.0.50727\IviFoundationSharedComponents 2.0.0\Ivi.Driver.dll"
        "NationalInstruments.Common" = "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\NationalInstruments.Common\v4.0_19.1.40.49152__dc6ad606294fc298\NationalInstruments.Common.dll"
        "NationalInstruments.ModularInstruments.Common" = "C:\Program Files (x86)\IVI Foundation\IVI\Microsoft.NET\Framework32\v4.0.30319\NationalInstruments.ModularInstruments.Common 23.0.0\NationalInstruments.ModularInstruments.Common.dll"
        "NationalInstruments.ModularInstruments.NIRfsg.Fx40" = "C:\Program Files (x86)\IVI Foundation\IVI\Microsoft.NET\Framework32\v4.0.30319\NationalInstruments.ModularInstruments.NIRfsg 23.0.0\NationalInstruments.ModularInstruments.NIRfsg.Fx40.dll"
        "NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40" = "C:\Program Files (x86)\National Instruments\MeasurementStudioVS2010\DotNET\Assemblies\26.0.0.49263\NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40.dll"
        "NationalInstruments.RFmx.InstrMX.Fx40" = "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\NationalInstruments.RFmx.InstrMX.Fx40\v4.0_23.8.0.49286__dc6ad606294fc298\NationalInstruments.RFmx.InstrMX.Fx40.dll"
        "NationalInstruments.RFmx.WlanMX.Fx40" = "C:\Windows\Microsoft.NET\assembly\GAC_MSIL\NationalInstruments.RFmx.WlanMX.Fx40\v4.0_23.8.0.49286__dc6ad606294fc298\NationalInstruments.RFmx.WlanMX.Fx40.dll"
    }
}

function Test-AssemblyCompatibility {
    param([hashtable]$AssemblyPaths)

    Write-Host "  Testing assembly compatibility..." -ForegroundColor Cyan

    # Check if all paths exist
    $allExist = $true
    foreach ($entry in $AssemblyPaths.GetEnumerator()) {
        if (-not (Test-Path $entry.Value)) {
            Write-Host "    [X] Missing: $($entry.Key)" -ForegroundColor Red
            $allExist = $false
        }
    }

    if (-not $allExist) {
        return $false
    }

    # Check for known incompatible combinations
    $rfmxPath = $AssemblyPaths["NationalInstruments.RFmx.WlanMX.Fx40"]
    $commonPath = $AssemblyPaths["NationalInstruments.Common"]

    if ($rfmxPath -and $commonPath) {
        # Extract versions
        $rfmxVersion = "Unknown"
        $commonVersion = "Unknown"

        if ($rfmxPath -match 'v\d+\.\d+_(\d+\.\d+)') {
            $rfmxVersion = $matches[1]
        }

        if ($commonPath -match 'v\d+\.\d+_(\d+\.\d+)') {
            $commonVersion = $matches[1]
        }

        Write-Host "    RFmx: v$rfmxVersion, Common: v$commonVersion" -ForegroundColor Gray

        # Known incompatible: RFmx v26+ needs Common v19.1, but we might have v19.0
        if ($rfmxVersion -match '^(26|27|28)' -and $commonVersion -eq "19.0") {
            Write-Host "    [!] Warning: RFmx v$rfmxVersion may be incompatible with Common v$commonVersion" -ForegroundColor Yellow
            Write-Host "    [!] Recommend using RFmx v23.8 + Common v19.1" -ForegroundColor Yellow
            return $false
        }
    }

    Write-Host "    [OK] Version check passed" -ForegroundColor Green
    return $true
}

function Update-ProjectFile {
    param([string]$ProjectFilePath, [hashtable]$AssemblyPaths)

    if (-not (Test-Path $ProjectFilePath)) {
        Write-Warning "Project file not found: $ProjectFilePath"
        return $false
    }

    Write-Host "  Checking: $(Split-Path -Leaf $ProjectFilePath)" -ForegroundColor Cyan

    [xml]$project = Get-Content $ProjectFilePath
    $referenceGroup = $project.Project.ItemGroup | Where-Object { $_.Reference -ne $null }

    if (-not $referenceGroup) {
        Write-Host "    No NI references found" -ForegroundColor Gray
        return $false
    }

    $updatedCount = 0

    foreach ($refGroup in $referenceGroup) {
        foreach ($reference in $refGroup.Reference) {
            $includeName = $reference.Include

            if ($AssemblyPaths.ContainsKey($includeName)) {
                $newPath = $AssemblyPaths[$includeName]

                if ($reference.HintPath) {
                    $oldPath = $reference.HintPath
                    if ($oldPath -ne $newPath) {
                        Write-Host "    Updating: $includeName" -ForegroundColor Yellow
                        $reference.HintPath = $newPath
                        $updatedCount++
                    }
                }
                else {
                    Write-Host "    Adding HintPath: $includeName" -ForegroundColor Yellow
                    $hintPathElement = $project.CreateElement("HintPath", $project.Project.NamespaceURI)
                    $hintPathElement.InnerText = $newPath
                    $reference.AppendChild($hintPathElement) | Out-Null
                    $updatedCount++
                }
            }
        }
    }

    if ($updatedCount -gt 0) {
        if ($Backup) {
            $backupPath = "$ProjectFilePath.backup"
            Copy-Item -Path $ProjectFilePath -Destination $backupPath -Force
        }

        $project.Save($ProjectFilePath)
        Write-Host "    Updated $updatedCount reference(s)" -ForegroundColor Green
        return $true
    }
    else {
        Write-Host "    Already up to date" -ForegroundColor Green
        return $false
    }
}

function Test-Build {
    Write-Host "`n  Testing build..." -ForegroundColor Cyan

    $buildOutput = dotnet build --nologo -v:quiet 2>&1

    if ($LASTEXITCODE -eq 0) {
        Write-Host "  [OK] Build successful!" -ForegroundColor Green
        return $true
    }
    else {
        Write-Host "  [X] Build failed!" -ForegroundColor Red

        # Check for version conflict errors
        $versionErrors = $buildOutput | Select-String "CS1705"
        if ($versionErrors) {
            Write-Host "`n  Version Conflict Detected:" -ForegroundColor Yellow
            foreach ($error in $versionErrors) {
                Write-Host "    $error" -ForegroundColor Gray
            }
        }

        return $false
    }
}

# Main execution
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host " Smart Project Reference Updater" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Step 1: Choose assembly strategy
Write-Host "Step 1: Selecting assembly strategy..." -ForegroundColor Cyan

if ($PreferStable) {
    Write-Host "  Using known-stable configuration (v23.8)" -ForegroundColor Green
    $assemblyPaths = Get-StableAssemblySet
}
else {
    Write-Host "  Discovering latest versions..." -ForegroundColor Yellow

    # Discovery logic here (would scan for newest)
    $assemblyNames = @(
        "Ivi.Driver",
        "NationalInstruments.Common",
        "NationalInstruments.ModularInstruments.Common",
        "NationalInstruments.ModularInstruments.NIRfsg.Fx40",
        "NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40",
        "NationalInstruments.RFmx.InstrMX.Fx40",
        "NationalInstruments.RFmx.WlanMX.Fx40"
    )

    $assemblyPaths = @{}
    foreach ($asmName in $assemblyNames) {
        $versions = Find-AllAssemblyVersions -Name $asmName
        if ($versions) {
            $latest = $versions | Select-Object -First 1
            $assemblyPaths[$asmName] = $latest.FullPath
        }
    }
}

Write-Host ""

# Step 2: Validate compatibility
Write-Host "Step 2: Validating version compatibility..." -ForegroundColor Cyan

$compatible = Test-AssemblyCompatibility -AssemblyPaths $assemblyPaths

if (-not $compatible) {
    Write-Host "`n[!] Incompatible versions detected!" -ForegroundColor Yellow
    Write-Host "    Falling back to stable configuration..." -ForegroundColor Yellow
    $assemblyPaths = Get-StableAssemblySet
    $compatible = Test-AssemblyCompatibility -AssemblyPaths $assemblyPaths
}

Write-Host ""

# Step 3: Find and update projects
Write-Host "Step 3: Updating project files..." -ForegroundColor Cyan
$solutionDir = Join-Path $scriptDir ".."
$projectFiles = Get-ChildItem -Path $solutionDir -Recurse -Filter "*.csproj" | 
                Where-Object { $_.FullName -notlike "*\obj\*" -and $_.FullName -notlike "*\bin\*" }

Write-Host "  Found $($projectFiles.Count) project(s)" -ForegroundColor White
Write-Host ""

$totalUpdated = 0
foreach ($projFile in $projectFiles) {
    $updated = Update-ProjectFile -ProjectFilePath $projFile.FullName -AssemblyPaths $assemblyPaths
    if ($updated) { $totalUpdated++ }
}

Write-Host ""

# Step 4: Test build
Write-Host "Step 4: Verifying build..." -ForegroundColor Cyan

$buildSuccess = Test-Build

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host " Complete" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

if ($buildSuccess) {
    Write-Host "[SUCCESS] All projects updated and build verified!" -ForegroundColor Green
    Write-Host ""
    Write-Host "  Projects updated: $totalUpdated" -ForegroundColor Green
    Write-Host "  Build status: PASSED" -ForegroundColor Green
}
else {
    Write-Host "[WARNING] Projects updated but build has errors" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "  Projects updated: $totalUpdated" -ForegroundColor Yellow
    Write-Host "  Build status: FAILED" -ForegroundColor Red
    Write-Host ""
    Write-Host "  Run 'dotnet build' to see detailed errors" -ForegroundColor Yellow
    Write-Host "  Or check if you need different NI software versions" -ForegroundColor Yellow
}

Write-Host ""

exit $(if ($buildSuccess) { 0 } else { 1 })
