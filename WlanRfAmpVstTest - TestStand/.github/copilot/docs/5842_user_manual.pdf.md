PXIe-5842 User
Manual

2026-04-23

PXIe-5842 User Manual

Contents
Contents

PXIe-5842 User Manual  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   7
PXIe-5842 New Features and Changes . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   8
2025 Q3 PXIe-5842 Changes . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   8
2025 Q2 PXIe-5842 Changes . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   8
Instrument Overview . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   10
What is the PXIe-5842?  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   10
Driver Support  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   12
System Requirements . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   14
Hardware Options . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   15
Viewing PXIe-5842 Hardware Options in Software . . . . . . . . . . . . . . . . . . . . . . . . . . .   15
Viewing PXIe-5842 Hardware Options in Hardware Configuration Utility or
MAX . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   16
Querying PXIe-5842 Hardware Options with System Configuration . . . . . . .   16
Locating the PXIe-5842 Assembly Part Number  . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   18
Components of a PXIe-5842 System  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   18
Cables and Accessories . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   20
Choosing Your Software . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   23
Front Panels and Pinouts  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   24
PXIe-5842 VST Front Panel . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   24
PXIe-5842 VST with 54 GHz Frequency Extension Front Panel and Rear Panel . . . . . . . .   35
PXIe-5842 VST with S-Parameters Front Panel  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   51
Theory of Operation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   67
PXIe-5842 Instrument Block Diagrams . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   67
PXIe-5842 VST Block Diagram . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   67
PXIe-5842 VST with 54 GHz Frequency Extension Block Diagram . . . . . . . . . . . . . .   68
PXIe-5842 VST with S-Parameters Block Diagram . . . . . . . . . . . . . . . . . . . . . . . . . . . .   71
PCI Express Interface . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   73
VST State Models  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   73
NI-RFSA State Model  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   73
NI-RFSG State Model . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   76
Finding Examples  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   78
RF API Locations . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   79

2 ni.com

PXIe-5842 User Manual

Contents of the Package . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   82
PXIe-5842 VST Package Contents . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   82
PXIe-5842 VST with 54 GHz Frequency Extension Package Contents . . . . . . . . . . . . . . . .   83
PXIe-5842 VST with S-Parameters Package Contents  . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   85
CAL-5501 Package Contents . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   86
Safety Guidelines  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   88
Safety Voltages . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   88
Product Certifications and Declarations . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   99
Mounting Guidelines  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   100
Installing and Setting Up the Instrument  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   101
Installing the Software  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   101
Installing and Interconnecting PXIe-5842 Instruments . . . . . . . . . . . . . . . . . . . . . . . . . . .   102
Unpacking the Kit . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   102
Installing PXIe-5842 Modules in a PXI Express Chassis . . . . . . . . . . . . . . . . . . . . . . .   103
Ensuring Signal Quality when Interconnecting the PXIe-5842 . . . . . . . . . . . . . . . .   105
Interconnecting your PXIe-5842 Instrument  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   106
Interconnecting the PXIe-5842 VST  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   106
Interconnecting the PXIe-5842 VST with 54 GHz Frequency Extension  . . .   109
Interconnecting the PXIe-5842 VST with S-Parameters . . . . . . . . . . . . . . . . .   115
Performing Initial Hardware Configuration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   118
Configuring the PXIe-5842 in Hardware Configuration Utility . . . . . . . . . . . . . . . .   118
Configuring the PXIe-5842 in MAX  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   121
Making a First VST Measurement . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   122
Creating a Multi-VST System . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   125
Operating Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   130
Device Warm-Up . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   130
Guidelines for Making Threaded RF Connections . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   130
Threaded RF Connector Care Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   131
Avoiding Damage when Making Direct Connections to the PXIe-5842  . . . . . . . . . . . . .   133
Avoiding Damage when Removing Modules from the Chassis  . . . . . . . . . . . . . . . . . . . .   133
Power and Thermal Monitoring and Shutdown Conditions . . . . . . . . . . . . . . . . . . . . . . .   134
PXIe-5842 Power On and Reset Conditions  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   136
VNA Measurement Calibration Guidelines . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   137
Using the Instrument . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   139
Connecting DUTs to the PXIe-5842 . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   139
Making Connections to the PXIe-5842 VST . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   139

© National Instruments 3

PXIe-5842 User Manual

Making Connections to the PXIe-5842 VST with 54 GHz Frequency Extension . .   140
Making Connections to the PXIe-5842 VST with S-Parameters  . . . . . . . . . . . . . . .   142
Analyzing and Generating RF Signals with NI VSTs . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   143
Analyzing RF Signals with RFmx and NI-RFSA . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   144
Analyzing RF Signals with RFmx . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   145
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   146
Configure Hardware Settings . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   147
Configure the Measurement  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   147
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   148
Analyzing RF Signals with NI-RFSA . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   148
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   149
Configure the Reference Clock  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   149
Configure the Acquisition . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   150
Coordinate Actions with Triggers and Events  . . . . . . . . . . . . . . . . . . . .   151
Read and Plot Acquired Data . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   154
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   155
Generating RF Signals with NI-RFSG  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   155
Initialize a Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   156
Configure the Reference Clock  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   156
Configure the RF Output Signal  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   157
Coordinate Actions with Triggers and Events  . . . . . . . . . . . . . . . . . . . . . . . . .   157
Initiate Waveform Generation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   164
Check the Status of RF Signal Generation . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   164
Close the Session . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   165
Designing VNA Measurement Applications for the PXIe-5842 VST with S-Parameters . . . .
165
Improving NI-TClk Synchronization of RF Instruments . . . . . . . . . . . . . . . . . . . . . . . . . . .   171
NI-TClk Manual Calibration Using NI-RFSA . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   172
NI-TClk Manual Calibration Using NI-RFSG  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   172
Local Oscillators . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   173
LO Sharing with NI-RFSA and NI-RFSG  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   173
LO Sharing for the PXIe-5842 VST . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   174
LO Sharing for the PXIe-5842 VST with 54 GHz Frequency Extension . . . . . . . . . .   176
LO Sharing for the PXIe-5842 VST with S-Parameters  . . . . . . . . . . . . . . . . . . . . . . .   180
Using an External LO . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   182
Connecting an External LO to a PXIe-5842 Instrument  . . . . . . . . . . . . . . . . . . . . . .   183

4 ni.com

PXIe-5842 User Manual

Configuring PXIe-5842 Instruments to Use an External LO . . . . . . . . . . . . . . . . . . .   184
Specifying LO Frequency With Automatic Frequency Offset  . . . . . . . . . . . . . . . . .   185
Specifying LO Power When Using an External LO . . . . . . . . . . . . . . . . . . . . . . . . . . .   186
Improving Spurious Performance  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   187
Timing Configurations  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   187
Configuring Onboard Reference Clock Timing  . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   187
Configuring External Reference Clock Timing . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   188
Configuring PXI Backplane Clock Timing . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   188
Frequency and Bandwidth Configuration with NI RF Drivers . . . . . . . . . . . . . . . . . . . . . .   189
Frequency and Bandwidth Configuration Terminology  . . . . . . . . . . . . . . . . . . . . .   190
Frequency and Bandwidth Selection to Optimize Performance . . . . . . . . . . . . . .   192
Frequency Offset  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   196
Using In-Band Retuning . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   198
Automatic Frequency Offset  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   200
PXIe-5842 Pulse Modulation  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   202
Streaming Applications  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   205
Streaming Waveform Data . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   205
Peer-to-Peer Data Streaming . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   209
Configuring a Peer-to-Peer Endpoint . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   210
Configuring a Peer-to-Peer Stream  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   211
PXIe-5842 MGT Streaming  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   213
Requirements for PXIe-5842 MGT Streaming . . . . . . . . . . . . . . . . . . . . . . . . . .   215
Connecting the PXIe-5842 for MGT Streaming . . . . . . . . . . . . . . . . . . . . . . . . .   216
Using PXIe-5842 MGT Streaming Examples  . . . . . . . . . . . . . . . . . . . . . . . . . . .   217
Using the MGT Streaming Acquisition Example . . . . . . . . . . . . . . . . . . .   217
Using the MGT Streaming Generation Example . . . . . . . . . . . . . . . . . . .   219
Using the Multi-Gigabit Transceiver (MGT) Streaming Roundtrip
Example  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   220
Performing Interactive VNA Measurements in InstrumentStudio . . . . . . . . . . . . . . . . . .   223
Unsupported Software Features . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   228
Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   230
PXIe-5842 Parameters Adjusted by Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   230
When to Perform Self-Calibration  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   231
Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   232
Self-Calibrating the PXIe-5842 with InstrumentStudio . . . . . . . . . . . . . . . . . . . . . .   232
Self-Calibrating the PXIe-5842 with the NI-RFSA LabVIEW Example . . . . . . . . . . .   234

© National Instruments 5

PXIe-5842 User Manual

Partial Self-Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   235
Performing Partial Self-Calibration  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   235
Cleaning and Maintaining the PXIe-5842 . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   237
Cleaning Threaded RF Connectors . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   237
Troubleshooting  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   240
My Hardware Doesn't Appear in Hardware Configuration Utility or MAX  . . . . . . . . . . .   240
Why Is the ACCESS LED Off When the Chassis Is On? . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   241
What Should I Do if the PXIe-5842 Fails the Self-Test? . . . . . . . . . . . . . . . . . . . . . . . . . . . .   242
What Should I Do if the Instrument Does Not Initialize? . . . . . . . . . . . . . . . . . . . . . . . . . .   244
Fundamental RF Concepts  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   246
Common NI RF Terminology . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   246
Carrier Wave  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   248
Message Signal . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   249
Modulation  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   249
I/Q Modulation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   250
Sample Rate  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   254
Impedance Matching . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   256
Resolution Bandwidth  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   258
Noise Fundamentals . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   260
Streaming  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   266
Scripts . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   267
How Signal Routing Works . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   269
Triggers and Events . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   271
De-embedding Overview . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   273
Quadrature Mixing (Direct Conversion) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   276
Average Power and Crest Factor Considerations  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   278

6 ni.com

PXIe-5842 User Manual

User Manual
PXIe-5842  User Manual
PXIe-5842

The PXIe-5842 User Manual provides detailed descriptions of the product functionality
and the step by step processes for use.

Looking for Something Else?

For information not found in the User Manual for your product, such as specifications
and API reference, browse Related Information.

Related information:

•  NI Hardware and Software Operating System Compatibility
•  PXIe-5842 Specifications
•  PXIe-5842 Configuration Guide
•  Software and Driver Downloads
•  License Setup and Activation
•  Release Notes
•  NI Learning Center
•  NI Community

© National Instruments 7

PXIe-5842 New Features and Changes

New Features and Changes
PXIe-5842  New Features and Changes
PXIe-5842

Learn about updates, including new features and behavior changes, introduced in
each version of PXIe-5842.

Discover what is new in the latest releases of PXIe-5842.

Note If you cannot find new features and changes for your version, it might
not include user-facing updates. However, your version might include non-
visible changes such as bug fixes and compatibility updates. For information
about non-visible changes, refer to your product Release Notes.

2025 Q3 PXIe-5842
2025 Q3

Changes
PXIe-5842  Changes

Learn about updates, including new features and behavior changes, introduced in
each version of PXIe-5842.

New Hardware Support

This version of the PXIe-5842 provides support for the following hardware setup:

•  PXIe-5842 VST with 54 GHz Frequency Extension now supports RMM-5586 in the

hardware setup.

2025 Q2 PXIe-5842
2025 Q2

Changes
PXIe-5842  Changes

Learn about new features, behavior changes, and other updates in PXIe-5842.

New Features

This version of the PXIe-5842 provides support for the following features:

•  PXIe-5842 VST with 54 GHz Frequency Extension is available and has been added to

the document.

8 ni.com

PXIe-5842 New Features and Changes

New Hardware Support

This version of the PXIe-5842 provides support for the following hardware setup:

•  PXIe-5842 VST with 54 GHz Frequency Extension uses a PXIe-5563 in the hardware

setup.

© National Instruments 9

PXIe-5842 Instrument Overview

Instrument Overview
PXIe-5842  Instrument Overview
PXIe-5842

Learn the basics about the PXIe-5842 and what you need to incorporate it into your
measurement system.

What is the PXIe-5842
What is the

PXIe-5842? ?

The PXIe-5842 is a modular RF vector signal transceiver (VST). The PXIe-5842 module
combines with other modules to form complete PXIe-5842 instruments.

The PXIe-5842 combines a vector signal generator and vector signal analyzer with
FPGA-based, real-time signal processing and control.

The PXIe-5842 name encompasses the following instruments:

Table 1. PXIe-5842 Instruments

Instrument

Constituent Modules

PXIe-5842 VST (PXIe-5842 VST (Up to
2 GHz Bandwidth) and PXIe-5842 VST (4 GHz
Bandwidth))

•  PXIe-5842
•  PXIe-5655

PXIe-5842 VST with 54 GHz Frequency Extension

•  PXIe-5842
•  PXIe-5655 (×2)
•  PXIe-5563
•  RMM-5585 or RMM-5586

PXIe-5842 VST with S-Parameters

•  PXIe-5842
•  PXIe-5655
•  PXIe-5633

Content applies to all PXIe-5842 configurations unless otherwise noted. Content that
applies to the specific PXIe-5842 module within a larger PXIe-5842 instrument is noted
accordingly.

10 ni.com

In addition, the PXIe-5842 is available with a variety of hardware options that extend
performance or enable specific features. The contents of this manual encompass the
full capability of the PXIe-5842.

PXIe-5842 Instrument Overview

Related concepts:

•  PXIe-5842 Hardware Options

Related information:

•  PXIe-5842 Configuration Guide

Instrument Personalities

Some PXIe-5842 configurations support more than one personality. The personality of
your VST can define its behavior and performance during any new sessions that you
create.

Table 2. Supported Personalities

Personality

Supported Hardware
Configurations

Features

Standard

All hardware configurations

4 GHz Bandwidth

PXIe-5842 VST (4 GHz
Bandwidth) configuration only

•  Provides all core

functionality of the
instrument

•  Flexible IQ rate up to 1.25 ×

maximum bandwidth
•  Frequency range from 30
MHz up to the maximum
licensed frequency

•  Allows acquisitions and
generations with up to
4 GHz bandwidth

•  IQ rate locked at 5 GS/s
•  1.75 GHz minimum

frequency

•  May have lower maximum

© National Instruments 11

Personality

Supported Hardware
Configurations

Features

PXIe-5842 Instrument Overview

generation power at high
frequencies

To configure your device personality, use either the Hardware Configuration Utility or
MAX.

Related tasks:

•  Configuring the PXIe-5842 in Hardware Configuration Utility
•  Configuring the PXIe-5842 in MAX

Driver Support
PXIe-5842  Driver Support
PXIe-5842

PXIe-5842 instruments require NI driver software. Different PXIe-5842 instruments
might have different minimum supported driver versions.

NI recommends that you use the newest version of the driver for your instrument.

Table 3. PXIe-5842 Instrument Earliest Driver Support

Instrument

Assembly Part Number

Earliest Driver Support

PXIe-5842 VST (Up to
2 GHz Bandwidth)

135077x-01L

Where the hardware revision x
is a letter.

•  RFmx 2022 Q4 or later
•  NI-RFSA 2022 Q4 or later
•  NI-RFSG 2022 Q4 or later

138862x-yL

Where the hardware revision x
is a letter and y is one or more
digits.

•  RFmx 2023 Q3 or later
•  NI-RFSA 2023 Q3 or later
•  NI-RFSG 2023 Q3 or later

Note Driver support
depends on the
assembly part
number of the
PXIe-5842 module
around which your
PXIe-5842
instrument is based.

12 ni.com

PXIe-5842 Instrument Overview

Instrument

Assembly Part Number

Earliest Driver Support

PXIe-5842 VST (4 GHz
Bandwidth)

•  117478x-yL
•  117480x-yL

Where the hardware revision x
is a letter and y is one or more
digits.

•  RFmx 2025 Q1 or later
•  NI-RFSA 2025 Q1 or later
•  NI-RFSG 2025 Q1 or later

PXIe-5842 VST with 54 GHz
Frequency Extension

—

PXIe-5842 VST with
S-Parameters

—

•  RMM-5585

◦  RFmx 2025 Q3 or later
◦  NI-RFSA 2025 Q3 or

later

◦  NI-RFSG 2025 Q3 or

later

•  RMM-5586

◦  RFmx 2026 Q1 or later
◦  NI-RFSA

2026 Q1 Patch 1 or
later
◦  NI-RFSG

2026 Q1 Patch 1 or
later

•  RFmx 2023 Q4 or later
•  NI-RFSA 2023 Q4 or later
•  NI-RFSG 2023 Q4 or later

Note For the
PXIe-5842 VST with
S-Parameters, VNA
API functionality is
accessible only
through RFmx VNA.

© National Instruments 13

PXIe-5842 Instrument Overview

System Requirements
PXIe-5842  System Requirements
PXIe-5842

Your system must meet the following minimum requirements to run and use the
PXIe-5842.

Chassis Requirements

•  Slot cooling capacity—Must be ≥82 W
•  Power delivery—Must provide ≥82 W per slot.

See PXIe-5842 Specifications or the safety, environmental, and regulatory
information document for each module of your instrument for specific power
consumption.

Note Power requirements may be specified on a module basis; the
chassis must provide enough power for the complete PXIe-5842
instrument.

•  Clearances—Maintain the minimum required clearances around your PXI Express

chassis. Clearances may vary by chassis. Follow the guidelines in the
documentation for the chassis.

•  Available adjacent, compatible PXI slots—Varies by instrument:

•  PXIe-5842 VST (Up to 2 GHz Bandwidth) and PXIe-5842 VST (4 GHz Bandwidth):

4
◦  3 for PXIe-5842 module
◦  1 for PXIe-5655 module

•  PXIe-5842 VST with 54 GHz Frequency Extension: 6

◦  3 for PXIe-5842 module
◦  2 for ×2 PXIe-5655 module
◦  1 for PXIe-5563 module

•  PXIe-5842 VST with S-Parameters: 5

◦  3 for PXIe-5842 module
◦  1 for PXIe-5655 module
◦  1 for PXIe-5633 module

The modules of your instrument can be installed in the following PXI chassis slot types:

14 ni.com

PXIe-5842 Instrument Overview

•  PXI Express Hybrid Peripheral Slot
•  PXI Express System Timing Slot
•  PXI Express Peripheral Slot

Controller or Host Computer Requirements

•  RAM—4 GB. Depending on the amount of data acquired and/or processed, a larger

amount of memory may be required.

•  Processor—1 GHz 64-bit (x64)

Related information:

•  NI Hardware and Software Operating System Compatibility

Hardware Options
PXIe-5842  Hardware Options
PXIe-5842

PXIe-5842 instruments have multiple available hardware options. Each hardware
option enables additional performance or a particular feature; you can use NI software
to check the hardware options of a PXIe-5842 instrument.

Viewing PXIe-5842
Viewing

Hardware Options in Software
PXIe-5842  Hardware Options in Software

There are multiple ways to check the hardware options that are enabled for a given
PXIe-5842 instrument within NI software.

This hardware option information applies to PXIe-5842 instruments based around a
PXIe-5842 with the following assembly part numbers:

•  138862x-yL
•  117478x-yL
•  117480x-yL

Where the hardware revision x is a letter and y is one or more digits.

Note For instruments based around a PXIe-5842 with assembly part number
135077x-01L: Only the Analysis and Generation options are reported in
software. To confirm the other available options—frequency range and
bandwidth—for these instruments, refer to the purchase order for your

© National Instruments 15

PXIe-5842 Instrument Overview

instrument.

Hardware Options in Hardware Configuration
PXIe-5842  Hardware Options in Hardware Configuration

Viewing PXIe-5842
Viewing
Utility or MAX
Utility or MAX

You can refer to Hardware Configuration Utility or MAX to identify the hardware
options that are enabled for a given PXIe-5842 instrument.

Depending on your software, complete the following steps to use NI hardware
configuration software to see the options a PXIe-5842 instrument is equipped with.

Configuration Software

Procedure

Hardware Configuration Utility

MAX

a.  Open Hardware Configuration Utility.
b.  Select the PXIe-5842 in the system pane on

the left side of the interface.

c.  In the configuration pane on the right side of
the interface, review the options listed in the
Device details section.

a.  Open MAX.
b.  In the MAX configuration tree, expand

Devices and Interfaces.
c.  Select the PXIe-5842 module.
d.  In the Settings pane, review the options
listed in the Hardware Options section.

Querying PXIe-5842
Querying

Hardware Options with System Configuration
PXIe-5842  Hardware Options with System Configuration

You can use the System Configuration API to create software applications for the
PXIe-5842 that verify that the expected hardware options are present or that
accommodate various hardware options.

Introduced in System Configuration 2023 Q2

16 ni.com

PXIe-5842 Instrument Overview

Note System Configuration may not be automatically installed with NI RF
driver software. Ensure your system includes the specified version of System
Configuration or later. You can download System Configuration from ni.com.

Within the System Configuration API, hardware options are known as activated
features.

Complete the following steps to create a System Configuration program that selects
the PXIe-5842 and identifies the hardware options it is equipped with.

1.  Use Initialize Session to create the System Configuration session.
2.  Use Create Filter and the Is Device and User Alias properties to select your

PXIe-5842 instrument using its alias.

Tip You can find the PXIe-5842 alias in MAX and Hardware Configuration
Utility. Select your instrument in MAX or Hardware Configuration Utility
and view the alias in the location as follows:
◦  MAX: Name field of the Settings section
◦  Hardware Configuration Utility: Device name field of the Identity

section in the right-side configuration pane

3.  Use Find Hardware to return the hardware you have filtered for.
4.  Create an array of the hardware options using a property node and the Activated
Feature Count, Activated Feature Names, and Activated Feature IDs properties.
This displays the total number of hardware options equipped on your PXIe-5842
and enumerates each, along with the corresponding Feature ID and feature name
for each hardware option.

5.  Use Close to end the program and release all session resources.

Sample System Configuration Program to Query PXIe-5842 Hardware
Options

Drag the following VI snippet to your block diagram to create the program this
procedure describes.

© National Instruments 17

PXIe-5842 Instrument Overview

Locating the PXIe-5842
Locating the

Assembly Part Number
PXIe-5842  Assembly Part Number

There are multiple PXIe-5842 module assembly part numbers, and the assembly you
have affects the available hardware options and how those options are presented in NI
hardware configuration software. You can find the assembly part number in NI
software or on the side of the PXIe-5842 module.

To find the assembly part number of the PXIe-5842, use any of the following methods:

Option

Software: MAX

Software: Hardware Configuration Utility

Description

In the configuration tree, expand Devices and
Interfaces and select the instrument. In the
Settings pane, view the assembly part number
and hardware revision.

Select your instrument in the system pane and
view the assembly part number and hardware
revision in the Identity section of the
configuration pane on the right side.

Visual identification on PXIe-5842 module

Viewing the front panel of the PXIe-5842 module,
find the label affixed to the left side.

Components of a PXIe-5842
Components of a

System
PXIe-5842  System

PXIe-5842 instruments are designed for use in a system that includes other hardware
components, drivers, and software.

Note A system and the surrounding environment must meet the
requirements defined in PXIe-5842 Specifications and the safety,
environmental, and regulatory information document for each component of
the PXIe-5842 instrument.

18 ni.com

The following list defines the minimum required hardware and software for a system
that includes a PXIe-5842 instrument.

PXIe-5842 Instrument Overview

Table 4. System Components

Component

PXI Chassis

PXI Controller or PXI Remote Control
Module

Description and Recommendations

A PXI chassis houses the PXIe-5842 and supplies power for
PXIe-5842 functions.

Note PXIe-5842 instruments require a chassis
with 82 W slot cooling capacity.

You can install a PXI controller or a PXI remote control
(MXI) module depending on your system requirements.
These components, installed in the same PXI chassis as
the PXIe-5842, interface with the instrument using NI
device drivers.

VST Instrument

Cables and Accessories

Your instrument.

RF Drivers: NI-RFSA, NI-RFSG, and
RFmx

Cables and accessories allow connectivity to/from your
instrument for measurements. Refer to Cables and
Accessories for recommended cables and accessories
guidance.

Instrument driver software that provides functions to
interact with the PXIe-5842 and execute measurements
using the PXIe-5842.

•  NI-RFSA—Controls and configures NI vector signal

analyzers (VSAs) and the analysis (input) functionality

© National Instruments 19

Component

Description and Recommendations

PXIe-5842 Instrument Overview

of NI vector signal transceivers (VSTs). NI-RFSA
provides the standard IVI-based functionality needed
for most vector signal analyzer applications. Features
a set of operations and properties that enable you to
create custom measurements or applications that
require I/Q data.

•  NI-RFSG—Configures and operates NI vector signal
generators (VSGs) and the generation (output)
functionality of NI vector signal transceivers (VSTs).
Performs waveform programming and generation
and basic modulation tasks. Provides the standard
IVI-based functionality needed for most RF signal
generator applications.

•  RFmx—Provides signal generation and analysis for
general-purpose; cellular connectivity; Internet of
things (IoT); and aerospace and defense test
applications. A set of interoperable measurement
personalities together with waveform creation
software that extends the capability of NI RF
instrumentation. This enables uses for design,
validation, and production test applications.

Note NI recommends always using the most
current driver versions with the PXIe-5842. You
can find the RF driver requirements on the
download page for the driver on ni.com.

NI Applications

NI-RFSA, NI-RFSG, and RFmx offer driver support for the
following applications:

•  InstrumentStudio
•  LabVIEW
•  LabWindows™/CVI
•  C/C++
•  .NET

Cables and Accessories
Cables and Accessories

NI recommends using certain cables and accessories with your PXIe-5842 instrument

20 ni.com

PXIe-5842 Instrument Overview

to realize optimal performance.

Cables

To install the included intermodule cabling for PXIe-5842 instruments, you will need
either of the following items, which are not included in the PXIe-5842 kit:

•  0.9 N · m (8 lb · in.) calibrated torque wrench, 5/16 in., NI part number 751120-01
•  100 N · cm calibrated torque screwdriver, NI part number 780487-01, for use with

the SMA driver bit included in the PXIe-5842 kit

Though the cables for intermodule connections are supplied with your PXIe-5842
instrument are supplied with the instrument, cables to connect external equipment
and DUTs to your PXIe-5842 instrument are not. NI recommends that the cables you
use to connect to your PXIe-5842 instrument meet the following guidelines, depending
on the connector type, in order to meet the RF performance requirements of your
application:

•  3.5 mm connectors—3.5 mm cables are recommended.

2.92 mm cables are acceptable. SMA cables are also usable, but ensure that the
SMA cable is rated to the frequencies you are using the cable for, and verify that the
center pin length of the SMA connector on your cable does not exceed the center
pin length of the 3.5 mm standard.

•  1.85 mm connectors—1.85 mm cables are recommended for the RMM-5585 and

RMM-5586.

Notice Ensure that you are using different cables for PXIe-5563 and
RMM-5585 or RMM-5586. These modules require different cable types and
are not compatible.

•  Other connector types—Use a cable that matches the connector type.

Note

© National Instruments 21

PXIe-5842 Instrument Overview

3.5 mm

1.85 mm

RF connectors on the PXIe-5563 (for
frequencies up to 26.5 GHz)

RF connectors on the RMM-5585 or
RMM-5586

The connection type to the RF connectors on the RMM-5585/RMM-5586 for
frequencies above 26.5 GHz differs from the PXIe-5563 for frequencies up to
26.5 GHz. Therefore, 1.85 mm and 3.5 mm cables are not compatible.

Accessories

NI recommends installing PXI slot blockers (NI part number 199198-01) to fill empty
instrument slots in a PXI chassis and EMC filler panels (NI part number 778700-01) to
cover these slots.

•  Slot blocker—Fills an empty slot within a PXI chassis. Improves system cooling in
PXI chassis by rerouting airflow from empty slots to slots containing PXI modules.

•  Filler panel—Covers an empty slot within a PXI chassis. Improves the cooling

performance of the PXI system.

There are both standard and EMC filler panels. EMC filler panels contain additional
gaskets to control EMC emissions from the chassis.

Related concepts:

•  PXIe-5842 Front Panels and Pinouts

Related tasks:

•  Connecting DUTs to the PXIe-5842

Related information:

•  Slot Blocker Documentation

22 ni.com

PXIe-5842 Instrument Overview

Choosing Your Software
Choosing Your Software

You can choose among multiple options for taking measurements with the PXIe-5842.
For example, you can design your own programs from scratch or from starting point
example programs, but you can also get started with measurements quickly by using
soft front panels.

Depending on the measurements you want to take and how you want to customize
your test system, choose the appropriate software from the following options.

If you want to

Perform physical layer measurements of
supported communications and connectivity
signals

Measure spectral performance and understand
spectral characteristics

Choose

RFmx personalities

RFmx SpecAn

Measure modulation quality, including error
vector magnitude (EVM)

RFmx Demod

Create, visualize, and play back RF waveforms  RFmx Waveform Creator

Take S-parameter or VNA measurements

RFmx VNA

Perform custom measurements or applications
that require I/Q data

NI-RFSA

Generate CW or modulated waveforms

NI-RFSG

Take interactive measurements with your
instrument

InstrumentStudio

© National Instruments 23

PXIe-5842 Front Panels and Pinouts

Front Panels and Pinouts
PXIe-5842  Front Panels and Pinouts
PXIe-5842

Refer to the front panel and rear panel information for your PXIe-5842 instrument to
understand the connectors, pinouts, and signals found on your instrument.

Related concepts:

•  Cables and Accessories

Related reference:

•  Safety Voltages

Front Panel
PXIe-5842  VSTVST  Front Panel
PXIe-5842

The PXIe-5842 VST comprises an interconnected PXIe-5842 and PXIe-5655.

24 ni.com

PXIe-5842 Front Panels and Pinouts

Figure 1. PXIe-5842 VST Front Panel

PXIe-5842
Vector Signal Transceiver

ACC

ACTIVE

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

LO 0 OUT
50 MHz to
7.2 GHz

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF OUT

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN
+17 dBm
MAX

LO OUT
+17 dBm
MAX
REVERSE

PFI 0
LVTTL

LO 1 IN
+17 dBm
MAX

CTRL
1.8 V  LVCMOS

RF IN

LO OUT
+17dBm
MAX
REVERSE

REF IN

LO IN
+17 dBm
MAX

LO 1 OUT
50 MHz to
7.2 GHz

ESD
SENSITIVE

PULSE

IN
OUT
3.3 V  LVCMOS

ALL RF PORTS 50 Ω

ESD
SENSITIVE

Note The PXIe-5842 VST is a functional instrument that comprises multiple
modules interconnected in the manner depicted. Refer to the front panels for
the individual modules for detailed information on their connectors.

Related reference:

•  Safety Voltages

© National Instruments 25

PXIe-5842 Front Panels and Pinouts

PXIe-5842 Front Panel and LEDs

Note This information applies to the PXIe-5842 module only.

Figure 2. PXIe-5842 Front Panel

Table 5. PXIe-5842 RF Connector Descriptions

Connector

Connector Type

Description

RF IN

RF OUT

RF OUT: LO IN

3.5 mm (f)

3.5 mm (f)

SMA (f)

Input terminal for RF signals

Output terminal for RF signals

Intermodule connection only

26 ni.com

ACTIVEACCPXIe-5842 Vector Signal TransceiverESDSENSITIVERF INRF OUTREFRF INRF OUTPULSELO OUT+17dBmMAXREVERSELO IN+17 dBmMAXLO IN+17 dBmMAXCTRL1.8 V  LVCMOSDIO5 V MAXMGT100 Ω DIFF5 V MAXPFI 00123OUT2 Vp-pMAXREVERSEIN2.5 Vp-pMAXLO OUT+17 dBmMAXREVERSEINOUT3.3 V  LVCMOSSEE SPECIFICATIONS FORMAX RF IN / OUT POWERALL RF PORTS 50 ΩPXIe-5842 Front Panels and Pinouts

Connector

Connector Type

Description

RF OUT: LO OUT

RF IN: LO OUT

RF IN: LO IN

SMA (f)

SMA (f)

SMA (f)

Output terminal for exporting
the RF OUT LO signal

Output terminal for exporting
the RF IN LO signal

Intermodule connection only

Table 6. PXIe-5842 General Connector Descriptions

Connector

Connector Type

Description

REF: IN

REF: OUT

PFI 0

DIO

MGT

CTRL

SMA (f)

SMA (f)

SMA (f)

Intermodule connection only

Output terminal that can export
a 10 MHz, 100 MHz, or 1 GHz
reference clock

Programmable function digital
I/O (DIO) connector for use with
triggers or events

Mini HDMI

Reserved

iPass+ zHD

Multigigabit transceiver for
streaming functionality; usable
by instruments with the MGT
streaming hardware option

Mini HDMI

Intermodule connection only

PULSE: IN

SMB (m)

PULSE: OUT

SMB (m)

Input for external pulse
modulation source; usable by
instruments with the pulse
modulation hardware option

Output for monitoring the
envelope of pulse modulated
RF signals; usable by
instruments with the pulse
modulation hardware option

© National Instruments 27

Table 7. PXIe-5842 LED Indicators

LED

Indications

PXIe-5842 Front Panels and Pinouts

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail

•  Amber—The module is being accessed;

accessed means that you are writing to the
module setup registers to control the
module, reading from the module to
monitor its status, or transferring data to or
from the module

•  Green—The module is controllable through

the software

Indicates the state of the module.

•  Off—The module is idle
•  Solid green—The module is generating a

waveform

•  Dim amber—The module is waiting for an

acquisition Reference Trigger

•  Solid amber—The module is acquiring a

waveform

•  Solid red—The module has detected an

error; the LED remains red until the error
condition is removed

For example, the module could have
exceeded its operating temperature and
entered thermal shutdown. In this case,
check system airflow and reset the module
in Hardware Configuration Utility or MAX.

Note Indicators are listed in
increasing order of priority. For
example, if you are generating a
waveform using NI-RFSG and waiting

ACCESS

ACTIVE

28 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

on an acquisition Reference Trigger in
NI-RFSA, the LED is dim amber.

PXIe-5842 MGT Connector Pinout

Single MGT connector shown; the PXIe-5842 front panel has four MGT connectors that
have identical pinouts.

Table 8. PXIe-5842 MGT Signal Descriptions

Pin

A1

A2

A3

A4

A5

Signal

Reserved

Reserved

GND

Rx+ 0

Rx- 0

Description

N/A

N/A

Ground reference for signals

Receive channel 0, positive

Receive channel 0, negative

© National Instruments 29

Optical 3.3 VEEPROM 3.3 VGNDTx+ 1Tx– 1GNDTx+ 2Tx– 2GNDD1D2D3D4D5D6D7D8D9Optical 3.3 VGPIOGNDRx+ 1Rx– 1GNDRx+ 2Rx– 2GNDB1B2B3B4B5B6B7B8B9RESERVEDRESERVEDGNDRx+ 0Rx– 0GNDRx+ 3Rx– 3GNDSCLSDAGNDTx+ 0Tx– 0GNDTx+ 3Tx– 3GNDA1A2A3A4A5A6A7A8A9C1C2C3C4C5C6C7C8C9Signal

GND

Rx+ 3

Rx- 3

GND

Optical 3.3 V

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

Optical 3.3 V

PXIe-5842 Front Panels and Pinouts

Description

Ground reference for signals

Receive channel 3, positive

Receive channel 3, negative

Ground reference for signals

Power supply for active/optical
cables

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

Power supply for active/optical
cables

EEPROM 3.3 V

EEPROM power supply

GND

Tx+ 1

Ground reference for signals

Transmit channel 1, positive

Pin

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

D3

D4

30 ni.com

Pin

D5

D6

D7

D8

D9

Signal

Tx- 1

GND

Tx+ 2

Tx- 2

GND

PXIe-5842 DIO Connector Pinout

PXIe-5842 Front Panels and Pinouts

Description

Transmit channel 1, negative

Ground reference for signals

Transmit channel 2, positive

Transmit channel 2, negative

Ground reference for signals

Table 9. PXIe-5842 DIO Signal Descriptions

Pin

19

Signal

GND

Description

Ground reference for signals

© National Instruments 31

GNDGNDGNDGNDGNDGNDGNDGNDNCNCVCCDIO 7DIO 6DIO 5DIO 4DIO 3DIO 2DIO 1DIO 011918171615141312111098765432Pin

Signal

Description

PXIe-5842 Front Panels and Pinouts

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

32 ni.com

PXIe-5655 Front Panel and LEDs

Figure 3. PXIe-5655 with SMA Front Panel

PXIe-5842 Front Panels and Pinouts

Table 10. PXIe-5655 Connector Descriptions

Connector

REF OUT

