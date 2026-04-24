# Quick Start Guide for New Systems

## First Time Setup (3 Steps)

### 1. Check if NI Software is Installed

```powershell
cd build-tools
.\Quick-Check.ps1
```

**If all checks pass** - Great! Go to step 2.  
**If checks fail** - Install the missing NI software (see below).

### 2. Update Project References

```powershell
.\Update-ProjectsSmart.ps1
```

This automatically configures your project with version-compatible assembly paths and validates the build succeeds.

### 3. Build the Project

```powershell
cd ..
dotnet build
```

Done! You should now have a successful build.

---

## Installing NI Software (If Needed)

If the Quick-Check shows missing assemblies, install:

### Required Packages:
- **NI-RFmx WLAN** (version 23.0 or later)
- **NI-RFSG** (version 23.0 or later)

### Installation Method 1: NI Package Manager (Easiest)
1. Download: https://www.ni.com/en-us/support/downloads/software-products/download.ni-package-manager.html
2. Install and launch NI Package Manager
3. Search for "NI-RFmx WLAN" and "NI-RFSG"
4. Install both packages
5. Restart your computer

### Installation Method 2: Manual Download
1. Visit: https://www.ni.com/en-us/support/downloads.html
2. Search and download each package
3. Run the installers
4. Restart your computer

After installation, run `.\Quick-Check.ps1` again to verify.

---

## Complete Tool Reference

| Script | Purpose | When to Use |
|--------|---------|-------------|
| **Quick-Check.ps1** | Fast verification of essential assemblies | First step on new machine |
| **Update-ProjectsSmart.ps1** | ⭐ Auto-configure with version validation | **Recommended**: After NI software is installed |
| **Update-ProjectReferences.ps1** | Basic project file updater | Alternative if smart updater has issues |
| **Find-NIAssemblies.ps1** | Detailed assembly discovery | Troubleshooting or manual config |

### Example: Complete New Machine Setup

```powershell
# 1. Navigate to build-tools
cd "C:\path\to\project\build-tools"

# 2. Quick check
.\Quick-Check.ps1

# 3. If OK, update references with version validation
.\Update-ProjectsSmart.ps1

# 4. Build (already tested by smart updater, but you can run again)
cd ..
dotnet build
```

---

## Troubleshooting

### "Script cannot be loaded" Error

PowerShell execution policy blocked the script.

**Fix:**
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

### Build Still Fails After Update

1. Close Visual Studio completely
2. Delete bin and obj folders:
   ```powershell
   Get-ChildItem -Include bin,obj -Recurse | Remove-Item -Force -Recurse
   ```
3. Re-run `Update-ProjectsSmart.ps1` (or `Update-ProjectReferences.ps1` if needed)
4. Open Visual Studio and rebuild

### Multiple NI Versions Installed

The smart updater defaults to known-stable v23.8 configuration to avoid version conflicts.

**For different versions:**
```powershell
# Try latest versions with compatibility checking
.\Update-ProjectsSmart.ps1 -PreferStable:$false

# Manual single project update
.\Update-ProjectReferences.ps1 -ProjectPath "..\src\ProjectName\ProjectName.csproj"
```

---

## Next Steps After Successful Build

1. Review the main project README for development guidelines
2. Set up TestStand environment (if needed)
3. Connect NI hardware for integration testing
4. Run test suite: `dotnet test`

---

## Need More Help?

- **Detailed Documentation:** See `build-tools/README.md`
- **Full Setup Guide:** See `SETUP_NEW_MACHINE.md`
- **NI Support:** https://www.ni.com/support
- **Project Issues:** Contact development team

---

Last Updated: 2024
