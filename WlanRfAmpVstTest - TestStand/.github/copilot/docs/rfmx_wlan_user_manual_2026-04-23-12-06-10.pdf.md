RFmx WLAN
User Manual

2026-04-23

RFmx WLAN User Manual

Contents
Contents

RFmx WLAN User Manual  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   3
RFmx WLAN Overview  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   4
RFmx WLAN System Requirements . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   5
Supported Hardware . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   6
New Features and Changes  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   7
Concepts . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   12
OFDM ModAcc . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   12
Common Pilot Error in OFDM Standards  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   12
Trigger-Based PPDU ModAcc . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   14
Unused Tone Error Measurement . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   14
Vector Averaging . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   16
DSSS ModAcc Measurements  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   18
Spectral Emission Mask (SEM)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   19
General . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   22
ModAcc Power Measurement  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   22
IQ Impairments . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   23

2 ni.com

RFmx WLAN User Manual

User Manual
RFmx WLAN  User Manual
RFmx WLAN

The RFmx WLAN User Manual provides detailed descriptions of the product
functionality and the step by step processes for use.

Looking for Something Else?

For information not found in the User Manual for your product, such as specifications
and API reference, browse Related Information.

Related information:

•  Download RFmx WLAN
•  Interactive Activation Guide
•  RFmx WLAN Release Notes
•  Getting Started with RFmx
•  RFmx WLAN LabVIEW Reference
•  RFmx WLAN .NET Reference
•  RFmx WLAN C Reference
•  RFmx Instr LabVIEW Reference
•  RFmx Instr .NET Reference
•  RFmx Instr C Reference

© National Instruments 3

RFmx WLAN Overview

RFmx WLAN Overview
RFmx WLAN Overview

This user manual contains introduction to RFmx WLAN measurement concepts.

RFmx WLAN is a measurement personality that extends the capability of NI RF
instrumentation for WLAN 802.11 signal generation and analysis. This software helps
you analyze 802.11a/b/g/j/p/n/ac/ax/be/bn signals up with standard-compliant,
physical layer measurements such as error vector magnitude (EVM), spectrum
emission mask (SEM), transmit power (TXP). Additionally, you can use RFmx WLAN to
generate and analyze up to 8x8 multiple-input and multiple-output (MIMO) single- and
multi-user signals with flexible configuration, impairments, and results for every user.

4 ni.com

RFmx WLAN System Requirements

System Requirements
RFmx WLAN  System Requirements
RFmx WLAN

RFmx WLAN has the following requirements:

•  Processor—1 GHz 64-bit (x64) processor
•  4 GB RAM *
•  A screen resolution of 1,024 x 768
•  Any supported OS, with all available critical updates and service packs

* Depending on the amount of data acquired and/or processed, a larger amount of
memory may be required.

© National Instruments 5

Supported Hardware

Supported Hardware
Supported Hardware

RFmx supports a number of NI devices.

Table 1. RFmx WLAN Hardware

RFmx WLAN Hardware

Earliest Driver Version Support (Windows 11)

PXIe-5646

PXIe-5820

PXIe-5830

PXIe-5840

PXIe-5841 (1 GHz Bandwidth)

PXIe-5842

PXIe-5860

PXIe-5668

2022 Q3

2022 Q3

2022 Q3

2022 Q3

2022 Q3

2022 Q4

2024 Q3

2022 Q3

Note  Some RFmx Instr properties and RFmx WLAN properties do not
support all devices. To identify device support, refer to the specific property
in the NI-RFSA Properties section of the NI-RFSA LabVIEW VI Reference.

For more information about your hardware and functionality, refer to the NI-RFSA User
Manual.

Related information:

•  NI-RFSA User Manual
•  NI-RFSA Properties

6 ni.com

RFmx WLAN New Features and Changes

New Features and Changes
RFmx WLAN  New Features and Changes
RFmx WLAN

Learn about updates, including new features and behavior changes, introduced in
each version of RFmx WLAN.

Discover what is new in the latest releases of RFmx WLAN.