PFI 0

REF IN

Connector Type

Description

SMA (f)

—

Output terminal that can export
a 100 MHz Reference Clock.

This is reserved and not
enabled for use with the
PXIe-5842.

SMA (f)

Input terminal that allows the

© National Instruments 33

PXIe-5655 Dual RF SynthesizerACTIVEALL RF PORTS 50ΩACCLO 0 OUT50 MHz to7.2 GHzLO 0 IN+17 dBmMAXLO 1 IN+17 dBmMAXLO 1 OUT50 MHz to7.2 GHzESDSENSITIVEPFI 0LVTTLREF INREF OUTConnector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

use of an external Reference
Clock with one of the following
frequencies:

•  10 MHz
•  100 MHz
•  270 MHz
•  3.84 MHz × y, where y is 4,

8, 16, 24, 25, or 32

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

Input terminal that allows the
use of an external local
oscillator.

Input terminal that allows the
use of an external local
oscillator.

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

LO 0 OUT

SMA (f)

LO 0 IN

LO 1 IN

SMA (f)

SMA (f)

LO 1 OUT

SMA (f)

Table 11. PXIe-5655 LED Indicators

LED

Indications

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail.

•  Amber—The module is being accessed.

Accessed means that you are writing to the
device setup registers to control the device,
reading from the device to monitor the
device status, or transferring data to or from
the device.

ACCESS

34 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

•  Green—The module is controllable through

the software.

•  Off—The module is idle or locked to the

requested reference.

•  Solid red—The PLL is unlocked or the

module temperature is out of the specified
operating range.

ACTIVE

PXIe-5842
PXIe-5842  VST with
Panel and Rear Panel
Panel and Rear Panel

VST with 54 GHz

54 GHz  Frequency Extension

Front
Frequency Extension  Front

The PXIe-5842 VST with 54 GHz Frequency Extension comprises an interconnected
PXIe-5842, PXIe-5655 (×2), PXIe-5563, and RMM-5585/RMM-5586 remote measurement
module.

Figure 4. PXIe-5842 VST with 54 GHz Frequency Extension Front Panel

IF IN
+15 dBm MAX

ESD
SENSITIVE

CTRL

1

0

IF OUT
+20 dBm REV MAX

ACCESS ACTIVE

12 V
7.0 A MAX

DOWNCONVERTER
LO IN
+20 dBm MAX

UPCONVERTER/
SHARED LO IN
+20 dBm MAX

PXIe-5842
Vector Signal Transceiver

PXIe-5655
Dual RF Synthesizer

PXIe-5563
RF Port Switch

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

ACC

ACTIVE

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

ALL RF PORTS 50Ω

ACC

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

LO 0 OUT

50 MHz to

7.2 GHz

ACTIVE

RF IN/OUT 0

SEE SPECIFICATIONS
FOR MAX PORT POWER

LO 0 OUT

50 MHz to

7.2 GHz

REF OUT

SWITCH IN

REF OUT

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN

+17 dBm

MAX

IF OUT

LO 0 IN

+17 dBm

MAX

PFI 0

LVTTL

SWITCH
OUT

PFI 0

LVTTL

LO OUT
+17 dBm
MAX
REVERSE

CTRL
1.8 V  LVCMOS

RF IN

LO 1 IN

+17 dBm

MAX

IF IN

LO 1 IN

+17 dBm

MAX

LO OUT
+17dBm
MAX
REVERSE

REF IN

ALL RF PORTS 50 Ω

REF IN

PULSE

IN
3.3 V  LVCMOS

OUT

LO IN
+17 dBm
MAX

LO 1 OUT

50 MHz to

7.2 GHz

ESD
SENSITIVE

RF IN/OUT 1

ESD
SENSITIVE

LO 1 OUT

50 MHz to

7.2 GHz

ESD
SENSITIVE

ALL RF PORTS 50 Ω

ESD
SENSITIVE

Note The PXIe-5842 VST with 54 GHz Frequency Extension is a functional
instrument that comprises multiple modules interconnected in the manner
depicted. Refer to the front panels for the individual modules for detailed
information on their connectors.

Related reference:

© National Instruments 35

PXIe-5842 Front Panels and Pinouts

•  Safety Voltages

PXIe-5842 Front Panel and LEDs

Note This information applies to the PXIe-5842 module only.

Figure 5. PXIe-5842 Front Panel

Table 12. PXIe-5842 RF Connector Descriptions

Connector

Connector Type

Description

RF IN

3.5 mm (f)

Input terminal for RF signals

36 ni.com

ACTIVEACCPXIe-5842 Vector Signal TransceiverESDSENSITIVERF INRF OUTREFRF INRF OUTPULSELO OUT+17dBmMAXREVERSELO IN+17 dBmMAXLO IN+17 dBmMAXCTRL1.8 V  LVCMOSDIO5 V MAXMGT100 Ω DIFF5 V MAXPFI 00123OUT2 Vp-pMAXREVERSEIN2.5 Vp-pMAXLO OUT+17 dBmMAXREVERSEINOUT3.3 V  LVCMOSSEE SPECIFICATIONS FORMAX RF IN / OUT POWERALL RF PORTS 50 ΩPXIe-5842 Front Panels and Pinouts

Connector

Connector Type

Description

RF OUT

RF OUT: LO IN

RF OUT: LO OUT

RF IN: LO OUT

RF IN: LO IN

3.5 mm (f)

Output terminal for RF signals

SMA (f)

SMA (f)

SMA (f)

SMA (f)

Intermodule connection only

Output terminal for exporting
the RF OUT LO signal

Output terminal for exporting
the RF IN LO signal

Intermodule connection only

Table 13. PXIe-5842 General Connector Descriptions

Connector

Connector Type

Description

REF: IN

REF: OUT

PFI 0

DIO

MGT

CTRL

SMA (f)

SMA (f)

SMA (f)

Intermodule connection only

Output terminal that can export
a 10 MHz, 100 MHz, or 1 GHz
reference clock

Programmable function digital
I/O (DIO) connector for use with
triggers or events

Mini HDMI

Reserved

iPass+ zHD

Multigigabit transceiver for
streaming functionality; usable
by instruments with the MGT
streaming hardware option

Mini HDMI

Intermodule connection only

PULSE: IN

SMB (m)

PULSE: OUT

SMB (m)

Input for external pulse
modulation source; usable by
instruments with the pulse
modulation hardware option

Output for monitoring the
envelope of pulse modulated
RF signals; usable by
instruments with the pulse
modulation hardware option

© National Instruments 37

Table 14. PXIe-5842 LED Indicators

LED

Indications

PXIe-5842 Front Panels and Pinouts

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail

•  Amber—The module is being accessed;

accessed means that you are writing to the
module setup registers to control the
module, reading from the module to
monitor its status, or transferring data to or
from the module

•  Green—The module is controllable through

the software

Indicates the state of the module.

•  Off—The module is idle
•  Solid green—The module is generating a

waveform

•  Dim amber—The module is waiting for an

acquisition Reference Trigger

•  Solid amber—The module is acquiring a

waveform

•  Solid red—The module has detected an

error; the LED remains red until the error
condition is removed

For example, the module could have
exceeded its operating temperature and
entered thermal shutdown. In this case,
check system airflow and reset the module
in MAX.

Note Indicators are listed in
increasing order of priority. For
example, if you are generating a
waveform using NI-RFSG and waiting

ACCESS

ACTIVE

38 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

on an acquisition Reference Trigger in
NI-RFSA, the LED is dim amber.

PXIe-5842 MGT Connector Pinout

Single MGT connector shown; the PXIe-5842 front panel has four MGT connectors that
have identical pinouts.

Table 15. PXIe-5842 MGT Signal Descriptions

Pin

A1

A2

A3

A4

A5

Signal

Reserved

Reserved

GND

Rx+ 0

Rx- 0

Description

N/A

N/A

Ground reference for signals

Receive channel 0, positive

Receive channel 0, negative

© National Instruments 39

Optical 3.3 VEEPROM 3.3 VGNDTx+ 1Tx– 1GNDTx+ 2Tx– 2GNDD1D2D3D4D5D6D7D8D9Optical 3.3 VGPIOGNDRx+ 1Rx– 1GNDRx+ 2Rx– 2GNDB1B2B3B4B5B6B7B8B9RESERVEDRESERVEDGNDRx+ 0Rx– 0GNDRx+ 3Rx– 3GNDSCLSDAGNDTx+ 0Tx– 0GNDTx+ 3Tx– 3GNDA1A2A3A4A5A6A7A8A9C1C2C3C4C5C6C7C8C9PXIe-5842 Front Panels and Pinouts

Description

Ground reference for signals

Receive channel 3, positive

Receive channel 3, negative

Ground reference for signals

Signal

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

GND

Tx+ 1

Ground reference for signals

Transmit channel 1, positive

Pin

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

D3

D4

40 ni.com

Pin

D5

D6

D7

D8

D9

PXIe-5842 Front Panels and Pinouts

Description

Transmit channel 1, negative

Ground reference for signals

Transmit channel 2, positive

Transmit channel 2, negative

Ground reference for signals

Signal

Tx- 1

GND

Tx+ 2

Tx- 2

GND

PXIe-5842 DIO Connector Pinout

Table 16. PXIe-5842 DIO Signal Descriptions

Pin

19

Signal

GND

Description

Ground reference for signals

© National Instruments 41

GNDGNDGNDGNDGNDGNDGNDGNDNCNCVCCDIO 7DIO 6DIO 5DIO 4DIO 3DIO 2DIO 1DIO 011918171615141312111098765432Pin

Signal

Description

PXIe-5842 Front Panels and Pinouts

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

42 ni.com

PXIe-5655 Front Panel and LEDs

Figure 6. PXIe-5655 with SMA Front Panel

PXIe-5842 Front Panels and Pinouts

Table 17. PXIe-5655 Connector Descriptions

Connector

REF OUT

PFI 0

REF IN

Connector Type

Description

SMA (f)

—

Output terminal that can export
a 100 MHz Reference Clock.

This is reserved and not
enabled for use with the
PXIe-5842.

SMA (f)

Input terminal that allows the

© National Instruments 43

PXIe-5655 Dual RF SynthesizerACTIVEALL RF PORTS 50ΩACCLO 0 OUT50 MHz to7.2 GHzLO 0 IN+17 dBmMAXLO 1 IN+17 dBmMAXLO 1 OUT50 MHz to7.2 GHzESDSENSITIVEPFI 0LVTTLREF INREF OUTConnector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

use of an external Reference
Clock with one of the following
frequencies:

•  10 MHz
•  100 MHz
•  270 MHz
•  3.84 MHz × y, where y is 4,

8, 16, 24, 25, or 32

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

Input terminal that allows the
use of an external local
oscillator.

Input terminal that allows the
use of an external local
oscillator.

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

LO 0 OUT

SMA (f)

LO 0 IN

LO 1 IN

SMA (f)

SMA (f)

LO 1 OUT

SMA (f)

Table 18. PXIe-5655 LED Indicators

LED

Indications

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail.

•  Amber—The module is being accessed.

Accessed means that you are writing to the
device setup registers to control the device,
reading from the device to monitor the
device status, or transferring data to or from
the device.

ACCESS

44 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

•  Green—The module is controllable through

the software.

•  Off—The module is idle or locked to the

requested reference.

•  Solid red—The PLL is unlocked or the

module temperature is out of the specified
operating range.

ACTIVE

PXIe-5563 Front Panel and LEDs

Figure 7. PXIe-5563 Front Panel

PXIe-5563
RF Port Switch

ACC

ACTIVE

RF IN/OUT 0

SEE SPECIFICATIONS
FOR MAX PORT POWER

SWITCH IN

IF OUT

SWITCH
OUT

IF IN

ALL RF PORTS 50 Ω

RF IN/OUT 1

ESD
SENSITIVE

Table 19. PXIe-5563 Front Panel Connectors

Connector

Connector Type

Description

RF IN/OUT 0

SWITCH IN

IF OUT

3.5 mm (f)

3.5 mm (f)

3.5 mm (f)

Bidirectional connector for both
input and output of RF signals

Intermodule connection only

IF output signal to the

© National Instruments 45

Connector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

SWITCH OUT

IF IN

3.5 mm (f)

3.5 mm (f)

RF IN/OUT 1

3.5 mm (f)

RMM-5585 Front Panel and LEDs

Figure 8. RMM-5585 Front Panel

upconverter

Intermodule connection only

IF input signal from the
downconverter

Bidirectional connector for both
input and output of RF signals

RF IN/OUT PORTS

IN

0

OUT

50 Ω
1.85 mm

IN

1

OUT

ESD
SENSITIVE

SEE SPECIFICATIONS FOR
MAX RF IN/OUT POWER

RMM-5585
Remote Measurement Module

Table 20. RMM-5585 Front Panel Connectors

Connector

Connector Type

Description

RF IN/OUT PORTS: 0

1.85 mm (f), 50 Ω

RF IN/OUT PORTS: 1

1.85 mm (f), 50 Ω

Bidirectional connector for both
input and output of RF signals.

Bidirectional connector for both
input and output of RF signals.

Table 21. RMM-5585 Front Panel LED Indicators

LED

Indications

IN 0

OUT 0

IN 1

46 ni.com

Channel 0 is configured for input (acquisition)

Channel 0 is configured for output (generation)

Channel 1 is configured for input (acquisition)

LED

Indications

OUT 1

Channel 1 is configured for output (generation)

PXIe-5842 Front Panels and Pinouts

Note When both indicators of an RF IN/OUT port are off, the port has not
been configured in the NI-RFSA or NI-RFSG API.

RMM-5586 Front Panel and LEDs

Figure 9. RMM-5586 Front Panel

RF IN/OUT PORTS

IN

0

OUT

50 Ω
1.85 mm

IN

1

OUT

ESD
SENSITIVE

SEE SPECIFICATIONS FOR
MAX RF IN/OUT POWER

RMM-5586
Remote Measurement Module

Table 22. RMM-5586 Front Panel Connectors

Connector

Connector Type

Description

RF IN/OUT PORTS: 0

1.85 mm (f), 50 Ω

RF IN/OUT PORTS: 1

1.85 mm (f), 50 Ω

Bidirectional connector for both
input and output of RF signals.

Bidirectional connector for both
input and output of RF signals.

Table 23. RMM-5586 Front Panel LED Indicators

LED

Indications

IN 0

OUT 0

IN 1

OUT 1

Channel 0 is configured for input (acquisition)

Channel 0 is configured for output (generation)

Channel 1 is configured for input (acquisition)

Channel 1 is configured for output (generation)

© National Instruments 47

PXIe-5842 Front Panels and Pinouts

Note When both indicators of an RF IN/OUT port are off, the port has not
been configured in the NI-RFSA or NI-RFSG API.

RMM-5585 Rear Panel and LEDs

Figure 10. RMM-5585 Rear Panel

Table 24. RMM-5585 Rear Panel Connectors

Connector

Connector Type

Description

IF IN

IF OUT

CTRL: 0

CTRL: 1

Power

SMA (f) fixed attenuator

SMA (f) fixed attenuator

Mini HDMI

Mini HDMI

IF input signal to the
upconverter

IF output signal from the
downconverter

Control port input from host

Reserved

MINI-COMBICON

Input for external power supply

DOWNCONVERTER LO IN

3.5 mm (f)

UPCONVERTER/SHARED LO IN

3.5 mm (f)

Local oscillator input for the
downconverter

Local oscillator input for the
upconverter

Table 25. RMM-5585 Rear Panel LED Indicators

LED

Indications

ACCESS

Indicates the basic hardware status of the

48 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

device.

•  Off—The driver software has not yet been
loaded, the device exceeded the approved
operating temperature and thermal
shutdown has occurred, or the device has
detected a problem with a power rail
•  Amber—The device is being accessed;

accessed means that you are writing to the
device setup registers to control the device,
reading from the device to monitor its
status, or transferring data to or from the
device

•  Green—The device is ready to be

programmed by software

Indicates the state of the device.

•  Off—The device is not powered
•  Amber—The device is being configured
•  Green—The device is ready for configuration
•  Red—The device has encountered a
hardware setup error or the device is
exceeding the approved operating
temperature and is in a state of thermal
shutdown

ACTIVE

RMM-5586 Rear Panel and LEDs

Figure 11. RMM-5586 Rear Panel

© National Instruments 49

PXIe-5842 Front Panels and Pinouts

Table 26. RMM-5586 Rear Panel Connectors

Connector

Connector Type

Description

IF IN

IF OUT

CTRL: 0

CTRL: 1

Power

SMA (f) fixed attenuator

SMA (f) fixed attenuator

Mini HDMI

Mini HDMI

IF input signal to the
upconverter

IF output signal from the
downconverter

Control port input from host

Reserved

MINI-COMBICON

Input for external power supply

DOWNCONVERTER LO IN

3.5 mm (f)

UPCONVERTER/SHARED LO IN

3.5 mm (f)

Local oscillator input for the
downconverter

Local oscillator input for the
upconverter

Table 27. RMM-5586 Rear Panel LED Indicators

LED

Indications

Indicates the basic hardware status of the
device.

•  Off—The driver software has not yet been
loaded, the device exceeded the approved
operating temperature and thermal
shutdown has occurred, or the device has
detected a problem with a power rail
•  Amber—The device is being accessed;

accessed means that you are writing to the
device setup registers to control the device,
reading from the device to monitor its
status, or transferring data to or from the
device

•  Green—The device is ready to be

programmed by software

Indicates the state of the device.

•  Off—The device is not powered
•  Amber—The device is being configured
•  Green—The device is ready for configuration
•  Red—The device has encountered a
hardware setup error or the device is

ACCESS

ACTIVE

50 ni.com

PXIe-5842 Front Panels and Pinouts

LED

Indications

exceeding the approved operating
temperature and is in a state of thermal
shutdown

PXIe-5842  VST with
PXIe-5842

VST with S-Parameters

Front Panel
S-Parameters  Front Panel

The PXIe-5842 VST with S-Parameters comprises an interconnected PXIe-5842,
PXIe-5655, and PXIe-5633.

Figure 12. PXIe-5842 VST with S-Parameters Front Panel

PXIe-5842
Vector Signal Transceiver

PXIe-5655
Dual RF Synthesizer

PXIe-5633
VNA

ACC

ACTIVE

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

LO 0 OUT
50 MHz to
7.2 GHz

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF OUT

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN
+17 dBm
MAX

PFI 0
LVTTL

LO OUT
+17 dBm
MAX
REVERSE

CTRL
1.8 V  LVCMOS

RF IN

LO 1 IN
+17 dBm
MAX

LO OUT
+17dBm
MAX
REVERSE

REF IN

PULSE

IN
OUT
3.3 V  LVCMOS

LO IN
+17 dBm
MAX

LO 1 OUT
50 MHz to
7.2 GHz

ACC

ACTIVE

LO IN

LO OUT

REF IN

REF OUT

PFI 0

PFI 1

PORT 1

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF PORTS 50 Ω

ESD
SENSITIVE

© National Instruments 51

PXIe-5842 Front Panels and Pinouts

Note The PXIe-5842 VST with S-Parameters is a functional instrument that
comprises multiple modules interconnected in the manner depicted. Refer to
the front panels for the individual modules for detailed information on their
connectors.

PXIe-5842 Front Panel and LEDs

Note This information applies to the PXIe-5842 module only.

Figure 13. PXIe-5842 Front Panel

52 ni.com

ACTIVEACCPXIe-5842 Vector Signal TransceiverESDSENSITIVERF INRF OUTREFRF INRF OUTPULSELO OUT+17dBmMAXREVERSELO IN+17 dBmMAXLO IN+17 dBmMAXCTRL1.8 V  LVCMOSDIO5 V MAXMGT100 Ω DIFF5 V MAXPFI 00123OUT2 Vp-pMAXREVERSEIN2.5 Vp-pMAXLO OUT+17 dBmMAXREVERSEINOUT3.3 V  LVCMOSSEE SPECIFICATIONS FORMAX RF IN / OUT POWERALL RF PORTS 50 ΩTable 28. PXIe-5842 RF Connector Descriptions

Connector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

RF IN

RF OUT

RF OUT: LO IN

RF OUT: LO OUT

RF IN: LO OUT

RF IN: LO IN

3.5 mm (f)

3.5 mm (f)

SMA (f)

SMA (f)

SMA (f)

SMA (f)

Input terminal for RF signals

Output terminal for RF signals

Intermodule connection only

Output terminal for exporting
the RF OUT LO signal

Output terminal for exporting
the RF IN LO signal

Intermodule connection only

Table 29. PXIe-5842 General Connector Descriptions

Connector

Connector Type

Description

REF: IN

REF: OUT

PFI 0

DIO

MGT

CTRL

SMA (f)

SMA (f)

SMA (f)

Intermodule connection only

Output terminal that can export
a 10 MHz, 100 MHz, or 1 GHz
reference clock

Programmable function digital
I/O (DIO) connector for use with
triggers or events

Mini HDMI

Reserved

iPass+ zHD

Multigigabit transceiver for
streaming functionality; usable
by instruments with the MGT
streaming hardware option

Mini HDMI

Intermodule connection only

PULSE: IN

SMB (m)

PULSE: OUT

SMB (m)

Input for external pulse
modulation source; usable by
instruments with the pulse
modulation hardware option

Output for monitoring the
envelope of pulse modulated
RF signals; usable by
instruments with the pulse

© National Instruments 53

PXIe-5842 Front Panels and Pinouts

Connector

Connector Type

Description

modulation hardware option

Table 30. PXIe-5842 LED Indicators

LED

Indications

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail

•  Amber—The module is being accessed;

accessed means that you are writing to the
module setup registers to control the
module, reading from the module to
monitor its status, or transferring data to or
from the module

•  Green—The module is controllable through

the software

Indicates the state of the module.

•  Off—The module is idle
•  Solid green—The module is generating a

waveform

•  Dim amber—The module is waiting for an

acquisition Reference Trigger

•  Solid amber—The module is acquiring a

waveform

•  Solid red—The module has detected an

error; the LED remains red until the error
condition is removed

For example, the module could have
exceeded its operating temperature and
entered thermal shutdown. In this case,
check system airflow and reset the module
in Hardware Configuration Utility or MAX.

ACCESS

ACTIVE

54 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

Note Indicators are listed in
increasing order of priority. For
example, if you are generating a
waveform using NI-RFSG and waiting
on an acquisition Reference Trigger in
NI-RFSA, the LED is dim amber.

PXIe-5842 MGT Connector Pinout

Single MGT connector shown; the PXIe-5842 front panel has four MGT connectors that
have identical pinouts.

Table 31. PXIe-5842 MGT Signal Descriptions

Pin

A1

A2

Signal

Reserved

Reserved

N/A

N/A

Description

© National Instruments 55

Optical 3.3 VEEPROM 3.3 VGNDTx+ 1Tx– 1GNDTx+ 2Tx– 2GNDD1D2D3D4D5D6D7D8D9Optical 3.3 VGPIOGNDRx+ 1Rx– 1GNDRx+ 2Rx– 2GNDB1B2B3B4B5B6B7B8B9RESERVEDRESERVEDGNDRx+ 0Rx– 0GNDRx+ 3Rx– 3GNDSCLSDAGNDTx+ 0Tx– 0GNDTx+ 3Tx– 3GNDA1A2A3A4A5A6A7A8A9C1C2C3C4C5C6C7C8C9PXIe-5842 Front Panels and Pinouts

Description

Ground reference for signals

Receive channel 0, positive

Receive channel 0, negative

Ground reference for signals

Receive channel 3, positive

Receive channel 3, negative

Ground reference for signals

Signal

GND

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

Pin

A3

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

56 ni.com

Pin

D2

D3

D4

D5

D6

D7

D8

D9

PXIe-5842 Front Panels and Pinouts

Signal

Description

EEPROM 3.3 V

EEPROM power supply

GND

Tx+ 1

Tx- 1

GND

Tx+ 2

Tx- 2

GND

Ground reference for signals

Transmit channel 1, positive

Transmit channel 1, negative

Ground reference for signals

Transmit channel 2, positive

Transmit channel 2, negative

Ground reference for signals

PXIe-5842 DIO Connector Pinout

© National Instruments 57

GNDGNDGNDGNDGNDGNDGNDGNDNCNCVCCDIO 7DIO 6DIO 5DIO 4DIO 3DIO 2DIO 1DIO 011918171615141312111098765432PXIe-5842 Front Panels and Pinouts

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

Table 32. PXIe-5842 DIO Signal Descriptions

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

58 ni.com

PXIe-5655 Front Panel and LEDs

Figure 14. PXIe-5655 with SMA Front Panel

PXIe-5842 Front Panels and Pinouts

Table 33. PXIe-5655 Connector Descriptions

Connector

REF OUT

PFI 0

REF IN

Connector Type

Description

SMA (f)

—

Output terminal that can export
a 100 MHz Reference Clock.

This is reserved and not
enabled for use with the
PXIe-5842.

SMA (f)

Input terminal that allows the

© National Instruments 59

PXIe-5655 Dual RF SynthesizerACTIVEALL RF PORTS 50ΩACCLO 0 OUT50 MHz to7.2 GHzLO 0 IN+17 dBmMAXLO 1 IN+17 dBmMAXLO 1 OUT50 MHz to7.2 GHzESDSENSITIVEPFI 0LVTTLREF INREF OUTConnector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

use of an external Reference
Clock with one of the following
frequencies:

•  10 MHz
•  100 MHz
•  270 MHz
•  3.84 MHz × y, where y is 4,

8, 16, 24, 25, or 32

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

Input terminal that allows the
use of an external local
oscillator.

Input terminal that allows the
use of an external local
oscillator.

Output terminal for the LO
source. This terminal has no
signal at power on and reset.

LO 0 OUT

SMA (f)

LO 0 IN

LO 1 IN

SMA (f)

SMA (f)

LO 1 OUT

SMA (f)

Table 34. PXIe-5655 LED Indicators

LED

Indications

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail.

•  Amber—The module is being accessed.

Accessed means that you are writing to the
device setup registers to control the device,
reading from the device to monitor the
device status, or transferring data to or from
the device.

ACCESS

60 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

•  Green—The module is controllable through

the software.

•  Off—The module is idle or locked to the

requested reference.

•  Solid red—The PLL is unlocked or the

module temperature is out of the specified
operating range.

ACTIVE

PXIe-5633 Front Panel and LEDs

Figure 15. PXIe-5633 Front Panel

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

© National Instruments 61

Table 35. PXIe-5633 Connector Descriptions

Connector

Connector Type

Description

PXIe-5842 Front Panels and Pinouts

PORT 1

3.5 mm (f)

Port 1 for VNA measurements;
input/output terminal for RF
signals for VST measurements
when integrated with VST

Intermodule connection only
(when integrated with VST)

SWITCH IN

IF OUT

3.5 mm (f)

3.5 mm (f)

Reserved

SWITCH OUT

3.5 mm (f)

Intermodule connection only
(when integrated with VST)

IF IN

3.5 mm (f)

Reserved

PORT 2

3.5 mm (f)

Port 2 for VNA measurements;
input/output terminal for RF
signals for VST measurements
when integrated with VST

LO IN

LO OUT

REF IN

REF OUT

PFI 0

PFI 1

MMPX (f)

MMPX (f)

MMPX (f)

MMPX (f)

MMPX (f)

MMPX (f)

Reserved

Reserved

Reserved

Reserved

Reserved

Reserved

Table 36. PXIe-5633 LED Indicators

LED

Indications

Access: Indicates the basic hardware status of
the module.

•  Off—The module is not yet functional or has

detected a problem with a PXI Express
power rail

•  Amber—The module is being accessed;

accessed means that you are writing to the
module setup registers to control the

ACC

62 ni.com

LED

Indications

PXIe-5842 Front Panels and Pinouts

module, reading from the module to
monitor its status, or transferring data to or
from the module

•  Green—The module is controllable through

the software

Indicates the state of the module.

•  Off—The module is idle
•  Dim amber—The module is armed and

waiting for an acquisition trigger

•  Solid green—The module has received an

acquisition trigger and is making a
measurement

•  Solid red—The module has detected an

error; the LED remains red until the error
condition is removed

Error conditions include loss of PLL lock and
thermal shutdown.

Note Indicators are listed in
increasing order of priority.

ACTIVE

© National Instruments 63

PXIe-5842 Front Panels and Pinouts

CAL-5501 Front Panel and LEDs

Figure 16. CAL-5501 Front Panel

PORT A

+24 dBm
±10 VDC
MAX

PORT B

CAL-5501
Vector Calibration Module
50 MHz to 26.5 GHz

Figure 17. CAL-5501 Side Panel

ACCESS

ACTIVE

64 ni.com

PXIe-5842 Front Panels and Pinouts

Table 37. CAL-5501 Connector Descriptions

Connector

Connector Type

Description

PORT A

PORT B

3.5 mm (f)

3.5 mm (f)

Port A for connection with VNA
module

Port B for connection with VNA
module

USB Type B (f)

USB communication and
control

Table 38. CAL-5501 LED Indicators

LED

Indications

ACCESS

ACTIVE

Indicates the basic hardware status of the
module.

•  Off—The module is not yet functional or is

not receiving power

•  Blinking amber—The module is being

accessed over USB; accessed means that
you are writing to the module setup
registers to control the module, reading
from the module to monitor its status, or
transferring data to or from the module
•  Green—The module is controllable through

the software

Indicates the state of the module.

•  Off—The module is not yet functional or is

not receiving power

•  Solid amber—The module is warming up to

prepare for use

•  Solid green—The module is ready for use
•  Solid red—The module has detected an

error; the LED remains red until the error
condition is removed

For example, the module could have
exceeded its operating temperature and

© National Instruments 65

PXIe-5842 Front Panels and Pinouts

LED

Indications

entered thermal shutdown.

66 ni.com

PXIe-5842 Theory of Operation

Theory of Operation
PXIe-5842  Theory of Operation
PXIe-5842

Refer to block diagrams and state models to understand the hardware and software
design behind the PXIe-5842.

Instrument Block Diagrams
PXIe-5842  Instrument Block Diagrams
PXIe-5842

Block diagrams describe the hardware architecture of your instrument and the paths
that signals take through components of the instrument.

Block Diagram
PXIe-5842  VSTVST  Block Diagram
PXIe-5842

The PXIe-5842 VST is a vector signal transceiver instrument that comprises an
interconnected PXIe-5842 and PXIe-5655.

Figure 18. PXIe-5842 VST Block Diagram

RF IN

RF IN: LO OUT

RF OUT:
LO OUT

RF OUT

PFI 0

PULSE: IN

PULSE: OUT

REF: OUT

REF IN

LO 0 IN

LO 1 IN

RF IN: LO IN

RF OUT: LO IN

x1

x1

Direct Sampling
< 1.75 GHz

Low IF Baseband
Signal Conditioning

ADCs

Zero IF Baseband
Signal Conditioning

Zero IF Baseband
Signal Conditioning

Low IF Baseband
Signal Conditioning

DACs

Direct Sampling
< 1.75 GHz

Waveform
Acquisition

Waveform
Generation

Digital Signal
Processing

Module
Control

Pulse
Control

REF: IN

REF OUT

Baseband
Clocks

PXIe-5842

PXIe Ref Clock (100 MHz)

Reference
Clock

OCXO

Calibration
DAC

LO 0 OUT

LO 1 OUT

Synthesizer &
Signal Conditioning

Synthesizer &
Signal Conditioning

VCXO

Module
Control

PXIe-5655

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

© National Instruments 67

PXIe-5842 Theory of Operation

Note Additional signal paths related to self-calibration not shown.

LO Path

The PXIe-5842 has two tunable local oscillators (LO) for the RF input and RF output
signal paths via the PXIe-5655.

The PXIe-5842 module has no onboard frequency synthesizer; instead, it derives the
LOs from the associated PXIe-5655.

Signal Distribution and LO Source Selection

The LO source is distributed to the downconverter or upconverter and the LO output
signal path through the Signal Distribution. Refer to the Local Oscillators topic for
more information about using an external LO with the LO IN front panel connector.

LO Out Signal Path

The PXIe-5842 supports the export of the LO IN signal to the LO OUT front panel
connector. The LO output signal path is exported from LO IN through a programmable
gain stage.

PXIe-5842  VST with
PXIe-5842
Diagram
Diagram

VST with 54 GHz

54 GHz  Frequency Extension

Block
Frequency Extension  Block

The PXIe-5842 VST with 54 GHz Frequency Extension is a vector signal transceiver
instrument that comprises multiple PXI Express modules: the PXIe-5842, PXIe-5655
(×2), and PXIe-5563. Additionally, the PXIe-5842 VST with 54 GHz Frequency Extension
uses either the RMM-5585 or RMM-5586 remote measurement device for
millimeterwave frequency coverage.

68 ni.com

Figure 19. PXIe-5842 VST with 54 GHz Frequency Extension Block Diagram

UPCONVERTER/SHARED LO IN

×N

×N

REF IN

LO 0 IN

REF OUT

PXIe Ref Clock (100 MHz)

Reference
Clock

OCXO

Calibration
DAC

PXIe-5842 Theory of Operation

RF IN/OUT 1

RF IN/OUT 0

LO 0 OUT

LO 1 OUT

Synthesizer &
Signal Conditioning

Synthesizer &
Signal Conditioning

VCXO

×N

×N

LO 1 IN

DOWNCONVERTER LO IN

RF IN/OUT 0

RF IN/OUT 1

IF IN

IF OUT

RMM-5585/RMM-5586

IF OUT

SWITCH IN

IF IN

SWITCH OUT

Module
Control

PXIe-5655

Module
Control

PXIe-5563

Waveform
Acquisition

Waveform
Generation

Digital Signal
Processing

Module
Control

Pulse
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

RF IN

RF OUT

PFI 0

PULSE: IN

PULSE: OUT

REF: OUT

LO 0 IN

LO 1 IN

RF IN: LO OUT

RF IN: LO IN

RF OUT: LO IN

RF OUT: LO OUT

×N

×N

Direct Sampling
< 1.75 GHz

Low IF Baseband
Signal Conditioning

ADCs

Zero IF Baseband
Signal Conditioning

Zero IF Baseband
Signal Conditioning

Low IF Baseband
Signal Conditioning

Direct Sampling
< 1.75 GHz

DACs

REF: IN

REF OUT

REF IN

LO 0 OUT

LO 1 OUT

Synthesizer &
Signal Conditioning

Synthesizer &
Signal Conditioning

Baseband
Clocks

PXIe-5842

PXIe Ref Clock (100 MHz)

Reference
Clock

VCXO

OCXO

Calibration
DAC

Module
Control

PXIe-5655

Note Additional signal paths related to self-calibration and some front panel
connectors not shown.

RMM-5585/RMM-5586 Port Configuration

The RMM-5585/RMM-5586 is a super-heterodyne converter with independent LOs for
signal generation and analysis, with the option to use a common LO programmatically.
The RMM-5585/RMM-5586 includes two full-duplex direct RF ports. You can use the
NI-RFSA and NI-RFSG drivers to perform, respectively, analysis and generation on
these RF ports simultaneously.

The one-meter cables included with the PXIe-5842 VST with 54 GHz Frequency
Extension that connect the RMM-5585/RMM-5586 to the in-chassis PXI modules of the
instrument allow the high-frequency ports to be positioned close to the DUT to
minimize loss between the DUT and the test system. Additionally, the RF ports within
the PXIe-5842 VST with 54 GHz Frequency Extension, which reside on the
RMM-5585/RMM-5586 and PXIe-5563 modules, have variable reference levels that
support a wide range of power levels. Finally, the RMM-5585/RMM-5586 and PXIe-5563
contain internal loopback paths at millimeterwave and IF frequencies, respectively, to

© National Instruments 69

PXIe-5842 Theory of Operation

facilitate self-calibration and improve measurement performance.

Operation Across Frequency Range

The PXIe-5842 VST with 54 GHz Frequency Extension has a frequency range for signal
generation and analysis of 30 MHz to 54 GHz. Different physical modules within the
overall instrument provide different frequency coverage across that comprehensive
range.

In the PXIe-5842 VST with 54 GHz Frequency Extension, the PXIe-5563 RF port switch
conveys signals to and from the PXIe-5842 VST module to the two RF ports,
RF IN/OUT 0/1, for frequency coverage of 30 MHz to 26.5 GHz. The RF IN/OUT PORTS of
the RMM-5585/RMM-5586 convey signals of 23.5 GHz to 54 GHz for coverage into the
millimeter wave range.

The direction for each of these ports—in or out for analysis or generation,
respectively—is software-configurable. You can use one port for analysis and another
for generation simultaneously.

Tip The best isolation for simultaneous analysis and generation is achieved
when Port 1 is used for generation and Port 0 is used for analysis. This is only
applicable to the ports of the RMM-5585/RMM-5586.

