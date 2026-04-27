"""
Scan for NI RF hardware suitable for WLAN RF amplifier testing.
Uses nisyscfg-equipment-discovery skill with optimizations.
"""
import nisyscfg

print("Scanning for NI RF Test Equipment...")
print("=" * 80)

# Target localhost and use focused experts for RF equipment
with nisyscfg.Session(target="localhost") as session:
    # Create filter for NI devices only
    filt = session.create_filter()
    filt.is_present = True
    filt.is_device = True
    filt.is_ni_product = True

    # Focus on RF-capable experts (VST, RFSG, RFSA, Scope, etc.)
    experts = "ni-vst,ni-rfsg,ni-rfsa,ni-scope,nidcpower,nifgen,ni-5655"

    devices = []
    for resource in session.find_hardware(filt, expert_names=experts):
        try:
            # Get safe properties with fallbacks
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

            alias = "N/A"
            try:
                alias_val = resource.expert_user_alias
                # Handle IndexedPropertyItems by iterating
                if hasattr(alias_val, '__iter__') and not isinstance(alias_val, str):
                    alias_list = list(alias_val)
                    if alias_list:
                        alias = alias_list[0]
                elif alias_val:
                    alias = str(alias_val)
            except:
                pass

            slot = "N/A"
            try:
                slot = resource.slot_number
            except:
                pass

            expert = "N/A"
            try:
                expert_val = resource.expert_name
                # Handle IndexedPropertyItems by iterating
                if hasattr(expert_val, '__iter__') and not isinstance(expert_val, str):
                    expert_list = list(expert_val)
                    if expert_list:
                        expert = expert_list[0]
                elif expert_val:
                    expert = str(expert_val)
            except:
                pass

            link = "N/A"
            try:
                link = resource.provides_link_name
            except:
                pass

            # Filter to PXI/PCI buses only (skip USB, GPIB)
            if link and link != "N/A":
                if not (link.startswith("PXI") or link.startswith("PCI")):
                    continue

            devices.append({
                "Alias": alias,
                "Product": product,
                "Serial": serial,
                "Slot": slot,
                "Expert": expert,
                "Link": link
            })
        except Exception as e:
            # Skip resources with errors
            continue

    if devices:
        print(f"Found {len(devices)} RF-capable device(s):\n")
        for i, dev in enumerate(devices, 1):
            prod = dev["Product"]
            al = dev["Alias"]
            ser = dev["Serial"]
            sl = dev["Slot"]
            exp = dev["Expert"]
            lnk = dev["Link"]

            print(f"{i}. {prod}")
            print(f"   Alias: {al}")
            print(f"   Serial: {ser}")
            print(f"   Slot: {sl}")
            print(f"   Expert: {exp}")
            print(f"   Bus: {lnk}")
            print()

        # Summary by product type
        from collections import Counter
        product_counts = Counter(d["Product"] for d in devices)
        print("Summary:")
        for product, count in product_counts.items():
            aliases = [d["Alias"] for d in devices if d["Product"] == product and d["Alias"] != "N/A"]
            alias_str = f" ({', '.join(aliases)})" if aliases else ""
            print(f"  - {product}: {count}{alias_str}")

        print("\n" + "=" * 80)
        print("Hardware Assessment for WlanRfAmpTest Project:")
        print("=" * 80)

        # Check for required hardware
        has_rfsg = any("5840" in d["Product"] or "5841" in d["Product"] or "RFSG" in d["Expert"] for d in devices)
        has_rfsa = any("5842" in d["Product"] or "5665" in d["Product"] or "5663" in d["Product"] or "RFSA" in d["Expert"] for d in devices)
        has_vst = any("VST" in d["Product"] or "5840" in d["Product"] or "5841" in d["Product"] or "5842" in d["Product"] for d in devices)

        if has_rfsg or has_vst:
            print("✓ RF Signal Generator (RFSG) detected - Can generate test signals")
        else:
            print("✗ No RF Signal Generator found")
            print("  Required: NI PXIe-5840, PXIe-5841, or similar RFSG/VST device")

        if has_rfsa or has_vst:
            print("✓ RF Signal Analyzer (RFSA) detected - Can measure WLAN signals")
        else:
            print("✗ No RF Signal Analyzer found")
            print("  Required: NI PXIe-5842, PXIe-5665, or similar RFSA/VST device")

        if (has_rfsg or has_vst) and (has_rfsa or has_vst):
            print("\n✓✓ System is ready for WLAN RF amplifier testing!")
        else:
            print("\n⚠ Missing required hardware - Cannot run full test")

    else:
        print("No RF-capable NI hardware found.")
        print()
        print("This project requires:")
        print("  - NI RF Signal Generator (RFSG) - e.g., PXIe-5840, PXIe-5841")
        print("  - NI RF Signal Analyzer (RFSA) with RFmx WLAN - e.g., PXIe-5842, PXIe-5665")
        print()
        print("Note: VST (Vector Signal Transceiver) devices like PXIe-5840/5841/5842")
        print("      combine both RFSG and RFSA capabilities in a single module.")

print("\nSkill used: nisyscfg-equipment-discovery")