Note If you cannot find new features and changes for your version, it might
not include user-facing updates. However, your version might include non-
visible changes such as bug fixes and compatibility updates. For information
about non-visible changes, refer to your product Release Notes.

Related information:

•  RFmx WLAN Release Notes
•  Software and Driver Downloads

RFmx WLAN 2026 Q2 Changes

RFmx WLAN 2026 Q2 adds support for Modulation Accuracy (ModAcc), Spectral
Emission Mask (SEM), and Transmit Power (TxP) measurements compliant with IEEE
P802.11bn/D1.3. This release also enhances UHR ModAcc capabilities with Wiener
interpolation for distributed RU packets, frequency‑selective IQ impairment support,
and Non‑HT Duplicate mode support. This release also enables automatic standard
detection for UHR.

New Features

This version of RFmx WLAN adds support for the following features:

•  Modulation Accuracy, SEM, and TxP measurement support for 802.11bn, compliant
with IEEE P802.11bn/D1.3 specification covering salient features like Distributed
RUs including 60 MHz variant, Unequal Modulation, 2x LDPC Decoding, New MCS
indices, Enhanced long range (ELR) and Interference Mitigation.

•  Wiener interpolation filter in ModAcc measurement for UHR distributed RU

packets.

© National Instruments 7

RFmx WLAN New Features and Changes

•  Tx Frequency Selective IQ Impairment Support for UHR packets.
•  Autodetection of Standard for UHR packets.
•  ModAcc support for UHR Non-HT duplicate mode.
•  RFmx WLAN MIMO for PXIe-5860.

RFmx WLAN 2026 Q1 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2026
Q1.

•  Modulation Accuracy, SEM and TxP measurement support for 802.11bn, compliant
with IEEE P802.11bn/D1.2 specification covering salient features like Distributed
RUs including 60MHz variant, Unequal Modulation, 2x LDPC Decoding, New MCS
indices, Enhanced long range (ELR) and Interference Mitigation.

•  Added support for LTF Averaging to perform channel smoothing in time domain

using multiple LTF symbols.

•  Added support for header decoding results for the new features of 802.11bn, like

RU Type, Distribution Bandwidth (Hz), 2xLDPC Enabled, IM Pilots Enabled,
Unequal Modulation Enabled and Unequal Modulation Pattern Index.

•  Added support for skipping decoding of header fields for the 802.11bn standard for

ModAcc measurement.

RFmx WLAN 2025 Q4 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2025
Q4.

•  Modulation Accuracy, SEM and TxP measurement support for 802.11bn, compliant
with IEEE P802.11bn/D1.0 specification covering salient features like Distributed
RUs including 60MHz variant, Unequal Modulation, 2x LDPC Decoding, New MCS
indices, Enhanced long range (ELR) and Interference Mitigation.

•  Added support for 802.11bn Gated Power and Fields Power measurements.
•  Added Group mode support for 802.11bn RU Allocation configurations.
•  Updated SEM Masks for all the supported older WLAN standards as per IEEE

Standard 802.11- 2024.

•  Added support for Python API.

8 ni.com

RFmx WLAN New Features and Changes

RFmx WLAN 2025 Q3 Patch 2 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2025
Q3 Patch 2.

•  Updated SEM Masks for all the OFDM standards as per IEEE Standard 802.11- 2024.

RFmx WLAN 2025 Q3 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2025
Q3.

•  Support for Self-Cal Validity Check for PXIe-5860.
•  Modulation Accuracy, SEM and TxP measurement support for 802.11bn, compliant
with IEEE P802.11bn/D0.3 specification covering salient features like Distributed
RUs including 60MHz variant, Unequal Modulation, 2x LDPC Decoding, New MCS
indices and Enhanced long range (ELR).

RFmx WLAN 2025 Q2 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2025
Q2.

•  Early access ModAcc support for 802.11bn compliant with IEEE P802.11bn/D0.1

specification covering salient features like Distributed RUs, Unequal Modulation,
2x LDPC Decoding and New MCS indices.

•  Channelization support (320MHz-1, 320MHz-2) added for 802.11be standard

RFmx WLAN 2024 Q4 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2024
Q4.

•  802.11be standard complies with IEEE P802.11be/D7.0 specification.