RMM-5585/RMM-5586 LO Operation

By default, the RMM-5585/RMM-5586 uses separate LO signals, both of which are
sourced from a single PXIe-5655 within the overall PXIe-5842 VST with 54 GHz
Frequency Extension, for the upconverter and downconverter. The PXIe-5655 that
sources this LO is referred to as LO1 and is associated in MAX or Hardware
Configuration Utility. When using this default dual LO configuration, the
RMM-5585/RMM-5586 can also accommodate independent frequencies on both LO
signals to support frequency division duplexing (FDD), which requires different uplink
and downlink frequencies.

Additionally, you can use an optional shared LO configuration, in which a single LO
from the associated PXIe-5655 is routed through a single port on the
RMM-5585/RMM-5586 to both RF ports. Using a shared LO can reduce phase noise for
some measurements.

70 ni.com

PXIe-5842 Theory of Operation

Local Oscillators

The PXIe-5842 VST with 54 GHz Frequency Extension contains two stages of local
oscillators (LOs) for analyzing and generating RF signals.

•  LO2—Mixed within the leftmost PXIe-5655 with the I/Q signals from the PXIe-5842

module to analyze or generate IF signals of frequency between 30 MHz and
26.5 GHz. You can use this IF signal to analyze or generate RF signals from the
RF IN/OUT bidirectional ports on the front panel of the PXIe-5563 module within
the instrument.

•  LO1—The IF signal and LO1 from the rightmost PXIe-5655 mix within the RMM-5585
or RMM-5586 to analyze or generate RF signals of frequency between 23.5 GHz and
54 GHz. You can use this RF signal to analyze or generate RF signals from the
RF IN/OUT bi-directional ports on the RMM-5585 or RMM-5586 front panel.

PXIe-5842  VST with
PXIe-5842

VST with S-Parameters

Block Diagram
S-Parameters  Block Diagram

The PXIe-5842 VST with S-Parameters is a vector signal transceiver instrument that
comprises an interconnected PXIe-5842, PXIe-5655, and PXIe-5633.

© National Instruments 71

Figure 20. PXIe-5842 VST with S-Parameters Block Diagram

PXIe-5842 Theory of Operation

RF IN

RF IN: LO OUT

RF OUT:
LO OUT

RF OUT

PFI 0

PULSE: IN

PULSE: OUT

REF: OUT

REF IN

LO 0 IN

LO 1 IN

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

RF IN: LO IN

RF OUT: LO IN

x1

x1

Direct Sampling
< 1.75 GHz

Low IF Baseband
Signal Conditioning

ADCs

Zero IF Baseband
Signal Conditioning

Zero IF Baseband
Signal Conditioning

Low IF Baseband
Signal Conditioning

DACs

Direct Sampling
< 1.75 GHz

Waveform
Acquisition

Waveform
Generation

Digital Signal
Processing

Module
Control

Pulse
Control

REF: IN

REF OUT

Baseband
Clocks

PXIe-5842

PXIe Ref Clock (100 MHz)

Reference
Clock

OCXO

Calibration
DAC

LO 0 OUT

LO 1 OUT

Synthesizer &
Signal Conditioning

Synthesizer &
Signal Conditioning

VCXO

Reference
Clock

LO
Generation

Module
Control

PXIe-5655

PXIe Ref Clock (100 MHz)

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

SWITCH IN

SWITCH OUT

ADC

ADC

LO

ADC

ADC

Transfer
Switch

Source

Waveform
Acquisition

Digital Signal
Processing

Module
Control

PXIe-5633

72 ni.com

PXIe-5842 Theory of Operation

Note Additional signal paths related to self-calibration not shown.

PCI Express Interface
PCI Express Interface

The PXIe-5842 has a PCI Express (up to Gen3 x8) backplane connection, which is used
for programmed I/O, DMA transfers, and peer-to-peer streaming.

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

The NI-RFSA programming model for vector signal analyzers has eight main states. The
analysis functionality of vector signal analyzers also has eight main states. The state of
the instrument at a given time affects the actions you can take during that time.

These states are as follows:

•  Idle
•  Wait for Start Trigger
•  Minimum Pre-Reference Trigger Sampling
•  Wait for Reference Trigger while Sampling
•  Post-Reference Trigger Sampling
•  Record Complete
•  Wait for Advance Trigger
•  Done

The following diagram depicts the state model for the PXIe-5842 when programmed

© National Instruments 73

with NI-RFSA software. This state diagram models the instrument when it acquires
data in the I/Q mode.

PXIe-5842 Theory of Operation

Figure 21. NI-RFSA State Model

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

Ready  for
Reference
Event

Reference
Trigger

•  Blue—State transitions always caused by software
•  Black—State transitions caused by the internal state machine of the instrument
•  Red—Output signals
•  Orange—User-configurable state transitions caused by software or hardware

The major state definitons are the following:

•  Idle—The instrument is not sampling a waveform. All the session properties are
programmable in this state. In this state, the system may not have applied the
properties to the hardware yet. Therefore, the hardware configuration of the
module may not match values of the properties in the session. In addition, the
instrument remains configured in the same committed state as the last session.

74 ni.com

PXIe-5842 Theory of Operation

When you call Initiate, the system programs all the properties to the hardware. If
you recently reset the computer, the instrument is in the Idle state.

•  Wait for Start Trigger—The instrument transitions to this state when you initiate
an acquisition. If you configure the Start Trigger source as None, the instrument
immediately transitions from this state and generates a Start Trigger. When you
configure the Start Trigger source to a software or hardware trigger, the instrument
remains in the original state. The instrument transitions only after the specified
trigger occurs. When a trigger condition occurs, transition occurs on the next clock
cycle and generates a Start Trigger. The default Start Trigger source is None.
•  Minimum Pre-Reference Trigger Sampling—The instrument can transition into
this state two ways: receiving the Start Trigger from the Start Trigger source or
receiving the Advance trigger from the Advance trigger source. The transition into
this state depends on the previous state of the instrument. While in this state, the
instrument samples according to the session attributes configured. The module
remains in this state until it satisfies three conditions:

•  the minimum Pre-Reference trigger sampling completes,
•  the time-to-digital converter (TDC) is ready,
•  the trigger-to-trigger delay has expired.

The first time through this state, the trigger-to-trigger delay does not have an
effect. When the three conditions are satisfied, the instrument transitions from this
state on the next clock cycle. Use the Pretrigger Samples property to specify the
number of samples to be acquired before receiving the Reference Trigger.

•  Wait for Reference Trigger while Sampling—The instrument transitions into this
state after the instrument finishes the Minimum Pre-Reference Trigger Sampling
state. After configuration, the instrument stays in this state until the selected
software or hardware trigger from an available source occurs. When the
instrument recognizes a trigger condition, the instrument transitions from this
state. The default Reference Trigger source is None.

•  Post-Reference Trigger Sampling—After the instrument receives the Reference

Trigger, the instrument transitions into this state. The instrument begins sampling
Post-Reference Trigger samples according to the properties configured for the
session. When the Post-Reference Trigger sampling completes, the instrument
transitions from this state.

•  Record Complete—the instrument transitions into this state After it completes

Post-Reference trigger sampling state. The instrument leaves this state after storing
the current record in the onboard memory. Upon leaving this state, the instrument
generates an End of Record Event.

© National Instruments 75

PXIe-5842 Theory of Operation

•  Wait for Advance Trigger—The instrument transitions into this state after is has

completed a record and determines that there are still more records to complete. If
you configure the Advance Trigger source as None, the instrument transitions from
this state on the next clock edge. When you configure the Advance Trigger source
as a software or hardware trigger from one of the available sources, the instrument
remains in this state until the trigger occurs. When the instrument recognizes a
trigger condition, the instrument transitions from this state. The default Advance
Trigger source is None.

•  Done—After the instrument completes a record and determines that all the records

are done, it transitions into this temporary state. Upon entering this state, the
instrument generates the End of Acquisition Event. The software transitions the
instrument from this state and back to the Idle state. In the Idle state, you can call
either a Fetch function or NI-RFSA Check Acquisition Status.

State Model
NI-RFSG  State Model
NI-RFSG

The NI-RFSG programming model for vector signal generators and the generation
functionality of vector signal transceivers has three main states. The state of the
instrument at a given time affects the actions you can take during that time.

These states are Configuration (idle), Committed, and Generation (running).

The following diagram depicts the state model for the PXIe-5842 when programmed
with NI-RFSG software.

Figure 22. NI-RFSG State Model

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

76 ni.com

PXIe-5842 Theory of Operation

The major states are defined as follows.

•  Configuration—You can program all session properties in the Configuration state;
however, properties are not yet applied to the instrument in this state. Therefore,
the actual instrument configuration may not match the values of the properties in
the session. The NI-RFSG instrument does not generate a signal in the
Configuration state.

Note When you read a property, NI-RFSG may analyze many properties
in the current configuration in order to return the coerced value for that
property or attribute. In general, avoid reading any properties until you
have finished changing all the properties you would like to change.
Otherwise, you may encounter errors if a property is read while the
configuration is in an inconsistent state.

•  Committed—Calling NI-RFSG Commit from the Configuration state performs the

following actions:

•  Verifies the settings of all properties
•  Validates the specified configuration
•  Writes all settings to the hardware modules
•  Writes the waveform to the instrument onboard memory
•  Transitions to the Committed state

If any properties are changed while in the Committed state, the session implicitly
transitions back to the Configuration state and the hardware configuration reflects
the previously committed properties or attributes.

•  Generation—The instrument is either waiting on a trigger or is generating a signal.
In the Generation state, session properties always reflect the current state of the
instrument.

Note You can call NI-RFSG Close from any state. Calling Close stops signal
generation.

© National Instruments 77

Finding Examples for the PXIe-5842

PXIe-5842
Finding Examples for the PXIe-5842
Finding Examples for the

The PXIe-5842 user manual uses examples to guide you through step-by-step
instructions for basic operation of the PXIe-5842 in G (LabVIEW), C/C++, and Visual C#
or Visual Basic .NET. For examples of specialty applications, optimizations, and other
customizations, browse the locations where examples are stored.

Access examples depending on your programming environment and the driver API(s)
you want to use to control your instrument:

Programming Environment

Description

LabVIEW, LabWindows™/CVI

Use the Example Finder:

a.  Launch the programming environment.
b.  Select Help » Find Examples to open the NI

Example Finder.

c.  Navigate to Hardware Input and Output »

Modular Instruments.

d.  Open the example that best matches your

application requirements.

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
directory

•  <Personality> is the directory of your

RFmx personality

78 ni.com

Finding Examples for the PXIe-5842

You can also find examples for your driver API at Start » National Instruments » Driver
Name Examples.

RF API Locations
RF API Locations

Access the API to program your instrument, depending on your application
development environment and RF driver.

Table 39. API Location for RFmx

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

Use the header files located in the
<NIDir>\Shared\
ExternalCompilerSupport\C\include
directory and import library files located in one
of the following directories:

•  32-bit installation—<NIDir>\Shared\
ExternalCompilerSupport\C\
lib32\msvc

•  64-bit installation—<NIDir>\Shared\
ExternalCompilerSupport\C\
lib64\msvc

where <NIDir> is the following location:

Program Files (x86)\National
Instruments.

© National Instruments 79

Finding Examples for the PXIe-5842

API Location

For the location of .NET class libraries, refer to
the installed RFmx readme.

ADE

Microsoft .NET

Table 40. API Location for NI-RFSA

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

Use the NI-RFSA .NET class library by adding a reference to
NationalInstruments.ModularInstruments.NIRfsa.Fx40
or
NationalInstruments.ModularInstruments.NIRfsa.Fx45
and any dependent class libraries from within the Solution Explorer in
Visual Studio.

ADE

LabVIEW

LabWindows/CVI

Microsoft Visual C/C++

Microsoft .NET

80 ni.com

Finding Examples for the PXIe-5842

Table 41. API Location for NI-RFSG

ADE

LabVIEW

API Location

Available on the LabVIEW Functions palette at
Measurement I/O » NI-RFSG.

LabWindows/CVI

Microsoft Visual C/C++

Microsoft .NET

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

Use the NI-RFSG .NET class library by adding a
reference to
NationalInstruments.ModularInstruments
.NIRfsg.Fx40 or
NationalInstruments.ModularInstruments
.NIRfsg.Fx45 and any dependent class libraries
from within the Solution Explorer in Visual Studio.

© National Instruments 81

Contents of the PXIe-5842 Package

Contents of the PXIe-5842
Contents of the

Package
PXIe-5842  Package

Consult the package contents for your instrument to confirm that all items that should
be included in the kit for your instrument are included.

Package Contents
PXIe-5842  VSTVST  Package Contents
PXIe-5842

Shipping kit part number: see PXIe-5842 Configuration Guide

•  PXIe-5842
•  PXIe-5655
•  Cables

Cable Type

Part Number

Quantity

Semi-rigid cable, PXIe-5842
REF: IN to PXIe-5655 REF OUT,
2.92 mm to 2.92 mm

136103A-01

Semi-rigid cable, PXIe-5842
RF OUT: LO IN to PXIe-5655
LO 0 OUT, 2.92 mm to
2.92 mm

Semi-rigid cable, PXIe-5842
RF IN: LO IN to PXIe-5655
LO 1 OUT, 2.92 mm to
2.92 mm

136104A-01

136106A-01

1

1

1

•  SMA driver bit (for use with preset 100 N · cm torque screwdriver, NI part number

780487-01, not included)

•  Phillips screwdriver
•  PXIe-5842 Safety, Environmental, and Regulatory Information
•  PXIe-5655 Safety, Environmental, and Regulatory Information

Related information:

•  PXIe-5842 Hardware Option and Shipping Kit Mapping

82 ni.com

Contents of the PXIe-5842 Package

PXIe-5842  VST with
PXIe-5842
Package Contents
Package Contents

VST with 54 GHz

Frequency Extension
54 GHz  Frequency Extension

Export controlled PXIe-5842 VST with 54 GHz Frequency Extension

Shipping kit part number: 788566-02

•  PXIe-5842
•  PXIe-5655 (×2)
•  PXIe-5563
•  RMM-5585
•  AC power supply adapter for RMM-5585
•  Cables

Cable Type

Part Number

Length

Quantity

Semi-rigid cable,
PXIe-5842 REF: IN to
PXIe-5655 REF OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF OUT: LO IN
to PXIe-5655 LO 0 OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF IN: LO IN to
PXIe-5655 LO 1 OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF IN to
PXIe-5563 SWITCH OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF OUT to
PXIe-5563 SWITCH IN,
2.92 mm to 2.92 mm

136103A-01

136104A-01

136106A-01

137924A-01

137925A-01

Flexible cable, PXIe-5655
(left) REF IN to PXIe-5655

190412B-04

N/A

N/A

N/A

N/A

N/A

N/A

1

1

1

1

1

1

© National Instruments 83

Cable Type

Part Number

Length

Quantity

Contents of the PXIe-5842 Package

(right) REF OUT, SMA to
SMA

3.5 mm (m)-to-3.5 mm (m)
cable

137446A-01

Mini HDMI-to-Mini HDMI
cable

143045A-01

1 m

1 m

4

1

•  SMA driver bit (for use with preset 100 N · cm torque screwdriver, NI part number

780487-01, not included)

•  Phillips screwdriver
•  PXIe-5842 Safety, Environmental, and Regulatory Information
•  PXIe-5655 Safety, Environmental, and Regulatory Information
•  PXIe-5563 Safety, Environmental, and Regulatory Information
•  RMM-5585/RMM-5586 Safety, Environmental, and Regulatory Information

Non-export controlled PXIe-5842 VST with 54 GHz Frequency Extension

Shipping kit part number: 789600-54211

•  PXIe-5842
•  PXIe-5655 (×2)
•  PXIe-5563
•  RMM-5586
•  AC power supply adapter for RMM-5586
•  Cables

Cable Type

Part Number

Length

Quantity

Semi-rigid cable,
PXIe-5842 REF: IN to
PXIe-5655 REF OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF OUT: LO IN
to PXIe-5655 LO 0 OUT,
2.92 mm to 2.92 mm

136103A-01

136104A-01

N/A

N/A

1

1

84 ni.com

Cable Type

Part Number

Length

Quantity

Contents of the PXIe-5842 Package

Semi-rigid cable,
PXIe-5842 RF IN: LO IN to
PXIe-5655 LO 1 OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF IN to
PXIe-5563 SWITCH OUT,
2.92 mm to 2.92 mm

Semi-rigid cable,
PXIe-5842 RF OUT to
PXIe-5563 SWITCH IN,
2.92 mm to 2.92 mm

Flexible cable, PXIe-5655
(left) REF IN to PXIe-5655
(right) REF OUT, SMA to
SMA

136106A-01

137924A-01

137925A-01

190412B-04

3.5 mm (m)-to-3.5 mm (m)
cable

137446A-01

Mini HDMI-to-Mini HDMI
cable

143045A-01

N/A

N/A

N/A

N/A

1 m

1 m

1

1

1

1

4

1

•  SMA driver bit (for use with preset 100 N · cm torque screwdriver, NI part number

780487-01, not included)

•  Phillips screwdriver
•  PXIe-5842 Safety, Environmental, and Regulatory Information
•  PXIe-5655 Safety, Environmental, and Regulatory Information
•  PXIe-5563 Safety, Environmental, and Regulatory Information
•  RMM-5585/RMM-5586 Safety, Environmental, and Regulatory Information

PXIe-5842  VST with
PXIe-5842

VST with S-Parameters

Package Contents
S-Parameters  Package Contents

•  PXIe-5842
•  PXIe-5655
•  PXIe-5633
•  Cables

© National Instruments 85

Cable Type

Part Number

Quantity

Contents of the PXIe-5842 Package

Semi-rigid cable, PXIe-5842
REF: IN to PXIe-5655 REF OUT,
2.92 mm to 2.92 mm

136103A-01

Semi-rigid cable, PXIe-5842
RF OUT: LO IN to PXIe-5655
LO 0 OUT, 2.92 mm to
2.92 mm

Semi-rigid cable, PXIe-5842
RF IN: LO IN to PXIe-5655
LO 1 OUT, 2.92 mm to
2.92 mm

Semi-rigid cable, PXIe-5842
RF IN to PXIe-5633
SWITCH OUT, 2.92 mm to
2.92 mm

Semi-rigid cable, PXIe-5842
RF OUT to PXIe-5633
SWITCH IN, 2.92 mm to
2.92 mm

136104A-01

136106A-01

138775A-01

138774A-01

1

1

1

1

1

•  SMA driver bit (for use with preset 100 N · cm torque screwdriver, NI part number

780487-01, not included)

•  Phillips screwdriver
•  PXIe-5842 Safety, Environmental, and Regulatory Information
•  PXIe-5655 Safety, Environmental, and Regulatory Information
•  PXIe-5633 Safety, Environmental, and Regulatory Information

Related information:

•  PXIe-5842 Hardware Option and Shipping Kit Mapping

Package Contents
CAL-5501  Package Contents
CAL-5501

Shipping kit part number: 788189-01

•  Wooden case

86 ni.com

Contents of the PXIe-5842 Package

•  CAL-5501
•  Torque wrench, NI part number 751120-01
•  Locking USB cable, 2 m, NI part number 198506D-02
•  Documentation

Your CAL-5501 kit also includes one of the following calibration certificates based on
the type of mandatory calibration purchased with the accessory:

•  Traceable calibration (960380-01)
•  Compliant calibration (960380-03)
•  ISO 17025 accredited calibration (960380-04)

© National Instruments 87

PXIe-5842 Safety Guidelines

Safety Guidelines
PXIe-5842  Safety Guidelines
PXIe-5842

Follow these guidelines to use the PXIe-5842 safely.

Guidelines apply to all PXIe-5842 instruments unless otherwise noted.

You can view product certifications and declarations at ni.com/product-certifications.

Important For comprehensive safety information, refer to the safety,
environmental, and regulatory information document that shipped with your
hardware.

Caution Observe all instructions and cautions in the user documentation.
Using the product in a manner not specified can damage the product and
compromise the built-in safety protection.

For the PXIe-5842 VST with 54 GHz Frequency Extension, comply with the following
guideline for the RMM-5585 or RMM-5586:

Caution Product installation must adequately protect users' eyes from
exposure to millimeter wave radiation output and input signals from the
transmitter and receiver.

Safety Voltages
Safety Voltages

Note Consult the safety voltages for each module within your PXIe-5842
instrument to understand the aggregate safety voltage information for the
instrument.

Notice The use of some ports is reserved. Make connections to the ports of
your PXIe-5842 instrument only as indicated in the PXIe-5842 User Manual.

88 ni.com

PXIe-5842 Safety Guidelines

PXIe-5842 Safety Voltages

Note This section applies to the PXIe-5842 module.

Table 42. Safety Voltages

RF IN absolute maximum input power

+27 dBm with reference level >20 dBm

RF OUT <0,1> absolute maximum reverse
power

+20 dBm

RF OUT: LO IN absolute maximum input power  +15 dBm

RF OUT: LO OUT absolute maximum reverse
power

+10 dBm

RF IN: LO IN absolute maximum input power

+15 dBm

RF IN: LO OUT absolute maximum reverse
power

+10 dBm

REF: IN maximum input voltage

•  Frequency ≥10 MHz: 5 V pk-pk
•  Frequency <10 MHz: 2 V pk-pk

REF: OUT absolute maximum reverse voltage

2 V pk-pk

PFI 0 absolute maximum input range

-0.5 V to 5 V

-0.5 V to 5 V

DIO absolute maximum input range

Notice The DIO port is not an HDMI
interface. Do not connect the DIO port
on the to the HDMI interface of
another device. NI is not liable for any
damage resulting from such signal
connections.

MGT absolute maximum input range

•  ≤6.6 Gbps: 150 mV pk-pk to 2 V pk-pk
•  >6.6 Gbps: 150 mV pk-pk to 1.25 V pk-pk

CTRL absolute maximum input

1.8 V

© National Instruments 89

PXIe-5842 Safety Guidelines

Notice The CTRL port is not an HDMI
interface. Do not connect the CTRL
port on the to the HDMI interface of
another device. NI is not liable for any
damage resulting from such signal
connections.

PULSE: IN, PULSE: OUT absolute maximum
input

Measurement Category

5 V

CAT I/O

Measurement Category

Caution Do not connect the product to signals or use for measurements
within Measurement Categories II, III, or IV.

Attention Ne pas connecter le produit à des signaux dans les catégories de
mesure II, III ou IV et ne pas l'utiliser pour effectuer des mesures dans ces
catégories.

Warning Do not connect the product to signals or use for measurements
within Measurement Categories II, III, or IV, or for measurements on MAINs
circuits or on circuits derived from Overvoltage Category II, III, or IV which
may have transient overvoltages above what the product can withstand. The
product must not be connected to circuits that have a maximum voltage
above the continuous working voltage, relative to earth or to other channels,
or this could damage and defeat the insulation. The product can only
withstand transients up to the transient overvoltage rating without
breakdown or damage to the insulation. An analysis of the working voltages,
loop impedances, temporary overvoltages, and transient overvoltages in the
system must be conducted prior to making measurements.

Mise en garde Ne pas connecter le produit à des signaux dans les
catégories de mesure II, III ou IV et ne pas l'utiliser pour des mesures dans ces

90 ni.com

PXIe-5842 Safety Guidelines

catégories, ou des mesures sur secteur ou sur des circuits dérivés de
surtensions de catégorie II, III ou IV pouvant présenter des surtensions
transitoires supérieures à ce que le produit peut supporter. Le produit ne doit
pas être raccordé à des circuits ayant une tension maximale supérieure à la
tension de fonctionnement continu, par rapport à la terre ou à d'autres voies,
sous peine d'endommager et de compromettre l'isolation. Le produit peut
tomber en panne et son isolation risque d'être endommagée si les tensions
transitoires dépassent la surtension transitoire nominale. Une analyse des
tensions de fonctionnement, des impédances de boucle, des surtensions
temporaires et des surtensions transitoires dans le système doit être
effectuée avant de procéder à des mesures.

Measurement Category I is for measurements performed on circuits not directly
connected to the electrical distribution system referred to as MAINS voltage. MAINS is a
hazardous live electrical supply system that powers equipment. This category is for
measurements of voltages from specially protected secondary circuits. Such voltage
measurements include signal levels, special equipment, limited-energy parts of
equipment, circuits powered by regulated low-voltage sources, and electronics.

Note Measurement Categories CAT I and CAT O are equivalent. These test
and measurement circuits are for other circuits not intended for direct
connection to the MAINS building installations of Measurement Categories
CAT II, CAT III, or CAT IV.

PXIe-5655 Safety Voltages

Connect only voltages that are below these limits.

Table 43. Safety Voltages

Absolute maximum input power (LO 0/1 IN)

+17 dBm

Absolute maximum reverse power (LO 0/1 OUT)  +18 dBm

Maximum input voltage (REF IN)

Measurement Category

3.3 V pk-pk

CAT I/O

© National Instruments 91

Measurement Category

PXIe-5842 Safety Guidelines

Warning Do not connect the product to signals or use for measurements
within Measurement Categories II, III, or IV, or for measurements on MAINs
circuits or on circuits derived from Overvoltage Category II, III, or IV which
may have transient overvoltages above what the product can withstand. The
product must not be connected to circuits that have a maximum voltage
above the continuous working voltage, relative to earth or to other channels,
or this could damage and defeat the insulation. The product can only
withstand transients up to the transient overvoltage rating without
breakdown or damage to the insulation. An analysis of the working voltages,
loop impedances, temporary overvoltages, and transient overvoltages in the
system must be conducted prior to making measurements.

Mise en garde Ne pas connecter le produit à des signaux dans les
catégories de mesure II, III ou IV et ne pas l'utiliser pour des mesures dans ces
catégories, ou des mesures sur secteur ou sur des circuits dérivés de
surtensions de catégorie II, III ou IV pouvant présenter des surtensions
transitoires supérieures à ce que le produit peut supporter. Le produit ne doit
pas être raccordé à des circuits ayant une tension maximale supérieure à la
tension de fonctionnement continu, par rapport à la terre ou à d'autres voies,
sous peine d'endommager et de compromettre l'isolation. Le produit peut
tomber en panne et son isolation risque d'être endommagée si les tensions
transitoires dépassent la surtension transitoire nominale. Une analyse des
tensions de fonctionnement, des impédances de boucle, des surtensions
temporaires et des surtensions transitoires dans le système doit être
effectuée avant de procéder à des mesures.

Measurement Category I is for measurements performed on circuits not directly
connected to the electrical distribution system referred to as MAINS voltage. MAINS is a
hazardous live electrical supply system that powers equipment. This category is for
measurements of voltages from specially protected secondary circuits. Such voltage
measurements include signal levels, special equipment, limited-energy parts of
equipment, circuits powered by regulated low-voltage sources, and electronics.

92 ni.com

PXIe-5842 Safety Guidelines

Note Measurement Categories CAT I and CAT O are equivalent. These test
and measurement circuits are for other circuits not intended for direct
connection to the MAINS building installations of Measurement Categories
CAT II, CAT III, or CAT IV.

PXIe-5563 Safety Voltages

Connect only voltages that are below these limits.

Absolute maximum input power (SWITCH IN)

Absolute maximum reverse power (SWITCH OUT)

Absolute maximum input power (IF IN)

Absolute maximum reverse power (IF OUT)

Absolute maximum input power (RF IN/OUT 0/1)

Absolute maximum reverse power (RF IN/OUT 0/1)

RMM-5585 Safety Voltages

Connect only voltages that are below these limits.

Front Panel Maximum Power

RF IN maximum power

+20 dBm

+18 dBm

+20 dBm

+20 dBm

+20 dBm

+20 dBm

© National Instruments 93

Reference Level > +18 dBm

Reference Level ≤ +18 dBm

PXIe-5842 Safety Guidelines

+27 dBm

+20 dBm

RF OUT maximum reverse power

+23 dBm

+15 dBm

+20 dBm

+20 dBm

+20 dBm

Rear Panel Maximum Power

IF IN maximum power

IF OUT maximum reverse power

DOWNCONVERTER LO IN maximum power

UPCONVERTER/SHARED LO IN maximum power

DC power input

DC voltage

DC current

12.0 V DC

7 A

RMM-5586 Safety Voltages

Connect only voltages that are below these limits.

94 ni.com

Front Panel Maximum Power

RF IN maximum power

Reference Level > +18 dBm

Reference Level ≤ +18 dBm

PXIe-5842 Safety Guidelines

+27 dBm

+20 dBm

RF OUT maximum reverse power

+23 dBm

Rear Panel Maximum Power

IF IN maximum power

IF OUT maximum reverse power

DOWNCONVERTER LO IN maximum power

UPCONVERTER/SHARED LO IN maximum power

DC power input

DC voltage

DC current

12.0 V DC

7 A

PXIe-5633 Safety Voltages

Connect only voltages that are below these limits.

+15 dBm

+20 dBm

+20 dBm

+20 dBm

© National Instruments 95

PORT 1, PORT 2

Table 44. Absolute Maximum Input Power for VST Passthrough* When Operating as Vector Signal
Analyzer

PXIe-5842 Safety Guidelines

*When used within PXIe-5842 VST with S-Parameters.

Reference Level ≤ 20 dBm

Reference Level + 5 dB

Table 45. Reference Level > 20 dBm

Note Derate by 2 dB when source match is worse than -6 dB.

0.3 GHz to 2 GHz

>2 GHz to 8 GHz

>8 GHz to 26.5 GHz

+25 dBm (CW RMS)

+26 dBm (CW RMS)

+27 dBm (CW RMS)

Table 46. Absolute Maximum Reverse Power for VST Passthrough* When Operating as Vector Signal
Generator

*When used within PXIe-5842 VST with S-Parameters.

Output Power ≤ +16 dBm

Output Power ≤ +20 dBm

+25 dBm

+20 dBm

Table 47. Absolute Maximum Input Power for VNA Load Port

Test Receiver Attenuation < 8 dB

Test Receiver Attenuation ≥ 8 dB

+20 dBm

+27 dBm

Table 48. Absolute Maximum Reverse Power for VNA Reflection Port

Notice In certain conditions, such as generating into a short, reflections of signals that
otherwise comply with these limits may exceed these values and damage the instrument.

RF Output Power ≤ +10 dBm, Test Receiver
Attenuation < 8 dB

+15 dBm

96 ni.com

PXIe-5842 Safety Guidelines

RF Output Power ≤ +20 dBm, Test Receiver
Attenuation ≥ 8 dB

+20 dBm

Other Ports

Table 49. Other Ports

IF IN absolute maximum input power

+18 dBm

IF OUT absolute maximum reverse power

+18 dBm

SWITCH IN absolute maximum input power

+14 dBm

SWITCH OUT absolute maximum reverse power  +10 dBm

LO IN absolute maximum input power

+12 dBm

LO OUT absolute maximum reverse power

+10 dBm

REF IN maximum input voltage

5 Vpk-pk

REF OUT absolute maximum reverse voltage

2 Vpk-pk

PFI 0, PFI 1 absolute maximum input range

-0.5 V to 5 V

Measurement Category

Caution Do not connect the product to signals or use for measurements
within Measurement Categories II, III, or IV.

Attention Ne pas connecter le produit à des signaux dans les catégories de
mesure II, III ou IV et ne pas l'utiliser pour effectuer des mesures dans ces
catégories.

Measurement Category I is for measurements performed on circuits not directly
connected to the electrical distribution system referred to as MAINS voltage. MAINS is a
hazardous live electrical supply system that powers equipment. This category is for
measurements of voltages from specially protected secondary circuits. Such voltage
measurements include signal levels, special equipment, limited-energy parts of
equipment, circuits powered by regulated low-voltage sources, and electronics.

© National Instruments 97

PXIe-5842 Safety Guidelines

Note Measurement Categories CAT I and CAT O are equivalent. These test
and measurement circuits are for other circuits not intended for direct
connection to the MAINS building installations of Measurement Categories
CAT II, CAT III, or CAT IV.

CAL-5501 Safety Voltages

Connect only voltages that are below these limits.

PORT A, PORT B absolute maximum input power

PORT A, PORT B absolute maximum input voltage

Measurement Category

Measurement Category

+24 dBm

±10 V DC

CAT I/O

Caution Do not connect the product to signals or use for measurements
within Measurement Categories II, III, or IV.

Attention Ne pas connecter le produit à des signaux dans les catégories de
mesure II, III ou IV et ne pas l'utiliser pour effectuer des mesures dans ces
catégories.

Measurement Category I is for measurements performed on circuits not directly
connected to the electrical distribution system referred to as MAINS voltage. MAINS is a
hazardous live electrical supply system that powers equipment. This category is for
measurements of voltages from specially protected secondary circuits. Such voltage
measurements include signal levels, special equipment, limited-energy parts of
equipment, circuits powered by regulated low-voltage sources, and electronics.

98 ni.com

PXIe-5842 Safety Guidelines

Note Measurement Categories CAT I and CAT O are equivalent. These test
and measurement circuits are for other circuits not intended for direct
connection to the MAINS building installations of Measurement Categories
CAT II, CAT III, or CAT IV.

Product Certifications and Declarations
Product Certifications and Declarations

Refer to the product Declaration of Conformity (DoC) for additional regulatory
compliance information. To obtain product certifications and the DoC for NI products,
visit ni.com/product-certifications, search by model number, and click the appropriate
link.

Related information:

•  Product Certifications

© National Instruments 99

PXIe-5842 Mounting Guidelines

Mounting Guidelines
PXIe-5842  Mounting Guidelines
PXIe-5842

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

100 ni.com

Installing and Setting Up the PXIe-5842

PXIe-5842
Installing and Setting Up the PXIe-5842
Installing and Setting Up the

Complete the procedures to install necessary software, physically install your
PXIe-5842 instrument, perform initial configuration, and run an initial test
measurement.

1.  Installing the Software
2.  Installing and Interconnecting PXIe-5842 Instruments

Follow this general process to complete physical setup for your PXIe-5842
instrument.

3.  Performing Initial Hardware Configuration

Before you can use your PXIe-5842, you need to ensure your system recognizes the
instrument and to set up the correct associations between the constituent
modules of the composite instrument.

4.  Making a First VST Measurement

You can verify proper installation and configuration of your instrument by making
a measurement using InstrumentStudio.

Installing the Software
Installing the Software

You must be an Administrator to install NI software on your computer.

1.  Install an ADE, such as LabVIEW or LabWindows™/CVI™.
2.  Download the driver software installer from ni.com/downloads.

Package Manager downloads with the driver software to handle the installation.
Refer to the Package Manager Manual for more information about installing,
removing, and upgrading NI software using Package Manager.

3.  Follow the instructions in the installation prompts.

Note Windows users may see access and security messages during
installation. Accept the prompts to complete the installation.

4.  When the installer completes, select Restart in the dialog box that prompts you to

restart, shut down, or restart later.

Related concepts:

© National Instruments 101

Installing and Setting Up the PXIe-5842

•  PXIe-5842 Driver Support

Installing and Interconnecting PXIe-5842
Installing and Interconnecting

Instruments
PXIe-5842  Instruments

Follow this general process to complete physical setup for your PXIe-5842 instrument.

Complete the following tasks in order to successfully install your PXIe-5842 instrument
in a chassis and make the connections between modules necessary for it to function.

1.  Unpacking the Kit

Take precautions to prevent electrostatic discharge when unpacking and
inspecting your hardware.

2.  Installing PXIe-5842 Modules in a PXI Express Chassis

You need to install modules in your PXIe-5842 instrument in a specific order and
orientation to facilitate interconnection of the modules into a complete, functional
instrument.

3.  Ensuring Signal Quality when Interconnecting the PXIe-5842

After you install the PXIe-5842 modules into your chassis, you must use the
included cables to interconnect the PXI Express modules to each other and, if
applicable, to any modules external to the PXI Express chassis. To ensure proper
connections that maintain signal quality, adhere to these guidelines while
interconnecting the modules.

4.  Interconnecting your PXIe-5842 Instrument

Interconnection makes connections between individual modules that are
necessary for the functionality of the overall instrument. Complete the relevant
interconnection procedure for your PXIe-5842 instrument.

Unpacking the Kit
Unpacking the Kit

Take precautions to prevent electrostatic discharge when unpacking and inspecting
your hardware.

Notice To prevent electrostatic discharge (ESD) from damaging the device,
ground yourself using a grounding strap or by holding a grounded object,
such as your computer chassis.

102 ni.com

Installing and Setting Up the PXIe-5842

1.  Touch the antistatic package to a metal part of the computer chassis.
2.  Remove the device from the package and inspect the device for loose components

or any other sign of damage.

Notice Never touch the exposed pins of connectors.

Note Do not install a device if it appears damaged in any way.

3.  Unpack any other items and documentation from the kit.

Note Store the device in the antistatic package when the device is not in use.

