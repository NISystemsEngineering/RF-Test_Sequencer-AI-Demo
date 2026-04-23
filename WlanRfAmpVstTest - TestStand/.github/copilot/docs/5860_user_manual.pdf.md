PXIe-5860 User
Manual

2026-04-23

PXIe-5860 User Manual

Contents
Contents

PXIe-5860 User Manual  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   5
PXIe-5860 Instrument Overview  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   6
PXIe-5860 Driver Support  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   7
Components of a PXIe-5860 System . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   10
PXIe-5860 System Requirements . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   14
Part Numbers for Recommended PXIe-5860 Cables and Accessories . . . . . . . . . . . . . . . . . .   15
Theory of Operation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   17
PXIe-5860 Block Diagram . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   17
PCI Express Interface . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   19
VST State Models  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   20
NI-RFSA State Model  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   20
NI-RFSG State Model . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   23
Finding Examples  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   26
RF API Locations . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   27
PXIe-5860 Front Panels and Pinouts . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   31
Viewing PXIe-5860 Hardware Options in Software  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   38
Viewing PXIe-5860 Hardware Options in Hardware Configuration Utility or MAX . . . . .   38
Safety Guidelines  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   39
Mounting Guidelines  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   41
Installing and Setting Up the PXIe-5860 . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   42
Installing the Software  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   42
Unpacking the Kit  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   43
Installing the PXIe-5860 in a PXI Express Chassis  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   45
Ensuring Signal Quality When Connecting the PXIe-5860  . . . . . . . . . . . . . . . . . . . . . . . . .   47
Interconnecting the PXIe-5860 with S-Parameters . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   47
Performing Initial Hardware Configuration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   53
Configuring the PXIe-5860 in Hardware Configuration Utility . . . . . . . . . . . . . . . . .   54
Configuring the PXIe-5860 in MAX  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   54
Making a First VST Measurement . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   55
Operating Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   58
Device Warm-Up . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   58
RF Cabling Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   58

2 ni.com

PXIe-5860 User Manual

Guidelines for Making Threaded RF Connections . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   59
Threaded RF Connector Care Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   60
Avoiding Damage when Making Direct Connections to the PXIe-5860  . . . . . . . . . . . . . .   61
Power and Thermal Monitoring and Shutdown Conditions . . . . . . . . . . . . . . . . . . . . . . . .   61
PXIe-5860 Power On and Reset Conditions  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   62
Making Connections to the PXIe-5860 . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   64
Analyzing RF Signals with RFmx  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   65
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   66
Configure Hardware Settings  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   66
Configure the Measurement  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   67
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   68
Analyzing RF Signals with NI-RFSA . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   69
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   69
Configure the Reference Clock . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   70
Configure the Acquisition . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   70
Coordinate Actions with Triggers and Events  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   71
Read and Plot Acquired Data . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   75
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   75
Generating RF Signals with NI-RFSG . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   76
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   77
Configure the Reference Clock . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   77
Configure the RF Output Signal  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   77
Coordinate Actions with Triggers and Events  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   78
Initiate Waveform Generation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   85
Check the Status of RF Signal Generation  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   85
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   85
Using the PXIe-5860 with S-Parameters as a VNA  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   87
Designing VNA Measurement Applications for the PXIe-5860 with S-parameters . . . . .   87
Performing Interactive VNA Measurements in InstrumentStudio . . . . . . . . . . . . . . . . . . .   93
Configuring External Reference Clock Timing  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   100
Configuring PXI Backplane Clock Timing  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   101
Frequency and Bandwidth Configuration with NI RF Drivers . . . . . . . . . . . . . . . . . . . . . . . .   102
Frequency and Bandwidth Configuration Terminology  . . . . . . . . . . . . . . . . . . . . . . . . . .   102
Frequency and Bandwidth Selection to Optimize Performance . . . . . . . . . . . . . . . . . . .   103
Maintaining the Instrument  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   106
Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   106

© National Instruments 3

PXIe-5860 User Manual

PXIe-5860 Parameters Adjusted by Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . .   106
When to Perform Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   107
Self-Calibrating the PXIe-5860 . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   107
Self-Calibrating the PXIe-5860 with InstrumentStudio  . . . . . . . . . . . . . . . . .   108
Self-Calibrating the PXIe-5860 with the NI-RFSA LabVIEW Example . . . . . .   109
Cleaning Threaded RF Connectors . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   110
Maintenance . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   112
Troubleshooting  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   113
What Should I Do if My Hardware Doesn't Appear in Hardware Configuration Utility or
MAX? . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   113
Why Is the ACCESS LED Off When the Chassis Is On? . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   114
What Should I Do if the PXIe-5860 Fails the Self-Test? . . . . . . . . . . . . . . . . . . . . . . . . . . . .   115
What Should I Do if the Instrument Does Not Initialize? . . . . . . . . . . . . . . . . . . . . . . . . . .   116
Fundamental RF Concepts  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   117
Common Terms  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   117
Carrier Wave  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   117
Message Signal . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   118
Modulation  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   118
I/Q Modulation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   119
Sample Rate  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   123
Impedance Matching . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   125
Resolution Bandwidth  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   127
Noise Fundamentals . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   129
Streaming  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   135
Scripts . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   136
How Signal Routing Works . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   138
Triggers and Events . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   140
De-embedding Overview . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   142
Average Power and Crest Factor Considerations  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   142

4 ni.com

PXIe-5860 User Manual

User Manual
PXIe-5860  User Manual
PXIe-5860

The PXIe-5860 User Manual provides detailed descriptions of the product functionality
and the step by step processes for use.

Looking for Something Else?

For information not found in the User Manual for your product, such as specifications
and API reference, browse Related Information.

Related information:

•  PXIe-5860 Specifications
•  Software and Driver Downloads
•  Release Notes
•  License Setup and Activation
•  Dimensional Drawings
•  Product Certifications
•  Letter of Volatility
•  Discussion Forums
•  NI Learning Center

© National Instruments 5

PXIe-5860 Instrument Overview

Instrument Overview
PXIe-5860  Instrument Overview
PXIe-5860

Learn the basics about the PXIe-5860 and what you need to incorporate it into your
measurement system.

What is the PXIe-5860?

The PXIe-5860 is a modular multi-channel RF vector signal transceiver (VST).

The PXIe-5860 is available in multiple configurations.

•  When used standalone, the PXIe-5860 functions as a VST. This configuration is

designated the PXIe-5860 VST.

•  When integrated with PXIe-5633 vector network analyzer (VNA) modules, the

integrated instrument provides both VST and VNA functionality from the same
ports of the PXIe-5633 modules. This configuration is designated the PXIe-5860
with S-parameters.

Instrument Name

Constituent Modules

Instrument Functionality

PXIe-5860 VST

PXIe-5860

VST only

PXIe-5860 with S-parameters

PXIe-5860

PXIe-5633 ×2

VST and VNA

6 ni.com

PXIe-5860 Driver Support

Driver Support
PXIe-5860  Driver Support
PXIe-5860

Determine the earliest driver version supported for your product.

Tip To optimize product performance, update to the most recent driver
version.

Table 1. PXIe-5860 Earliest Driver Version Support

Product

Driver Name

Earliest Version Support

PXIe-5860 VST

PXIe-5860 with S-parameters

NI-RFSA

NI-RFSG

RFmx

NI-RFSA

NI-RFSG

RFmx

RFmx VNA

2024 Q3 or later

2024 Q3 or later

2024 Q3 or later

2025 Q2 or later

2025 Q2 or later

2025 Q2 or later

2025 Q2 or later

Note To use the VNA functionality of the PXIe-5860 with S-parameters, you
must install matching versions of both NI-RFSA and RFmx VNA.

Related tasks:

•  Finding Examples for the PXIe-5860

Related information:

•  Software and Driver Downloads
•  RFmx Instruments Help
•  NI RF Signal Analyzers User Manual
•  NI RF Signal Generators User Manual

© National Instruments 7

PXIe-5860 Driver Support

Choosing Your Software

You can choose among multiple options for taking measurements with the PXIe-5860.

You can design programs from scratch or from example programs that provide a
starting point. You can also get started with measurements quickly by using soft front
panels.

Depending on what your test system must accomplish, choose the appropriate
software from the following options.

Objective

Perform physical layer measurements of
supported communications and connectivity
signals

Measure spectral performance and understand
spectral characteristics

Software

RFmx personalities

RFmx SpecAn

Measure modulation quality, including error
vector magnitude (EVM)

RFmx Demod

Create, visualize, and play back RF waveforms  RFmx Waveform Creator
Take S-parameter (VNA) measurements1

RFmx VNA

Perform custom measurements or applications
that require I/Q data

NI-RFSA

Generate CW or modulated waveforms

NI-RFSG

Take interactive measurements with your
instrument

InstrumentStudio

Unsupported Software Features

Certain NI-RFSA and NI-RFSG driver software features are not supported on the
PXIe-5860.

The following features are not supported. Refer to the documentation for your driver

1. Supported by the PXIe-5860 with S-parameters.

8 ni.com

PXIe-5860 Driver Support

version for detailed device support information.

•  Pulse shaping is not supported.
•  Pulse modulation is not supported.
•  TClk synchronization is not supported.
•  List mode is not supported for the PXIe-5860 with S-parameters.

Restrictions on Scripts

•  if else is not supported.
•  break instruction is not supported.
•  stream instruction is not supported.
•  The maximum compiled script size is 6,100 instructions. Each script language
instruction requires roughly one compiled instruction, plus one instruction for
each marker.

•  Nested repeats are only allowed if the outer repeat is a repeat forever

instruction, and there are no other instructions preceding it or past the end of the
repeat block. You can only use a single nesting level.

•  Markers are allowed in generate and finite wait instructions. They are not

allowed in conditional wait instructions.

© National Instruments 9

Components of a PXIe-5860 System

Components of a PXIe-5860
Components of a

System
PXIe-5860  System

PXIe-5860 instruments are designed for use in a system that includes other hardware
components, drivers, and software.

Note A system and the surrounding environment must meet the
requirements that are defined in the relevant specifications documents.

The following list defines the minimum required hardware and software for a system
that includes a PXIe-5860 instrument.

Table 2. System Components

Component

PXI chassis

PXI controller or PXI remote control
module

Description and Recommendations

A PXI chassis houses the PXIe-5860 and supplies power for
PXIe-5860 functions.

Note PXIe-5860 instruments require a chassis
with ≥82 W slot cooling capacity.

You can install a PXI controller or a PXI remote control
(MXI) module depending on your system requirements.
These components, installed in the same PXI chassis as
the PXIe-5860, interface with the instrument using NI
device drivers.

Your PXIe-5860 VST instrument.

PXIe-5860 VST instrument

Can function as a VST on its own or as a combined VST
and VNA as the PXIe-5860 with S-parameters.

10 ni.com

Component

Description and Recommendations

Components of a PXIe-5860 System

PXIe-5633 VNA (×2)

The VNA modules that integrate with the PXIe-5860 to
compose the PXIe-5860 with S-parameters.

The PXIe-5633 is available with various frequency ranges
for VNA operation. You can choose the frequency option
that suits your application.

You can also operate the PXIe-5633 as a standalone VNA,
without integrating it with with PXIe-5860.

PXIe-5860 VST cable kit for PXIe-5633
VNA pass through connection

Required to interconnect modules of the PXIe-5860 with
S-parameters.

×1 cable kit (NI part number 790504-01) required per
PXIe-5860 with S-parameters.

CAL-5501 VNA measurement
calibration accessory

CAL-5501 VNA measurement calibrator to perform
electronic calibration for the PXIe-5860 with S-
parameters. The CAL-5501 requires the purchase of a
hardware services calibration along with the module.

Alternatively, you can perform manual calibration with
your own calibration standards.

Cables and accessories

Cables and accessories allow connectivity to/from your
instrument for measurements. Refer to Part Numbers for
Recommended PXIe-5860 Cables and Accessories for

© National Instruments 11

Component

Description and Recommendations

Components of a PXIe-5860 System

RF drivers: NI-RFSA, NI-RFSG, and RFmx

guidance on recommended cables and accessories.

Instrument driver software that provides functions to
interact with the PXIe-5860 and execute measurements
using the PXIe-5860.

•  NI-RFSA—Controls and configures NI vector signal

analyzers (VSAs) and the analysis (input) functionality
of NI vector signal transceivers (VSTs). NI-RFSA
provides the standard IVI-based functionality needed
for most vector signal analyzer applications. NI-RFSA
includes operations and properties to create custom
measurements or applications that require I/Q data.

•  NI-RFSG—Configures and operates NI vector signal
generators (VSGs) and the generation (output)
functionality of NI vector signal transceivers (VSTs).
NI-RFSG performs waveform programming and
generation and basic modulation tasks. Provides the
standard IVI-based functionality needed for most RF
signal generator applications.

•  RFmx—Provides signal generation and analysis for a
variety of applications, such as, cellular connectivity,
Internet of things (IoT), aerospace and defense, and
general-purpose applications. RFmx encompasses a
set of interoperable measurement personalities and
waveform creation software. RFmx extends the
capability of NI RF instrumentation for design,
validation, and production test applications.

Note NI recommends always using the most
current driver versions with the PXIe-5860. You
can find the RF driver requirements on the
download page for the driver on ni.com.

NI applications or software
development environments

NI-RFSA, NI-RFSG, and RFmx offer driver support for the
following applications and software languages:

12 ni.com

Component

Description and Recommendations

Components of a PXIe-5860 System

•  InstrumentStudio
•  LabVIEW
•  LabWindows™/CVI
•  C/C++
•  .NET

Related concepts:

•  Part Numbers for Recommended PXIe-5860 Cables and Accessories
•  PXIe-5860 Driver Support

Related information:

•  Software and Driver Downloads

© National Instruments 13

PXIe-5860 System Requirements

System Requirements
PXIe-5860  System Requirements
PXIe-5860

Your system must meet the following minimum requirements to run and use the
PXIe-5860.

Chassis Requirements

•  Slot cooling capacity—Must be ≥82 W
•  Power delivery—Must provide ≥82 W per slot.

See the specifications for your instrument or the safety, environmental, and
regulatory information document included with your instrument for specific
power consumption.

•  Clearances—Maintain the minimum required clearances around your PXI Express

chassis. Clearances may vary by chassis. Follow the guidelines in the
documentation for the chassis.

•  Available adjacent, compatible PXI slots—2 slots for the PXIe-5860 VST module; 4

slots for the PXIe-5860 with S-parameters

The PXIe-5860 can be installed in the following PXI chassis slot types:

•  PXI Express Hybrid Peripheral Slot
•  PXI Express System Timing Slot
•  PXI Express Peripheral Slot

Controller or Host Computer Requirements

•  RAM—4 GB. Depending on the amount of data acquired and/or processed, a larger

amount of memory may be required.

•  Processor—1 GHz 64-bit (x64)

14 ni.com

Part Numbers for Recommended PXIe-5860 Cables and Accessories

Part Numbers for Recommended
PXIe-5860
Part Numbers for Recommended PXIe-5860
Cables and Accessories
Cables and Accessories

Use part numbers to purchase the cables and the accessories for optimizing the
performance of PXIe-5860.

The shipping kits for the PXIe-5860 and for associated modules do not include these
items.

Table 3. Part Numbers for Recommended Cables and Accessories

Accessory or Cable

Description

Part Number

751120-01

780487-01

790504-01

0.9 N · m (8 lb · in.) calibrated
torque wrench, 5/16 in.

For installing threaded
connections

100 N · cm calibrated torque
screwdriver

For use with SMA driver bit
included in PXIe-5860 kits

PXIe-5860 cable kit for
PXIe-5633 pass-through
connection

CAL-5501

RF cable,
3.5 mm (m)-to-3.5 mm (m), 1 m

Required to interconnect
modules of the PXIe-5860 with
S-parameters.

×1 cable kit required per
PXIe-5860 with S-parameters.

VNA measurement calibrator
for the PXIe-5860 with S-
parameters.

788189-012

High-performance, phase-
stable cabling. Provides
connectivity for VST
measurements and VNA
measurements.

137445-01

2. The CAL-5501 in turn requires the purchase of a hardware services calibration. Choose from traceable

calibration (960380-01), compliant calibration (960380-03), and ISO 17025 accredited calibration
960380-04.

© National Instruments 15

Part Numbers for Recommended PXIe-5860 Cables and Accessories

Accessory or Cable

Description

Part Number

Recommended for PXIe-5860
with S-parameters.

×4 required to fully utilize
PXIe-5860 with S-parameters I/
O.

PXI slot blockers

EMC filler panels

Fills an empty instrument slot
in a PXI chassis.

199198-01

Covers an empty slot within a
PXI chassis. Contains gaskets to
control EMC emissions from the
chassis.

778700-01

For more information about installing slot blockers and filler panels, go to ni.com/
r/pxiblocker.

16 ni.com

PXIe-5860 Theory of Operation

Theory of Operation
PXIe-5860  Theory of Operation
PXIe-5860

Refer to block diagrams and state models to understand the hardware and software
design behind the PXIe-5860.

Block Diagram
PXIe-5860  Block Diagram
PXIe-5860

Block diagrams describe the hardware architecture of your instrument and the paths
that signals take through components of the instrument.

Figure 1. PXIe-5860 VST Block Diagram

RF IN <0,1>

Signal Conditioning

ADCs

RF OUT <0,1>

Signal Conditioning

DACs

PFI <0,1>

DIO

Waveform
Acquisition

Waveform
Generation

Digital Signal
Processing

Module
Control

REF: OUT

10 MHz/100 MHz

REF: IN

10 MHz/100 MHz

Reference
Clock

PXIe Reference Clock (100 MHz)

TCXO

Calibration
DAC

VCXO

PXIe-5860

l

e
n
a
p
k
c
a
B
s
s
e
r
p
x
E

I

X
P

Note Single channel shown. Additional signal paths related to self-
calibration not shown.

© National Instruments 17

Figure 2. PXIe-5860 with S-Parameters Block Diagram

PXIe-5860 Theory of Operation

PXIe Ref Clock (100 MHz)

Reference
Clock

LO
Generation

ADC

ADC

LO

ADC

ADC

Transfer
Switch

Source

REF IN

REF OUT

LO IN

LO OUT

IF OUT

PORT 1

PORT 2

IF IN

PFI 0

PFI 1

SWITCH IN

SWITCH OUT

Waveform
Acquisition

Digital Signal
Processing

Module
Control

l

e
n
a
p
k
c
a
B
s
s
e
r
p
x
E

I

X
P

PXIe-5633

Waveform
Acquisition

Waveform
Generation

Digital Signal
Processing

Module
Control

RF IN <0,1>

Signal Conditioning

ADCs

RF OUT <0,1>

Signal Conditioning

DACs

PFI <0,1>

DIO

REF: OUT

10 MHz/100 MHz

REF: IN

10 MHz/100 MHz

Reference
Clock

PXIe Reference Clock (100 MHz)

TCXO

Calibration
DAC

VCXO

PXIe-5860

Note Single channel shown. For VST functionality, access this channel on
either PORT 1 or PORT 2 of the PXIe-5633. Additional signal paths related to
self-calibration not shown.

The following figure represents a single RF input channel architecture.

18 ni.com

PXIe-5860 Theory of Operation

Figure 3. PXIe-5860 RF Input Channel Block Diagram

Gain Ranging

RF IN

Input Isolation
Switch

ADC

Digital Down-
Conversion

FIR
Filter

Fractional Sample
Rate Conversion

Anti-Alias
Filter

Direct-Sampling
ADC (20 GSPS)

Note Single channel shown. The architecture is identical for the RF IN 0 and
RF IN 1 channels.

The following figure represents a single RF output channel architecture.

Figure 4. PXIe-5860 RF Output Channel Block Diagram

Gain Ranging

RF OUT

Output Isolation
Switch

DAC

   Digital Up-
Conversion

FIR
Filter

Fractional Sample
Rate Conversion

Anti-Alias
Filter

Direct-Sampling
DAC (20 GSPS)

Note Single channel shown. The architecture is identical for the RF OUT 0
and RF OUT 1 channels.

Related tasks:

•  Making Connections to the PXIe-5860

Related information:

•  PXIe-5633 Block Diagram - PXIe-5633 User Manual

PCI Express Interface
PCI Express Interface

The PXIe-5860 has a PCI Express (up to Gen3 x8) backplane connection, which is used
for programmed I/O, and DMA transfers.

© National Instruments 19

PXIe-5860 Theory of Operation

VST State Models
VST State Models

At the lowest level, NI VSTs use two separate instrument drivers—NI-RFSA and
NI-RFSG—to control the signal analysis and generation functionality, respectively, of
the instrument. The underlying state model of each driver informs how you should
construct programs to make use of your VST.

The state model determines what actions you can program the instrument to take in
each state and tells you how to progress through the states when programming your
instrument to build a successful program.

State Model
NI-RFSA  State Model
NI-RFSA

The NI-RFSA programming model has eight main states. The state of the instrument at
a given time affects the actions you can take during that time.

NI-RFSA controls vector signal analyzers and the analysis functionality of vector signal
transceivers.

These states are as follows:

•  Idle
•  Wait for Start Trigger
•  Minimum Pre-Reference Trigger Sampling
•  Wait for Reference Trigger while Sampling
•  Post-Reference Trigger Sampling
•  Record Complete
•  Wait for Advance Trigger
•  Done

