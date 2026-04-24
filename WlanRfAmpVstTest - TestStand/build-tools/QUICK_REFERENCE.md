# NI Dependency Management - Quick Reference Card

## 🚀 First Time Setup (Recommended)

```powershell
cd build-tools
.\Update-ProjectsSmart.ps1
```

This automatically:
1. ✅ Uses known-stable assembly versions
2. ✅ Validates version compatibility
3. ✅ Updates project references
4. ✅ Tests the build

**Alternative (Complete Automation):**
```powershell
.\Setup-Project.ps1
```

---

## 📋 Individual Commands

### ⭐ Smart Update with Version Validation (Recommended)
```powershell
.\Update-ProjectsSmart.ps1
```
**Output:** Version check, project updates, build verification

### Check If NI Software Is Installed
```powershell
.\Quick-Check.ps1
```
**Output:** Green [OK] or Red [X] for each assembly

### Basic Update Project References
```powershell
.\Update-ProjectReferences.ps1
```
**Output:** Updates .csproj with correct paths, creates .backup file

### Find All NI Assemblies (Detailed)
```powershell
.\Find-NIAssemblies.ps1
```
**Output:** Table showing all discovered assemblies with versions

---

## 🔧 Common Tasks

### Use Latest Versions (With Compatibility Check)
```powershell
.\Update-ProjectsSmart.ps1 -PreferStable:$false
```

### Preview Changes Without Applying
```powershell
.\Update-ProjectReferences.ps1 -WhatIf
```

### Update Specific Project
```powershell
.\Update-ProjectReferences.ps1 -ProjectPath "..\src\MyProject\MyProject.csproj"
```

### Export Assembly Paths as JSON
```powershell
.\Find-NIAssemblies.ps1 -OutputFormat Json > assemblies.json
```

### Generate .csproj Reference XML
```powershell
.\Find-NIAssemblies.ps1 -OutputFormat ProjectXml
```

---

## ⚠️ Troubleshooting

### Script Won't Run
```powershell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

### Build Fails After Update
```powershell
cd ..
dotnet clean
cd build-tools
.\Update-ProjectsSmart.ps1  # Validates versions and tests build
cd ..
dotnet build
```

### Version Conflict Errors (CS1705)
```powershell
# Use stable configuration to avoid conflicts
.\Update-ProjectsSmart.ps1 -PreferStable
```

### Check Specific Assembly
```powershell
.\Find-NIAssemblies.ps1 -AssemblyName "NationalInstruments.RFmx.WlanMX.Fx40"
```

---

## 📦 Required NI Software

| Package | Min Version | Purpose |
|---------|-------------|---------|
| NI-RFmx WLAN | 23.0 | WLAN RF measurements |
| NI-RFSG | 23.0 | Signal generation |
| IVI Shared Components | 2.0 | IVI driver framework |

**Download:** https://www.ni.com/en-us/support/downloads.html

---

## 📚 Documentation

| File | Purpose |
|------|---------|
| `QUICKSTART.md` | 3-step setup guide |
| `README.md` | Complete tool documentation |
| `SETUP_NEW_MACHINE.md` | Detailed installation guide |
| `DEPENDENCY_MANAGEMENT_SKILL.md` | Technical implementation details |

---

## 🎯 Typical Workflow

```
New Machine Setup:
  1. Clone repo
  2. cd build-tools
  3. .\Setup-Project.ps1
  4. Done! ✅

After NI Software Update:
  1. cd build-tools
  2. .\Update-ProjectReferences.ps1
  3. cd ..
  4. dotnet clean
  5. dotnet build

Troubleshooting:
  1. cd build-tools
  2. .\Quick-Check.ps1 (verify installation)
  3. .\Find-NIAssemblies.ps1 (see details)
  4. .\Update-ProjectReferences.ps1 (reconfigure)
```

---

## 💡 Pro Tips

- Run `Quick-Check.ps1` first to save time
- Use `-WhatIf` to preview changes safely
- Keep VS closed when running `Update-ProjectReferences.ps1`
- Delete bin/obj folders if build fails after update
- The scripts always use the newest NI version found

---

## 🆘 Need Help?

1. **Quick answers:** See `QUICKSTART.md`
2. **Detailed info:** See `README.md`  
3. **Full setup:** See `SETUP_NEW_MACHINE.md`
4. **Technical:** See `DEPENDENCY_MANAGEMENT_SKILL.md`
5. **NI Support:** https://www.ni.com/support

---

**Print this card and keep it handy!** 📄