© National Instruments 9

RFmx WLAN New Features and Changes

Behavior Changes

•  Uninstalling RFmx WLAN software also removes any previous versions of RFmx

WLAN .NET runtimes that were leaked in .NET Global Assembly Cache directory.

RFmx WLAN 2024 Q3 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2024
Q3.

•  802.11be standard complies with IEEE P802.11be/D6.0 specification
•  Support for PXIe-5860

RFmx WLAN 2024 Q2 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2024
Q2.

•  Added support for Common Pilot Trace with LTF normalization
•  Added support for 802.11be standard to be compliant with IEEE P802.11be/D5.0.1

specification

•  Added support for RFmx WLAN MIMO Measurement Interactive Panel
•  Obsoleted the RFmxInstr Load All Configurations VI. Use the RFmxInstr Load

Configurations VI along with the appropriate RFmxInstr Load Options
property, instead.

RFmx WLAN 2024 Q1 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2024
Q1.

•  Added support for 802.11be Standard IEEE P802.11be/D5.0.
•  Improvements to preamble detection algorithm to handle higher IQ Origin Offset.

RFmx WLAN 2023 Q4 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2023

10 ni.com

RFmx WLAN New Features and Changes

Q4.

•  Added support for 802.11be Standard IEEE P802.11be/D4.0

RFmx WLAN 2023 Q3 Changes

Learn about new features, behavior changes, and other updates in RFmx WLAN 2023
Q3.

•  Added support for 802.11be Standard IEEE P802.11be/D3.2.
•  Added support for auto detection of signal in Analysis-Only Mode.
•  Added support for saving and loading RFmx configurations into/from rfmxconfig

files. Load from TDMS is supported but save into TDMS files is discontinued.

© National Instruments 11

RFmx WLAN New Features and Changes

Common Pilot Error in OFDM Standards
Common Pilot Error in OFDM Standards

Common Pilot Error (CPE) represents the following imperfections that affect
demodulation:

•  Amplitude jitter across time
•  Residual Carrier Frequency Offset (CFO) caused due to close-in phase noise of the

system

OFDM signals for WLAN transmit the pilot subcarriers with a known data sequence.
This information is used to determine the error, in amplitude and phase, between an
ideal signal and the received signal. This error data, known as CPE, is used to correct
imperfections on both the pilot subcarriers and the data subcarriers. This correction
results in more accurate demodulation.

Estimation and correction of the phase error component in CPE is mandatory in the
Transmitter Modulation Accuracy (Error Vector Magnitude) Test as defined in sections
17.3.9.8, 19.3.18.7.4, and 21.3.17.4.4 of IEEE Standard 802.11-2016, section 27.3.18.4.4
of IEEE Standard P802.11ax/D8.0, section 36.3.20.4.4 of IEEE Standard P802.11be/D7.0
and section 38.3.25.4.3 of IEEE Standard P802.11bn/D1.3.

Note Estimation and correction of Amplitude Error component of CPE is
optional.

The following figure describes the procedure to compute CPE.

You can obtain the CPE for the received pilot subcarrier by correlating the received

12 ni.com

pilot subcarrier with its ideal value.

The CPE for symbol l is as follows.

RFmx WLAN New Features and Changes

Where the values are the following.

•  Amp(.) represents the amplitude component of a complex signal.
•  Ph(.) represents the phase component of a complex signal.
•  k is the pilot subcarrier index.
•  M is the number of pilot subcarriers.
•  X(k) is the received pilot subcarrier at index k.
•  XI(k) is the ideal pilot subcarrier at index k.

If CPE tracking is enabled (Amplitude Tracking Enabled and Phase Tracking Enabled
properties), all subcarriers are reduced by the amplitude error δl and de-rotated by the
phase error ∅l, for each symbol. The corrected subcarrier for symbol l is given by

where

•  Xr(k) is the received subcarrier at index k

Note CPE result is the RMS value of the phase error component of CPE
across all symbols.

© National Instruments 13

RFmx WLAN New Features and Changes

Trigger-Based PPDU ModAcc
Trigger-Based PPDU ModAcc

