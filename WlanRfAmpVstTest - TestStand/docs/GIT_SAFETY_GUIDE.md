# Git Branch Protection - Preventing Accidental Reverts

## What Happened

The project files (.csproj) were accidentally reverted, losing the NI assembly path fixes. This has now been resolved.

## ✅ Current Status (After Reapplication)

All three projects have been fixed again:
- **WlanRfAmpTest.Instrument** - 7 NI assemblies configured (v23.8)
- **WlanRfAmpTest.Validation** - 1 NI assembly configured (v23.8)
- **WlanRfAmpTest.Sequencer** - 1 NI assembly configured (v23.8)

**Build Status:** ✅ Successful

## 🛡️ How to Protect Your Changes

### Before Any Git Operations

Always check what files will be affected:

```powershell
# See what would change
git status

# See differences before reverting
git diff

# If you want to discard changes, be specific about files
git restore -- specific-file.txt

# AVOID: git restore . (reverts everything!)
```

### Safe Git Workflow

```powershell
# 1. Check current status
git status

# 2. Stage only the files you want
git add build-tools/
git add *.md

# 3. Commit with descriptive message
git commit -m "Add: NI dependency management tools and documentation"

# 4. Push to your branch
git push origin jon
```

### If You Need to Discard Changes

**For specific files only:**
```powershell
git restore -- path/to/unwanted-file.txt
```

**For project files (CAREFUL!):**
```powershell
# Don't do this unless you're sure!
git restore -- src/**/*.csproj
```

### To Recover from Accidental Revert

If you accidentally revert the .csproj files again:

**Quick Fix (2 minutes):**
```powershell
cd build-tools
.\Update-AllProjects.ps1
cd ..
dotnet restore
dotnet build
```

The tool will automatically reconfigure all projects with the correct paths.

## 📝 What Should Be Committed

### ✅ Commit These Files:
- `build-tools/*.ps1` - All PowerShell scripts
- `build-tools/*.md` - All documentation
- `*.md` - Root documentation files
- `src/**/*.csproj` - Updated project files (IMPORTANT!)

### ❌ Don't Commit These:
- `bin/` folders
- `obj/` folders
- `*.backup` files
- `*.user` files
- `.vs/` folder

## 🔍 Checking What Changed

Before committing, review your changes:

```powershell
# See all changed files
git status

# See detailed changes
git diff

# See changes in specific file
git diff src/WlanRfAmpTest.Instrument/WlanRfAmpTest.Instrument.csproj
```

Look for:
- ✅ HintPath changes (from old paths to new paths)
- ✅ Version changes (from v25.5 to v23.8)
- ❌ Accidental file deletions
- ❌ Unintended changes

## 🚨 Emergency Recovery Commands

### If You Accidentally Reverted Everything:

```powershell
# Option 1: Use the automated tool (FASTEST)
cd build-tools
.\Update-AllProjects.ps1
cd ..
dotnet restore
dotnet build

# Option 2: Restore from git if you committed before
git log --oneline -10  # Find your commit hash
git checkout <commit-hash> -- src/**/*.csproj

# Option 3: Manually re-run all fixes (SLOWEST)
# See ALL_DEPENDENCIES_FIXED.md for manual steps
```

## 📦 Create a Safety Commit Now

Commit your current working state:

```powershell
# Add all the build tools and docs
git add build-tools/
git add *.md

# Add the fixed project files
git add src/WlanRfAmpTest.Instrument/WlanRfAmpTest.Instrument.csproj
git add src/WlanRfAmpTest.Validation/WlanRfAmpTest.Validation.csproj
git add src/WlanRfAmpTest.Sequencer/WlanRfAmpTest.Sequencer.csproj

# Commit with clear message
git commit -m "Fix: Update NI assembly references for local system (v23.8)

- Configure WlanRfAmpTest.Instrument with all 7 NI assemblies
- Update WlanRfAmpTest.Validation with RFmx WLAN
- Update WlanRfAmpTest.Sequencer with RFmx WLAN
- Add automated dependency management tools in build-tools/
- Add comprehensive documentation for setup

All projects now build successfully on this system."

# Push to your branch
git push origin jon
```

## 💡 Pro Tips

### Visual Studio Git Integration

1. **Solution Explorer**: Right-click files → "View History" to see changes
2. **Git Changes Window**: `View → Git Changes` (Ctrl+0, G)
3. **Git Repository Window**: `View → Git Repository` (Ctrl+0, R)

### Using VS Git Changes Window

✅ **Best Practice:**
- Review each file before committing
- Uncheck files you don't want to commit
- Write descriptive commit messages

### Preventing Future Issues

1. **Before Git operations**: Run `dotnet build` to ensure everything works
2. **After Git operations**: Run `dotnet build` to verify nothing broke
3. **Use branches**: Work on feature branches, not main
4. **Commit often**: Small, frequent commits are easier to recover from

## 🔄 Quick Recovery Process

If you revert again (copy-paste these commands):

```powershell
cd build-tools
.\Update-AllProjects.ps1 -Backup $false
cd ..
dotnet clean
dotnet restore
dotnet build
```

**Time to recover:** ~2 minutes

## ✅ Verification

After any git operations, verify your setup:

```powershell
# Check build works
dotnet build

# Should see:
# Build succeeded.
#     0 Warning(s)
#     0 Error(s)
```

## 📚 Related Documentation

- `build-tools/QUICKSTART.md` - Fast recovery guide
- `ALL_DEPENDENCIES_FIXED.md` - What was fixed
- `QUICK_REFERENCE.md` - Command cheat sheet

---

**Remember:** The `Update-AllProjects.ps1` tool can always restore your configuration in ~2 minutes. Keep the build-tools folder safe!

**Status:** ✅ All fixes reapplied and verified  
**Build:** ✅ Successful  
**Safety Net:** ✅ Automated recovery tool available