The following diagram depicts the state model for the PXIe-5860 when programmed
with NI-RFSA software. This state diagram models the instrument when it acquires
data in the I/Q mode.

20 ni.com

PXIe-5860 Theory of Operation

Ready  for
Reference
Event

Figure 5. NI-RFSA State Model

Ready  for
Start  Event

Initiate

Start
Trigger

Idle

Wait  for
Start  Trigger

Start
Trigger

Configure

Software
Done

Advance
Trigger

Advance
Trigger

Ready  for
Advance  Event

Done

Wait  for
Advance
Trigger

Software
Done

More
Records
to Do

Minimum
Pre-Reference
Trigger
Sampling

Minimum
Pre-Reference
Trigger  Sampling
Complete

Wait  for
Reference
Trigger  while
Sampling

Done
(End  of
Acquisition)
Event

Record
Complete

Reference
Trigger

Post-
Reference
Trigger  Sampling
(Start  Trigger-to-
Trigger  Holdoff
Counter)

End of
Record  Event

Post-Reference
Trigger  Sampling
Complete

Arrow legend:

Reference
Trigger

•  Blue—State transitions always caused by software
•  Black—State transitions caused by the internal state machine of the instrument
•  Red—Output signals
•  Orange—User-configurable state transitions caused by software or hardware

The major states are defined as follows.

•  Idle—The instrument is not sampling a waveform. All the session properties are

programmable in this state.

In this state, properties have not necessarily been applied to the hardware yet. As a
result, the hardware configuration of the module may not match the values of the
properties in the session.

In addition, while idle, the instrument remains configured as it was the last time a

© National Instruments 21

PXIe-5860 Theory of Operation

session was committed. When you call Initiate, all the properties are programmed
to the hardware. If you recently reset the computer, the instrument is in the Idle
state.

•  Wait for Start Trigger—The instrument transitions to this state when you initiate
an acquisition. If the Start Trigger source is configured as None, the instrument
immediately transitions from this state and generates a Start Trigger. If you
configure the Start Trigger source as a software trigger or hardware trigger, the
instrument remains in this state until that trigger occurs. When the instrument
recognizes a trigger condition, it transitions from this state on the next clock cycle
and generates a Start Trigger. The default Start Trigger source is None.

•  Minimum Pre-Reference Trigger Sampling—The instrument can transition into
this state two ways: receiving the Start Trigger from the Start Trigger source or
receiving the Advance trigger from the Advance trigger source. The transition into
this state depends on the previous state of the instrument. While in this state, the
instrument samples according to the session attributes configured. The module
remains in this state until three conditions are satisfied:
1.  The minimum Pre-Reference trigger sampling completes
2.  The time-to-digital converter (TDC) is ready
3.  The trigger-to-trigger delay has expired

For the first time through this state, trigger-to-trigger delay does not have an
effect. When the three conditions are satisfied, the instrument transitions from this
state on the next clock cycle. Use the Pretrigger Samples property to specify the
number of samples to be acquired before the Reference Trigger is received.

•  Wait for Reference Trigger while Sampling—The instrument transitions into this
state after the instrument finishes the Minimum Pre-Reference Trigger Sampling
state. If you configure the Reference Trigger source as a software trigger or
hardware trigger, the instrument remains in this state until the configured trigger
occurs. When the instrument recognizes a trigger condition, the instrument
transitions from this state. The default Reference Trigger source is None.

•  Post–Reference Trigger Sampling—After the instrument receives the Reference

Trigger, the instrument transitions into this state. The instrument begins sampling
Post-Reference Trigger samples according to the properties configured for the
session. When the Post-Reference Trigger sampling completes, the instrument
transitions from this state.

•  Record Complete—The instrument transitions into this state when Post–Reference

22 ni.com

PXIe-5860 Theory of Operation

Trigger Sampling is complete. The instrument leaves this state after the current
record has been stored in the onboard memory. Upon leaving this state, the
instrument generates an End of Record Event.

•  Wait for Advance Trigger—When the instrument completes a record but
determines that there are still more records to complete, the instrument
transitions into this state. If you configure the Advance Trigger source as None, the
instrument transitions from this state on the next clock edge. If you configure the
Advance Trigger source as a software trigger or hardware trigger, the instrument
remains in this state until the configured trigger occurs. When the instrument
recognizes a trigger condition, the instrument transitions from this state. The
default Advance Trigger source is None.

•  Done—After the instrument completes a record and determines that all the records

are done, it transitions into this temporary state. Upon entering this state, the
instrument generates the End of Acquisition Event. The software transitions the
instrument from this state and back to the Idle state when you call either a Fetch
function or NI-RFSA Check Acquisition Status.

State Model
NI-RFSG  State Model
NI-RFSG

The NI-RFSG programming model has three main states. The state of the instrument at
a given time affects the actions you can take during that time.

NI-RFSG controls vector signal generators and the generation functionality of vector
signal transceivers.

These states are Configuration (idle), Committed, and Generation (running).

The following diagram depicts the state model for the PXIe-5860 when programmed
with NI-RFSG software.

© National Instruments 23

PXIe-5860 Theory of Operation

Figure 6. NI-RFSG State Model

Get/Set  Attribute
Write  Waveform

Initiate

Get Attribute

Commit

Initiate

Initialize

Configuration
(Idle)

Committed

Generation
(Running)

Set Attribute
Write  Waveform*

Get Attribute

Start  Trigger

Abort

The major states are defined as follows.

•  Configuration—You can program all session properties in the Configuration state;
however, properties are not yet applied to the instrument in this state. Therefore,
the actual instrument configuration might not match the values of the properties
in the session. The NI-RFSG instrument does not generate a signal in the
Configuration state.

Note When you read a property, NI-RFSG returns the coerced value for
that property or attribute. To determine the coerced value, NI-RFSG
might analyze many properties in the current configuration. In general,
avoid reading any properties until you have finished changing all the
properties you want to change. Otherwise, you may encounter errors if
NI-RFSG reads a property while the configuration is in an inconsistent
state.

•  Committed—Calling NI-RFSG Commit from the Configuration state performs the

following actions:

•  Verifies the settings of all properties
•  Validates the specified configuration
•  Writes all settings to the hardware modules
•  Writes the waveform to the instrument onboard memory
•  Transitions to the Committed state

24 ni.com

PXIe-5860 Theory of Operation

If properties are changed in the Committed state, the following occur:

•  The session implicitly transitions back to the Configuration state
•  The hardware configuration reflects the previously committed properties or

attributes

•  Generation—The instrument is either waiting on a trigger or is generating a signal.
In the Generation state, session properties always reflect the current state of the
instrument.

Note You can call NI-RFSG Close from any state. Calling Close stops signal
generation.

© National Instruments 25

Finding Examples for the PXIe-5860

PXIe-5860
Finding Examples for the PXIe-5860
Finding Examples for the

The PXIe-5860 user manual uses examples to guide you through step-by-step
instructions for basic operation of the PXIe-5860 in G (LabVIEW), C/C++, and Visual C#
or Visual Basic .NET. For examples of specialty applications, optimizations, and other
customizations, browse the locations where examples are stored.

Access examples depending on your programming environment and the driver API(s)
you want to use to control your instrument:

Programming Environment

Description

LabVIEW, LabWindows™/CVI

For NI-RFSA and NI-RFSG, use the Example Finder:

a.  Launch the programming environment.
b.  Select Help » Find Examples to open the NI

Example Finder.

c.  Navigate to Hardware Input and Output »

Modular Instruments.

d.  Open the example that best matches your

application requirements.

For RFmx, find examples at Start » National
Instruments » <Personality> Examples, where
<Personality> is the name of the RFmx personality.

Microsoft Visual Studio

Browse your file system to find the examples for the
RF APIs you are using:

•  RFmx:

<NIDocDir>\<Personality>\Examples

•  NI-RFSA: <NIDocDir>\NI-RFSA\

examples

•  NI-RFSG: <NIDocDir>\NI-RFSG\

examples

where

•  <NIDocDir> is the Users\Public\Public
Documents\National Instruments

26 ni.com

Programming Environment

Description

Finding Examples for the PXIe-5860

directory

•  <Personality> is the directory of your

RFmx personality

You can also find examples for your driver API at Start » National Instruments » Driver
Name Examples.

RF API Locations
RF API Locations

Access the API to program your instrument, depending on your application
development environment and RF driver.

Table 4. API Location for RFmx

ADE

LabVIEW

LabWindows/CVI

Microsoft Visual C/C++

API Location

Available on the LabVIEW Functions palette at
Measurement I/O » NI-RFmx.

Available from the LabWindows/CVI Library
menu at Library » RFmx SpecAn Library and
Library » RFmx Demod Library.

LabWindows/CVI supports only the
RFmx SpecAn and RFmx Demod personalities.

Use the header files located in the
<NIDir>\Shared\
ExternalCompilerSupport\C\include
directory and import library files located in one
of the following directories:

•  32-bit installation—<NIDir>\Shared\
ExternalCompilerSupport\C\
lib32\msvc

© National Instruments 27

ADE

API Location

Finding Examples for the PXIe-5860

•  64-bit installation—<NIDir>\Shared\
ExternalCompilerSupport\C\
lib64\msvc

where <NIDir> is the following location:

Program Files (x86)\National
Instruments.

Microsoft .NET

For the location of .NET class libraries, refer to
the installed RFmx readme.

Table 5. API Location for NI-RFSA

ADE

LabVIEW

LabWindows/CVI

Microsoft Visual C/C++

API Location

Available on the LabVIEW Functions palette at Measurement I/O » NI-
RFSA.

Depending on bitness, available in the <IVIROOTDIR32>\Drivers\
niRFSA or <IVIROOTDIR64>\Drivers\niRFSA directory, where
<IVIROOTDIR32> and <IVIROOTDIR64> are the following:

•  <IVIROOTDIR32>—Program Files (x86)\IVI

Foundation\IVI

•  <IVIROOTDIR64>—Program Files\IVI Foundation\IVI

Depending on bitness, use the header files located in the
<IVIROOTDIR32>\Include or <IVIROOTDIR64>\Include
directory and import library files located in the
<IVIROOTDIR32>\Lib or <IVIROOTDIR64>\Lib directory, where
<IVIROOTDIR32> and <IVIROOTDIR32> are the following:

•  <IVIROOTDIR32>—Program Files (x86)\IVI

Foundation\IVI

•  <IVIROOTDIR64>—Program Files\IVI Foundation\IVI

28 ni.com

Finding Examples for the PXIe-5860

ADE

API Location

Microsoft .NET

Use the NI-RFSA .NET class library by adding a reference to
NationalInstruments.ModularInstruments.NIRfsa.Fx40
or
NationalInstruments.ModularInstruments.NIRfsa.Fx45
and any dependent class libraries from within the Solution Explorer in
Visual Studio.

Table 6. API Location for NI-RFSG

ADE

LabVIEW

API Location

Available on the LabVIEW Functions palette at
Measurement I/O » NI-RFSG.

LabWindows/CVI

Microsoft Visual C/C++

Depending on bitness, available in the
<IVIROOTDIR32>\Drivers\niRFSG or
<IVIROOTDIR64>\Drivers\niRFSG directory,
where <IVIROOTDIR32> and <IVIROOTDIR64> are the
following:

•  <IVIROOTDIR32>—Program Files
(x86)\IVI Foundation\IVI

•  <IVIROOTDIR64>—Program Files\IVI

Foundation\IVI

Depending on bitness, use the header files located in
the <IVIROOTDIR32>\Include or
<IVIROOTDIR64>\Include directory and import
library files located in the <IVIROOTDIR32>\Lib or
<IVIROOTDIR64>\Lib directory, where
<IVIROOTDIR32> and <IVIROOTDIR32> are the
following:

•  <IVIROOTDIR32>—Program Files
(x86)\IVI Foundation\IVI

•  <IVIROOTDIR64>—Program Files\IVI

Foundation\IVI

© National Instruments 29

ADE

API Location

Finding Examples for the PXIe-5860

Microsoft .NET

Use the NI-RFSG .NET class library by adding a
reference to
NationalInstruments.ModularInstruments
.NIRfsg.Fx40 or
NationalInstruments.ModularInstruments
.NIRfsg.Fx45 and any dependent class libraries
from within the Solution Explorer in Visual Studio.

30 ni.com

PXIe-5860 Front Panels and Pinouts

Front Panels and Pinouts
PXIe-5860  Front Panels and Pinouts
PXIe-5860

Refer to the front panel information for your PXIe-5860 instrument to understand the
connectors, pinouts, and signals found on your instrument.

For front panels and pinouts for other modules that combine with the PXIe-5860, refer
to the documentation for those modules.

Related information:

•  PXIe-5633 and CAL-5501 Front Panels and LEDs

© National Instruments 31

PXIe-5860 Front Panel and LEDs

Figure 7. PXIe-5860 Front Panel

PXIe-5860 Front Panels and Pinouts

PXIe-5860
Vector Signal Transceiver

ACC

ACTIVE

PFI 0

REF
IN

DIO

OUT

MGT
100 Ω DIFF

RF OUT 0

RF IN 0

CTRL

RF IN 1

PFI 1

RF OUT 1

0

1

2

3

ALL RF PORTS 50 Ω

SEE SPECIFICATIONS FOR
CONN MAX IN / OUT LEVELS

ESD
SENSITIVE

Table 7. PXIe-5860 Connector Descriptions

Connector

Connector Type

Description

RF OUT <0,1>

RF IN <0,1>

REF: IN

SMA (f)

SMA (f)

SMA (f)

Output terminal for RF signals

Input terminal for RF signals

Input terminal that allows the
use of an external reference
clock with one of the following
frequencies: 10 MHz, 100 MHz

32 ni.com

Connector

Connector Type

Description

PXIe-5860 Front Panels and Pinouts

REF: OUT

SMA (f)

PFI <0,1>

SMA (f)

Output terminal that can export
a 10 MHz or 100 MHz reference
clock

Programmable function digital
I/O (DIO) connector for use with
triggers or events

DIO

MGT

CTRL

Mini HDMI

iPass+ zHD

Mini HDMI

Reserved

Reserved

Reserved

Table 8. PXIe-5860 LED Indicators

LED

Indications

ACCESS

ACTIVE

Indicates the basic hardware status of the module.

•  Off—The module is not yet functional or has detected a problem with a PXI

Express power rail

•  Amber—The module is being accessed; accessed means that you are

writing to the module setup registers to control the module, reading from
the module to monitor its status, or transferring data to or from the
module

•  Green—The module is controllable through the software

Indicates the state of the module.

•  Off—The module is idle
•  Solid green—The module is generating a waveform
•  Dim amber—The module is waiting for an acquisition Reference Trigger
•  Solid amber—The module is acquiring a waveform
•  Solid red—The module has detected an error; the LED remains red until

the error condition is removed

For example, the module could have exceeded its operating temperature
and entered thermal shutdown. In this case, check system airflow and
reset the module in Hardware Configuration Utility or MAX.

© National Instruments 33

LED

Indications

PXIe-5860 Front Panels and Pinouts

Note Indicators are listed in increasing order of priority. For
example, if you are generating a waveform using NI-RFSG and
waiting on an acquisition Reference Trigger in NI-RFSA, the LED is
dim amber.

PXIe-5860 MGT Connector Pinout

Single MGT connector shown; the PXIe-5860 front panel has four MGT connectors that
have identical pinouts.

RESERVED
RESERVED
GND
Rx+ 0
Rx– 0
GND
Rx+ 3
Rx– 3
GND

SCL
SDA
GND
Tx+ 0
Tx– 0
GND
Tx+ 3
Tx– 3
GND

A1

A2
A3
A4
A5
A6
A7
A8

A9

C1

C2
C3
C4
C5
C6
C7
C8

C9

B1

B2
B3
B4
B5
B6
B7
B8

B9

D1

D2
D3
D4
D5
D6
D7
D8

D9

Optical 3.3 V
GPIO
GND
Rx+ 1
Rx– 1
GND
Rx+ 2
Rx– 2
GND

Optical 3.3 V
EEPROM 3.3 V
GND
Tx+ 1
Tx– 1
GND
Tx+ 2
Tx– 2
GND

Table 9. PXIe-5860 MGT Signal Descriptions

Pin

A1

A2

A3

Signal

Reserved

Reserved

GND

Description

N/A

N/A

Ground reference for signals

34 ni.com

Pin

A4

A5

A6

A7

A8

A9

B1

B2

B3

B4

B5

B6

B7

B8

B9

C1

C2

C3

C4

C5

C6

C7

C8

C9

D1

D2

PXIe-5860 Front Panels and Pinouts

Description

Receive channel 0, positive

Receive channel 0, negative

Ground reference for signals

Receive channel 3, positive

Receive channel 3, negative

Ground reference for signals

Signal

Rx+ 0

Rx- 0

GND

Rx+ 3

Rx- 3

GND

Optical 3.3 V

Power supply for active/optical
cables

GPIO

GND

Rx+ 1

Rx- 1

GND

Rx+ 2

Rx- 2

GND

SCL

SDA

GND

Tx+ 0

Tx- 0

GND

Tx+ 3

Tx- 3

GND

Reserved

Ground reference for signals

Receive channel 1, positive

Receive channel 1, negative

Ground reference for signals

Receive channel 2, positive

Receive channel 2, negative

Ground reference for signals

Serial clock

Serial data

Ground reference for signals

Transmit channel 0, positive

Transmit channel 0, negative

Ground reference for signals

Transmit channel 3, positive

Transmit channel 3, negative

Ground reference for signals

Optical 3.3 V

Power supply for active/optical
cables

EEPROM 3.3 V

EEPROM power supply

© National Instruments 35

Pin

D3

D4

D5

D6

D7

D8

D9

PXIe-5860 Front Panels and Pinouts

Description

Ground reference for signals

Transmit channel 1, positive

Transmit channel 1, negative

Ground reference for signals

Transmit channel 2, positive

Transmit channel 2, negative

Ground reference for signals

Signal

GND

Tx+ 1

Tx- 1

GND

Tx+ 2

Tx- 2

GND

PXIe-5860 DIO Connector Pinout

19
18
17
16
15
14
13
12
11
10
9
8
7
6
5
4
3
2
1

GND
VCC
DIO 7
DIO 6
DIO 5
DIO 4
GND
DIO 3
DIO 2
GND
DIO 1
DIO 0
GND
GND
NC
GND
GND
NC
GND

36 ni.com

Table 10. PXIe-5860 DIO Signal Descriptions

Pin

19

18

17

16

15

14

13

12

11

10

9

8

7

6

5

4

3

2

1

PXIe-5860 Front Panels and Pinouts

Description

Ground reference for signals

+3.3 V power (200 mA
maximum)

Bidirectional digital I/O line

Bidirectional digital I/O line

Bidirectional digital I/O line

Bidirectional digital I/O line

Ground reference for signals

Bidirectional digital I/O line

Bidirectional digital I/O line

Ground reference for signals

Bidirectional digital I/O line

Bidirectional digital I/O line

Ground reference for signals

Ground reference for signals

No connection

Ground reference for signals

Ground reference for signals

No connection

Ground reference for signals

Signal

GND

VCC

DIO 7

DIO 6

DIO 5

DIO 4

GND

DIO 3

DIO 2

GND

DIO 1

DIO 0

GND

GND

NC

GND

GND

NC

GND

© National Instruments 37

Viewing PXIe-5860 Hardware Options in Software

Hardware Options in
PXIe-5860  Hardware Options in

Viewing
Viewing PXIe-5860
Software
Software

There are multiple ways to check the hardware options that are enabled for a given
PXIe-5860 instrument within NI software.

Hardware Options in Hardware
PXIe-5860  Hardware Options in Hardware

Viewing PXIe-5860
Viewing
Configuration Utility or MAX
Configuration Utility or MAX

You can refer to Hardware Configuration Utility or MAX to identify the hardware
options that are enabled for a given PXIe-5860 instrument.

Depending on your software, complete the following steps to use NI hardware
configuration software to see the options a PXIe-5860 instrument is equipped with.

Configuration Software

Procedure

Hardware Configuration Utility

a.  Open Hardware Configuration Utility.
b.  Select the PXIe-5860 in the system pane on

the left side of the interface.

c.  In the configuration pane on the right side of
the interface, review the options listed in the
Device details section.

a.  Open MAX.
b.  In the MAX configuration tree, expand

Devices and Interfaces.
c.  Select the PXIe-5860 module.
d.  In the Settings pane, review the options
listed in the Hardware Options section.

MAX

38 ni.com

PXIe-5860 Safety Guidelines

Safety Guidelines
PXIe-5860  Safety Guidelines
PXIe-5860

Follow these guidelines to use the PXIe-5860 safely.

You can view product certifications and declarations at ni.com/product-certifications.

Important For comprehensive safety information, refer to the safety,
environmental, and regulatory information document that shipped with your
hardware.

Caution Observe all instructions and cautions in the user documentation.
Using the product in a manner not specified can damage the product and
compromise the built-in safety protection.

Attention Suivez toutes les instructions et respectez toutes les mises en
garde de la documentation d'utilisation. L'utilisation du produit de toute
autre façon que celle spécifiée risque de l'endommager et de compromettre
la protection de sécurité intégrée.

Caution The product is designed for nonhazardous, live signals. You must
ensure that all signals connected to the product are isolated from hazardous,
live circuits and no unsafe voltages are present at the inputs. Voltages that
exceed the specifications could result in damage to the product or electric
shock.