Trigger-based (TB) PPDU in 802.11ax, 802.11be or 802.11bn is transmitted in response
to a trigger frame. The trigger frame allocates resources and carries the information
required to construct a TB PPDU. Hence, the TB PPDU header does not contain
Resource Unit (RU), Modulation and Coding Scheme (MCS), and guard interval
information. You must configure RU and MCS for performing a ModAcc measurement.

The key results of this measurement are Composite RMS EVM Mean, Frequency Error
Mean, Frequency Error CCDF 10%, Symbol Clock Error Mean, and Unused Tone Error
Margin. When you set the OFDM Header Decoding Enabled property to True, you must
configure the following properties:

•  MCS Index
•  RU Size
•  RU Offset/MRU Index
•  RU Type
•  Distribution Bandwidth (Hz)
•  Guard Interval Type
•  LTF Size
•  PE Disambiguity
•  Space Time Stream Offset
•  2xLDPC Enabled
•  Number of HE-LTF Symbols
•  MU-MIMO LTF Mode Enabled

Unused Tone Error Measurement
Unused Tone Error Measurement

The unused tone error test is an additional modulation accuracy (ModAcc) test for the
unoccupied subcarriers in a HE or EHT or UHR TB PPDU, as defined in section
27.3.18.4.4 of IEEE P802.11ax/D8.0 or section 36.3.20.4.4 of IEEE Standard P802.11be/
D7.0, or section 38.3.26.4.4 of IEEE Standard P802.11bn/D1.3, respectively.

Calculate the unused tone error for each unused 26-tone resource unit (RU) by
averaging across 26 subcarriers and normalizing the value with the average power in
the occupied subcarriers.

14 ni.com

RFmx WLAN New Features and Changes

For example, the RU index for 20 MHz TB PPDU ranges from 0 to 8, with 0 being the left
most 26-tone RU and 8 being the right most 26-tone RU in the frequency axis. The
unused tone error mask, with respect to the RU index, is the standard specified
maximum limit for unused tone error as defined by the following equations.

where

•  iRU26,start is equal to the occupied RU index if the occupied RU is a 26-tone RU. For
more information on this index, see Table 27-50 of IEEE P802.11ax/D8.0 and Table
36-66 of IEEE P802.11be/D7.0 for other RU sizes.

•  r is the occupied RU bandwidth in units of a 26-tone RU.
•  iRU26,end is equal to iRU26,start + r − 1.
•  m defines the gap in the units of the 26-tone RU to the occupied RU. m is an integer

with m = ±1 being the adjacent 26-tone RUs.

•  ε is the relative constellation error for the HE TB PPDU defined in table 27-49 of

IEEE P802.11ax/D8.0 and Table 36-65 of IEEE P802.11be/D7.0.

The standard specifies two limits for UsedToneError. If the transmit power is less than
or equal to the maximum power of MCS7, a tighter mask is applied on the unused tone
error. Subsequently, if the transmit power is more than maximum power of MCS7, a
relaxed mask is applied.

In case of a non-contiguous multiple RU (MRU), the transmit modulation accuracy test
for the unoccupied subcarriers of the PPDU is performed by constructing the overall
relative constellation error staircase mask as following.

1.  Treat the non-contiguous MRU as a large RU/MRU that does not have an

unmodulated portion in between multiple RUs. For example, 2 x 996 + 484-tone
MRU is treated as 3 x 996-tone MRU

2.  Find the average unused subcarrier error vector magnitude for each unoccupied

© National Instruments 15

RFmx WLAN New Features and Changes

26-tone RU based on the large RU/MRU.

3.  Replace the unmodulated portion in between multiple RUs to max (ε – 2, – 38) dB.

The following figure is a graphical representation of the unused tone error
measurement for a 20 MHz 802.11ax TB PPDU with a 52-tone RU at offset 5.

where

•  [m0,...,mn]: Unused Tone Error Margin Vector (dB)
•  mmin: Unused Tone Error Margin (dB)
•  imin: Unused Tone Error Margin RU Index

Vector Averaging
Vector Averaging