Installing PXIe-5842
Installing

Modules in a PXI Express Chassis
PXIe-5842  Modules in a PXI Express Chassis

You need to install modules in your PXIe-5842 instrument in a specific order and
orientation to facilitate interconnection of the modules into a complete, functional
instrument.

Ensure your PXI Express chassis meets the capacity, power, and slot cooling capacity
requirements of your PXIe-5842 instrument.

Notice To prevent damage to your PXIe-5842 instrument caused by ESD or
contamination, handle each PXI module using the edges or the metal
bracket.

Complete the following steps to install the PXI modules of your instrument in your PXI
chassis:

1.  Ensure the AC power source is connected to the chassis before installing the

modules.
The AC power cord grounds the chassis and protects it from electrical damage
while you install modules.

2.  Power off the chassis.
3.  Inspect the slot pins on the chassis backplane for any bends or damage prior to

installation. Do not install a module if the backplane is damaged.

© National Instruments 103

Installing and Setting Up the PXIe-5842

4.  Remove the black plastic covers from all the captive screws on the front panels for

all modules.

5.  Select an appropriate set of PXI chassis slots so that you can install the modules

that compose your instrument in the order indicated:

Instrument

PXIe-5842 VST

PXIe-5842 VST with 54 GHz Frequency
Extension

PXIe-5842 VST with S-Parameters

Instrument

PXIe-5842 VST

PXIe-5842 VST with 54 GHz Frequency
Extension

PXIe-5842 VST with S-Parameters

Adjacent Compatible Slots Required

4

6

5

Module Installation Order, Left to Right

a.  PXIe-5842
b.  PXIe-5655

a.  PXIe-5842
b.  PXIe-5655
c.  PXIe-5563
d.  PXIe-5655

a.  PXIe-5842
b.  PXIe-5655
c.  PXIe-5633

PXIe-5842 instruments can be installed in the following PXI chassis slot types:
◦

H PXI Express Hybrid Peripheral Slot

◦

◦

 PXI Express System Timing Slot

 PXI Express Peripheral Slot

6.  Touch any metal part of the chassis to discharge static electricity.
7.  Place the edges of a module of your instrument into the module guides of the

appropriate slot at the top and bottom of the chassis. Slide the module into the
slot until it is fully inserted.

8.  Secure the module front panel to the chassis using the front-panel mounting

screws.

Note All front panel mounting screws must be attached to the PXI

104 ni.com

Installing and Setting Up the PXIe-5842

Express chassis to ensure all backplane connectors are fully mated.
Tightening the mounting screws also increases mechanical stability and
electrically connects the front panel to the chassis, which can improve
the signal quality and electromagnetic performance.

9.  Repeat all relevant steps for each PXI module within your instrument until you

have installed all PXI modules for your instrument.

10.  Cover all empty slots using slot blockers and EMC filler panels.

Note For more information about installing slot blockers and filler
panels, go to ni.com/r/pxiblocker.

11.  Depending on your instrument, manage chassis power as follows:

◦  PXIe-5842 VST with 54 GHz Frequency Extension: do not power on the PXI

Express chassis yet. The RMM-5585/RMM-5586 must be fully connected and
powered before the chassis is powered so it is correctly recognized by the
software.

◦  All other PXIe-5842 instruments: power on the PXI Express chassis.

The in-chassis modules of your PXIe-5842 instrument are now correctly installed in
your PXI chassis.

PXIe-5842 instruments also require interconnections between the installed modules.
Review the interconnection guidelines for PXIe-5842 instruments before continuing
with the interconnection procedure.

Related information:

•  Slot Blocker Documentation

PXIe-5842
Ensuring Signal Quality when Interconnecting the PXIe-5842
Ensuring Signal Quality when Interconnecting the

After you install the PXIe-5842 modules into your chassis, you must use the included
cables to interconnect the PXI Express modules to each other and, if applicable, to any
modules external to the PXI Express chassis. To ensure proper connections that
maintain signal quality, adhere to these guidelines while interconnecting the modules.

© National Instruments 105

Installing and Setting Up the PXIe-5842

•  Inspect all RF connectors before attaching mating cables. Clean with dry

compressed air, if necessary, to remove any contaminants that may be present.
•  Position RF cables with instrument connectors to ensure center pins are straight

and aligned before mating.

•  For all threaded RF connectors for your PXIe-5842 instrument, engage and finger-
tighten the connector nuts. The connector nuts should thread easily without
binding, but if not, ensure the connector is straight and that center pins have not
been damaged.

•  Carefully tighten all threaded RF connectors to the torque specified in the

interconnection process for your instrument using an appropriate torque wrench
or torque screwdriver and driver bit; tighten only until the wrench or screwdriver
reaches the torque limit.

Notice Incorrect torque at threaded connections can damage
connectors and degrade signal integrity.

To complete installation, continue with the relevant interconnection procedure for
your PXIe-5842 instrument.

Interconnecting your PXIe-5842
Interconnecting your

Instrument
PXIe-5842  Instrument

Interconnection makes connections between individual modules that are necessary
for the functionality of the overall instrument. Complete the relevant interconnection
procedure for your PXIe-5842 instrument.

Interconnecting the PXIe-5842
Interconnecting the

VST
PXIe-5842  VST

Complete this procedure to interconnect the modules of the PXIe-5842 VST.

Before beginning this procedure, install the relevant modules for your instrument in
your PXI Express chassis and refer to the interconnection guidelines.

The PXIe-5842 VST comprises the following modules:

•  PXIe-5842
•  PXIe-5655

106 ni.com

Installing and Setting Up the PXIe-5842

Once you complete this procedure, your instrument should appear as follows:

Figure 23. Interconnected PXIe-5842 VST

1

2

PXIe-5842
Vector Signal Transceiver

ACC

ACTIVE

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

LO 0 OUT
50 MHz to
7.2 GHz

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF OUT

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN
+17 dBm
MAX

LO OUT
+17 dBm
MAX
REVERSE

PFI 0
LVTTL

3

LO 1 IN
+17 dBm
MAX

CTRL
1.8 V  LVCMOS

RF IN

LO OUT
+17dBm
MAX
REVERSE

REF IN

LO IN
+17 dBm
MAX

LO 1 OUT
50 MHz to
7.2 GHz

ESD
SENSITIVE

PULSE

IN

OUT
3.3 V  LVCMOS

ALL RF PORTS 50 Ω

ESD
SENSITIVE

1.  PXIe-5842 (module)
2.  PXIe-5655
3.  Semi-rigid 2.92 mm (m)-to-2.92 mm (m) cables

© National Instruments 107

Installing and Setting Up the PXIe-5842

Complete the following steps to interconnect the PXIe-5842 VST:

1.  Connect the local oscillator for RF output.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136104A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF OUT: LO IN

LO 0 OUT

2.  Connect the internal reference clock.

Note Install this cable such that the flatter bend is closest to the
PXIe-5842 REF: IN connector and the more angled bend is closest to the
PXIe-5655 REF OUT connector. The correct orientation leaves less space
between this cable and the cable you have already installed.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136103A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

REF: IN

REF OUT

3.  Connect the local oscillator for RF input.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136106A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF IN: LO IN

LO 1 OUT

You have now provided the reference clock and LO sources for the PXIe-5842 VST.
Physical setup for the PXIe-5842 VST is now complete.

108 ni.com

Installing and Setting Up the PXIe-5842

Interconnecting the PXIe-5842
Interconnecting the

PXIe-5842  VST with

VST with 54 GHz

Frequency Extension
54 GHz  Frequency Extension

Complete these procedures to interconnect the modules of the PXIe-5842 VST with
54 GHz Frequency Extension. This instrument includes both a set of PXI Express
modules and the RMM-5585/RMM-5586 remote measurements module, which is
external to the PXI Express chassis.

The PXIe-5842 VST with 54 GHz Frequency Extension comprises the following modules:

•  PXIe-5842
•  PXIe-5655 (×2)
•  PXIe-5563
•  RMM-5585 or RMM-5586

To fully interconnect the PXIe-5842 VST with 54 GHz Frequency Extension, complete
the following tasks in order:

1.  Interconnect the in-chassis modules of the instrument.
2.  Connect the remote measurements module, which is external to the PXI Express

chassis, to the in-chassis modules.

3.  Connect the remote measurements module to power.

Interconnecting PXI Express Modules for the PXIe-5842 VST with 54 GHz Frequency
Extension

Complete this procedure to finish interconnecting the in-chassis components of the
PXIe-5842 VST with 54 GHz Frequency Extension.

Before beginning this procedure, install the relevant modules for your instrument in
your PXI Express chassis and refer to the interconnection guidelines.

Once you complete this procedure, your instrument should appear as follows:

© National Instruments 109

Figure 24. Interconnected PXIe-5842 VST with 54 GHz Frequency Extension, In-Chassis Components

1

2

3

4

Installing and Setting Up the PXIe-5842

PXIe-5842
Vector Signal Transceiver

PXIe-5655
Dual RF Synthesizer

PXIe-5563
RF Port Switch

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

ACC

ACTIVE

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

ACC

ACTIVE

RF IN/OUT 0

5

SEE SPECIFICATIONS
FOR MAX PORT POWER

ALL RF PORTS 50Ω

LO 0 OUT

50 MHz to

7.2 GHz

LO 0 OUT

50 MHz to

7.2 GHz

5

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF OUT

SWITCH IN

REF OUT

REF

5

IN
2.5 Vp-p
MAX

RF OUT

5

LO IN
+17 dBm
MAX

LO 0 IN

+17 dBm

MAX

IF OUT

OUT
2 Vp-p
MAX
REVERSE

LO OUT
+17 dBm
MAX
REVERSE

CTRL
1.8 V  LVCMOS

RF IN

PFI 0

LVTTL

SWITCH
OUT

6

LO 1 IN

+17 dBm

MAX

IF IN

LO 0 IN

+17 dBm

MAX

PFI 0

LVTTL

LO 1 IN

+17 dBm

MAX

LO OUT
+17dBm
MAX
REVERSE

REF IN

ALL RF PORTS 50 Ω

REF IN

LO IN
+17 dBm
MAX

LO 1 OUT

50 MHz to

7.2 GHz

5

ESD
SENSITIVE

RF IN/OUT 1

ESD
SENSITIVE

LO 1 OUT

50 MHz to

7.2 GHz

ESD
SENSITIVE

PULSE

IN
3.3 V  LVCMOS

OUT

ALL RF PORTS 50 Ω

ESD
SENSITIVE

1.  PXIe-5842 (module)
2.  PXIe-5655, left
3.  PXIe-5563
4.  PXIe-5655, right
5.  Semi-rigid 2.92 mm (m)-to-2.92 mm (m) cables
6.  Flexible SMA (m)-to-SMA (m) cable

Complete the following steps to interconnect the in-chassis modules of the PXIe-5842
VST with 54 GHz Frequency Extension:

1.  Connect the local oscillator for RF output.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

Left PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136104A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF OUT: LO IN

LO 0 OUT

110 ni.com

Installing and Setting Up the PXIe-5842

2.  Connect the internal reference clock.

Note Install this cable such that the flatter bend is closest to the
PXIe-5842 REF: IN connector and the more angled bend is closest to the
PXIe-5655 REF OUT connector. The correct orientation leaves less space
between this cable and the cable you have already installed.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

Left PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136103A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

REF: IN

REF OUT

3.  Connect the local oscillator for RF input.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

Left PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136106A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF IN: LO IN

LO 1 OUT

4.  Connect the RF output.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5563
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
137925A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF OUT

SWITCH IN

5.  Connect the RF input.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5563
Connector

Semi-rigid

0.9 N · m

1.0 N · m

RF IN

SWITCH OUT

© National Instruments 111

Installing and Setting Up the PXIe-5842

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5563
Connector

2.92 mm (m)-to-2.92 mm (m),
137924A-01

(8 lb · in.)

(8.85 lb · in.)

6.  Connect the second internal reference.

Cable

Torque

Minimum

Maximum

Left PXIe-5655
Connector

Right PXIe-5655
Connector

Flexible
SMA (m)-to-SMA (m),
190412B-04

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

REF IN

REF OUT

You have now interconnected all of the in-chassis modules that compose the
PXIe-5842 VST with 54 GHz Frequency Extension. The modules are not yet connected to
the remote measurement module necessary to complete the instrument.

Next, connect the RMM-5585 or RMM-5586 remote measurement module to the in-
chassis components of the PXIe-5842 VST with 54 GHz Frequency Extension.

Interconnecting the RMM-5585 or RMM-5586 to In-Chassis PXI Express Modules

Connect the RMM-5585 or RMM-5586 remote measurements module to the in-chassis
PXI modules of the PXIe-5842 VST with 54 GHz Frequency Extension.

Once you complete this procedure, your instrument should appear as follows:

112 ni.com

Installing and Setting Up the PXIe-5842

Figure 25. Interconnected PXIe-5842 VST with 54 GHz Frequency Extension

PXIe-5842
Vector Signal Transceiver

PXIe-5655
Dual RF Synthesizer

PXIe-5563
RF Port Switch

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

ACC

ACTIVE

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

ALL RF PORTS 50Ω

ACC

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

LO 0 OUT

50 MHz to

7.2 GHz

ACTIVE

RF IN/OUT 0

SEE SPECIFICATIONS
FOR MAX PORT POWER

LO 0 OUT

50 MHz to

7.2 GHz

REF OUT

SWITCH IN

REF OUT

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN

+17 dBm

MAX

IF OUT

LO 0 IN

+17 dBm

MAX

PFI 0

LVTTL

SWITCH
OUT

PFI 0

LVTTL

LO OUT
+17 dBm
MAX
REVERSE

CTRL
1.8 V  LVCMOS

RF IN

LO 1 IN

+17 dBm

MAX

IF IN

LO 1 IN

+17 dBm

MAX

LO OUT
+17dBm
MAX
REVERSE

REF IN

ALL RF PORTS 50 Ω

REF IN

PULSE

IN
3.3 V  LVCMOS

OUT

LO IN
+17 dBm
MAX

LO 1 OUT

50 MHz to

7.2 GHz

ESD
SENSITIVE

RF IN/OUT 1

ESD
SENSITIVE

LO 1 OUT

50 MHz to

7.2 GHz

ESD
SENSITIVE

ALL RF PORTS 50 Ω

ESD
SENSITIVE

3

3

1

IF IN
+15 dBm MAX

ESD
SENSITIVE

CTRL

1

0

IF OUT
+20 dBm REV MAX

ACCESS ACTIVE

12 V
7.0 A MAX

3

DOWNCONVERTER
LO IN
+20 dBm MAX

UPCONVERTER/
SHARED LO IN
+20 dBm MAX

3

2

1.  RMM-5585/RMM-5586 (rear panel)
2.  Mini HDMI-to-Mini HDMI cable
3.  3.5 mm (m)-to-3.5 mm (m) cables

Note Refer to the front and rear panel documentation for the PXIe-5842 VST
with 54 GHz Frequency Extension to see the individual connectors for each
module of the instrument in detail.

Complete the following steps to connect the RMM-5585 or RMM-5586 to the in-chassis
modules of the PXIe-5842 VST with 54 GHz Frequency Extension:

1.  Connect the CTRL signal.

Cable

Torque

PXIe-5842 Connector

RMM-5585/RMM-5586
Connector

Mini HDMI-to-Mini HDMI,
143045A-01

0.34 N · m (3 lb · in.),
maximum

CTRL

CTRL: 0

2.  Connect the IF output signal.

Notice Do not disconnect the attenuator preinstalled on the IF IN port of
the RMM-5585 or RMM-5586.

© National Instruments 113

Installing and Setting Up the PXIe-5842

Cable

Torque

Minimum

Maximum

PXIe-5563
Connector

RMM-5585/RMM-5586
Connector

3.5 mm (m)-to-3.5 mm (m),
137446A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

IF OUT

Attenuator
preinstalled on IF IN

3.  Connect the IF input signal.

Notice Do not disconnect the attenuator preinstalled on the IF OUT port
of the RMM-5585 or RMM-5586.

Cable

Torque

Minimum

Maximum

PXIe-5563
Connector

RMM-5585/RMM-5586
Connector

3.5 mm (m)-to-3.5 mm (m),
137446A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

IF IN

Attenuator
preinstalled on IF OUT

4.  Connect the first millimeter wave local oscillator signal.

Cable

Torque

Minimum

Maximum

3.5 mm (m)-to-3.5 mm (m),
137446A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

Right
PXIe-5655
Connector

LO 0 OUT

RMM-5585/RMM-5586
Connector

UPCONVERTER/
SHARED LO IN

5.  Connect the second millimeter wave local oscillator signal.

Cable

Torque

Minimum

Maximum

3.5 mm (m)-to-3.5 mm (m),
137446A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

Right
PXIe-5655
Connector

LO 1 OUT

RMM-5585/RMM-5586
Connector

DOWNCONVERTER
LO IN

Signals are now properly connected between the RMM-5585 or RMM-5586, and the in-
chassis components of the PXIe-5842 VST with 54 GHz Frequency Extension. The
RMM-5585/RMM-5586 is not yet connected to power.

114 ni.com

Installing and Setting Up the PXIe-5842

To finish physical setup of the PXIe-5842 VST with 54 GHz Frequency Extension,
connect power to the RMM-5585 or RMM-5586.
Related reference:

•  PXIe-5842 VST with 54 GHz Frequency Extension Front Panel and Rear Panel

Connecting the RMM-5585 or RMM-5586 Remote Measurements Module to Power

After you connect the RMM-5585/RMM-5586 to the PXIe-5842 PXI Express modules,
connect the RMM-5585/RMM-5586 to power.

1.  Connect the AC power supply adapter to the RMM-5585/RMM-5586 power input.
2.  Tighten the locking screws on the power supply connector to the

RMM-5585/RMM-5586 using a small flat blade screwdriver to 0.34 N · m (3 lb · in.)
maximum.

3.  Power on the RMM-5585/RMM-5586 by connecting the AC power cable to the
power input on the adapter and connecting the other end to a wall socket.

4.  Power on the PXI Express chassis.

Physical setup for the PXIe-5842 VST with 54 GHz Frequency Extension is now
complete.

Interconnecting the PXIe-5842
Interconnecting the

PXIe-5842  VST with

S-Parameters
VST with S-Parameters

Complete this procedure to interconnect the modules of the PXIe-5842 VST with
S-Parameters.

Before beginning this procedure, install the relevant modules for your instrument in
your PXI Express chassis and refer to the interconnection guidelines.

The PXIe-5842 VST with S-Parameters comprises the following modules:

•  PXIe-5842
•  PXIe-5655
•  PXIe-5633

Once you complete this procedure, your instrument should appear as follows:

© National Instruments 115

Figure 26. Interconnected PXIe-5842 VST with S-Parameters

1

2

3

Installing and Setting Up the PXIe-5842

PXIe-5842
Vector Signal Transceiver

ACC

ACTIVE

PXIe-5655
Dual RF Synthesizer

PXIe-5633
VNA

ACC

ACTIVE

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

LO 0 OUT
50 MHz to
7.2 GHz

5 V MAX

DIO
5 V MAX

MGT
100 Ω DIFF

0

1

2

3

SEE SPECIFICATIONS FOR
MAX RF IN / OUT POWER

REF OUT

REF

RF OUT

IN
2.5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

LO IN
+17 dBm
MAX

LO 0 IN
+17 dBm
MAX

PFI 0
LVTTL

LO OUT
+17 dBm
MAX
REVERSE

CTRL
1.8 V  LVCMOS

RF IN

LO 1 IN
+17 dBm
MAX

LO OUT
+17dBm
MAX
REVERSE

REF IN

ACC

ACTIVE

LO IN

LO OUT

REF IN

REF OUT

PFI 0

PFI 1

PORT 1

SWITCH
IN

IF OUT

SWITCH
OUT

IF IN

PORT 2

4

PULSE

IN
OUT
3.3 V  LVCMOS

LO IN
+17 dBm
MAX

LO 1 OUT
50 MHz to
7.2 GHz

ESD
SENSITIVE

ESD
SENSITIVE

ALL RF PORTS 50 Ω

ESD
SENSITIVE

1.  PXIe-5842 (module)
2.  PXIe-5655
3.  PXIe-5633
4.  Semi-rigid 2.92 mm (m)-to-2.92 mm (m) cables

Complete the following steps to interconnect the PXIe-5842 VST with S-Parameters:

1.  Connect the local oscillator for RF output.

116 ni.com

Installing and Setting Up the PXIe-5842

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136104A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF OUT: LO IN  LO 0 OUT

2.  Connect the internal reference clock.

Note Install this cable such that the flatter bend is closest to the
PXIe-5842 REF: IN connector and the more angled bend is closest to the
PXIe-5655 REF OUT connector. The correct orientation leaves less space
between this cable and the cable you have already installed.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136103A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

REF: IN

REF OUT

3.  Connect the local oscillator for RF input.

Cable

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5655
Connector

Semi-rigid
2.92 mm (m)-to-2.92 mm (m),
136106A-01

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF IN: LO IN

LO 1 OUT

4.  Connect the VST passthrough generation path.

Cable

Semi-rigid
2.92 mm (m)-to-
2.92 mm (m),

Torque

Minimum

Maximum

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

PXIe-5842
Connector

PXIe-5633
Connector

RF OUT

SWITCH IN

© National Instruments 117

Installing and Setting Up the PXIe-5842

Cable

138278A-01

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5633
Connector

5.  Connect the VST passthrough analysis path.

Cable

Semi-rigid
2.92 mm (m)-to-
2.92 mm (m),
138277A-01

Torque

Minimum

Maximum

PXIe-5842
Connector

PXIe-5633
Connector

0.9 N · m
(8 lb · in.)

1.0 N · m
(8.85 lb · in.)

RF IN

SWITCH OUT

You have now interconnected all modules of the PXIe-5842 VST with S-Parameters.
Physical setup for the PXIe-5842 VST with S-Parameters is now complete.

Performing Initial Hardware Configuration
Performing Initial Hardware Configuration

Before you can use your PXIe-5842, you need to ensure your system recognizes the
instrument and to set up the correct associations between the constituent modules of
the composite instrument.

Related concepts:

•  When to Perform Self-Calibration

Related tasks:

•  What Should I Do if the Instrument Does Not Initialize?

Configuring the PXIe-5842
Configuring the

in Hardware Configuration Utility
PXIe-5842  in Hardware Configuration Utility

NI recommends using Hardware Configuration Utility to perform initial hardware
configuration.

1.  Open the Hardware Configuration Utility.

118 ni.com

Installing and Setting Up the PXIe-5842

The PXIe-5842 appears in the system pane automatically.
If the PXIe-5842 does not appear automatically, do the following:
a.  Click the + button or, in the menu, select Edit » Add hardware....
b.  Find the modules of your instrument in the Discovered pane and click Add.
2.  Record the name that the Hardware Configuration Utility assigns to the PXIe-5842

or, if desired, provide a custom name to the PXIe-5842.
Use this name when programming the PXIe-5842.

3.  Associate the hardware modules that compose your instrument.

Tip You can expand Hardware associations in the configuration pane
and click Available associations to see illustrations of the valid
configurations for PXIe-5842 instruments.

Instrument

PXIe-5842 VST

PXIe-5842 VST with 54 GHz Frequency
Extension

Process

a.  In the system pane, select the PXIe-5842

module to associate.

b.  In the Hardware associations section of
the configuration pane, click the LO field
and choose the PXIe-5655 to associate
with the PXIe-5842 module.

a.  In the system pane, select the PXIe-5842

module to associate.

b.  In the Hardware associations section of
the configuration pane, click the LO field
and choose the entry that represents the
PXIe-5655 immediately to the right of the
PXIe-5842 module.

c.  In the Hardware associations section,

click the RMM LO dropdown and choose
the entry that represents the PXIe-5655 to
the right of the PXIe-5563 module.
d.  In the Hardware associations section,
click the Switch field and choose the
PXIe-5563 module to associate with the
instrument.

PXIe-5842 VST with S-Parameters

a.  In the system pane, select the PXIe-5842

module to associate.

b.  In the Hardware associations section of
the configuration pane, click the LO field

© National Instruments 119

Instrument

Process

Installing and Setting Up the PXIe-5842

and choose the PXIe-5655 to associate
with the PXIe-5842 module.

c.  In the Hardware associations section of
the configuration pane, click the Switch
field and choose the PXIe-5633 to
associate with the PXIe-5842 module.

4.  If your hardware option supports more than one personality, configure the

personality.
a.  Select your instrument in the system pane.
b.  Expand the Device details section and select one of the following options from

the Personality dropdown:
▪  Standard
▪  4 GHz Bandwidth

5.  Validate that your instrument is installed and connected correctly by selecting the
PXIe-5842 module of your instrument in the system pane and choosing either of
the following:

Option

Process

Verify associations

a.  Expand the Hardware associations area

Self-test

of the configuration pane.
b.  Click Verify associations.

Note Verify associations performs
an intermediate self-test.

a.  Expand the Troubleshooting area of the
configuration pane and click Self-test.
b.  Select Intermediate and then click Ok to

run the test.

Hardware Configuration Utility reports when the hardware setup is validated.

Related concepts:

•  Instrument Personalities

120 ni.com

Installing and Setting Up the PXIe-5842

Configuring the PXIe-5842
Configuring the

in MAX
PXIe-5842  in MAX

You can use Measurement & Automation Explorer (MAX) to perform initial hardware
configuration. MAX is automatically installed with NI-RFSA, NI-RFSG, and RFmx.

1.  Launch MAX.
2.  In the configuration tree, expand Devices and Interfaces to see the list of installed

NI hardware.
Installed modules appear under the name of their associated chassis.

3.  Expand your Chassis tree item.

MAX lists all modules installed in the chassis. Your default names might vary.

Note If your module does not appear in the list, press <F5> to refresh the
list of installed modules. If the module is still not listed, power off the
system, and ensure that the module is correctly installed, then restart.

4.  Record the name MAX assigns to the PXIe-5842 or, if desired, provide a custom

name to the PXIe-5842.
Use this name when programming the PXIe-5842.

5.  Associate the hardware modules that compose your instrument.

Instrument

PXIe-5842 VST

Process

a.  Select the PXIe-5842 module to associate.
b.  In the Associated Devices section, click

the Associated LO dropdown and choose
the PXIe-5655 to associate with the
PXIe-5842 module.

c.  Click Save.

PXIe-5842 VST with 54 GHz Frequency
Extension

a.  Select the PXIe-5842 module to associate.
b.  In the Associated Devices section, click

the Associated LO dropdown and choose
the entry that represents the PXIe-5655
immediately to the right of the PXIe-5842
module.

c.  In the Associated Devices section, click
the Associated RMM LO dropdown and
choose the entry that represents the
PXIe-5655 to the right of the PXIe-5563
module.

© National Instruments 121

Instrument

Process

Installing and Setting Up the PXIe-5842

PXIe-5842 VST with S-Parameters

d.  In the Associated Devices section, click
the Associated Switch dropdown and
choose the PXIe-5563 module to associate
with the instrument.

e.  Click Save.

a.  Select the PXIe-5842 module to associate.
b.  In the Associated Devices section, click

the Associated LO dropdown and choose
the PXIe-5655 to associate with the
PXIe-5842 module.

c.  In the Associated Devices section, click
the Associated Switch dropdown and
choose the PXIe-5633 module to associate
with the instrument.

d.  Click Save.

6.  If your hardware option supports more than one personality, configure the

personality.
a.  In the configuration tree, expand Devices and Interfaces and select your

instrument.

b.  In the Settings pane, click the Personality dropdown and choose one of the

following options, then click Save.
▪  Standard
▪  4 GHz Bandwidth
7.  Perform an intermediate self-test.

a.  Select the item in the configuration tree and click Self-Test in the MAX toolbar.
b.  Select the Intermediate radio button and then click Start.
The green signal illuminates and shows Pass when the self-test completes
successfully.

Related concepts:

•  Instrument Personalities

Making a First VST Measurement
Making a First VST Measurement

You can verify proper installation and configuration of your instrument by making a

122 ni.com

Installing and Setting Up the PXIe-5842

measurement using InstrumentStudio.

Complete the following steps to generate an RF test signal from one port of your
PXIe-5842 instrument and acquire that test signal on another port of the instrument to
verify its functionality.

The hardware connections and test frequencies that you can generate and acquire
through the connections are dependent on your PXIe-5842 instrument. Use the
following test frequencies depending on your instrument:

Instrument

Test Frequency

PXIe-5842 VST (Up to 2 GHz Bandwidth)

1 GHz

PXIe-5842 VST with 54 GHz Frequency Extension  1 GHz or 28 GHz

PXIe-5842 VST with S-Parameters

PXIe-5842 VST (4 GHz Bandwidth)

1 GHz

2 GHz

Complete the following steps to make a test measurement and validate that your
PXIe-5842 instrument is configured correctly.

1.  Depending on your instrument and, if applicable to your configuration, the

frequency you want to test, connect the relevant RF input and RF output ports
using the appropriate cable.

Instrument

Connection

PXIe-5842 VST (PXIe-5842 VST (Up to
2 GHz Bandwidth) or PXIe-5842 VST (4 GHz
Bandwidth))

PXIe-5842 VST with 54 GHz Frequency
Extension

◦  Ports: PXIe-5842 RF IN to RF OUT
◦  Cable: 3.5 mm (m)-to-3.5 mm (m)

Frequency < 26.5 GHz: Make connections to
the PXIe-5563 module.
◦  Ports: RF IN/OUT 0 to RF IN/OUT 1 (one
port configured as input; other port
configured as output)

◦  Cable: 3.5 mm (m)-to-3.5 mm (m)

Frequency ≥ 23.5 GHz: Make connections to
the RMM-5585 or RMM-5586 module.

© National Instruments 123

Instrument

Connection

Installing and Setting Up the PXIe-5842

PXIe-5842 VST with S-Parameters

◦  Ports: RF IN/OUT PORTS: 0 to

RF IN/OUT PORTS: 1 (one port configured
as input; other port configured as output)

◦  Cable: 1.85 mm (m)-to-1.85 mm (m)

◦  Ports: PXIe-5633 PORT 1 to PORT 2
◦  Cable: 3.5 mm (m)-to-3.5 mm (m)

2.  Launch InstrumentStudio at Start » National Instruments » InstrumentStudio.
3.  Click File » New » RF Signal Generator.
4.  Generate a test CW tone RF signal at the RF output terminal of your instrument.

a.  Select CW in the panel for the instrument.
b.  In the Frequency box, input the test frequency.
c.  In the Level box, enter 0 dBm.
d.  For certain instruments, choose the correct port:

▪  PXIe-5842 VST with 54 GHz Frequency Extension only: In the Selected Port

field, select the relevant port for the frequency you are generating.
▪  PXIe-5842 VST with S-Parameters only: In the Selected Port field, choose

port1.

5.  If the generator is not already running, click Run, and set the output to On.

The instrument generates a signal with the settings you specify.

6.  Click File » New » RF Signal Analyzer.
7.  PXIe-5842 VST with 54 GHz Frequency Extension and PXIe-5842 VST with

S-Parameters only: In the RF signal analyzer panel, for Selected Port, choose the
counterpart port for the port that is generating the RF signal.

8.  Verify on the RF signal analyzer panel that the PXIe-5842 is receiving the CW tone.
Confirm that the frequency is set to the frequency of the generated tone and that
the reference level is set to an appropriate value, such as 5 dBm.

9.  Close InstrumentStudio.

Related concepts:

•  Cables and Accessories
•  When to Perform Self-Calibration

124 ni.com

Creating a Multi-VST System

Creating a Multi-VST System
Creating a Multi-VST System

Use the NI-RFSA and NI-RFSG drivers to configure a Multi-Channel Phase-Coherent
system with NI VST.

Note Multi-VST systems were first implemented in 2024 Q2.

Configuring a PXIe-5842 Multi-VST System

You can create a multi-VST system with the PXIe-5842.

Use cables to connect the following items:

•  Multiple PXIe-5842 devices
•  A PXIe-5655 device
•  SMA power splitter x2

Note The splitter size depends on the number of VSTs in the system.

Connect the PXIe-5655 LO OUT for RF IN and RF OUT to a splitter that distributes to the
LO IN of each PXIe-5842 device in the system. The LO distribution through the splitters
must have a loss between 0 dB and 9 dB for the frequency range of 1500 MHz to 7200
MHz.

For clock cables, attach the REF OUT connector of the primary PXIe-5842 directly into
the REF IN connector of the downstream PXIe-5842. Repeat this action for each
remaining VST.

For an example of an x2 system using this configuration, refer to the following cabling
diagram.

© National Instruments 125

Creating a Multi-VST System

PXIe-5842
Vector Signal Transceiver

PXIe-5842
Vector Signal Transceiver

ACC

ACTIVE

ACC

ACTIVE

PXIe-5655
Dual RF Synthesizer

ACC

ACTIVE

PFI 0

RF IN

RF OUT

PFI 0

RF IN

RF OUT

ALL RF PORTS 50Ω

5 V MAX
LVTTL

DIO
5 V MAX LVTTL

ALL RF PORTS 50 Ω

REF

RF OUT

5 V MAX
LVTTL

DIO
5 V MAX LVTTL

ALL RF PORTS 50 Ω

REF

RF OUT

LO 0 OUT
50 MHz to
7.2 GHz

REF OUT

0

1

2

3

MGT
100 Ω DIFF

IN
5 Vp-p
MAX

OUT
2 Vp-p
MAX
REVERSE

CTRL
1.8 V LVTTL

PULSE

IN

OUT

3.3 V LVTTL

LO IN
+15 dBm
MAX

LO OUT
+10 dBm
MAX
REVERSE

RF IN

LO OUT
+10 dBm
MAX
REVERSE

LO IN
+15 dBm
MAX

0

1

2

3

MGT
100 Ω DIFF

IN
5 Vp-p
MAX

LO IN
+15 dBm
MAX

LO 0 IN
+17 dBm
MAX

OUT
2 Vp-p
MAX
REVERSE

CTRL
1.8 V LVTTL

PFI 0
LVTTL

LO 1 IN
+17 dBm
MAX

LO OUT
+10 dBm
MAX
REVERSE

RF IN

LO OUT
+10 dBm
MAX
REVERSE

REF IN

PULSE

IN

OUT

3.3 V LVTTL

LO IN
+15 dBm
MAX

LO 1 OUT
50 MHz to
7.2 GHz

ESD
SENSITIVE

ESD
SENSITIVE

ESD
SENSITIVE

Configuring the Multi-VST System Software

After physically connecting the multi-VST system, you must programmatically
configure and calibrate the system.

Use NI Hardware Configuration Utility to associate the PXIe-5655 with each connected
VST. For more information on using this product, refer to the NI Hardware
Configuration Utility User Manual.

Note Because this configuration associates a single PXIe-5655 with multiple

126 ni.com

Creating a Multi-VST System

devices, NI Hardware Configuration Utility will display a warning. Click
Continue to ignore the warning.

The following installed LabVIEW examples demonstrate how to configure the system
software:

•  C:\Program Files\NI\LVAddons\rfsg\1\examples\instr\

niRFSG\RFSG Synchronization (NI 5842 Multi-VST
Configuration).vi

•  C:\Program Files\NI\LVAddons\nirfsa\1\examples\instr\

niRFSA\RFSA Synchronization (NI 5842 Multi-VST
Configuration).vi

•  C:\Program Files\NI\LVAddons\vstcalapi\1\instr.lib\niVST\
Calibration\ExternalCal\Public\5842\NI 5842 Multi-VST
Configuration Self Cal.vi

Note Multi-VST configuration does not support Multi-Span Spectrum or List
Mode.

Specifying the Clocking Configuration

To run the devices in this configuration, set the reference clock so that all downstream
devices have the correct clock. On the master session, where the PXIe-5842 receives its
reference clock from the PXIe-5655, complete the following tasks:

1.  Set the PXIe-5655 reference clock source and rate.
2.  Connect the reference clock export to the RefOut output.
3.  Set the reference clock export rate to 1 GHz.

© National Instruments 127

Creating a Multi-VST System

In the slave sessions, where the PXIe-5842 is downstream of the master session,
complete the following tasks:

1.  Set the reference clock source to RefIn input.
2.  Set the reference clock rate to 1 GHz.
3.  For other downstream devices, ensure the slave session is exporting its ref clock to

RefOut at 1 GHz. The PXIe-5842 will only accept a 1 GHz reference clock rate.

Self-Calibrating the Multi-VST System

To run a system self-calibration to account for power loss, use the Multi VST Self
Cal.vi.

This VI will self-calibrate each VST and reconfigure the output power of the LO to
overcome the splitter loss. This calibration data is then set on the device and will
persist until a regular self-calibration session is run.

Rerun a regular self-calibration after disassembling this system so the LO power can be
set back to normal. The Cal Step control allows the VI to run only the LO target power.

