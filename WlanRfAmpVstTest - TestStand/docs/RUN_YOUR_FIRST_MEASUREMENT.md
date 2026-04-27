# Step-by-Step Measurement Instructions

**GUI Status:** ✅ Running (WlanRfAmpTest.ModuleRunner.exe)  
**Hardware:** ✅ PXIe-5842 (Slot 4, Alias: "5842"), PXIe-5655 (Slot 7, Alias: "5655")  
**Waveforms:** ✅ Available in `config/Waveforms/` folder

---

## 🎯 **Run Your First Measurement (2 Minutes)**

### **Step 1: Configure Resource Name**
In the GUI, find the **"Resource"** textbox (currently shows "5841"):
1. **Change from:** `5841`
2. **Change to:** `5842`

   ✅ This matches your detected PXIe-5842 hardware

---

### **Step 2: Select Measurement Type**
In the **dropdown at top**, select:
- ✅ **"EVM (OFDM ModAcc)"** ← Start with this for first measurement

---

### **Step 3: Set Test Parameters**

**Frequency:**
- ✅ Keep default: `2.412 GHz` (2.4 GHz band, Channel 1)

**Band:**
- ✅ Select: **"2.4 GHz"**

**Standard:**
- ✅ Select: **"802.11ax"** (Wi-Fi 6)

**Bandwidth:**
- ✅ Select: **"20"** MHz

---

### **Step 4: Select Waveform File**

1. Click **"Browse TDMS..."** button
2. Navigate to: `C:\Users\LocalAdmin\Source\Repos\RF-Test_Sequencer-AI-Demo\WlanRfAmpVstTest - TestStand\config\Waveforms\`
3. Select: **`2.4GHz_802.11ax_20MHz.tdms`**
4. Click **Open**

   ✅ This matches your configured parameters (2.4GHz, 802.11ax, 20MHz)

---

### **Step 5: Verify Configuration**

Your GUI should now show:
```
Measurement Type: EVM (OFDM ModAcc)
Frequency: 2.412e9 Hz (or 2.412 GHz)
Band: 2.4 GHz
Standard: 802.11ax
Bandwidth: 20
TDMS: C:\...\2.4GHz_802.11ax_20MHz.tdms
Resource: 5842
```

---

### **Step 6: Hardware Setup**

**IMPORTANT:** Physical cable connections

**Option A - Loopback Test** (No amplifier, verify system works):
```
┌────────────┐
│ PXIe-5842  │
│            │
│ TX ─────┐  │
│         │  │
│ RX ◄────┘  │ ← Connect TX port directly to RX port
└────────────┘   (Use short RF cable or attenuator if needed)
```

**Option B - Amplifier Test** (Actual DUT measurement):
```
┌────────────┐     ┌─────────┐     ┌────────────┐
│ PXIe-5842  │     │   RF    │     │ PXIe-5842  │
│            │     │   Amp   │     │            │
│ TX ────────┼────►│  (DUT)  ├────►│ RX         │
└────────────┘     └─────────┘     └────────────┘
                   ↑ Ensure amp is powered on
