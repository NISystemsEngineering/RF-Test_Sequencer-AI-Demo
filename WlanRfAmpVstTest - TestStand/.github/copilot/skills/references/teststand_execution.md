# TestStand Execution Reference — Running Sequences and Collecting Results

**COM ProgID**: Execution objects are created via `Engine.NewExecution()`
**Automation Interface**: `IExecution`
**Requires**: NI TestStand 2021 SP1+ installed, `pywin32` (`pip install pywin32`)
**Source**: [NI TestStand API Reference](https://www.ni.com/docs/en-US/bundle/teststand-api-reference/page/tsapiref/teststand-api-overview-poster.html)

## Table of Contents

1. [Launching an Execution](#launching-an-execution)
2. [Execution Properties](#execution-properties)
3. [Monitoring Execution State](#monitoring-execution-state)
4. [Result Extraction](#result-extraction)
5. [Step-Level Results](#step-level-results)
6. [SequenceContext in Code Modules](#sequencecontext-in-code-modules)
7. [Execution Control (Pause, Resume, Terminate)](#execution-control)
8. [Report Generation](#report-generation)
9. [Canonical Examples](#canonical-examples)
10. [Execution Gotchas](#execution-gotchas)

---

## Launching an Execution

Executions are created via `Engine.NewExecution()`. This starts the sequence running
immediately (unless `breakAtFirstStep` is True).

### NewExecution Parameters

```python
execution = engine.NewExecution(
    sequenceFileParam,       # SequenceFile object
    sequenceNameParam,       # str: name of sequence to run (e.g. "MainSequence")
    executionObject,         # Execution or None: parent execution (None for standalone)
    breakAtFirstStep,        # bool: pause before first step (for debugging)
    executionTypeMask        # int: execution options bitmask (0 = default)
)
```

### executionTypeMask Values

| Value | Name                          | Description                                  |
|-------|-------------------------------|----------------------------------------------|
| 0     | Default                       | Normal execution with process model           |
| 1     | `ExecTypMask_NoProcessModel`  | Run without process model entry points        |

### Basic Execution Launch

```python
# Run MainSequence with default process model
execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)

# Run without process model (run the sequence directly, no UUT loop)
execution = engine.NewExecution(seq_file, "MainSequence", None, False, 1)
```

---

## Execution Properties

| Property           | Type   | Description                                              |
|--------------------|--------|----------------------------------------------------------|
| `IsRunning`        | bool   | True while the execution is still running                |
| `ResultStatus`     | str    | Overall result: "Passed", "Failed", "Error", "Terminated"|
| `ElapsedTime`      | float  | Total execution time in seconds                          |
| `ErrorOccurred`    | bool   | True if a runtime error occurred                         |
| `ErrorMessage`     | str    | Error description text (if ErrorOccurred is True)        |
| `ErrorCode`        | int    | Error code (if ErrorOccurred is True)                    |
| `NumSteps`         | int    | Total number of steps that executed                      |
| `Id`               | int    | Unique execution identifier                              |
| `SequenceFile`     | object | The SequenceFile being executed                          |
| `SequenceName`     | str    | The name of the sequence being executed                  |
| `ResultObject`     | object | PropertyObject containing the full result tree           |
| `Thread`           | object | The primary thread of execution                          |

---

## Monitoring Execution State

### Simple Polling Loop

```python
import time

execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)

while execution.IsRunning:
    pythoncom.PumpWaitingMessages()
    time.sleep(0.1)

print(f"Finished: {execution.ResultStatus}")
```

### Polling with Timeout

```python
import time

execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)

timeout = 120.0  # seconds
start = time.time()

while execution.IsRunning:
    elapsed = time.time() - start
    if elapsed > timeout:
        execution.Terminate()
        raise TimeoutError(f"Execution timed out after {timeout}s")
    pythoncom.PumpWaitingMessages()
    time.sleep(0.1)

print(f"Status: {execution.ResultStatus} ({execution.ElapsedTime:.2f}s)")
```

### Polling with Progress Reporting

```python
import time

execution = engine.NewExecution(seq_file, "MainSequence", None, False, 0)
last_report = time.time()

while execution.IsRunning:
    now = time.time()
    if now - last_report > 2.0:  # Report every 2 seconds
        print(f"  ... still running ({now - start:.0f}s elapsed)")
        last_report = now
    pythoncom.PumpWaitingMessages()
    time.sleep(0.1)
```

---

## Result Extraction

After execution completes, results are available through the `ResultObject` property
or by inspecting the execution's thread and step results.

### Overall Execution Result

```python
def get_execution_summary(execution) -> dict:
    """Extract high-level results from a completed execution."""
    return {
        "status": execution.ResultStatus,
        "elapsed_time": round(execution.ElapsedTime, 3),
        "error_occurred": execution.ErrorOccurred,
        "error_message": execution.ErrorMessage if execution.ErrorOccurred else None,
        "error_code": execution.ErrorCode if execution.ErrorOccurred else None,
        "sequence": execution.SequenceName,
    }
```

### Accessing the Result Tree via ResultObject

The `ResultObject` is a PropertyObject containing the full hierarchical result tree.
It mirrors the sequence structure with entries for each step.

```python
result_obj = execution.ResultObject

# The result tree has "TS" (TestStand) and sequence-level properties
# Navigate using PropertyObject methods
if result_obj:
    # Check if result properties exist and extract them
    main_result = result_obj.GetValString("TS.SequenceCall.ResultList[0].Status", 0)
    print(f"Main result: {main_result}")
```

### Extracting the Result List

The result list contains an entry for each step that executed:

```python
def extract_step_results(execution) -> list:
    """Extract per-step results from a completed execution."""
    results = []
    result_obj = execution.ResultObject
    if not result_obj:
        return results

    # Access the result list
    try:
        result_list_path = "TS.SequenceCall.ResultList"
        num_results = result_obj.GetNumSubProperties(result_list_path)

        for i in range(num_results):
            entry_path = f"{result_list_path}[{i}]"
            step_result = {
                "index": i,
                "step_name": result_obj.GetValString(f"{entry_path}.TS.StepName", 0),
                "status": result_obj.GetValString(f"{entry_path}.Status", 0),
                "step_type": result_obj.GetValString(f"{entry_path}.TS.StepType", 0),
            }

            # Try to get numeric data (for NumericLimitTest steps)
            try:
                step_result["numeric_value"] = result_obj.GetValNumber(
                    f"{entry_path}.Numeric", 0
                )
            except Exception:
                pass

            # Try to get limits
            try:
                step_result["low_limit"] = result_obj.GetValNumber(
                    f"{entry_path}.Limits.Low", 0
                )
                step_result["high_limit"] = result_obj.GetValNumber(
                    f"{entry_path}.Limits.High", 0
                )
            except Exception:
                pass

            # Get error info
            try:
                err_code = result_obj.GetValNumber(f"{entry_path}.Error.Code", 0)
                if err_code != 0:
                    step_result["error_code"] = int(err_code)
                    step_result["error_message"] = result_obj.GetValString(
                        f"{entry_path}.Error.Msg", 0
                    )
            except Exception:
                pass

            results.append(step_result)

    except Exception as e:
        print(f"Warning: Could not extract result list: {e}")

    return results
```

---

## Step-Level Results

### Result Status Values

| Status       | Description                                          |
|--------------|------------------------------------------------------|
| `"Passed"`   | Step passed its evaluation (limits met, pass/fail ok)|
| `"Failed"`   | Step failed its evaluation                           |
| `"Error"`    | A runtime error occurred during the step             |
| `"Skipped"`  | Step was skipped (precondition false, etc.)          |
| `"Done"`     | Step completed but has no pass/fail evaluation       |
| `"Running"`  | Step is currently executing (mid-execution only)      |
| `"Terminated"` | Execution was manually terminated                  |

### NumericLimitTest Result Properties

| Property Path                  | Type  | Description                         |
|--------------------------------|-------|-------------------------------------|
| `Numeric`                      | float | The measured value                  |
| `Limits.Low`                   | float | The low limit used                  |
| `Limits.High`                  | float | The high limit used                 |
| `Limits.CompOp`                | int   | Comparison operator used            |
| `Status`                       | str   | "Passed" or "Failed"                |
| `Error.Code`                   | int   | Error code (0 = no error)           |
| `Error.Msg`                    | str   | Error message                       |

### PassFailTest Result Properties

| Property Path                  | Type  | Description                         |
|--------------------------------|-------|-------------------------------------|
| `PassFail`                     | bool  | True = passed, False = failed       |
| `Status`                       | str   | "Passed" or "Failed"                |

### StringValueTest Result Properties

| Property Path                  | Type  | Description                         |
|--------------------------------|-------|-------------------------------------|
| `String`                       | str   | The actual string value             |
| `Limits.String`                | str   | The expected string value           |
| `Status`                       | str   | "Passed" or "Failed"                |

---

## SequenceContext in Code Modules

When TestStand calls a Python code module, the function receives a `SequenceContext`
COM object that provides full access to step properties, sequence locals, file globals,
station globals, and the execution environment.

### SequenceContext Key Methods

| Method                                          | Returns | Description                        |
|-------------------------------------------------|---------|------------------------------------|
| `GetValNumber(path, flags)`                     | float   | Read a numeric property            |
| `SetValNumber(path, flags, value)`              | None    | Write a numeric property           |
| `GetValString(path, flags)`                     | str     | Read a string property             |
| `SetValString(path, flags, value)`              | None    | Write a string property            |
| `GetValBoolean(path, flags)`                    | bool    | Read a boolean property            |
| `SetValBoolean(path, flags, value)`             | None    | Write a boolean property           |
| `Exists(path, flags)`                           | bool    | Check if property path exists      |

### SequenceContext Property Paths (from Code Module)

| Path                                    | Scope                                    |
|-----------------------------------------|------------------------------------------|
| `Step.InBuf.Numeric`                    | NumericLimitTest data (write your result)|
| `Step.Result.PassFail`                  | PassFailTest result (write True/False)   |
| `Step.Result.Error.Code`                | Set error code (non-zero = error)        |
| `Step.Result.Error.Msg`                 | Set error message                        |
| `Locals.<varname>`                      | Sequence local variable                  |
| `Parameters.<paramname>`                | Sequence parameter                       |
| `FileGlobals.<varname>`                 | File-level global                        |
| `StationGlobals.<varname>`              | Station-level global                     |
| `RunState.SequenceFile.Path`            | Path of the current sequence file        |
| `RunState.Sequence.Name`               | Name of the current sequence             |
| `RunState.Step.Name`                    | Name of the current step                 |
| `RunState.Root.SequenceFile.Path`       | Path of the root-level sequence file     |

### Code Module Examples

#### NumericLimitTest Code Module

```python
def measure_voltage(sequence_context):
    """Measure a voltage and return it for NumericLimitTest evaluation."""
    target = sequence_context.GetValNumber("Locals.TargetVoltage", 0)

    # Perform measurement (replace with actual instrument code)
    measured_voltage = perform_voltage_measurement(target)

    # Write result — TestStand compares this against the step's limits
    sequence_context.SetValNumber("Step.InBuf.Numeric", 1, measured_voltage)
    return 0  # 0 = success
```

#### PassFailTest Code Module

```python
def check_dut_present(sequence_context):
    """Check if DUT is detected on the test fixture."""
    # Perform check (replace with actual detection logic)
    is_present = detect_dut_on_fixture()

    # Write boolean result — TestStand evaluates pass/fail
    sequence_context.SetValBoolean("Step.Result.PassFail", 1, is_present)
    return 0
```

#### Code Module with Error Handling

```python
def acquire_data(sequence_context):
    """Acquire measurement data with error handling."""
    try:
        channel = sequence_context.GetValString("Locals.Channel", 0)
        num_samples = int(sequence_context.GetValNumber("Locals.NumSamples", 0))

        # Perform acquisition
        data = acquire_from_instrument(channel, num_samples)
        avg = sum(data) / len(data)

        sequence_context.SetValNumber("Step.InBuf.Numeric", 1, avg)
        return 0

    except Exception as e:
        # Report error back to TestStand
        sequence_context.SetValNumber("Step.Result.Error.Code", 1, -1)
        sequence_context.SetValString("Step.Result.Error.Msg", 1, str(e))
        return -1  # Non-zero return indicates error
```

---

## Execution Control

### Pausing and Resuming

```python
# Pause a running execution
execution.Pause()

# Check if paused
if execution.IsPaused:
    print("Execution is paused")

# Resume
execution.Resume()
```

### Terminating an Execution

```python
# Gracefully terminate — runs Cleanup steps
execution.Terminate()

# Wait for it to fully stop
while execution.IsRunning:
    pythoncom.PumpWaitingMessages()
    time.sleep(0.1)

print(f"Terminated with status: {execution.ResultStatus}")
```

### Breaking at First Step (Debugging)

```python
# Start paused at the first step
execution = engine.NewExecution(seq_file, "MainSequence", None, True, 0)

# The execution is paused — resume when ready
execution.Resume()
```

---

## Report Generation

TestStand can generate test reports in various formats (XML, HTML, ATML, text) through
the process model's report generation. For programmatic result extraction (more useful
for CLI/agent workflows), use the result extraction patterns above.

### Programmatic Report via Process Model

When running with the default process model (`executionTypeMask=0`), TestStand
automatically generates reports based on the configured report options in the
process model. The report path is configured via station options.

### Extracting Results for Custom Reporting

For CLI/agent use, it's typically better to extract structured results programmatically
rather than relying on TestStand's built-in report generation:

```python
def generate_report(execution) -> str:
    """Generate a simple text report from execution results."""
    lines = []
    lines.append(f"Test Report — {execution.SequenceName}")
    lines.append(f"{'='*50}")
    lines.append(f"Overall Status: {execution.ResultStatus}")
    lines.append(f"Elapsed Time:   {execution.ElapsedTime:.2f}s")
    lines.append(f"")

    step_results = extract_step_results(execution)  # From above
    for sr in step_results:
        status_icon = "PASS" if sr["status"] == "Passed" else "FAIL"
        line = f"  [{status_icon}] {sr['step_name']}"
        if "numeric_value" in sr:
            line += f" — Value: {sr['numeric_value']:.4f}"
        if "low_limit" in sr and "high_limit" in sr:
            line += f" [{sr['low_limit']}, {sr['high_limit']}]"
        lines.append(line)

    if execution.ErrorOccurred:
        lines.append(f"\nERROR: {execution.ErrorMessage}")

    return "\n".join(lines)
```

---

## Canonical Examples

### Example 1: Run a Sequence and Print Step-by-Step Results

```python
"""Run an existing sequence file and display detailed results."""
import pythoncom
import win32com.client
import time

pythoncom.CoInitialize()
engine = win32com.client.Dispatch("TestStand.Engine.1")

try:
    # Load the sequence file
    seq_file = engine.GetSequenceFileEx(r"C:\TestStand\Sequences\MyTest.seq", 0, 0)

    # Run without process model for simplicity
    execution = engine.NewExecution(seq_file, "MainSequence", None, False, 1)

    # Wait for completion
    start = time.time()
    while execution.IsRunning:
        pythoncom.PumpWaitingMessages()
        time.sleep(0.1)

    # Print summary
    print(f"Status: {execution.ResultStatus}")
    print(f"Time:   {execution.ElapsedTime:.2f}s")
    print()

    # Extract step results
    result_obj = execution.ResultObject
    if result_obj:
        result_list_path = "TS.SequenceCall.ResultList"
        try:
            num = result_obj.GetNumSubProperties(result_list_path)
            for i in range(num):
                path = f"{result_list_path}[{i}]"
                name = result_obj.GetValString(f"{path}.TS.StepName", 0)
                status = result_obj.GetValString(f"{path}.Status", 0)
                print(f"  Step '{name}': {status}")
        except Exception as e:
            print(f"Could not read results: {e}")

    # Release
    engine.ReleaseSequenceFileEx(seq_file, 0)

finally:
    engine.UIMessagePollingEnabled = False
    engine.ShutDown()
    engine = None
    pythoncom.CoUninitialize()
```

### Example 2: Execute with Timeout and Result Extraction for CLI

```python
"""CLI-oriented execution with structured result output."""
import pythoncom
import win32com.client
import time
import json


def run_teststand_sequence(seq_path: str, sequence_name: str = "MainSequence",
                           timeout: float = 120.0) -> dict:
    """Run a TestStand sequence and return structured results. 
    
    Suitable for CLI or AI agent integration.
    """
    pythoncom.CoInitialize()
    engine = win32com.client.Dispatch("TestStand.Engine.1")

    try:
        seq_file = engine.GetSequenceFileEx(seq_path, 0, 0)
        execution = engine.NewExecution(seq_file, sequence_name, None, False, 0)

        # Wait with timeout
        start = time.time()
        while execution.IsRunning:
            if time.time() - start > timeout:
                execution.Terminate()
                return {"status": "Timeout", "error": f"Exceeded {timeout}s"}
            pythoncom.PumpWaitingMessages()
            time.sleep(0.1)

        # Build result structure
        result = {
            "status": execution.ResultStatus,
            "elapsed_time": round(execution.ElapsedTime, 3),
            "steps": [],
            "error": None,
        }

        if execution.ErrorOccurred:
            result["error"] = execution.ErrorMessage

        # Extract step-level results
        result_obj = execution.ResultObject
        if result_obj:
            try:
                rlist = "TS.SequenceCall.ResultList"
                for i in range(result_obj.GetNumSubProperties(rlist)):
                    p = f"{rlist}[{i}]"
                    step_info = {
                        "name": result_obj.GetValString(f"{p}.TS.StepName", 0),
                        "status": result_obj.GetValString(f"{p}.Status", 0),
                    }
                    try:
                        step_info["value"] = result_obj.GetValNumber(f"{p}.Numeric", 0)
                    except Exception:
                        pass
                    result["steps"].append(step_info)
            except Exception:
                pass

        engine.ReleaseSequenceFileEx(seq_file, 0)
        return result

    finally:
        engine.UIMessagePollingEnabled = False
        engine.ShutDown()
        engine = None
        pythoncom.CoUninitialize()


# CLI usage
if __name__ == "__main__":
    import sys
    seq_path = sys.argv[1] if len(sys.argv) > 1 else r"C:\TestStand\Sequences\Test.seq"
    result = run_teststand_sequence(seq_path)
    print(json.dumps(result, indent=2))
```

### Example 3: Create, Execute, and Collect Results — Full Pipeline

```python
"""Full pipeline: create a sequence, add test steps, run, collect results."""
import pythoncom
import win32com.client
import time


def create_and_run_voltage_test(test_points: list[dict]) -> dict:
    """
    Create a TestStand sequence dynamically from test point definitions
    and execute it.

    Args:
        test_points: List of dicts with keys: name, low_limit, high_limit
                     e.g. [{"name": "3.3V Rail", "low": 3.2, "high": 3.4}]

    Returns:
        Structured result dict with overall status and per-step results.
    """
    pythoncom.CoInitialize()
    engine = win32com.client.Dispatch("TestStand.Engine.1")

    try:
        # Create sequence
        seq_file = engine.NewSequenceFile()
        main_seq = seq_file.SequenceByName("MainSequence")
        nlt_type = engine.GetStepTypeByName("NumericLimitTest")

        # Add test steps
        for tp in test_points:
            step = main_seq.InsertStep(nlt_type, 1, -1)
            step.Name = tp["name"]
            step_po = step.AsPropertyObject()
            step_po.SetValNumber("Step.InBuf.Limits.CompOp", 1, 6)  # GELE
            step_po.SetValNumber("Step.InBuf.Limits.Low", 1, tp["low"])
            step_po.SetValNumber("Step.InBuf.Limits.High", 1, tp["high"])

        # Execute (no process model)
        execution = engine.NewExecution(seq_file, "MainSequence", None, False, 1)

        while execution.IsRunning:
            pythoncom.PumpWaitingMessages()
            time.sleep(0.1)

        # Collect results
        result = {
            "status": execution.ResultStatus,
            "elapsed_time": round(execution.ElapsedTime, 3),
            "test_points": [],
        }

        result_obj = execution.ResultObject
        if result_obj:
            try:
                rlist = "TS.SequenceCall.ResultList"
                for i in range(result_obj.GetNumSubProperties(rlist)):
                    p = f"{rlist}[{i}]"
                    tp_result = {
                        "name": result_obj.GetValString(f"{p}.TS.StepName", 0),
                        "status": result_obj.GetValString(f"{p}.Status", 0),
                    }
                    try:
                        tp_result["measured"] = result_obj.GetValNumber(f"{p}.Numeric", 0)
                        tp_result["low_limit"] = result_obj.GetValNumber(f"{p}.Limits.Low", 0)
                        tp_result["high_limit"] = result_obj.GetValNumber(f"{p}.Limits.High", 0)
                    except Exception:
                        pass
                    result["test_points"].append(tp_result)
            except Exception:
                pass

        return result

    finally:
        engine.UIMessagePollingEnabled = False
        engine.ShutDown()
        engine = None
        pythoncom.CoUninitialize()


# Usage:
if __name__ == "__main__":
    tests = [
        {"name": "1.8V Rail", "low": 1.71, "high": 1.89},
        {"name": "3.3V Rail", "low": 3.135, "high": 3.465},
        {"name": "5.0V Rail", "low": 4.75, "high": 5.25},
    ]
    result = create_and_run_voltage_test(tests)
    print(f"Overall: {result['status']}")
    for tp in result["test_points"]:
        icon = "PASS" if tp["status"] == "Passed" else "FAIL"
        measured = tp.get("measured", "N/A")
        print(f"  [{icon}] {tp['name']}: {measured}")
```

### Example 4: Persistent Engine Manager for Agent/CLI Sessions

```python
"""Long-lived TestStand manager for an AI agent that makes multiple calls."""
import pythoncom
import win32com.client
import time
import json
from typing import Optional


class TestStandAgent:
    """Manages a persistent TestStand Engine for multi-turn agent interactions.
    
    Designed for use in a CLI or AI agent where the user may:
    - Create sequences across multiple commands
    - Add steps incrementally
    - Execute and inspect results
    - Modify and re-execute
    """

    def __init__(self):
        pythoncom.CoInitialize()
        self.engine = win32com.client.Dispatch("TestStand.Engine.1")
        self._files: dict[str, object] = {}
        self._last_execution = None

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

    # ---- Sequence File Management ----

    def new_file(self, alias: str = "default") -> str:
        """Create a new sequence file and return its alias."""
        self._files[alias] = self.engine.NewSequenceFile()
        return alias

    def load_file(self, path: str, alias: Optional[str] = None) -> str:
        """Load a .seq file from disk."""
        key = alias or path
        self._files[key] = self.engine.GetSequenceFileEx(path, 0, 0)
        return key

    def save_file(self, alias: str, path: str):
        """Save a sequence file to disk."""
        self._files[alias].SaveAs(path, 0)

    def list_files(self) -> list[str]:
        """List loaded file aliases."""
        return list(self._files.keys())

    # ---- Step Management ----

    def add_step(self, file_alias: str, step_type_name: str, step_name: str,
                 sequence: str = "MainSequence", group: int = 1,
                 position: int = -1, **properties) -> dict:
        """Add a step and optionally set properties. Returns step info."""
        sf = self._files[file_alias]
        seq = sf.SequenceByName(sequence)
        st = self.engine.GetStepTypeByName(step_type_name)
        step = seq.InsertStep(st, group, position)
        step.Name = step_name

        # Apply any extra properties
        if properties:
            step_po = step.AsPropertyObject()
            for path, value in properties.items():
                if isinstance(value, (int, float)):
                    step_po.SetValNumber(path, 1, value)
                elif isinstance(value, bool):
                    step_po.SetValBoolean(path, 1, value)
                elif isinstance(value, str):
                    step_po.SetValString(path, 1, value)

        return {"name": step_name, "type": step_type_name, "group": group}

    def list_steps(self, file_alias: str, sequence: str = "MainSequence",
                   group: int = 1) -> list[dict]:
        """List steps in a sequence group."""
        sf = self._files[file_alias]
        seq = sf.SequenceByName(sequence)
        steps = []
        for i in range(seq.NumSteps(group)):
            step = seq.GetStep(group, i)
            steps.append({"index": i, "name": step.Name})
        return steps

    # ---- Execution ----

    def run(self, file_alias: str, sequence: str = "MainSequence",
            timeout: float = 120.0, use_process_model: bool = False) -> dict:
        """Execute a sequence and return structured results."""
        sf = self._files[file_alias]
        exec_mask = 0 if use_process_model else 1
        execution = self.engine.NewExecution(sf, sequence, None, False, exec_mask)

        start = time.time()
        while execution.IsRunning:
            if time.time() - start > timeout:
                execution.Terminate()
                return {"status": "Timeout", "error": f"Exceeded {timeout}s"}
            pythoncom.PumpWaitingMessages()
            time.sleep(0.1)

        self._last_execution = execution

        result = {
            "status": execution.ResultStatus,
            "elapsed_time": round(execution.ElapsedTime, 3),
            "steps": [],
            "error": None,
        }

        if execution.ErrorOccurred:
            result["error"] = execution.ErrorMessage

        # Extract step results
        result_obj = execution.ResultObject
        if result_obj:
            try:
                rlist = "TS.SequenceCall.ResultList"
                for i in range(result_obj.GetNumSubProperties(rlist)):
                    p = f"{rlist}[{i}]"
                    sr = {
                        "name": result_obj.GetValString(f"{p}.TS.StepName", 0),
                        "status": result_obj.GetValString(f"{p}.Status", 0),
                    }
                    try:
                        sr["value"] = result_obj.GetValNumber(f"{p}.Numeric", 0)
                    except Exception:
                        pass
                    try:
                        sr["low"] = result_obj.GetValNumber(f"{p}.Limits.Low", 0)
                        sr["high"] = result_obj.GetValNumber(f"{p}.Limits.High", 0)
                    except Exception:
                        pass
                    result["steps"].append(sr)
            except Exception:
                pass

        return result

    def get_last_result_json(self) -> str:
        """Return the last execution's results as JSON."""
        if not self._last_execution:
            return json.dumps({"error": "No execution has been run yet"})
        # Re-extract from the stored execution
        return json.dumps(self.run.__wrapped__(self) if False else {"status": self._last_execution.ResultStatus})


# Agent usage example:
if __name__ == "__main__":
    with TestStandAgent() as agent:
        # Step 1: Create a sequence
        agent.new_file("my_test")

        # Step 2: Add test steps
        agent.add_step("my_test", "NumericLimitTest", "Check 3.3V",
                        **{"Step.InBuf.Limits.CompOp": 6,
                           "Step.InBuf.Limits.Low": 3.2,
                           "Step.InBuf.Limits.High": 3.4})

        agent.add_step("my_test", "NumericLimitTest", "Check 5V",
                        **{"Step.InBuf.Limits.CompOp": 6,
                           "Step.InBuf.Limits.Low": 4.9,
                           "Step.InBuf.Limits.High": 5.1})

        # Step 3: Run and get results
        result = agent.run("my_test")
        print(json.dumps(result, indent=2))
```

---

## Execution Gotchas

1. **`IsRunning` stays True until all cleanup completes**: Even after the Main group finishes,
   Cleanup steps still run. Don't assume the test is done until `IsRunning` returns False.

2. **`PumpWaitingMessages()` is mandatory in wait loops**: Without it, COM callbacks are blocked
   and execution may appear frozen. Call it in every iteration of your wait loop.

3. **`ResultStatus` is only valid after `IsRunning` becomes False**: Reading it while still
   running returns an intermediate or undefined value.

4. **`ResultObject` may be None**: If the execution failed to start or was terminated before
   producing results, `ResultObject` can be None. Always check before accessing.

5. **`executionTypeMask=1` skips the process model**: This means no UUT serial number dialog,
   no report generation, and no model callbacks. Use this for automated/agent execution and
   handle results programmatically.

6. **`Terminate()` is not instantaneous**: After calling `Terminate()`, you must still poll
   `IsRunning` in a loop — the execution needs time to run Cleanup steps before stopping.

7. **COM object lifetime**: Don't store execution or result objects beyond the Engine's
   lifetime. Once `ShutDown()` is called, all COM object references become invalid.

8. **Thread safety**: COM objects obtained on one thread cannot be used on another thread
   without COM marshaling. If your agent uses async/threading, ensure the TestStand
   interaction happens on a dedicated thread with its own `CoInitialize()`.

9. **Result property paths differ by step type**: `Numeric` exists for NumericLimitTest,
   `PassFail` for PassFailTest, `String` for StringValueTest. Always wrap result reads
   in try/except when iterating mixed step types.

10. **Execution holds a reference to the SequenceFile**: Don't release a SequenceFile
    (via `ReleaseSequenceFileEx`) while an execution using it is still running. Wait for
    completion first.
