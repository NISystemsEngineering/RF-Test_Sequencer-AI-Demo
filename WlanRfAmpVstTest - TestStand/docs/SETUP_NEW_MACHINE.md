# Setting Up This Project on a New Machine

This guide will help you quickly set up and build this project on a new development machine.

## Prerequisites

- **Windows 10/11** (64-bit)
- **Visual Studio 2019 or later** (Community, Professional, or Enterprise)
- **.NET Framework 4.8 SDK**
- **PowerShell 5.1 or later** (included with Windows)

## Required NI Software

This project requires National Instruments hardware drivers and APIs:

- **NI-RFmx WLAN** (v23.0 or later)
- **NI-RFSG** (v23.0 or later)
- **IVI Shared Components** (v2.0 or later)

> **Note:** You can develop and compile the code without physical NI hardware. The software drivers provide the necessary APIs for compilation.

## Setup Steps

### Step 1: Clone the Repository

```bash
git clone https://github.com/NISystemsEngineering/RF-Test_Sequencer-AI-Demo.git
cd "RF-Test_Sequencer-AI-Demo\WlanRfAmpVstTest - TestStand"
```

### Step 2: Verify NI Software Installation

Open PowerShell and navigate to the `build-tools` directory:

```powershell
cd build-tools
.\Verify-NIInstallation.ps1
```

**Expected Output:**
- ✓ Green checkmarks for all required assemblies
- Summary showing "All required components are installed"

**If you see red X marks or errors:**

The script will tell you exactly which NI packages are missing. Install them:

1. **Using NI Package Manager (Recommended):**
   - Download from: https://www.ni.com/en-us/support/downloads/software-products/download.ni-package-manager.html
   - Install and launch NI Package Manager
   - Search for: "NI-RFmx WLAN" and "NI-RFSG"
   - Install both packages (dependencies will be included automatically)

2. **Manual Installation:**
   - Visit: https://www.ni.com/en-us/support/downloads.html
   - Download NI-RFmx WLAN
   - Download NI-RFSG
   - Run each installer

3. **Restart your computer** after installing NI software

### Step 3: Configure Project References

After installing NI software, update the project to use your system's assembly paths:

```powershell
# Still in build-tools directory
.\Update-ProjectReferences.ps1
```

**What this does:**
- Automatically discovers NI assemblies on your system
- Updates project files with correct paths
- Creates a backup of original project files (`.backup`)

**Expected Output:**
```
✓ Found: NationalInstruments.RFmx.WlanMX.Fx40 (v23.8.0)
✓ Found: NationalInstruments.RFmx.InstrMX.Fx40 (v23.8.0)
...
✓ Project file updated successfully!
```

### Step 4: Build the Solution

Return to solution directory and build:

```powershell
cd ..
dotnet build
```

Or open in Visual Studio:

```powershell
start WlanRfAmpVstTest.sln
```

Then press `Ctrl+Shift+B` to build in Visual Studio.

### Step 5: Verify Build Success

You should see:

```
Build succeeded.
    0 Warning(s)
    0 Error(s)
```

🎉 **You're ready to develop!**

## Troubleshooting

### Build Fails with "Type or namespace 'NationalInstruments' could not be found"

**Cause:** Project references not updated or NI software not installed

**Fix:**
```powershell
cd build-tools
.\Verify-NIInstallation.ps1
.\Update-ProjectReferences.ps1
cd ..
dotnet clean
dotnet build
```

### "Cannot find assembly" even after installing NI software

**Cause:** Visual Studio may be caching old references

**Fix:**
1. Close Visual Studio completely
2. Delete `bin/` and `obj/` folders:
   ```powershell
   Get-ChildItem -Include bin,obj -Recurse | Remove-Item -Force -Recurse
   ```
3. Re-run `Update-ProjectReferences.ps1`
4. Reopen Visual Studio and rebuild

### PowerShell Script Won't Run

**Error:** "cannot be loaded because running scripts is disabled"

**Fix:**
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

### Wrong Version of Assembly Detected

**Cause:** Multiple NI software versions installed

**Fix:**
- Uninstall older versions through **Control Panel → Programs and Features**
- Or use **NI Package Manager** to manage versions
- Re-run `Update-ProjectReferences.ps1`

### CS1705: Assembly Version Conflict

**Error:** "Assembly uses X which has a higher version than referenced assembly Y"

**Cause:** Version mismatch between NI assemblies

**Fix:** The `Update-ProjectReferences.ps1` script should handle this automatically. If it persists:
1. Check installed NI software versions match (all should be v23.x or all v24.x)
2. Run `Verify-NIInstallation.ps1` to see exact versions
3. Update all NI software to the same major version

## Alternative Setup (Manual)

If you prefer not to use the automated scripts:

1. Open the solution in Visual Studio
2. Right-click on `WlanRfAmpTest.Instrument` project → **Properties**
3. Go to **References** tab
4. Remove all broken NI references (yellow warning icons)
5. Click **Add Reference** → **Browse**
6. Navigate to:
   - `C:\Windows\Microsoft.NET\assembly\GAC_MSIL\` for RFmx assemblies
   - `C:\Program Files (x86)\IVI Foundation\IVI\Microsoft.NET\` for RFSG assemblies
7. Select the required `.dll` files
8. Build the solution

## Quick Reference

### Common Commands

```powershell
# Verify installation
cd build-tools
.\Verify-NIInstallation.ps1

# Update project references
.\Update-ProjectReferences.ps1

# Build solution
cd ..
dotnet build

# Clean solution
dotnet clean

# Run tests
dotnet test
```

### Directory Structure

```
WlanRfAmpVstTest - TestStand/
├── build-tools/              # Automated setup scripts
│   ├── Verify-NIInstallation.ps1
│   ├── Find-NIAssemblies.ps1
│   ├── Update-ProjectReferences.ps1
│   └── README.md
├── src/                      # Source code
│   ├── WlanRfAmpTest.Core/
│   ├── WlanRfAmpTest.Instrument/   # Main project with NI dependencies
│   ├── WlanRfAmpTest.Sequencer/
│   └── ...
├── SETUP_NEW_MACHINE.md     # This file
└── WlanRfAmpVstTest.sln     # Visual Studio solution
```

## Getting Help

- **Setup Issues:** Review this guide and `build-tools/README.md`
- **NI Software Issues:** https://www.ni.com/support
- **Build Issues:** Check Visual Studio Error List window
- **Project Questions:** Contact the development team

## Next Steps

After successful setup:

1. **Read the main README** for project architecture and development guidelines
2. **Review `build-tools/README.md`** for advanced tooling options
3. **Set up your TestStand environment** (if using TestStand integration)
4. **Run the test suite** to ensure everything works
5. **Connect NI hardware** (if available) for full integration testing

---

**Last Updated:** [Current Date]  
**NI Software Version:** 23.x series  
**.NET Framework:** 4.8
