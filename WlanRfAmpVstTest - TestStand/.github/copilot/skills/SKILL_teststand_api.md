---
name: teststand-api
description: >
  Generate correct Python code for programmatic TestStand automation using the TestStand COM API
  via win32com / pywin32. Covers Engine lifecycle, creating and loading sequence files, adding and
  configuring steps (Action, NumericLimitTest, PassFailTest, StringValueTest, MultipleNumericLimitTest,
  CallExecutable), setting step properties via PropertyObject paths, launching and monitoring executions,
  collecting results, and report generation. Use this skill whenever the user mentions TestStand,
  TestStand API, TestStand Engine, SequenceFile, Sequence, Step, Execution, PropertyObject,
  TestStand COM, win32com TestStand, test sequence creation, sequence execution, test automation,
  TestStand Python, step type, code module, run sequence, or asks to programmatically create,
  load, modify, execute, or monitor TestStand sequences — especially in the context of a CLI,
  agent, or automated workflow driving real hardware tests.
---

# TestStand API Skill — Python COM Automation

This skill helps generate correct Python code for automating NI TestStand via its COM API.
It prevents common AI code generation mistakes by encoding the actual COM object model,
property path syntax, step type configuration, execution lifecycle, and result extraction
patterns from the TestStand API.

## Why this skill exists

LLMs frequently hallucinate TestStand COM API details: inventing method names that don't exist,
using wrong property path syntax, misunderstanding the Engine lifecycle, confusing SequenceFile
objects with Sequence objects, or producing code that crashes with inscrutable COM errors.
The TestStand API is a large COM object model with non-obvious conventions (e.g., PropertyObject
path syntax uses `.` not `/`, step types are created by name string, adapters must be set before
module configuration). This skill provides ground-truth patterns so generated code works on
first run against a real TestStand installation.

## Supported Reference Files

| Topic                        | Reference File                        | Status    |
|------------------------------|---------------------------------------|-----------|
| Engine, SequenceFile, Steps  | references/teststand_engine.md        | ✅ Active |
| Execution, Results, Reports  | references/teststand_execution.md     | ✅ Active |

**When the user asks about TestStand, read the corresponding reference file(s) before generating code.**

## Universal Patterns (All TestStand COM Automation)

### Installation

TestStand Python automation uses the COM API via `pywin32`:

```
pip install pywin32
```

Requirements:
- NI TestStand must be installed on the system (2021 SP1 or later recommended)
- The TestStand Engine COM server is registered automatically during TestStand installation
- Python must match the TestStand bitness (64-bit Python for 64-bit TestStand)

### COM Initialization

Python COM automation requires proper COM threading initialization. **Always call
`pythoncom.CoInitialize()` at the start of any thread that uses TestStand COM objects.**

```python
import pythoncom
import win32com.client

# CORRECT: Initialize COM before creating any COM objects
pythoncom.CoInitialize()
try:
    engine = win32com.client.Dispatch("TestStand.Engine.1")
    # ... use engine ...
finally:
    # Release COM objects before uninitializing
    engine = None
    pythoncom.CoUninitialize()
```

### Engine Lifecycle

The TestStand Engine is the root object for all TestStand automation. There should be
**exactly one Engine instance per process**. The Engine must be properly shut down before
the process exits.

```python
import pythoncom
import win32com.client

pythoncom.CoInitialize()

engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    # Use the engine...
    pass
finally:
    # CRITICAL: Shut down the engine before releasing
    engine.UIMessagePollingEnabled = False
    engine.ShutDown()
    engine = None
    pythoncom.CoUninitialize()
```

### SequenceFile and Sequence Access

```python
# Create a new sequence file
seq_file = engine.NewSequenceFile()

# Access the default "MainSequence"
main_seq = seq_file.SequenceByName("MainSequence")

# Or create a new named sequence
seq_file.InsertNewSequence("MyCustomSequence", 0)
custom_seq = seq_file.SequenceByName("MyCustomSequence")
```

### Adding Steps

Steps are added to a sequence's step group (Setup, Main, Cleanup):

```python
# Get the step group
main_steps = main_seq.GetStepByGroup(1)  # 0=Setup, 1=Main, 2=Cleanup

# Insert a new step of a given type
step_type = engine.GetStepTypeByName("NumericLimitTest")
new_step = main_seq.InsertStep(step_type, 1, -1)  # group=Main, position=-1 (append)
new_step.Name = "Measure Voltage"
```

### PropertyObject Path Syntax

TestStand uses dot-separated paths to access nested properties:

```python
# Step-level properties
step.AsPropertyObject().SetValString("Step.Description", 1, "My step description")

# Result properties (read after execution)
result = step.AsPropertyObject().GetValNumber("Result.Numeric", 0)

# Locals
step.AsPropertyObject().SetValNumber("Locals.MyVar", 1, 42.0)
```

### Execution Launch and Wait

