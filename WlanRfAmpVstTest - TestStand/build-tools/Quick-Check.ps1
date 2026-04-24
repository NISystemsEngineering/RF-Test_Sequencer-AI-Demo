# Quick Check - Verifies essential NI assemblies are installed
Write-Host "Checking for NI Assemblies..." -ForegroundColor Cyan
Write-Host ""

$assemblies = @(
    "NationalInstruments.RFmx.WlanMX.Fx40",
    "NationalInstruments.RFmx.InstrMX.Fx40",
    "NationalInstruments.ModularInstruments.NIRfsg.Fx40"
)

$found = 0
foreach ($asm in $assemblies) {
    $result = Get-ChildItem "$env:SystemRoot\Microsoft.NET\assembly\GAC_MSIL\$asm" -Recurse -Filter "*.dll" -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($result) {
        Write-Host "[OK] $asm" -ForegroundColor Green
        $found++
    } else {
        Write-Host "[X] $asm - NOT FOUND" -ForegroundColor Red
    }
}

Write-Host ""
if ($found -eq $assemblies.Count) {
    Write-Host "SUCCESS: All NI assemblies found!" -ForegroundColor Green
    Write-Host ""
    Write-Host "Next step: Run .\Update-ProjectReferences.ps1" -ForegroundColor Cyan
} else {
    Write-Host "ERROR: Missing $($assemblies.Count - $found) assemblies" -ForegroundColor Red
    Write-Host ""
    Write-Host "Install required NI software:" -ForegroundColor Yellow
    Write-Host "  - NI-RFmx WLAN (v23.0 or later)" -ForegroundColor Yellow
    Write-Host "  - NI-RFSG (v23.0 or later)" -ForegroundColor Yellow
    Write-Host ""
    Write-Host "Download from: https://www.ni.com/support/downloads" -ForegroundColor Cyan
}
