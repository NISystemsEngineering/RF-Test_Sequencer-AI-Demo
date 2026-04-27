---
name: nisyscfg-equipment-discovery
description: "Answer questions about installed or attached hardware, test equipment, and NI devices using the nisyscfg Python API. Use when users ask what equipment is connected, what instruments are present, serial numbers, product names, chassis/modules detected, drivers installed, or system hardware inventory. Also covers NI-specific queries about PXI, cRIO, XNET, DMM, Scope, NI-SCOPE, NI-DMM, connected instruments, aliases, and whether NI hardware drivers/devices are present on a system."
argument-hint: "Describe the equipment question, target system, and desired fields like model, serial, alias, chassis, or bus"
user-invocable: true
---

# NI SysCfg Equipment Discovery

Use this skill to identify hardware and test equipment connected to a system using the `nisyscfg` Python API. Covers general hardware inventory as well as NI-specific test equipment queries.

## Trigger Phrases

- "What hardware is installed?"
- "What equipment is attached to this system?"
- "List connected test instruments"
- "Find NI devices by serial number"
- "Show chassis and modules"
- "Check if a driver/device is present"
- "What NI test equipment is attached?"
- "List PXI modules and chassis"
- "What cRIO hardware is installed?"
- "Which XNET interfaces are connected?"
- "Do we have NI-DMM or DMM hardware installed?"
- "Do we have NI-SCOPE or scope cards installed?"
- "Show NI devices connected to this controller"
- "Which test instruments are present on this station?"

## What This Skill Uses

- `nisyscfg.Session()` for system and hardware queries.
- `session.create_filter()` and `session.find_hardware(...)` for resource discovery.
- `session.find_systems(...)` for network/system discovery.
- Common resource fields: `product_name`, `vendor_name`, `serial_number`, `expert_user_alias`, `expert_resource_name`, `name`, `provides_link_name`.

## Scope

- Local and network system inventory
- Chassis and module correlation
- Expert-scoped lookup (`xnet`, `daqmx`, `scope`, and others when available)
- Instrument-family checks for PXI, cRIO, XNET, DMM/NI-DMM, and Scope/NI-SCOPE
- Driver/presence checks through NI SysCfg properties
- Serial number, alias, and model lookups

## Procedure

0. Fast path before querying:
   - verify `nisyscfg` import works in the selected Python environment
   - if missing, install `nisyscfg` and rerun
1. Confirm the target scope:
   - local system inventory
   - network system discovery
   - specific equipment filters (serial number, NI-only, device/chassis)
2. Build a filter with high-value properties first:
   - `is_present = True`
   - `is_device = True` or `is_chassis = True`
   - `is_ni_product = True` for NI-focused lists
   - `serial_number = ...` for pinpoint lookup
3. Query hardware with `find_hardware(filter, expert_names=...)`.
4. Include grouping keys when possible:
   - `provides_link_name`
   - `connects_to_link_name`
   - `slot_number` for PXI module location
5. Return a concise table-like summary with key identifiers and counts.
6. If no matches are found, suggest widening filters (remove expert or NI-only restriction).

## Performance Optimizations

Hardware discovery can be slow (10-30 seconds) due to bus enumeration and network scanning. Apply these optimizations for faster execution:

### 1. **Skip Network Discovery** (saves 5-10+ seconds)
```python
# Target localhost explicitly to skip network scanning
with nisyscfg.Session(target="localhost") as session:
    ...
```

### 2. **Use Focused Expert Lists** (saves 3-5 seconds)
Instead of loading all experts, specify only relevant ones:
```python
# For PXI-focused discovery
experts = "ni-pxi,ni-vst,niflexrio2,ni-scope,nidmm,nidcpower,nidigital,nifgen,niswitch,ni-5655"
session.find_hardware(filt, expert_names=experts)

# For specific instrument types only
experts = "ni-vst,ni-scope"  # Only VST and scope devices
```

