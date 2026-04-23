# TestStand Engine Reference — Creating and Configuring Sequences

**COM ProgID**: `TestStand.Engine.1`
**Automation Interface**: `IEngine`
**Requires**: NI TestStand 2021 SP1+ installed, `pywin32` (`pip install pywin32`)
**Python Bitness**: Must match TestStand installation (typically 64-bit)
**Source**: [NI TestStand API Reference](https://www.ni.com/docs/en-US/bundle/teststand-api-reference/page/tsapiref/teststand-api-overview-poster.html)

## Table of Contents

1. [Engine Creation and Shutdown](#engine-creation-and-shutdown)
2. [SequenceFile Operations](#sequencefile-operations)
3. [Sequence Operations](#sequence-operations)
4. [Step Types](#step-types)
5. [Adding and Configuring Steps](#adding-and-configuring-steps)
6. [PropertyObject — Reading and Writing Properties](#propertyobject--reading-and-writing-properties)
7. [Python Adapter Configuration](#python-adapter-configuration)
8. [Canonical Examples](#canonical-examples)
9. [Advanced Topics](#advanced-topics)
10. [Engine & Sequence Gotchas](#engine--sequence-gotchas)

---

## Engine Creation and Shutdown

The `Engine` is the root COM object for all TestStand automation. It manages sequence files,
step types, adapters, station globals, and executions.

### Creating the Engine

```python
import pythoncom
import win32com.client

# Initialize COM on the current thread
pythoncom.CoInitialize()

# Create the TestStand Engine (late-bound)
engine = win32com.client.Dispatch("TestStand.Engine.1")
```

### Engine Properties

| Property                    | Type   | Description                                         |
|-----------------------------|--------|-----------------------------------------------------|
| `MajorVersion`              | int    | TestStand major version number                       |
| `MinorVersion`              | int    | TestStand minor version number                       |
| `UIMessagePollingEnabled`   | bool   | Enable/disable UI message polling (set False before shutdown) |
| `StationGlobals`            | object | PropertyObject containing station-level variables    |
| `NumStepTypes`              | int    | Number of registered step types                      |
| `NumAdapterKeyNames`        | int    | Number of registered adapter key names               |

### Engine Methods

| Method                         | Returns        | Description                                                   |
|--------------------------------|----------------|---------------------------------------------------------------|
| `NewSequenceFile()`            | SequenceFile   | Create a new empty sequence file                              |
| `GetSequenceFileEx(path)`      | SequenceFile   | Load a sequence file from disk                                |
| `ReleaseSequenceFileEx(sf)`    | None           | Release a sequence file from the engine's cache               |
| `LoadTypePaletteFiles()`       | None           | Load built-in step type palettes — **must call before NewStep** |
| `NewStep(adapterName, typeName)` | Step         | Create a new step (adapterName='' for None adapter)           |
| `NewExecution(...)`            | Execution      | Create and start a new execution                              |
| `ShutDown(0)`                  | None           | Shut down the engine — must be called before process exit     |
| `NumAdapters`                  | int            | Number of registered module adapters                          |
| `GetAdapter(index)`            | Adapter        | Get an adapter by index                                       |

### Proper Shutdown Pattern

```python
import pythoncom
import win32com.client

pythoncom.CoInitialize()
engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    # ---- Your automation code here ----
    pass
finally:
    # CRITICAL: Always shut down the engine
    if engine:
        engine.UIMessagePollingEnabled = False
        engine.ShutDown(0)
        engine = None
    pythoncom.CoUninitialize()
```

> **Warning**: If you skip `ShutDown()`, TestStand processes remain running in the background,
> locking sequence files and consuming resources. Always use try/finally or a context manager.

---

## SequenceFile Operations

A `SequenceFile` represents a `.seq` file (in memory or on disk). It contains one or more
`Sequence` objects, file globals, and file version information.

### Creating a New SequenceFile

```python
seq_file = engine.NewSequenceFile()

# A new SequenceFile automatically contains a "MainSequence" sequence
main_seq = seq_file.GetSequenceByName("MainSequence")
```

### Loading an Existing SequenceFile

```python
# Load from disk (absolute path required)
seq_file = engine.GetSequenceFileEx(
    r"C:\TestStand\Sequences\MyTest.seq",
    0,    # GetSeqFileFlags: 0 = default
    0     # TypeConflictFlags: 0 = default
)

# Access sequences in the loaded file
main_seq = seq_file.GetSequenceByName("MainSequence")
```

### Saving a SequenceFile

```python
# Save to a path
seq_file.Save(r"C:\TestStand\Sequences\NewTest.seq")
```

### SequenceFile Properties

| Property                | Type   | Description                                       |
|-------------------------|--------|---------------------------------------------------|
| `Path`                  | str    | Full file path (empty if never saved)             |
| `NumSequences`          | int    | Number of sequences in the file                   |
| `Locals`                | object | File-level local variables (PropertyObject)       |
| `AsPropertyObject()`    | object | Access the SequenceFile as a PropertyObject       |
| `Modified`              | bool   | True if the file has unsaved changes              |

### SequenceFile Methods

| Method                                    | Returns    | Description                                 |
|-------------------------------------------|------------|---------------------------------------------|
| `GetSequenceByName(name)`                 | Sequence   | Get a sequence by name                      |
| `GetSequence(index)`                      | Sequence   | Get a sequence by index                     |
| `InsertNewSequence(name, position)`       | Sequence   | Create and insert a new sequence            |
| `Save(path)`                              | None       | Save to the specified path                  |
| `AsPropertyObject()`                      | PropertyObject | Access file as PropertyObject          |

---

## Sequence Operations

A `Sequence` is a named container of steps organized into three groups:
Setup (0), Main (1), and Cleanup (2).

### Accessing Sequences

```python
# By name
main_seq = seq_file.GetSequenceByName("MainSequence")

# By index
first_seq = seq_file.GetSequence(0)

# Create a new sequence
seq_file.InsertNewSequence("InitializeHardware", 0)
init_seq = seq_file.GetSequenceByName("InitializeHardware")
```

### Sequence Properties

| Property                | Type   | Description                                       |
|-------------------------|--------|---------------------------------------------------|
| `Name`                  | str    | Sequence name                                     |
| `NumSteps(group)`       | int    | Number of steps in a step group (0/1/2)           |
| `Locals`                | object | Sequence-level local variables (PropertyObject)   |
| `Parameters`            | object | Sequence parameters (PropertyObject)              |

### Step Group Constants

| Constant | Group   | Description                                      |
|----------|---------|--------------------------------------------------|
| 0        | Setup   | Runs before Main; used for initialization        |
| 1        | Main    | Primary test steps                               |
| 2        | Cleanup | Runs after Main (even if Main fails); teardown   |

### Getting Steps from a Sequence

```python
# Get step count in Main group
num_main_steps = main_seq.GetNumSteps(1)

# Get a specific step by index within a group
step = main_seq.GetStep(1, 0)  # group=Main, index=0

# Iterate all Main steps
for i in range(main_seq.GetNumSteps(1)):
    step = main_seq.GetStep(1, i)
    print(f"Step {i}: {step.Name}")
```

---

## Step Types

TestStand provides built-in step types for common test operations. Each step type
defines a set of properties, a default adapter configuration, and result handling behavior.

### Common Step Types

| Step Type Name              | Purpose                                              | Key Properties                |
|-----------------------------|------------------------------------------------------|-------------------------------|
| `Action`                    | Call a code module, no built-in result evaluation     | Module path, function name    |
| `NumericLimitTest`          | Call code module, compare numeric result to limits    | Low/High limits, comparison   |
| `StringValueTest`           | Call code module, compare string result to expected   | Expected string, comparison   |
| `PassFailTest`              | Call code module, evaluate boolean pass/fail result   | Pass expression               |
| `MultipleNumericLimitTest`  | Multiple numeric measurements with individual limits  | Array of limit specs          |
| `NoneStep`                  | Placeholder step, executes no module                  | (none)                        |
| `Statement`                 | Execute a TestStand expression                        | Expression string             |
| `Label`                     | A label target for GoTo jumps                         | Label name                    |
| `GoTo`                      | Jump to a label                                       | Target label                  |
| `MessagePopup`              | Display a message to the operator                     | Title, message text           |
| `CallExecutable`            | Run an external .exe                                  | Executable path, arguments    |
| `SequenceCall`              | Call another sequence (same or different file)         | Sequence name, file path      |

### Creating Steps (v26.0+)

In TestStand v26.0, step types are accessed via `Engine.NewStep()` after loading
type palette files. The `NewStep(adapterName, stepTypeName)` method returns a
configured Step object directly.

```python
# REQUIRED: Load type palettes before creating steps
engine.LoadTypePaletteFiles()

# Create steps with no adapter (for built-in step types)
action_step = engine.NewStep('', 'Action')
nlt_step = engine.NewStep('', 'NumericLimitTest')
pf_step = engine.NewStep('', 'PassFailTest')
stmt_step = engine.NewStep('', 'Statement')
msg_step = engine.NewStep('', 'MessagePopup')
seq_call_step = engine.NewStep('', 'SequenceCall')

# adapterName='' means the <None> adapter (built-in steps)
# Use adapter DisplayNames from engine.GetAdapter(i).DisplayName to find others
# Available adapters: LabVIEW, LabWindows/CVI, C/C++ DLL, .NET, ActiveX/COM,
#                     Sequence, <None>, LabVIEW NXG, Python, HTBasic
```

---

## Adding and Configuring Steps

### Inserting a Step

```python
# Create the step
engine.LoadTypePaletteFiles()
step = engine.NewStep('', 'NumericLimitTest')
step.Name = "Measure Output Voltage"

# Insert into a sequence: InsertStep(step, index, stepGroup)
#   stepGroup: 0=Setup, 1=Main, 2=Cleanup
#   index: position within the group (0 = first)
main_seq.InsertStep(step, 0, 1)  # Insert at index 0 in Main group
```

### Configuring a NumericLimitTest Step

```python
step = engine.NewStep('', 'NumericLimitTest')
step.Name = "Check Voltage"

# Access step as PropertyObject to set properties
step_po = step.AsPropertyObject()

# Set comparison type: 0=EQ, 1=NE, 2=GT, 3=GE, 4=LT, 5=LE, 6=GELE, 7=GELT, 8=GTLE, 9=GTLT
step_po.SetValNumber("Step.InBuf.Limits.CompOp", 1, 6)  # GELE (>=Low, <=High)

# Set limit values
step_po.SetValNumber("Step.InBuf.Limits.Low", 1, 3.2)
step_po.SetValNumber("Step.InBuf.Limits.High", 1, 3.4)

# The numeric data property path for the measured value
# (This is what the code module should write its result to)
# "Step.InBuf.Numeric" — the code module sets this via SequenceContext
```

### NumericLimitTest Comparison Operators

| Value | Name | Description                   |
|-------|------|-------------------------------|
| 0     | EQ   | Equal to                      |
| 1     | NE   | Not equal to                  |
| 2     | GT   | Greater than                  |
| 3     | GE   | Greater than or equal to      |
| 4     | LT   | Less than                     |
| 5     | LE   | Less than or equal to         |
| 6     | GELE | >= Low AND <= High            |
| 7     | GELT | >= Low AND < High             |
| 8     | GTLE | > Low AND <= High             |
| 9     | GTLT | > Low AND < High              |

### Configuring a PassFailTest Step

```python
step = engine.NewStep('', 'PassFailTest')
step.Name = "Verify DUT Present"
main_seq.InsertStep(step, 0, 1)

step_po = step.AsPropertyObject()
# The code module sets Step.Result.PassFail (boolean) 
# PassFailTest evaluates this automatically
```

### Configuring a Statement Step

```python
step = engine.NewStep('', 'Statement')
step.Name = "Set Local Variable"
main_seq.InsertStep(step, 0, 1)

step_po = step.AsPropertyObject()
step_po.SetValString("Step.Expr", 1, 'Locals.TestVoltage = 3.3')
```

### Configuring a SequenceCall Step

```python
step = engine.NewStep('', 'SequenceCall')
step.Name = "Run Calibration"
main_seq.InsertStep(step, 0, 1)

step_po = step.AsPropertyObject()

# Call a sequence in the same file
step_po.SetValString("Step.SequenceName", 1, "CalibrationSequence")

# Or call a sequence in a different file
step_po.SetValString("Step.SequenceFilePath", 1, r"C:\TestStand\Sequences\Calibration.seq")
step_po.SetValString("Step.SequenceName", 1, "MainSequence")
```

### Configuring a MessagePopup Step

```python
step = engine.NewStep('', 'MessagePopup')
step.Name = "Operator Prompt"
main_seq.InsertStep(step, 0, 1)

step_po = step.AsPropertyObject()
step_po.SetValString("Step.TitleExpr", 1, '"Connect DUT"')
step_po.SetValString("Step.MsgExpr", 1, '"Please connect the DUT to port A1 and press OK."')
```

### Deleting and Reordering Steps

```python
# Delete a step: RemoveStep(group, index)
main_seq.RemoveStep(1, 0)  # Remove first Main step

# Get step count
count = main_seq.GetNumSteps(1)
```

---

## PropertyObject — Reading and Writing Properties

The `PropertyObject` interface is the backbone of TestStand data access. Nearly every
TestStand object (Step, Sequence, SequenceFile, Execution, Result) can be accessed
as a PropertyObject to read/write its properties using dot-path syntax.

### Core PropertyObject Methods

| Method                                    | Returns  | Description                                   |
|-------------------------------------------|----------|-----------------------------------------------|
| `GetValString(path, flags)`               | str      | Read a string property                        |
| `SetValString(path, flags, value)`        | None     | Write a string property                       |
| `GetValNumber(path, flags)`               | float    | Read a numeric property                       |
| `SetValNumber(path, flags, value)`        | None     | Write a numeric property                      |
| `GetValBoolean(path, flags)`              | bool     | Read a boolean property                       |
| `SetValBoolean(path, flags, value)`       | None     | Write a boolean property                      |
| `GetValInterface(path, flags)`            | object   | Read a COM interface property                 |
| `SetValInterface(path, flags, value)`     | None     | Write a COM interface property                |
| `GetNumSubProperties(path)`               | int      | Number of sub-properties at path              |
| `GetNthSubPropertyName(path, index)`      | str      | Name of the Nth sub-property                  |
| `Exists(path, flags)`                     | bool     | Check if a property exists                    |
| `NewSubProperty(path, valType, ...)`      | object   | Create a new sub-property                     |
| `DeleteSubProperty(path)`                 | None     | Delete a sub-property                         |

### Flags Parameter

The `flags` parameter (often called `options`) controls behavior:

| Value | Name                 | Description                                     |
|-------|----------------------|-------------------------------------------------|
| 0     | `PropOption_NoOpt`   | No options — read-only, error if not found       |
| 1     | `PropOption_Insert`  | Create the property if it doesn't exist (writes) |

**Rule of thumb**: Use `0` for reads, `1` for writes (to auto-create if needed).

### Common Property Paths

#### Step Properties
| Path                          | Type   | Description                                |
|-------------------------------|--------|--------------------------------------------|
| `Step.Name`                   | str    | Step name                                  |
| `Step.Description`            | str    | Step description                           |
| `Step.StepType`               | str    | Step type name                             |
| `Step.InBuf.Limits.Low`       | float  | Low limit (NumericLimitTest)               |
| `Step.InBuf.Limits.High`      | float  | High limit (NumericLimitTest)              |
| `Step.InBuf.Limits.CompOp`    | int    | Comparison operator (NumericLimitTest)     |
| `Step.InBuf.Numeric`          | float  | Numeric data value (NumericLimitTest)      |
| `Step.Result.PassFail`        | bool   | Pass/fail result (PassFailTest)            |
| `Step.Result.Status`          | str    | Step status string ("Passed"/"Failed"/...) |
| `Step.Result.Error.Code`      | int    | Error code (0 = no error)                  |
| `Step.Result.Error.Msg`       | str    | Error message                              |
| `Step.Expr`                   | str    | Expression (Statement step)                |
| `Step.SequenceName`           | str    | Target sequence (SequenceCall)             |
| `Step.SequenceFilePath`       | str    | Target file (SequenceCall)                 |

#### Sequence Properties
| Path                          | Type   | Description                                |
|-------------------------------|--------|--------------------------------------------|
| `Locals.<varname>`            | varies | Sequence-level local variable              |
| `Parameters.<paramname>`      | varies | Sequence parameter                         |

#### File-Level Properties
| Path                                    | Type   | Description                      |
|-----------------------------------------|--------|----------------------------------|
| `FileGlobals.<varname>`                 | varies | File-level global variable       |
| `StationGlobals.<varname>`              | varies | Station-level global variable    |

### Creating Custom Properties (Local Variables)

```python
# Add a local variable to a sequence
seq_locals = main_seq.Locals

# Add a numeric local
seq_locals.NewSubProperty("TestVoltage", 2, False, "", 0)  # valType 2 = Number
seq_locals.SetValNumber("TestVoltage", 0, 3.3)

# Add a string local
seq_locals.NewSubProperty("DUT_Serial", 8, False, "", 0)   # valType 8 = String
seq_locals.SetValString("DUT_Serial", 0, "SN00001")

# Add a boolean local
seq_locals.NewSubProperty("SkipCalibration", 1, False, "", 0)  # valType 1 = Boolean
seq_locals.SetValBoolean("SkipCalibration", 0, False)
```

### PropertyObject Value Types (for NewSubProperty)

| Value | Type             |
|-------|------------------|
| 0     | Empty/Container  |
| 1     | Boolean          |
| 2     | Number (double)  |
| 3     | String           |
| 5     | Object Reference |
| 8     | String           |

---

## Python Adapter Configuration

To configure a step to call a Python code module, you must set the adapter and module
properties. TestStand's Python Adapter calls Python functions directly.

### Setting Up a Step with the Python Adapter

```python
engine.LoadTypePaletteFiles()
step = engine.NewStep('', 'Action')
step.Name = "Run Python Measurement"
main_seq.InsertStep(step, 0, 1)

step_po = step.AsPropertyObject()

# Set the adapter to Python
# The adapter key name for Python is "Python" or "PythonAdapter"
step_po.SetValString("Step.Adapter.Name", 1, "PythonAdapter")

# Set the Python module path and function
step_po.SetValString("Step.Adapter.PythonModule", 1, r"C:\Tests\my_measurement.py")
step_po.SetValString("Step.Adapter.PythonFunction", 1, "measure_voltage")
```

### Python Code Module Structure

The Python function called by TestStand receives a `SequenceContext` object:

```python
# my_measurement.py — called by TestStand's Python Adapter

def measure_voltage(sequence_context):
    """Called by TestStand. sequence_context provides access to step properties."""
    # Read a parameter
    voltage_target = sequence_context.GetValNumber("Locals.TestVoltage", 0)

    # Perform your measurement (using NI instrument drivers, etc.)
    import nidcpower
    with nidcpower.Session(resource_name="PXI1Slot2/0") as session:
        session.output_function = nidcpower.OutputFunction.DC_VOLTAGE
        session.voltage_level = voltage_target
        session.current_limit = 0.1
        session.source_mode = nidcpower.SourceMode.SINGLE_POINT
        session.measure_when = nidcpower.MeasureWhen.AUTOMATICALLY_AFTER_SOURCE_COMPLETE
        with session.initiate():
            measurements = session.fetch_multiple(count=5)
    
    avg_voltage = sum(m.voltage for m in measurements) / len(measurements)

    # Write the result back to TestStand
    sequence_context.SetValNumber("Step.InBuf.Numeric", 1, avg_voltage)

    # Return 0 for success, non-zero for error
    return 0
```

---

## Canonical Examples

### Example 1: Create and Execute a Minimal Sequence

```python
"""Create a TestStand sequence with a Statement step, execute it, get results."""
import pythoncom
import win32com.client
import time

pythoncom.CoInitialize()
engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    # Create a new sequence file
    seq_file = engine.NewSequenceFile()
    main_seq = seq_file.GetSequenceByName("MainSequence")

    # Add a local variable
    main_seq.Locals.NewSubProperty("Result", 2, False, "", 0)  # Number

    # Load type palettes and add a Statement step
    engine.LoadTypePaletteFiles()
    step = engine.NewStep('', 'Statement')
    step.Name = "Set Result Value"
    step.AsPropertyObject().SetValString("Step.Expr", 1, "Locals.Result = 42")
    main_seq.InsertStep(step, 0, 1)  # index 0, Main group

    # Execute the sequence
    execution = engine.NewExecution(
        seq_file,          # sequenceFileParam
        "MainSequence",    # sequenceNameParam
        None,              # executionObject (None = new)
        False,             # breakAtFirstStep
        0                  # executionTypeMask
    )

    # Wait for completion
    while execution.IsRunning:
        pythoncom.PumpWaitingMessages()
        time.sleep(0.1)

    # Check result
    print(f"Status: {execution.ResultStatus}")
    print(f"Elapsed: {execution.ElapsedTime:.2f}s")

finally:
    engine.UIMessagePollingEnabled = False
    engine.ShutDown(0)
    engine = None
    pythoncom.CoUninitialize()
```

### Example 2: Load a Sequence, Modify Limits, Execute

```python
"""Load an existing .seq file, adjust numeric limits, and run."""
import pythoncom
import win32com.client
import time

pythoncom.CoInitialize()
engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    # Load the sequence file
    seq_file = engine.GetSequenceFileEx(
        r"C:\TestStand\Sequences\VoltageTest.seq", 0, 0
    )
    main_seq = seq_file.GetSequenceByName("MainSequence")

    # Find the step named "Check Voltage" and update its limits
    for i in range(main_seq.GetNumSteps(1)):
        step = main_seq.GetStep(1, i)
        if step.Name == "Check Voltage":
            step_po = step.AsPropertyObject()
            step_po.SetValNumber("Step.InBuf.Limits.Low", 1, 4.9)
            step_po.SetValNumber("Step.InBuf.Limits.High", 1, 5.1)
            print(f"Updated limits for '{step.Name}': [4.9, 5.1]")
            break

    # Execute
    execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)

    while execution.IsRunning:
        pythoncom.PumpWaitingMessages()
        time.sleep(0.1)

    print(f"Result: {execution.ResultStatus}")

    # Release the sequence file
    engine.ReleaseSequenceFileEx(seq_file, 0)

finally:
    engine.UIMessagePollingEnabled = False
    engine.ShutDown(0)
    engine = None
    pythoncom.CoUninitialize()
```

### Example 3: Build a Multi-Step Test Sequence with NumericLimitTest

```python
"""Build a complete voltage sweep test sequence from scratch."""
import pythoncom
import win32com.client
import time

pythoncom.CoInitialize()
engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    seq_file = engine.NewSequenceFile()
    main_seq = seq_file.GetSequenceByName("MainSequence")

    # Add sequence-level local variables
    locals_po = main_seq.Locals
    locals_po.NewSubProperty("DUT_ID", 8, False, "", 0)
    locals_po.SetValString("DUT_ID", 0, "DUT-001")

    # Load type palettes
    engine.LoadTypePaletteFiles()

    # --- Setup group: initialization step ---
    setup_step = engine.NewStep('', 'MessagePopup')
    setup_step.Name = "Operator Setup"
    setup_po = setup_step.AsPropertyObject()
    setup_po.SetValString("Step.TitleExpr", 1, '"Test Setup"')
    setup_po.SetValString("Step.MsgExpr", 1, '"Connect DUT to test fixture and press OK."')
    main_seq.InsertStep(setup_step, 0, 0)  # index 0, Setup group

    # --- Main group: multiple voltage test points ---
    test_points = [
        ("1.8V Rail", 1.8, 1.71, 1.89),
        ("3.3V Rail", 3.3, 3.135, 3.465),
        ("5.0V Rail", 5.0, 4.75, 5.25),
    ]

    nlt_step = engine.NewStep('', 'NumericLimitTest')
    for idx, (name, nominal, low, high) in enumerate(test_points):
        step = engine.NewStep('', 'NumericLimitTest')
        step.Name = f"Measure {name}"
        step_po = step.AsPropertyObject()
        step_po.SetValNumber("Step.InBuf.Limits.CompOp", 1, 6)  # GELE
        step_po.SetValNumber("Step.InBuf.Limits.Low", 1, low)
        step_po.SetValNumber("Step.InBuf.Limits.High", 1, high)
        step_po.SetValString("Step.Description", 1,
                             f"Verify {name} is within ±5% of {nominal}V")
        main_seq.InsertStep(step, idx, 1)  # insert into Main group

    # --- Cleanup group: teardown step ---
    cleanup_step = engine.NewStep('', 'Statement')
    cleanup_step.Name = "Log Completion"
    cleanup_step.AsPropertyObject().SetValString(
        "Step.Expr", 1, 'Locals.DUT_ID = Locals.DUT_ID'
    )
    main_seq.InsertStep(cleanup_step, 0, 2)  # Cleanup group

    # Save the sequence file
    seq_file.Save(r"C:\TestStand\Sequences\VoltageSweep.seq")
    print("Sequence file saved.")

    # Execute
    execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)

    while execution.IsRunning:
        pythoncom.PumpWaitingMessages()
        time.sleep(0.1)

    print(f"Overall Result: {execution.ResultStatus}")

finally:
    engine.UIMessagePollingEnabled = False
    engine.ShutDown(0)
    engine = None
    pythoncom.CoUninitialize()
```

### Example 4: Agent/CLI Wrapper Class

```python
"""Reusable TestStand manager for a CLI or AI agent."""
import pythoncom
import win32com.client
import time


class TestStandManager:
    """Manages a TestStand Engine instance for programmatic sequence automation."""

    def __init__(self):
        pythoncom.CoInitialize()
        self.engine = win32com.client.Dispatch("TestStand.Engine.1")
        self.engine.LoadTypePaletteFiles()
        self._seq_files = {}

    def __enter__(self):
        return self

    def __exit__(self, *args):
        self.close()

    def close(self):
        """Shut down the engine and release COM resources."""
        if self.engine:
            self.engine.UIMessagePollingEnabled = False
            self.engine.ShutDown(0)
            self.engine = None
        pythoncom.CoUninitialize()

    def create_sequence_file(self, name: str = "default"):
        """Create a new in-memory sequence file."""
        sf = self.engine.NewSequenceFile()
        self._seq_files[name] = sf
        return sf

    def load_sequence_file(self, path: str, name: str = None):
        """Load a .seq file from disk."""
        sf = self.engine.GetSequenceFileEx(path, 0, 0)
        key = name or path
        self._seq_files[key] = sf
        return sf

    def add_numeric_limit_step(self, seq_file, sequence_name: str,
                                step_name: str, low: float, high: float,
                                group: int = 1, position: int = 0):
        """Add a NumericLimitTest step to a sequence."""
        seq = seq_file.GetSequenceByName(sequence_name)
        step = self.engine.NewStep('', 'NumericLimitTest')
        step.Name = step_name
        step_po = step.AsPropertyObject()
        step_po.SetValNumber("Step.InBuf.Limits.CompOp", 1, 6)  # GELE
        step_po.SetValNumber("Step.InBuf.Limits.Low", 1, low)
        step_po.SetValNumber("Step.InBuf.Limits.High", 1, high)
        seq.InsertStep(step, position, group)
        return step

    def add_action_step(self, seq_file, sequence_name: str,
                        step_name: str, group: int = 1, position: int = 0):
        """Add an Action step to a sequence."""
        seq = seq_file.GetSequenceByName(sequence_name)
        step = self.engine.NewStep('', 'Action')
        step.Name = step_name
        seq.InsertStep(step, position, group)
        return step

    def run_sequence(self, seq_file, sequence_name: str = "MainSequence",
                     timeout: float = 60.0) -> dict:
        """Execute a sequence and wait for completion. Returns result dict."""
        execution = self.engine.NewExecution(
            seq_file, sequence_name, None, False, 0
        )

        start = time.time()
        while execution.IsRunning:
            if time.time() - start > timeout:
                execution.Terminate()
                return {"status": "Timeout", "error": "Execution timed out"}
            pythoncom.PumpWaitingMessages()
            time.sleep(0.1)

        result = {
            "status": execution.ResultStatus,
            "elapsed_time": execution.ElapsedTime,
            "error": None,
        }
        if execution.ErrorOccurred:
            result["error"] = execution.ErrorMessage
        return result

    def list_steps(self, seq_file, sequence_name: str = "MainSequence",
                   group: int = 1) -> list:
        """List all steps in a sequence group."""
        seq = seq_file.GetSequenceByName(sequence_name)
        steps = []
        for i in range(seq.GetNumSteps(group)):
            step = seq.GetStep(group, i)
            steps.append({
                "index": i,
                "name": step.Name,
                "type": step.AsPropertyObject().GetValString("Step.StepType", 0),
            })
        return steps


# Usage from CLI/agent:
if __name__ == "__main__":
    with TestStandManager() as ts:
        sf = ts.create_sequence_file()
        ts.add_numeric_limit_step(sf, "MainSequence", "Check 3.3V", 3.2, 3.4)
        ts.add_numeric_limit_step(sf, "MainSequence", "Check 5V", 4.9, 5.1)

        print("Steps:", ts.list_steps(sf))
        result = ts.run_sequence(sf)
        print("Result:", result)
```

---

## Advanced Topics

### Enumerating Available Adapters

```python
print("Available adapters:")
for i in range(engine.NumAdapters):
    a = engine.GetAdapter(i)
    print(f"  {i}: {a.DisplayName}")
```

### Accessing Station Globals

Station globals are shared across all sequence files and persist across executions:

```python
station = engine.StationGlobals

# Read a station global
if station.Exists("MyGlobal", 0):
    val = station.GetValString("MyGlobal", 0)

# Write a station global
station.SetValString("MyGlobal", 1, "TestBench-A")
```

### Working with Sequence Parameters

```python
seq = seq_file.SequenceByName("MainSequence")
params = seq.Parameters

# Add a parameter
params.NewSubProperty("InputVoltage", 2, False, "", 0)  # Number
params.SetValNumber("InputVoltage", 0, 5.0)

# Read parameters back
voltage = params.GetValNumber("InputVoltage", 0)
```

### Conditional Step Execution (Preconditions)

```python
step_po = step.AsPropertyObject()
# Set a precondition expression — step only runs if this evaluates True
step_po.SetValString("Step.PreExpr", 1, "Locals.SkipCalibration == False")
```

---

## Engine & Sequence Gotchas

1. **Engine is process-singleton**: Creating a second `Dispatch("TestStand.Engine.1")` in the
   same process returns the same instance. Don't try to create multiple engines.

2. **COM threading apartment**: `pythoncom.CoInitialize()` sets STA (Single-Threaded Apartment).
   If you need COM from multiple threads, each thread must call `CoInitialize()` independently,
   and COM objects cannot be shared across threads without marshaling.

3. **Property paths are case-sensitive**: `"Step.InBuf.Limits.Low"` works;
   `"step.inbuf.limits.low"` does not. Always match the exact casing from the TestStand documentation.

4. **`InsertStep` returns the Step object**: Don't discard the return value — you need it to
   configure the step. There's no "get last inserted step" method.

5. **Step group indices are 0-based**: Setup=0, Main=1, Cleanup=2. This is a common source
   of off-by-one errors if you assume 1-based indexing.

6. **SequenceFile must exist when setting `SequenceFilePath` for SequenceCall steps**:
   The path is validated at edit time. Use absolute paths and verify the file exists before setting.

7. **`NewSubProperty` type codes differ from documentation format**: The numeric type codes
   (1=Boolean, 2=Number, 8=String) are not intuitive. Always reference the table.

8. **Forgetting to pump COM messages during execution wait**: Without
   `pythoncom.PumpWaitingMessages()` in the wait loop, COM callbacks are blocked and
   the execution may appear to hang.

9. **`GetSequenceFileEx` caches files**: If you load the same file twice, you get the same
   in-memory object. Call `ReleaseSequenceFileEx` to unload. Modifying a cached file
   affects all references.

10. **`ShutDown(0)` blocks until all executions terminate**: If you have a running execution
    when you call `ShutDown(0)`, it will wait (potentially forever if the execution is stuck).
    Terminate all executions before shutdown.

11. **Must call `LoadTypePaletteFiles()` before `NewStep()`**: Without loading type palettes,
    `NewStep` will fail with "Step type not found in type list." Call it once after engine creation.

12. **`InsertStep(step, index, stepGroup)` parameter order**: The step object goes first,
    then the insertion index within the group, then the step group (0/1/2). This differs from
    older documentation that showed `InsertStep(stepType, group, position)`.

13. **COM objects cannot be printed**: Many TestStand COM objects (PropertyObject, StepType)
    raise errors when you try to `print()` or `str()` them. Access specific properties instead.