You can use the vector averaging functionality in the OFDMModAcc measurement
when testing devices like power amplifiers and front-end modules in a test setup that
uses an NI signal generator for generating an RF stimulus signal for the device-under-
test (DUT) and an NI signal analyzer to perform measurements on the RF output signal
of the DUT. You can use vector averaging to reduce the impact of uncorrelated noise on
the measurement, originating from anywhere in the entire signal path.

Vector averaging averages the acquired I/Q data across averaging counts after aligning
the data in time and phase. I/Q data for each averaging count is obtained by
processing I/Q data in a record in a multi-record acquisition. Correction of relative time
offsets between records may cause the number of samples available for the

16 ni.com

RFmx WLAN New Features and Changes

OFDMModAcc measurement to be lesser than the number of samples in a record,
depending on the absolute value of the maximum time offset between records. Vector
averaging assumes that all records are aligned in center frequency and sampling
frequency.

Therefore, center frequency alignment and sampling frequency alignment are not
performed on acquired records. You must make sure that the frequency reference is
locked between the signal generator and the signal analyzer. Assume that si[l] denotes
acquired I/Q samples of record i for 0 ≤ l < L, where L is the number of samples in a
record, with 0 ≤ i < N, where N is the averaging count. Let s'i[m] denote I/Q samples of
averaging count i after correcting relative time and phase offsets of si[l], with 0 ≤ m < M
≤ L, where M is the number of samples available for averaging across all averaging
counts after alignment. The output samples after vector averaging are given by

The OFDMModAcc measurement is performed on the averaged I/Q data s[m].

Vector averaging reduces uncorrelated noise in the signal. In the vector averaged
signal s[m], the power ratio of the signal of interest and the uncorrelated noise is
increased by 10log(N) dB, as compared to the same power ratio in each of the acquired
I/Q data si[l]. However, after vector averaging, the improvement in the overall signal-
to-noise ratio and thus the EVM may be limited by correlated noise components such
as non-linearities. To determine the averaging count, you must check the amount of
EVM improvement for your device-under-test and test system for different averaging
counts.

To perform vector averaging, you must set the OFDMModAcc Averaging Type property
to Vector. You can control time and phase alignment operations through the
OFDMModAcc Vector Averaging Time Alignment Enabled and OFDMModAcc Vector
Averaging Phase Alignment Enabled properties, respectively. You can disable time
alignment if your test setup uses a precise and repetitive triggering mechanism where
all acquired records are triggered at the same relative position within the signal. You
can disable phase alignment if you are sharing the LO between the NI signal generator
and the NI signal analyzer. Disabling time and/or phase alignment may improve the

© National Instruments 17

RFmx WLAN New Features and Changes

measurement time.

In contrast to vector averaging, RMS averaging performs OFDMModAcc measurement
on each averaging count and then averages the measurement results. RMS averaging
can improve the standard deviation of the measurement results such as EVM, whereas
vector averaging can improve the mean value of the measurement results.

DSSS ModAcc Measurements
DSSS ModAcc Measurements

RFmx WLAN supports measurement of the modulation accuracy on signals conforming
to the DSSS PHY defined in section 15 and the High Rate DSSS PHY defined in section
16 of IEEE Standard 802.11-2016. The standard calls for EVM computation only on the
differential quadrature phase-shift keying (DQPSK) signal. However, DSSS ModAcc
measurement computes the EVM for all data rates and modulation schemes defined in
the above sections.

Along with sections 15.4.5.10/16.3.7.9 of IEEE Standard 802.11-2016, RFmx WLAN also
conforms to sections 18.4.7.8 of IEEE Standard 802.11b-1999 and 18.4.7.8 of IEEE
Standard 802.11-2007 to compute the EVM.

First, the deviation V(n) of the amplitude of the nth chip from the mean amplitude of
the packet is calculated as

where

•  XI (n) is the in-phase component of the received signal after removal of

impairment,

•  XQ (n) is the quadrature phase component of the received signal after removal of

impairment,

•  E is the expectation operator, and
•  n is the chip index with a range of 0 ≤ n < 1000
•  The EVM results of DSSS ModAcc measurement is then computed using the