### 3. **Filter Results Early**
Post-filter to skip unwanted buses (e.g., keep only PXI/PCI devices):
```python
for resource in session.find_hardware(filt, expert_names=experts):
    link = resource.provides_link_name
    # Skip non-PXI buses like GPIB, USB
    if link and not (link.startswith("PXI") or link.startswith("PCI")):
        continue
    # Process PXI device...
```

### 4. **Cache Results**
For repeated queries, cache the inventory and refresh only when needed (e.g., on hardware changes).

**Expected Performance:**
- Without optimizations: 10-30 seconds
- With localhost + focused experts: 3-5 seconds
- With all optimizations: 2-4 seconds

## Learned Reliability Rules

### Property Access Issues

- Some resources do not expose optional properties (for example link-related fields).
- Access optional properties using safe fallbacks (`get_property(name, default)` or guarded helpers) to avoid `LibraryError` aborting the whole scan.
- Keep row-level failures isolated so inventory still returns partial results.

### Critical Error Patterns (Added 2026-04-24)

**1. IndexedPropertyItems Objects**

Properties like `expert_user_alias` and `expert_name` return `IndexedPropertyItems` objects, not plain strings or lists. These must be iterated to extract values.

**❌ WRONG:**
```python
# This fails - returns object representation
alias = resource.expert_user_alias
print(alias)  # <nisyscfg.properties.IndexedPropertyItems object at 0x...>
```

**✅ CORRECT:**
```python
# Convert IndexedPropertyItems to list by iterating
alias = "N/A"
try:
    alias_val = resource.expert_user_alias
    if hasattr(alias_val, '__iter__') and not isinstance(alias_val, str):
        alias_list = list(alias_val)  # Force iteration
        if alias_list:
            alias = alias_list[0]
    elif alias_val:
        alias = str(alias_val)
except:
    pass
```

**2. Python f-string Limitations**

When generating output in one-line Python commands, avoid dictionary key access with quotes inside f-strings.

**❌ WRONG:**
```python
# SyntaxError: f-string expression part cannot include a backslash
python -c "print(f'{dev[\"Product\"]}')"
```

**✅ CORRECT Options:**
```python
# Option 1: Extract to variable first
prod = dev["Product"]
print(f"{prod}")

# Option 2: Use .get() method
print(f"{dev.get('Product', 'N/A')}")

# Option 3: Use chr() to build strings
print(f"{dev[chr(80)+chr(114)+chr(111)+chr(100)+chr(117)+chr(99)+chr(116)]}")
```

**3. Property Access Order**

Always wrap individual property accesses in try-except blocks. Some properties may throw `LibraryError: Status.PROP_DOES_NOT_EXIST` even when the resource seems valid.

**✅ RECOMMENDED Pattern:**
```python
for resource in session.find_hardware(filt, expert_names=experts):
    try:
        # Get each property individually with fallback
        product = "Unknown"
        try:
            product = resource.product_name
        except:
            pass

        serial = "N/A"
        try:
            serial = resource.serial_number
        except:
            pass

        # ... continue for each property

        devices.append({
            "Product": product,
            "Serial": serial,
            # ...
        })
    except Exception as e:
        # Skip entire resource if catastrophic failure
        continue
```

**4. Write Scripts to Files, Not One-Liners**

For complex nisyscfg queries, **always create a Python script file** rather than using `python -c "..."` one-liners. Benefits:
- Proper error handling
- Readable code
- Easier debugging
- No f-string or quote escaping issues

**✅ BEST PRACTICE:**
```python
# Create scan_hardware.py file with proper structure
# Then run: python scan_hardware.py
```

## Output Format

Return rows with:

- Equipment Name / Alias
- Product Name
- Serial Number
- Slot Number (for PXI modules)
- Expert Name
- Resource Name
- Chassis Link or Bus context (if available)

Then include summary counts with device names/aliases:

- Total devices found
- Counts by product model with aliases in parentheses
  - Example: `NI PXIe-5842: 1 (5842)`

This makes it easy to reference specific devices by their user-friendly aliases.

## References