Note As a best practice, run the All calibration step every time. Perform an
advanced optimization by running LO calibration once during system
creation then run the Self Cal Only calibration step.

Related information:

128 ni.com

Creating a Multi-VST System

•  NI Hardware Configuration Utility User Manual

Common Multi-VST Issues

Multi-VST systems may experience certain issues.

The following table displays likely problems and solutions.

Problem

Solution

The device loses the upstream reference clock
and causes the PLL to unlock.

Use NI Hardware Configuration Utility to reset
the device and any other downstream devices.

Note As a best practice, leave the 1
GHz ref clock exporting at all times.

An IFIFO timeout error occurs during a RFSA or
RFSG reset.

The device clock was disconnected. To resolve
the issue, restart the controller.

© National Instruments 129

PXIe-5842 Operating Guidelines

Operating Guidelines
PXIe-5842  Operating Guidelines
PXIe-5842

Follow these guidelines when operating the PXIe-5842.

Device Warm-Up
Device Warm-Up

NI recommends warming up the PXIe-5842 hardware for 30 minutes before operation.

The unit is fully functional prior to this time, but frequency, amplitude accuracy, and
other specifications are not at warranted levels until the device has fully completed
warming up.

Note Warm up begins when the PXI Express chassis has been powered on
and the operating system has completely loaded.

Guidelines for Making Threaded RF Connections
Guidelines for Making Threaded RF Connections

Follow the guidelines to maximize connector life and connection quality.

•  Inspect connectors before making a connection:
◦  Ensure that the mating connectors are clean.
◦  When making a connection, ensure that the male center pin on the connector
aligns with the mating connector. Before mating connectors or cables, verify
that the connector ends match and will mate without damage.

•  When making a connection, never turn the cable or body: turn only the connector
nut. Turning the body instead of the nut causes the mating surfaces to wear down
and become loose, which causes a mismatch between the connectors and
degrades measurements. The turning motion of the surfaces can also produce
burrs and loose metal shavings that not only affect the measurement but can also
damage other surfaces these contaminants come into contact with.
•  You can use connector savers to reduce wear on critical connectors in

environments where you frequently change cables and connectors. Account for all
connector savers in the error budget for a measurement. Only use connector
savers when appropriate for the degree of accuracy your measurement requires.

130 ni.com

PXIe-5842 Operating Guidelines

Threaded RF Connector Care Guidelines
Threaded RF Connector Care Guidelines

Follow all guidelines to prevent damage to instruments and connectors and to make
the best possible measurements.

•  Tighten connectors without rotating the center pin.—Never tighten the

connectors, adapters, or cables such that the center pin rotates.

•  Avoid touching connectors with bare hands.—Touching connectors can

contaminate the connectors with natural skin oils and microscopic dirt particles.
Natural skin oils and microscopic dirt particles are difficult to remove from
connectors. Contaminated connectors can affect your measurements.

•  Observe the pin depth of mating connectors.—Mate the proper connectors with

PXIe-5842 instruments. Before mating the connector with another device or cable,
measure the pin depth of the device that you want to mate. To measure the pin
depth, use a pin depth gauge. Improper pin depth of mating connectors is a major
cause of failure in the field.
Figure 27. Features of Mating Connectors

2

3

1

4

4

1.  Reference plane
2.  Female connector
3.  Male connector
4.  Pin depth

The center pin of RF component connectors has a precision tolerance measured in
mils (1/1000 in.). Connectors on test devices that mate with RF components might
not be precision types and might not have the proper depth. To ensure suitability,
measure the connectors before mating.

Gauge the pin depth of the test device connector. If the pin depth measures
outside the tolerances listed in the following table, the center pin is too long and
can damage the termination connector:

© National Instruments 131

Port/Connector Type

Pin Depth

Gauge Setting

PXIe-5842 Operating Guidelines

3.5 mm (m), 3.5 mm (f)

2.92 mm (m), 2.92 mm (f)

1.85 mm (m), 1.85 mm (f)

-0.0002 in.

-0.0007 in.

-0.0002 in.

-0.0007 in.

-0.0002 in.

-0.0010 in.

Same as pin depth

Same as pin depth

Same as pin depth

If the test device connector measures out of tolerance in the "-" region, the center
pin is too short. While this connection does not cause damage, it results in a poor
connection and consequent performance degradation.

•  Avoid lateral pressure.—Never put lateral pressure on the center pin of the

connector.

•  Always torque connectors to the specified torque using a torque wrench.—Do

not over-tighten connectors. Over-tightening might damage the connector center
pin. Always use a 0.9 N · m (8 in. · lb) torque wrench when tightening 1.85 mm,
2.92 mm, 3.5 mm, and SMA connectors for PXIe-5842 instruments. Always tighten
to the torque specified in this manual.

•  Do not disturb Teflon tuning washers.—The center conductor on some RF

components contains a small Teflon tuning washer that compensates for minor
impedance discontinuities at the interface. The washer location is critical to the RF
component performance.

Notice Do not disturb the Teflon tuning washer in connectors.

•  Avoid mechanical shock.—Precision connectors are designed to withstand years
of normal bench handling. Handle the connectors carefully. Mechanical shock
significantly reduces the service life of the connectors.

132 ni.com

PXIe-5842 Operating Guidelines

•  Avoid applying excessive power.—Test instrumentation is rated for a specific

maximum continuous input power. Exceeding the maximum input power level
permanently damages the internal components. Refer to the safety,
environmental, and regulatory information document or the instrument
specifications for these levels.

•  Protect connectors when not in use.—Cover connectors that are not in use with

the dust cap included with your instrument.

Avoiding Damage when Making Direct Connections to
Avoiding Damage when Making Direct Connections to
PXIe-5842
the PXIe-5842
the

Because the PXIe-5842 is a precision RF instrument, it is sensitive to ESD and
transients. When you make direct connections to the PXIe-5842, you can avoid
damaging the RF ports by adhering to the following guidelines.

•  Apply external signals only while the hardware is powered on.

Notice Applying external signals while the hardware is powered off may
cause damage.

•  Ensure you are properly grounded when manipulating cables or antennas

connected to the instrument.

•  If you are using non-insulated devices, such as an RF antenna, ensure the devices

are maintained in a static-free environment.

•  If you are using an active device, such as a preamplifier or switch routed to the

PXIe-5842, ensure that the device cannot generate signal transients greater than
the RF and DC specifications of the PXIe-5842.

Avoiding Damage when Removing Modules from the
Avoiding Damage when Removing Modules from the
Chassis
Chassis

If you need to move your composite instrument or remove individual modules for any
reason, take care to avoid damaging modules or cables by first disconnecting all
interconnections made between the modules of the instrument.

© National Instruments 133

PXIe-5842 Operating Guidelines

Notice All interconnections made between the in-chassis modules of your
composite instrument must be disconnected prior to removing any modules
from the PXI chassis. Failure to do so could result in damage to the modules
or interconnection cables.

Power and Thermal Monitoring and Shutdown
Power and Thermal Monitoring and Shutdown
Conditions
Conditions

To protect itself from excessive heat, the PXIe-5842 shuts down when the system
detects excessive temperates.

During a shutdown condition, the PXIe-5842 automatically loads a low-power, nearly
empty FPGA image. Any attempt by an instrument driver to read or write to the module
returns an error.

Recovering from a Thermal Shutdown

To recover from a thermal shutdown:

•  Resolve the excessive heat issue to cool the system.
•  Ensure that the system temperature returns to acceptable levels.
•  Restart the system manually or reset the device. To reset the PXIe-5842, use the

Hardware Configuration Utility or NI MAX.

Note Warm up the PXIe-5842 for 30 minutes before operating. The warm-up
time is required to meet product specifications.

Maximizing Cooling Airflow

For optimal operation, ensure that the device is receiving proper airflow. Check that
the ambient temperature around the chassis is within specifications. To maximize
cooling airflow, adhere to the following guidelines:

•  Ensure the chassis fans are clean.
•  Install PXI slot blockers in all empty chassis slots. Slot blockers improve system

cooling in the chassis by rerouting airflow from empty slots to slots containing PXI

134 ni.com

PXIe-5842 Operating Guidelines

modules.

•  Install filler panels over slot blockers and unused slots. Filler panels improve the

cooling performance of the system.

•  Position the chassis so that inlet and outlet vents are clear from obstructions.

Note For detailed information about achieving optimal air circulation, refer
to the Maintaining Forced-Air Cooling topic in your chassis user manual. This
information is also available in the Cooling Guidelines document.

Monitoring the Temperature Shutdown Limit

The temperature shutdown limit is 99 °C, as measured on the FPGA.

To monitor how close the PXIe-5842 is to its temperature shutdown limit, check the
FPGA temperature listed in NI MAX.

To monitor the temperature with software, use the FPGA Temperature property or the
NIRFSA_ATTR_FPGA_TEMPERATURE attribute. To monitor the PXIe-5842 power
consumption, use the Module Power Consumption property or the
NIRFSA_ATTR_MODULE_POWER_CONSUMPTION attribute.

The PXIe-5842 meets all specifications in an NI 82-Watt cooling capacity chassis with
the fan mode set to Auto. To gain more thermal margin, set the fan mode to High.

Note Setting the fan mode to High increases thermal margin and ensures all
specifications are met, but it also raises fan noise and acoustic levels.

A deployed application may run hotter or cooler than it did during development.
Factors that affect temperature variations include:

•  Hardware differences
•  Changes in ambient temperature
•  Air flow
•  Chassis positioning
•  Adjacent modules
•  Power consumption

© National Instruments 135

PXIe-5842 Operating Guidelines

Ensure that your application has a wide enough margin to allow for temperature and
power variations between your development environment and deployment
environment.
Related information:

•  PXIe-5842 Specifications
•  Cooling Guidelines

Power On and Reset Conditions
PXIe-5842  Power On and Reset Conditions
PXIe-5842

The PXIe-5842 sets some hardware circuitry to certain states at power on and at device
reset.

Power on conditions are present after powering on or restarting the system and until
you specify a different configuration.

Reset conditions apply to the device state upon device reset.

At power on or device reset, elements of PXIe-5842 instruments are configured as
follows.

•  PXIe-5842 VST (Up to 2 GHz Bandwidth) and PXIe-5842 VST (4 GHz

Bandwidth)—Bidirectional terminals on the PXIe-5842 module are configured as
inputs, and output terminals are configured as high impedance.

•  RF OUT is configured as high impedance
•  RF OUT: LO OUT and RF IN: LO OUT are configured as high impedance
•  REF: OUT is configured as high impedance
•  PFI 0 is configured as an input

PULSE connectors are configured as high impedance

•  PXIe-5842 VST with 54 GHz Frequency Extension—Output and bidirectional

terminals are configured on the RMM-5585/RMM-5586.

•  RF IN/OUT PORTS: 0 and RF IN/OUT PORTS: 1 are terminated to 50 Ω
•  IF OUT is configured for output

PULSE connectors of the PXIe-5842 module are configured as high impedance
•  PXIe-5842 VST with S-Parameters—Ports are configured on the PXIe-5633 as

follows:

•  PORT 1 and PORT 2 are set to high-power termination
•  IF IN and IF OUT are set to tristate open

136 ni.com

PXIe-5842 Operating Guidelines

•  SWITCH OUT is set to termination; SWITCH IN is set to power detector

termination

VNA Measurement Calibration Guidelines
VNA Measurement Calibration Guidelines

For best VNA measurement results with the PXIe-5842 VST with S-Parameters, you
should always apply a valid measurement calibration dataset, or calset, to your
measurements. Refer to the guidelines for when to perform VNA measurement
calibration and for VNA measurement calibration best practices.

•  Always apply a measurement calibration that corresponds to your test setup to
VNA measurements. If you have saved a calset for a given configuration, ensure
that the calset is applied to the measurement.

•  NI recommends using high-performance, phase-stable RF test port cables. NI

offers several suitable cables to choose from, including the Sucoflex 526S (NI part
number 137445-01).

•  NI recommends configuring the PXIe-5842 VST with S-Parameters with the same

settings across both measurement calibration and the measurements that use that
calset.

•  The frequency list you define determines the frequencies that are used for the VNA

measurement calibration.

•  For the best measurement calibration results, do the following:

◦  Ensure that all connectors of the PXIe-5633, CAL-5501, and all cables that
connect the two are completely free of debris and are undamaged.

◦  Keep the physical layout of your test system, such as the orientation of cables,
as consistent as possible between measurement calibration and measurement
and between different measurements.

◦  If your test fixture includes any adapters or more complex elements between

the PXIe-5842 VST with S-Parameters and the calibration standards or DUT, you
can characterize and de-embed them to remove their influence from
measurement calibration and from VNA measurements.

•  Perform a new measurement calibration in any of the following situations:

◦  If any aspects of your test fixtures, such as new connectors or cables, are

replaced or added between the PXIe-5842 VST with S-Parameters and the DUT.

◦  If you change the set of frequencies or any attenuation settings used for your
VNA measurements to any frequencies or attenuation settings not already
included in the calset.

© National Instruments 137

PXIe-5842 Operating Guidelines

◦  For applications that require the highest accuracy:

▪  If you change the IF bandwidth for your measurements.
▪  If the ambient temperature in the test environment or the onboard

temperature of the instrument changes by an amount you deem significant
enough.

▪  To account for drift, if an amount of time you deem significant enough

elapses since the previous measurement calibration.

138 ni.com

Using the PXIe-5842

PXIe-5842
Using the PXIe-5842
Using the

Understand how to use the PXIe-5842, from basic measurements and programming to
optimizing performance for complex applications.

PXIe-5842
Connecting DUTs to the PXIe-5842
Connecting DUTs to the

Follow the procedure for your PXIe-5842 instrument to connect DUTs to the
instrument.

Before you connect DUTs or other equipment to the instrument, complete the
interconnection process for your PXIe-5842 instrument.

Related concepts:

•  Cables and Accessories

Making Connections to the PXIe-5842
Making Connections to the

VST
PXIe-5842  VST

Follow these instructions to connect a DUT to the PXIe-5842 VST.

Before you connect DUTs or other equipment to the instrument, complete the
interconnection process for the PXIe-5842 VST.
Depending on whether you want to input signals into the instrument or output signals
from it, connect a compatible cable as follows:

•  For input (vector signal analysis), connect to RF IN on the front panel of the

PXIe-5842 module.

•  For output (vector signal generation), connect to RF OUT on the front panel of the

PXIe-5842 module.

Tighten to a torque of 0.9 N · m to 1.0 N · m (8 lb · in. to 8.85 lb · in.).
Related concepts:

•  Cables and Accessories
•  PXIe-5842 Front Panels and Pinouts

© National Instruments 139

Using the PXIe-5842

Making Connections to the PXIe-5842
Making Connections to the
Frequency Extension
Frequency Extension

PXIe-5842  VST with

54 GHz
VST with 54 GHz

Follow these instructions to connect a DUT to the PXIe-5842 VST with 54 GHz
Frequency Extension and configure the relevant ports with driver software.

Before you connect DUTs or other equipment to the instrument, complete the
interconnection process for the PXIe-5842 VST with 54 GHz Frequency Extension.
Related concepts:

•  Cables and Accessories
•  PXIe-5842 Front Panels and Pinouts

Connecting to the PXIe-5842 VST with 54 GHz Frequency Extension by
Frequency

For the PXIe-5842 VST with 54 GHz Frequency Extension, the RF ports that you need to
make connections to for signal generation and analysis depend on the frequency you
are generating or analyzing.

In general, make connections to the PXIe-5563 module for frequencies below 26.5 GHz;
make connections to the RMM-5585/RMM-5586 remote measurement module for
frequencies of 23.5 GHz and above.

Make connections to individual modules within the PXIe-5842 VST with 54 GHz
Frequency Extension depending on signal frequency as follows:

•  Frequency < 26.5 GHz—Make connections to the PXIe-5563 module.

•  Ports: RF IN/OUT 0 to RF IN/OUT 1 (one port configured as input; other port

configured as output)

•  Cable: 3.5 mm (m)-to-3.5 mm (m)
•  Torque: 0.9 N · m (8 lb · in.) to 1.0 N · m (8.85 lb · in.)

•  Frequency ≥ 23.5 GHz—Make connections to the RMM-5585 or RMM-5586 device.
•  Ports: RF IN/OUT PORTS: 0 to RF IN/OUT PORTS: 1 (one port configured as

input; other port configured as output)

•  Cable: 1.85 mm (m)-to-1.85 mm (m)
•  Torque: 0.9 N · m (8 lb · in.)

140 ni.com

Using the PXIe-5842

Note The driver you use to configure the port determines the direction of
the port. For example, if you use NI-RFSG to configure the port, you are
configuring the port as an output.

Refer to Equivalent PXIe-5842 VST with 54 GHz Frequency Extension Port Strings and
Physical Connectors and Selecting Available Ports to configure the multifunction ports
of the PXIe-5563 and RMM-5585/RMM-5586 appropriately for input or output.

Equivalent PXIe-5842 VST with 54 GHz Frequency Extension Port Strings
and Physical Connectors

To control the PXIe-5842 VST with 54 GHz Frequency Extension, you specify port strings
in your development environment, using the driver API, that correspond to hardware
connectors on your instrument.

Physical ports on the PXIe-5842 VST with 54 GHz Frequency Extension hardware and
the port string names in NI RF drivers correspond as follows:

Signal Frequency

Hardware Module

<26.5 GHz

PXIe-5563

≥23.5 GHz

RMM-5585/RMM-5586

Hardware
Connector

Port String

RF IN/OUT 0

rfinout0

RF IN/OUT 1

rfinout1

RF IN/OUT PORTS: 0

rmm0/port0

RF IN/OUT PORTS: 1

rmm0/port1

For example, if you specify rmm0/port1, you are specifying port 1 on the RMM-5585
or RMM-5586 device to generate or acquire an RF signal.

Selecting Available Ports

You can use the NI-RFSA and NI-RFSG APIs to query available ports on your VST and
specify which ports to use. This functionality is important for VSTs with millimeter
wave functionality because these VSTs use different ports depending on the frequency
of the signal you are generating or analyzing.

© National Instruments 141

Using the PXIe-5842

Complete the following steps to check which ports are available and specify the ports
to use:

1.  Using NI-RFSA or NI-RFSG, read the Available Ports property to see the ports

available for use based on the instrument configuration you have installed and
connected.
The ports are returned as a comma-separated string and refer to corresponding
hardware connectors.

2.  Set the Selected Ports property to specify the port you want to use to generate or

acquire a signal.

Making Connections to the PXIe-5842
Making Connections to the

PXIe-5842  VST with

S-Parameters
VST with S-Parameters

Follow these instructions to connect a DUT to the PXIe-5842 VST with S-Parameters.

Before you connect DUTs or other equipment to the instrument, complete the
interconnection process for the PXIe-5842 VST with S-Parameters.

Make connections to the PXIe-5633 module for both VST and VNA functionality.

Depending on whether you want to use the instrument as a VST or VNA and, for VST
functionality, whether you want to input signals into the instrument or output signals
from it, connect a compatible cable as follows:

Instrument Functionality

Connection

VST

VNA

For input (vector signal analysis) or output
(vector signal generation), connect to PORT 1 or
PORT 2 on the front panel of the PXIe-5633
module.

Connect to PORT 1 and PORT 2 on the front
panel of the PXIe-5633 module.

Tighten to a torque of 0.9 N · m to 1.0 N · m (8 lb · in. to 8.85 lb · in.).

Note PORT 1 and PORT 2 are bidirectional ports than can serve as either
input or output. Whether these ports serve as input or output, and as VNA
ports or as VST ports, depends on the application that makes use of the

142 ni.com

Using the PXIe-5842

PXIe-5842 VST with S-Parameters.

Related concepts:

•  Cables and Accessories
•  PXIe-5842 Front Panels and Pinouts

Analyzing and Generating RF Signals with NI VSTs
Analyzing and Generating RF Signals with NI VSTs

In broad terms, NI VSTs are designed to receive (analyze) and output (generate) RF
signals. To do this, NI VSTs use separate instrument drivers—NI-RFSA, NI-RFSG—as well
as RFmx and other purpose-built applications that enable specific measurement
types.

The documentation in this manual focuses on programming your hardware using the
NI-RFSA, NI-RFSG, and RFmx APIs.

You can use the following software to control your NI VST:

•  NI-RFSA—Instrument driver that provides API-level control over RF signal analysis

functionality

•  NI-RFSG—Instrument driver that provides API-level control over RF signal

generation functionality

•  RFmx—Advanced measurement software for RF test systems that includes

personalities and purpose-built applications. Each personality enables a specific
family of RF measurements via a soft front panel and a programmatic API; the API
allows you to access signal analysis functionality of the personality in test
programs.

Each API has its own programming flow you need to understand to successfully control
your VST and meet the needs of your RF application.

In addition to NI-RFSA, NI-RFSG, and RFmx, NI provides high-level applications to
control RF instruments:

•  InstrumentStudio—Interactive soft front panel application that, for NI RF

instruments, surfaces the functionality of NI-RFSG and RFmx; also supports other

© National Instruments 143

Using the PXIe-5842

instrument types

•  Application-specific RF software—Purpose-built application environments for

specific RF testing workflows, such as RFIC test

Refer to the documentation for these applications for information on using them with
NI RF hardware.

Note Your instrument must have the appropriate hardware option—for
generation, analysis, or both—to access associated functionality in your
programs.

Related information:

•  InstrumentStudio documentation
•  Application Software for Wireless Design and Test

NI-RFSA
Analyzing RF Signals with RFmx and NI-RFSA
Analyzing RF Signals with RFmx and

RFmx and NI-RFSA both allow you to develop programs to control the signal analysis
functionality of NI VSAs and VSTs. NI recommends using the RFmx API for most signal
analysis applications, but there are specific cases where using the NI-RFSA API is
necessary to access specific functionality.

Use the following guidelines to determine if you should use NI-RFSA instead of RFmx.

Software Option

RFmx

NI-RFSA

144 ni.com

When to Use

Recommended for all signal analysis
applications unless you need specific
functionality available only through NI-RFSA.
Simplifies program development relative to
NI-RFSA.

•  Supporting existing NI-RFSA applications
•  If RFmx does not have the flexibility for

triggering and events that your application
requires

•  If your application makes use of NI-TClk

Software Option

When to Use

Using the PXIe-5842

synchronization

•  If your application makes use of peer-to-

peer streaming

•  If you are writing custom demodulation

algorithms

•  If your application requires the fastest

access to raw I/Q data

Refer to the documentation for the signal analysis software you chose to develop a
program with that software.

Analyzing RF Signals with RFmx
Analyzing RF Signals with RFmx

RFmx is a set of RF measurement personalities, each designed to enable a specific type
of RF measurements. Each RFmx personality includes a soft front panel and the
accompanying low-level APIs that give you access to the functionality of that
personality in programs you develop.

This documentation describes using the RFmx API to develop signal analysis programs
for your RF instrument.

Note While RFmx panels may make use of both signal analysis and signal
generation functionality, the low-level RFmx APIs provide access to signal
analysis functionality only. Use the NI-RFSG API to include signal generation
functionality in programs you develop.

There are two general parts of an RFmx program:

•  RFmxInstr—Set of entry points that create and end the RFmx session and that

focus on configuring your hardware to the settings you want for your
measurement; common to all RFmx personalities.

•  Measurement entry points—API entry points specific to and named for each RFmx

measurement personality; define the parameters of the measurement itself.

© National Instruments 145

Each RFmx personality includes both RFmxInstr entry points and the measurement-
specific entry points.

Using the PXIe-5842

Note Each RFmx personality includes a wide array of entry points to control
your instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create an RF signal analysis
program successfully.

1.  Initialize a Session

Use RFmxInstr Initialize NIRFSA to create a session with the PXIe-5842. All RFmx
programs must begin with an RFmxInstr function.

2.  Configure Hardware Settings

Use RFmxInstr functions and properties to configure your hardware to use the
correct settings for the measurement.

3.  Configure the Measurement

Use the functions and properties specific to your RFmx personality to configure
that measurement.

4.  Close the Session

Every RFmx session must be closed in order to deallocate memory, destroy
threads, and free operating system resources.

Related tasks:

•  Finding Examples for the PXIe-5842

Initialize a Session
Initialize a Session

Use RFmxInstr Initialize NIRFSA to create a session with the PXIe-5842. All RFmx
programs must begin with an RFmxInstr function.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call RFmxInstr
Initialize NIRFSA one time.

1.  Call RFmxInstr Initialize NIRFSA.

146 ni.com

Using the PXIe-5842

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
settings for the measurement.

1.  Call RFmxInstr Configure Frequency Reference and select the reference clock

source that corresponds to the physical configuration your instrument.
◦  Onboard Clock: Uses the clock within the PXIe-5842 instrument that is

provided by the PXIe-5655 module(s). The default option.

◦  RefIn: Uses an external reference clock source. For PXIe-5842 instruments, this
clock is from external equipment that supplies a compatible clock, which you
connect to the free REF IN port of an associated PXIe-5655 module.

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

© National Instruments 147

Using the PXIe-5842

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

Close the Session
Close the Session

Every RFmx session must be closed in order to deallocate memory, destroy threads,
and free operating system resources.

Required: Use RFmxInstr Close to conclude the session and free system resources.

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

Use Initialize to create a session with the PXIe-5842. All programs must begin with
Initialize.

2.  Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that

148 ni.com

Using the PXIe-5842

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

Related tasks:

•  Finding Examples for the PXIe-5842

Initialize a Session
Initialize a Session

Use Initialize to create a session with the PXIe-5842. All programs must begin with
Initialize.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call Initialize one time.

Configure the Reference Clock
Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that instruments
in the session are operating from a common timebase.

1.  Call Configure Ref Clock and select the reference clock source that corresponds to

the physical configuration your instrument.
◦  Onboard Clock: Uses the clock within the PXIe-5842 instrument that is

provided by the PXIe-5655 module(s). The default option.

◦  RefIn: Uses an external reference clock source. For PXIe-5842 instruments, this

© National Instruments 149

Using the PXIe-5842

clock is from external equipment that supplies a compatible clock, which you
connect to the free REF IN port of an associated PXIe-5655 module.

◦  PXI_Clk: Uses the PXI_CLK signal from the PXI backplane.

2.  If you selected an external reference clock source (RefIn), provide a valid clock

rate.
Valid clock rates for the PXIe-5655 LO within your PXIe-5842 instrument are as
follows:
◦  10 MHz
◦  100 MHz
◦  270 MHz
◦  3.84 MHz × y, where y is 4, 8, 16, 24, 25, or 32

Configure the Acquisition
Configure the Acquisition

Use NI-RFSA to configure the acquisition parameters for the RF signal you want to
analyze. There are two categories of acquisitions you can perform: I/Q acquisitions and
power spectrum acquisitions.

1.  Call Configure Acquisition Type to designate the type of acquisition to perform

◦  IQ: Acquire I/Q data
◦  Spectrum: Compute a power spectrum over a given frequency range

2.  Call Configure Reference Level and provide the maximum expected power of the

RF signal you are acquiring.

3.  Depending on the type of acquisition you want to make, set other parameters for

the acquisition:

Acquisition Type

I/Q

Spectrum

150 ni.com

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

Acquisition Type

Procedure

Using the PXIe-5842

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

© National Instruments 151

Using the PXIe-5842

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

Note Not all named trigger types in NI-RFSA support all signal conditions.

None

Signal acquisition starts immediately upon execution of the NI-RFSA Initiate function;
no Start or Script trigger is necessary. This configuration is the default for instruments
programmed with NI-RFSA.

Digital Edge

A digital edge trigger acts on the rising or falling edge of a digital signal.

A digital signal has two discrete levels: a high level and a low level. When the signal
transitions from high to low or from low to high, a digital edge is created. There are two

152 ni.com

Using the PXIe-5842

types of edges:

•  Rising—Occurs when the signal transitions from low level to high level.
•  Falling—Occurs when the signal transitions from high level to low level.

Triggers acting on a rising or a falling edge of a digital signal are edge triggers. Digital
triggering is possible on the RTSI lines, PFI lines, and the PXI Star Trigger line.

As the figure shows, an edge trigger can be configured to occur either at the place
labeled Falling Edge of Signal or Rising Edge of Signal.

Figure 28. Configuring the Edge Trigger

You can configure each named trigger to operate based on a digital edge.

I/Q Power Edge Trigger

After data has been downconverted and decimated, NI-RFSA calculates the
instantaneous power of the I/Q data (I2 + Q2) in the digital downconverter and uses this
value as a source for the Reference Trigger for the IF digitizer.

As shown in the figure, an I/Q power edge trigger can be configured to occur either at
the positive slope or the negative slope.

Figure 29. Configuring the I/Q Power Edge Trigger

Trigger
Level

Trigger on
Positive Slope

Trigger on
Negative Slope

© National Instruments 153

High LevelLow LevelRising edge of signalFalling edge of signalUsing the PXIe-5842

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

154 ni.com

Using the PXIe-5842

Close the Session
Close the Session

Every NI-RFSA session must be closed in order to deallocate memory, destroy threads,
and free operating system resources.

Required: Use Close to conclude the session and free system resources.

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

Use Initialize to create a session with the PXIe-5842. All programs must begin with
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

© National Instruments 155

Every NI-RFSG session must be closed in order to deallocate memory, destroy
threads, and free operating system resources. Closing a session also stops
waveform generation, if it hasn't been stopped already.

Using the PXIe-5842

Related tasks:

•  Finding Examples for the PXIe-5842

Initialize a Session
Initialize a Session

Use Initialize to create a session with the PXIe-5842. All programs must begin with
Initialize.

Initializing returns an instrument handle with the session configured to a known state.
Initialization can take a significant amount of time compared to other functions, so
you should not include it in loops. Ideally, your program should call Initialize one time.

Configure the Reference Clock
Configure the Reference Clock

Configure the correct settings for the reference clock, which ensures that instruments
in the session are operating from a common timebase.

1.  Call Configure Ref Clock and select the reference clock source that corresponds to

the physical configuration your instrument.
◦  Onboard Clock: Uses the clock within the PXIe-5842 instrument that is

provided by the PXIe-5655 module(s). The default option.

◦  RefIn: Uses an external reference clock source. For PXIe-5842 instruments, this
clock is from external equipment that supplies a compatible clock, which you
connect to the free REF IN port of an associated PXIe-5655 module.

◦  PXI Clock: Uses the PXI_CLK signal from the PXI backplane.

2.  If you selected an external reference clock source (RefIn), provide a valid ref

clock rate.
Valid clock rates for the PXIe-5655 LO within your PXIe-5842 instrument are as
follows:
◦  10 MHz
◦  100 MHz
◦  270 MHz

156 ni.com

Using the PXIe-5842

◦  3.84 MHz × y, where y is 4, 8, 16, 24, 25, or 32

Configure the RF Output Signal
Configure the RF Output Signal

Use NI-RFSG to configure the parameters of the RF signal you want to generate.

Complete the following steps to configure the center frequency, output power level,
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

© National Instruments 157

Using the PXIe-5842

For example, you can use Export Signal to route a signal from a first instrument to a
second instrument that is awaiting that signal, as defined by the Configure Trigger
instance for the second instrument.

NI-RFSG Named Trigger Types

Named trigger types in NI-RFSG define the action you want an instrument or
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

158 ni.com

as shown in the following figure. The instrument ignores a Start trigger received after
signal generation has started.

Using the PXIe-5842

Figure 30. NI-RFSG Start Trigger Model

Start
Trigger

Waveform Repeats
Continuously

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

© National Instruments 159

Using the PXIe-5842

Figure 31. NI-RFSG Start Trigger Sources

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

Figure 32. NI-RFSG Script Trigger Sources

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

160 ni.com

Using the PXIe-5842

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

A digital edge trigger acts on the rising or falling edge of a digital signal.

A digital signal has two discrete levels: a high level and a low level. When the signal
transitions from high to low or from low to high, a digital edge is created. There are two
types of edges:

•  Rising—Occurs when the signal transitions from low level to high level.
•  Falling—Occurs when the signal transitions from high level to low level.

© National Instruments 161

Using the PXIe-5842

Triggers acting on a rising or a falling edge of a digital signal are edge triggers. Digital
triggering is possible on the RTSI lines, PFI lines, and the PXI Star Trigger line.

As the figure shows, an edge trigger can be configured to occur either at the place
labeled Falling Edge of Signal or Rising Edge of Signal.

Figure 33. Configuring the Edge Trigger

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

162 ni.com

High LevelLow LevelRising edge of signalFalling edge of signalUsing the PXIe-5842

NI-RFSG Event Types

NI-RFSG includes specific events you can use in tandem with triggers to coordinate
actions across instruments.

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

Figure 34. Waveform Output and Associated Marker Event

•  tm1—Duration of delay between the configured waveform sample n and

generation of the associated marker event. For most NI VSTs, configurable with

© National Instruments 163

WaveformSample nWaveform Outputon Output ConnectorMarker Eventtm1tm2Using the PXIe-5842

NI-RFSG Events Delay and Relative Delay.

•  tm2—Marker event pulse duration. For most NI VSTs, configurable with NI-RFSG

Width Units and Width Value.

You can use NI-RFSG to configure the characteristics of the pulse generated as the
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

164 ni.com

Using the PXIe-5842

Close the Session
Close the Session

Every NI-RFSG session must be closed in order to deallocate memory, destroy threads,
and free operating system resources. Closing a session also stops waveform
generation, if it hasn't been stopped already.

Required: Use Close to conclude the session and free system resources.

Designing VNA Measurement Applications for the
Designing VNA Measurement Applications for the
PXIe-5842  VST with
PXIe-5842

S-Parameters
VST with S-Parameters

Use the PXIe-5842 VST with S-Parameters to make VNA measurements—S-parameters
and incident and reflected waves—for 1-port and 2-port devices. To design
measurement programs for the PXIe-5842 VST with S-Parameters, use the RFmx VNA
API.

You can also control the PXIe-5842 VST with S-Parameters interactively with
InstrumentStudio. This process describes how to use the RFmx VNA API to build VNA
measurement applications for the PXIe-5842 VST with S-Parameters that include
measurement calibration with the CAL-5501 vector calibration module.

Note RFmx VNA includes a wide array of entry points to control your
instrument and optimize its behavior for your application. This process
describes only the basic programming flow to create a VNA measurement
program successfully.

Initialize a Session

Use RFmxInstr Initialize to create a session with the PXIe-5842. All RFmx programs
must begin with an RFmxInstr function.

Initializing returns an instrument handle with the session configured to a known state.

Initializing can take a significant amount of time compared to other functions, so you
should not include it in loops. Ideally, your program should call RFmxInstr Initialize
one time.

© National Instruments 165

Using the PXIe-5842

Call RFmxInstr Initialize.

Tip For most RFmx personalities, you can include measurement functions
from any number of personalities in a single session initialized with
RFmxInstr Initialize.

The exception is RFmx VNA. You cannot use RFmx VNA functions in a session
that includes any other RFmx personalities.

De-Embed Fixtures

De-embed the effects of all cabling and connectors between your DUT and the
PXIe-5842 instrument. De-embedding ensures that you are characterizing your DUT,
not your larger test setup.

This process assumes your overall testing process uses an .s2p file to accomplish de-
embedding.

Note De-embedding is not necessary in certain situations where you can
perform measurement calibration so that the measurement calibration plane
is at the DUT. If you can do so, you can avoid de-embedding in the following
situations:

•  If you are using a manual calibration kit.
•  If you are using the PXIe-5842 VST with S-Parameters with a
connectorized fixture that can connect to the CAL-5501.

This process describes de-embedding for 2-port devices.

You can de-embed elements of your physical setup with RFmxInstr Load S-parameter
External Attenuation Table from S2P File.

Iterate through the following steps for each port.

1.  Specify, or allow an operator to input, the following information:

166 ni.com

Using the PXIe-5842

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

The PXIe-5842 VST with S-Parameters can measure either S-parameters or incident
and reflected waves.

S-parameters are represented with the convention Sxy, where x is the measure port

© National Instruments 167

Using the PXIe-5842

and y is the source port.

For example, consider the following setup:

•  PORT 1 of a PXIe-5633 module: connected to DUT input
•  PORT 2 of the same PXIe-5633 module: connected to DUT output

In this case, S21 refers to sourcing on port 1 and measuring on port 2.

The PXIe-5842 VST with S-Parameters can also measure incident and reflected waves.

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

e.  Define the format for the measurement:

168 ni.com

Using the PXIe-5842

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

The PXIe-5842 VST with S-Parameters is designed to use the CAL-5501 vector
calibration module for electronic calibration. The PXIe-5842 VST with S-Parameters
also supports manual calibration, in which you use your own calibration standards to
perform measurement calibration.

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
proceed.

© National Instruments 169

