# GitHub Copilot Skills

This folder contains AI-readable context files that help GitHub Copilot and other AI assistants understand the project's dependency management solution.

## Skills Available

### 1. Dependency Management (`skills/dependency-management.md`)
**Primary AI Skill** - Complete technical guide explaining:
- The NI dependency problem and solution architecture
- How the PowerShell automation tools work
- Version compatibility patterns and validation logic
- File structure and tool relationships

**Use Case**: When AI needs to help with NI assembly references, build errors, or modify the automation tools.

---

### 2. Dependency Status (`skills/dependency-status.md`)
**Current State Reference** - Documents:
- Which projects have been fixed
- What assembly versions are currently used
- Known working configurations (v23.8 stable setup)

**Use Case**: When AI needs to know the current state of the project.

---

### 3. Dependency Completion (`skills/dependency-completion.md`)
**Checklist & Summary** - Contains:
- What tasks have been completed
- Verification checklist for the solution
- Summary of all created files

**Use Case**: When AI needs to verify completeness or continue unfinished work.

---

### 4. Dependency History (`skills/dependency-history.md`)
**Historical Context** - Records:
- Initial problem discovery process
- Evolution of the solution
- Decisions made along the way

**Use Case**: When AI needs to understand why certain approaches were chosen.

---

## How AI Uses These Skills

When you ask GitHub Copilot questions like:
- "Help me fix NI dependency errors"
- "Update the project for a new NI version"
- "Why is the build failing with CS1705?"

Copilot can read these skill files to:
1. Understand the existing solution
2. Provide contextually accurate help
3. Suggest changes that align with established patterns
4. Avoid repeating past mistakes

---

## For Developers

You typically **don't need to read these files directly**. They're written for AI consumption.

Instead, refer to:
- `build-tools/QUICKSTART.md` - Quick start guide
- `build-tools/QUICK_REFERENCE.md` - Command cheat sheet
- `build-tools/README.md` - Comprehensive tool documentation
- `docs/SETUP_NEW_MACHINE.md` - New developer onboarding
- `docs/GIT_SAFETY_GUIDE.md` - Git best practices

---

## Maintaining Skills

When you make significant changes to the dependency management solution:
1. Update relevant skill files to reflect changes
2. Keep `dependency-status.md` current with actual project state
3. Add new skills if you create new automation patterns

This ensures future AI assistance remains accurate and helpful.