Attention Le produit est conçu pour les signaux en direct non dangereux.
Vous devez vous assurer que tous les signaux connectés au produit sont
isolés des circuits dangereux sous tension et qu'aucune tension dangereuse
n'est présente aux entrées. Des tensions supérieures à celles mentionnées
dans les spécifications peuvent endommager le produit ou provoquer un
choc électrique

© National Instruments 39

PXIe-5860 Safety Guidelines

Product Certifications and Declarations

Refer to the product Declaration of Conformity (DoC) for additional regulatory
compliance information. To obtain product certifications and the DoC for NI products,
visit ni.com/product-certifications, search by model number, and click the appropriate
link.

40 ni.com

PXIe-5860 Mounting Guidelines

Mounting Guidelines
PXIe-5860  Mounting Guidelines
PXIe-5860

To ensure optimal thermal performance, follow the placement, clearance, and
mounting guidelines for the product platform.

Notice Failure to follow the mounting instructions in the product
documentation can cause temperature derating.

Notice This product is intended for use in indoor applications only.

To understand the placement requirements of the chassis, such as required
clearances, refer to the user manual for your PXI chassis. For environmental
requirements for storage and operation, refer to the chassis specifications.

Note The environmental requirements of modules within the chassis may
differ from those of the chassis. Similarly, the requirements of the installed
modules may differ from each other, and any devices connected to the
modules within the chassis may have different requirements of their own.
Consult the relevant documentation for all equipment within and connected
to the chassis to understand the aggregate mounting and environmental
requirements of the system.

Chassis placement must also facilitate making a safety ground connection, if the user
manual for your chassis indicates this is required.

To understand more specific aspects of rack mounting the PXI chassis, such as
installation procedures, refer to the documentation included with the rack mount kit
for your chassis or available on ni.com.

© National Instruments 41

Installing and Setting Up the PXIe-5860

PXIe-5860
Installing and Setting Up the PXIe-5860
Installing and Setting Up the

Complete the procedures to install necessary software, physically install your
PXIe-5860 instrument, perform initial configuration, and run an initial test
measurement.

1.  Installing the Software
2.  Unpacking the Kit
3.  Installing the PXIe-5860 in a PXI Express Chassis

Complete these steps to install your PXIe-5860 instrument in your PXI express
chassis.

4.  Ensuring Signal Quality When Connecting the PXIe-5860

To ensure proper connections that maintain signal quality, adhere to these
guidelines while interconnecting the modules.
5.  Interconnecting the PXIe-5860 with S-Parameters

Complete this procedure to interconnect the modules of the PXIe-5860 with S-
parameters.

6.  Performing Initial Hardware Configuration

Before you can use your PXIe-5860, you need to ensure your system recognizes the
instrument.

7.  Making a First VST Measurement

You can verify proper installation and configuration of your instrument by making
a measurement using InstrumentStudio.

Installing the Software
Installing the Software

You must be an Administrator to install NI software on your computer.

The PXIe-5860 supports multiple drivers that enable specific functionality. Refer to
PXIe-5860 Driver Support to understand which drivers to install.

1.  Install an ADE, such as LabVIEW.
2.  Download the driver software using any of the following methods:

◦  Download the software from ni.com/downloads
◦  Select the software to install in Package Manager
NI Package Manager downloads with the driver software to handle the installation.

42 ni.com

Installing and Setting Up the PXIe-5860

Refer to the Package Manager User Manual for more information about installing,
removing, and upgrading NI software using NI Package Manager.

Note For the PXIe-5860 with S-parameters, you must install matching
versions of RFmx VNA and NI-RFSA. The order in which you install these
drivers is not important.

3.  Follow the instructions in the installation prompts.

Note Windows users may see access and security messages during
installation. Accept the prompts to complete the installation.

4.  When the installer completes, select Restart in the dialog box that prompts you to

restart, shut down, or restart later.

Related concepts:

•  PXIe-5860 Driver Support

Related information:

•  Software and Driver Downloads
•  Package Manager User Manual: Installing, Updating, Repairing, and Removing NI

Software

Unpacking the Kit
Unpacking the Kit

Notice To prevent electrostatic discharge (ESD) from damaging the device,
ground yourself using a grounding strap or by holding a grounded object,
such as your computer chassis.

1.  Touch the antistatic package to a metal part of the computer chassis.
2.  Remove the device from the package and inspect the device for loose components

or any other sign of damage.

Notice Never touch the exposed pins of connectors.

© National Instruments 43

Installing and Setting Up the PXIe-5860

Note Do not install a device if it appears damaged in any way.

3.  Unpack any other items and documentation from the kit.

Note Store the device in the antistatic package when the device is not in use.

PXIe-5860 Package Contents

Shipping kit part number: 789449-01

•  PXIe-5860
•  SMA driver bit
•  Documentation

PXIe-5633 Package Contents

Shipping kit part numbers:

Part Number

790406-08

790406-12

790406-18

790406-26

Description

8 GHz VNA for use with PXIe-5860

12 GHz VNA for use with PXIe-5860

18 GHz VNA for use with PXIe-5860

26.5 GHz VNA for use with PXIe-5860

•  PXIe-5633 module
•  SMA driver bit
•  Documentation

CAL-5501 Package Contents

Shipping kit part number: 788189-01

•  Wooden case
•  CAL-5501

44 ni.com

Installing and Setting Up the PXIe-5860

•  Torque wrench, NI part number 751120-01
•  Locking USB cable, 2 m, NI part number 198506D-02
•  Documentation

Your CAL-5501 kit also includes one of the following calibration certificates based on
the type of mandatory calibration purchased with the accessory:

•  Traceable calibration (960380-01)
•  Compliant calibration (960380-03)
•  ISO 17025 accredited calibration (960380-04)

Installing the PXIe-5860
Installing the

in a PXI Express Chassis
PXIe-5860  in a PXI Express Chassis

Complete these steps to install your PXIe-5860 instrument in your PXI express chassis.

Ensure your PXI Express chassis meets the capacity, power, and slot cooling capacity
requirements of your PXIe-5860 instrument.

Notice To prevent damage to PXI modules from ESD or contamination,
handle each PXI module using the edges or the metal bracket.

To install the PXI modules of your instrument in your PXI chassis, complete the
following steps:

1.  Ensure that the AC power source is connected to the chassis before installing the

modules.
The AC power cord grounds the chassis and protects it from electrical damage
while you install modules.

2.  Power off the chassis.
3.  Inspect the slot pins on the chassis backplane for any bends or damage prior to

installation.
Do not install a module if the backplane is damaged.

4.  Remove the black plastic covers from all the captive screws on the front panels for

all modules.

5.  Based on your instrument, identify the appropriate slots in which to install the

PXIe-5860.

© National Instruments 45

Installing and Setting Up the PXIe-5860

◦  PXIe-5860 VST: Two adjacent, compatible slots
◦  PXIe-5860 with S-parameters: Four adjacent, compatible slots

Note You must install the modules for the PXIe-5860 with S-
parameters in the following order, from left to right: PXIe-5633,
PXIe-5860, PXIe-5633. The interconnection cables are designed for
this order.

You can install the modules of PXIe-5860 instruments in the following PXI chassis
slot types:

◦  PXI Express hybrid peripheral slot:

H

◦  PXI Express system timing slot:

◦  PXI Express peripheral slot:

6.  To discharge static electricity, touch any metal part of the chassis.
7.  Place the edges of a module into the module guides at the top and bottom of an

appropriate chassis slot.
a.  Ensure that the ejector handle is in the downward (unlatched) position.
b.  Slide the module into the slot until it is fully inserted.
c.  Latch the module in place by pulling up on the ejector handle.

8.  Secure the module front panel to the chassis using the front-panel mounting

screws.

Note Attach all front panel mounting screws to the PXI Express chassis to
fully mate all backplane connectors. Tightening the mounting screws
also:

◦  Increases mechanical stability
◦  Electrically connects the front panel to the chassis, which can
improve signal quality and electromagnetic performance

9.  (PXIe-5860 with S-parameters) Repeat steps 6 through 8 for each module of the

instrument.

10.  Cover all empty slots using slot blockers and EMC filler panels.

Note For more information about installing slot blockers and filler
panels, go to ni.com/r/pxiblocker.

46 ni.com

Installing and Setting Up the PXIe-5860

11.  Power on the PXI Express chassis.

The modules of your PXIe-5860 instrument are now correctly installed in your PXI
chassis.

If your instrument combines multiple modules, review the interconnection guidelines
for PXIe-5860 instruments before interconnecting the modules.

PXIe-5860
Ensuring Signal Quality When Connecting the PXIe-5860
Ensuring Signal Quality When Connecting the

To ensure proper connections that maintain signal quality, adhere to these guidelines
while interconnecting the modules.

•  Inspect all RF connectors before attaching mating cables. Clean with dry

compressed air, if necessary, to remove any contaminants that might be present.
•  Position RF cables with instrument connectors to ensure center pins are straight

and aligned before mating.

•  For all threaded RF connectors for your PXIe-5860 instrument, engage and finger-

tighten the connector nuts.
The connector nuts should thread easily without binding. If the connectors nuts
bind:
◦  Ensure that the connector is straight.
◦  Ensure that the center pin of the connectors has not been damaged.
•  Carefully tighten all threaded RF connectors to the torque specified in the

interconnection process for your instrument:
◦  Tighten connectors with an appropriate torque wrench or torque screwdriver

and driver bit.

◦  Tighten only until the wrench or screwdriver reaches the torque limit.

Notice Incorrect torque at threaded connections can damage
connectors and degrade signal integrity.

To complete installation, continue making required connections for your application.

Interconnecting the PXIe-5860
Interconnecting the

with S-Parameters
PXIe-5860  with S-Parameters

Complete this procedure to interconnect the modules of the PXIe-5860 with S-

© National Instruments 47

Installing and Setting Up the PXIe-5860

parameters.

Before you begin this procedure, install the modules of your instrument in your PXI
Express chassis and refer to the interconnection guidelines.

Required Equipment

Item

NI Part Number

PXIe-5860 VST Cable Kit for PXIe-5633 VNA Pass-
through Connection

790504-01

100 N · cm calibrated torque screwdriver for use
with SMA driver bit included in module kits

780487-01

The PXIe-5860 with S-parameters comprises the following equipment:

•  PXIe-5860
•  PXIe-5633 ×2
•  PXIe-5860 VST Cable Kit for PXIe-5633 VNA Pass-through Connection

Once you complete this procedure, your instrument should appear as follows:

48 ni.com

Figure 8. Interconnected PXIe-5860 with S-Parameters

1

2

3

Installing and Setting Up the PXIe-5860

PXIe-5633
VNA

PXIe-5860
Vector Signal Transceiver

PXIe-5633
VNA

ACC

ACTIVE

4
PFI 0

REF
IN

ACCESS

ACTIVE

PORT 1

SEE SPECIFICATIONS FOR
MAX PORT POWER

ACCESS

ACTIVE

RF OUT 0

SEE SPECIFICATIONS FOR
MAX PORT POWER

PORT 1

LO IN

LO OUT

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

PFI 1
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

0

1

2

3

4
DIO

OUT

MGT
100 Ω DIFF

4

LO IN

RF IN 0

LO OUT

4

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

CTRL

RF IN 1

PFI 1

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

RF OUT 1

PFI 1
5 V MAX

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF REPORTS 50Ω

SEE SPECIFICATIONS FOR
CONN MAX IN/OUT LEVELS

ESD
SENSITIVE

1.  Left PXIe-5633: VST or VNA CH 0 for the PXIe-5860 with S-parameters
2.  PXIe-5860 (module)
3.  Right PXIe-5633: VST or VNA CH 1 for the PXIe-5860 with S-parameters
4.  Semi-rigid SMA (m)-to-SMA (m) cables

To interconnect the PXIe-5860 with S-parameters, complete the following steps.

For all connections, begin by loosely hand-tightening the connections. Then, properly
torque connections with the SMA driver bit included in your module kits and a
100 N · cm torque screwdriver (780487-01, sold separately).

© National Instruments 49

Installing and Setting Up the PXIe-5860

1.  Install the cable labeled 118887A-01 to the following connectors such that the

bend in the cable points upwards.

Cable

Left PXIe-5633
Connector

PXIe-5860
Connector

Minimum Torque

118887A-01

SWITCH IN

RF OUT 0

0.9 N · m
(8 lb · in.)

Maximum
Torque

1.0 N · m
(8.85 lb · in.)

PXIe-5633
VNA

PXIe-5860
Vector Signal Transceiver

PXIe-5633
VNA

ACC

ACTIVE

PFI 0

REF
IN

ACCESS

ACTIVE

PORT 1

SEE SPECIFICATIONS FOR
MAX PORT POWER

ACCESS

ACTIVE

RF OUT 0

SEE SPECIFICATIONS FOR
MAX PORT POWER

PORT 1

LO IN

LO OUT

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

PFI 1
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

0

1

2

3

DIO

OUT

MGT
100 Ω DIFF

RF IN 0

LO IN

LO OUT

CTRL

RF IN 1

PFI 1

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

RF OUT 1

PFI 1
5 V MAX

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF REPORTS 50Ω

SEE SPECIFICATIONS FOR
CONN MAX IN/OUT LEVELS

ESD
SENSITIVE

2.  Install the cable labeled 118888A-01 to the following connectors such that the

bend in the cable points upwards.

Cable

Left PXIe-5633
Connector

PXIe-5860
Connector

Minimum Torque

118888A-01

SWITCH OUT

RF IN 0

0.9 N · m
(8 lb · in.)

Maximum
Torque

1.0 N · m
(8.85 lb · in.)

50 ni.com

Installing and Setting Up the PXIe-5860

PXIe-5633
VNA

PXIe-5860
Vector Signal Transceiver

PXIe-5633
VNA

ACC

ACTIVE

PFI 0

REF
IN

ACCESS

ACTIVE

PORT 1

SEE SPECIFICATIONS FOR
MAX PORT POWER

ACCESS

ACTIVE

RF OUT 0

SEE SPECIFICATIONS FOR
MAX PORT POWER

PORT 1

LO IN

LO OUT

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

PFI 1
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

0

1

2

3

DIO

OUT

MGT
100 Ω DIFF

RF IN 0

LO IN

LO OUT

CTRL

RF IN 1

PFI 1

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

RF OUT 1

PFI 1
5 V MAX

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF REPORTS 50Ω

SEE SPECIFICATIONS FOR
CONN MAX IN/OUT LEVELS

ESD
SENSITIVE

3.  Install the cable labeled 118889A-01 to the following connectors such that the

bend in the cable points upwards.

Cable

Right PXIe-5633
Connector

PXIe-5860
Connector

Minimum Torque

118889A-01

SWITCH OUT

RF IN 1

0.9 N · m
(8 lb · in.)

Maximum
Torque

1.0 N · m
(8.85 lb · in.)

© National Instruments 51

Installing and Setting Up the PXIe-5860

PXIe-5633
VNA

PXIe-5860
Vector Signal Transceiver

PXIe-5633
VNA

ACC

ACTIVE

PFI 0

REF
IN

ACCESS

ACTIVE

PORT 1

SEE SPECIFICATIONS FOR
MAX PORT POWER

ACCESS

ACTIVE

RF OUT 0

SEE SPECIFICATIONS FOR
MAX PORT POWER

PORT 1

LO IN

LO OUT

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

PFI 1
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

0

1

2

3

DIO

OUT

MGT
100 Ω DIFF

RF IN 0

LO IN

LO OUT

CTRL

RF IN 1

PFI 1

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

RF OUT 1

PFI 1
5 V MAX

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF REPORTS 50Ω

SEE SPECIFICATIONS FOR
CONN MAX IN/OUT LEVELS

ESD
SENSITIVE

4.  Install the cable labeled 118890A-01 to the following connectors such that the

bend in the cable points upwards.

Cable

Right PXIe-5633
Connector

PXIe-5860
Connector

Minimum Torque

118890A-01

SWITCH IN

RF OUT 1

0.9 N · m
(8 lb · in.)

Maximum
Torque

1.0 N · m
(8.85 lb · in.)

52 ni.com

Installing and Setting Up the PXIe-5860

PXIe-5633
VNA

PXIe-5860
Vector Signal Transceiver

PXIe-5633
VNA

ACC

ACTIVE

PFI 0

REF
IN

ACCESS

ACTIVE

PORT 1

SEE SPECIFICATIONS FOR
MAX PORT POWER

ACCESS

ACTIVE

RF OUT 0

SEE SPECIFICATIONS FOR
MAX PORT POWER

PORT 1

LO IN

LO OUT

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

PFI 1
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

0

1

2

3

DIO

OUT

MGT
100 Ω DIFF

RF IN 0

LO IN

LO OUT

CTRL

RF IN 1

PFI 1

REF IN
5V p-p MAX

REF OUT
2V p-p
MAX
REVERSE

PFI 0
5 V MAX

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

RF OUT 1

PFI 1
5 V MAX

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF REPORTS 50Ω

SEE SPECIFICATIONS FOR
CONN MAX IN/OUT LEVELS

ESD
SENSITIVE

Related concepts:

•  Part Numbers for Recommended PXIe-5860 Cables and Accessories

Performing Initial Hardware Configuration
Performing Initial Hardware Configuration

Before you can use your PXIe-5860, you need to ensure your system recognizes the
instrument.

Related tasks:

•  What Should I Do if the Instrument Does Not Initialize?

© National Instruments 53

Installing and Setting Up the PXIe-5860

Configuring the PXIe-5860
Configuring the

in Hardware Configuration Utility
PXIe-5860  in Hardware Configuration Utility

NI recommends using Hardware Configuration Utility to perform initial hardware
configuration.

1.  Open Hardware Configuration Utility.

The PXIe-5860 should appear in the system pane automatically.
If the PXIe-5860 does not appear automatically, do the following:
a.  Click the + button or, in the menu, select Edit » Add hardware....
b.  Find the modules of your instrument in the Discovered pane and click Add.
2.  Record the name that Hardware Configuration Utility assigns to the PXIe-5860 or, if

desired, provide a custom name to the PXIe-5860.
Use this name when programming the PXIe-5860.

3.  (PXIe-5860 with S-parameters) Associate the PXIe-5860 module with the two

PXIe-5633 modules that it is connected to.
a.  Select the PXIe-5860 module within the chassis in the system pane.
b.  In the Hardware associations area of the configuration pane, define the

PXIe-5633 modules to associate with the PXIe-5860 module.
▪  Switch 0: Select the PXIe-5633 that is installed to the left of the PXIe-5860.
▪  Switch 1: Select the PXIe-5633 that is installed to the right of the PXIe-5860.

c.  Optional: To check that that instrument is associated correctly, click Verify

associations.

4.  Validate that your instrument is installed and connected correctly by performing a

self-test:
a.  Select the PXIe-5860 module of your instrument in the system pane.
b.  Expand the Troubleshooting area of the configuration pane and click Self-test.
c.  Select Intermediate and then click Ok to run the test.
Hardware Configuration Utility reports when the hardware setup is validated.

Configuring the PXIe-5860
Configuring the

in MAX
PXIe-5860  in MAX

You can use Measurement & Automation Explorer (MAX) to perform initial hardware
configuration. MAX is automatically installed with NI-RFSA, NI-RFSG, and RFmx.

1.  Launch MAX.
2.  In the configuration tree, expand Devices and Interfaces to see the list of installed

NI hardware.

54 ni.com

Installing and Setting Up the PXIe-5860

Installed modules appear under the name of their associated chassis.

3.  Expand your Chassis tree item.

MAX lists all modules installed in the chassis. Your default names may vary.

Note If you do not see your module listed, press <F5> to refresh the list
of installed modules. If the module is still not listed, power off the system,
ensure the module is correctly installed, and restart.

4.  Record the name MAX assigns to the PXIe-5860 or, if desired, provide a custom

name to the PXIe-5860.
Use this name when programming the PXIe-5860.

5.  (PXIe-5860 with S-parameters) Associate the PXIe-5860 module with the two

PXIe-5633 modules that it is connected to.
a.  Select the PXIe-5860 module within the chassis tree item.
b.  In the Associated Devices section, define the PXIe-5633 modules to associate

with the PXIe-5860 module.
▪  Associated Switch (Ch0): Select the PXIe-5633 that is installed to the left of

the PXIe-5860.

▪  Associated Switch (Ch1): Select the PXIe-5633 that is installed to the right

of the PXIe-5860.
6.  Perform an intermediate self-test.

a.  Select the item in the configuration tree and click Self-Test in the MAX toolbar.
b.  Select the Intermediate radio button and then click Start.
The green signal illuminates and shows Pass when the self-test completes
successfully.

Making a First VST Measurement
Making a First VST Measurement

You can verify proper installation and configuration of your instrument by making a
measurement using InstrumentStudio.

In this process, you will:

•  Generate an RF test signal from one port of your PXIe-5860 instrument
•  Acquire that test signal on another port of the instrument to verify its functionality

To validate that your PXIe-5860 instrument is set up correctly by making a test

© National Instruments 55

Installing and Setting Up the PXIe-5860

measurement, complete the following steps:

1.  Connect the relevant RF input and RF output ports using the appropriate cable.

Instrument

PXIe-5860 VST

PXIe-5860 with S-parameters

