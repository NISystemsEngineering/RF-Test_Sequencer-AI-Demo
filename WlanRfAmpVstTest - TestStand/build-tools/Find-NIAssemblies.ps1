<#
.SYNOPSIS
    Discovers National Instruments assemblies installed on the system.

.DESCRIPTION
    This script scans common installation locations for NI assemblies and outputs
    their paths in a structured format. Useful for configuring project references
    when moving to a new development machine.

.PARAMETER AssemblyName
    Optional. Specific assembly name to search for. If not provided, searches for all common NI assemblies.

.PARAMETER OutputFormat
    Format for output: 'Table' (default), 'Json', or 'Xml'

.EXAMPLE
    .\Find-NIAssemblies.ps1
    Displays all found NI assemblies in table format

.EXAMPLE
    .\Find-NIAssemblies.ps1 -AssemblyName "NationalInstruments.RFmx.WlanMX.Fx40" -OutputFormat Json
    Finds specific assembly and outputs in JSON format
#>

[CmdletBinding()]
param(
    [Parameter(Mandatory=$false)]
    [string]$AssemblyName,

    [Parameter(Mandatory=$false)]
    [ValidateSet('Table', 'Json', 'Xml', 'ProjectXml')]
    [string]$OutputFormat = 'Table'
)

# Common NI assemblies used in this project
$RequiredAssemblies = @(
    "Ivi.Driver",
    "NationalInstruments.Common",
    "NationalInstruments.ModularInstruments.Common",
    "NationalInstruments.ModularInstruments.NIRfsg.Fx40",
    "NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40",
    "NationalInstruments.RFmx.InstrMX.Fx40",
    "NationalInstruments.RFmx.WlanMX.Fx40"
)

# Search paths
$SearchPaths = @(
    "$env:SystemRoot\Microsoft.NET\assembly\GAC_MSIL",
    "${env:ProgramFiles(x86)}\IVI Foundation\IVI\Microsoft.NET\Framework32",
    "${env:ProgramFiles}\IVI Foundation\IVI\Microsoft.NET\Framework64",
    "${env:ProgramFiles(x86)}\National Instruments\MeasurementStudioVS2010\DotNET\Assemblies",
    "${env:ProgramFiles(x86)}\National Instruments\Shared\MeasurementStudioVS\DotNET\Assemblies"
)

function Get-AssemblyVersion {
    param([string]$Path)

    try {
        $assembly = [System.Reflection.Assembly]::ReflectionOnlyLoadFrom($Path)
        return $assembly.GetName().Version.ToString()
    }
    catch {
        # Try to extract version from folder path
        if ($Path -match 'v\d+\.\d+_(\d+\.\d+\.\d+\.\d+)__') {
            return $matches[1]
        }
        return "Unknown"
    }
}

function Find-NIAssembly {
    param(
        [string]$Name,
        [string[]]$Paths
    )

    $results = @()

    foreach ($basePath in $Paths) {
        if (-not (Test-Path $basePath)) {
            continue
        }

        Write-Verbose "Searching in: $basePath"

        # Search for DLL files matching the assembly name
        $dllFiles = Get-ChildItem -Path $basePath -Recurse -Filter "$Name.dll" -ErrorAction SilentlyContinue

        foreach ($dll in $dllFiles) {
            $version = Get-AssemblyVersion -Path $dll.FullName

            $results += [PSCustomObject]@{
                AssemblyName = $Name
                Version = $version
                FullPath = $dll.FullName
                Directory = $dll.DirectoryName
                LastModified = $dll.LastWriteTime
            }
        }
    }

    return $results
}

# Main execution
Write-Host "Scanning for National Instruments assemblies..." -ForegroundColor Cyan

$assembliesToFind = if ($AssemblyName) { @($AssemblyName) } else { $RequiredAssemblies }
$allResults = @()

foreach ($asmName in $assembliesToFind) {
    Write-Verbose "Looking for: $asmName"
    $found = Find-NIAssembly -Name $asmName -Paths $SearchPaths

    if ($found) {
        $allResults += $found
        Write-Host "✓ Found $($found.Count) instance(s) of $asmName" -ForegroundColor Green
    }
    else {
        Write-Warning "✗ Could not find: $asmName"
        $allResults += [PSCustomObject]@{
            AssemblyName = $asmName
            Version = "NOT FOUND"
            FullPath = ""
            Directory = ""
            LastModified = $null
        }
    }
}

# Output results
Write-Host "`nResults:" -ForegroundColor Cyan

switch ($OutputFormat) {
    'Table' {
        $allResults | Format-Table -AutoSize
    }
    'Json' {
        $allResults | ConvertTo-Json -Depth 10
    }
    'Xml' {
        $allResults | ConvertTo-Xml -As String -Depth 10
    }
    'ProjectXml' {
        # Generate XML fragments suitable for .csproj files
        Write-Host "<ItemGroup>" -ForegroundColor Yellow

        foreach ($result in $allResults | Where-Object { $_.FullPath -ne "" }) {
            $simpleName = $result.AssemblyName
            Write-Host "  <Reference Include=`"$simpleName`">" -ForegroundColor Yellow
            Write-Host "    <HintPath>$($result.FullPath)</HintPath>" -ForegroundColor Yellow
            Write-Host "  </Reference>" -ForegroundColor Yellow
        }

        Write-Host "</ItemGroup>" -ForegroundColor Yellow
    }
}

# Summary
$foundCount = ($allResults | Where-Object { $_.FullPath -ne "" }).Count
$totalCount = $allResults.Count

Write-Host "`nSummary: Found $foundCount of $totalCount assemblies" -ForegroundColor $(if ($foundCount -eq $totalCount) { 'Green' } else { 'Yellow' })

if ($foundCount -lt $totalCount) {
    Write-Host "`nMissing assemblies may require installation of:" -ForegroundColor Yellow
    Write-Host "  - NI-RFmx WLAN" -ForegroundColor Yellow
    Write-Host "  - NI-RFSG" -ForegroundColor Yellow
    Write-Host "  - NI Modular Instruments drivers" -ForegroundColor Yellow
    Write-Host "`nDownload from: https://www.ni.com/en-us/support/downloads.html" -ForegroundColor Cyan
}
