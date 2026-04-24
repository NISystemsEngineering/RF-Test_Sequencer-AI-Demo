# Complete Project Setup - Automated workflow for new machines
# This script runs all necessary steps to configure the project

param(
    [switch]$SkipBuild = $false
)

Write-Host ""
Write-Host "====================================" -ForegroundColor Cyan
Write-Host " Automated Project Setup" -ForegroundColor Cyan
Write-Host "====================================" -ForegroundColor Cyan
Write-Host ""

# Step 1: Check for NI assemblies
Write-Host "Step 1: Verifying NI Software Installation..." -ForegroundColor Cyan
Write-Host ""

& ".\Quick-Check.ps1"
$checkResult = $LASTEXITCODE

if ($checkResult -ne 0 -and $LASTEXITCODE -eq $null) {
    # Quick-Check doesn't set exit code, parse output
    $checkResult = 0
}

Write-Host ""

# Step 2: Update project references if NI software found
Write-Host "Step 2: Configuring Project References..." -ForegroundColor Cyan
Write-Host ""

& ".\Update-ProjectReferences.ps1"

Write-Host ""

# Step 3: Build project (optional)
if (-not $SkipBuild) {
    Write-Host "Step 3: Building Solution..." -ForegroundColor Cyan
    Write-Host ""

    Push-Location ..
    try {
        dotnet build
        $buildResult = $LASTEXITCODE

        Write-Host ""
        if ($buildResult -eq 0) {
            Write-Host "====================================" -ForegroundColor Green
            Write-Host " Setup Complete! Build Successful" -ForegroundColor Green
            Write-Host "====================================" -ForegroundColor Green
            Write-Host ""
            Write-Host "You can now:" -ForegroundColor Cyan
            Write-Host "  - Open the solution in Visual Studio" -ForegroundColor White
            Write-Host "  - Run the application" -ForegroundColor White
            Write-Host "  - Execute tests: dotnet test" -ForegroundColor White
        }
        else {
            Write-Host "====================================" -ForegroundColor Red
            Write-Host " Build Failed" -ForegroundColor Red
            Write-Host "====================================" -ForegroundColor Red
            Write-Host ""
            Write-Host "Troubleshooting steps:" -ForegroundColor Yellow
            Write-Host "  1. Check build errors above" -ForegroundColor White
            Write-Host "  2. Ensure all NI software is installed" -ForegroundColor White
            Write-Host "  3. Try: dotnet clean" -ForegroundColor White
            Write-Host "  4. Close and reopen Visual Studio" -ForegroundColor White
        }
    }
    finally {
        Pop-Location
    }
}
else {
    Write-Host "====================================" -ForegroundColor Green
    Write-Host " Configuration Complete!" -ForegroundColor Green
    Write-Host "====================================" -ForegroundColor Green
    Write-Host ""
    Write-Host "To build the solution, run:" -ForegroundColor Cyan
    Write-Host "  cd .." -ForegroundColor White
    Write-Host "  dotnet build" -ForegroundColor White
}

Write-Host ""