Configuration

◦  Ports: PXIe-5860 RF IN to RF OUT
◦  Cable: SMA-to-SMA
◦  Test frequency: 1 GHz

◦  Ports: PXIe-5633 PORT 1 to PORT 2
◦  Cable: 3.5 mm-to-3.5 mm or SMA-to-SMA
◦  Test frequency: 1 GHz

2.  Launch InstrumentStudio at Start » National Instruments » InstrumentStudio.
3.  Click File » New » RF Signal Generator.
4.  Generate a test CW tone RF signal at the RF output terminal of your instrument.

a.  Select CW in the panel for the instrument.
b.  In the Frequency box, input the test frequency.
c.  In the Level box, enter 0 dBm.
d.  In the Channel list, select the channel corresponding to the connection you

made in step 1.
For example, the list contains PXIxSloty/0 and PXIxSloty/1, where
PXIxSloty is the resource name specified with either the Hardware
Configuration Utility or MAX followed by the channel number.
5.  If the generator is not already running, click Run, and set the output to On.

The instrument generates a signal with the settings you specify.

6.  Click File » New » RF Signal Analyzer.
7.  Locate the panel created for the instrument. In the Channel list, select the channel

corresponding to the connection you made in step 1.
For example, the list contains PXIxSloty/0 and PXIxSloty/1, where
PXIxSloty is the resource name specified with either the Hardware
Configuration Utility or MAX followed by the channel number.

8.  Verify on the RF signal analyzer panel that the PXIe-5860 is receiving the CW tone.
Confirm that the frequency is set to the frequency of the generated tone and that
the reference level is set to an appropriate value, such as 5 dBm.

9.  Close InstrumentStudio.

Related concepts:

56 ni.com

Installing and Setting Up the PXIe-5860

•  RF Cabling Guidelines
•  Guidelines for Making Threaded RF Connections
•  PXIe-5860 Front Panels and Pinouts

Related tasks:

•  Avoiding Damage when Making Direct Connections to the PXIe-5860

Related information:

•  PXIe-5633 User Manual: PXIe-5633 Front Panel and LEDs

© National Instruments 57

PXIe-5860 Operating Guidelines

Operating Guidelines
PXIe-5860  Operating Guidelines
PXIe-5860

Follow these guidelines when operating the PXIe-5860.

Device Warm-Up
Device Warm-Up

NI recommends warming up the PXIe-5860 hardware for 30 minutes before operation.

The unit is fully functional prior to this time, but frequency, amplitude accuracy, and
other specifications are not at warranted levels until the device has fully completed
warming up.

Note Warm up begins when the PXI Express chassis has been powered on
and the operating system has completely loaded.

RF Cabling Guidelines
RF Cabling Guidelines

Use the right RF cables for the connectors on your test instrumentation and DUTs.

The cables you must use to connect external equipment or DUTs to your PXIe-5860
instrument are not included with the PXIe-5860.

Note Refer to the front panel documentation for your module(s) to
understand the types of connectors that are present on the instrument.

NI recommends that the cables you use to connect to your PXIe-5860 instrument meet
the following guidelines, depending on the connector type, to meet the RF
performance requirements of your application:

•  3.5 mm connectors: NI recommends 3.5 mm cables. 2.92 mm cables are

acceptable.

You can also use SMA cables, but verify the following when using SMA cables for
3.5 mm connectors:

58 ni.com

PXIe-5860 Operating Guidelines

◦  Verify that the SMA cable is rated to the frequencies you are using the cable for.
◦  Verify that the center pin length of the SMA connector on your cable does not

exceed the center pin length of the 3.5 mm standard.

•  Other connector types: Use a cable that matches the connector type.

No matter the type of cable you use, ensure that the cable is rated to the frequencies it
will carry.

Related concepts:

•  PXIe-5860 Front Panels and Pinouts

Related information:

•  PXIe-5633 User Manual: PXIe-5633 Front Panel and LEDs

Guidelines for Making Threaded RF Connections
Guidelines for Making Threaded RF Connections

Follow the guidelines to maximize connector life and the quality of connections in your
system.

•  Inspect connectors before making a connection:
◦  Ensure that the mating connectors are clean.
◦  When making a connection, ensure that the male center pin on the connector

aligns with the mating connector. Before mating connectors or cables:
▪  Verify that the connector ends match
▪  Verify that the connectors will mate without damage

•  When making a connection, never turn the cable or body: turn only the connector
nut. Turning the body instead of the nut causes the mating surfaces to wear and
cause a mismatch. Mismatch between the connectors can degrade measurements.

The turning motion of the surfaces can also produce burrs and loose metal
shavings. These contaminants not only affect the measurement but can also
damage other surfaces that they contact.

•  If users frequently change cables and connectors in your test setup, consider using
connector savers. Connector savers reduce wear on critical connectors. Account
for all connector savers in the error budget for a measurement. Only use connector

© National Instruments 59

PXIe-5860 Operating Guidelines

savers when appropriate for the degree of accuracy your measurement requires.

Threaded RF Connector Care Guidelines
Threaded RF Connector Care Guidelines

Proper use and care of the connectors on your instrument is important because
improper connections can damage your instrument and degrade your measurements.
Follow all guidelines to prevent damage to instruments and connectors and to make
the best possible measurements.

•  Tighten connectors without rotating the center pin—Never tighten the

connectors, adapters, or cables such that the center pin rotates.

•  Avoid touching connectors with bare hands—Touching connectors can

contaminate the connectors with natural skin oils and microscopic dirt particles,
which are difficult to remove and can affect measurements.

•  Avoid lateral pressure—Never put lateral pressure on the center pin of the

connector.

•  Always torque connectors to the specified torque using a torque wrench—Do not

overtorque connectors; doing so may damage the connector center pin. NI
recommends a preset 100 N · cm torque screwdriver for tightening SMA connectors
on PXIe-5860 instruments. Tighten SMA connections to the torque specified in this
manual.

•  Do not disturb teflon tuning washers—The center conductor on some RF

components contains a small teflon tuning washer that compensates for minor
impedance discontinuities at the interface. The washer location is critical to the RF
component performance.

Notice Do not disturb the teflon tuning washer in connectors.

•  Avoid mechanical shock—Precision connectors are designed to withstand years of

normal bench handling. Handle the connectors carefully and avoid dropping
them: mechanical shock significantly reduces their service life.

•  Avoid applying excessive power—Test instrumentation is rated for a specific

maximum continuous input power. Exceeding the maximum input power level
permanently damages the internal components. Refer to the safety,
environmental, and regulatory information document or the instrument
specifications for these levels.

•  Protect connectors when not in use—When connectors are not in use, keep them

60 ni.com

PXIe-5860 Operating Guidelines

covered with the dust cap for included with your instrument for the connector.

Avoiding Damage when Making Direct Connections to
Avoiding Damage when Making Direct Connections to
PXIe-5860
the PXIe-5860
the

Because the PXIe-5860 is a precision RF instrument, it is sensitive to ESD and
transients. When you make direct connections to the PXIe-5860, you can avoid
damaging the RF ports by adhering to the following guidelines.

•  Apply external signals only while the hardware is powered on.

Notice Applying external signals while the hardware is powered off
might cause damage.

•  Ensure that you are properly grounded when manipulating cables or antennas

connected to the instrument.

•  If you are using non-insulated devices, such as an RF antenna, keep the devices in

a static-free environment.

•  Ensure that any active device, such as a preamplifier or switch, that is routed to the
PXIe-5860 cannot generate signal transients greater than the RF specifications and
DC specifications of the PXIe-5860.

Power and Thermal Monitoring and Shutdown
Power and Thermal Monitoring and Shutdown
Conditions
Conditions

The PXIe-5860 is protected against excessive temperatures and power consumption
and shuts down in the presence of excessive heat.

When the module shuts down, all of the following occur:

•  The module automatically loads a low-power, nearly empty FPGA image
•  Any instrument driver session or FPGA I/O stops
•  Any program that tries to read or write to the module returns an error

To recover from thermal shutdown, resolve the excessive temperature and restart the
system, or reset the device from MAX. To attempt to resolve the excessive temperature,

© National Instruments 61

PXIe-5860 Operating Guidelines

you can attempt the following:

•  Check that the ambient temperature around the chassis is within specifications

and that the device is receiving proper airflow

•  Make sure that chassis fans are clean and that filler panels or slot blockers cover

any empty slots to maximize cooling airflow

•  Position the chassis so that inlet and outlet vents are not obstructed

You can monitor temperature in your application to detect shutdown conditions. To
monitor how far the module is from the temperature limit, use the FPGA Temperature
property or the NIRFSA_ATTR_FPGA_TEMPERATURE attribute. The thermal shutdown
limit is 99 °C. You can also use the Module Power Consumption property or the
NIRFSA_ATTR_MODULE_POWER_CONSUMPTION attribute to view the power
consumption of the PXIe-5860.

Note A deployed application might run hotter or cooler than it does in
development. Ensure that your application has a wide enough margin to
allow for temperature and power variations between your development
environment and deployment environment.

These variations might occur due to hardware differences or variations in
ambient temperature, air flow, chassis positioning, adjacent modules, power
consumption, and other factors.

Power On and Reset Conditions
PXIe-5860  Power On and Reset Conditions
PXIe-5860

The PXIe-5860 sets some hardware circuitry to certain states at power on and at device
reset.

Power on conditions are present after powering on or restarting the system and until
you specify a different configuration.

Reset conditions apply to the device state upon device reset.

When you power on or reset the PXIe-5860, bidirectional terminals are configured as
inputs and output terminals are configured as high impedance.

62 ni.com

•  RF OUT <0,1> are terminated to 50 Ω
•  REF: OUT is configured as high impedance
•  PFI <0,1> is configured as an input

PXIe-5860 Operating Guidelines

© National Instruments 63

Making Connections to the PXIe-5860

PXIe-5860
Making Connections to the PXIe-5860
Making Connections to the

Follow these instructions to connect a DUT to the PXIe-5860.

Depending on whether you want to input signals into the instrument or output signals
from it, connect a compatible cable as follows:

Instrument

PXIe-5860 VST

Process

PXIe-5860 with S-parameters

•  For input (vector signal analysis), connect to
RF IN on the front panel of the PXIe-5860
module

•  For output (vector signal generation),

connect to RF OUT on the front panel of the
PXIe-5860 module

Connect to PORT 1 or PORT 2 of the PXIe-5633
modules for input and output for both VST and
VNA functionality:

•  CH 0 of the instrument is available from the
PXIe-5633 module that is installed to the left
of the PXIe-5860 module

•  CH 1 of the instrument is available from the
PXIe-5633 module that is installed to the
right of the PXIe-5860 module

A single VST channel is available from either
PORT 1 or PORT 2 of a single PXIe-5633 module
within the PXIe-5860 with S-parameters.

Tighten threaded connections to a torque of 0.9 N · m to 1.0 N · m (8 lb · in. to
8.85 lb · in.).
Related concepts:

•  PXIe-5860 Front Panels and Pinouts
•  Part Numbers for Recommended PXIe-5860 Cables and Accessories

64 ni.com

Analyzing RF Signals with RFmx

Analyzing RF Signals with RFmx
Analyzing RF Signals with RFmx

RFmx is a set of RF measurement personalities, each designed to enable a specific type
of RF measurements. Each RFmx personality includes a soft front panel and
accompanying low-level APIs that let you use that personality in programs you
develop.

This documentation describes using the RFmx API to develop signal analysis programs
for your RF instrument.

Note While RFmx panels might make use of both signal analysis and signal
generation functionality, low-level RFmx APIs enable signal analysis only. Use
the NI-RFSG API to include signal generation in programs you develop.

There are two general parts of an RFmx program:

•  RFmxInstr—Entry points that create and end the RFmx session and perform

hardware configuration. Common to all RFmx personalities.

•  Measurement entry points—Entry points specific to, and named for, each RFmx
measurement personality. Define the parameters of the measurement itself.

Each RFmx personality includes both RFmxInstr entry points and the measurement-
specific entry points.

Note Each RFmx personality includes a wide array of entry points to control
your instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create an RF signal analysis
program successfully.

1.  Initialize a Session

Use RFmxInstr Initialize NIRFSA to create a session with the PXIe-5860. All RFmx
programs must begin with an RFmxInstr function.

2.  Configure Hardware Settings

Use RFmxInstr functions and properties to configure your hardware to use the

© National Instruments 65

Analyzing RF Signals with RFmx

correct settings for the measurement.

3.  Configure the Measurement

Use the functions and properties specific to your RFmx personality to configure
that measurement.

4.  Close the Session

Every RFmx session must be closed in order to deallocate memory, destroy
threads, and free operating system resources.

Initialize a Session
Initialize a Session

Use RFmxInstr Initialize NIRFSA to create a session with the PXIe-5860. All RFmx
programs must begin with an RFmxInstr function.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call RFmxInstr
Initialize NIRFSA one time.

1.  Call RFmxInstr Initialize NIRFSA. Ensure that the Resource Name input specifies a
channel. For example: PXI1Slot2/0, where PXI1Slot2 is the resource ID
configured in the Hardware Configuration Utility or MAX, and /0 is the channel to
use.

Tip For most RFmx personalities, you can include measurement
functions from any number of personalities in a single session initialized
with RFmxInstr Initialize NIRFSA; you do not need to create unique
sessions for each personality. The exception is RFmx VNA, which cannot
be used in a session that includes any other RFmx personalities.

2.  Optional: Define an option string.

Setting option string to AnalysisOnly allows your program to perform
analysis of preexisting I/Q data or spectrum. Use this option to analyze RF data
without using hardware.

Configure Hardware Settings
Configure Hardware Settings

Use RFmxInstr functions and properties to configure your hardware to use the correct

66 ni.com

Analyzing RF Signals with RFmx

settings for the measurement.

1.  Call RFmxInstr Configure Frequency Reference and select the reference clock

source that corresponds to the physical configuration your instrument.
◦  Onboard Clock: Uses the clock within the PXIe-5860 instrument. The default

option.

◦  RefIn: Uses an external reference clock source. For PXIe-5860 instruments, this
clock is from external equipment that supplies a compatible clock, which you
connect to the REF IN port of the PXIe-5860.

◦  PXI_Clock: Uses the PXI_CLK signal from the PXI backplane.

2.  If you selected an external reference clock source (RefIn), provide a valid

Frequency.

3.  Optional: Make additional configuration selections using configuration and utility

functions and session properties as desired.
For example, you can use RFmxInstr configuration functions to account for
attenuation due to RF components in the signal path.

Configure the Measurement
Configure the Measurement

Use the functions and properties specific to your RFmx personality to configure that
measurement.

Each RFmx personality has its own measurement API to enable the related
measurement type.

Tip For most RFmx personalities, you can include measurement functions
from any number of personalities in a single session initialized with
RFmxInstr Initialize NIRFSA; you do not need to create unique sessions for
each personality. The exception is RFmx VNA, which cannot be used in a
session with any other RFmx personalities.

If you are programming in LabVIEW, you can refer to the VI Tree function on the palette
for your RFmx personality for an inventory of all the functions included in the API
placed in the order in which you need to call them to create a successful program. View
the block diagram of the VI Tree to see the VI programming flow.

© National Instruments 67

Analyzing RF Signals with RFmx

Close the Session
Close the Session

Every RFmx session must be closed in order to deallocate memory, destroy threads,
and free operating system resources.

Required: Use RFmxInstr Close to conclude the session and free system resources.

68 ni.com

Analyzing RF Signals with NI-RFSA

NI-RFSA
Analyzing RF Signals with NI-RFSA
Analyzing RF Signals with

The primary function of vector signal analyzers and a primary function of vector signal
transceivers is to analyze RF signals. To perform this operation while gaining access to
the lowest level functionality of NI VSAs and VSTs, use the NI-RFSA instrument driver.

Note NI-RFSA includes a wide array of entry points to control your
instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create an RF signal analysis
program successfully.

1.  Initialize a Session

Use Initialize to create a session with the PXIe-5860. All programs must begin with
Initialize.

2.  Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that
instruments in the session are operating from a common timebase.

3.  Configure the Acquisition

Use NI-RFSA to configure the acquisition parameters for the RF signal you want to
analyze. There are two categories of acquisitions you can perform: I/Q acquisitions
and power spectrum acquisitions.

4.  Coordinate Actions with Triggers and Events

Use triggers and events to implement conditional behavior on your instrument
and to coordinate the action of multiple instruments.

5.  Read and Plot Acquired Data

Once you have defined the parameters for the RF signal acquisition, you can
perform the acquisition and visualize the RF data you acquire.

6.  Close the Session

Every NI-RFSA session must be closed in order to deallocate memory, destroy
threads, and free operating system resources.

Initialize a Session
Initialize a Session

Use Initialize to create a session with the PXIe-5860. All programs must begin with
Initialize.Ensure that the resource name input specifies a channel. For example:

© National Instruments 69

Analyzing RF Signals with NI-RFSA

PXI1Slot2/0, where PXI1Slot2 is the resource ID configured in the Hardware
Configuration Utility or MAX, and /0 is the channel to use.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call Initialize one time.

Configure the Reference Clock
Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that instruments
in the session are operating from a common timebase.

1.  Call Configure Ref Clock and select the reference clock source that corresponds to

the physical configuration your instrument.

◦  Onboard Clock: Uses the clock within the PXIe-5860 instrument. The default

option.

◦  RefIn: Uses an external reference clock source. For PXIe-5860 instruments, this
clock is from external equipment that supplies a compatible clock, which you
connect to the REF IN port.

◦  PXI_Clk: Uses the PXI_CLK signal from the PXI backplane.

2.  If you selected an external reference clock source (RefIn), provide a valid clock

rate. Valid clock rates are:
◦  10 MHz
◦  100 MHz

Configure the Acquisition
Configure the Acquisition

Use NI-RFSA to configure the acquisition parameters for the RF signal you want to
analyze. There are two categories of acquisitions you can perform: I/Q acquisitions and
power spectrum acquisitions.

1.  Call Configure Acquisition Type to designate the type of acquisition to perform

◦  IQ: Acquire I/Q data
◦  Spectrum: Compute a power spectrum over a given frequency range

2.  Call Configure Reference Level and provide the maximum expected power of the

70 ni.com

RF signal you are acquiring.

3.  Depending on the type of acquisition you want to make, set other parameters for

Analyzing RF Signals with NI-RFSA

the acquisition:

Acquisition Type

I/Q

Spectrum

Procedure

a.  Call Configure IQ Carrier Frequency and

provide the carrier frequency—the center
frequency of the I/Q acquisition.

b.  Call Configure IQ Rate to set the I/Q rate,

in samples per second, for the acquisition.

c.  Use Configure Number of Samples to
choose whether you want to acquire
continuously or to acquire a finite number
of samples.

a.  Define the spectrum to analyze.

▪  Use Configure Spectrum Frequency
Start Stop to set lower and upper
bounds on the spectrum.

▪  Use Configure Spectrum Frequency
Center Span to define a center
frequency and an associated span
surrounding that frequency.
b.  Use Configure Resolution Bandwidth to
set the size of the frequency bins in the
power spectrum; higher resolution yields
wider bins.

Coordinate Actions with Triggers and Events
Coordinate Actions with Triggers and Events

Use triggers and events to implement conditional behavior on your instrument and to
coordinate the action of multiple instruments.

•  Call Configure Trigger and choose the instance that supports your application

needs.
Configure Trigger defines the named trigger, as well as the type of signal that
represents the named trigger, that the instrument should expect before taking the
action the rest of your program defines.

•  If you chose a software instance of Configure Trigger, call Send Software Edge

Trigger later in your program to have the program provide that trigger, regardless

© National Instruments 71

Analyzing RF Signals with NI-RFSA

of whether an actual trigger has occurred within your hardware setup.

•  Use Export Signal to route a signal of your choosing to a terminal of your choosing.

For example, you can use Export Signal to route a signal from a first instrument to a
second instrument that is awaiting that signal, as defined by the Configure Trigger
instance for the second instrument.

NI-RFSA Named Trigger Types

Named trigger types in NI-RFSA define the action you want an instrument to take upon
detecting a specific signal condition.

•  Start—Transitions an instrument into a state where the instrument can respond to
Sample Clocks. This trigger transitions the instrument from a nonsampling state
into a sampling state—the instrument starts sampling and storing data.

Supported signal conditions: None, Digital Edge, Software

•  Reference—Establishes the reference point that separates pretrigger and

posttrigger samples; transitions an instrument from the Wait for Reference Trigger
sampling state into the Post Reference Trigger sampling state. In the Post
Reference Trigger sampling state, a counter begins counting Sample Clock cycles.
When the configured number of samples is acquired, the device transitions into a
Done state.

Supported signal conditions: None, Digital Edge, IQ Power Edge, Software

•  Advance—Initiates the acquisition of the additional records in a multirecord

acquisition.

Supported signal conditions: None, Digital Edge, Software

NI-RFSA Trigger Signal Conditions

NI-RFSA includes four possible signal conditions that can serve as the stimulus for an
action an instrument or channel can take: digital edge, I/Q power edge, software edge,
and none.

72 ni.com

Analyzing RF Signals with NI-RFSA

Note Not all named trigger types in NI-RFSA support all signal conditions.

None

Signal acquisition starts immediately upon execution of the NI-RFSA Initiate function;
no Start or Script trigger is necessary. This configuration is the default for instruments
programmed with NI-RFSA.

