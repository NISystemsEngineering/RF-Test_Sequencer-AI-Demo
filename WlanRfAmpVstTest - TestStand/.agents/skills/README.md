# Skills Configuration

This directory (`.agents/skills/`) is configured to use skills from the git submodule instead of auto-loaded local copies.

## Current Configuration

### Skills Source: Git Submodule
All skills are now sourced from: `../../Skills_Dev_NICon-2026/.agents/skills/`

This provides:
- ✅ Version control for all skills
- ✅ Team synchronization
- ✅ Ability to update skills independently
- ✅ Consistent skill versions across projects

### Custom Local Skills

Only custom, project-specific skills should remain in this directory:

- **`nisyscfg-equipment-discovery/`** - Enhanced with project-specific error handling patterns

## Available Skills from Submodule

Located in: `../../Skills_Dev_NICon-2026/.agents/skills/`

1. **measurement-plugin** - NI measurement plugin framework
2. **ni-datastore-query-odata** - Query NI DataStore with OData
3. **ni-dependency-management** - PowerShell automation for assembly references
4. **ni-hw-drivers** - General NI hardware driver knowledge
5. **ni-hw-drivers-csharp** - C# driver APIs and patterns
6. **ni-measurement-data-services** - NI MDS/TDMS file handling
7. **nisyscfg-equipment-discovery** - Hardware scanning with nisyscfg
8. **teststand-api** - TestStand API automation
9. **teststand-grpc** - TestStand gRPC integration

## How GitHub Copilot Finds Skills

GitHub Copilot searches for skills in multiple locations:

1. **Local `.agents/skills/`** - Custom project skills
2. **Submodule `Skills_Dev_NICon-2026/.agents/skills/`** - Shared skills
3. **`.copilot/skills/`** - Legacy custom skills
4. **`.github/copilot/skills/`** - Original repo skills

All locations are scanned and merged, so skills from the submodule are automatically available.

## Updating Skills

### To update submodule skills to latest:
```powershell
cd "Skills_Dev_NICon-2026"
git pull origin main
cd ..
git add Skills_Dev_NICon-2026
git commit -m "Update skills submodule"
git push
```

### To add a new custom skill:
1. Create folder in `.agents/skills/your-skill-name/`
2. Add `SKILL.md` file with skill content
3. Commit to this repository

## Maintenance

### Auto-loaded Skills are Blocked
The `.gitignore` in this directory prevents auto-loaded Copilot skills from being committed. Only custom skills should be version-controlled here.

### Prefer Submodule Skills
When a skill exists in both locations:
- Submodule version is canonical (version-controlled)
- Local version is only for project-specific customizations

## Benefits

✅ **Consistency** - All team members use same skill versions  
✅ **Updates** - Skills can be updated via git submodule  
✅ **Sharing** - Multiple projects can reference same skills  
✅ **Version Control** - Skills are tracked and can be rolled back  
✅ **Collaboration** - Team can contribute to shared skills repository  

## Current Setup (2026-04-24)

- ✅ Auto-loaded skills removed from local folder
- ✅ Custom `nisyscfg-equipment-discovery` skill retained
- ✅ Submodule provides 9 shared skills
- ✅ Configuration documented
- ✅ .gitignore configured to block auto-loaded skills

---

**For questions about skill management, see:** `../../docs/GIT_SUBMODULE_SKILLS.md`