18 ni.com

following equations from the standard specifications.

RFmx WLAN New Features and Changes

Spectral Emission Mask (SEM)
Spectral Emission Mask (SEM)

RFmx WLAN SEM measurement uses the configurations and masks conforming to IEEE
Standard 802.11-2016, IEEE Standard P802.11ax/D8.0, IEEE Standard P802.11be/D7.0,
and IEEE Standard P802.11bn/D1.3 specifications.

This section explains the configurations and masks that the RFmx WLAN SEM
measurement uses.

Offset Segments

The frequency ranges adjacent to the carrier channels on which some spectral
emission mask limit is imposed are collectively known as SEM offset segments.

The offset segments are specified by their start and stop frequencies relative to the
center frequency of the carrier channel. When you set the SEM Mask Type property to
Standard, the offset segments' start and stop frequencies and mask levels are
automatically configured according to the Standard property and the Channel
Bandwidth property, conforming to IEEE Standard specifications. Additionally, if you
set the Standard property to 802.11n, then the OFDM Freq Band property is also
considered for automatically configuring compliant offset segments.

© National Instruments 19

To manually configure the following properties for each offset segment, set the SEM
Mask Type property to Custom:

RFmx WLAN New Features and Changes

•  SEM Offset Start Freq (Hz)
•  SEM Offset Stop Freq (Hz)
•  SEM Offset Sideband
•  SEM Offset Rel Limit Start (dB)
•  SEM Offset Rel Limit Stop (dB)

The signs of the offset segment relative start and stop frequencies, specified by the
SEM Offset Start Freq (Hz) and SEM Offset Stop Freq (Hz) properties respectively, are
interpreted as shown in the following examples.

Configured by you

Measurement interpretation of the
configuration

SEM Offset Start Freq (Hz) ← +9 MHz SEM Offset
Stop Freq (Hz) ← +11 MHz

SEM Offset Start Freq (Hz) ← 9 MHz SEM Offset
Stop Freq (Hz) ← 11 MHz

SEM Offset Start Freq (Hz) ← –11 MHz SEM Offset
Stop Freq (Hz) ← –9 MHz

SEM Offset Start Freq (Hz) ← 9 MHz SEM Offset
Stop Freq (Hz) ← 11 MHz

SEM Offset Start Freq (Hz) ← –9 MHz SEM Offset
Stop Freq (Hz) ← +11 MHz

SEM Offset Start Freq (Hz) ← –9 MHz SEM Offset
Stop Freq (Hz) ← +11 MHz

The SEM Offset Rel Limit Start (dB) property and SEM Offset Rel Limit Stop (dB)
property determine the SEM mask level for each of the offset segments. The SEM Offset
Rel Limit Start (dB) property and the SEM Offset Rel Limit Stop (dB) property are mask
levels for the corresponding SEM Offset Start Freq (Hz) and SEM Offset Stop Freq (Hz)
of the specific offset segment. These mask levels are relative to the measured peak
power level in the carrier channel.

The resolution bandwidth and video bandwidth for performing the SEM measurement
conforms to the IEEE Standard 802.11-2016, IEEE Standard P802.11ax/D8.0, IEEE
Standard P802.11be/D7.0, and IEEE Standard P802.11bn/D1.3 specifications.

Preamble Puncturing

In accordance with the specifications in IEEE Standard P802.11ax/D8.0, IEEE Standard
P802.11be/D7.0 and IEEE Standard P802.11bn/D1.3, you can configure additional

20 ni.com

RFmx WLAN New Features and Changes

offset segments for the following,

•  80 MHz and 160 MHz MU PPDUs in 802.11ax.
•  80 MHz, 160 MHz, and 320 MHz MU PPDUs in 802.11be.
•  80 MHz, 160 MHz, and 320 MHz MU PPDUs in 802.11bn.

In the previous cases, the preamble is punctured (absent) from certain unoccupied
20 Mhz subchannels. To enable automatic configuration of such additional offset
segments, configure the following properties.

Property

Description

Standard

802.11ax, 802.11be or 802.11bn

Channel
Bandwidth (Hz)