Digital Edge

A channel performs an operation when the signal transitions from high to low or from
low to high.

A digital signal has two discrete levels: a high level and a low level. When the signal
transitions from high to low or from low to high, a digital edge is created. There are two
types of edges: rising, which occurs when the signal transitions from low level to high
level, and falling, which occurs with a transition from high level to low level. Triggers
configured to act on a rising or falling edge of a digital signal are called edge triggers.
Digital triggering is possible on the RTSI lines, PFI lines, and the PXI Star Trigger line.

As the figure shows, an edge trigger can be configured to occur either at the place
labeled Falling Edge of Signal or Rising Edge of Signal.

You can configure each named trigger to operate based on a digital edge.

I/Q Power Edge Trigger

After data has been downconverted and decimated, NI-RFSA calculates the
instantaneous power of the I/Q data (I2 + Q2) in the digital downconverter and uses this
value as a source for the Reference Trigger for the IF digitizer.

© National Instruments 73

High LevelLow LevelRising edge of signalFalling edge of signalAs shown in the figure, an I/Q power edge trigger can be configured to occur either at
the positive slope or the negative slope.

Analyzing RF Signals with NI-RFSA

Trigger
Level

Trigger on
Positive Slope

Trigger on
Negative Slope

Only Reference triggers may be configured to trigger based on the I/Q power edge.

Software Trigger

A software trigger is generated internally by a programmatic call to the NI-RFSA Send
Software Edge Trigger function and can occur at any time, based upon the conditions
specified in the program.

You can configure each named trigger in NI-RFSA to operate based on a software edge.

NI-RFSA Event Types

NI-RFSA includes specific events you can use in tandem with triggers to coordinate
actions across instruments.

•  Ready for Start—Indicates the instrument is configured and ready to receive a

Start trigger.

•  Ready for Advance—Indicates that the acquisition of a previous record is complete

and that the instrument has entered its Wait for Advance Trigger state.

•  Ready for Ref—Indicates when the instrument enters its Wait for Reference Trigger

while Sampling state.

•  End of Record Event—Indicates that the current record has been acquired and that

the instrument has entered its Record Complete state.
•  Done—Indicates the device has completed its acquisition.

74 ni.com

Analyzing RF Signals with NI-RFSA

Read and Plot Acquired Data
Read and Plot Acquired Data

Once you have defined the parameters for the RF signal acquisition, you can perform
the acquisition and visualize the RF data you acquire.

1.  Based on whether you chose an I/Q acqusition or a spectrum acquisition, read the

data in order to plot it.
◦  I/Q: Call Read IQ and choose the data type to return.
◦  Spectrum: Call Read Power Spectrum and choose the data type to return.
2.  If you acquired I/Q data, call Get IQ Components to separate the data into separate

I and Q components you can visualize.

Close the Session
Close the Session

Every NI-RFSA session must be closed in order to deallocate memory, destroy threads,
and free operating system resources.

Required: Use Close to conclude the session and free system resources.

© National Instruments 75

Generating RF Signals with NI-RFSG

NI-RFSG
Generating RF Signals with NI-RFSG
Generating RF Signals with

The primary function of vector signal generators and a primary function of vector
signal transceivers is to generate RF signals. To perform this operation with NI VSGs
and VSTs, use the NI-RFSG instrument driver.

Note NI-RFSG includes a wide array of entry points to control your
instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create an RF signal generation
program successfully.

1.  Initialize a Session

Use Initialize to create a session with the PXIe-5860. All programs must begin with
Initialize.

2.  Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that
instruments in the session are operating from a common timebase.

3.  Configure the RF Output Signal

Use NI-RFSG to configure the parameters of the RF signal you want to generate.

4.  Coordinate Actions with Triggers and Events

Use triggers and events to implement conditional behavior on your instrument
and to coordinate the action of multiple instruments.

5.  Initiate Waveform Generation

Initiate the instrument to apply any configured settings and begin generating the
RF signal. All NI-RFSG waveform generation programs must call this function.

6.  Check the Status of RF Signal Generation

All NI-RFSG programs must call this function, which provides an opportunity to
check for errors in the program that occur during generation and indicates
whether generation has concluded.

7.  Close the Session

Every NI-RFSG session must be closed in order to deallocate memory, destroy
threads, and free operating system resources. Closing a session also stops
waveform generation, if it hasn't been stopped already.

76 ni.com

Generating RF Signals with NI-RFSG

Initialize a Session
Initialize a Session

Use Initialize to create a session with the PXIe-5860. All programs must begin with
Initialize.Ensure that the resource name input specifies a channel. For example:
PXI1Slot2/0, where PXI1Slot2 is the resource ID configured in the Hardware
Configuration Utility or MAX, and /0 is the channel to use.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call Initialize one time.

Configure the Reference Clock
Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that instruments
in the session are operating from a common timebase.

1.  Call Configure Ref Clock and select the reference clock source that corresponds to

the physical configuration your instrument.

◦  Onboard Clock: Uses the clock within the PXIe-5860 instrument. The default

option.

◦  RefIn: Uses an external reference clock source. For PXIe-5860 instruments, this
clock is from external equipment that supplies a compatible clock, which you
connect to the REF IN port.

◦  PXI Clock: Uses the PXI_CLK signal from the PXI backplane.

2.  If you selected an external reference clock source (RefIn), provide a valid ref

clock rate. Valid clock rates are:
◦  10 MHz
◦  100 MHz

Configure the RF Output Signal
Configure the RF Output Signal

Use NI-RFSG to configure the parameters of the RF signal you want to generate.

Complete the following steps to configure the center frequency, output power level,

© National Instruments 77

Generating RF Signals with NI-RFSG

generation mode, and, for arbitrary waveforms, the signal bandwidth.

1.  Required: Use Configure RF to define the center frequency and power level of the

RF signal to generate.

Note All NI-RFSG programs must include at least Configure RF.

2.  Use Configure Generation Mode to define the type of signal to generate: CW, an

arbitrary waveform, or a waveform dictated by scripts you create.

3.  If generating an arbitrary waveform, with or without scripting, use Configure Signal

Bandwidth to define the bandwidth for the signal.

4.  If generating an arbitrary waveform, with or without scripting, use Write Arb

Waveform to construct the waveform to generate.

5.  If using scripting to generate an arbitrary waveform, use Write Script to incorporate

your script into the program.

Coordinate Actions with Triggers and Events
Coordinate Actions with Triggers and Events

Use triggers and events to implement conditional behavior on your instrument and to
coordinate the action of multiple instruments.

•  Call Configure Trigger and choose the instance that supports your application

needs.
Configure Trigger defines the named trigger, as well as the type of signal that
represents the named trigger, that the instrument should expect before taking the
action the rest of your program defines.

•  If you chose a software instance of Configure Trigger, call Send Software Edge

Trigger later in your program to have the program provide that trigger, regardless
of whether an actual trigger has occurred within your hardware setup.

•  Use Export Signal to route a signal of your choosing to a terminal of your choosing.

For example, you can use Export Signal to route a signal from a first instrument to a
second instrument that is awaiting that signal, as defined by the Configure Trigger
instance for the second instrument.

NI-RFSG Named Trigger Types

Named trigger types in NI-RFSG define the action you want an instrument or

78 ni.com

Generating RF Signals with NI-RFSG

instrument channel to take upon detecting a specific signal condition.

Trigger stimuli include digital edges, software functions, and analog levels. The trigger
can be derived from attributes of the signal to be acquired, such as the level and slope
of the signal.

The following named trigger types are available in NI-RFSG:

•  Start—Initiates signal generation.

Supported signal conditions: None, Digital Edge, Software

•  Script—General-purpose trigger with a role that is determined entirely by the
context of the generation script. A script allows you to create sophisticated
generation operations. For example, the script could configure the device to
generate waveform A, then wait for the Script Trigger, then generate waveform B.
You can configure up to four Script Triggers for use in your application. Once a
digital edge Script Trigger has been received, that trigger remains true for all
subsequent instructions until the clear instruction is called or the trigger is reset
after being used in the wait, repeat/end repeat, or if instructions.

Supported signal conditions: None, Digital Edge, Digital Level, Software

•  Configuration List Step—Transitions an instrument to the next step in the list.

Supported signal conditions: None, Digital Edge

NI-RFSG Start Trigger Details

For waveform generators and VSTs, a Start trigger initiates signal generation.

When the instrument receives a Start trigger, the RF output signal begins to generate
as shown in the following figure. The instrument ignores a Start trigger received after
signal generation has started.

© National Instruments 79

Figure 9. NI-RFSG Start Trigger Model

Start
Trigger

Generating RF Signals with NI-RFSG

Waveform Repeats
Continuosly

End of Waveform

Note All devices that reside between the waveform generator and the
output signal introduce a delay from the Start trigger to waveform
generation.

Configure the Start trigger using the Start Trigger Type property. The Configure Trigger
function also provides access to this property.

Tip Sending a software trigger when you set Start Trigger Type to Digital
Edge also starts signal generation. You can use this approach to create a
software timeout to avoid leaving the instrument in a waiting state if the
digital edge is never received.

The possible sources for a Start trigger are as follows.

80 ni.com

Generating RF Signals with NI-RFSG

Figure 10. NI-RFSG Start Trigger Sources

s
u
B

I

X
P

PXI Star

PXI_Trig <0..>

PFI <0..1>

MUX

Start Trigger

Start Trigger Out

Software Trigger

NI-RFSG Script Trigger Details

A Script trigger is a general-purpose trigger with a role determined entirely by the
context of the dynamic generation script.

A script allows you to create sophisticated dynamic generation operations. For
example, the script can configure the instrument to generate waveform A, then wait for
a Script trigger, then generate waveform B. You can configure up to four Script triggers
for use in your application.

Figure 11. NI-RFSG Script Trigger Sources

s
u
B

I

X
P

PXI Star

PXI_Trig <0..>

PFI <0..1>

MUX

Script Trigger

Software Trigger

Note All devices that reside between the waveform generator and the

© National Instruments 81

Generating RF Signals with NI-RFSG

output signal introduce a delay between the Script trigger and generation of
the waveform.

Configure the Script trigger using the Script Trigger Type property. The Configure
Trigger function also provides access to this property.

Tip Sending a software trigger when you set Script Trigger Type to Digital
Edge also starts signal generation. You can use this to create a software
timeout to avoid leaving the instrument in a waiting state if the digital edge is
never received.

NI-RFSG Trigger Signal Conditions

NI-RFSG includes four possible signal conditions that can serve as the stimulus for an
action an instrument or channel can take: digital edge, digital level, software edge, and
none.

Note Not all named trigger types in NI-RFSG support all signal conditions.

None

Signal generation starts immediately upon execution of the NI-RFSG Initiate function;
no Start or Script trigger is necessary to begin generation.

This configuration is the default behavior for instruments programmed with NI-RFSG.

Digital Edge

A channel performs an operation when the signal transitions from high to low or from
low to high.

A digital signal has two discrete levels: a high level and a low level. When the signal
transitions from high to low or from low to high, a digital edge is created. There are two
types of edges: rising, which occurs when the signal transitions from low level to high
level, and falling, which occurs with a transition from high level to low level. Triggers
configured to act on a rising or falling edge of a digital signal are called edge triggers.

82 ni.com

Generating RF Signals with NI-RFSG

Digital triggering is possible on the RTSI lines, PFI lines, and the PXI Star Trigger line.

As the figure shows, an edge trigger can be configured to occur either at the place
labeled Falling Edge of Signal or Rising Edge of Signal.

You can configure each named trigger to operate based on a digital edge.

Digital Level

A channel performs an operation when a signal goes below a defined low level or
above a defined high level.

Triggers configured to act in this way are known as level triggers.

Only Script triggers may be configured to trigger based on a digital level.

Software Edge

After initiation, a software trigger is generated internally by a programmatic call using
NI-RFSG and can occur at any time, based upon the conditions specified in the
program.

You can configure Start and Script triggers in NI-RFSG to operate based on a software
edge.

Use NI-RFSG Send Software Edge Trigger and set the trigger type input to the
type of trigger you want to send.

NI-RFSG Event Types

NI-RFSG includes specific events you can use in tandem with triggers to coordinate
actions across instruments.

© National Instruments 83

High LevelLow LevelRising edge of signalFalling edge of signalGenerating RF Signals with NI-RFSG

•  Marker—Occurs at the time that a specific location or sample n in the waveform
generates on the output connector. If the waveform loops multiple times in a
segment, the marker generates each time the waveform loops.

•  Started—Emitted when the RF signal generator has received a Start trigger and is

generating a waveform.

•  Done—Indicates that the generation of the previous waveform is complete.
•  Configuration Settled—Indicates when the signal has settled for a given

configuration list step. The definition of settled is determined based on the values
of the Frequency Settling and Frequency Settling Units properties.

NI-RFSG Marker Event Details

A marker is an event that an NI RF signal generator produces in relation to a waveform
that is generated. The marker event is delayed slightly relative to the leading edge of
the waveform that it marks.

By default, the marker event is a pulse of fixed width. The following figure shows a
waveform generated on the output of a waveform generator. The waveform contains a
pulse that represents a waveform sample n that is one Sample Clock in width. The
second pulse, the marker event, represents the pulse that generates when the
corresponding waveform sample n is output at the output connector.

Figure 12. Waveform Output and Associated Marker Event

Waveform
Sample n

Waveform Output
on Output Connector

Marker Event

tm1

tm2

•  tm1—Duration of delay between the configured waveform sample n and

generation of the associated marker event. For most NI VSTs, configurable with
NI-RFSG Events Delay and Relative Delay.

•  tm2—Marker event pulse duration. For most NI VSTs, configurable with NI-RFSG

Width Units and Width Value.

You can use NI-RFSG to configure the characteristics of the pulse generated as the

84 ni.com

Generating RF Signals with NI-RFSG

Marker event.

In addition, you can use scripts to create markers to develop complex behaviors
around generated waveforms.

For example, you can configure the Marker event as a toggled digital pulse signal that
changes state between a low level and high level. While the basic pulse option for
Marker events generates event pulses of fixed width, using the toggle option allows
you to use scripts to change the duration of the Marker event pulse. You can control
the initial state of the toggled pulse with MarkerEvent.Toggle.InitialState.

Initiate Waveform Generation
Initiate Waveform Generation

Initiate the instrument to apply any configured settings and begin generating the RF
signal. All NI-RFSG waveform generation programs must call this function.

Call Initiate to apply all configured settings, if they have not already been applied, and
start RF generation.

Check the Status of RF Signal Generation
Check the Status of RF Signal Generation

All NI-RFSG programs must call this function, which provides an opportunity to check
for errors in the program that occur during generation and indicates whether
generation has concluded.

Call Check Generation Status.

Tip NI recommends placing this function in a while loop to continually check
the generation status. Use the Wait function to limit how frequently the loop
runs to conserve CPU usage.

Close the Session
Close the Session

Every NI-RFSG session must be closed in order to deallocate memory, destroy threads,
and free operating system resources. Closing a session also stops waveform
generation, if it hasn't been stopped already.

© National Instruments 85

Required: Use Close to conclude the session and free system resources.

Generating RF Signals with NI-RFSG

86 ni.com

Using the PXIe-5860 with S-Parameters as a VNA

Using the
Using the PXIe-5860
VNA
VNA

PXIe-5860  with S-Parameters

as a
with S-Parameters  as a

You can design your own RFmx VNA programs to use the VNA functionality of the
PXIe-5860 with S-parameters. You can also control the PXIe-5860 with S-parameters as
a VNA interactively with InstrumentStudio.

Designing VNA Measurement Applications for the
Designing VNA Measurement Applications for the
with S-parameters
PXIe-5860  with S-parameters
PXIe-5860

Use the PXIe-5860 with S-parameters to make VNA measurements—S-parameters and
incident and reflected waves—for 1-port and 2-port devices. To design measurement
programs for the PXIe-5860 with S-parameters, use the RFmx VNA API.

You can also control the PXIe-5860 with S-parameters interactively with
InstrumentStudio. This process describes how to use the RFmx VNA API to build VNA
measurement applications for the PXIe-5860 with S-parameters that include
measurement calibration with the CAL-5501 vector calibration module.

Note RFmx VNA includes a wide array of entry points to control your
instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create a VNA measurement
program successfully.

Initialize a Session

Use RFmxInstr Initialize to create a session with the PXIe-5860. All RFmx programs
must begin with an RFmxInstr function.

Initializing returns an instrument handle with the session configured to a known state.

Initializing can take a significant amount of time compared to other functions, so you
should not include it in loops. Ideally, your program should call RFmxInstr Initialize

© National Instruments 87

Using the PXIe-5860 with S-Parameters as a VNA

one time.

Call RFmxInstr Initialize.

Tip For most RFmx personalities, you can include measurement functions
from any number of personalities in a single session initialized with
RFmxInstr Initialize.

The exception is RFmx VNA. You cannot use RFmx VNA functions in a session
that includes any other RFmx personalities.

De-Embed Fixtures

De-embed the effects of all cabling and connectors between your DUT and the
PXIe-5860 instrument. De-embedding ensures that you are characterizing your DUT,
not your larger test setup.

This process assumes your overall testing process uses an .s2p file to accomplish de-
embedding.

Note De-embedding is not necessary in certain situations where you can
perform measurement calibration so that the measurement calibration plane
is at the DUT. If you can do so, you can avoid de-embedding in the following
situations:

•  If you are using a manual calibration kit.
•  If you are using the PXIe-5860 with S-parameters with a connectorized

fixture that can connect to the CAL-5501.

This process describes de-embedding for 2-port devices.

You can de-embed elements of your physical setup with RFmxInstr Load S-parameter
External Attenuation Table from S2P File.

Iterate through the following steps for each port.

88 ni.com

Using the PXIe-5860 with S-Parameters as a VNA

1.  Specify, or allow an operator to input, the following information:

◦  Name of the port in question
◦  Filepath to the .s2p file
◦  Orientation of the port with respect to the DUT: whether port 1 or port 2 of the

.s2p is oriented towards the DUT

2.  Construct a port string with the port name entry and the Build Port String function

in the RFmx API you are using.

3.  Call RFmxInstr Load S-parameter External Attenuation Table from S2P File.

Configure Frequency Sweep Settings

Use RFmx VNA properties to configure the frequency sweep parameters.

1.  Define the sweep by choosing the Sweep Type and, based on the option you

choose, define the frequencies to include in the sweep.
Each sweep type has its own properties for configuring the frequencies that are
included in the sweep. Refer to the contextual help in your programming
environment for more information.

2.  Define the IF Bandwidth (Hz) for the sweep.

Only certain discrete bandwidth values are supported. Refer to the contextual help
in your programming environment for these values.

Tip The smaller the IF bandwidth, the lesser the influence of noise on the
measurement, but the longer the sweep time.

3.  Set port-specific parameters.

◦  Selector String: Define the port(s) to apply the settings to.
◦  Power Level (dBm): Set the source power level for the VNA port.
◦  Test Receiver Attn (dB): Specify the attenuation you want the VNA to apply to:
▪  Waves reflected by the DUT back to the source port of the PXIe-5633
▪  Waves emitted from the DUT to the receiver port of the PXIe-5633

Configure VNA Measurement Settings

The PXIe-5860 with S-parameters can measure either S-parameters or incident and
reflected waves.

© National Instruments 89

S-parameters are represented with the convention Sxy, where x is the measure port
and y is the source port.

Using the PXIe-5860 with S-Parameters as a VNA

For example, consider the following setup:

•  PORT 1 of a PXIe-5633 module: connected to DUT input
•  PORT 2 of the same PXIe-5633 module: connected to DUT output

In this case, S21 refers to sourcing on port 1 and measuring on port 2.

The PXIe-5860 with S-parameters can also measure incident and reflected waves.

Use RFmx VNA to configure the settings for these measurements.

1.  Define measurement averaging settings:

a.  Control whether to apply averaging with Averaging Enabled.
b.  If using averaging, define the number of acquisitions to average with Averaging

Count.

2.  Call the relevant RFmx VNA function and select the measurement(s) to perform:

◦  Single measurement type: RFmx VNA Select Measurement (Single)
◦  Multiple measurement types: RFmx VNA Select Measurement (Multiple)
3.  Depending on the measurement type, specify the number of items to measure:

◦  S-parameter measurement: SParams Num SParams
◦  Waves measurement: Waves Num Waves

4.  For as many individual S-parameters or waves as you are measuring, iteratively

configure port-specific settings for the measurement(s).
a.  Provide the Selector String for the remaining elements of this step.

▪  S-parameters: Build S-Parameter String
▪  Waves: Build Wave String

b.  Define the port acting as the receiver:

▪  S-parameters: SParams Configure S-Parameter
▪  Waves: Waves Configure Wave

c.  (Waves only) Use Waves Receiver to define whether to measure the wave on
the reference receiver or the test receiver of the port you defined with Waves
Receiver Port.

d.  Define the port acting as the source:

▪  S-parameters: SParams Configure S-Parameter
▪  Waves: Waves Configure Wave

90 ni.com

Using the PXIe-5860 with S-Parameters as a VNA

e.  Define the format for the measurement:
▪  S-parameters: SParams Format
▪  Waves: Waves Format
For both measurement types, you can return magnitude, phase, or raw
complex values.

5.  For magnitude and phase measurements, choose the units for magnitude