- [NI SysCfg Query Playbook](./references/nisyscfg-query-playbook.md)
- [NI Test Equipment Patterns](./references/ni-test-equipment-patterns.md)
- [General Inventory Script](./scripts/list_attached_equipment.py)
- [NI Inventory Script](./scripts/list_ni_test_equipment.py)

---

## Complete Working Example (Error-Proof Pattern)

Here's a complete, production-ready hardware scan script incorporating all learned patterns:

```python
"""
Robust NI hardware discovery with all error handling patterns.
Tested 2026-04-24 - handles IndexedPropertyItems, property errors, etc.
"""
import nisyscfg

def safe_get_property(resource, property_name, default="N/A"):
    """Safely get a resource property with fallback."""
    try:
        value = getattr(resource, property_name)

        # Handle IndexedPropertyItems (like expert_user_alias, expert_name)
        if hasattr(value, '__iter__') and not isinstance(value, str):
            value_list = list(value)
            return value_list[0] if value_list else default

        return value if value else default
    except:
        return default

def scan_ni_hardware(expert_filter=None):
    """
    Scan for NI hardware with optimized performance and robust error handling.

    Args:
        expert_filter: Comma-separated expert names (e.g., "ni-vst,ni-scope")
                      or None for all experts

    Returns:
        List of device dictionaries
    """
    print("Scanning for NI hardware...")

    # Optimization: Target localhost to skip network discovery
    with nisyscfg.Session(target="localhost") as session:
        # Create filter
        filt = session.create_filter()
        filt.is_present = True
        filt.is_device = True
        filt.is_ni_product = True

        # Use focused experts if provided (3-5x faster)
        devices = []
        for resource in session.find_hardware(filt, expert_names=expert_filter):
            try:
                # Safely extract all properties
                device = {
                    "Product": safe_get_property(resource, "product_name", "Unknown"),
                    "Serial": safe_get_property(resource, "serial_number"),
                    "Alias": safe_get_property(resource, "expert_user_alias"),
                    "Slot": safe_get_property(resource, "slot_number"),
                    "Expert": safe_get_property(resource, "expert_name"),
                    "Link": safe_get_property(resource, "provides_link_name"),
                }

                # Optional: Filter by bus type
                link = device["Link"]
                if link and link != "N/A":
                    if not (link.startswith("PXI") or link.startswith("PCI")):
                        continue  # Skip USB, GPIB, etc.

                devices.append(device)

            except Exception as e:
                # Isolate per-resource failures
                print(f"Warning: Skipped resource due to error: {e}")
                continue

        return devices

# Example usage
if __name__ == "__main__":
    # For RF equipment: use focused expert list
    experts = "ni-vst,ni-rfsg,ni-rfsa,ni-scope,nidcpower,nifgen,ni-5655"
    devices = scan_ni_hardware(experts)

    if devices:
        print(f"\nFound {len(devices)} device(s):\n")

        for i, dev in enumerate(devices, 1):
            # Extract to variables to avoid f-string quote issues
            product = dev["Product"]
            alias = dev["Alias"]
            serial = dev["Serial"]
            slot = dev["Slot"]

            print(f"{i}. {product}")
            print(f"   Alias: {alias}")
            print(f"   Serial: {serial}")
            print(f"   Slot: {slot}")
            print()

        # Summary
        from collections import Counter
        counts = Counter(d["Product"] for d in devices)
        print("Summary:")
        for product, count in counts.items():
            aliases = [d["Alias"] for d in devices 
                      if d["Product"] == product and d["Alias"] != "N/A"]
            alias_str = f" ({', '.join(aliases)})" if aliases else ""
            print(f"  - {product}: {count}{alias_str}")
    else:
        print("\nNo NI hardware found.")
```

**Key Features:**
- ✅ Handles `IndexedPropertyItems` correctly
- ✅ Isolates property access failures
- ✅ Uses localhost targeting for speed
- ✅ Focused expert filtering
- ✅ No f-string quote escaping issues
- ✅ Complete error recovery
- ✅ Clean, readable output

**Performance:** Typically completes in 2-5 seconds vs 10-30 seconds without optimizations.