Using the PXIe-5842

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

Related concepts:

•  VNA Measurement Calibration Guidelines

Initiate VNA Measurement

Initiate the instrument to apply any configured settings and begin VNA measurement.

Call RFmx VNA Initiate.
Initiate does the following:

•  Applies all configured settings, if the settings have not already been applied
•  Starts VNA measurement, including any corrections you have configured

170 ni.com

Using the PXIe-5842

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

Improving NI-TClk
Improving

Synchronization of RF Instruments
NI-TClk  Synchronization of RF Instruments

The PXIe-5842 supports NI-TClk, which allows for multi-instrument synchronization
with fine alignment. You can use NI-RFSA and NI-RFSG to further optimize NI-TClk
synchronization.

Refer to the NI-TClk Synchronization Help for more information about instrument
synchronization.

Related information:

•  NI-TClk Synchronization Help

© National Instruments 171

Using the PXIe-5842

NI-TClk  Manual Calibration Using
NI-TClk

NI-RFSA
Manual Calibration Using NI-RFSA

Complete the following steps to improve the synchronization accuracy by lowering
skew and minimizing jitter of NI-TClk synchronized devices using manual calibration.

1.  Connect the external signal to the VSTs. For best performance, minimize

unnecessary skew by using matched length cables.

2.  Configure the VST for acquisition using NI-TClk. If using LabVIEW, use the RFSA
Synchronization (TClk, Shared LO and Reference Clock)
(5840).vi example.

3.  Start the acquisition and measure the skew between devices, noting the amount of

jitter.

4.  Read the value from the Absolute Delay property. Stop the acquisition, modify the

value, and write it back to apply skew correction.

5.  Repeat steps 3 and 4 until you achieve the appropriate synchronization results.
6.  Read the value from the Absolute Delay property and store the value for future

synchronization sessions.

To apply the manual calibration synchronization results, write the stored value to the
Absolute Delay property before calling the NI-TClk Synchronize.

NI-TClk  Manual Calibration Using
NI-TClk

NI-RFSG
Manual Calibration Using NI-RFSG

Complete the following steps to improve the synchronization accuracy by lowering
skew and minimizing jitter of NI-TClk synchronized devices using manual calibration.

1.  Connect the RF output connector on the vector signal transceivers (VSTs) to a

multi-channel signal analyzer. For best performance, minimize unnecessary skew
by using matched length cables.

2.  Configure the VST for generation using NI-TClk. If using LabVIEW, use the RFSG

Synchronization (TClk, Shared LO).vi example.

3.  Start the generation and measure the skew between devices, noting the amount of

jitter.

4.  Read the value from the Absolute Delay property. Stop the generation, modify the

value, and write it back to apply skew correction.

5.  Repeat steps 3 and 4 until you achieve the appropriate synchronization results.
6.  Read the value from the Absolute Delay property and store the value for future

172 ni.com

Using the PXIe-5842

synchronization sessions.

To apply the manual calibration synchronization results, write the stored value to the
Absolute Delay property before calling NI-TClk Synchronize.

Local Oscillators
Local Oscillators

PXIe-5842 instruments can use separate local oscillators (LOs) for each RF signal path
or a shared LO; separate LOs allow for different LO frequencies between the RF input
and RF output channels. PXIe-5842 instruments can also use external LOs.

The PXIe-5842 module does not supply its own LOs; it receives them from the
associated PXIe-5655.

The LOs for RF input and RF output are phase-locked to the same reference clock.

External Local Oscillators

You can use external LOs instead of the onboard LOs on the PXIe-5655 module for
either or both of the RF IN and RF OUT signal paths of the PXIe-5842.

For using external LOs with a PXIe-5842 instrument, use the ports of the associated
PXIe-5655 depending on the PXIe-5842 signal path as follows:

PXIe-5842 Instrument Signal Path

Relevant PXIe-5655 Port for External LO

RF IN

RF OUT

LO 1 IN

LO 0 IN

Related tasks:

•  Using an External LO

LO Sharing with NI-RFSA
LO Sharing with

NI-RFSA  and

NI-RFSG
and NI-RFSG

LO sharing is a technique to reduce phase noise for some measurements by sharing
the local oscillator (LO) between NI-RFSA and NI-RFSG sessions to the same

© National Instruments 173

Using the PXIe-5842

instrument. To share the same LO between an NI-RFSA and NI-RFSG session, you must
initiate both sessions and ensure both sessions use the same shared setting.

The LO for the instrument can be either an onboard LO or an external LO:

•  Onboard LO—Integrated LO within the VST
•  External LO—LO for the instrument from an external (non-NI) device that operates

in place of the onboard LO

The exact manner in which the LO functions within your PXIe-5842 instrument
depends on the instrument configuration.

LO Sharing for the PXIe-5842
LO Sharing for the

VST
PXIe-5842  VST

The PXIe-5655 module serves as the local oscillator within the PXIe-5842 VST. LO
sharing with this instrument involves controlling the behavior of the PXIe-5655 within
the overall instrument.

The following high-level block diagrams show the difference between an independent
and shared LO configuration for the PXIe-5655 LO 0 and LO 1 paths within the
PXIe-5842 VST.

Figure 35. LO Source: Set to Onboard

174 ni.com

LO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INFigure 36. LO Source: Set to SG SA Shared

Using the PXIe-5842

Note In the shared configuration, the shared LO must use the same
frequency or the second driver session will return an error when committing
the settings to hardware.

Figure 37. LO Source: Set to LO In

To share the same LO signal between NI-RFSA and NI-RFSG sessions, configure the
NI-RFSA or NI-RFSG LO Source property as appropriate for your hardware
configuration, as shown in the following table.

Table 50. LO Source Configurations

PXIe-5842 VST Hardware Configuration

PXIe-5655 (independent configuration)

External device LO connected to PXIe-5655 LO 0 IN or LO 1 IN
(independent configuration)

PXIe-5655 (shared configuration using LO 0)

NI-RFSA and NI-RFSG LO
Source Values

Onboard

LO In

SG SA Shared1

1. For NI-RFSG, the SG SA Shared and Automatic SG SA Shared values are equivalent.

© National Instruments 175

LO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INLO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INUsing the PXIe-5842

When using the PXIe-5842 VST, setting the LO Source property to SG SA Shared in an
NI-RFSG session enables NI-RFSA to share the internal LO 0 synthesizer if requested by
NI-RFSA. If an NI-RFSG session has already set the LO Source property to something
other than SG SA Shared property value in an NI-RFSG session, you cannot request
sharing using NI-RFSA.

Setting the LO Source property to SG SA Shared in an NI-RFSA session results in using
the PXIe-5655 LO 0 synthesizer. You can also choose not to use the LO 0 shared
configuration in the NI-RFSA session by instead setting the LO Source property to
Onboard or LO In.

Note Output power levels at LO 0 OUT may vary slightly (<1 dB, typical)
when set to SG SA Shared as NI-RFSA connects or disconnects the shared
signal.

LO Sharing for the
LO Sharing for the PXIe-5842
Extension
Extension

PXIe-5842  VST with

VST with 54 GHz

Frequency
54 GHz  Frequency

The PXIe-5842 VST with 54 GHz Frequency Extension can use an independent LO
configuration or a shared LO configuration for millimeter wave and for baseband
frequencies.

LO sharing for millimeter wave applies to generating or acquiring signals of Frequency
≥ 23.5 GHz. The RF ports of the RMM-5585 or RMM-5586 device within the PXIe-5842
VST with 54 GHz Frequency Extension are used for these frequencies. LO sharing for
this frequency range originates from LO1 in the rightmost PXIe-5655 module within the
instrument.

LO sharing at baseband applies to generating or acquiring signals of Frequency <
26.5 GHz. The RF ports of the PXIe-5563 device within the PXIe-5842 VST with 54 GHz
Frequency Extension are used for these frequencies. LO sharing for this frequency
range originates from LO2 in the leftmost PXIe-5655 device within the instrument.

LO Sharing with RMM-5585 and RMM-5586 RF IN/OUT Ports

The LO1 stage is used when connecting the PXIe-5842 VST with 54 GHz Frequency

176 ni.com

Using the PXIe-5842

Extension with a DUT using one of the RF IN/OUT ports on the RMM-5585 or RMM-5586,
which are used for signals of Frequency ≥ 23.5 GHz.

For the PXIe-5842 VST with 54 GHz Frequency Extension, LO1 and LO2 are defined as
follows:

•  LO1—PXIe-5655 module that interconnects with the RMM-5585/RMM-5586; the

rightmost PXIe-5655 within the composite instrument

•  LO2—PXIe-5655 module that interconnects with and is installed adjacent to the
PXIe-5842 module; the leftmost PXIe-5655 within the composite instrument

The following high-level block diagrams show the difference between an independent
and shared LO configuration within the RMM-5585/RMM-5586, as provided by the LO1
PXIe-5655.

Figure 38. PXIe-5842 VST with 54 GHz Frequency Extension Independent LO Configuration, Frequency
≥ 23.5 GHz

UPCONVERTER/SHARED LO IN

×N

×N

×N

×N

DOWNCONVERTER LO IN

IF IN

IF OUT

RMM-5585/RMM-5586

RF IN/OUT 1

RF IN/OUT 0

Figure 39. PXIe-5842 VST with 54 GHz Frequency Extension Shared LO Configuration, Frequency ≥

© National Instruments 177

23.5 GHz

RF IN/OUT 1

RF IN/OUT 0

Using the PXIe-5842

UPCONVERTER/SHARED LO IN

×N

×N

×N

×N

DOWNCONVERTER LO IN

IF IN

IF OUT

RMM-5585/RMM-5586

In the shared configuration, the shared LO must use the same frequency or an error
returns in the second driver session when committing the settings to hardware.

To share the same LO signal between NI-RFSA and NI-RFSG sessions, set the NI-RFSA
and NI-RFSG LO Source property for LO1 and LO2 as appropriate for your hardware
configuration, as shown in the following table.

Note You can independently select different LO source configurations for the
LO1 and LO2 stages. Use the Active Channel property to select LO1 or LO2
before setting the LO source attribute. The LO1 LO Source attributes can be
used in conjunction with any valid LO2 configuration.

Table 51. LO Source Configurations

PXIe-5842 VST with 54 GHz Frequency Extension Hardware
Configuration

NI-RFSA and NI-RFSG LO
Source Values

PXIe-5655 (independent configuration)

External device LO connected to PXIe-5655 LO 0 IN or LO 1 IN front
panel connectors (independent configuration)

Onboard

LO In

PXIe-5655 (shared configuration using LO 0 front panel connector)

SG SA Shared2

2. For NI-RFSG, the SG SA Shared and Automatic SG SA Shared values are equivalent.

178 ni.com

Using the PXIe-5842

LO Sharing with PXIe-5563 RF IN/OUT Ports

The LO2 stage is used when connecting the PXIe-5842 VST with 54 GHz Frequency
Extension with a DUT using one of the RF IN/OUT ports of the integral PXIe-5563
module, which are used for signals of Frequency < 26.5 GHz.

The following high-level block diagrams show the difference between an independent
and shared LO configuration for the LO 0 and LO 1 paths of the PXIe-5655 designated
LO2 within the PXIe-5842 VST with 54 GHz Frequency Extension.

Figure 40. LO Source: Set to Onboard

Figure 41. LO Source: Set to SG SA Shared

Note In the shared configuration, the shared LO must use the same
frequency or the second driver session will return an error when committing
the settings to hardware.

© National Instruments 179

LO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INLO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INFigure 42. LO Source: Set to LO In

Using the PXIe-5842

To share the same LO signal between NI-RFSA and NI-RFSG sessions, set the NI-RFSA or
NI-RFSG LO Source property for LO2 as appropriate for your hardware configuration, as
shown in the following table.

Table 52. LO2 Source Configurations

PXIe-5842 VST with 54 GHz
Frequency Extension
Hardware Configuration

Property
Value

NI-RFSA and NI-RFSG LO Source Values

Attribute Value

PXIe-5655 (independent
configuration)

Onboard

•  NIRFSA_VAL_ONBOARD_STR
•  NIRFSG_VAL_LO_SOURCE_ONBOARD_STR

External device LO connected
to PXIe-5655 LO 0 IN or LO 1 IN
(independent configuration)

LO In

•  NIRFSA_VAL_LO_IN_STR
•  NIRFSG_VAL_LO_SOURCE_LO_IN_STR

PXIe-5655 (shared
configuration using LO 0)

SG SA
Shared

•  NIRFSA_VAL_LO_SOURCE_SG_SA_SHARED_STR
•  NIRFSG_VAL_LO_SOURCE_SG_SA_SHARED_STR

LO Sharing for the PXIe-5842
LO Sharing for the

PXIe-5842  VST with

S-Parameters
VST with S-Parameters

The PXIe-5655 module serves as the local oscillator within the PXIe-5842 VST with
S-Parameters. LO sharing with this instrument involves controlling the behavior of the
PXIe-5655 within the overall instrument.

The following high-level block diagrams show the difference between an independent

180 ni.com

LO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INand shared LO configuration for the PXIe-5655 LO 0 and LO 1 paths within the
PXIe-5842 VST with S-Parameters.

Figure 43. LO Source: Set to Onboard

Using the PXIe-5842

Figure 44. LO Source: Set to SG SA Shared

Note In the shared configuration, the shared LO must use the same
frequency or the second driver session will return an error when committing
the settings to hardware.

Figure 45. LO Source: Set to LO In

To share the same LO signal between NI-RFSA and NI-RFSG sessions, configure the
NI-RFSA or NI-RFSG LO Source property as appropriate for your hardware

© National Instruments 181

LO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INLO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INLO 0 OUTRF OUT: LO INRF IN: LO INLO 0 INLO 1 OUTLO 1 INUsing the PXIe-5842

configuration, as shown in the following table.

Table 53. LO Source Configurations

PXIe-5842 VST with S-Parameters Hardware Configuration

NI-RFSA and NI-RFSG LO
Source Values

PXIe-5655 (independent configuration)

External device LO connected to PXIe-5655 LO 0 IN or LO 1 IN
(independent configuration)

PXIe-5655 (shared configuration using LO 0)

Onboard

LO In

SG SA Shared3

When using the PXIe-5842 VST (Up to 2 GHz Bandwidth), setting the LO Source
property to SG SA Shared in an NI-RFSG session enables NI-RFSA to share the internal
LO 0 synthesizer if requested by NI-RFSA. If an NI-RFSG session has already set the LO
Source property to something other than SG SA Shared property value in an NI-RFSG
session, you cannot request sharing using NI-RFSA.

Setting the LO Source property to SG SA Shared in an NI-RFSA session results in using
the PXIe-5655 LO 0 synthesizer. You can also choose not to use the LO 0 shared
configuration in the NI-RFSA session by instead setting the LO Source property to
Onboard or LO In.

Note Output power levels at LO 0 OUT may vary slightly (<1 dB, typical)
when set to SG SA Shared as NI-RFSA connects or disconnects the shared
signal.

Using an External LO
Using an External LO

For VST operation, you can use external LOs instead of the onboard LOs of the integral
PXIe-5655 module of a PXIe-5842 instrument for either or both of the RF IN and RF OUT
signal paths of the instrument.

1.  Connecting an External LO to a PXIe-5842 Instrument

Connect a compatible external LO to the correct ports of your PXIe-5842
instrument. The connections you need to make depend on which PXIe-5842

3. For NI-RFSG, the SG SA Shared and Automatic SG SA Shared values are equivalent.

182 ni.com

Using the PXIe-5842

instrument you are using.

2.  Configuring PXIe-5842 Instruments to Use an External LO

Once the external LO is connected to your PXIe-5842 instrument, use the NI-RFSA
and NI-RFSG drivers to correctly configure the PXIe-5842 to use the external LO.

3.  Specifying LO Frequency With Automatic Frequency Offset

To use automatic offset with an external LO, you should provide a frequency as
requested by the NI-RFSA or NI-RFSG driver.
4.  Specifying LO Power When Using an External LO

To achieve better image and LO leakage performance with an external LO, set the
LO IN power level of the PXIe-5842 to the actual output power level of the external
LO.

Connecting an External LO to a PXIe-5842
Connecting an External LO to a

Instrument
PXIe-5842  Instrument

Connect a compatible external LO to the correct ports of your PXIe-5842 instrument.
The connections you need to make depend on which PXIe-5842 instrument you are
using.

When using an external LO with the PXIe-5842, NI recommends sharing a common
reference clock between the PXIe-5842 and the external LO device. Before you connect
an external LO, and depending on your application, validate that the PXIe-5842
instrument and the external LO are compatible:

Application

Validating Compatibility

Export a reference clock from the PXIe-5842
module to the reference clock input of an
external LO device

Export a reference clock from the external LO
device to the PXIe-5655 module within the
PXIe-5842 instrument

Check that the PXIe-5842 REF: OUT power and
frequency specifications are compatible with the
reference clock input of the external LO device.
Refer to the PXIe-5842 Specifications for details.

Check that the power and frequency
specifications of the external LO's reference
clock output are compatible with the PXIe-5655.
Refer to the PXIe-5655 Specifications for details.

Connect the output of the external LO to the relevant PXIe-5655 LO IN connector:

PXIe-5842 Signal Path

Relevant PXIe-5655 Port

RF IN

LO 1 IN

© National Instruments 183

Using the PXIe-5842

PXIe-5842 Signal Path

Relevant PXIe-5655 Port

RF OUT

LO 0 IN

Configuring PXIe-5842
Configuring

Instruments to Use an External LO
PXIe-5842  Instruments to Use an External LO

Once the external LO is connected to your PXIe-5842 instrument, use the NI-RFSA and
NI-RFSG drivers to correctly configure the PXIe-5842 to use the external LO.

If the LO source is another PXI module, both the LO source and the PXIe-5842
instrument can use the PXI backplane clock as a reference. Otherwise, you can route a
reference clock to or from the PXIe-5842 instrument.

Complete the following steps to use a compatible external LO with the PXIe-5842:

1.  Depending on your application, use either of the following methods to establish a

common reference frequency between the external LO and the PXIe-5842:

Option

Description

Export a reference clock from the PXIe-5842
module to the reference clock input of an
external LO device

Export the reference clock to the REF: OUT
terminal of the PXIe-5842 module by setting
the NI-RFSA Ref Clock Exported Terminal
property or the NI-RFSG Reference Clock
Export Output Terminal property to RefOut.
The default REF: OUT frequency is 10 MHz.

Note To export the clock at
different rates, you can use the
NI-RFSA Ref Clock Exported Rate
property or the NI-RFSG Reference
Clock Exported Rate (Hz) property.
If you use NI-RFSA and NI-RFSG
simultaneously, both must specify
the same rate.

Export a reference clock from the external LO
device to the PXIe-5655 module within the
PXIe-5842 instrument

a.  Connect the reference clock output of the
external LO device to the PXIe-5655 REF IN
connector.

b.  Using the NI-RFSA or NI-RFSG APIs, set the

184 ni.com

Option

Description

Using the PXIe-5842

reference clock source and rate of the
overall PXIe-5842 instrument. Set the
reference clock source to RefIn and the
reference clock rate to the appropriate
rate.
▪  Use Configure Ref Clock to set both

the source and rate

▪  Use the NI-RFSG Reference Clock

Source and Reference Clock Rate (Hz)
properties or the NI-RFSA Ref Clock
Source and Ref Clock Rate properties

2.  Set the NI-RFSG LO In Power (dBm) property or the NI-RFSA LO In Power property

to the power level of the LO signal from the external source.

3.  Query the NI-RFSG LO Frequency (Hz) property or the NI-RFSA LO Frequency
property and ensure the frequency of the external LO is set to this value.

Note This value may not be the same as the RF center frequency.

Specifying LO Frequency With Automatic Frequency Offset
Specifying LO Frequency With Automatic Frequency Offset

To use automatic offset with an external LO, you should provide a frequency as
requested by the NI-RFSA or NI-RFSG driver.

When writing your application, complete the following steps to specify the LO
frequency in case the driver applies frequency offset as described in Automatic
Frequency Offset.

1.  Set all the properties for the acquisition or generation, including the NI-RFSA I/Q

Carrier Frequency property or the NI-RFSG Frequency property.

Note Do not set the LO Frequency property. If you previously set the LO
Frequency property, reset it.

2.  Depending on whether you want NI-RFSA and NI-RFSG to both use the external LO,

set LO Source in one or both sessions as follows:

© National Instruments 185

Using the PXIe-5842

Option

LO Source Setting

Use external LO for either NI-RFSA or NI-RFSG  LO In in relevant session

Use external LO across both NI-RFSA and
NI-RFSG

SG SA Shared in both sessions

3.  Optional: If you want to apply automatic frequency offset, complete the following.
a.  Set the Signal Bandwidth property to a value within the frequency offset

bandwidth for your hardware options and selected frequency. Refer to the
PXIe-5842 Specifications for valid values.
By default, the driver then applies automatic frequency offset if it is able to,
based on your Signal Bandwidth and other property settings.

b.  If you want the driver to return an error if it cannot apply automatic offset, set

the Upconverter Frequency Offset Mode to Enabled.
4.  Query the LO Frequency to get the expected frequency.
5.  Set the frequency of your LO source to the expected frequency.
6.  Set the LO Frequency property to the actual frequency of your LO source in case

the source does any rounding.

Related concepts:

•  Automatic Frequency Offset

Related information:

•  PXIe-5842 Specifications

Specifying LO Power When Using an External LO
Specifying LO Power When Using an External LO

To achieve better image and LO leakage performance with an external LO, set the LO IN
power level of the PXIe-5842 to the actual output power level of the external LO.

1.  Query the actual output power level of the external LO.
2.  Set the NI-RFSA or NI-RFSG LO IN Power Level property to the value returned in the

previous step.

186 ni.com

Using the PXIe-5842

Improving Spurious Performance
Improving Spurious Performance

To improve spurious performance related to baseband mixing spurs, you can reduce
the power level of baseband signals.

Reducing the power level of baseband signals improves spurious performance
because the PXIe-5842 uses a direct conversion topology. Direct conversion topologies
do not allow for multiple stages of filtering common in multistage IF systems; any
signals present within the instantaneous bandwidth of the instrument are converted
down to baseband.

To improve spurious performance, increase the reference level for RF IN and use the
Digital Gain (dB) property for RF OUT.

Timing Configurations
Timing Configurations

There are multiple reference clock sources available for PXIe-5842 instruments.

Configuring Onboard Reference Clock Timing
Configuring Onboard Reference Clock Timing

The onboard reference clock configuration of the PXIe-5842 uses a 100 MHz signal from
an integral LO within the instrument.

The source of the onboard reference clock depends on your PXIe-5842 instrument:

•  PXIe-5842 VST (Up to 2 GHz Bandwidth) and PXIe-5842 VST (4 GHz

Bandwidth)—Associated PXIe-5655

•  PXIe-5842 VST with 54 GHz Frequency Extension—Associated PXIe-5655
designated LO2, which is installed adjacent to the PXIe-5842 module

•  PXIe-5842 VST with S-Parameters—

•  VST functionality: associated PXIe-5655
•  VNA functionality: PXI backplane

Complete the following steps to configure the PXIe-5842 to lock to an onboard
reference clock source.

1.  Associate the PXIe-5842 and PXIe-5655 by performing the steps in the

© National Instruments 187

interconnection procedure for your instrument.
This completes the Reference Clock connection.

2.  Using NI-RFSA or NI-RFSG, set the Reference Clock Source property or attribute for

the PXIe-5842 to Onboard Clock.

Using the PXIe-5842

Related tasks:

•  Interconnecting your PXIe-5842 Instrument

Configuring External Reference Clock Timing
Configuring External Reference Clock Timing

You can provide an external reference clock to a PXIe-5842 instrument via an
associated PXIe-5655.

Refer to the specifications for your instrument for details about the minimum and
maximum levels allowed by the REF IN connector of the PXIe-5655.

Complete the following steps to configure the PXIe-5842 to lock to an external clock
reference source.

1.  Connect the external signal to the available PXIe-5655 REF IN connector.

Note The REF IN connector must not be in use for any intermodule
connections for the PXIe-5842 instrument.

2.  Using NI-RFSA or NI-RFSG, set the Reference Clock Source property or attribute to

RefIn.

3.  Using NI-RFSA or NI-RFSG, set the Ref Clock Rate property or attribute to a

supported value for the external reference clock frequency.

Configuring PXI Backplane Clock Timing
Configuring PXI Backplane Clock Timing

The PXI backplane can supply a 100 MHz reference clock signal.

To configure the PXIe-5842 to use the PXI backplane clock, set the NI-RFSA or NI-RFSG
Reference Clock Source property or attribute to PXI Clock.

188 ni.com

Using the PXIe-5842

Frequency and Bandwidth Configuration with NI RF
Frequency and Bandwidth Configuration with NI RF
Drivers
Drivers

You can use the NI-RFSA and NI-RFSG drivers to configure PXIe-5842 instruments for
optimal performance by specifying frequency and bandwidth constraints.

The following table shows equivalencies between the NI-RFSA and NI-RFSG properties
that control various elements of instrument frequency and bandwidth.

Table 54. NI-RFSA and NI-RFSG Frequency and Bandwidth Configuration Properties

NI-RFSA Property

IQ Carrier Frequency

NI-RFSG Property

Frequency

Downconverter Center Frequency

Upconverter Center Frequency

Downconverter Frequency Offset

Upconverter Frequency Offset

LO Frequency

LO Frequency

Device Instantaneous Bandwidth

Device Instantaneous Bandwidth

Signal Bandwidth

IQ Rate

Signal Bandwidth

IQ Rate

Downconverter Frequency Offset Mode

Upconverter Frequency Offset Mode

The following block diagrams represent, respectively:

•  The PXIe-5842 RF input connectors and the associated NI-RFSA properties
•  The PXIe-5842 RF output connectors and the associated NI-RFSG properties

© National Instruments 189

Using the PXIe-5842

Figure 46. PXIe-5842 RF Input and Associated NI-RFSA Properties

From RF OUT

Frequency Mixing Bands
Band 1 : Direct ADC

RF IN

RF IN: LO IN

RF IN: LO OUT

R I
L

ADC

Digital Offset

Downconverter
Center Frequency
(DCF)

Digital Gain

Wide Band Image

×n

n=1,2,4;
Band-dependent

Equalization

Device Instantaneous
Bandwidth (DIBW)

User Quadrature
Error Correction
(Scalar)

R I
L

Decimation Filter
Fractional
Resampler

IQ Rate

Acquisition
Engine

Configure
Acquisition

Downconverter
Frequency Offset (DCFO)

Numerically Controlled
Oscillator (NCO)

Figure 47. PXIe-5842 RF Output and Associated NI-RFSG Properties

Upconverter Center
Frequency (UCF)

To RX
Signal Chain

Digital Offset

DAC

I

Q

I R
L

Digital Gain
Post Filter

Wide Band
Image

Equalization

Device Instantaneous
Bandwidth (DIBW)

Upconverter
Frequency Offset

User Quadrature
Error Correction

R I
L

Fractional
Resampler

Digital Gain
(Pre-filter)

Waveform
Engine

Configure Generation

Downconverter
Center Frequency
(DCF)

×n

n=1,2,4;
Band-dependent

RF OUT

RF OUT: LO OUT

RF OUT: LO IN

Frequency and Bandwidth Configuration Terminology
Frequency and Bandwidth Configuration Terminology

Refer to the following list of terms when configuring frequency and bandwidth.

•  I/Q Rate—The effective sampling rate of the baseband signal chain. Setting a value

lower than the maximum limits the available passband.

•  I/Q Carrier Frequency—The center frequency of the waveform data acquired or

generated.

•  Downconverter Center Frequency— The frequency present at the mixer during
downconversion or upconversion. This frequency derives from the LO frequency
through a series of multipliers. The multiplication factor can be 1, 2, 4, or 8,
depending on the target frequency. In a direct conversion architecture, the
downconverter center frequency contains the LO leakage in the I/Q data.

190 ni.com

Using the PXIe-5842

•  LO Frequency— The frequency of the local oscillator as present at the LO IN or

LO OUT port. This frequency can be equal to the downconverter center frequency,
depending on the conversion architecture and any frequency multipliers in the LO
path. The onboard LO or LO IN port signal passes through either signal
conditioning circuits and frequency multipliers or dividers. The signal then hits the
mixer at the required frequency and power.

•  Device Instantaneous Bandwidth— The total calibrated bandwidth available
through the instrument signal path, centered at the downconverter center
frequency. For example, if the downconverter center frequency is 6 GHz and the
device instantaneous bandwidth is 1 GHz, an acquisition can contain calibrated
data from 5.5 GHz to 6.5 GHz.

•  Signal Bandwidth—During a signal acquisition, signal bandwidth is the bandwidth
of the signal present at the input port, centered at the I/Q carrier frequency. When
performing a signal generation, signal bandwidth is the bandwidth of the
waveform to be generated, centered at the I/Q carrier frequency.

•  Passband— The bandwidth able to be acquired based on the I/Q rate, centered at

the I/Q carrier frequency. In most cases, this rate is at 80% of the I/Q rate. For
example, an I/Q rate of 100 MS/s results in a passband of 80 MHz. Note that the
passband edge might fall outside of the device instantaneous bandwidth edge and
will, therefore, have aliased or uncalibrated data.

•  LO Step Size—Tune the LO frequency at this quantum. You can set the LO Step Size
property, or the VCO Step Size property on supported instruments. This property
controls the step sizes on the mixer or on the multiplierless onboard LO. Tuning
this property helps achieve varied hardware performance.

For example, the LO step size for an instrument is 2 MHz and the downconverter
center frequency is 5,001.5 MHz. The downconverter center frequency is coerced to
5,002 MHz, and the remaining 500 kHz shift is applied digitally.

•  LO Power—When using an external LO, the power of the LO is important for

maintaining good image and good LO leakage performance. Maintaining power is
important since impairments correction is calibrated for a specific LO power at the
mixer. Depending on the LO IN power, NI-RFSA configures the LO signal path mixer
power close to the mixer power used during impairment calibration. You can set
the LO OUT power to apply gain to the output signal and avoid power loss when in
a LO daisy-chain configuration.

© National Instruments 191

Using the PXIe-5842

Frequency and Bandwidth Selection to Optimize Performance
Frequency and Bandwidth Selection to Optimize Performance

You can configure frequency and bandwidth settings of a NI VST to optimize
measurement performance for different types of applications.

Note This information illustrates frequency and bandwidth concepts by
portraying a generic example instrument of 1 GHz bandwidth. Values and
figures might not necessarily reflect the frequencies, bandwidth, or LO step
size of your instrument.

Basic Behavior

For a simple acquisition, you can set the I/Q carrier frequency and the I/Q rate. When
you do not specify a bandwidth constraint, NI-RFSA selects the widest filter for the
given frequency region. You can obtain the bandwidth of the instrument for this
configuration by querying the Device Instantaneous Bandwidth property. To
determine the center of the device instantaneous bandwidth, you can query the
Downconverter Center Frequency property.

You can specify the I/Q rate that configures the decimation filter and, as a result,
configures the available passband. When oversampling, the passband is often greater
than the current signal bandwidth present at the port. Therefore, specifying the Signal
Bandwidth property gives the driver additional information about the requested
bandwidth.

The following example illustrates the default behavior.

192 ni.com

Using the PXIe-5842

Device Instantaneous Bandwidth

Signal BW = 160 MHz

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

I/Q Carrier Frequency

Downconverter Center Frequency (DCF)

LO Frequency

Specifying Device Instantaneous Bandwidth

In some cases, the default behavior might not be optimal. You can improve the default
behavior by providing NI-RFSA with more information about the system. By setting the
Device Instantaneous Bandwidth property, you are specifying how much instrument
bandwidth is required. The instrument bandwidth is used for filter selection and is
only coerced up. Therefore, the selected filters always yield a bandwidth as wide or
wider than requested. You can always read back the coerced or current device
instantaneous bandwidth to find out how much bandwidth is available in the given
configuration. For example, you need only 160 MHz of bandwidth from an instrument,
and the next largest filter for that instrument is 1 GHz. In this case, NI-RFSA chooses the
1 GHz filter.

Oversampling

In this example, the I/Q rate is 320 MS/s, and the waveform signal bandwidth is only
160 MS/s. This is referred to as oversampling. The passband is 80% of the I/Q rate, or
256 MHz. Since the passband extends outside the device instantaneous bandwidth,
frequency content outside the device instantaneous bandwidth is present in the time-
domain data. This frequency content is usually filtered out by demodulation
algorithms but might be problematic if you are analyzing the time-domain data
manually, and there is a strong interfering signal in that region.

© National Instruments 193

Using the PXIe-5842

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

Downconverter Center Frequency (DCF)

LO Frequency

Specifying a Frequency Offset

To avoid LO leakage present in the passband, you can apply a frequency offset by
setting the NI-RFSA Downconverter Frequency Offset property or the NI-RFSG
Upconverter Frequency Offset property. This property maintains a constant offset if
you vary the I/Q center frequency. You can always read back the actual device
instantaneous bandwidth and downconverter center frequency.

Specifying Signal Bandwidth

Another way to provide bandwidth information to the instrument driver is to specify
the signal bandwidth. Previously, it was noted that the device instantaneous
bandwidth is centered at the downconverter center frequency. Signal bandwidth,
however, is centered at the I/Q carrier frequency, which may be more useful for some
applications as it follows the signal of interest. Similarly, you can specify the
downconverter frequency offset instead of the downconverter center frequency if it is
more intuitive for the application.

The following example shows how to programmatically specify the signal bandwidth.

194 ni.com

Using the PXIe-5842

Device Instantaneous Bandwidth

Signal BW = 160 MHz
Passband = 256 MHz
I/Q Rate = 320 MS/s

Passband

Signal
Bandwidth

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

Image Frequency

LO Frequency

Downconverter Center

Frequency

I/Q Carrier Frequency

Note that setting the signal bandwidth does not necessarily avoid hardware
reconfigurations during in-band retuning, but the settings stay relative to the I/Q
carrier frequency, so it may be easier to manage in your application. The following
example shows three acquisitions with the same I/Q rate, signal bandwidth, and
downconverter frequency and only changes the I/Q carrier frequency for each
acquisition.

© National Instruments 195

Using the PXIe-5842

Signal BW = 160 MHz
Passband = 256 MHz
I/Q Rate = 320 MS/s

Device Instantaneous Bandwidth

Passband

Signal
Bandwidth

Acquisition 1

Device Instantaneous Bandwidth

Passband

Signal
Bandwidth

Acquisition 2

Device Instantaneous Bandwidth

Passband

Signal
Bandwidth

Acquisition 3

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

6.25 GHz

6.5 GHz

Frequency Offset
Frequency Offset

You can combine the capabilities of LO tuning and digital frequency shift function
through additional digital processing on the FPGA to configure the VST to operate with
a downconverter or upconverter frequency offset. Frequency offset tunes the LO away
from the signal.

Use the NI-RFSA Downconverter Frequency Offset Mode property or the NI-RFSG
Upconverter Frequency Offset Mode property to ask the driver to select an offset, or
set the NI-RFSA Downconverter Frequency Offset property or the NI-RFSG Upconverter
Frequency Offset property to configure a user-defined offset.

The use of frequency offset through digital frequency shift is at the expense of
restricted instantaneous bandwidth. For example, for an automatic offset, the driver
places the LO outside the signal bandwidth which restricts the signal bandwidth to
50% of the device instantaneous bandwidth after subtracting an instrument-
dependent LO guard band.

The following figures illustrate theoretical examples of a 1,000 MHz direct conversion
acquisition versus a 1,000 MHz frequency offset acquisition. Notice the different
constraints and distortions in each figure.

196 ni.com

Using the PXIe-5842

Note This information illustrates frequency and bandwidth concepts by
portraying a generic example instrument of 1 GHz bandwidth; values and
figures may not necessarily reflect the frequencies and bandwidth of your
instrument.

A direct conversion acquisition, as illustrated by the following figure, involves a single
acquisition to cover 1,000 MHz. There are distortions present that effectively constrain
the dynamic range of the spectrum, however. A primary example of this is the residual
LO power, also known as carrier or LO leakage. Residual LO power is an artifact of the
quadrature architecture used in direct conversion devices. Use the equation |x| >
(Bandwidth / 2) to calculate the minimum frequency shift needed to avoid LO leakage,
where x is the minimum digital frequency shift and BW is the required bandwidth.

Figure 48. Spectrum Acquisition with Direct Conversion (Single Span)

Acquisition 1

The following example figure illustrates that you can acquire the same 1,000 MHz using
frequency offset with minimal distortion present from direct conversion architectures.
However, when you use frequency offset, the effective bandwidth of the device is
restricted. The 1,000 MHz acquisition that took a single acquisition using direct
conversion takes three acquisitions using frequency offset configuration.