measurements and, for phase, whether the result should be wrapped between
-180° and 180° or unwrapped.
◦  S-parameters: SParams Magnitude Units, SParams Phase Trace Type
◦  Waves: Waves Magnitude Units, Waves Phase Trace Type

Implement a Measurement Calibration Process

When designing VNA measurement programs, include measurement calibration
prompts to your end users to ensure the most accurate results.

The PXIe-5860 with S-parameters is designed to use the CAL-5501 vector calibration
module for electronic calibration. The PXIe-5860 with S-parameters also supports
manual calibration, in which you use your own calibration standards to perform
measurement calibration.

1.  Specify the ports for the measurement calibration with Cal Ports.
2.  Use Cal Method to choose the measurement calibration method that corresponds

to your test setup.

3.  Input the type of connector for your measurement calibrator with Connector Type.
This value must correspond to the connectors of the measurement calibrator you
are using. To use the CAL-5501, set this field to 3.5 mm female.

4.  Provide the vCal Resource Name to include the measurement calibrator in the

session.

Note In the RFmx VNA API, vCal refers to the CAL-5501 electronic
calibrator.

5.  Call RFmx VNA Calibration Initiate to commit measurement calibration settings to

the session.

6.  Include a prompt that directs the operator to connect the correct ports of the

CAL-5501 (or manual calibration kit) and the PXIe-5633 module.
The prompt should allow the operator to signal that the task is complete and then

© National Instruments 91

Using the PXIe-5860 with S-Parameters as a VNA

proceed.

7.  Call RFmx VNA Calibration Acquire and Calibration Save.

Calibration Acquire gathers measurement calibration data using the connected
CAL-5501. Calibration Save calculates error correction terms and saves the
resulting correction data (calset) in memory.

Tip You can also design programs around saving and loading calsets to
and from files (.ncst), rather than memory. Use Calset Save to File and
Calset Load from File.

8.  Depending on the measurement calibration type, include a prompt that directs the
operator to connect the DUT to the PXIe-5633 module and that gives the operator a
way to signal that this task is complete:
◦  1-port calibration and measurement: Connect the DUT port to the calibrated
port of the PXIe-5633. Connect the other port as follows, depending on the
number of DUTs:
▪  If you are making two one-port measurements at the same time: Connect

to the other DUT

▪  Otherwise: Connect to a 50 Ω terminator

◦  2-port calibration and measurement: Connect both ports of the PXIe-5633 to

both ports of the DUT.

The prompt should allow the operator to signal that the task is complete and then
proceed.

9.  Set Correction Enabled to True to apply the calset to the measurements the

program will enable.

Initiate VNA Measurement

Initiate the instrument to apply any configured settings and begin VNA measurement.

Call RFmx VNA Initiate.
Initiate does the following:

•  Applies all configured settings, if the settings have not already been applied
•  Starts VNA measurement, including any corrections you have configured

92 ni.com

Using the PXIe-5860 with S-Parameters as a VNA

Fetch VNA Measurement Data

Iteratively fetch the VNA measurement data to return data for each S-parameter or
wave you have configured in your program.

1.  Call an RFmx VNA fetch function for the S-parameters or waves that you

configured.
◦  S-parameters: SParams Fetch Y Data
◦  Waves: Waves Fetch Y Data

Tip You can use Build S-Parameter String or Build Wave String to furnish
the Selector String to the fetch function you use.

2.  Optional: To graph the measurements visually, return the frequency values for the

data as the x-axis of the graph.
◦  S-parameters: SParams Fetch X Data
◦  Waves: Waves Fetch X Data

Close the Session

Every RFmx session must be closed in order to deallocate memory, destroy threads,
and free operating system resources.

Required: Use RFmxInstr Close to conclude the session and free system resources.

Performing Interactive VNA Measurements in
Performing Interactive VNA Measurements in
InstrumentStudio
InstrumentStudio

You can use InstrumentStudio to access the VNA functionality of the PXIe-5860 with S-
parameters through an interactive soft front panel.

This process assumes you have already performed initial hardware configuration in
Hardware Configuration Utility or MAX.

Refer to InstrumentStudio documentation for information on the layout of
InstrumentStudio.

© National Instruments 93

Using the PXIe-5860 with S-Parameters as a VNA

Notice Follow all guidelines when making connections to the PXIe-5860
with S-parameters.

Complete the following steps to make interactive VNA measurements with the
PXIe-5860 with S-parameters in InstrumentStudio:

1.  Open a network analyzer panel in InstrumentStudio.

◦  From InstrumentStudio: Click

 » Network Analyzer, or create a layout

automatically based on the equipment in your system.

◦  From Hardware Configuration Utility: Select the PXIe-5633 module and, within
the instrument configuration panel on the right side, click Measurement
panel.

2.  Configure reference clock settings with

 » Instrument.

PXI_Clk is the valid source for PXIe-5860 with S-parameters VNA functionality.
3.  Optional: If you want to use de-embedding to remove the effect of fixtures from

your measurements, do the following:
a.  In the instrument configuration panel, click
b.  Choose the relevant settings.

 » Instrument

Note To apply de-embedding, you must have .s2p files available for
each port you want to de-embed.

4.  Define the frequency sweep settings.

Sweep Type

Linear

Description

Sweep a linear set of frequencies.

Define:

◦  A low start frequency
◦  A high stop frequency for the sweep
◦  The total number of frequency points to

include in the sweep

List

Sweep only specific frequency points.

Define the individual frequencies to include.

94 ni.com

Sweep Type

Segment

Using the PXIe-5860 with S-Parameters as a VNA

Description

Divide the sweep into discrete frequency
segments and apply independent settings to
each segment.

For each segment of the sweep, define:

◦  A low start frequency
◦  A high stop frequency
◦  The total number of frequency points for

the segment

◦  Additional settings, such as IF bandwidth,

dwell time, and more

5.  Optional: Configure advanced sweep settings with

 » Sweep.

◦  Configure IF bandwidth.

Note Only discrete bandwidth values are supported. If you choose
an unsupported value, the bandwidth is coerced up to the next
supported value.

◦  Configure power and attenuation settings.
◦  Configure delay and dwell.
◦  Choose whether to turn the VNA source off during measurements.

6.  Optional: Enable per-point measurement averaging and choose the number of

measurements to average with

 » Averaging.

7.  Apply or perform measurement calibration.
◦  Apply an existing correction from a file:
a.  Select the active calset (.ncst).
b.  Toggle correction ON.

◦  Perform manual calibration with your own measurement calibration

standards: select Calibration » Manual Calibration follow the onscreen
prompts, and toggle correction ON.

◦  Perform electronic calibration with the CAL-5501:
a.  Select Calibration » Electronic Calibration.
b.  Select options for the measurement calibration:

▪  1-port calibration: For Ports, select port1 or port2 and select an

appropriate Method

© National Instruments 95

Using the PXIe-5860 with S-Parameters as a VNA

▪  2-port calibration: For Ports, select port1, port2 and select an

appropriate Method

c.  Enter the identifier of the CAL-5501 device you are using for the calibration

in vCal Resource Name.

Note In InstrumentStudio, vCal refers to the CAL-5501 electronic
calibrator.

d.  If needed, modify the vCal Orientation.

vCal Orientation defines which port of the PXIe-5633 is connected to which
port of the CAL-5501.

e.  If it is not connected already, make the USB connection between the

CAL-5501 and the controller for your system.

f.  Connect the CAL-5501 to the PXIe-5633 module in the way that

corresponds to the vCal Orientation you specified:

96 ni.com

Figure 13. CAL-5501 Connection to PXIe-5860 with S-parameters

Using the PXIe-5860 with S-Parameters as a VNA

PXIe-5633
VNA

PORT 1

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

ACC

ACTIVE

LO IN

LO OUT

REF IN

REF OUT

PFI 0

PFI 1

PORT 2

ESD
SENSITIVE

Port A

A
C
C
E
S
S

A
C
T
V
E

I

Port B

Connection shown:

▪  CAL-5501 PORT A to PXIe-5633 PORT 1
▪  CAL-5501 PORT B to PXIe-5633 PORT 2

CAL-5501 USB connection not shown.

Note Measurement calibration calculates corrections at the
ports of the CAL-5501 module. For best results, connect the

© National Instruments 97

Using the PXIe-5860 with S-Parameters as a VNA

CAL-5501 in place of your DUT, leaving the rest of your physical
setup exactly as it is during DUT measurements.

g.  Click Continue.
h.  To save the calibration data for later use, select Save Calset to File.
i.  Toggle correction ON.

8.  Optional: If desired, adjust correction settings: click

 » Correction and adjust the

options.

You can do the following:

◦  Apply correction to only a subset of the ports for which the calset contains

correction data

Note If the calset originates from a two-port measurement
calibration but you are measuring on only one port, you must still
perform both sweeps to apply the corrections for the single port.

◦  Enable port extension to extend the measurement reference plane

9.  Define the measurements to perform, S-parameters or incident and reflected
waves, with the ADD / REMOVE button in the Measurements section of the
instrument configuration panel.

10.  Configure measurement-specific settings in the instrument configuration panel or

with

 » S-parameters or

 » Waves.

Note If the frequency points used for measurement deviate from the
calibrated frequency points, corrected measurements use interpolated
error terms. However, interpolated error correction may affect
measurement accuracy. Use interpolation judiciously.
◦  To disable interpolated error correction, uncheck

 » Correction »

Interpolation Enabled.

◦  See the status bar below the graph for the Correction State (None,
Corrected, or Interpolated) to determine whether the
corrected measurements use interpolated error terms.

11.  Connect your DUT, if it is not connected already.

◦  1-port, 1-device measurement: Connect the port of your device to a port of the

98 ni.com

Using the PXIe-5860 with S-Parameters as a VNA

PXIe-5633 module, and terminate the other PXIe-5633 port with a 50 Ω
terminator

◦  2-port measurement: Connect each port of your device to a port of the

PXIe-5633 module

12.  Run the measurement by clicking RUN to measure continuously or SINGLE to

capture a single measurement.
The measurement you have configured displays in the measurement graph.

© National Instruments 99

Configuring External Reference Clock Timing

Configuring External Reference Clock Timing
Configuring External Reference Clock Timing

You can provide an external reference clock to a PXIe-5860 instrument via the
PXIe-5860 REF IN connector.

Complete the following steps to configure the PXIe-5860 to lock to an external clock
reference source.

1.  Connect the external signal to PXIe-5860 REF IN connector.
2.  Using NI-RFSA or NI-RFSG, set the Reference Clock Source property or attribute to

RefIn.

3.  Using NI-RFSA or NI-RFSG, set the Ref Clock Rate property or attribute to a

supported value for the external reference clock frequency.

100 ni.com

Configuring PXI Backplane Clock Timing

Configuring PXI Backplane Clock Timing
Configuring PXI Backplane Clock Timing

The PXI backplane can supply a 100 MHz reference clock signal.

To configure the PXIe-5860 to use the PXI backplane clock, set the NI-RFSA or NI-RFSG
Reference Clock Source property or attribute to PXI Clock.

© National Instruments 101

Frequency and Bandwidth Configuration with NI RF Drivers

Frequency and Bandwidth Configuration
Frequency and Bandwidth Configuration
with NI RF Drivers
with NI RF Drivers

You can use the NI-RFSA and NI-RFSG drivers to configure PXIe-5860 instruments for
optimal performance by specifying frequency and bandwidth constraints.

The following table shows equivalencies between the NI-RFSA and NI-RFSG properties
that control various elements of instrument frequency and bandwidth.

Table 11. NI-RFSA and NI-RFSG Frequency and Bandwidth Configuration Properties

NI-RFSA Property

IQ Carrier Frequency

NI-RFSG Property

Frequency

Device Instantaneous Bandwidth

Device Instantaneous Bandwidth

Signal Bandwidth

IQ Rate

Signal Bandwidth

IQ Rate

Frequency and Bandwidth Configuration Terminology
Frequency and Bandwidth Configuration Terminology

Refer to the following list of terms when configuring frequency and bandwidth.

•  I/Q Rate—The effective sampling rate of the baseband signal chain. Setting a value

lower than the maximum will limit the available passband.

•  I/Q Carrier Frequency—The center frequency of the waveform data acquired or

generated.

•  Device Instantaneous Bandwidth— The total calibrated bandwidth available

through the instrument signal path.

•  Passband— The bandwidth able to be acquired based on the I/Q rate, centered at

the I/Q carrier frequency. This is usually defined at 80% of the I/Q rate. For
example, an I/Q rate of 100 MS/s results in a passband of 80 MHz. Note that the
passband edge may fall outside of the device instantaneous bandwidth edge and
will, therefore, have aliased or uncalibrated data.

•  Signal Bandwidth—When performing a signal acquisition, signal bandwidth is the

bandwidth of the signal present at the input port, centered at the I/Q carrier

102 ni.com

Frequency and Bandwidth Configuration with NI RF Drivers

frequency. When performing a signal generation, signal bandwidth is the
bandwidth of the waveform to be generated, centered at the I/Q carrier frequency.

Frequency and Bandwidth Selection to Optimize
Frequency and Bandwidth Selection to Optimize
Performance
Performance

You can configure frequency and bandwidth settings of an NI VST to optimize
measurement performance for different types of applications.

Note This information illustrates frequency and bandwidth concepts by
portraying a generic example instrument of 1 GHz bandwidth. Values and
figures might not reflect the frequencies or bandwidth of your instrument.

Basic Behavior

For a simple acquisition, you can set the I/Q carrier frequency and the I/Q rate. When
you do not specify a bandwidth constraint, NI-RFSA selects the widest filter for the
given frequency region. You can obtain the bandwidth of the instrument for this
configuration by querying the Device Instantaneous Bandwidth property.

You can specify the I/Q rate, which configures the decimation filter and, as a result,
configures the available passband. When oversampling, the passband is often greater
than the actual signal bandwidth present at the port. Specifying the Signal Bandwidth
property gives the driver additional information about the requested bandwidth.

The following example illustrates the default behavior.

© National Instruments 103

Frequency and Bandwidth Configuration with NI RF Drivers

Device Instantaneous Bandwidth

Signal BW = 160 MHz

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

I/Q Carrier Frequency

Specifying Device Instantaneous Bandwidth

In some cases, the default behavior may not be optimal. You can improve the default
behavior by providing NI-RFSA with more information about the system. By setting the
Device Instantaneous Bandwidth property, you are specifying how much instrument
bandwidth is required. The instrument bandwidth is used in filter selection and is only
coerced up. As a result, the filters chosen will always yield a bandwidth as wide as or
wider than requested. You can always read back the coerced or actual device
instantaneous bandwidth to find out how much bandwidth is available in the given
configuration.

For example, if you need 160 MHz of bandwidth from an instrument and the next
largest filter is 1 GHz, NI-RFSA chooses the 1 GHz filter.

Oversampling

In this example, the I/Q rate is set to 320 MSa/s, but the waveform signal bandwidth is
only 160 MSa/s. This practice is referred to as oversampling. The passband is 80% of
the I/Q rate, or 256 MHz. Because the passband extends beyond the device
instantaneous bandwidth, frequency content beyond the device instantaneous
bandwidth appears in the time-domain data. This frequency content is usually filtered
out by demodulation algorithms but may be problematic if you are manually analyzing
the time-domain data and there is a strong interfering signal in that region.

104 ni.com

Frequency and Bandwidth Configuration with NI RF Drivers

Device Instantaneous Bandwidth

Passband

Signal
Bandwidth

Signal BW = 160 MHz
Passband = 256 MHz
I/Q Rate = 320 MS/s

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

I/Q Carrier Frequency

© National Instruments 105

Maintaining the PXIe-5860

PXIe-5860
Maintaining the PXIe-5860
Maintaining the

Understand how to maintain PXIe-5860 performance.

Self-Calibration
Self-Calibration

Temperature drift and other environmental changes can lead to performance
degradation for several VST specifications. Self-calibration adjusts the instrument for
variations in the environment using an onboard high-precision calibration tone.

Perform self-calibration to compensate and optimize the performance of the PXIe-5860
for a given ambient temperature and operating environment.

Note Self-calibration always adjusts both channels. Self-calibration for a
single channel is not supported, even when called from a channel-specific
session.

Note The onboard temperature may fluctuate despite consistent ambient
operating temperature. For optimum performance, NI recommends that you
periodically verify onboard temperature, especially after changes to the
device configuration, and perform self-calibration as necessary. Refer to the
specifications or safety, environmental, and regulatory information
document for your instrument for more information about operating
temperature specifications.

Note NI recommends that no external signals are transmitted to the RF input
port during the self-calibration.

Parameters Adjusted by Self-Calibration
PXIe-5860  Parameters Adjusted by Self-Calibration
PXIe-5860

Depending on your PXIe-5860 instrument, self-calibration adjusts specific parameters
to facilitate temperature correction.

106 ni.com

Instrument

Self-Calibration Adjustment Parameters

Maintaining the PXIe-5860

•  ADC interleaving spurs
•  RF input gain
•  RF output gain
•  RF input flatness
•  RF output flatness

When to Perform Self-Calibration
When to Perform Self-Calibration

Self-calibration uses internal elements to adjust the PXIe-5860 for variations in the
module environment.

PXIe-5860 modules are externally calibrated at the factory; however you should
perform a self-calibration in any of the following situations:

•  After first installing and connecting your PXIe-5860 instrument
•  After any module in the chassis is installed, uninstalled, or moved
•  After cabling has been changed, reconnected, or repositioned
•  After changing controllers, computers, or reinstalling the driver software
•  When the system is in an environment where the ambient temperature varies or
the module temperature has drifted more than ±5 °C from the temperature at the
last self-calibration

•  To periodically adjust for small performance drifts that occur with product aging

PXIe-5860
Self-Calibrating the PXIe-5860
Self-Calibrating the

You can self-calibrate your VST either interactively or programmatically; each method
yields the same self-calibration results.

•  Interactive methods—Self-calibration in the InstrumentStudio application or

Hardware Configuration Utility.

•  Programmatic methods—Self-calibration in a supporting programming

environment using an API directly.

•  NI-RFSA

◦  Using the RFSA Self-Calibration programming example

© National Instruments 107

Maintaining the PXIe-5860

◦  Using self-calibration functions

•  NI-RFSG: using self-calibration functions
•  RFmx: using self-calibration functions

Choose and complete one of the self-calibration methods.

Self-Calibrating the PXIe-5860
Self-Calibrating the

with InstrumentStudio
PXIe-5860  with InstrumentStudio

NI recommends you perform an initial self-calibration using InstrumentStudio.

Note Ensure that any connected external hardware is in an idle state and not
transmitting during self-calibration. It is not recommended to perform self-
calibration while connected in direct loopback configurations.

NI VSTs are represented in InstrumentStudio as a vector signal analyzer and a vector
signal generator. Performing self-calibration with either representation of the
PXIe-5860 accomplishes the same self-calibration, so it is not necessary to use both
when you self-calibrate the PXIe-5860.

Complete the following steps to self-calibrate your VST with InstrumentStudio:

1.  To ensure specifications before you use the instrument or perform self-calibration,

allow the instrument to warm up.
a.  If it is not powered already, power on the PXI Express chassis.
b.  Wait for the operating system to completely load.
c.  Allow the instrument to warm up for 30 minutes.

2.  Launch InstrumentStudio by navigating to Start » National Instruments »

InstrumentStudio.

3.  Click File » New » RF Signal Analyzer to create an analyzer panel for the PXIe-5860.
4.  On the RF signal analyzer panel, verify that a channel is selected in the Channel

list.

Note Self-calibration always adjusts both channels. Self-calibration for a
single channel is not supported, even when called from a channel-
specific session.

5.  Click the tab created for the PXIe-5860 and click the gear icon (

) in the upper right

corner of the right sidebar.

108 ni.com

Maintaining the PXIe-5860

6.  Hover over Device Slot » Calibration and click Self-Calibrate....
7.  Click Continue to proceed.

The PXIe-5860 stores the new calibration data in its nonvolatile memory if the self-
calibration is performed successfully.

Self-Calibrating the PXIe-5860
Self-Calibrating the

PXIe-5860  with the

with the NI-RFSA

LabVIEW Example
NI-RFSA  LabVIEW Example

Note Ensure that any connected external hardware is in an idle state and not
transmitting during self-calibration. It is not recommended to perform self-
calibration while connected in direct loopback configurations.

Complete the following steps to self-calibrate the PXIe-5860 with the NI-RFSA
programming example:

1.  To ensure specifications before you use the instrument or perform self-calibration,

allow the instrument to warm up.
a.  If it is not powered already, power on the PXI Express chassis.
b.  Wait for the operating system to completely load.
c.  Allow the instrument to warm up for 30 minutes.

2.  Select Start » All Programs » National Instruments » LabVIEW to launch LabVIEW.
3.  Launch the Example Finder at Help » Find Examples... and navigate to the

example.
a.  Select Hardware Input and Output » Modular Instruments » NI-RFSA »

Utilities » RFSA Self Calibration.

b.  Open the example.

4.  Complete the following steps to configure the example:

a.  Select the device identifier assigned to the PXIe-5860 in MAX in the [Resource

Name] drop-down menu.

b.  Set Clock Source to OnboardClock.
c.  Set Self Calibration Step Operations to Perform All Self Calibration Steps.

5.  Run the VI.

