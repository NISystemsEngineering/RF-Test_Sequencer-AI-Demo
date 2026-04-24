# Update All Project References - Processes ALL projects in the solution
# This script discovers NI assemblies and updates ALL project files that reference them

[CmdletBinding()]
param(
    [Parameter(Mandatory=$false)]
    [bool]$Backup = $true
)

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path

function Find-NIAssembly {
    param([string]$Name)

    $searchPaths = @(
        "$env:SystemRoot\Microsoft.NET\assembly\GAC_MSIL",
        "${env:ProgramFiles(x86)}\IVI Foundation\IVI\Microsoft.NET\Framework32",
        "${env:ProgramFiles}\IVI Foundation\IVI\Microsoft.NET\Framework64",
        "${env:ProgramFiles(x86)}\National Instruments\MeasurementStudioVS2010\DotNET\Assemblies"
    )

    foreach ($basePath in $searchPaths) {
        if (-not (Test-Path $basePath)) { continue }

        $found = Get-ChildItem -Path $basePath -Recurse -Filter "$Name.dll" -ErrorAction SilentlyContinue | 
                 Sort-Object LastWriteTime -Descending | 
                 Select-Object -First 1

        if ($found) {
            return $found.FullName
        }
    }

    return $null
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
        if ($PSCmdlet.ShouldProcess($ProjectFilePath, "Update $updatedCount assembly reference(s)")) {
            if ($Backup) {
                $backupPath = "$ProjectFilePath.backup"
                Copy-Item -Path $ProjectFilePath -Destination $backupPath -Force
            }

            $project.Save($ProjectFilePath)
            Write-Host "    Updated $updatedCount reference(s)" -ForegroundColor Green
        }
        return $true
    }
    else {
        Write-Host "    Already up to date" -ForegroundColor Green
        return $false
    }
}

# Main execution
Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host " Update All Project References" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

# Discover assemblies
Write-Host "Step 1: Discovering NI assemblies..." -ForegroundColor Cyan
$assemblyPaths = @{}

$assemblyNames = @(
    "Ivi.Driver",
    "NationalInstruments.Common",
    "NationalInstruments.ModularInstruments.Common",
    "NationalInstruments.ModularInstruments.NIRfsg.Fx40",
    "NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40",
    "NationalInstruments.RFmx.InstrMX.Fx40",
    "NationalInstruments.RFmx.WlanMX.Fx40"
)

foreach ($asmName in $assemblyNames) {
    $path = Find-NIAssembly -Name $asmName
    if ($path) {
        $assemblyPaths[$asmName] = $path
        Write-Host "  [OK] $asmName" -ForegroundColor Green
    }
    else {
        Write-Host "  [X] $asmName - NOT FOUND" -ForegroundColor Red
    }
}

Write-Host ""

# Find all project files
Write-Host "Step 2: Finding project files..." -ForegroundColor Cyan
$solutionDir = Join-Path $scriptDir ".."
$projectFiles = Get-ChildItem -Path $solutionDir -Recurse -Filter "*.csproj" | Where-Object { $_.FullName -notlike "*\obj\*" -and $_.FullName -notlike "*\bin\*" }

Write-Host "  Found $($projectFiles.Count) project(s)" -ForegroundColor White
Write-Host ""

# Update each project
Write-Host "Step 3: Updating project files..." -ForegroundColor Cyan
$totalUpdated = 0

foreach ($projFile in $projectFiles) {
    $updated = Update-ProjectFile -ProjectFilePath $projFile.FullName -AssemblyPaths $assemblyPaths
    if ($updated) { $totalUpdated++ }
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Cyan
Write-Host " Complete" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host ""

if ($totalUpdated -gt 0) {
    Write-Host "Updated $totalUpdated project(s) successfully!" -ForegroundColor Green
}
else {
    Write-Host "All projects are already up to date!" -ForegroundColor Green
}

Write-Host ""