© National Instruments 197

Figure 49. Spectrum Acquisition with Frequency Offset (Multi-Span)

Using the PXIe-5842

Acquisition 1

Acquisition 2

Acquisition 3

Images can occur when using a VST with frequency offset because of imperfections of
the gain imbalance and skew between the I and Q channels. Residual sideband images
are suppressed by calibration, but images can still be a complication when using
frequency offset.

Using In-Band Retuning
Using In-Band Retuning

In-band retuning allows an NI VST to quickly tune between signals of interest or
generation within a given instantaneous bandwidth by keeping the LO constant and
using digital frequency shifts in the digital data path. The advantages of in-band
retuning include reduced settling time for both frequency and amplitude.

In-band retuning can occur only within the supported instantaneous bandwidth of the
instrument. You can use digital tuning in combination with LO tuning to more
efficiently sweep over a spectrum for supported applications.

You can use in-band retuning by setting the instrument instantaneous bandwidth and
leaving the downconverter center frequency fixed, which significantly reduces
reconfiguration and settling times.

To perform in-band returning, set the relevant property, based on your RF driver as
follows, to a value within the instantaneous bandwidth of the VST.

•  NI-RFSA: Downconverter Center Frequency

198 ni.com

Using the PXIe-5842

•  NI-RFSG: Upconverter Center Frequency

Programming for In-Band Returning

This example shows how to programmatically set an NI VST for in-band retuning
during acquisition using NI-RFSA.

Note This example illustrates frequency and bandwidth concepts by
portraying a generic example instrument of 1 GHz bandwidth; values and
figures may not necessarily reflect the frequencies, bandwidth, or LO step
size of your instrument.

The following figure shows three acquisitions with only digital frequency shift
reconfigurations.

Passband

Signal
Bandwidth

Device Instantaneous Bandwidth

Passband

Signal
Bandwidth

Signal BW = 160 MHz
Passband = 256 MHz
I/Q Rate = 320 MS/s

Passband

Signal
Bandwidth

5.00 GHz

5.25 GHz

5.5 GHz

5.75 GHz

6.00 GHz

I/Q Carrier Frequency
for Acquisition 1

I/Q Carrier Frequency
for Acquisition 2

I/Q Carrier Frequency
for Acquisition 3

Downconverter Center Frequency

LO Frequency

© National Instruments 199

Using the PXIe-5842

Automatic Frequency Offset
Automatic Frequency Offset

The PXIe-5842 can automatically offset the downconverter center frequency from the
carrier frequency when sufficient instrument bandwidth is available.

For the PXIe-5842 to apply automatic frequency offset, the signal must fit within the
following limits, depending on the bandwidth hardware option:

•  2 GHz and 4 GHz bandwidth options: (Instantaneous Bandwidth - 200 MHz LO

Guard Band) / 2

•  Lower bandwidth options: Bandwidth Option / 2

A table of the maximum available bandwidth for a given I/Q frequency when using
automatic frequency offset is available in the instrument specifications in Equalized
Bandwidth.

When Offset Mode is Automatic (the default behavior) and Signal Bandwidth ≤
Maximum Offset Bandwidth, as defined in the Maximum Offset Bandwidth table in the
specifications, the PXIe-5842 automatically applies the offset. When Offset Mode is
Automatic and Signal Bandwidth > Maximum Offset Bandwidth, the PXIe-5842 does
not apply an automatic offset.

You can determine the actual frequency offset that was applied by reading the coerced
downconverter center frequency. For automatic offset mode to function, you must
specify the signal bandwidth. Additionally, when the downconverter frequency offset
mode is enabled and the signal bandwidth is known, NI-RFSA can further optimize the
dynamic range of the instrument. Using the instrument when downconverter
frequency offset mode is enabled also ensures that the gain accuracy is maintained, as
noted in the device specifications. Otherwise, using the user-defined offset mode, the
gain accuracy at an offset is limited to Amplitude Accuracy Specification ± Frequency
Response Specification.

Note To use automatic frequency offset with an external LO, including
sharing an LO between the acquisition and generation, refer to Using an
External LO.

The following example shows how to programmatically set an NI VST to automatically

200 ni.com

offset the downconverter center frequency from the carrier frequency, if possible.
Refer to the NI-RFSA Downconverter Frequency Offset Mode and NI-RFSG Upconverter
Frequency Offset Mode properties for more information.

Using the PXIe-5842

Note The following figure illustrates frequency and bandwidth concepts by
portraying a generic example instrument of 1 GHz bandwidth; values and
figures might not necessarily reflect the frequencies and bandwidth of your
instrument.

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

LO Frequency

Image Frequency

Downconverter Center
Frequency

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

LO Frequency

Image Frequency

Downconverter Center
Frequency

Related tasks:

•  Using an External LO

Related information:

•  PXIe-5842 Specifications

© National Instruments 201

Using the PXIe-5842

Pulse Modulation
PXIe-5842  Pulse Modulation
PXIe-5842

With the corresponding hardware option enabled, the PXIe-5842 supports modulating
RF signal generation with pulsed signals using the NI-RFSG API. You can supply the
modulating signal from either an external source or from scripted waveforms
generated by the VST itself, and you can select from a variety of modes to realize the
right pulse characteristics for your application.

Introduced in NI-RFSG 2023 Q3

The choice of which modulation source to use—external or internal—is the
fundamental design decision in implementing pulse modulation with the PXIe-5842.

•  External source—The modulating signal is external to the VST: convey a

compatible external signal to the PULSE: IN connector on the PXIe-5842 module
front panel. Enables the lowest latency between receiving a pulse and generating
the associated RF burst.

•  Internal source—The VST itself generates the modulating signal: use waveform
scripting to create the modulating signal and designate a marker within that
waveform to initiate the modulation pulse. Allows the greatest flexibility in the
waveform you can use and affords you access to capabilities like triggering, events,
and waveform looping.

You can then choose a pulse modulation mode to further control the character of the
modulation pulses, especially the on/off ratio.

Additionally, you can use the PULSE: OUT port of the PXIe-5842 module to monitor the
envelope of the pulse modulated RF signal.

PXIe-5842 Support for Pulse Modulation

•  Pulse modulation is a hardware option for the PXIe-5842. Your PXIe-5842 must

have this option to use pulse modulation.

•  The pulse modulation hardware option is available only for PXIe-5842 instruments

that are based around a PXIe-5842 module with assembly part numbers
138862x-yL, 117478x-yL, and 117480x-yL, where the hardware revision x is a letter
and y is one or more digits.

202 ni.com

•  You can use pulse modulation with any PXIe-5842 instrument that has the

appropriate license, but pulse modulation performance is specified only for the
PXIe-5842 VST (Up to 2 GHz Bandwidth) and PXIe-5842 VST (4 GHz Bandwidth).

Using the PXIe-5842

Related concepts:

•  What is the PXIe-5842?
•  PXIe-5842 Hardware Options

Choosing a Pulse Modulation Approach for the PXIe-5842

For pulse modulation with the PXIe-5842, you can choose the source for the
modulating signal and can select between a number of modulation modes that tune
pulse characteristics.

Use the following criteria to help determine which modulation signal source and pulse
modulation mode are best for your application:

•  Select a source, external or internal, for the modulating signal.

Pulse Modulation Signal Source

Description

External

Internal

Very low latency between receiving the
modulation pulse and asserting the RF burst.
Appropriate for CW only because the pulse is
not aligned to any specific point within the
waveform.

Ensure the modulating signal is compatible
with the PULSE: IN connector.

Usable with arbitrary waveforms because the
pulse is aligned to a specific point in the
waveform, which you designate with markers.

•  Select a pulse modulation mode.

Pulse Modulation Mode

Description

Analog

Best balance between on/off switching speed

© National Instruments 203

Pulse Modulation Mode

Description

Using the PXIe-5842

Analog High Isolation

Digital

speed and on/off ratio.

Suitable for most applications.

Best on/off ratio at the cost of larger minimum
pulse width, lower duty cycle, and higher
latency when used with an external source.

Recommended as an alternative to Analog
mode if Analog mode does not have sufficient
on/off ratio for your application.

Fastest on/off switching speed of the
modulating signal at the cost of on/off ratio.

On/off ratio may not be suitable for some
applications.

Tip Refer to the PXIe-5842 Specifications to consult specific performance
data for each pulse modulation mode.

Related information:

•  PXIe-5842 Specifications

External Pulse Modulation Source Requirements

If you are using an external pulse modulation source with the PXIe-5842, the signal you
provide must be compatible with the instrument.

Ensure your external pulse modulation signal meets the following requirements.

•  PULSE: IN input damage level—5 V
•  Minimum detectable voltage—3.3 V

204 ni.com

Using the PXIe-5842

Streaming Applications
Streaming Applications

Streaming refers to generating data incrementally or a variety of approaches for
moving data between your instrument and other destinations.

Streaming Waveform Data
Streaming Waveform Data

Streaming is a way to generate waveforms that are too large to fit in the onboard
memory of an instrument.

The following instructions are a guide for configuring your application for streaming.
For a programmatic example, refer to RFSG Arbitrary Waveform
Streaming.vi for LabVIEW or ArbitraryWaveformStreaming.prj for
LabWindows/CVI, available using the NI Example Finder.

As an example, we have a 1.6 GB waveform we want to generate and an NI arbitrary
waveform generator with 256 MB of onboard memory. This 1.6 GB waveform may be in
the host memory, on disk, or data that your application generates dynamically during
generation.

1.  Identify the streaming waveform—Set the Streaming Waveform Name property.
Setting this property ensures that none of your streaming data is overwritten
before it is generated. NI-RFSG monitors your progress to ensure that you write
fresh data fast enough to keep up with the generation. If your application fails to
keep up or attempts to write fresh data over data that has not been generated,
NI-RFSG returns an error.

Set the Streaming Waveform Handle Property
to Identify the Waveform for Streaming

1.6 GB Waveform

160 MB

© National Instruments 205

Using the PXIe-5842

2.  Specify the amount of onboard memory to be used for streaming—Call NI-RFSG
Allocate Arb Waveform to specify the amount of onboard memory to reserve for
streaming. The allocated memory, known as the streaming waveform, serves as a
buffer for the streaming process. The size of the waveform you wish to stream must
be evenly divisible by the amount of onboard memory allocated for streaming to
prevent the streaming waveform from being overwritten before it has generated.

160 MB

1.6 GB Waveform

160 MB Allocated
for Streaming

Remaining Onboard
Memory Used for
Additional Waveforms
and Script Instructions.

3.  Fill the streaming waveform with initial data—Call NI-RFSG Write Arb Waveform
to write the first part of the waveform data to the streaming waveform in onboard
memory.

Tip When transferring large blocks of waveform data, break the data into
smaller blocks and call the NI-RFSG Write Arb Waveform multiple times.
The data is appended sequentially. A computer can allocate smaller
blocks of a large waveform faster than allocating a single large
contiguous block in memory. Depending on the amount of RAM on the
computer, transferring ten 16 MB blocks may be faster than transferring
one 160 MB block.

206 ni.com

160 MB

1.6 GB Waveform

Using the PXIe-5842

Write First Portion
to Onboard Memory

160 MB

4.  Begin generating the waveform—Call NI-RFSG Initiate to begin the waveform

generation. As the waveform generates, space in the streaming waveform becomes
free.

1.6 GB Waveform

As Waveform is Generated,
Onboard Memory Becomes Free

160 MB

5.  (Optional) Monitor available memory as the waveform generates—Use the Space

Available in Streaming Waveform property to determine how much of the
streaming waveform is free for writing new data. As the waveform generates, space
becomes available to write more waveform data.

© National Instruments 207

Using the PXIe-5842

1.6 GB Waveform

Query the Space Available in Streaming Waveform
Property to Determine Freed Onboard Memory

17 MB

160 MB

6.  Write a block of waveform data—Call NI-RFSG Write Arb Waveform to write a new

block of waveform data to the streaming waveform in onboard memory.

16 MB

1.6 GB Waveform

Write Waveform Data in Blocks

16 MB

160 MB

If the size of the new block of waveform data is larger than the space available, NI-
RFSG waits until sufficient space becomes available or the streaming write time
expires. Use the Streaming Write Timeout property to change the streaming write
time.

208 ni.com

Using the PXIe-5842

Space
Available

16 MB New Data

160 MB

7.  Repeat steps 5 and 6 until all waveform data is written.

16 MB

1.6 GB Waveform

Write Waveform Data in Blocks

16 MB

160 MB

Related tasks:

•  Finding Examples for the PXIe-5842

Peer-to-Peer Data Streaming
Peer-to-Peer Data Streaming

The PXIe-5842 supports peer-to-peer (P2P) data streaming using the NI-P2P API. Peer-
to-peer streaming exchanges data directly between supported devices, bypassing the
host computer memory and making applications that require real-time data transfer
between devices possible.

For more information about the following terminology, refer to the NI-P2P peer-to-
peer streaming driver documentation.

•  Stream—The data path connection between two peer-to-peer endpoints. A peer-

to-peer stream is independent of the data generation and consumption of the two
peers.

© National Instruments 209

Using the PXIe-5842

•  Endpoint—The collection of hardware resources needed to support one end of a
peer-to-peer stream. Multiple peer-to-peer endpoints may exist in a single device.

•  Writer Peer—The peer sending the data over the bus to the reader peer.
•  Reader Peer—The peer receiving the data over the bus from the writer peer.

Vector signal transceivers support simultaneous streaming between both peer-to-peer
endpoints.

Configuring a Peer-to-Peer Endpoint
Configuring a Peer-to-Peer Endpoint

Any driver property that is associated with an instance of an endpoint is an endpoint-
based property.

Configuring a Peer-to-Peer Endpoint with NI-RFSG

1.  Set the Active Channel property using an appropriate string when configuring

endpoint-based properties.
The syntax "FIF0endpointN" is used to tell NI-RFSG which RF vector signal
transceiver endpoint is being specified, where N is an integer starting with 0. If the
RF vector signal transceiver supports multiple endpoints, the first is
"FIF0endpoint0", the second is "FIF0Endpoint1," and so on.

2.  Set the P2P Enabled property to True.
3.  To determine how many endpoints your RF vector signal transceiver supports,

query the Endpoint Count property.

4.  Perform either a continuous generation or a finite generation.

◦  Continuous generation: Set the Number of Records is Finite property to False
◦  Finite generation: Set the Is Finite P2P Generation property to True, and set the
Number of P2P Samples to Generate property to the number of samples that
should be generated

Configuring a Peer-to-Peer Endpoint with NI-RFSA

1.  Set the Active Channel property using an appropriate string when configuring

endpoint-based properties.
The syntax "FIF0endpointN" is used to tell NI-RFSA which RF vector signal
transceiver endpoint is being specified, where N is an integer starting with 0. If the
RF vector signal transceiver supports multiple endpoints, the first is
"FIF0endpoint0", the second is "FIF0Endpoint1," and so on.

210 ni.com

Using the PXIe-5842

2.  Set the P2P Enabled property to True.
3.  To determine how many endpoints your RF vector signal transceiver supports,

query the P2P FIFO Endpoint Count property.

4.  Perform either a continuous acquisition or a finite acquisition.

◦  Continuous acquisition: Set the Number of Records is Finite property to False
◦  Finite acquisition: Set the Number of Samples is Finite property to True and set
the Number of Samples property to the number of samples that should be
acquired

Configuring a Peer-to-Peer Stream
Configuring a Peer-to-Peer Stream

To configure a peer-to-peer stream using the NI-P2P API, a writer and reader handle for
each endpoint are required.

Use Get Stream Endpoint Handle to generate a reader endpoint handle.

Configuring Flow Control

To configure flow control in NI-RFSA and NI-RFSG, complete the following steps:

1.  Call Get Stream Endpoint Handle for your driver to get the RF vector signal

transceiver reader handle and the appropriate handle from the writer peer API.

2.  Call NI-P2P Create Peer to Peer Stream to configure NI-P2P with information

regarding each endpoint to link the endpoints into a stream.
You must specify both a reader and writer endpoint handle.

Starting Peer-to-Peer Generation

If the RF vector signal transceiver begins generating data from a peer-to-peer stream
immediately after the first sample is received, the device may not have enough data to
continue the generation and can underflow at startup. This problem is due to latency
across the bus, and it is especially likely when heavy, possibly unrelated, traffic is on
the bus. To avoid underflow at startup, prime the endpoint with data before starting
generation so the device has a backlog of data to insulate the generation from the
bursty nature of data flowing across the bus.

The following two methods are available for preparing the RF vector signal transceiver
endpoint for startup:

© National Instruments 211

Using the PXIe-5842

•  NI-RFSG StartTrig.P2PEndpointFullness.Level—Starts generation after the

endpoint receives the specified number of samples. If no number of samples is
specified, the driver automatically selects an appropriate value. This method
should work for most applications and requires the least amount of configuration.
This property is used when StartTrig.Type is set to P2P Endpoint Fullness.

•  Manual preparation—Configure the application so that the writer peer sends data

to the RF vector signal transceiver endpoint prior to the RF vector signal
transceiver initiating generation.

To prepare for generation manually, complete the following steps:

1.  Configure both peers for peer-to-peer streaming.
2.  Link both peers with NI-P2P Create Peer to Peer Stream.
3.  Enable the stream in either of the following ways:

◦  Set enable stream to True with NI-P2P Create Peer to Peer Stream
◦  Call NI-P2P Enable Peer to Peer Stream

4.  Start the writer peer first so that it begins sending data to the RF vector signal

transceiver prior to initiation.

5.  Depending on the language you are using, query the following after starting the
writer peer to ensure that sufficient data has been transferred to the RF vector
signal transceiver.
◦  LabVIEW: NI-RFSG Space Available in Endpoint
◦  C: NIRFSG_ATTR_P2P_ENDPOINT_FULLNESS_START_TRIGGER_LEVEL or

NIRFSG_ATTR_P2P_SPACE_AVAILABLE_IN_ENDPOINT

6.  Call NI-RFSG Initiate.

Stopping Peer-to-Peer Generation

Avoid receiving an underflow error by using a supported technique to stop peer-to-
peer generation.

Use either of the following techniques to stop peer-to-peer generation without
generating an underflow error:

Option

Is Finite P2P Generation

Description

If the RF vector signal transceiver receives the
specified number of samples from the writer
peer, the NI-RFSG session completes without an

212 ni.com

Option

Description

Using the PXIe-5842

Continuous Generation Using User-Requested
Abort

underflow error. Use Number of P2P Samples to
Generate to specify the sample number

Using the NI-RFSG Abort or NI-RFSG Check
Generation Status returns True for Done.
However, if the writer peer is not configured
carefully for this event, it may overflow because
the RF vector signal transceiver is no longer
allowing it to send data through the stream.

In either preceding technique, use NI-RFSG Check Generation Status function to
determine whether generation is complete. After generation is done, you can abort the
generation using NI-RFSG Abort. When generation aborts, all data in the endpoint is
cleared to prepare the device for subsequent generations.

Note When using the NI-P2P API to configure the stream, call NI-P2P Flush
and Disable Peer to Peer Stream or NI-P2P Disable Peer to Peer Stream and
wait for the done? parameter from NI-RFSG Check Generation Status to
assert before aborting the RF vector signal transceiver. If data is still in the
endpoint when NI-RFSG Abort is called, it is cleared to prepare the device for
subsequent generations.

Stopping Peer-to-Peer Acquisition

When stopping peer-to-peer acquisition, you must clear the data from the stream
before starting a new acquisition.

Use either of the following techniques to clear the stream:

•  Call NI-P2P Flush and Disable Peer to Peer Stream before starting a new

acquisition. This function automatically clears the remaining data from the stream.

•  Configure the reader peer to read the remaining samples in the stream, then call

NI-P2P Disable Peer to Peer Stream before starting a new acquisition.

MGT Streaming
PXIe-5842  MGT Streaming
PXIe-5842

As instantaneous bandwidth increases, so too do the bandwidth requirements for

© National Instruments 213

Using the PXIe-5842

streaming data. You can use the multi-gigabit transceiver (MGT) ports of the PXIe-5842
to take advantage of the instrument's bandwidth and stream data at high rates with
the help of an FPGA coprocessor.

Introduced in NI-RFSA/NI-RFSG Instrument Driver for Multi-Gigabit
Transceiver Streaming 2023 Q4

MGT streaming functionality is based on the Aurora serial communication protocol.
The bitfile for MGT streaming lets you use PXIe-5842 MGT to both generate RF data that
is streamed to the instrument via an Aurora interface and to acquire RF data from the
instrument and stream it over an Aurora interface.

All PXIe-5842 instruments can support MGT streaming.

Note Your PXIe-5842 instrument must have the MGT streaming hardware
option to use this functionality.

NI has created MGT streaming examples for the LabVIEW ADE to help you get started.
These examples are included with the driver software necessary to enable MGT
streaming.

Refer to the following to get started with MGT streaming with the PXIe-5842.

1.  Requirements for PXIe-5842 MGT Streaming

You need certain hardware and software to take advantage of MGT streaming
functionality of your PXIe-5842 instrument.
2.  Connecting the PXIe-5842 for MGT Streaming

Interconnect the PXIe-5842 module of your instrument and the PXIe-7903 with
zHD (m)-to-zHD (m) cables to facilitate MGT streaming.

3.  Using PXIe-5842 MGT Streaming Examples

Refer to the LabVIEW examples for MGT streaming to understand how to get
started with designing applications that use the MGT streaming functionality of the
PXIe-5842.

Related information:

214 ni.com

Using the PXIe-5842

•  Software and Driver Downloads

Requirements for PXIe-5842
Requirements for

MGT Streaming
PXIe-5842  MGT Streaming

You need certain hardware and software to take advantage of MGT streaming
functionality of your PXIe-5842 instrument.

Note Your PXIe-5842 instrument must have the MGT streaming hardware
option to use this functionality.

•  Cabling—zHD (m)-to-zHD (m) cables. NI recommends the following cables for use

with the PXIe-7903:

Model

Description

NI Part
Number

0.5 m zHD (m)-to-zHD (m)
cable

788927-0R5

Mini-SAS zHD-Mini-SAS zHD HSS Passive
Cable

1 m zHD (m)-to-zHD (m) cable

788927-01

2 m zHD (m)-to-zHD (m) cable

788927-02

•  FPGA coprocessor—PXIe-7903; PXIe-5842 instruments support only this

coprocessor for MGT streaming functionality
•  Software—The following software is required:

•  Driver software:

◦  MGT streaming functionality: NI-RFSA/NI-RFSG Instrument Driver for Multi-

Gigabit Transceiver Streaming 2023 Q4 or later

◦  PXIe-5842 acquisition functionality: NI-RFSA 2023 Q4 or later
◦  PXIe-5842 generation functionality: NI-RFSG 2023 Q4 or later
◦  Coprocessor support: FlexRIO 2023 Q4 or later

•  Application software: LabVIEW 2022 or later, with LabVIEW FPGA Module

2023 Q1 or later

© National Instruments 215

Using the PXIe-5842

•  Stimulus and response VST—(Roundtrip operation only) VST that can generate a
signal within the instananeous bandwidth of the PXIe-5842 and analyze the RF
output frequency of the PXIe-5842; optional for roundtrip operation if you want to
process actual RF signals in this configuration

Connecting the PXIe-5842
Connecting the

for MGT Streaming
PXIe-5842  for MGT Streaming

Interconnect the PXIe-5842 module of your instrument and the PXIe-7903 with
zHD (m)-to-zHD (m) cables to facilitate MGT streaming.

Complete the following steps to interconnect your hardware for MGT streaming:

1.  Install and interconnect the modules of your PXIe-5842 instrument according to

the instructions in this user manual.

2.  Install the PXIe-7903 coprocessor in the PXI Express chassis according to the

instructions in the documentation for the PXIe-7903.

3.  Interconnect the MGT ports of the PXIe-5842 and PXIe-7903.

Notice Use care when handling zHD cables. If you meet resistance when
connecting the cable, stop and inspect the cable; replace the cable if the
EMI gasket is damaged.

Note Use the following interconnections for the MGT streaming LabVIEW
examples:

Cable

PXIe-5842 Connector

PXIe-7903 Connector

zHD (m)-to-zHD (m)

zHD (m)-to-zHD (m)

MGT port 0

MGT port 1

Port 8

Port 9

4.  Connect RF signals depending on the streaming use case.

Use Case

Acquisition

216 ni.com

RF Connections

Connect the ports that serve as RF output and
RF input for your instrument together in
loopback

Use Case

Generation

Roundtrip4

Using the PXIe-5842

RF Connections

Connect the ports that serve as RF output and
RF input for your instrument together in
loopback

Connect depending on whether you have a
second VST for stimulus and response.
◦  PXIe-5842 and stimulus and response VST

(evaluate actual stimulus and
response)—Make the following
connections:
a.  Connect the RF output of the

stimulus and response VST to the
port that serves as RF input for your
PXIe-5842

b.  Connect the RF input of the stimulus
and response VST to the port that
serves as RF output for your
PXIe-5842

◦  PXIe-5842 only (process noise)—Connect
the ports that serve as RF output and RF
input for your PXIe-5842 instrument
together in loopback

Using PXIe-5842
Using

MGT Streaming Examples
PXIe-5842  MGT Streaming Examples

Refer to the LabVIEW examples for MGT streaming to understand how to get started
with designing applications that use the MGT streaming functionality of the PXIe-5842.

Using the MGT Streaming Acquisition Example
Using the MGT Streaming Acquisition Example

The MGT streaming Acquisition example uses an Aurora link to transmit data acquired
on the PXIe-5842 to the associated FlexRIO PXIe-7903 coprocessor.

Complete hardware setup for MGT streaming before using the MGT streaming example
programs.
Complete the following steps to navigate and use the LabVIEW example for
acquisitions that use MGT streaming:

4. Requires an additional VST to the PXIe-5842 to evaluate actual stimulus and response.

© National Instruments 217

Using the PXIe-5842

1.  Choose your PXIe-5842 instrument in vst resource name and choose the PXIe-7903

as the flexrio resource name.
2.  Define settings for the acquisition:

a.  Choose VST settings, such as the I/Q rate and carrier frequency.
b.  Choose whether the stream is infinite or finite; if finite, also choose the number

of samples to stream.
A finite stream runs for the number of samples you specify; an infinite stream
runs until you stop it manually.

3.  Run the example, and on the Aurora Config tab, confirm that the following settings

match between the PXIe-5842 and the PXIe-7903 coprocessor:
◦  line rate
◦  packets enabled
◦  number of lanes
◦  nfc immediate enabled
◦  crc enabled
◦  endianness

When you run the example, the MGT streaming bitfile is downloaded to the
PXIe-5842, a FlexRIO bitfile is downloaded to the PXIe-7903 coprocessor, and an
Aurora link is established between the two. The Aurora Config tab reads and
displays the Aurora link status.

Once the Aurora channels are configured, acquisition parameters are applied and
an NI-RFSA session begins. An NI-RFSA start trigger begins the transmission of data
from the PXIe-5842 to the coprocessor.

4.  In the Stream Status tab, check the channel up and lane up status to confirm the

link is working correctly.
You can also view other information about the transmission.

Tip You can calculate data throughput from the I/Q rate as follows:
Throughput (Gbps) = I/Q Rate (Samples/s) × 4

Bytes
Sample × 8

bits
Byte

For example, an I/Q rate of 1.25 GS/s, the VST transmit throughput and
coprocessor receive throughput are approximately 40.0 Gbps.

If channel up indicates the channel is not functioning, check that the hardware

218 ni.com

Using the PXIe-5842

setup and cabling are correct.

5.  Optional: During the stream, you can acquire records from the PXIe-5842 with the
underlying NI-RFSA driver; select the RF tab to acquire NI-RFSA records or fetch
snapshots of data on the coprocessor.

6.  If you selected an infinite stream, abort the stream by clicking STOP.

Using the MGT Streaming Generation Example
Using the MGT Streaming Generation Example

The MGT streaming Generation example uses an Aurora link to transmit I/Q data from a
FlexRIO PXIe-7903 coprocessor to the PXIe-5842, which generates the I/Q data as RF
signals.

Complete hardware setup for MGT streaming before using the MGT streaming example
programs.
Complete the following steps to navigate and use the LabVIEW example for generation
that uses MGT streaming:

1.  Choose your PXIe-5842 instrument in vst resource name and choose the PXIe-7903

as the flexrio resource name.
2.  Define settings for the generation:

a.  Choose VST settings, such as the I/Q rate and carrier frequency.
b.  Choose whether the stream is infinite or finite; if finite, also choose the number

of samples to stream.
A finite stream runs for the number of samples you specify; an infinite stream
runs until you stop it manually.

3.  Optional: If desired, set streaming zero waveform length to a positive integer to
define the number of zero I/Q samples the PXIe-5842 should generate before it
begins generating RF signals from the I/Q data stream.

4.  Run the example, and on the Aurora Config tab, confirm that the following settings

match between the PXIe-5842 and the PXIe-7903 coprocessor:
◦  line rate
◦  packets enabled
◦  number of lanes
◦  nfc immediate enabled
◦  crc enabled
◦  endianness

When you run the example, the MGT streaming bitfile is downloaded to the

© National Instruments 219

Using the PXIe-5842

PXIe-5842, a FlexRIO bitfile is downloaded to the PXIe-7903 coprocessor, and a CW
stimulus—in this example, the waveform that will stream from the coprocessor to
the PXIe-5842—is written to a buffer in the coprocessor. An Aurora link is then
established between the VST and coprocessor. The Aurora Config tab reads and
displays the Aurora link status.

Once the Aurora channels are configured, data begins streaming from the
coprocessor to the PXIe-5842. This data fills a buffer on the PXIe-5842, and once
the buffer is nearly full, the PXIe-5842 requests that the coprocessor stop sending
data and prepares to generate the buffered data.

An NI-RFSG session begins, and an NI-RFSG start trigger begins generation of the
I/Q data as RF signals. When the buffer is nearly empty, the PXIe-5842 requests that
the coprocessor transmit more data, and the process repeats.

Note In this example, the coprocessor sources data faster than the
PXIe-5842 can consume it. As a result, the buffer oscillates between the
full and empty thresholds when the example is running.

5.  In the Stream Status tab, check the channel up and lane up status to confirm the

link is working correctly.
You can also view other information about the transmission.

Tip You can calculate data throughput from the I/Q rate as follows:
Throughput (Gbps) = I/Q Rate (Samples/s) × 4

Bytes
Sample × 8

bits
Byte

For example, an I/Q rate of 1.25 GS/s, the VST receive throughput and
coprocessor transmit throughput are approximately 40.0 Gbps.

If channel up indicates the channel is not functioning, check that the hardware
setup and cabling are correct.

6.  If you selected an infinite stream, abort the stream by clicking STOP.

Using the Multi-Gigabit Transceiver (MGT) Streaming Roundtrip Example
Using the Multi-Gigabit Transceiver (MGT) Streaming Roundtrip Example

The MGT streaming roundtrip example uses an Aurora link to transmit data acquired

220 ni.com

Using the PXIe-5842

on the PXIe-5842 to the associated FlexRIO PXIe-7903 coprocessor. In turn, the Aurora
link sends the data back to the PXIe-5842 for generation.

Complete hardware setup for MGT streaming before using the MGT streaming example
programs.

Note To evaluate actual stimulus and actual response for this example, you
must connect a second VST to the PXIe-5842. You can run the example about
a second VST, but the example only processes noise, not the actual stimulus
and actual response of the instrument.

Complete the following steps to navigate and use the LabVIEW example that uses the
MGT streaming in a roundtrip configuration:

1.  Choose your PXIe-5842 instrument in vst resource name and choose the PXIe-7903

as the flexrio resource name.
2.  Define settings for the generation:

a.  Choose VST settings, such as the I/Q rate and carrier frequency.
b.  Choose whether the stream is infinite or finite; if finite, also choose the number

of samples to stream.
A finite stream runs for the number of samples you specify; an infinite stream
runs until you stop it manually.

3.  Set streaming zero waveform length to a positive integer to define the number of
zero I/Q samples the PXIe-5842 should generate before it begins generating RF
signals from the I/Q data stream.

Tip This value is important for roundtrip operation—the number of
samples must be large enough to account for the worst-case roundtrip
delay for I/Q data transferred from the VST, to the coprocessor, and back
to the VST again, but it must be small enough to fit within the buffer on
the PXIe-5842.

4.  Run the example, and on the Aurora Config tab, confirm that the following settings

match between the PXIe-5842 and the PXIe-7903 coprocessor:
◦  line rate
◦  packets enabled
◦  number of lanes
◦  nfc immediate enabled

© National Instruments 221

Using the PXIe-5842

◦  crc enabled
◦  endianness

When you run the example, the MGT streaming bitfile is downloaded to the
PXIe-5842, a FlexRIO bitfile is downloaded to the PXIe-7903 coprocessor, and an
Aurora link is established between the two. The Aurora Config tab reads and
displays the Aurora link status.

Once the Aurora channels are configured, NI-RFSA and NI-RFSG sessions begin. An
NI-RFSG start trigger occurs and, when samples are first generated at RF, the
generator portion of the VST sends a signal to the analyzer portion; this signal
initiates the data stream from the PXIe-5842 to the coprocessor.

The coprocessor buffers this I/Q data and transfers it back to the VST generator.
Once any zero I/Q samples are generated, the VST reads the I/Q data it has received
from the coprocessor.

5.  In the Stream Status tab, check the channel up and lane up status to confirm the

link is working correctly.
You can also view other information about the transmission.

Tip You can calculate data throughput from the I/Q rate as follows:
Throughput (Gbps) = I/Q Rate (Samples/s) × 4

Bytes
Sample × 8

bits
Byte

For example, an I/Q rate of 1.25 GS/s, the VST transmit and receive
throughput and coprocessor transmit and receive throughput are
approximately 40.0 Gbps.

If channel up indicates the channel is not functioning, check that the hardware
setup and cabling are correct.

6.  Optional: During the stream, you can acquire records from the PXIe-5842 with the
underlying NI-RFSA driver; select the RF tab to acquire NI-RFSA records or fetch
snapshots of data on the coprocessor.

7.  Optional: If you have a second VST to evaluate actual stimulus and response, you

can expand the program to encompass this functionality.

8.  If you selected an infinite stream, abort the stream by clicking STOP.

222 ni.com

Using the PXIe-5842

Performing Interactive VNA Measurements in
Performing Interactive VNA Measurements in
InstrumentStudio
InstrumentStudio

You can use InstrumentStudio to access the VNA functionality of the PXIe-5842 VST
with S-Parameters through an interactive soft front panel.

This process assumes you have already performed initial hardware configuration in
Hardware Configuration Utility or MAX.

Refer to InstrumentStudio documentation for information on the layout of
InstrumentStudio.

Notice Follow all guidelines when making connections to the PXIe-5842 VST
with S-Parameters.

Complete the following steps to make interactive VNA measurements with the
PXIe-5842 VST with S-Parameters in InstrumentStudio:

1.  Open a network analyzer panel in InstrumentStudio.

◦  From InstrumentStudio: Click

 » Network Analyzer, or create a layout

automatically based on the equipment in your system.

◦  From Hardware Configuration Utility: Select the PXIe-5633 module and, within
the instrument configuration panel on the right side, click Measurement
panel.

2.  Configure reference clock settings with

 » Instrument.

PXI_Clk is the valid source for PXIe-5842 VST with S-Parameters VNA functionality.

3.  Optional: If you want to use de-embedding to remove the effect of fixtures from

your measurements, do the following:
a.  In the instrument configuration panel, click
b.  Choose the relevant settings.

 » Instrument

Note To apply de-embedding, you must have .s2p files available for
each port you want to de-embed.

4.  Define the frequency sweep settings.

© National Instruments 223

Sweep Type

Linear

Using the PXIe-5842

Description

Sweep a linear set of frequencies.

Define:

◦  A low start frequency
◦  A high stop frequency for the sweep
◦  The total number of frequency points to

include in the sweep

List

Sweep only specific frequency points.

Segment

Define the individual frequencies to include.

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

224 ni.com

Using the PXIe-5842

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

© National Instruments 225

Figure 50. CAL-5501 Connection to PXIe-5842 VST with S-Parameters

Using the PXIe-5842

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

226 ni.com

Using the PXIe-5842

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

© National Instruments 227

Using the PXIe-5842

PXIe-5633 module, and terminate the other PXIe-5633 port with a 50 Ω
terminator

◦  2-port measurement: Connect each port of your device to a port of the

PXIe-5633 module

12.  Run the measurement by clicking RUN to measure continuously or SINGLE to

capture a single measurement.
The measurement you have configured displays in the measurement graph.

Related tasks:

•  Performing Initial Hardware Configuration

Related information:

•  Navigating InstrumentStudio

Unsupported Software Features
Unsupported Software Features