The PXIe-5860 stores the new calibration data in its nonvolatile memory if the self-
calibration is performed successfully.

© National Instruments 109

Maintaining the PXIe-5860

Cleaning Threaded RF Connectors
Cleaning Threaded RF Connectors

Keep connector interfaces, especially the outer conductors of threaded RF connectors,
clean and free of dirt and any other debris. Follow the guidelines to properly maintain
the connectors, and therefore the performance, of your instruments and cables over
time.

Contaminants such as metal fibers are sources of uncertainty in measurements. Such
contaminants can be abrasive and cause damage to the surfaces of mating connectors.
Damage to these surfaces inhibits the repeatability of your measurements.

Contaminated connectors pose problems especially for high-frequency, high-precision
measurements because they prevent a good impedance match. Therefore, it is
important to keep the threaded RF connectors in your test system clean.

You need the following materials for proper connector cleaning:

•  Protective eyewear
•  Pure, filtered compressed air or nitrogen
•  Magnifying glass
•  (Non–air dielectric connectors only) Lint-free swabs, such as foam swabs, of

appropriate size for the connectors

•  (Non–air dielectric connectors only) Pure (99.5%) isopropyl alcohol

Note If you use isopropyl alcohol to clean the appropriate connector
types, do so in a well ventilated area.

•  (Non–air dielectric connectors only) Toothpick

Notice Do not use swabs or isopropyl alcohol on connectors that have an air
dielectric. Connectors that have an air dielectric include 3.5 mm, 2.92 mm,
and 1.85 mm connectors. Refer to front panel and pinout documentation to
confirm the connector types for your instrument.

Complete as many of the following steps as are necessary to sufficiently clean
threaded RF connectors. Complete only the steps that are appropriate for the type of

110 ni.com

Maintaining the PXIe-5860

connector you are cleaning.

1.  Put on protective eyewear.
2.  Blow out any loose debris from the connector with compressed air or nitrogen by

blowing across the connector face.

Tip Do not blow directly into the connector; this can lodge any debris
more firmly. Blowing across the connector is the safest method for
cleaning connectors that use air dielectric.

3.  (Non–air dielectric connectors only) Examine the connector with a magnifying

glass to check for debris: if you still notice debris, try removing it with a lint-free,
foam-tipped swab.

Notice Follow these guidelines when cleaning connectors with a foam
swab:

◦  Always clean the connector in a circular motion around the center
pin, not across the pin. Never put lateral pressure on the center pin
of a connector.

◦  Apply as little pressure as necessary when moving the foam swab
around the center conductor. Applying too much pressure can
embed debris deeper into the connector.

Notice NI does not recommend using cotton swabs to clean threaded RF
connectors. Cotton fibers can become lodged in the connector and cause
damage or measurement errors.

4.  (Non–air dielectric connectors only) Examine the connector with a magnifying

glass: if you still notice debris, barely dampen another foam swab with isopropyl
alcohol and clean the connector again.

Notice Do not saturate the foam swab with isopropyl alcohol. Do not
apply isopropyl alcohol directly to a connector.

5.  Verify that no foam or other foreign material remains in the connector.
6.  (Non–air dielectric connectors only) If the connector is still contaminated, use a

very small toothpick with a small amount of isopropyl alcohol applied.

© National Instruments 111

Maintaining the PXIe-5860

Notice Use extreme care to avoid damaging the connector with the
toothpick. Use the magnifying glass when using the toothpick.

7.  If you used isopropyl alcohol to clean the connector, use the compressed air or

nitrogen on the connector.
Compressed air or nitrogen can help remove any foreign particles and dry the
connector.

After cleaning:

•  Verify that the center pin is not bent or damaged
•  Verify that the collets of the mating connector are neither bent nor damaged
•  Keep connectors that are not in use covered with the dust cap for included with

your instrument for the connector

If you have completed this procedure but are not successful in cleaning the connector,
remove the item from service and label it accordingly.

Maintenance
Maintenance

Clean your product with a soft, nonmetallic brush. Make sure that your product is
completely dry and free from contaminants before returning it to service.

112 ni.com

Troubleshooting

Troubleshooting
Troubleshooting

If an issue persists after you complete a troubleshooting procedure, search our
KnowledgeBase for additional information our technical support engineers create as
they answer common user questions and resolve unexpected issues.

Related information:

•  ni.com/support

What Should I Do if My Hardware Doesn't Appear in
What Should I Do if My Hardware Doesn't Appear in
Hardware Configuration Utility or MAX?
Hardware Configuration Utility or MAX?

1.  Check that the ACCESS/ACC LED on the hardware is solid green.
2.  Check if the connection between the hardware and software needs to be

refreshed.

Software

Description

Hardware Configuration Utility

Click the refresh button (

).

MAX

a.  In the MAX configuration tree, expand

Devices and Interfaces.

b.  Expand the Chassis tree to see the list of

installed hardware and press F5 to refresh
the list.

3.  If the instrument is still not listed, power off the system, ensure that all hardware is

correctly installed, and restart the system.

4.  Navigate to the Device Manager by right-clicking the Start button and selecting

Device Manager.

5.  Depending on your controller type, verify Device Manager settings.

Controller Type

PXI controller

Description

a.  Verify that a National Instruments entry

appears in the system device list

b.  If error conditions appear in the list, right-

© National Instruments 113

Controller Type

Description

Troubleshooting

click the module you are using in the
Device Manager and select Update
Driver.

Right-click PCI-to-PCI Bridge and select
Properties from the shortcut menu to verify
that the bridge is enabled.

MXI controller

6.  Restart your computer.

Why Is the ACCESS LED Off When the Chassis Is On?
Why Is the ACCESS LED Off When the Chassis Is On?

The LEDs may not light until the module has been configured in Hardware
Configuration Utility or MAX. Before proceeding, verify that the module appears in
Hardware Configuration Utility or MAX.

If the module appears in Hardware Configuration Utility or MAX but the ACCESS LED
fails to light after you power on the chassis, a problem may exist with the chassis
power rails, the hardware module, or the LED.

Notice Apply external signals only while the hardware is powered on.
Applying external signals while the hardware is powered off may cause
damage.

1.  Disconnect any signals from the PXI Express module front panel.
2.  Power off the PXI Express chassis.
3.  Remove the module from the PXI Express chassis and inspect it for damage.

Notice Do not reinstall a damaged device.

4.  Install the module in a different PXI Express chassis slot from which you removed

it.

5.  Power on the PXI Express chassis.
6.  Restart your computer.
7.  Verify that the module appears in Hardware Configuration Utility or MAX.

114 ni.com

Troubleshooting

What Should I Do if the PXIe-5860
What Should I Do if the

Fails the Self-Test?
PXIe-5860  Fails the Self-Test?

1.  Restart the system.
2.  Launch your NI configuration software and perform an intermediate self-test.

Option

Description

Hardware Configuration Utility

MAX

a.  Select the PXIe-5860 module of your
instrument in the system pane.

b.  Expand the Troubleshooting area of the
configuration pane and click Self-test.
c.  Select Intermediate and then click Ok to

run the test.

a.  Select the item in the configuration tree
and click Self-Test in the MAX toolbar.
b.  Select the Intermediate radio button and

then click Start.

The software indicates when the self-test concludes successfully.

If the self-test fails, review the self-test items for your instrument to identify the
specific item(s) causing the failure, and inspect any cables and connections for the
item(s) as indicated in the table for your instrument.

Table 12. Self-Test Connections

Self-Test Item (per Channel)

Recommended Resolution

[5860] Device Reset Required
CH0, [5860] Device Reset
Required CH1

[5860] TX RF Detector CH0,
[5860] TX RF Detector CH1

Reset the device and perform self-test again.

[5860] RX RF Detector CH0,
[5860] RX RF Detector CH1

Reset the device and perform self-test again.
Contact NI Support if the problem persists.

[5860] ADC Loopback CH0, [5860]
ADC Loopback CH1

Address any issues you identify and perform an intermediate self-test again. If the

© National Instruments 115

Troubleshooting

self-test still fails, continue this procedure.

3.  Power off the chassis.
4.  Reinstall the failed instrument in a different set of slots.
5.  Power on the chassis.
6.  Perform an intermediate self-test again.

If the instrument still fails the self-test, contact NI for support.

What Should I Do if the Instrument Does Not Initialize?
What Should I Do if the Instrument Does Not Initialize?

Failure to initialize may indicate a problem with module interconnections or with
Hardware Configuration Utility or MAX.

If the Initialize function for your instrument driver returns an error and the PXIe-5860
fails to initialize, complete the following steps:

1.  Power off the system.
2.  Inspect all PXIe-5860 front panel cables and, if there are no apparent issues,

reconnect cables securely, according to the interconnection procedure for your
instrument.

3.  Power on your system and run the Hardware Configuration Utility or MAX

configuration and intermediate self-test procedures.

Related tasks:

•  Performing Initial Hardware Configuration

116 ni.com

Fundamental RF Concepts

Fundamental RF Concepts
Fundamental RF Concepts

Understanding RF concepts and the concepts that underpin NI's RF hardware will help
you be successful with your instrument.

Common Terms
Common Terms

Refer to the following list for definitions of common terms related to RF hardware and
software-configured settings for the PXIe-5860 and used throughout documentation.

Table 13. Common Terminology Definitions

Term

Definition

Center Frequency

Refers to the IQ Carrier Frequency property in NI-RFSA, the
Frequency property in NI-RFSG, and the Center Frequency
property in RFmx.

Onboard

dBr

With respect to reference clocks, refers to the value of the
NI-RFSG Reference Clock Source or NI-RFSA Ref Clock Source
properties. A value of Onboard Clock configures the hardware
to use the internal reference clock within the instrument.

•  For input—Power of an acquired signal with respect to

the instrument's configured reference level. For example,
if the reference level is set to -10 dBm and the acquired
tone is -17 dBm, the signal is said to be at -7 dBr.

•  For output—Generated power of a CW with respect to the
instrument's peak power setting. For example, with a
peak power level setting of +5 dBm and a -3 dBr setting,
the power of the generated CW is +2 dBm.

Carrier Wave
Carrier Wave

The carrier wave is a sinusoidal wave that is modulated by a message signal, m(t),
prior to transmission.

© National Instruments 117

Fundamental RF Concepts

The message signal modifies the carrier wave amplitude, frequency, or phase. The
modulation process may vary these characteristics individually or in combination. The
modified carrier signal, also referred to as the modulated wave, is transmitted to a
receiver.

The process of demodulation recovers a replica of the original message signal from the
carrier wave. In advanced communication systems, the carrier may be a moving signal,
also known as a spread spectrum signal. When the characteristics of the carrier signal
are deterministic and known by the receiver, virtually any type of carrier signal can be
used.

The nominal frequency of the carrier wave is the carrier frequency. The carrier
frequency is the center frequency of the spread spectrum signal.

Message Signal
Message Signal

The message signal contains the data for transmission.

The message signal is used to modulate the carrier wave to create the modulated wave
for transmission. The message signal data is recovered from the modulated wave by a
process of demodulation.

The message signal is often referred to as the baseband signal.

Modulation
Modulation

Modulation is a process that alters the characteristics of a carrier wave according to
information in the message signal to generate and transmit a modulated wave. There
are several different types of modulation.

The unmodulated carrier is represented by the following equation:

v(t) = Accos(2πft+ φ)

The amplitude-modulated carrier signal is represented by the following equation:

118 ni.com

v(t) = (m(t) + Ac)cos(2πft+ φ)

The frequency-modulated carrier signal is represented by the following equation:

Fundamental RF Concepts

v(t) = Ac((m(t) + 2πf)t+ φ)

This yields the following equation:

Accos(2πft+ φ + ∫m(t)ⅆt)

The phase-modulated carrier signal is represented by the following equation:

v(t) = Accos(2πft+ φ + m(t))

where

•  m(t) is the time-varying modulation
•  Ac is the amplitude of the carrier wave
•  f is the frequency of the carrier wave

I/Q Modulation
I/Q Modulation

I/Q is a common way to represent message signals in modern communication systems.

There are two fundamental ways (degrees of freedom) to produce a modulated wave
from a carrier wave: you can perturb either its amplitude or its phase. I/Q signaling
allows you to simultaneously change both amplitude and phase. Using both degrees
of freedom when modulating a carrier allows greater spectral efficiency with regard to
bits per hertz of channel bandwidth (for a given bits per second transmission rate)
compared to using only one degree of freedom.

To simultaneously perturb both the amplitude and phase of a carrier, two canonical
forms of frequency-translating transmitters use the two degrees of freedom in
modulation simultaneously. These canonical forms are referred to as canonical polar

© National Instruments 119

Fundamental RF Concepts

modulation and canonical rectangular modulation.

Canonical Polar Modulation

Figure 14. Canonical Polar Modulation

m(t)

Baseband
Processing

R(t)

j(t)

Phase
Modulator

cos(wc(t))

p(t)=R(t)cos(wc(t)+j(t))

cos(wc(t)+j(t))

In polar modulation, the message signal is split into two components.

•  R(t) controls the carrier wave amplitude changes
•  φ(t) drives the carrier wave phase changes

Canonical Rectangular Modulation

Figure 15. Canonical Rectangular Modulation

cos(wc(t))

sin(wc(t))

+

–

S

I(t)=R(t)cos(j(t))

Q(t)=R(t)sin(j(t))

m(t)

Baseband
Processing

p(t)=I(t)cos(wc(t))–Q(t)sin(wc(t))
 =R(t)cos(wc(t))+j(t))

In rectangular modulation, the message signal is split into two components.

•  I(t) controls the in-phase carrier wave changes
•  Q(t) controls the quadrature-phase carrier wave changes

Mathematical Relationship between Canonical Modulation Forms

The modulated outputs of the two canonical forms are mathematically and physically
equivalent. To show their equality, you can compare and translate between the polar
and rectangular representations.

Begin with the following equation:

120 ni.com

Fundamental RF Concepts

R(t)cos(ωc(t) + φ(t))

Plug in the following trigonometric identity:

cos(α + β) = cos α cos β - sin α sin β

to yield the following equation:

R(t)[cosωc(t)cosφ(t) - sinωc(t)sinφ(t)]

Simplify the preceding equation to arrive at the following relationship:

I(t)cos(ωc(t)) - Q(t)sin(ωc(t))

where

•  I(t) = R(t)cos(φ(t))
•  Q(t) = R(t)sin(φ(t))
•  ω c = 2 πfc
•  f c is the carrier frequency in Hz

The rectangular form of modulation, often called I/Q modulation, has become popular
for certain technical reasons.

In the rectangular modulation figure, the real baseband signals of I(t) and Q(t) are
created (in some way) to contain all the information of message input m(t).3 Because
the carriers cos(ωc(t)) and sin(ωc(t)) are orthogonal functions, we use the terminology
of quadrature modulation, where the signal applied to the cosine mixer is called the
In-phase component (I), and the signal applied to the sine mixer is call the Quadrature-
phase component (Q). The I and Q designations are useful because the I(t) baseband
signal is applied to the cosine mixer, and the Q(t) baseband signal is applied to the sine
mixer.

The analytical relationship between the polar form (R(t) and φ(t)) of the baseband
signal and Cartesian form (I(t) and Q(t)) of the baseband signal is shown in the
following figure.

3. The polar R(t) and φ(t) also contain the information of m(t).

© National Instruments 121

Fundamental RF Concepts

Figure 16. Relationship Between R(t) and φ(t)

jQ

Q

R

f

I

I

The diagram is a "snapshot in time" of the complex (analytical) baseband envelope
g(t). Because the diagram is for an arbitrary instant in time, the independent time
variable t is dropped. The amplitude of Q is projected onto the imaginary (j) axis and
the amplitude of I is projected onto the real axis.

I/Q Receiver

An I/Q receiver recovers a signal containing both amplitude and phase modulation.

For the incoming signal, p(t), the normalized outputs of the cosine and sine mixers are
respectively:

I(t) + I(t)cos(2ωct) + Q(t)sin(2ωct)

Q(t) + Q(t)sin(2ωct) + I(t)cos(2ωct)

After the mixers, the lowpass filters remove all the high-frequency 2ωct terms, leaving
the recovered I(t) and Q(t) signals.

The diagrams and discussion in this topic are ideal. They imply that the original
message signal m(t) is recovered along the transmitter-path-receiver chain. This
implication is useful when focusing purely upon the signaling method. In reality,
however, the receiver returns a version of m(t) corrupted by noise and distortion
impairments.

The vector signal analyzer measures the unit under test (UUT) noise and distortion

122 ni.com

Fundamental RF Concepts

impairments and determines if the performance of the UUT is sufficient for the desired
transmission scheme. Because the I/Q signal representation is relatively
straightforward (and also has practical and physical application in communication
systems), it is conceptually used to evaluate the noise and distortion performance of
these communication systems.

Sample Rate
Sample Rate

Sample rate is the rate at which digital data is transferred from the memory to the
digital-to-analog converter (DAC).

According to Shannon’s Sampling theorem, a digital waveform must be updated at
least twice as fast as the bandwidth of the signal to be accurately generated. Ideally, a
sample rate many times greater than the frequency of the signal produces accurate
waveforms. A higher sample rate also captures more waveform details. The following
figure illustrates a 1 MHz sine wave generated by a sampled 2 MS/s DAC and a 20 MS/s
DAC. The faster DAC generates 20 points per cycle of the expected signal compared
with 2 points per cycle with the slower DAC. In this example, the higher sample rate
more accurately defines the waveform shape.

1 µ

Legend

Sample Rate 2 MS/s

Sample Rate 20 MS/s

Nyquist and Shannon's Sampling Theorems

The Nyquist theorem concerns digital sampling of a continuous time analog
waveform, while Shannon’s Sampling theorem concerns the creation of a continuous
time analog waveform from digital, discrete samples.

© National Instruments 123

Fundamental RF Concepts

•  Nyquist Theorem—The Nyquist theorem states that an analog signal must be
sampled at least twice as fast as the bandwidth of the signal to accurately
reconstruct the waveform; otherwise, the high-frequency content creates an alias
at a frequency inside the spectrum of interest (passband). An alias is a false lower
frequency component that appears in sampled data acquired at too low a
sampling rate. The following figure shows a 5 MHz sine wave digitized by a 6 MS/s
analog-to-digital converter (ADC). In this figure, the solid line represents the sine
wave being digitized, while the dotted line represents the aliased signal recorded
by the ADC at that sample rate.

The 5 MHz frequency aliases back in the passband, falsely appearing as a 1 MHz
sine wave.

•  Shannon’s Sampling Theorem—Shannon’s Sampling theorem states that a digital
waveform must be updated at least twice as fast as the bandwidth of the signal to
be accurately generated. The same image that was used for the Nyquist example
can be used to demonstrate Shannon’s Sampling theorem. The following figure
shows a desired 5 MHz sine wave generated by a 6 MS/s DAC. The solid line
represents the desired waveform, and the arrows represent the digitized samples
that are available to recreate the continuous time 5 MHz sine wave. The dotted line
indicates the signal that would be seen, for example, with an oscilloscope at the
output of a DAC.

In this case, the high–frequency sine wave is the desired signal, but was severely

124 ni.com

ttFundamental RF Concepts

undersampled by only being generated by a 6 MS/s DAC; the actual resulting
waveform is a 1 MHz signal.

In systems where you want to generate accurate signals using sampled data, the
sampling rate must be set high enough to prevent aliasing.

Impedance Matching
Impedance Matching

When broadband signals are transmitted on lines of any significant length, impedance
discontinuities or mismatches degrade the amplitude and phase accuracy, as well as
the temporal fidelity, of waveforms generated with a signal generator. To minimize
signal reflections, the source and load impedances should equal the characteristic
impedance of the transmission line.

One of the most common mismatch errors encountered in such measurements is
shown in the following figure:

Characteristic Impedance = 50 Ω
Delay = t

75 Ω

V

Source

To DAC

75 Ω

Coaxial
Cable

Input
(Load)

In this example, selectable source impedances are provided at the signal generator
outputs to accommodate the most popular coaxial cable characteristic impedances:
50 Ω and 75 Ω.

Consider an example where a 50 Ω coaxial cable connects 75 Ω source and load
impedances. The following figure shows the discontinuities that occur in this situation
and how they compare to a matched cable:

© National Instruments 125

Fundamental RF Concepts

V

AWG

Module

Voltage

With Matched Cable

0

0

t

3t

5t

7t

9t

Time

The pulse encounters impedance mismatches at each end of the cable, and the pulse
is partially reflected. The reflected pulse traverses the cable back and forth numerous
times, diminishing at each end by the reflection coefficient, Γ:

Γ =

vr
vi

=

zt − z0
zt+ z0

where

•  vr = reflected voltage
•  vi = incident voltage
•  zt = terminating impedance
•  z0 = characteristic impedance

The resulting voltage waveform is distorted by the asymptotic decay of the reflected
pulse as shown, exaggerated for visual effect. Impedance discontinuities of smaller
magnitude and/or duration have correspondingly smaller effects. Also displayed is the
waveform that results when a cable of matched impedance (75 Ω) is used.

Mismatch Uncertainty

Impedance matching is also important for preserving the absolute delivered power
from a device. The accuracy with which power can be delivered is limited by mismatch
error. The mismatch error in a z0 system can be shown to be bounded by:

