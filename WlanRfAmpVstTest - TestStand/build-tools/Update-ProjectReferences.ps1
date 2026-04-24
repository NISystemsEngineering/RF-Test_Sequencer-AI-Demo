<#
.SYNOPSIS
    Automatically updates .csproj files with correct NI assembly HintPaths for the current system.

.DESCRIPTION
    This script discovers NI assemblies on the local system and updates project files
    with the correct HintPath references. This is useful when moving a project to a new
    development machine with different NI software versions or installation paths.

.PARAMETER ProjectPath
    Path to the .csproj file to update. Defaults to WlanRfAmpTest.Instrument.csproj

.PARAMETER Backup
    Creates a backup of the original .csproj file before making changes. Default: $true

.PARAMETER WhatIf
    Shows what changes would be made without actually modifying files.

.EXAMPLE
    .\Update-ProjectReferences.ps1
    Updates the default instrument project with auto-discovered assembly paths

.EXAMPLE
    .\Update-ProjectReferences.ps1 -ProjectPath "src\MyProject\MyProject.csproj" -WhatIf
    Shows what changes would be made to the specified project without applying them
#>

[CmdletBinding(SupportsShouldProcess=$true)]
param(
    [Parameter(Mandatory=$false)]
    [string]$ProjectPath = "..\src\WlanRfAmpTest.Instrument\WlanRfAmpTest.Instrument.csproj",

    [Parameter(Mandatory=$false)]
    [bool]$Backup = $true,

    [Parameter(Mandatory=$false)]
    [switch]$WhatIf
)

# Import the assembly finder
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
. "$scriptDir\Find-NIAssemblies.ps1" -OutputFormat 'Json' | Out-Null

function Get-LatestAssembly {
    param([object[]]$Assemblies)

    if ($Assemblies.Count -eq 0) {
        return $null
    }

    # Sort by version and return the latest
    return $Assemblies | Sort-Object -Property LastModified -Descending | Select-Object -First 1
}

function Update-ProjectFile {
    param(
        [string]$ProjectFilePath,
        [hashtable]$AssemblyPaths
    )

    if (-not (Test-Path $ProjectFilePath)) {
        throw "Project file not found: $ProjectFilePath"
    }

    Write-Host "Reading project file: $ProjectFilePath" -ForegroundColor Cyan

    # Load the project file as XML
    [xml]$project = Get-Content $ProjectFilePath

    # Find the ItemGroup containing References
    $referenceGroup = $project.Project.ItemGroup | Where-Object { $_.Reference -ne $null } | Select-Object -First 1

    if (-not $referenceGroup) {
        Write-Warning "No Reference ItemGroup found in project file"
        return $false
    }

    $updatedCount = 0
    $missingCount = 0

    foreach ($reference in $referenceGroup.Reference) {
        $includeName = $reference.Include

        if ($AssemblyPaths.ContainsKey($includeName)) {
            $newPath = $AssemblyPaths[$includeName]

            if ($reference.HintPath) {
                $oldPath = $reference.HintPath
                if ($oldPath -ne $newPath) {
                    Write-Host "  Updating: $includeName" -ForegroundColor Yellow
                    Write-Host "    Old: $oldPath" -ForegroundColor Gray
                    Write-Host "    New: $newPath" -ForegroundColor Green
                    $reference.HintPath = $newPath
                    $updatedCount++
                }
                else {
                    Write-Host "  ✓ Already correct: $includeName" -ForegroundColor Green
                }
            }
            else {
                Write-Host "  Adding HintPath to: $includeName" -ForegroundColor Yellow
                $hintPathElement = $project.CreateElement("HintPath", $project.Project.NamespaceURI)
                $hintPathElement.InnerText = $newPath
                $reference.AppendChild($hintPathElement) | Out-Null
                $updatedCount++
            }
        }
        else {
            # Check if this is an NI assembly we should be tracking
            if ($includeName -like "NationalInstruments.*" -or $includeName -eq "Ivi.Driver") {
                Write-Warning "  ✗ Missing: $includeName (not found on system)"
                $missingCount++
            }
        }
    }

    if ($updatedCount -gt 0) {
        if ($PSCmdlet.ShouldProcess($ProjectFilePath, "Update assembly references")) {
            # Create backup if requested
            if ($Backup) {
                $backupPath = "$ProjectFilePath.backup"
                Copy-Item -Path $ProjectFilePath -Destination $backupPath -Force
                Write-Host "`nBackup created: $backupPath" -ForegroundColor Cyan
            }

            # Save the updated project file
            $project.Save($ProjectFilePath)
            Write-Host "`n✓ Project file updated successfully!" -ForegroundColor Green
            Write-Host "  Updated: $updatedCount reference(s)" -ForegroundColor Green

            if ($missingCount -gt 0) {
                Write-Host "  Missing: $missingCount reference(s)" -ForegroundColor Yellow
            }
        }
    }
    else {
        Write-Host "`nNo updates needed - all references are already correct!" -ForegroundColor Green
    }

    return $updatedCount -gt 0
}

# Main execution
Write-Host "=== NI Assembly Reference Updater ===" -ForegroundColor Cyan
Write-Host ""

# Discover assemblies
Write-Host "Step 1: Discovering NI assemblies on this system..." -ForegroundColor Cyan
$discoveredAssemblies = @{}

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
    $found = Find-NIAssembly -Name $asmName -Paths @(
        "$env:SystemRoot\Microsoft.NET\assembly\GAC_MSIL",
        "${env:ProgramFiles(x86)}\IVI Foundation\IVI\Microsoft.NET\Framework32",
        "${env:ProgramFiles}\IVI Foundation\IVI\Microsoft.NET\Framework64",
        "${env:ProgramFiles(x86)}\National Instruments\MeasurementStudioVS2010\DotNET\Assemblies",
        "${env:ProgramFiles(x86)}\National Instruments\Shared\MeasurementStudioVS\DotNET\Assemblies"
    )

    if ($found) {
        $latest = Get-LatestAssembly -Assemblies $found
        $discoveredAssemblies[$asmName] = $latest.FullPath
        Write-Host "  ✓ Found: $asmName (v$($latest.Version))" -ForegroundColor Green
    }
    else {
        Write-Warning "  ✗ Not found: $asmName"
    }
}

Write-Host ""

# Resolve project path
$resolvedProjectPath = Resolve-Path $ProjectPath -ErrorAction SilentlyContinue
if (-not $resolvedProjectPath) {
    Write-Error "Project file not found: $ProjectPath"
    exit 1
}

# Update project file
Write-Host "Step 2: Updating project file..." -ForegroundColor Cyan
$updated = Update-ProjectFile -ProjectFilePath $resolvedProjectPath -AssemblyPaths $discoveredAssemblies

Write-Host ""
Write-Host "=== Complete ===" -ForegroundColor Cyan

if ($updated) {
    Write-Host "Project references have been updated for this system." -ForegroundColor Green
    Write-Host "You can now build the project successfully." -ForegroundColor Green
}