```python
# Run MainSequence in the file
execution = engine.NewExecution(
    seq_file,                    # SequenceFile
    "MainSequence",              # Sequence name
    None,                        # SequenceContext (None for new)
    False,                       # breakAtFirstStep
    0                            # executionTypeMask
)

# Wait for execution to complete
while execution.IsRunning:
    pythoncom.PumpWaitingMessages()  # Process COM messages

# Get result status
result_status = execution.ResultStatus
print(f"Execution completed with status: {result_status}")
```

## Workflow Patterns

### Pattern 1: Create and Execute a Simple Sequence

Create a sequence file from scratch, add test steps, execute, and collect results.
This is the most common pattern for an AI agent driving hardware tests.
Read `references/teststand_engine.md` for step type details and `references/teststand_execution.md`
for execution monitoring.

### Pattern 2: Load, Modify, and Run an Existing Sequence

Load a `.seq` file from disk, modify step parameters (limits, module paths, variables),
then execute. Useful for parameterized testing where the sequence template exists but
the agent adjusts test conditions dynamically.

### Pattern 3: Execution Monitoring and Result Collection

Launch an execution, poll for status, and extract structured results (pass/fail,
numeric measurements, step-level details) for reporting back to the agent/CLI.
Read `references/teststand_execution.md` for the full result extraction patterns.

### Pattern 4: Multi-Sequence Orchestration

Run multiple sequences in order — e.g., a setup sequence, multiple DUT test sequences
with different parameters, and a cleanup sequence. Manage Engine and SequenceFile
objects across runs.

### Pattern 5: Integration with NI Instrument Code Modules

Configure steps that call Python code modules (your NI instrument driver code) as
test steps within a TestStand sequence. The Python Adapter routes calls to your
measurement functions while TestStand handles sequencing, limits, and results.

## Common Mistakes to Avoid

1. **Forgetting `pythoncom.CoInitialize()`**: Every thread that uses COM objects must call this.
   Without it, you get cryptic `CoInitialize has not been called` errors.

2. **Not shutting down the Engine**: If the Engine isn't shut down properly (`engine.ShutDown()`),
   TestStand processes orphan and lock files. Always use try/finally.

3. **Wrong property path syntax**: TestStand uses `"Step.Description"`, not `"Step/Description"`
   or `"step.description"`. Paths are case-sensitive and dot-separated.

4. **Confusing SequenceFile vs. Sequence**: A SequenceFile contains multiple Sequences.
   You must get the Sequence object (e.g., `seq_file.SequenceByName("MainSequence")`) before
   adding steps — you can't add steps directly to a SequenceFile.

5. **Wrong step group index**: Setup=0, Main=1, Cleanup=2. Using the wrong index puts
   steps in the wrong phase.

6. **Not setting the adapter before configuring the module**: The step's adapter type
   (Python, LabVIEW, DLL, etc.) must be set before configuring module-specific properties
   like the module path or function name.

7. **Blocking the COM message pump**: Long-running executions require calling
   `pythoncom.PumpWaitingMessages()` in the wait loop. Without it, COM callbacks
   and UI messages are blocked, potentially causing deadlocks.

8. **Creating multiple Engine instances**: The TestStand Engine is designed as a singleton
   per process. Creating multiple instances causes undefined behavior.

9. **Using `Dispatch` vs `EnsureDispatch`**: Use `win32com.client.Dispatch` for late binding
   (simpler, always works). `EnsureDispatch` generates early-bound wrappers but can cause
   cache issues. Late binding is recommended for automation scripts.

10. **Forgetting to save the SequenceFile**: After modifying a sequence programmatically,
    call `seq_file.Save()` or `seq_file.SaveAs(path)` if you need the changes persisted.
    Executions use the in-memory state, so saving is only needed for persistence.

## Integration with CLI / AI Agent

When wrapping TestStand operations for a CLI or AI agent, follow these patterns:

### Engine as a Managed Resource

```python
class TestStandManager:
    """Manages a single TestStand Engine instance for CLI/agent use."""

    def __init__(self):
        pythoncom.CoInitialize()
        self.engine = win32com.client.Dispatch("TestStand.Engine.1")

    def close(self):
        if self.engine:
            self.engine.UIMessagePollingEnabled = False
            self.engine.ShutDown()
            self.engine = None
        pythoncom.CoUninitialize()

    def __enter__(self):
        return self

    def __exit__(self, *args):
        self.close()
```

### Structured Result Extraction

```python
def get_execution_results(execution) -> dict:
    """Extract structured results from a completed execution."""
    result = {
        "status": execution.ResultStatus,
        "elapsed_time": execution.ElapsedTime,
        "num_steps": execution.NumSteps,
        "error": None,
    }
    if execution.ErrorOccurred:
        result["error"] = execution.ErrorMessage
    return result
```

## Adding New Reference Files

To extend this skill for additional TestStand API areas (UI Controls, Synchronization,
Semiconductor Module), create a reference file at `references/teststand_<topic>.md` with:

1. **Key classes and their COM ProgIDs** (if applicable)
2. **Essential properties** with types and valid values
3. **Core methods** with signatures and return types
4. **PropertyObject paths** for the topic's data structures
5. **Canonical code examples** for the 3-5 most common workflows
6. **Topic-specific gotchas** (7-10 items)

Then update the Supported Reference Files table in this file.