2)
(1 − |ΓL|
(1 +|ΓL | ⋅ |ΓG|)

2 ≤ mismatch error ≤

2)
(1 − |ΓL|
(1 − |ΓL | ⋅ |ΓG|)

2

126 ni.com

Fundamental RF Concepts

where

•  ΓL = load reflection coefficient
•  ΓG = generator reflection coefficient

The denominator term represents mismatch uncertainty, which is a fundamental limit
to the power transfer accuracy that can be achieved across a mismatched junction.

Resistive Matching

You can use a resistor in series (shunt) to match the total source impedance
(admittance) that an RF signal generator sees to the characteristic impedance
(admittance) of a cable. This method works for RF signal generates with low or high
source impedance.

RF signal generators that are not capable of driving the cable impedance directly can
be coupled through a matching L-pad. In this case, the RF signal generator sees an
approximately 500 Ω load, while the source impedance presented to the cable is 50 Ω.

Refer to the following figure:

500 Ω

50 Ω

475 Ω

Characteristic Impedance = 50  Ω

To DAC

56.2  Ω

50 Ω

Source

L-Pad

Coaxial
Cable

Input

To minimize parasitic effects, use high-frequency components and layout techniques
throughout.

Resolution Bandwidth
Resolution Bandwidth

For NI VSAs and VSTs, the resolution bandwidth (RBW) determines the fast-Fourier
transform (FFT) bin size, or the smallest frequency that can be resolved.

© National Instruments 127

The following graphs represent the same signal with varying RBW.

Fundamental RF Concepts

0.000 –

–20.000 –

–40.000 –

–60.000 –

–80.000 –

)

m
B
d
(

r
e
w
o
P

0.000 –

–20.000 –

–40.000 –

–60.000 –

–80.000 –

)

m
B
d
(

r
e
w
o
P

0.000 –

–20.000 –

–40.000 –

–60.000 –

–80.000 –

)

m
B
d
(

r
e
w
o
P

–100.000 –

–
999.48M

–
1.00G

–
1.00G

–100.000 –

–
999.50M

–
1.00G

–
1.00G

–100.000 –

–
999.50M

–
1.00G

–
1.00G

Frequency (Hz)

Frequency (Hz)

Frequency (Hz)

RBW = 100 kHz

RBW = 10 kHz

RBW = 100 Hz

The smaller RBW, on the right, has much finer resolution which allows the sidebands
to be visible. Finer resolution requires a longer acquisition time. When acquisition time
is a factor and the display needs to be updated rapidly or when the modulation
bandwidth is wide, you can use a larger RBW. RBW and acquisition time are inversely
proportional.

The following table shows the advantages and disadvantages of both larger and
smaller RBWs:

Characteristic

Larger RBW

Smaller RBW

FFT size

Number of samples

Measurement speed

Ability to resolve tones

Smaller

Fewer

Faster

Larger

More

Slower

Often unable to resolve two
closely spaced tones in a
spectrum

Tones are easily resolved

In FFT-based (digital) spectrum analyzers and vector signal analyzers, RBW is inversely
proportional to the number of samples acquired. By taking more samples in the time
domain, or making the acquisition time longer while keeping the sampling rate the
same, the RBW is lowered. The result is more bins in the same span and improved
frequency resolution.

The FFT process is equivalent to passing a time-domain signal through a bank of

128 ni.com

Fundamental RF Concepts

bandpass filters with center frequencies corresponding to the frequencies of the FFT
bins. For wide sweeps, a wide RBW is required to shorten acquisition times. For narrow
sweeps, a narrow filter improves frequency resolution.

Carefully consider which FFT window type to use. As an example, a Flat Top window
minimizes amplitude measurement error and is recommended for amplitude
measurements even though it has non-optimal selectivity.

Noise Fundamentals
Noise Fundamentals

There are multiple types of noise to consider when analyzing RF signals.

Noise Figure

All devices have inherent noise. When a noise is quantified, it is usually referred to the
device input. In other words, all the noise power a unit under test (UUT) inherits is
assumed to come from its input. The noise figure of a UUT is the ratio, in dB, of its
noise power to the noise power that a matched resistive load would deliver at room
temperature.

If you terminate a UUT input with a matched resistive load (typically 50 Ω) and
measure the noise power density, in watts/Hz, at its output (N0), the noise figure (NF) is
given by the following equation:

NF = 10log(N0 / G

kT ) NF = 10log(N0 / G
kT )

where

•  G is the power gain (in linear units) of the UUT
•  k is Boltzmann's constant (≈ 1.38 ×10-23 J/K)
•  T is the ambient temperature (≈ 290° K)

If you use the vector signal analyzer to measure the output noise of a UUT, the
resulting measurement contains both UUT noise and noise intrinsic to the vector
signal analyzer. If the UUT gain (GUUT in dB) is known, compute the noise figure of the

© National Instruments 129

Fundamental RF Concepts

UUT with the following equation:

NF = 10log[Nm − Nrfsa

kT

+ 1] − GUUT NF = 10log[Nm − Nrfsa

kT

+ 1] − GUUT

where

•  N rfsa is the noise, in watts/Hz, measured by the vector signal analyzer when its

input is terminated with a matched resistive load

•  N m is the measured noise, in watts/Hz, with the UUT attached
•  G is the linear power gain
•  NF is expressed in dB

Noise Floor

Noise floor is the measure of the noise density, in dBm/Hz, or the noise power in a 1 Hz
bandwidth.

Noise can be classified into several types, including the following:

•  Shot noise
•  Thermal noise
•  Flicker noise
•  Burst noise
•  Quantization noise
•  Avalanche noise

The noise due to a matched resistive load (Ni) can be expressed as the following
relation:

(Ni) = kTB watts

where

•  k is Boltzmann's Constant (k = 1.38 x 10-23J/K
•  T is the resistor temperature in Kelvin
•  B is the bandwidth in Hz

130 ni.com

If B is set to 1 Hz, then Ni is equal to the output noise density in watts/Hz. For the
system shown in the following figure, the output noise floor (NO) is the combination of
the input noise multiplied by the gain or loss of the system plus the internal noise of
the system (Nn).

Fundamental RF Concepts

Ni = kTB

G = Gain
Nn = Internal Noise
F = Noise Factor

No = NiG + Nn

The internal noise of a system is therefore represented by the following equation:

N n = NiG – NO

Harmonic Distortion

Harmonic distortion is a measure of the amount of power contained in the harmonics
of a fundamental signal compared to the power of the fundamental signal.

Harmonic distortion is inherent to devices and systems that possess nonlinear
characteristics. The more nonlinear the device, the greater its harmonic distortion.

Harmonic distortion can be expressed as a power ratio or as a percentage. Use the
following formula to express it as a power ratio:

P HD = Pfund–Pharm(dBc)

where

•  P HD is the power of the harmonic distortion in dBc
•  P fund is the fundamental signal power in dB or dBm
•  P harm is the power of the harmonic of interest in dB or dBm

Convert power to voltage and use the following equation to express harmonic
distortion as a percentage ratio:

© National Instruments 131

Fundamental RF Concepts

Percentage of Distortion =

Vharm
Vfund

× 100 %  Percentage of Distortion =

Vharm
Vfund

× 100 %

Total Harmonic Distortion

Total harmonic distortion (THD) is a representation of the effect that multiple
harmonic spurs throughout a spectrum band have on the fundamental tone.

You can calculate THD by summing the power in each of the harmonics and dividing by
the total power of the fundamental. As a general principle, a signal becomes visibly
distorted when the THD approaches -30 dB.

The equation for THD is:

THD = √V

2
h2

2
+ V
h3

2
+ … + V
hN

2
+ V
h4
Vfund

× 100 %  THD = √V

2
h2

2
+ V
h3

2
+ … + V
hN

2
+ V
h4
Vfund

× 100 %

As this equation suggests, the THD specification evaluates the power in harmonic
spurs from the second through the nth harmonic. In practice, typical signal generators
feature THD specifications for harmonics two through six. The following figure shows
an example plot of a generated signal and illustrates the concept of THD specification
in signal generators.

Figure 17. Total Harmonic Distortion Example

20

0

–20

–40

–60

–80

–100

–120

→
e
d
u

t
i
l

p
m
A

132 ni.com

Frequency →

Fundamental RF Concepts

The previous figure shows an example plot of a 20 kHz sinusoid generated with an
arbitrary waveform generator. Notice the power levels of the harmonic spurs,
indicated with circles. This generator features -77 dBc or better of THD for the second
through sixth harmonics.

THD generally deteriorates as the generated signal increases in frequency. When
working with a signal generator, consider the THD throughout the bandwidth of the
generator.

Two-Tone Third-Order Intermodulation Distortion

Two-tone third-order intermodulation distortion (IMD3) is the measure of third-order
distortion products that a nonlinear device produces when it receives two tones that
are close in frequency.

This distortion product is usually so close to the carrier that it is almost impossible to
filter out. Such distortion can cause interference in multichannel communications
equipment.

If F1 and F2 are the frequencies of the two tones, the third-order distortion products
occur on both sides of these tones at 2F2 – F1 and 2F1 – F2 . Assuming equal power
levels of the two tones, IMD3 is the difference between the power of the fundamental
signals and the third-order products, as defined in the following equation:

IMD 3 = Po – Po3

where

•  Po3 is the power level of one of the output third-order products
•  Po is the power level of one of the fundamental tones

The math becomes more involved if the powers of the two tones are different.

After you calculate the IMD3 using the preceding formula, you can calculate the unit
under test (UUT) output third-order intercept point (OIP3) using the following
equation:

© National Instruments 133

Fundamental RF Concepts

OIP3 =

IMD3
2 + Po =

1

2(3Po − Po3)(dB)

The input third-order intercept point (IIP3) is defined as:

IIP 3 = (OIP3 – G)

Where G is the gain of the device. The IIP3 number quantifies the third-order linearity
input referred of a device.

The following figure shows the relationship between the second- and third-order
distortions and the linear output of a device.

Third-Order
Intercept Point

Second-Order
Intercept Point

B
d

t

t

u
p
u
O

Linear Output

Second-Order Distortion
Slope = 2

Third-Order Distortion
Slope = 3

Input dB

The two tones injected into the UUT must be free from any third-order products. These
two tones are combined, or summed, at or before the UUT input. If the two tones are
not well isolated, the tones intermodulate with each other and cause distortion. To
minimize distortion of the input tones, use a signal combiner with good input-to-input
isolation.

1 dB Gain Compression Point

The 1 dB gain compression point describes amplifier saturation.

134 ni.com

Fundamental RF Concepts

An amplifier maintains a constant gain for low-level input signals. However, at higher
input levels, the amplifier saturates and its gain decreases. The 1 dB gain compression
point (P1 dB) indicates the power level that causes the gain to drop by 1 dB from its
small signal value.

The 1 dB gain compression point is derived from the gain relationship between output
power and input power. Output power is plotted against input power in the following
figure.

Figure 18. 1 dB Gain Compression Point

)

m
B
d
(

t

u
O

r
e
w
o
P

50

40

30

20

10

0

-10

-20

1 dB Compression Point

Extrapolation
Measured

-50

-30

-10

Power In (dBm)

10

The straight line on this graph is an extrapolation of the small signal gain of the unit
under test (UUT). The input 1 dB compression point is the input power that causes the
UUT gain to drop by 1 dB from this small signal value. In this figure, the gain drop
occurs at approximately -12 dBm.

Streaming
Streaming

Streaming is a way to generate waveforms that are too large to fit in the onboard
memory of an RF signal generator.

Streaming can be used in Arbitrary Waveform or Script generation modes. You can
stream waveforms only when the power level is defined as a peak power, not an
average power.

To stream waveform data, allocate and identify all or a portion of the RF signal
generator onboard memory to act as an onboard waveform for streaming. Before
initiating waveform generation, fill that onboard memory with the first part of your

© National Instruments 135

waveform. As the waveform is generated, continuously write the remaining waveform
data until generation is complete. The RF signal generator uses the instrument to
stream the waveform.

Fundamental RF Concepts

Scripts
Scripts

You can link and loop multiple waveforms together in a generation operation using a
script. A script is a series of instructions that indicates how waveforms saved in the
onboard memory should be sent to the DUT.

The script can specify the order in which the waveforms are generated, the number of
times they are generated, and the triggers and markers associated with the
generation.

Note If you are using a vector signal transceiver (VST) instrument, some
script instructions may not be supported using NI-RFSG.

Basic Scripting Example

You can create a script to manage waveform generation based on multiple waveforms
and triggers. For example, you could download waveforms A, B, C, and D into
instrument memory and script it to do the following:

1.  Wait for a trigger to initiate generation
2.  Upon receiving this trigger, generate waveform A three times with a marker at

position 16 each time

3.  Generate waveforms B, C, and D twice (BCDBCD)

The following is the script of this example:

script myFirstScript
    wait until scriptTrigger0
    repeat 3
        generate waveformA marker0(16)
    end repeat
    repeat 2
        generate waveformB
        generate waveformC

136 ni.com

Fundamental RF Concepts

        generate waveformD
    end repeat
end script

NI-RFSG Marker Event Details

A marker is an event that an NI RF signal generator produces in relation to a waveform
that is generated. The marker event is delayed slightly relative to the leading edge of
the waveform that it marks.

By default, the marker event is a pulse of fixed width. The following figure shows a
waveform generated on the output of a waveform generator. The waveform contains a
pulse that represents a waveform sample n that is one Sample Clock in width. The
second pulse, the marker event, represents the pulse that generates when the
corresponding waveform sample n is output at the output connector.

Figure 19. Waveform Output and Associated Marker Event

Waveform
Sample n

Waveform Output
on Output Connector

Marker Event

tm1

tm2

•  tm1—Duration of delay between the configured waveform sample n and

generation of the associated marker event. For most NI VSTs, configurable with
NI-RFSG Events Delay and Relative Delay.

•  tm2—Marker event pulse duration. For most NI VSTs, configurable with NI-RFSG

Width Units and Width Value.

You can use NI-RFSG to configure the characteristics of the pulse generated as the
Marker event.

In addition, you can use scripts to create markers to develop complex behaviors
around generated waveforms.

For example, you can configure the Marker event as a toggled digital pulse signal that

© National Instruments 137

Fundamental RF Concepts

changes state between a low level and high level. While the basic pulse option for
Marker events generates event pulses of fixed width, using the toggle option allows
you to use scripts to change the duration of the Marker event pulse. You can control
the initial state of the toggled pulse with MarkerEvent.Toggle.InitialState.

How Signal Routing Works
How Signal Routing Works

NI VSTs are capable of sending and receiving signals through the front panel
connectors and the PXI trigger bus. Signals are routed between a source and
destination via a path through the PXI trigger bus; there are two broad categories of
routes.

The front panel connectors provide connectivity for input and output signals as well as
for the control lines that send and receive clocks, triggers, and events. You can use the
PXI trigger bus to send and receive events, triggers, and Sample and Reference Clocks.

Signals can be routed to and from the supported front panel connectors of your
instrument. All signal routing operations can be characterized by a source and a
destination. The possible signal routes for your instrument depend on the instrument,
the PXI chassis, and the occupied PXI chassis slot.

When a signal is exported to a PXI trigger bus line from an instrument, only
instruments in the same PXI chassis segment recognize the signal from that PXI trigger
bus line. To route the signal to instruments in a different PXI chassis segment, you
must establish a dynamic route or static route.

•  Dynamic route—Signal route that is specified by only the route endpoints. The

actual route is determined automatically in software and is reserved and
unreserved based on the based on the driver session using that route. Closing the
driver session using a dynamic route releases that route.

NI recommends using dynamic reservations and routing whenever possible.

•  Static route—Signal route that you create manually. You can implement static

reservation of trigger lines in MAX through the Triggers tab.

Refer to your chassis documentation to determine the PXI trigger bus segments of your
chassis.

138 ni.com

Fundamental RF Concepts

Terminal Names and Terminal Name Syntax

A terminal name is a unique identifier that refers to a physical terminal in your system.
A terminal name is fully qualified if it is an unambiguous reference to a specific
terminal.

Terminal names use the following format:

/instrument name/terminal name

where

•  instrument name is the name of the instrument as configured in MAX or Hardware

Configuration Utility, such as PXI1Slot2

•  terminal name is the name of the specific terminal, such as PFI1

This format guarantees the uniqueness of a terminal name across multiple
instruments.

For example, the fully qualified terminal name for PFI1 on PXI1Slot2 is
/PXI1Slot2/PFI1.

Creating Dynamic Routes

With PXI chassis that support them, dynamic routes simplify signal routing through a
system by automatically choosing, allocating, and deallocating the route.

To create a dynamic route, specify a fully qualified terminal name for the source or
destination signal in your programming environment.

Creating Static Routes in MAX

Static routes are a way to manually designate a route on the PXI trigger bus between a
specific signal source and a specific signal destination.

Note NI recommends using dynamic reservations and routing whenever
possible. If your application contains too many static routes between PXI

© National Instruments 139

Fundamental RF Concepts

trigger buses of your chassis, you may not be able to establish dynamic
routes across chassis segments. Refer to your chassis documentation to
determine the allowed number of static routes between the PXI trigger buses
of your chassis.

Complete the following steps to create static routes in MAX.

1.  Launch MAX by navigating to Start » All Programs » National Instruments » NI MAX

or by clicking the NI MAX desktop icon.

2.  Expand Devices and Interfaces.

Note If you are using a remote real-time target, expand Remote
Systems, find and expand your remote real-time target, and then expand
Devices and Interfaces.

3.  Select your chassis.

The settings of your chassis are displayed on the right of the MAX window.

4.  Click the Trigger tab below the settings view.

A table in the Triggers view shows the PXI trigger bus segments of your chassis.

5.  Configure the static route that you wish to make.
6.  Save the changes.

Triggers and Events
Triggers and Events

You can use triggers and events to coordinate the operation of multiple channels and
instruments.

Triggers

A trigger is an input signal to an instrument or channel that causes the instrument or
channel to perform an action. Triggers are routed to input terminals to coordinate
actions.

An input terminal is a physical trigger line (such as a PXI trigger line) or an output
terminal on another instrument or channel where an instrument or channel awaits a
digital edge trigger signal.

140 ni.com

Fundamental RF Concepts

For purposes of programming instruments with NI APIs, triggers comprise two parts:

•  The action, represented with the name of the trigger, that you want the instrument

or channel to take.

•  The signal condition you want to serve as the stimulus for that action (for example,

a rising or falling digital edge on a signal, or a software-generated edge you
configure).

Triggers can be internal (software-generated) or external. You can export external
triggers and use them with events to synchronize hardware operation with external
circuitry or other instruments.

NI RF instruments accept external triggers routed between the instruments using PXI
trigger lines. Events assigned to a PXI trigger line can coordinate actions across
channels and across instruments.

Events

An event is a signal generated by an instrument or channel that signifies:

•  a state change of the instrument,
•  the arrival of a certain kind of sample,
•  the production of a certain amount of samples, or
•  the passage of time.

Events can be routed to output terminals to coordinate the action of multiple channels
or multiple instruments.

Triggers and clocks are generally considered input signals. Exportable triggers and
clocks, such as the sample clock, can also be considered output signals. Output
signals that have neither a trigger nor clock counterpart are called events.

You typically configure events for a specific hardware condition and then do one of the
following:

•  Export the events for use in the test program
•  Export the events to a PXI trigger line to cause an action in another instrument that

is configured to wait for a trigger on that PXI trigger line

© National Instruments 141

Fundamental RF Concepts

De-embedding Overview
De-embedding Overview

NI RF instrument performance specifications are for signals at the instrument's ports.
However, you must also account for external cabling and components between the
instrument and DUT, which also affects input and output signals.

Figure 20. Effect of the External Network on Signals

VST Reference Plane

DUT Reference Plane

VST

External
Network

DUT

De-embedding is the process of removing the effects of these components on an input
or output signal, so the accuracy of the instrument is extended to the DUT.

The NI-RFSA and NI-RFSG instrument drivers can de-embed measurements and
generations using your characterization data. To use this feature, first characterize the
external components with an S-parameter table. Once the tables are passed to the
driver, they can be applied to move the reference plane from the instrument port to
the DUT port.

The NI driver compensates for the effects of the networks by modifying the analog
path and adjusting the data with digital signal processing (DSP).

When using NI-RFSG, the signal seen at the DUT port matches the requested signal.
When using NI-RFSA, the data returned from the driver reflects the signal at the DUT
port rather than the signal seen at the instrument's input port.

Average Power and Crest Factor Considerations
Average Power and Crest Factor Considerations

Crest factor is the difference between peak signal power and average power.

The crest factor for a sinusoidal signal, as is used in CW mode, is 3 dB. In other words,

142 ni.com

Fundamental RF Concepts

the average RMS power of the sinusoid is 3 dB less than its peak instantaneous power.
For modulated signals, specifically orthogonal frequency-division multiplexing
(OFDM), the crest factor can be much larger, in the order of 10 dB to 12 dB.

Consider both the average power and the crest factor of a signal when you configure
the device for generation. The PXIe-5860 supports a maximum specified peak output
power. Generating signals beyond specification are not guaranteed to be calibrated or
linear. If the peak power is set higher than specified as a result of signal crest factor
added with requested average power, severe saturation might occur. Refer to the
PXIe-5860 Specifications for more information about output power range
specifications.

© 2026 National Instruments Corporation.

© National Instruments 143

