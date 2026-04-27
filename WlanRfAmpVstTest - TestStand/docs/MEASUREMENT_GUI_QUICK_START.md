# Running a Measurement with WlanRfAmpTest ModuleRunner GUI

**Date:** 2026-04-24  
**Hardware Detected:** PXIe-5842 (VST), PXIe-5655 (LO Source)  
**GUI Launched:** WlanRfAmpTest.ModuleRunner.exe

---

## 🎯 Quick Start Guide

### 1. **GUI Configuration**

The **WLAN RF Amplifier — Measurement modules** GUI is now running. Configure it with your hardware:

#### **Resource Name Field:**
- Current default: `"5841"`
- **Change to:** `"5842"` (your detected PXIe-5842 alias)
- Alternative formats that work:
  - `"5842"` (alias - recommended)
  - `"PXI1Slot4"` (slot-based)
  - `"PXI1::4::INSTR"` (VISA format)

#### **Measurement Type:**
Select from dropdown:
- **EVM (OFDM ModAcc)** - Error Vector Magnitude measurement
- **TxP** - Transmit Power measurement
- **SEM** - Spectral Emission Mask
- **EVM + TxP composite** - Combined measurement

**Recommended for first test:** Start with "EVM (OFDM ModAcc)"

---

### 2. **Test Parameters**

#### **Frequency:**
- Default: 2.412 GHz (Channel 1, 2.4 GHz band)
- Adjust as needed for your test
- Format: Use scientific notation (e.g., "2.412e9 Hz")

#### **Band:**
- **2.4 GHz** - Channels 1-14
- **5 GHz** - Channels 36-165

#### **Standard:**
- **802.11ac** - Wi-Fi 5
- **802.11ax** - Wi-Fi 6 (default)

#### **Bandwidth:**
- **20 MHz** (default)
- **40 MHz**
- **80 MHz**

---

### 3. **Waveform Configuration**

You need a TDMS waveform file for signal generation.

**Option A: Use existing waveform** (if available)
- Click **"Browse TDMS..."**
- Navigate to waveform file
- Select TDMS file containing WLAN signal

**Option B: Generate waveform** (if needed)
- The project may include waveform generation utilities
- Check: `Documents\WlanRfAmpVstTest\waveforms.json`
- Or use NI RFmx Waveform Creator

---

### 4. **Hardware Connection**

**For Loopback Test (no amplifier):**
```
PXIe-5842 TX → PXIe-5842 RX (loopback cable)
```

**For Amplifier Test:**
```
PXIe-5842 TX → RF Amplifier (DUT) → PXIe-5842 RX
```

**With LO Source:**
```
PXIe-5655 provides reference signals to PXIe-5842
(Automatically configured via PXI backplane)
```

---

### 5. **Running the Measurement**

1. ✅ **Configure resource:** Change `"5841"` → `"5842"`
2. ✅ **Select measurement type:** e.g., "EVM (OFDM ModAcc)"
3. ✅ **Set frequency/band/standard:** Default values OK for first test
4. ✅ **Browse for TDMS waveform:** Required for signal generation
5. ✅ **Connect hardware:** TX → RX (or TX → Amp → RX)
6. ✅ **Click "Run measurement"**

---

### 6. **Expected Results**

The GUI will display:

**Results Grid:**
- EVM values (data subcarriers, pilot subcarriers)
- Frequency error
- IQ offset
- Power measurements
- Spectral mask results (if SEM selected)

**Chart:**
- Bar chart visualization of results
- Color-coded pass/fail indicators

**Log Tab:**
- Detailed measurement log
- Error messages (if any)
- Hardware initialization status

---

### 7. **Saving Results**

After successful measurement:
- Click **"Save results to CSV..."**
- Results saved with all measurement parameters
- Can be used for validation/regression testing

---

## ⚠️ Troubleshooting

### **"Resource not found" error**

**Solution:** Check resource name format
```
Try these in order:
1. "5842" (alias)
2. "PXI1Slot4" (slot-based)
3. Run: python scan_rf_hardware.py to verify alias
```

### **"No waveform file" error**

**Solution:** TDMS waveform is required
- Check project documentation for waveform location
- May need to generate waveforms first
- Look in: `Documents\WlanRfAmpVstTest\` folder

### **Measurement timeout**

**Solution:** 
- Check physical cable connections
- Verify TX power level isn't too low/high
- Check RF amplifier (if used) is powered on
- Verify frequency is within device range (DC-6 GHz for 5842)

### **Driver initialization error**

**Solution:**
- Close GUI
- Run: `cd build-tools; .\Quick-Check.ps1`
- Verify NI-RFmx WLAN v23.8 is installed
- Restart GUI

---

## 📊 Hardware Capabilities (PXIe-5842)

| Spec | Value |
|------|-------|
| Frequency Range | DC to 6 GHz |
| Instantaneous BW | Up to 500 MHz |
| TX Power Range | -70 to +10 dBm (typical) |
| RX Dynamic Range | >80 dB |
| Supports | 802.11a/b/g/n/ac/ax |

Perfect for WLAN amplifier testing across all bands and standards!

---

## 🎯 Next Steps

1. **First test:** Run loopback (TX → RX) to verify hardware and GUI work
2. **With amplifier:** Insert DUT between TX and RX
3. **Sweep parameters:** Change frequency, BW, standard to test full range
4. **Save baseline:** Capture CSV for regression testing
5. **Iterate:** Adjust amplifier settings, re-measure, compare

---

**GUI Status:** ✅ Running  
**Hardware:** ✅ Detected and ready  
**Configuration:** Update resource name to `"5842"` and you're ready to measure!

Good luck with your measurements! 🚀