```

**⚠️ Power Level Warning:**
- For loopback: May need **attenuator** (10-30 dB) to avoid overload
- For amplifier: Verify amplifier input power spec matches TX output

---

### **Step 7: Run Measurement**

1. ✅ Click **"Run measurement"** button
2. **Wait for measurement to complete** (typically 5-30 seconds)
3. Watch the **status bar** at top for progress

**What happens:**
- RFSG generates WLAN signal from TDMS waveform
- Signal goes through your setup (loopback or amplifier)
- RFSA captures and analyzes signal with RFmx WLAN
- Results displayed in grid and chart

---

### **Step 8: Review Results**

**Results Grid (lower left):**
Look for key metrics:
- **`composite_EVM_mean_dB`** - Overall EVM performance (lower is better)
  - Good: < -25 dB
  - Excellent: < -30 dB
- **`data_EVM_mean_dB`** - Data subcarrier EVM
- **`pilot_EVM_mean_dB`** - Pilot subcarrier EVM
- **`frequency_error_mean_Hz`** - Frequency offset
- **`IQ_origin_offset_dB`** - IQ imbalance

**Chart (upper right):**
- Bar chart shows EVM values color-coded
- Green = good, Red = issues

**Log Tab (lower panel):**
- Detailed measurement steps
- Any errors or warnings
- Timing information

---

### **Step 9: Save Results** (Optional)

After successful measurement:
1. Click **"Save results to CSV..."**
2. Choose filename and location
3. Results saved with all parameters for later analysis

---

## ✅ **Expected First-Run Results**

### **Loopback (No Amplifier):**
```
composite_EVM_mean_dB: -35 to -40 dB (Excellent)
data_EVM_mean_dB: -35 to -40 dB
pilot_EVM_mean_dB: -38 to -43 dB
frequency_error_mean_Hz: < ±100 Hz
Status: PASS - System working perfectly
```

### **With Amplifier:**
```
Depends on amplifier quality:
Good amp: -28 to -32 dB EVM
Fair amp: -25 to -28 dB EVM
Poor amp: -20 to -25 dB EVM (may still meet spec)
Failing amp: > -20 dB EVM (investigate)
```

---

## 🔄 **Try Other Measurements**

After successful first run, experiment with:

### **Different Bandwidths:**
- Change BW dropdown: 20 → 40 → 80 MHz
- **Must select matching waveform:** e.g., `2.4GHz_802.11ax_40MHz.tdms` for 40 MHz

### **Different Standards:**
- 802.11ax (Wi-Fi 6) vs 802.11ac (Wi-Fi 5)
- **Must select matching waveform:** Check filename

### **Different Frequencies:**
**2.4 GHz Band:**
- 2.412 GHz (Ch 1)
- 2.437 GHz (Ch 6)
- 2.462 GHz (Ch 11)

**5 GHz Band:**
- 5.180 GHz (Ch 36)
- 5.500 GHz (Ch 100)
- 5.745 GHz (Ch 149)
- **Must select 5GHz waveforms** from folder

### **Other Measurement Types:**
- **TxP** - Transmit power measurement
- **SEM** - Spectral emission mask compliance
- **EVM + TxP composite** - Combined measurement

---

## ⚠️ **Troubleshooting Common Issues**

### **"Resource 5842 not found"**
**Cause:** Driver can't find hardware  
**Fix:**
1. Verify hardware scan: `python scan_rf_hardware.py`
2. Try alternative names: `"PXI1Slot4"` or `"PXI1::4::INSTR"`
3. Check NI-RFmx driver installation: `cd build-tools; .\Quick-Check.ps1`

### **"Waveform file not found"**
**Cause:** TDMS path is incorrect  
**Fix:**
1. Click "Browse TDMS..." and manually select file
2. Verify file exists in `config/Waveforms/` folder
3. Use full path: `C:\Users\LocalAdmin\Source\Repos\...\2.4GHz_802.11ax_20MHz.tdms`

### **"Measurement timeout" or "Acquisition failed"**
**Cause:** No signal reaching RX  
**Fix:**
1. ✅ Verify physical cable connections (TX → RX)
2. ✅ Check amplifier is powered on (if used)
3. ✅ Verify frequency is in range (5842 supports DC-6GHz)
4. ✅ Add attenuator for loopback test (may be overloading RX)

### **Very poor EVM (> -15 dB)**
**Cause:** Signal overload or amplifier distortion  
**Fix:**
1. For loopback: Add 20-30 dB attenuator
2. For amplifier: Reduce TX power or check amp specs
3. Verify amplifier isn't saturating (output power too high)

### **GUI crashes or freezes**
**Cause:** Driver or hardware initialization issue  
**Fix:**
1. Close GUI completely
2. Reset hardware: Unplug/replug PXI chassis power
3. Relaunch GUI
4. If persists: Run `dotnet build --no-restore` and retry

---

## 📊 **Understanding Your Results**

### **EVM (Error Vector Magnitude)**
- Measures signal quality degradation
- **Lower is better** (more negative dB)
- Typical specs:
  - 802.11ax requires: ≤ -25 dB for MCS0-9
  - 802.11ac requires: ≤ -27 dB for MCS0-8

### **What Good EVM Means:**
- ✅ Amplifier has low distortion
- ✅ Frequency response is flat
- ✅ Phase linearity is good
- ✅ Meets Wi-Fi certification requirements

### **What Poor EVM Indicates:**
- ⚠️ Amplifier non-linearity
- ⚠️ Frequency response ripple
- ⚠️ Phase distortion
- ⚠️ Insufficient gain or too much gain

---

## 🎯 **Next Steps**

1. ✅ **Run your first loopback test** to verify system works
2. ✅ **Insert amplifier** and run real DUT measurement
3. ✅ **Sweep frequencies** across 2.4 GHz and 5 GHz bands
4. ✅ **Test all bandwidths** (20, 40, 80 MHz)
5. ✅ **Save results to CSV** for comparison and trending
6. ✅ **Iterate** - Adjust amp settings, re-measure, optimize

---

**You're all set! The GUI is running, hardware is ready, waveforms are available. Just configure the resource name to "5842" and click "Run measurement"!** 🚀

---

## 📁 Available Waveforms

All located in: `config/Waveforms/`

**2.4 GHz Band (Ch 1-14):**
- `2.4GHz_802.11ac_20MHz.tdms` (2.1 MB)
- `2.4GHz_802.11ac_40MHz.tdms` (2.1 MB)
- `2.4GHz_802.11ac_80MHz.tdms` (2.1 MB)
- `2.4GHz_802.11ax_20MHz.tdms` (1.9 MB) ← **Start with this**
- `2.4GHz_802.11ax_40MHz.tdms` (2.0 MB)
- `2.4GHz_802.11ax_80MHz.tdms` (2.0 MB)

**5 GHz Band (Ch 36-165):**
- `5GHz_802.11ac_20MHz.tdms` (2.1 MB)
- `5GHz_802.11ac_40MHz.tdms` (2.1 MB)
- `5GHz_802.11ac_80MHz.tdms` (2.1 MB)
- `5GHz_802.11ax_20MHz.tdms` (1.9 MB)
- `5GHz_802.11ax_40MHz.tdms` (2.0 MB)
- `5GHz_802.11ax_80MHz.tdms` (2.0 MB)

**Bonus:**
- `11ax_80M_MCS11.tdms` (641 KB) - Special high-MCS waveform

---

**Status:** ✅ Everything ready for your first measurement!