•  80.000E+6, 160.000E+6 if you set the Standard property to 802.11ax.
•  80.000E+6, 160.000E+6, 320.000E+6 if you set the Standard property to

802.11be.

•  80.000E+6, 160.000E+6, 320.000E+6, if you set the Standard property to

802.11bn.

OFDM Preamble
Puncturing
Enabled

True

OFDM Preamble
Puncturing
Bitmap

An integer between 0x1 and 0xF for 80 MHz PPDU, an integer between 0x1 and
0xFF for 160 MHz PPDU, and an integer between 0x1 and 0xFFFF for 320 MHz
PPDU

0s and 1s in the binary representation of the integer OFDM Preamble Puncturing
Bitmap indicate the presence of a punctured 20 MHz subchannel and an active 20 MHz
subchannel, respectively. The Least Significant Bit corresponds to the lower frequency
20 MHz subchannel. OFDM Preamble Puncturing Bitmap is interpreted by the SEM
measurement as illustrated by the following examples for the 80 MHz PPDU.

OFDM Preamble Puncturing Bitmap

Active 20 MHz Subchannels

0x1

0x2

0xE

0b0000 0001

0b0000 0010

0b0000 1110

–40 MHz to –20 MHz

–20 MHz to 0 MHz

–20 MHz to 0 MHz, 0 MHz to 20

© National Instruments 21

RFmx WLAN New Features and Changes

OFDM Preamble Puncturing Bitmap

Active 20 MHz Subchannels

MHz, 20 MHz to 40 MHz

Similarly, for a 160 MHz PPDU, the bitmap interpretation is shown in the following
example.

OFDM Preamble Puncturing Bitmap

Active 20 MHz Subchannels

0x1

0x2

0x48

0b0000 0001

0b0000 0010

0b0100 1000

–80 MHz to –60 MHz

–60 MHz to –40 MHz

–20 MHz to 0 MHz, 40 MHz to 60 MHz

Similarly, for a 320 MHz PPDU, the bitmap interpretation is shown in the following
example.

OFDM Preamble Puncturing Bitmap  Active 20 MHz Subchannels

0x1

0x2

0b0000 0000 0000 0001

–160 MHz to –140 MHz

0b0000 0000 0000 0010

–140 MHz to –120 MHz

0x148

0b0000 0001 0100 1000

–100 MHz to –80 MHz, –40 MHz to –20 MHz, 0 MHz to 20 MHz

ModAcc Power Measurement
ModAcc Power Measurement

ModAcc power measurement computes power of the various fields in the PPDU and
over custom gates. The number of custom gates is specified by configuring the
Number of Custom Gates property and the custom gates interval is specified by
configuring the Custom Gate Start Time (s) and Custom Gate Stop Time (s) properties.
The following figure illustrates start time and stop time for custom gates.

22 ni.com

RFmx WLAN New Features and Changes

Power measurements for preamble and header are computed for the individual fields
present in them. The following figure illustrates the other different portions of the
WLAN packet and the corresponding power measurements supported.

IQ Impairments
IQ Impairments

IQ impairments are caused by the mismatch between the analog components of in-
phase and quadrature paths in the RF chain. IQ impairments are characterized by
three quantities, namely IQ gain imbalance, quadrature skew and timing skew.

© National Instruments 23

RFmx WLAN New Features and Changes

•  IQ gain imbalance (dB) is the amount of amplifier and filter gain imbalance

between I and Q signals. Quadrature skew (deg) is the deviation in angle from 90
degrees between the I and Q signals.

•  Timing skew (s) is the difference in sampling instances of I and Q signals.
•  Both timing skew and quadrature skew contribute to the phase mismatch between

I and Q signals.

The following equation illustrates these quantities.

where

•  G = 10(IQ Gain Imbalance/20)
•  φ is the quadrature skew
•  τ is the timing skew
•  I'(t) is the impaired in-phase component of the signal
•  Q'(t) is the impaired quadrature-phase component of the signal
•  I(t) is the ideal in-phase component of the signal
•  Q(t) is the ideal quadrature-phase component of the signal

24 ni.com

© 2026 National Instruments Corporation.