Certain NI-RFSA and NI-RFSG driver software features are not supported on the
PXIe-5842.

•  RF list mode is not supported with either NI-RFSA or NI-RFSG versions prior to

2023 Q3.

•  Pulse shaping with NI-RFSG is not supported.
•  Pulse modulation is not supported for PXIe-5842 instruments that are based

around a PXIe-5842 module with assembly part number
135077x-01L, where the hardware revision x is a letter.

Restrictions on Scripts

•  if else is not supported.
•  break instruction is not supported.
•  stream instruction is not supported.
•  The maximum compiled script size is 6,100 instructions. Each script language
instruction requires roughly one compiled instruction, plus one instruction for
each marker.

•  Nested repeats are only allowed if the outer repeat is a repeat forever

228 ni.com

instruction, and there are no other instructions preceding it or past the end of the
repeat block. You can only use a single nesting level.

•  Markers are allowed in generate and finite wait instructions. They are not

allowed in conditional wait instructions.

Using the PXIe-5842

© National Instruments 229

Self-Calibration

Self-Calibration
Self-Calibration

Temperature drift and other environmental changes can lead to performance
degradation for several VST specifications. Self-calibration adjusts the instrument for
variations in the environment using an onboard high-precision calibration tone.

Perform self-calibration to compensate and optimize the performance of the PXIe-5842
for a given ambient temperature and operating environment.

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
PXIe-5842  Parameters Adjusted by Self-Calibration
PXIe-5842

Depending on your PXIe-5842 instrument, self-calibration adjusts specific parameters
to facilitate temperature correction.

Instrument

Self-Calibration Adjustment Parameters

•  ADC interleaving spurs
•  LO path gain
•  RF input gain
•  RF output gain
•  RF input residual LO power
•  RF output residual LO power
•  RF input residual sideband image

PXIe-5842 VST

230 ni.com

Instrument

Self-Calibration Adjustment Parameters

Self-Calibration

•  RF output residual sideband image
•  RF input flatness
•  RF output flatness

•  ADC interleaving spurs
•  Internal path gain for LOs
•  RF and millimeter wave input gain
•  RF and millimeter wave output gain
•  RF and millimeter wave input frequency

response

•  RF and millimeter wave output frequency

response

•  RF input residual LO power
•  RF output residual LO power
•  RF input residual sideband image
•  RF output residual sideband image

•  ADC interleaving spurs
•  LO path gain
•  RF input gain
•  RF output gain
•  RF input residual LO power
•  RF output residual LO power
•  RF input residual sideband image
•  RF output residual sideband image
•  RF input flatness
•  RF output flatness

PXIe-5842 VST with 54 GHz Frequency Extension

PXIe-5842 VST with S-Parameters

When to Perform Self-Calibration
When to Perform Self-Calibration

Self-calibration uses internal elements to adjust the PXIe-5842 for variations in the
module environment.

PXIe-5842 modules are externally calibrated at the factory; however you should
perform a self-calibration in any of the following situations:

© National Instruments 231

Self-Calibration

•  After first installing and interconnecting your PXIe-5842 instrument
•  After any module in the chassis is installed, uninstalled, or moved
•  After intermodule cabling has been changed, reconnected, or repositioned
•  After changing controllers, computers, or reinstalling the driver software
•  When the system is in an environment where the ambient temperature varies or
the module temperature has drifted more than ±5 °C from the temperature at the
last self-calibration

Note For the best image rejection and residual LO performance, run Self
Cal or Self Calibrate Range for the image rejection and residual LO
portion any time the module temperature changes beyond ±1 °C.

•  To periodically adjust for small performance drifts that occur with product aging

PXIe-5842
Self-Calibrating the PXIe-5842
Self-Calibrating the

You can self-calibrate your VST either interactively or programmatically; each method
yields the same self-calibration results.

•  Interactive methods—Self-calibration in the InstrumentStudio application, or in

MAX or Hardware Configuration Utility.

•  Programmatic methods—Self-calibration in a supporting programming

environment using an API directly.

•  NI-RFSA

◦  Using the RFSA Self-Calibration programming example
◦  Using self-calibration functions

•  NI-RFSG: using self-calibration functions
•  RFmx: using self-calibration functions

Choose and complete one of the self-calibration methods.

Self-Calibrating the PXIe-5842
Self-Calibrating the

with InstrumentStudio
PXIe-5842  with InstrumentStudio

NI recommends that you perform an initial self-calibration using InstrumentStudio.

NI VSTs are represented in InstrumentStudio as a vector signal analyzer and a vector
signal generator. Performing self-calibration with either representation of the
PXIe-5842 accomplishes the same self-calibration, so it is not necessary to use both

232 ni.com

Self-Calibration

when you self-calibrate the PXIe-5842.

Complete the following steps to self-calibrate your VST with InstrumentStudio.

Note Ensure that any connected external hardware is in an idle state and not
transmitting during self-calibration. NI does not recommend that you
perform a self-calibration while connected in direct loopback configurations.

1.  Before you use the instrument or perform a self-calibration, you must allow the

instrument to warm up.
a.  If your instrument does not have power, complete the following steps to

provide power for your specific instrument:
▪  PXIe-5842 VST with 54 GHz Frequency Extension: Provide power to the
RMM-5585 or RMM-5586 remote measurement module using the power
adapter, then power on the PXI Express chassis.

▪  All other PXIe-5842 instruments: Power on the PXI Express chassis.

b.  Wait for the operating system to load completely.
c.  If your instrument supports multiple device personalities, configure the device

personality in Hardware Configuration Utility or MAX.

Note You must perform an individual self-calibration for each device
personality.

d.  Allow the instrument to warm up for 30 minutes.

2.  Launch InstrumentStudio by navigating to Start » National Instruments »

InstrumentStudio.

3.  To create an analyzer panel for the PXIe-5842, click File » New » RF Signal Analyzer

.

4.  Select the tab for the PXIe-5842 and click the gear icon (

) in the upper right

corner of the right sidebar.

5.  Hover over Device Slot » Calibration and click Self-Calibrate....
6.  Click Continue.

The PXIe-5842 stores the new calibration data in its nonvolatile memory if the self-
calibration is successful.

© National Instruments 233

Self-Calibration

Self-Calibrating the PXIe-5842
Self-Calibrating the
Example
Example

PXIe-5842  with the

with the NI-RFSA

LabVIEW
NI-RFSA  LabVIEW

Complete the following steps to self-calibrate the PXIe-5842 with the NI-RFSA
programming example.

Note Ensure that any connected external hardware is in an idle state and not
transmitting during self-calibration. NI does not recommended that you
perform a self-calibration while connected in direct loopback configurations.

1.  Before you use the instrument or perform a self-calibration, you must allow the

instrument to warm up.
a.  If your instrument does not have power, complete the following steps to

provide power for your specific instrument:
▪  PXIe-5842 VST with 54 GHz Frequency Extension: Provide power to the
RMM-5585 or RMM-5586 remote measurement module using the power
adapter, then power on the PXI Express chassis.

▪  All other PXIe-5842 instruments: Power on the PXI Express chassis.

b.  Wait for the operating system to load completely.
c.  If your instrument supports multiple device personalities, configure the device

personality in Hardware Configuration Utility or MAX.

Note You must perform an individual self-calibration for each device
personality.

d.  Allow the instrument to warm up for 30 minutes.

2.  Launch LabVIEW.
3.  Launch the Example Finder at Help » Find Examples... and navigate to the

example.
a.  Select Hardware Input and Output » Modular Instruments » NI-RFSA »

Utilities » RFSA Self Calibration.

b.  Open the example.

4.  Complete the following steps to configure the example:

a.  Select the device identifier assigned to the PXIe-5842 in MAX in the [Resource

Name] drop-down menu.

b.  Set Clock Source to OnboardClock.
c.  Set Self Calibration Step Operations to Perform All Self Calibration Steps.

234 ni.com

Self-Calibration

5.  Run the VI.

The PXIe-5842 stores the new calibration data in its nonvolatile memory if the self-
calibration is successful.

Partial Self-Calibration
Partial Self-Calibration

Partial self-calibration self-calibrates NI VSTs within only the specified frequency and
reference level limits and gives you the option to omit certain self-calibration steps.

Note For NI VSTs with associated millimeter wave heads or remote
measurement modules that have IF and RF frequency ranges, only the
applicable ports are calibrated within a given frequency range. Only IF ports
are calibrated when you specify a frequency in the IF range, and only RF ports
are calibrated when you specify a frequency in the millimeter wave range.

Performing Partial Self-Calibration
Performing Partial Self-Calibration

Use partial self-calibration instead of self-calibration for your NI VST when you want to
apply self-calibration only to a specific range of frequencies reference level limits or if
you want to reduce execution time by skipping self-calibration of certain aspects that
you can specify.

Note Before you perform this process, stop transmission of external signals
to the instrument. NI recommends that no external signals are transmitted to
any RF input port during the partial self-calibration.

For best results, NI recommends that you perform partial self-calibration without
omitting any steps; the default partial self-calibration does not omit any steps.

However, if certain aspects of performance are less important for your application, you
can omit the following steps for faster execution:

•  LO Self Cal—Omits the LO path gain adjustment.
•  Amplitude Accuracy—Omits the RF absolute amplitude accuracy adjustment.
•  Residual LO Power—Omits the RF residual LO power adjustment.

© National Instruments 235

Self-Calibration

•  Image Suppression—Omits the RF residual sideband suppression adjustment.

Use Self Calibrate Range available in NI-RFSA or NI-RFSG.

Note Self Calibrate Range in NI-RFSA and NI-RFSG does not perform any RF
output calibration steps in NI-RFSG or any RF input calibration steps in
NI-RFSG.

Note Do not access the RF input, RF output, or basecard clock circuitry while
either of these functions is executing.

Notice Resetting the driver results in the loss of any stored partial self-
calibration data. Restarting the computer typically resets the driver.

For more information about calibration, contact NI or visit ni.com/calibration. You can
obtain the calibration certificate for your product at ni.com/calibration.

236 ni.com

Cleaning and Maintaining the PXIe-5842

PXIe-5842
Cleaning and Maintaining the PXIe-5842
Cleaning and Maintaining the

NI recommends the following to clean and maintain your instrument's system.

•  Clean the fan filters on the chassis regularly to prevent fan blockage and to ensure
efficient air circulation. Cleaning frequency depends on the amount of use and the
operating environment. For specific information about cleaning procedures and
other recommended maintenance, refer to the chassis user documentation.

•  Clean the hardware with a soft, nonmetallic brush. Make sure that the hardware is

completely dry and free from contaminants before returning it to service.

Cleaning Threaded RF Connectors
Cleaning Threaded RF Connectors

Keep connector interfaces, especially the outer conductors of threaded RF connectors,
clean and free of dirt and any other debris. Follow the guidelines to maintain the
connectors, and therefore the performance, of your instruments and cables over time.

Contaminants such as metal fibers are sources of uncertainty in measurements.
Contaminants can be abrasive and cause damage to the surfaces of matings
connectors, which inhibits the repeatability of your measurements. Contaminated
connectors pose problems especially for high-frequency, high-precision
measurements because they prevent a good impedance match. Therefore, it is
important to keep the threaded RF connectors in your test system clean.

Required equipment:

•  Protective eyewear
•  Pure, filtered compressed air or nitrogen
•  Magnifying glass
•  (Non–air dielectric connectors only) Lint-free swabs, such as foam swabs, of

appropriate size for the connectors

•  (Non–air dielectric connectors only) Pure (99.5%) isopropyl alcohol
•  (Non–air dielectric connectors only) Toothpick

Notice Do not use swabs or isopropyl alcohol on connectors that have an air

© National Instruments 237

Cleaning and Maintaining the PXIe-5842

dielectric, such as 3.5 mm, 2.92 mm, or 1.85 mm connectors. Refer to front
panel and pinout documentation to confirm the connector types for your
instrument. If using isopropyl alcohol to clean the appropriate connector
types, do so in a well ventilated area.

Complete as many of the following steps as you need to clean threaded RF connectors.
Complete only the steps that are appropriate for the type of connector you are
cleaning:

1.  After putting on protective eyewear, blow out any loose debris from the connector

with compressed air or nitrogen by blowing across the connector face.

Tip Do not blow directly into the connector: blowing into the connector
can lodge any debris more firmly. Blowing across the connector is the
safest method for cleaning connectors that use air dielectric.

2.  (Non–air dielectric connectors only) Examine the connector with a magnifying

glass to check for debris. If you still notice debris, try removing it with a lint-free,
foam-tipped swab by gently moving the foam swab around the center conductor.

Notice Follow these guidelines when cleaning connectors with a foam
swab:

◦  Always clean the connector in a circular motion around the center
pin, not across the pin. Never put lateral pressure on the center pin
of a connector.

◦  Apply as little pressure as necessary. Applying too much pressure

can embed debris deeper into the connector.

Notice NI does not recommend using cotton swabs to clean threaded RF
connectors. Cotton fibers can become lodged in the connector, where
they can cause damage or measurement errors.

3.  (Non–air dielectric connectors only) Examine the connector with a magnifying
glass again. If you still notice debris, barely dampen another foam swab with
isopropyl alcohol (do not saturate it) and attempt to clean the connector in the
same manner as with the first swab.

238 ni.com

Cleaning and Maintaining the PXIe-5842

Notice Do not apply isopropyl alcohol directly to a connector.

4.  Verify that no foam or other foreign material remains in the connector.
5.  (Non–air dielectric connectors only) If the connector is still contaminated, use a
very small toothpick with a small amount of isopropyl alcohol applied. Use the
magnifying glass when using the toothpick.

Notice Use extreme care to avoid damaging the connector with the
toothpick.

6.  If desired, use the compressed air or nitrogen to remove any foreign particles and,

if you used isopropyl alcohol, to dry the connector.

After cleaning, verify that the center pin has not been bent or damaged. Also verify that
the collets of the mating connector are neither bent nor damaged. When connectors
are not in use, keep them covered with the dust cap for included with your instrument
for the connector.

If you are not successful in cleaning the connector after completing as many steps of
this procedure as are appropriate for the connector type, remove the item from service
and label it accordingly.

© National Instruments 239

Troubleshooting

Troubleshooting
Troubleshooting

If an issue persists after you complete a troubleshooting procedure, search our
KnowledgeBase for additional information our technical support engineers create as
they answer common user questions and resolve unexpected issues.

Related information:

•  ni.com/support

My Hardware Doesn't Appear in Hardware Configuration
My Hardware Doesn't Appear in Hardware Configuration
Utility or MAX
Utility or MAX

1.  Check that the ACCESS/ACC LED on the hardware is solid green.
2.  Check if the connection between the hardware and software is working.

Software

Description

Hardware Configuration Utility

Click the refresh button (

).

MAX

a.  In the MAX configuration tree, expand

Devices and Interfaces.

b.  Expand the Chassis tree to see the list of
installed hardware. Then press F5 to
refresh the list.

3.  If the instrument is still not listed, power off the system. Ensure that all hardware is

correctly installed, and restart the system.

4.  Navigate to the Device Manager. Right-click the Start button and select Device

Manager.

5.  Depending on your controller type, verify Device Manager settings.

Controller Type

PXI controller

Description

a.  Verify that a National Instruments entry

appears in the system device list.

b.  If error conditions appear in the list, right-

240 ni.com

Controller Type

Description

Troubleshooting

click the module you are using in the
Device Manager and select Update
Driver.

Right-click PCI-to-PCI Bridge and select
Properties from the shortcut menu to verify
the bridge status.

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

© National Instruments 241

Troubleshooting

What Should I Do if the PXIe-5842
What Should I Do if the

Fails the Self-Test?
PXIe-5842  Fails the Self-Test?

1.  Restart the system.
2.  Launch your NI configuration software and perform an intermediate self-test.

Option

Description

Hardware Configuration Utility

MAX

a.  Select the PXIe-5842 module of your
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

Table 55. PXIe-5842 VST (Up to 2 GHz Bandwidth) Self-Test Connections

Self-Test Item

Ref Clock

[5842] RX LO Cable

[5842] TX LO Cable

[5842] TX RF Detector

Related Physical Connection

136103A-01, PXIe-5842 REF: IN to PXIe-5655
REF OUT

136106A-01, PXIe-5842 RF IN: LO IN to
PXIe-5655 LO 1 OUT

136104A-01, PXIe-5842 RF OUT: LO IN to
PXIe-5655 LO 0 OUT

[5842] RX RF Detector

Check all connections above

[5842] RX ADC Loopback Signal

242 ni.com

Table 56. PXIe-5842 VST with 54 GHz Frequency Extension Self-Test Connections

Troubleshooting

Self-Test Item

Ref Clock

[5842] RX LO Cable

[5842] TX LO Cable

[5842] TX RF Detector

Related Physical Connection

136103A-01, PXIe-5842 REF: IN to PXIe-5655
REF OUT

136106A-01, PXIe-5842 RF IN: LO IN to
PXIe-5655 LO 1 OUT

136104A-01, PXIe-5842 RF OUT: LO IN to
PXIe-5655 LO 0 OUT

[5842] RX RF Detector

Check all connections above

[5842] RX ADC Loopback Signal

[5633/5563] TX Detector

◦  137925A-01, PXIe-5842 RF OUT to

[5633/5563] RX ADC Loopback
Signal

[5585/5586] RMM Upconverter LO
Cable

[5585/5586] RMM Downconverter LO
Cable

[5585/5586] RMM TX RF Detector

[5585/5586] RMM TX RF Detector
Power Delta

[5585/5586] RMM RX ADC Loopback
Signal

[5585/5586] RMM RX ADC Loopback
Power Delta

PXIe-5563 SWITCH IN

◦  137924A-01, PXIe-5842 RF IN to PXIe-5563

SWITCH OUT

137446A-01, RIGHT PXIe-5655 LO 0 OUT to
RMM-5585/RMM-5586 UPCONVERTER/SHARED
LO IN

137446A-01, RIGHT PXIe-5655 LO 1 OUT to
RMM-5585/RMM-5586 DOWNCONVERTER
LO IN

◦  137446A-01, PXIe-5563 IF OUT to
attenuator preinstalled on
RMM-5585/RMM-5586 IF IN

◦  137446A-01, PXIe-5563 IF IN to attenuator
preinstalled on RMM-5585/RMM-5586
IF OUT

Table 57. PXIe-5842 VST with S-Parameters Self-Test Connections

Self-Test Item

Ref Clock

Related Physical Connection

136103A-01, PXIe-5842 REF: IN to PXIe-5655
REF OUT

© National Instruments 243

Troubleshooting

Self-Test Item

Related Physical Connection

[5842] RX LO Cable

[5842] TX LO Cable

[5842] TX RF Detector

[5842] RX RF Detector

[5842] RX ADC Loopback Signal

[5633/5563] TX Detector

[5633/5563] RX ADC Loopback
Signal

136106A-01, PXIe-5842 RF IN: LO IN to
PXIe-5655 LO 1 OUT

136104A-01, PXIe-5842 RF OUT: LO IN to
PXIe-5655 LO 0 OUT

Check all connections above

◦  138278A-01, PXIe-5842 RF IN to PXIe-5633

SWITCH OUT

◦  138277A-01, PXIe-5842 RF OUT to

PXIe-5633 SWITCH IN

Address any issues you identify and perform an intermediate self-test again. If the
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

If the Initialize function for your instrument driver returns an error and the PXIe-5842
fails to initialize, complete the following steps:

1.  Power off the system.
2.  Inspect all PXIe-5842 front panel cables and, if there are no apparent issues,

reconnect cables securely, according to the interconnection procedure for your
instrument.

244 ni.com

Troubleshooting

3.  Power on your system and run the Hardware Configuration Utility or MAX

configuration and intermediate self-test procedures.

Related tasks:

•  Performing Initial Hardware Configuration

© National Instruments 245

Fundamental RF Concepts

Fundamental RF Concepts
Fundamental RF Concepts

Understanding RF concepts and the concepts that underpin NI's RF hardware will help
you be successful with your instrument.

Common NI RF Terminology
Common NI RF Terminology

Refer to the following list for definitions of common NI terms related to RF hardware
and software-configured settings for the PXIe-5842 and used throughout
documentation.

Table 58. Common Terminology Definitions

Term

Definition

Center Frequency

Refers to the IQ Carrier Frequency property in NI-RFSA, the
Frequency property in NI-RFSG, and the Center Frequency
property in RFmx.

Refers to the NI-RFSA Downconverter Frequency Offset Mode
property or NI-RFSG Upconverter Frequency Offset Mode
property set to Automatic.

Equivalent to the term Offset Mode is Automatic.

The PXIe-5842 uses a direct conversion architecture. Offset
Mode allows the instrument to operate in low IF mode, which
increases the separation between the signal of interest and
the residual sideband image and residual LO leakage power.
However, low IF mode limits the available instantaneous
bandwidth. A setting of Automatic allows the driver to set
Offset Mode to Enabled when the signal bandwidth is
configured as small enough to allow it. You can read back the
Offset Mode to determine if the driver selected Enabled or
User-Defined.

Automatic is the default value. NI recommends keeping Offset

Frequency Offset Mode is
Automatic

246 ni.com

Fundamental RF Concepts

Term

Definition

Mode set to the default value.

Refers to the NI-RFSA Downconverter Frequency Offset Mode
property or NI-RFSG Upconverter Frequency Offset Mode
property set to Enabled.

Equivalent to the following terms or conditions:

Frequency Offset Mode is Enabled

•  Offset Mode is Enabled
•  Signal Bandwidth ≤ Maximum Offset Bandwidth

The PXIe-5842 uses a direct conversion architecture. Offset
Mode allows the instrument to operate in low IF mode, which
increases the separation between the signal of interest and
the residual sideband image and residual LO leakage power.

Refers to the NI-RFSA Downconverter Frequency Offset Mode
property or NI-RFSG Upconverter Frequency Offset Mode
property set to User-Defined.

Frequency Offset Mode is User-
Defined

Equivalent to the following terms or conditions:

•  Offset Mode is User-Defined
•  Signal Bandwidth > Maximum Offset Bandwidth

The PXIe-5842 uses a direct conversion architecture. Offset
Mode set to User-Defined allows the instrument to operate
with maximum instantaneous bandwidth.

Onboard

With respect to local oscillators, refers to the value of the LO
Source property. A value of Onboard configures the hardware
to use the integral local oscillator of the instrument, that of
the associated PXIe-5655 module(s).

With respect to reference clocks, refers to the value of the
NI-RFSG Reference Clock Source or NI-RFSA Ref Clock Source

© National Instruments 247

Term

Definition

Fundamental RF Concepts

properties. A value of Onboard Clock configures the hardware
to use the integral reference clock of the instrument, that of
the associated PXIe-5655 module(s).

•  For input—Power of an acquired signal with respect to

the instrument's configured reference level. For example,
if the reference level is set to -10 dBm and the acquired
tone is -17 dBm, the signal is said to be at -7 dBr.

•  For output—Generated power of a CW with respect to the
instrument's peak power setting. For example, with a
peak power level setting of +5 dBm and a -3 dBr setting,
the power of the generated CW is +2 dBm.

dBr

Carrier Wave
Carrier Wave

The carrier wave is a sinusoidal wave that is modulated by a message signal, m(t),
prior to transmission.

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

Related concepts:

•  Message Signal

248 ni.com

Fundamental RF Concepts

Message Signal
Message Signal

The message signal contains the data for transmission.

The message signal is used to modulate the carrier wave to create the modulated wave
for transmission. The message signal data is recovered from the modulated wave by a
process of demodulation.

The message signal is often referred to as the baseband signal.

Related concepts:

•  Carrier Wave

Modulation
Modulation

Modulation is a process that alters the characteristics of a carrier wave according to
information in the message signal to generate and transmit a modulated wave. There
are several different types of modulation.

The unmodulated carrier is represented by the following equation:

v(t) = Accos(2πft+ φ)

The amplitude-modulated carrier signal is represented by the following equation:

v(t) = (m(t) + Ac)cos(2πft+ φ)

The frequency-modulated carrier signal is represented by the following equation:

v(t) = Ac((m(t) + 2πf)t+ φ)

This yields the following equation:

© National Instruments 249

Accos(2πft+ φ + ∫m(t)ⅆt)

The phase-modulated carrier signal is represented by the following equation:

Fundamental RF Concepts

v(t) = Accos(2πft+ φ + m(t))

where

•  m(t) is the time-varying modulation
•  Ac is the amplitude of the carrier wave
•  f is the frequency of the carrier wave

Related concepts:

•  Message Signal
•  Carrier Wave

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
modulation and canonical rectangular modulation.

250 ni.com

Fundamental RF Concepts

Canonical Polar Modulation

Figure 51. Canonical Polar Modulation

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

Figure 52. Canonical Rectangular Modulation

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

R(t)cos(ωc(t) + φ(t))

© National Instruments 251

Fundamental RF Concepts

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
created (in some way) to contain all the information of message input m(t).5 Because
the carriers cos(ωc(t)) and sin(ωc(t)) are orthogonal functions, we use the terminology
of quadrature modulation, where the signal applied to the cosine mixer is called the
In-phase component (I), and the signal applied to the sine mixer is call the Quadrature-
phase component (Q). The I and Q designations are useful because the I(t) baseband
signal is applied to the cosine mixer, and the Q(t) baseband signal is applied to the sine
mixer.

The analytical relationship between the polar form (R(t) and φ(t)) of the baseband
signal and Cartesian form (I(t) and Q(t)) of the baseband signal is shown in the
following figure.

5. The polar R(t) and φ(t) also contain the information of m(t).

252 ni.com

Fundamental RF Concepts

Figure 53. Relationship Between R(t) and φ(t)

jQ

Q

R

f

I

I

The diagram is a "snapshot in time" of the complex (analytical) baseband envelope
g(t). The diagram is for an arbitrary instant in time, therefore the independent time
variable t is dropped. The amplitude of Qprojects onto the imaginary (j) axis. The
amplitude of Iprojects onto the real axis.

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

© National Instruments 253

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

254 ni.com

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

© National Instruments 255

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

Figure 54. Common Mismatch Measurement Error

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

256 ni.com

Fundamental RF Concepts

Figure 55. Discontinuities Caused by Mismatched Cable

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

© National Instruments 257

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

Figure 56. Coupling RF Signal Generators Using an L-Pad
Characteristic Impedance = 50  Ω

500 Ω

50 Ω

475 Ω

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

258 ni.com

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

Table 59. Larger and Smaller RBW Comparison

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

© National Instruments 259

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

260 ni.com

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

© National Instruments 261

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

262 ni.com

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

Figure 57. Total Harmonic Distortion Example

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

Frequency →

© National Instruments 263

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

264 ni.com

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

© National Instruments 265

Fundamental RF Concepts

An amplifier maintains a constant gain for low-level input signals. However, at higher
input levels, the amplifier saturates and its gain decreases. The 1 dB gain compression
point (P1 dB) indicates the power level that causes the gain to drop by 1 dB from its
small signal value.

The 1 dB gain compression point is derived from the gain relationship between output
power and input power. Output power is plotted against input power in the following
figure.

Figure 58. 1 dB Gain Compression Point

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

266 ni.com

waveform. As the waveform is generated, continuously write the remaining waveform
data until generation is complete. The RF signal generator uses the instrument to
stream the waveform.

Fundamental RF Concepts

Related concepts:

•  Streaming Waveform Data

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

© National Instruments 267

Fundamental RF Concepts

        generate waveformA marker0(16)
    end repeat
    repeat 2
        generate waveformB
        generate waveformC
        generate waveformD
    end repeat
end script

Related concepts:

•  Unsupported Software Features

NI-RFSG Marker Event Details

A marker is an event that an NI RF signal generator produces in relation to a waveform
that is generated. The marker event is delayed slightly relative to the leading edge of
the waveform that it marks.

By default, the marker event is a pulse of fixed width. The following figure shows a
waveform generated on the output of a waveform generator. The waveform contains a
pulse that represents a waveform sample n that is one Sample Clock in width. The
second pulse, the marker event, represents the pulse that generates when the
corresponding waveform sample n is output at the output connector.

Figure 59. Waveform Output and Associated Marker Event

•  tm1—Duration of delay between the configured waveform sample n and

generation of the associated marker event. For most NI VSTs, configurable with
NI-RFSG Events Delay and Relative Delay.

•  tm2—Marker event pulse duration. For most NI VSTs, configurable with NI-RFSG

Width Units and Width Value.

268 ni.com

WaveformSample nWaveform Outputon Output ConnectorMarker Eventtm1tm2Fundamental RF Concepts

You can use NI-RFSG to configure the characteristics of the pulse generated as the
Marker event.

In addition, you can use scripts to create markers to develop complex behaviors
around generated waveforms.

For example, you can configure the Marker event as a toggled digital pulse signal that
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

© National Instruments 269

Fundamental RF Concepts

NI recommends using dynamic reservations and routing whenever possible.

•  Static route—Signal route that you create manually. You can implement static

reservation of trigger lines in MAX through the Triggers tab.

Refer to your chassis documentation to determine the PXI trigger bus segments of your
chassis.

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

270 ni.com

Creating Static Routes in MAX

Static routes are a way to manually designate a route on the PXI trigger bus between a
specific signal source and a specific signal destination.

Fundamental RF Concepts

Note NI recommends using dynamic reservations and routing whenever
possible. If your application contains too many static routes between PXI
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

© National Instruments 271

Fundamental RF Concepts

Triggers

A trigger is an input signal to an instrument or channel that causes the instrument or
channel to perform an action. Triggers are routed to input terminals to coordinate
actions.

An input terminal is a physical trigger line (such as a PXI trigger line) or an output
terminal on another instrument or channel where an instrument or channel awaits a
digital edge trigger signal.

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

272 ni.com

Fundamental RF Concepts

Triggers and clocks are generally considered input signals. Exportable triggers and
clocks, such as the sample clock, can also be considered output signals. Output
signals that have neither a trigger nor clock counterpart are called events.

You typically configure events for a specific hardware condition and then do one of the
following:

•  Export the events for use in the test program
•  Export the events to a PXI trigger line to cause an action in another instrument that

is configured to wait for a trigger on that PXI trigger line

Related concepts:

•  NI-RFSA Named Trigger Types
•  NI-RFSA Trigger Signal Conditions
•  NI-RFSA Event Types
•  NI-RFSG Named Trigger Types
•  NI-RFSG Trigger Signal Conditions
•  NI-RFSG Event Types

De-embedding Overview
De-embedding Overview

NI RF instrument performance specifications are for signals at the instrument's ports.
However, you must also account for external cabling and components between the
instrument and DUT, which also affects input and output signals.

Figure 60. Effect of the External Network on Signals

VST Reference Plane

DUT Reference Plane

VST

External
Network

DUT

De-embedding is the process of removing the effects of these components on an input
or output signal, so the accuracy of the instrument is extended to the DUT.

© National Instruments 273

Fundamental RF Concepts

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

S-parameters

S-parameters characterize the effects of a linear network on a signal when it passes
from one port of the network to another port. For purposes of de-embedding for VST
operation, the instrument driver compensates for the effects of the networks by
modifying the analog path and adjusting the data with DSP.

S-parameters of the de-embedding network can be obtained by either extracting them
using a vector network analyzer (VNA) or by simulating the network in an RF computer
assisted design (CAD) tool.

NI-RFSA and NI-RFSG support de-embedding of two port networks. Two port networks
are characterized by four s-parameters. S-parameters are written in the format Snm,
where n, designates the receiving port, and m, designates the driving port. Each S-
parameter is referred to as a gain or reflection term.

The following table illustrates which terms characterize gain or reflection of the
network.

Table 60. S-parameters

S-parameter

S11

S21

274 ni.com

Description

reflection (input reflection)

gain (forward transmission)

Fundamental RF Concepts

S-parameter

S12

S22

Description

gain (reverse isolation)

reflection (output reflection)

Gain terms, S12 and S21, model the gain an input signal experiences as it passes
through the network to the receiving port. The reflection terms, S11 and S22, are used
when computing the effects of signal reflection due to impedance mismatch between
the network's ports and driving ports.

The following figure provides a visualization of the external network as an S-parameter
model. Signal b', output from the DUT, passes through the external network and
arrives at the VST as signal b. Signal a, generated by the VST, passes through the
network and arrives at the DUT as signal a'. The following are reflection terms for the
instrument ports:

•  ΓL_VSA
•  ΓL_VSG

Figure 61. S-parameter modeling of an external network for NI-RFSA and NI-RFSG

S21

a

VSG

L_VSG

S11

S22

VST

S12

S21

b

VSA

L_VSA

S11

S22

a’

b’

DUT

Scalar De-embedding

S12

Scalar de-embedding compensates only for the gain term of the S-parameters.

© National Instruments 275

Fundamental RF Concepts

In the previous figure, the DUT output is connected to port2 of the external network
and port1 is connected to the NI device port. By convention, the S12 parameter
specifies the gain due to the network, and applied to the signal b' output from the DUT
toward the VSA port. NI-RFSA computes the signal at the DUT port using the following
formula:

b ′ =

b
S12

To acquire the output signal of the DUT and not the signal seen at the NI instrument's
port, NI-RFSA compensates for the network by amplifying the signal. The driver makes
DSP adjustments to compensate for any remaining effects that analog path
adjustments do not compensate for. NI-RFSA returns data reflecting the amplitude of
the signal at the DUT.

Similarly, when using NI-RFSG scalar de-embedding, the driver computes the output
signal at the DUT port using the following formula:

a ′ = S21 × a

The receiving port in this case is port2 at the DUT and the input port is port1 at the NI
instrument's port. NI-RFSG compensates for the network via analog path adjustments
and DSP so that the signal you request arrives at the DUT with the correct amplitude.

Quadrature Mixing (Direct Conversion)
Quadrature Mixing (Direct Conversion)

Quadrature mixing allows for the complex modulation or demodulation of signals as
represented by two orthogonal signals I and Q. Quadrature mixing has the added
benefit of an increased complex bandwidth that allows for net bandwidths up to the
sample rate of the DACs.

Analog quadrature mixing exposes the signal to impairments because of the
imperfections of the circuitry involved. These imperfections can create distortion
products or unwanted signals, which may degrade modulation and demodulation
quality. The following section illustrates key impairments involved in quadrature
mixing and how they affect the respective signal.

The following figure shows a typical quadrature transmission device. The shaded

276 ni.com

sections represent the presence of several impairments, including DC offsets within
the various baseband sections and LO signal power leaking into the RF path because of
imperfect isolation.

Fundamental RF Concepts

DAC

DAC

DC Offset
Error

r
o
t
c
e
n
n
o
C

+45

–45

RF OUT

LO

Offsets and the lack of LO isolation can cause unwanted distortion, defined as residual
LO power, which is always centered on the tuned LO frequency. Digital equalization
schemes can help suppress residual LO power. This suppression improves the
performance of the system for many modulation schemes.

For an I/Q waveform to be represented perfectly, I and Q should have a gain ratio of 1
and be 90 degrees out of phase (orthogonal). Several components in an analog
quadrature mixing system can degrade the gain ratio or the phase offset from the ideal
values. These impairments are known as gain imbalance and skew.

The shaded sections in the following figure represent several components that affect
the phase offset and create skew.

© National Instruments 277

Fundamental RF Concepts

DAC

DAC

Group Delay
Differences
Between Paths

r
o
t
c
e
n
n
o
C

Time
Delay

Time
Delay

+45

–45+ ϕ

LO

The presence of gain imbalance or skew-related impairments creates a distortion at
the negative complex frequency of the tone of interest. This distortion is referred to as
the residual sideband image or the image. Gain imbalances also exist in the I and Q
paths (not shown), which also contributes to residual sideband image.

Wideband applications drive the necessity to suppress this distortion to avoid
unwanted signals that can corrupt transmitted or received data. On the PXIe-5842,
calibrated digital equalization suppresses most of the image to improve the
performance of the system.

Average Power and Crest Factor Considerations
Average Power and Crest Factor Considerations

Crest factor is the difference between peak signal power and average power.

The crest factor for a sinusoidal signal, as is used in CW mode, is 3 dB. In other words,
the average RMS power of the sinusoid is 3 dB less than its peak instantaneous power.
For modulated signals, specifically orthogonal frequency-division multiplexing
(OFDM), the crest factor can be much larger, in the order of 10 dB to 12 dB.

Consider both the average power and the crest factor of a signal when you configure
the device for generation. The PXIe-5842 supports a maximum specified peak output
power. Generating signals beyond specification are not guaranteed to be calibrated or
linear. If the peak power is set higher than specified as a result of signal crest factor
added with requested average power, severe saturation might occur. Refer to the

278 ni.com

PXIe-5842 Specifications for more information about output power range
specifications.

Fundamental RF Concepts

Related information:

•  PXIe-5842 Specifications

© 2026 National Instruments Corporation.

© National Instruments 279

