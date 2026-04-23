NI-RFSG
LabVIEW VI
Reference

2026-04-21

NI-RFSG LabVIEW VI Reference

Contents
Contents

NI-RFSG . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   17
niRFSG Initialize VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   17
niRFSG Configure RF VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   18
niRFSG Initiate VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   20
niRFSG Check Generation Status VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   21
niRFSG Close VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   22
niRFSG Property Node VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   23
Generation Configuration  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   24
Configure Waveform . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   24
niRFSG Configure Generation Mode VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   24
niRFSG Write Arb Waveform VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   26
niRFSG Write Arb Waveform (Complex DBL) VI  . . . . . . . . . . . . . . . . . . . .   27
niRFSG Write Arb Waveform (Complex SGL) VI  . . . . . . . . . . . . . . . . . . . .   28
niRFSG Write Arb Waveform (Complex Input) VI . . . . . . . . . . . . . . . . . . .   29
niRFSG Write Arb Waveform (Complex Input SGL) VI . . . . . . . . . . . . . . .   31
niRFSG Write Arb Waveform (CWDT) VI . . . . . . . . . . . . . . . . . . . . . . . . . . .   33
niRFSG Write Arb Waveform (CWDT SGL) VI . . . . . . . . . . . . . . . . . . . . . . .   34
niRFSG Write Arb Waveform (I-Q) VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   36
niRFSG Write Arb Waveform (I-Q SGL) VI . . . . . . . . . . . . . . . . . . . . . . . . . .   37
niRFSG Write Arb Waveform (I16) VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   39
niRFSG Write Arb Waveform (Direct DMA) VI . . . . . . . . . . . . . . . . . . . . . . .   40
niRFSG Write Script VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   41
niRFSG Check If Waveform Exists VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   42
niRFSG Check If Script Exists VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   43
niRFSG Read and Download Waveform From File (TDMS) VI . . . . . . . . . . . . .   44
niRFSG Clear Arb Waveform VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   46
niRFSG Clear All Arb Waveforms VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   47
niRFSG Configure Digital Modulation User Defined Waveform VI . . . . . . . . .   48
rfsg_Resample and Write VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   49
rfsg_Resample and Write (Complex Input) VI  . . . . . . . . . . . . . . . . . . . . .   49
rfsg_Resample and Write (CWDT) VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   51
rfsg_Resample and Write (I-Q) VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   53

2 ni.com

NI-RFSG LabVIEW VI Reference

niRFSG Fractional Resampling VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   55
niRFSG Fractional Resampling (Complex Input) VI . . . . . . . . . . . . . . . . .   56
niRFSG Fractional Resampling (CWDT) VI . . . . . . . . . . . . . . . . . . . . . . . . .   60
niRFSG Fractional Resampling (I-Q) VI . . . . . . . . . . . . . . . . . . . . . . . . . . . .   62
niRFSG Select Arb Waveform VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   65
niRFSG Configure Signal Bandwidth VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   66
niRFSG Set Arb Waveform Next Write Position VI  . . . . . . . . . . . . . . . . . . . . . . .   67
niRFSG Configure Power Level Type VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   69
niRFSG Allocate Arb Waveform VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   70
Burst Location . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   72
niRFSG Set Waveform Burst Start Locations VI  . . . . . . . . . . . . . . . . . . . .   72
niRFSG Set Waveform Burst Stop Locations VI  . . . . . . . . . . . . . . . . . . . .   73
niRFSG Get Waveform Burst Start Locations VI . . . . . . . . . . . . . . . . . . . .   74
niRFSG Get Waveform Burst Stop Locations VI  . . . . . . . . . . . . . . . . . . . .   75
Marker Event . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   76
niRFSG Set Waveform Marker Event Locations VI . . . . . . . . . . . . . . . . . .   76
niRFSG Get Waveform Marker Event Locations VI . . . . . . . . . . . . . . . . . .   77
niRFSG Get All Named Waveform Names VI . . . . . . . . . . . . . . . . . . . . . . . . . . . .   79
niRFSG Get All Script Names VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   79
niRFSG Get Script VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   80
niRFSG Delete Script VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   81
Configuration List . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   82
niRFSG Create Configuration List VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   83
niRFSG Create Configuration List Step VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   87
niRFSG Delete Configuration List VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   88
niRFSG Check If Configuration List Exists VI . . . . . . . . . . . . . . . . . . . . . . . . . . . .   89
Configure Trigger . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   90
niRFSG Configure Trigger VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   90
niRFSG Configure Start Trigger Digital Edge VI  . . . . . . . . . . . . . . . . . . . .   91
niRFSG Configure Start Trigger Software VI  . . . . . . . . . . . . . . . . . . . . . . .   92
niRFSG Disable Start Trigger VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   93
niRFSG Configure Script Trigger Digital Edge VI  . . . . . . . . . . . . . . . . . . .   94
niRFSG Configure Script Trigger Digital Level VI  . . . . . . . . . . . . . . . . . . .   95
niRFSG Configure Script Trigger Software VI  . . . . . . . . . . . . . . . . . . . . . .   96
niRFSG Disable Script Trigger VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   97
niRFSG Configure Configuration List Step Trigger Digital Edge VI . . . .   98

© National Instruments 3

NI-RFSG LabVIEW VI Reference

niRFSG Disable Configuration List Step Trigger VI . . . . . . . . . . . . . . . . . .   99
niRFSG Configure Start Trigger P2P Endpoint Fullness VI . . . . . . . . . .   100
niRFSG Send Software Edge Trigger VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   101
niRFSG Export Signal VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   102
niRFSG Get Terminal Name VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   105
Configure Clock  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   107
niRFSG Configure Ref Clock VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   107
niRFSG Configure PXI Chassis Clk10 VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   110
Peer To Peer . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   111
niRFSG Get Stream Endpoint Handle VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   112
niRFSG Write P2P Endpoint (I16) VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   113
De-embedding  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   114
niRFSG Create De-embedding S-parameter Table VI . . . . . . . . . . . . . . . . . . .   114
niRFSG Create De-embedding S-parameter Table (S2P file) VI  . . . . .   115
niRFSG Create De-embedding S-parameter Table (array) VI  . . . . . . .   116
niRFSG Delete De-embedding Table VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   118
niRFSG Delete All De-embedding Tables VI  . . . . . . . . . . . . . . . . . . . . . . . . . . .   119
niRFSG Select De-embedding Table VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   120
niRFSG Configure De-embedding Table Interpolation VI  . . . . . . . . . . . . . . .   121
niRFSG Configure De-embedding Table Interpolation (Nearest) VI  .   121
niRFSG Configure De-embedding Table Interpolation (Linear) VI . . .   122
niRFSG Configure De-embedding Table Interpolation (Spline) VI . . .   124
niRFSG Get De-embedding S-parameters VI  . . . . . . . . . . . . . . . . . . . . . . . . . .   125
niRFSG Abort VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   126
Utility  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   127
niRFSG Initialize With Options VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   127
niRFSG Commit VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   129
niRFSG Wait Until Settled VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   130
niRFSG Configure Output Enabled VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   131
niRFSG Self Test VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   132
niRFSG Reset VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   134
niRFSG Reset With Options VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   135
niRFSG Reset Device VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   136
niRFSG Save Configurations To File VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   138
niRFSG Load Configurations From File VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   139
niRFSG Perform Power Search VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   140

4 ni.com

NI-RFSG LabVIEW VI Reference

niRFSG Get Session Reference VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   141
niRFSG Revision Query VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   142
niRFSG Query Arb Waveform Capabilities VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   143
niRFSG Perform Thermal Correction VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   144
niRFSG Error Message VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   145
niRFSG Get Max Settable Power VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   146
Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   147
Self Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   148
niRFSG Self Cal VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   148
niRFSG Self Calibrate Range VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   150
niRFSG Get Self Calibration Date and Time VI . . . . . . . . . . . . . . . . . . . . . . . . .   152
niRFSG Get Self Calibration Temperature VI . . . . . . . . . . . . . . . . . . . . . . . . . . .   153
niRFSG Clear Self Calibrate Range VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   154
niRFSG 5840 Align LO Daisy Chain VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   155
External Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   157
niRFSG Initialize External Calibration VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   157
niRFSG Close External Calibration VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   158
niRFSG Get External Calibration Last Date and Time VI . . . . . . . . . . . . . . . . .   159
niRFSG Change External Calibration Password VI . . . . . . . . . . . . . . . . . . . . . .   160
niRFSG Update External Calibration Temperature VI . . . . . . . . . . . . . . . . . . .   161
niRFSG Update External Calibration Date And Time VI  . . . . . . . . . . . . . . . . .   162
NI PXIe-5611 Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   163
niRFSG 5611 Initialize LO Filter Calibration VI  . . . . . . . . . . . . . . . . . . . .   163
niRFSG 5611 Configure LO Filter Calibration VI . . . . . . . . . . . . . . . . . . .   164
niRFSG 5611 Adjust LO Filter Calibration VI  . . . . . . . . . . . . . . . . . . . . . .   165
niRFSG 5611 Initialize LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . . .   167
niRFSG 5611 Configure LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . .   168
niRFSG 5611 Adjust LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . . . . .   169
niRFSG 5611 Initialize Impairment Calibration VI . . . . . . . . . . . . . . . . .   170
niRFSG 5611 Configure Impairment Calibration VI . . . . . . . . . . . . . . . .   171
niRFSG 5611 Adjust Impairment Calibration VI . . . . . . . . . . . . . . . . . . .   174
niRFSG 5611 Initialize RF Gain Calibration VI . . . . . . . . . . . . . . . . . . . . .   175
niRFSG 5611 Configure RF Gain Calibration VI . . . . . . . . . . . . . . . . . . . .   176
niRFSG 5611 Adjust RF Gain Calibration VI . . . . . . . . . . . . . . . . . . . . . . .   179
NI PXIe-5653 Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   181
niRFSG 5653 Initialize Reference Clock Calibration VI . . . . . . . . . . . . .   181

© National Instruments 5

NI-RFSG LabVIEW VI Reference

niRFSG 5653 Configure Reference Clock Calibration VI . . . . . . . . . . . .   182
niRFSG 5653 Adjust Reference Clock Calibration VI  . . . . . . . . . . . . . . .   183
niRFSG 5653 Initialize YIG Frequency Calibration VI . . . . . . . . . . . . . . .   184
niRFSG 5653 Configure YIG Frequency Calibration VI . . . . . . . . . . . . . .   185
niRFSG 5653 Adjust YIG Frequency Calibration VI . . . . . . . . . . . . . . . . .   186
niRFSG 5653 Initialize LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . . .   187
niRFSG 5653 Configure LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . .   188
niRFSG 5653 Adjust LO Gain Calibration VI . . . . . . . . . . . . . . . . . . . . . . .   189
NI 5652 Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   190
niRFSG 5652 Initialize ALC Calibration VI  . . . . . . . . . . . . . . . . . . . . . . . .   190
niRFSG 5652 Configure ALC Calibration VI  . . . . . . . . . . . . . . . . . . . . . . .   191
niRFSG 5652 Adjust ALC Calibration VI . . . . . . . . . . . . . . . . . . . . . . . . . . .   192
niRFSG 5652 Initialize Attenuator Calibration VI . . . . . . . . . . . . . . . . . .   193
niRFSG 5652 Configure Attenuator Calibration VI . . . . . . . . . . . . . . . . .   194
niRFSG 5652 Adjust Attenuator Calibration VI . . . . . . . . . . . . . . . . . . . .   195
niRFSG 5652 Validate ALC Limits Table VI . . . . . . . . . . . . . . . . . . . . . . . .   196
niRFSG 5652 Initialize Reference Clock Calibration VI . . . . . . . . . . . . .   197
niRFSG 5652 Configure Reference Clock Calibration VI . . . . . . . . . . . .   198
niRFSG 5652 Adjust Reference Clock Calibration VI  . . . . . . . . . . . . . . .   199
NI PXIe-5654 Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   200
niRFSG 5654 Power Cal Initialize VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   201
niRFSG 5654 Power Cal Configure VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . .   201
niRFSG 5654 Power Cal Adjust VI  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   202
niRFSG 5654 OCXO Cal Initialize VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   203
niRFSG 5654 OCXO Cal Configure VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   204
niRFSG 5654 OCXO Cal Adjust VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   205
NI PXIe-5696 Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   206
niRFSG 5696 Attenuator Path Cal Initialize VI . . . . . . . . . . . . . . . . . . . . .   206
niRFSG 5696 Attenuator Path Cal Configure VI  . . . . . . . . . . . . . . . . . . .   207
niRFSG 5696 Attenuator Path Cal Adjust VI . . . . . . . . . . . . . . . . . . . . . . .   208
niRFSG 5696 Attenuator Cal Initialize VI  . . . . . . . . . . . . . . . . . . . . . . . . .   209
niRFSG 5696 Attenuator Cal Configure VI . . . . . . . . . . . . . . . . . . . . . . . .   210
niRFSG 5696 Attenuator Cal Adjust VI  . . . . . . . . . . . . . . . . . . . . . . . . . . .   211
niRFSG 5696 Amplifier Cal Initialize VI . . . . . . . . . . . . . . . . . . . . . . . . . . .   212
niRFSG 5696 Amplifier Cal Configure VI . . . . . . . . . . . . . . . . . . . . . . . . . .   213
niRFSG 5696 Amplifier Cal Adjust VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   214

6 ni.com

NI-RFSG LabVIEW VI Reference

niRFSG 5696 ALC Cal Initialize VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   215
niRFSG 5696 ALC Cal Configure VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   216
niRFSG 5696 ALC Cal Adjust VI . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   217
niRFSG Properties . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   218
Active Channel  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   218
Arb . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   218
Advanced . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   218
Arb:Advanced:Compensate for Filter Group Delay . . . . . . . . . . . . . . . . . . . . .   218
Arb:Advanced:Digital Gain (dB) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   219
Arb:Advanced:Overflow Error Reporting . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   220
Arb:Arb Carrier Frequency (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   221
Arb:Arb Power (dBm) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   222
Data Transfer . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   223
Advanced . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   223
Arb:Data Transfer:Advanced:Host DMA Buffer Size . . . . . . . . . . . . . . . .   223
Arb:Data Transfer:Advanced:Maximum In-Flight Read Requests  . . .   223
Arb:Data Transfer:Advanced:Preferred Packet Size  . . . . . . . . . . . . . . .   224
Arb:Data Transfer:Data Transfer Block Size  . . . . . . . . . . . . . . . . . . . . . . . . . . .   225
Arb:Data Transfer:Direct Download . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   226
Arb:Data Transfer:Maximum Bandwidth . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   227
Streaming . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   227

Arb:Data Transfer:Streaming:Space Available In Streaming Waveform
(Samples) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   228
Arb:Data Transfer:Streaming:Streaming Enabled . . . . . . . . . . . . . . . . .   228
Arb:Data Transfer:Streaming:Streaming Waveform Name . . . . . . . . .   229
Arb:Data Transfer:Streaming:Streaming Write Timeout . . . . . . . . . . .   230
Arb:Device Instantaneous Bandwidth (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   231
Arb:Digital Equalization Enabled  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   231
Arb:Digital Pattern . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   233
Arb:Generation Mode  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   234
Arb:IQ Rate (S/s) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   235
Arb:IQ Swap Enabled . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   237
Arb:Memory Size  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   238
Arb:Phase Continuity Enabled  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   239
Arb:Pre-filter Gain (dB) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   241
Pulse Shaping . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   241

© National Instruments 7

NI-RFSG LabVIEW VI Reference

Arb:Pulse Shaping:Filter Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   241
Arb:Pulse Shaping:Raised Cosine Alpha . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   242
Arb:Pulse Shaping:Root Raised Cosine Alpha . . . . . . . . . . . . . . . . . . . . . . . . .   243
Arb:Selected Script  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   244
Arb:Signal Bandwidth (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   245
Arb:Software Scaling Factor . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   246
Waveform Attributes . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   247
Arb:Waveform Attributes:Waveform IQ Rate (S/s) . . . . . . . . . . . . . . . . . . . . . .   247
Arb:Waveform Attributes:Waveform PAPR (dB) . . . . . . . . . . . . . . . . . . . . . . . .   248
Arb:Waveform Attributes:Waveform RF Blanking . . . . . . . . . . . . . . . . . . . . . .   248
Arb:Waveform Attributes:Waveform Runtime Scaling . . . . . . . . . . . . . . . . . .   249
Arb:Waveform Attributes:Waveform Signal Bandwidth (Hz)  . . . . . . . . . . . .   250
Arb:Waveform Attributes:Waveform Size . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   250
Waveform Capabilities  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   251
Arb:Waveform Capabilities:Max Number Waveforms  . . . . . . . . . . . . . . . . . .   251
Arb:Waveform Capabilities:Max Waveform Size . . . . . . . . . . . . . . . . . . . . . . .   252
Arb:Waveform Capabilities:Min Waveform Size . . . . . . . . . . . . . . . . . . . . . . . .   252
Arb:Waveform Capabilities:Selected Waveform . . . . . . . . . . . . . . . . . . . . . . .   253
Arb:Waveform Capabilities:Waveform Quantum  . . . . . . . . . . . . . . . . . . . . . .   254
Arb:Waveform Repeat Count . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   255
Arb:Waveform Repeat Count Is Finite  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   255
Write Waveform Burst Detection  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   256
Arb:Write Waveform Burst Detection:Enabled . . . . . . . . . . . . . . . . . . . . . . . . .   256
Arb:Write Waveform Burst Detection:Mode . . . . . . . . . . . . . . . . . . . . . . . . . . .   257
Arb:Write Waveform Burst Detection:Power Threshold  . . . . . . . . . . . . . . . .   258
Arb:Write Waveform Normalization . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   259
Clock . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   260
Advanced . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   260
Clock:Advanced:Arb Oscillator Phase DAC Value  . . . . . . . . . . . . . . . . . . . . . .   260
Clock:Arb Onboard Sample Clock Mode . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   261
Clock:Arb Sample Clock Rate (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   262
Clock:Arb Sample Clock Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   262
Clock:PXI Chassis Clk 10 Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   263
Clock:Reference Clock Export Output Terminal  . . . . . . . . . . . . . . . . . . . . . . . . . . . .   265
Clock:Reference Clock Exported Rate (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   266
Clock:Reference Clock Rate (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   267

8 ni.com

NI-RFSG LabVIEW VI Reference

Clock:Reference Clock Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   269
Configuration List . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   271
Configuration List:Active List . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   272
Configuration List:Active Step . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   273
Configuration List:Configuration List Is Done  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   273
Configuration List:Configuration List Repeat . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   274
Configuration List:Step In Progress . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   275
De-embedding  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   276
De-embedding:Compensation Gain  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   276
De-embedding:Selected Table . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   277
De-embedding:Type  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   278
Device Characteristics . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   279
Device Characteristics:AE Temperature (Degrees C)  . . . . . . . . . . . . . . . . . . . . . . . .   279
Device Characteristics:AWG Temperature (Degrees C)  . . . . . . . . . . . . . . . . . . . . . .   279
Device Characteristics:Device Temperature (Degrees C) . . . . . . . . . . . . . . . . . . . . .   280
Device Characteristics:FPGA Target Name . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   281
Device Characteristics:FPGA Temperature (Degrees C) . . . . . . . . . . . . . . . . . . . . . .   282
Device Characteristics:LO Temperature (Degrees C)  . . . . . . . . . . . . . . . . . . . . . . . .   283
Device Characteristics:Module Power Consumption (W)  . . . . . . . . . . . . . . . . . . . .   283
Device Characteristics:Module Revision . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   284
Options . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   285
Device Characteristics:Options:Fast Tuning Option . . . . . . . . . . . . . . . . . . . .   285
Device Characteristics:Serial Number . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   285
Device Characteristics:Temperature Read Interval . . . . . . . . . . . . . . . . . . . . . . . . . .   286
Device Specific . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   286
Vector Signal Transceiver . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   286
Device Characteristics . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   286

Device Specific:Vector Signal Transceiver:Device Characteristics:FPGA
Bitfile Path . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   287
Events . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   287
Device Specific:Vector Signal Transceiver:Events:Events Delay  . . . .   287
IQ Out Port . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   289

Device Specific:Vector Signal Transceiver:IQ Out Port:Carrier
Frequency  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   289
Device Specific:Vector Signal Transceiver:IQ Out Port:Common Mode
Offset . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   290

© National Instruments 9

NI-RFSG LabVIEW VI Reference

Device Specific:Vector Signal Transceiver:IQ Out Port:Level . . . . . . .   291
Device Specific:Vector Signal Transceiver:IQ Out Port:Load
Impedance . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   292
Device Specific:Vector Signal Transceiver:IQ Out Port:Offset  . . . . . .   293
Device Specific:Vector Signal Transceiver:IQ Out Port:Temperature
(Degrees C) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   294
Device Specific:Vector Signal Transceiver:IQ Out Port:Terminal
Configuration  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   295
Signal Path . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   296
Device Specific:Vector Signal Transceiver:Signal Path:Absolute Delay . .
296
Available Paths . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   297
Device Specific:Vector Signal Transceiver:Signal Path:Available
Paths:Available Paths  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   297
Device Specific:Vector Signal Transceiver:Signal Path:Available Ports  . .
297
Device Specific:Vector Signal Transceiver:Signal Path:Fixed Group
Delay Across Ports  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   298
Device Specific:Vector Signal Transceiver:Signal Path:Interpolation
Delay . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   299
Device Specific:Vector Signal Transceiver:Signal Path:LO Frequency
Step Size (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   299
Device Specific:Vector Signal Transceiver:Signal Path:LO PLL Fractional
Mode Enabled . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   302
Device Specific:Vector Signal Transceiver:Signal Path:LO Source . . .   303
Device Specific:Vector Signal Transceiver:Signal Path:LO VCO
Frequency Step Size (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   305
Device Specific:Vector Signal Transceiver:Signal Path:Output Port . . . . .
306
Device Specific:Vector Signal Transceiver:Signal Path:RF Blanking
Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   307
Device Specific:Vector Signal Transceiver:Signal Path:Relative Delay . . .
309
Selected Path  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   310
Device Specific:Vector Signal Transceiver:Signal Path:Selected
Path:Selected Path . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   310
Device Specific:Vector Signal Transceiver:Signal Path:Selected Ports . . .

10 ni.com

NI-RFSG LabVIEW VI Reference

311

Triggers . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   312

Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock
Dist Line  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   312
Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock
Master . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   313
Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger
Dist Line  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   314
Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger
Master . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   315
Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger
Dist Line  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   316
Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger
Master . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   317
Upconverter . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   318
Device Specific:Vector Signal Transceiver:Upconverter:Frequency
Offset (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   318
Events . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   320
Events:Configuration Settled Event Export Output Terminal . . . . . . . . . . . . . . . . .   320
Events:Configuration Settled Event Terminal Name . . . . . . . . . . . . . . . . . . . . . . . .   321
Events:Done Event Export Output Terminal  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   322
Events:Done Event Terminal Name . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   325
Marker . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   326
Events:Marker:Output Behavior . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   326
Events:Marker:Output Terminal . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   327
Pulse . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   329
Events:Marker:Pulse:Width Units . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   329
Events:Marker:Pulse:Width Value . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   330
Events:Marker:Terminal Name . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   331
Toggle . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   332
Events:Marker:Toggle:Initial State . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   332
Pulse Modulation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   333
Events:Pulse Modulation:Exported Pulse Modulation Event Active Level . . . . .
333
Events:Pulse Modulation:Exported Pulse Modulation Event Output
Terminal . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   334

© National Instruments 11

NI-RFSG LabVIEW VI Reference

Events:Started Event Export Output Terminal . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   335
Events:Started Event Terminal Name  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   338
Timer . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   339
Events:Timer:Interval  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   339
External Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   339
External Calibration:Last External Calibration Temperature  . . . . . . . . . . . . . . . . .   340
External Calibration:Recommended Interval . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   340
IQ Impairment . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   341
IQ Impairment:Enabled  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   341
IQ Impairment:Gain Imbalance (dB)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   341
IQ Impairment:I Offset  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   342
IQ Impairment:IQ Skew (Degrees)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   343
IQ Impairment:Offset Units . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   344
IQ Impairment:Q Offset . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   346
Inherent IVI Attributes . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   346
Advanced Session Information . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   346
Inherent IVI Attributes:Advanced Session Information:Logical Name . . . .   346
Inherent IVI Attributes:Advanced Session Information:Resource Descriptor . .
347

Driver Capabilities . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   348
Inherent IVI Attributes:Driver Capabilities:Class Group Capabilities  . . . . .   348
Inherent IVI Attributes:Driver Capabilities:Supported Instrument Models . . . .
348

Driver Identification . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   349

Inherent IVI Attributes:Driver Identification:Class Specification Major
Version  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   349
Inherent IVI Attributes:Driver Identification:Class Specification Minor
Version  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   350
Inherent IVI Attributes:Driver Identification:Description . . . . . . . . . . . . . . . .   350
Inherent IVI Attributes:Driver Identification:Driver Prefix . . . . . . . . . . . . . . .   351
Inherent IVI Attributes:Driver Identification:Driver Vendor . . . . . . . . . . . . . .   352
Inherent IVI Attributes:Driver Identification:Revision  . . . . . . . . . . . . . . . . . .   352
Instrument Identification . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   353
Inherent IVI Attributes:Instrument Identification:Firmware Revision  . . . .   353
Inherent IVI Attributes:Instrument Identification:Manufacturer . . . . . . . . .   353
Inherent IVI Attributes:Instrument Identification:Model . . . . . . . . . . . . . . . .   354

12 ni.com

NI-RFSG LabVIEW VI Reference

User Options . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   354
Inherent IVI Attributes:User Options:Cache . . . . . . . . . . . . . . . . . . . . . . . . . . .   355
Inherent IVI Attributes:User Options:Interchange Check  . . . . . . . . . . . . . . .   355
Inherent IVI Attributes:User Options:Query Instrument Status . . . . . . . . . .   356
Inherent IVI Attributes:User Options:Range Check . . . . . . . . . . . . . . . . . . . . .   357
Inherent IVI Attributes:User Options:Record Value Coercions . . . . . . . . . . .   358
Inherent IVI Attributes:User Options:Simulate  . . . . . . . . . . . . . . . . . . . . . . . .   359
Load Configurations  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   359
Load Configurations:Load Options  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   359
Load Configurations:Reset Options . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   360
Modulation  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   361
Analog . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   361
Modulation:Analog:AM Sensitivity . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   361
Modulation:Analog:FM Band . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   362
Modulation:Analog:FM Deviation (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   363
Modulation:Analog:FM Narrowband Integrator  . . . . . . . . . . . . . . . . . . . . . . .   364
Modulation:Analog:FM Sensitivity . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   365
Modulation:Analog:Modulation Type  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   365
Modulation:Analog:PM Deviation (Degrees)  . . . . . . . . . . . . . . . . . . . . . . . . . .   366
Modulation:Analog:PM Mode  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   367
Modulation:Analog:PM Sensitivity . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   368
Modulation:Analog:Waveform Frequency (Hz) . . . . . . . . . . . . . . . . . . . . . . . .   369
Modulation:Analog:Waveform Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   369
Digital . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   370
Modulation:Digital:FSK Deviation (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   370
Modulation:Digital:Modulation Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   371
Modulation:Digital:PRBS Order . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   372
Modulation:Digital:PRBS Seed  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   373
Modulation:Digital:Symbol Rate . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   373
Modulation:Digital:Waveform Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   374
Pulse . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   375
Modulation:Pulse:Pulse Modulation Active Level . . . . . . . . . . . . . . . . . . . . . .   375
Modulation:Pulse:Pulse Modulation Enabled . . . . . . . . . . . . . . . . . . . . . . . . .   376
Modulation:Pulse:Pulse Modulation Mode  . . . . . . . . . . . . . . . . . . . . . . . . . . .   377
Modulation:Pulse:Pulse Modulation Source  . . . . . . . . . . . . . . . . . . . . . . . . . .   378
Peer-to-Peer  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   379

© National Instruments 13

NI-RFSG LabVIEW VI Reference

Peer-to-Peer:Data Transfer Permission Initial Credits . . . . . . . . . . . . . . . . . . . . . . .   379
Peer-to-Peer:Data Transfer Permission Interval . . . . . . . . . . . . . . . . . . . . . . . . . . . .   380
Peer-to-Peer:Enabled . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   381
Peer-to-Peer:Endpoint Count . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   381
Peer-to-Peer:Endpoint Size . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   382
Peer-to-Peer:Generation FIFO Sample Quantum . . . . . . . . . . . . . . . . . . . . . . . . . . .   383
Peer-to-Peer:Is Finite Generation . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   383
Peer-to-Peer:Most Space Available in Endpoint . . . . . . . . . . . . . . . . . . . . . . . . . . . .   384
Peer-to-Peer:Number Of Samples To Generate . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   385
Peer-to-Peer:Space Available In Endpoint . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   386
RF . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   386
RF:ALC Control  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   386
Advanced . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   388
RF:Advanced:Amp Path . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   388
RF:Advanced:Correction Temperature  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   389
RF:Advanced:Ref PLL Bandwidth . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   390
RF:Advanced:Thermal Correction Headroom Range (Degrees C) . . . . . . . .   391
RF:Advanced:Thermal Correction Temperature Resolution (Degrees C) . .   392
RF:Advanced:YIG Main Coil Drive  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   392
RF:Allow Out Of Specification User Settings  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   393
RF:Amplitude Settling . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   394
RF:Attenuator Hold Enabled  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   396
RF:Attenuator Hold Max Power (dBm) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   397
RF:Attenuator Setting (dB) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   398
RF:Automatic Power Search  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   399
RF:Automatic Thermal Correction . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   400
RF:External Gain (dB) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   401
RF:Frequency (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   402
RF:Frequency Settling . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   403
RF:Frequency Settling Units  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   405
RF:Frequency Tolerance (Hz) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   406
RF:LO Frequency (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   407
RF:LO In Power (dBm) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   408
RF:LO Out Enabled . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   409
RF:LO Out Export Configure From RFSA  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   410
RF:LO Out Power (dBm)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   411

14 ni.com

NI-RFSG LabVIEW VI Reference

RF:Loop Bandwidth . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   412
RF:Output Enabled  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   414
RF:Peak Envelope Power (dBm) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   415
RF:Peak Power Adjustment (dB) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   416
RF:Peak Power Adjustment Inheritance . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   417
RF:Phase Offset (Degrees)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   418
RF:Power Level (dBm) . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   418
RF:Power Level Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   420
RF:RF In LO Export Enabled . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   422
Upconverter . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   423
RF:Upconverter:Center Frequency (Hz)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   423
RF:Upconverter:Frequency Offset Mode . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   424
RF:Upconverter:Gain (dB)  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   426
Self Calibration . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   427
Self Calibration:Last Self Calibration Temperature  . . . . . . . . . . . . . . . . . . . . . . . . .   427
Triggers . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   427
Configuration List Step . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   427
Digital Edge . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   427
Triggers:Configuration List Step:Digital Edge:Edge  . . . . . . . . . . . . . . .   427
Triggers:Configuration List Step:Digital Edge:Source . . . . . . . . . . . . . .   428
Triggers:Configuration List Step:Export Output Terminal . . . . . . . . . . . . . . .   431
Triggers:Configuration List Step:Terminal Name  . . . . . . . . . . . . . . . . . . . . . .   434
Triggers:Configuration List Step:Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   435
Script . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   436
Digital Edge . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   436
Triggers:Script:Digital Edge:Edge . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   436
Triggers:Script:Digital Edge:Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   437
Digital Level . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   439
Triggers:Script:Digital Level:Active Level  . . . . . . . . . . . . . . . . . . . . . . . .   440
Triggers:Script:Digital Level:Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   440
Triggers:Script:Export Output Terminal  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   443
Triggers:Script:Terminal Name . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   446
Triggers:Script:Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   447
Start . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   448
Digital Edge . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   448
Triggers:Start:Digital Edge:Edge . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   448

© National Instruments 15

NI-RFSG LabVIEW VI Reference

Triggers:Start:Digital Edge:Source . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   449
Triggers:Start:Export Output Terminal  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   452
P2P Endpoint Fullness  . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   455
Triggers:Start:P2P Endpoint Fullness:Level . . . . . . . . . . . . . . . . . . . . . .   455
Triggers:Start:Terminal Name . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   456
Triggers:Start:Type . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .   457

16 ni.com

NI-RFSG

NI-RFSG
NI-RFSG

This help file contains technical and programming support for using the NI-RFSG
LabVIEW API. This help file provides reference material for the NI-RFSG VIs.

Use the NI-RFSG VIs to program RF signal generators using the NI-RFSG instrument
driver.

© 2004–2025 National Instruments Corporation. All rights reserved.

niRFSG Initialize VI
niRFSG Initialize VI

Opens a session to the device you specify as the resource name and returns an
instrument handle that you use to identify the NI-RFSG device in all subsequent NI-
RFSG VIs.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Instrument Driver Programming Flow

Inputs/Outputs

•

 resource name —

© National Instruments 17

NI-RFSG

resource name specifies the resource name of the device to initialize.

Note For multichannel devices such as the PXIe-5860, the resource name must
include the channel number to use. The channel number is specified by appending
/ChannelNumber to the device name, where ChannelNumber is the channel
number (0, 1, etc.). For example, if the device name is PXI1Slot2 and you want to
use channel 0, use the resource name PXI1Slot2/0.

•

 id query —

id query specifies whether NI-RFSG performs an ID query. Set this parameter to TRUE to perform
an ID query. Set this parameter to FALSE to not perform an ID query.

•

 reset device —

reset device specifies whether you want to reset the NI-RFSG device during the initialization
procedure. Set this parameter to TRUE to reset the device. Set this parameter to FALSE to not
reset the device.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle —

instrument handle passes a reference to your instrument session to the next VI. instrument
handle is obtained from this VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure RF VI
niRFSG Configure RF VI

Configures the frequency and power level of the RF output signal. The PXI-5670/5671,
PXIe-5672, and PXIe-5860 device must be in the Configuration state before you call this
VI. The PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5654/5654 with
PXIe-5696, PXIe-5673/5673E, and PXIe-5830/5831/5832/5840/5841/5842 device can be
in the Configuration state or Generation state when you call this VI.

18 ni.com

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5654/5654
with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5830/5831/5832/5840/
5841/5842/5860

NI-RFSG

Related Topics

NI-RFSG Instrument Driver Programming Flow

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 frequency (Hz) —

frequency specifies the frequency of the generated RF signal. For arbitrary waveform
generation, frequency specifies the center frequency of the signal. This value is expressed in
hertz.

•

 power level (dBm) —

power level specifies the power level of the generated RF signal. By default, this parameter
specifies the average power of the signal. To configure the power level of a waveform with
varying power, set the Power Level Type property to Peak Power. This value is expressed in dBm.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

© National Instruments 19

NI-RFSG

error out contains error information. This output provides standard error out functionality.

niRFSG Initiate VI
niRFSG Initiate VI

Initiates signal generation, causing the NI-RFSG device to leave the Configuration state
or Committed state and enter the Generation state. If settings have not been
committed to the device before you use this VI, they are committed by this VI. The
operation returns when the RF output signal settles. To return to the Configuration
state, use the niRFSG Abort VI.

Supported Devices: PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Instrument Driver Programming Flow

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

20 ni.com

•

 error out —

error out contains error information. This output provides standard error out functionality.

NI-RFSG

niRFSG Check Generation Status VI
niRFSG Check Generation Status VI

Checks the status of the generation. Use this VI to check for any errors that may occur
during signal generation or to check whether the device has finished generating.

Supported Devices: PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Instrument Driver Programming Flow

Stopping Pear-to-Peer Generation

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

© National Instruments 21

NI-RFSG

•

•

 done? —

done? returns TRUE when signal generation has completed.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Close VI
niRFSG Close VI

Aborts any signal generation in progress and destroys the instrument driver session.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Instrument Driver Programming Flow

NI-RFSG Programming State Model

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. The default is no error.
This node passes the error in input to the error out output. This node will run regardless of
whether an error occurred before it.

22 ni.com

NI-RFSG

This input contains status, code, and source, which provide standard error in functionality.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Property Node VI
niRFSG Property Node VI

Gets (reads), sets (writes), or resets (sets to default value) NI-RFSG properties. When
you read a property, NI-RFSG analyzes the current configuration in order to return the
coerced value for that property. NI-RFSG verifies many properties upon reading,
thereby either transitioning the session to the verified state or alerting you of an
invalid configuration. Setting or resetting a property transitions the session to an
unverified state.

Related Topics

niRFSG Properties—Refer to this topic for more information about using the NI-RFSG
properties.

Inputs/Outputs

•

 reference —

reference identifies your instrument session. reference is obtained from either the niRFSG
Initialize VI or the niRFSG Initialize With Options VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

© National Instruments 23

NI-RFSG

•

•

This input contains status, code, and source, which provide standard error in functionality.

 Property —

Property Node is used to get (read), set (write), or reset (set to default value) RFSG properties.

 reference out —

reference out passes a reference to your instrument session to the next VI. reference out is
obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Generation Configuration
Generation Configuration

Use the Configuration VIs to configure the signal generation.

Configure Waveform
Configure Waveform

Use the Waveform Configuration VIs to configure a waveform.

niRFSG Configure Generation Mode VI
niRFSG Configure Generation Mode VI

Configures the NI-RFSG device to generate a continuous sine tone (CW), apply I/Q
(vector) modulation to the RF output signal, or generate arbitrary waveforms
according to scripts. The NI-RFSG device must be in the Configuration state before you
call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/

24 ni.com

5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

NI-RFSG

Related Topics

Assigning Properties or Attributes to a Waveform

Scripting Instructions—Refer to this topic for information about VST restrictions on
scripts.

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 generation mode —

generation mode specifies the mode used by NI-RFSG for generating an RF output signal.

CW (default)  Configures the RF signal generator to generate a CW signal.
Arb
Waveform

Configures the RF signal generator to generate a arbitrary waveforms.

Script

Configures the RF signal generator to generate arbitrary waveforms as directed by
scripts.

Note For the PXI/PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696, only CW
generation mode is supported.

Note If you are using an RF vector signal transceiver (VST) device, some script
instructions may not be supported.

•

 error in —

© National Instruments 25

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform VI
niRFSG Write Arb Waveform VI

Writes an arbitrary waveform to the NI-RFSG device. This VI configures the I and Q
vectors of a complex baseband signal. If the waveform to write is already allocated
using the niRFSG Allocate Arb Waveform VI, the more data pending? parameter is
ignored. This VI has nine polymorphic instances that accept as data input a complex
cluster, a waveform datatype (CWDT), Complex DBL, Complex SGL, I16, and I/Q arrays.
The PXI-5670/5671 must be in the Configuration state before you call this VI. When
streaming is enabled, you can call this VI when the PXIe-5672/5673/5673E, PXIe-5820/
5830/5831/5832/5840/5841/5842/5860 is in the Generation state.

Note On the PXIe-5644/5645/5646, PXIe-5672/5673/5673E, and PXIe-5820/
5830/5831/5832/5840/5841/5842/5860, the more data pending? parameter is
always ignored. To write data in blocks on these devices, you must allocate
the waveform before writing it.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Streaming

Assigning Properties or Attributes to a Waveform

26 ni.com

NI-RFSG

niRFSG Write Arb Waveform (Complex DBL) VI
niRFSG Write Arb Waveform (Complex DBL) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the complex
baseband data in the form of complex double data type.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 waveform data —

waveform data specifies the array of data to load into the waveform. You must normalize the
data points in the array to have polar magnitudes between 0.0 and +1.00.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

© National Instruments 27

NI-RFSG

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (Complex SGL) VI
niRFSG Write Arb Waveform (Complex SGL) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the complex
baseband data in the form of complex single data type.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from

28 ni.com

NI-RFSG

either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 waveform data —

waveform data specifies the array of data to load into the waveform. You must normalize the
data points in the array to have polar magnitudes between 0.0 and +1.00.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (Complex Input) VI
niRFSG Write Arb Waveform (Complex Input) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts complex baseband
signal data in the form of a complex cluster.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

© National Instruments 29

NI-RFSG

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 IQ waveform —

IQ waveform specifies the complex baseband signal to write to the NI-RFSG device.

•

•

 t0 —

t0 specifies the trigger (start) time of the acquired Y array.

 dt —

dt specifies the time interval between the samples in the acquired Y array. dt is the
reciprocal of the I/Q rate.

•

 Y —

Y specifies an array of complex-valued time domain data. The real and imaginary parts of
this complex data array correspond to the in-phase (I) and quadrature-phase (Q) data,
respectively.

•

 use waveform dt for IQ rate? —

use waveform dt for IQ rate? specifies TRUE if the VI uses the waveform dt to configure the I/Q
rate and FALSE if it does not configure the I/Q rate.

•

 error in —

30 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (Complex Input SGL) VI
niRFSG Write Arb Waveform (Complex Input SGL) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts complex baseband
signal data in the form of a complex cluster.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

© National Instruments 31

NI-RFSG

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 IQ waveform —

IQ waveform specifies the complex baseband signal to write to the NI-RFSG device.

•

•

 t0 —

t0 specifies the trigger (start) time of the acquired Y array.

 dt —

dt specifies the time interval between the samples in the acquired Y array. dt is the
reciprocal of the I/Q rate.

•

 Y —

Y specifies an array of complex-valued time domain data. The real and imaginary parts of
this complex data array correspond to the in-phase (I) and quadrature-phase (Q) data,
respectively.

•

 use waveform dt for IQ rate? —

use waveform dt for IQ rate? specifies TRUE if the VI uses the waveform dt to configure the I/Q
rate and FALSE if it does not configure the I/Q rate.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write

32 ni.com

NI-RFSG

operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (CWDT) VI
niRFSG Write Arb Waveform (CWDT) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the complex
baseband signal data in the form of a complex waveform datatype.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 IQ Waveform —

© National Instruments 33

NI-RFSG

IQ Waveform specifies the complex waveform to write to the NI-RFSG device.

•

 use waveform dt for IQ rate? —

use waveform dt for IQ rate? specifies TRUE if the VI uses the waveform dt to configure the I/Q
rate and FALSE if it does not configure the I/Q rate.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (CWDT SGL) VI
niRFSG Write Arb Waveform (CWDT SGL) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the complex
baseband signal data in the form of a complex waveform datatype consisting of
singles.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

34 ni.com

NI-RFSG

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 IQ Waveform —

IQ Waveform specifies the complex waveform to write to the NI-RFSG device.

 use waveform dt for IQ rate? —

use waveform dt for IQ rate? specifies TRUE if the VI uses the waveform dt to configure the I/Q
rate and FALSE if it does not configure the I/Q rate.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument

© National Instruments 35

NI-RFSG

handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (I-Q) VI
niRFSG Write Arb Waveform (I-Q) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the I and Q vectors
of a complex baseband signal. To write only I Data of waveform through NI-RFSG, pass
an empty array for Q Data parameter.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 I Data —

I Data specifies the in-phase (I) component of the complex baseband signal.

 Q Data —

36 ni.com

NI-RFSG

Q Data specifies the quadrature-phase (Q) component of the complex baseband signal.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (I-Q SGL) VI
niRFSG Write Arb Waveform (I-Q SGL) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the I and Q vectors
of a complex baseband signal containing singles. To write only I Data of waveform
through NI-RFSG, pass an empty array for Q Data parameter.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

© National Instruments 37

NI-RFSG

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

•

 I Data —

I Data specifies the in-phase (I) component of the complex baseband signal.

 Q Data —

Q Data specifies the quadrature-phase (Q) component of the complex baseband signal.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 more data pending? —

more data pending? specifies whether the data block contains the end of the waveform. Set
more data pending? to TRUE to allow data to be appended to the waveform later. Splitting the
waveform into multiple data blocks can reduce the memory requirements of the write
operation. You can append data to a previously written waveform by using the saved waveform
name. Set this parameter to FALSE to indicate that this data block contains the end of the
waveform.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

38 ni.com

NI-RFSG

niRFSG Write Arb Waveform (I16) VI
niRFSG Write Arb Waveform (I16) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI accepts the interleaved I/Q
data of a complex baseband signal.

Note When using this VI, you must set the Power Level Type property to
Peak Power. If you download a waveform when using this VI, you cannot set
the Power Level Type property to Average Power without causing error in the
output.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 interleaved IQ Data —

interleaved IQ Data specifies an array of interleaved I data and Q data to load into the waveform,
paired in binary (I16) format.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

© National Instruments 39

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write Arb Waveform (Direct DMA) VI
niRFSG Write Arb Waveform (Direct DMA) VI

Writes an arbitrary waveform to the NI-RFSG device. This VI inputs the I and Q vectors
of a complex baseband signal. The NI-RFSG device must be in the Configuration state
before calling this VI.

Related Topics

Streaming

Assigning Properties or Attributes to a Waveform

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This is a case-insensitive alphanumeric
string that does not use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 direct DMA address —

 samples to write —

40 ni.com

NI-RFSG

•

 error in —

error in can accept error information wired from VIs previously called. The pop-up option Explain
Error (or Explain Warning) gives more information about the error displayed.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out passes error or warning information out of a VI to be used by other VIs. The pop-up
option Explain Error (or Explain Warning) gives more information about the error displayed.

niRFSG Write Script VI
niRFSG Write Script VI

Writes a script to the device to control waveform generation in Script mode. First,
configure your device for Script mode by calling the niRFSG Configure Generation
Mode VI. The NI-RFSG device must be in the Configuration state before calling the
niRFSG Write Script VI.

Note If you are using an RF vector signal transceiver (VST) device, some
script instructions may not be supported.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Scripting Instructions—Refer to this topic for information about VST restrictions on
scripts.

Common Scripting Use Cases

© National Instruments 41

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 script —

script specifies the script that controls waveform generation. NI-RFSG supports multiple scripts
that are selected with the Selected Script property. Refer to Scripting Instructions for more
information about using scripts.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Check If Waveform Exists VI
niRFSG Check If Waveform Exists VI

Returns whether the waveform that you specify as waveform name exists.

Supported Devices: PXIe-5673/5673E, PXIe-5830/5831/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

42 ni.com

NI-RFSG

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 waveform name —

waveform name specifies the name used to store the waveform. This string is case-insensitive.

Example:

"waveform::waveform0"

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 waveform exists? —

waveform exists? returns TRUE if the waveform exists.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Check If Script Exists VI
niRFSG Check If Script Exists VI

Returns whether the script that you specify as script name exists.

Supported Devices: PXIe-5673/5673E, PXIe-5830/5831/5840/5841/5842/5860

© National Instruments 43

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 script name —

script name specifies the name of the script. This string is case-insensitive.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 script exists? —

script exists? returns TRUE if the script exists.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Read and Download Waveform From File (TDMS) VI
niRFSG Read and Download Waveform From File (TDMS) VI

Reads the waveforms from a TDMS file and downloads one waveform into each of the
NI RF vector signal generators.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

44 ni.com

Inputs/Outputs

•

 waveform name —

waveform name specifies the name used to store the waveform. This string is case-insensitive.

NI-RFSG

Example:

"waveform::waveform0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 file path —

file path specifies the absolute path to the TDMS file from which the NI-RFSG reads the
waveforms.

 waveform index —

waveform index specifies the index of the waveform to be read from the TDMS file.

 error in —

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

This VI reads the following information from the TDMS file and writes it into the NI-
RFSG session:

© National Instruments 45

NI-RFSG

•  Sample Rate
•  PAPR
•  Runtime Scaling
•  RF Blanking Marker Locations
•  RF Blanking Enabled
•  Burst Start Locations
•  Burst Stop Locations
•  RF Blanking Marker Source
•  Signal Bandwidth
•  Waveform Size

If RF blanking marker locations are present in the file but burst locations are not
present, burst locations are calculated from RF blanking marker locations and stored
in the NI-RFSG session.

niRFSG Clear Arb Waveform VI
niRFSG Clear Arb Waveform VI

Deletes a specified waveform from the pool of currently defined waveforms. The NI-
RFSG device must be in the Configuration state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 error in —

46 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Clear All Arb Waveforms VI
niRFSG Clear All Arb Waveforms VI

Deletes all currently defined waveforms and scripts. The NI-RFSG device must be in the
Configuration state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

© National Instruments 47

•

 error out —

error out contains error information. This output provides standard error out functionality.

NI-RFSG

niRFSG Configure Digital Modulation User Defined Waveform VI
niRFSG Configure Digital Modulation User Defined Waveform VI

Specifies the message signal used for digital modulation when the Modulation Type
property is enabled and the Waveform Type property is set to User-defined.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 user defined waveform —

user defined waveform specifies the user-defined message signal used for digital modulation.

 error in —

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

48 ni.com

NI-RFSG

rfsg_Resample and Write VI
rfsg_Resample and Write VI

Resamples the complex waveform to the new I/Q rate and writes it to the NI-RFSG
device. This VI preserves the phase continuity of a phase-continuous complex
waveform while resampling.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842

rfsg_Resample and Write (Complex Input) VI
rfsg_Resample and Write (Complex Input) VI

Resamples the complex waveform to the new I/Q rate and writes it to NI-RFSG. Given a
phase continuous complex waveform, this VI preserves the phase continuity while
resampling. This VI also optimizes memory usage by resampling and writing in blocks
of 100k samples and by deallocating unused memory after the VI executes.

Inputs/Outputs

•

 waveform name —

waveform name specifies the name used to store the waveform. This string is case-insensitive.

Example:

"waveform::waveform0"

•

 new IQ rate (S/s) —

new IQ rate specifies the new I/Q rate at which to resample.

© National Instruments 49

•

 instrument handle in —

instrument handle in identifies your instrument session. instrument handle in is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

NI-RFSG

•

 complex waveform —

complex waveform specifies the complex waveform to resample.

•

•

•

 t0 —

t0 specifies the trigger (start) time of the acquired Y array.

 dt —

dt specifies the time between values in the Y array. Default Value: 1.0

 Y —

Y specifies the complex-valued signal-only baseband modulated waveform. The real and
imaginary parts of this complex data array correspond to the in-phase (I) and quadrature-
phase (Q) data, respectively.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 repeat waveform until tolerance met —

repeat waveform until tolerance met allows the resampled waveform to contain multiple
copies of the original waveform. This parameter increases the size of the resampled waveform
and reduces the I/Q rate error introduced when the resample waveform size is coerced to a
multiple of the quantum.

•

 IQ rate tolerance (ppm) —

IQ rate tolerance specifies how much to limit the adjusted I/Q rate over the original I/Q rate, in
parts per million.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument

50 ni.com

NI-RFSG

handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 adjusted IQ rate / original IQ rate —

adjusted IQ rate / original IQ rate indicates how much the frequency content or the symbol rate
of the original waveform changed. Before resampling the waveform, the original waveform I/Q
rate is adjusted so that the resampled waveform size is a multiple of the quantum.

The resampled waveform I/Q rate is calculated with the following equation:

Resampled Waveform I/Q Rate = (Adjusted I/Q Rate / Original I/Q Rate) * Original Symbol Rate

•

 error out —

error out contains error information. This output provides standard error out functionality.

rfsg_Resample and Write (CWDT) VI
rfsg_Resample and Write (CWDT) VI

Resamples the complex waveform to the new I/Q rate and writes it to NI-RFSG. Given a
phase continuous complex waveform, this VI preserves the phase continuity while
resampling. This VI also optimizes memory usage by resampling and writing in blocks
of 100 k samples and by deallocating unused memory after the VI executes.

Inputs/Outputs

•

 waveform name —

waveform name specifies the name used to store the waveform. This string is case-insensitive.

Example:

"waveform::waveform0"

© National Instruments 51

NI-RFSG

•

•

•

•

 new IQ rate (S/s) —

new IQ rate specifies the new I/Q rate at which to resample.

 instrument handle in —

instrument handle in identifies your instrument session. instrument handle in is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 complex waveform —

complex waveform specifies the complex waveform to split into I and Q components.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 repeat waveform until tolerance met —

repeat waveform until tolerance met allows the resampled waveform to contain multiple
copies of the original waveform. This parameter increases the size of the resampled waveform
and reduces the I/Q rate error introduced when the resample waveform size is coerced to a
multiple of the quantum.

•

 IQ rate tolerance (ppm) —

IQ rate tolerance specifies how much to limit the adjusted I/Q rate over the original I/Q rate, in
parts per million.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 adjusted IQ rate / original IQ rate —

adjusted IQ rate / original IQ rate indicates how much the frequency content or the symbol rate
of the original waveform changed. Before resampling the waveform, the original waveform I/Q
rate is adjusted so that the resampled waveform size is a multiple of the quantum.

The resampled waveform I/Q rate is calculated with the following equation:

Resampled Waveform I/Q Rate = (Adjusted I/Q Rate / Original I/Q Rate) * Original Symbol Rate

52 ni.com

•

 error out —

error out contains error information. This output provides standard error out functionality.

NI-RFSG

rfsg_Resample and Write (I-Q) VI
rfsg_Resample and Write (I-Q) VI

Resamples the complex waveform to the new I/Q rate and writes it to the NI-RFSG.
Given a phase continuous complex waveform, this VI preserves the phase continuity
while resampling. This VI also optimizes memory usage by resampling and writing in
blocks of 100 k samples and by deallocating unused memory after the VI executes.

Inputs/Outputs

•

 waveform name —

waveform name specifies the name used to store the waveform. This string is case-insensitive.

Example:

"waveform::waveform0"

 new IQ rate (S/s) —

new IQ rate specifies the new I/Q rate at which to resample.

 instrument handle in —

•

•

instrument handle in identifies your instrument session. instrument handle in is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 I —

© National Instruments 53

NI-RFSG

I specifies the in-phase (I) component of the complex baseband signal.

 Q —

Q specifies the quadrature-phase (Q) component of the complex baseband signal.

 input IQ rate —

input IQ rate specifies the I/Q rate of the input waveform.

 error in —

•

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 repeat waveform until tolerance met —

repeat waveform until tolerance met allows the resampled waveform to contain multiple
copies of the original waveform. This parameter increases the size of the resampled waveform
and reduces the I/Q rate error introduced when the resample waveform size is coerced to a
multiple of the quantum.

•

 IQ rate tolerance (ppm) —

IQ rate tolerance specifies how much to limit the adjusted I/Q rate over the original I/Q rate, in
parts per million.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 adjusted IQ rate / original IQ rate —

adjusted IQ rate / original IQ rate indicates how much the frequency content or the symbol rate
of the original waveform changed. Before resampling the waveform, the original waveform I/Q
rate is adjusted so that the resampled waveform size is a multiple of the quantum.

The resampled waveform I/Q rate is calculated with the following equation:

Resampled Waveform I/Q Rate = (Adjusted I/Q Rate / Original I/Q Rate) * Original Symbol Rate

•

 error out —

54 ni.com

NI-RFSG

error out contains error information. This output provides standard error out functionality.

niRFSG Fractional Resampling VI
niRFSG Fractional Resampling VI

Resamples and/or realigns a complex-valued waveform that you specify. This VI has
three polymorphic instances, which accept as data input a complex cluster, a complex
waveform, or an I/Q array.

Details

To resample a waveform, enter a desired sample rate that differs from the existing
sample rate of input complex waveform. To realign a waveform without changing the
sample rate, specify a desired sample rate equal to the existing sample rate. To
resample a waveform without changing the relative timing offset between the input
and output complex waveforms, specify an initial sample offset of 0.

Note The sample rate of your waveform corresponds to the IQ Rate (S/s)
property in NI-RFSG.

Resampling and Phase Continuity

Resampling can disturb phase continuity. For example, if a sine wave sampled at four
samples per cycle in a four-sample long phase-continuous array, is resampled at a rate
of 4.5 samples per cycle, the resulting five samples are no longer phase-continuous.
Phase continuity is preserved only if an integer number of samples in the original array
becomes an integer number of samples in the resampled array. The following figure
shows a four-sample waveform resampled to 4.5 samples. The rate change should
produce 4.5 samples, but the resampler can return only an integer number of samples.

© National Instruments 55

NI-RFSG

Address this issue by repeating the original array. If you copy and concatenate the
original array, the new phase-continuous array contains eight samples. The frequency
content of the new array is exactly the same as the frequency content of the original
array. If you perform resampling from 4 samples per cycle to 4.5 samples per cycle, the
eight samples become nine samples. Because nine is an integer, phase continuity is
preserved. The Resample and Write example for NI-RFSG shows this strategy. The
following figure shows both sample rates phase-continuous on two waveform cycles.

Note You can use the rfsg_Resample and Write VI to ensure that the signal's
phase continuity is maintained while resampling.

niRFSG Fractional Resampling (Complex Input) VI
niRFSG Fractional Resampling (Complex Input) VI

Inputs a complex-valued waveform and resamples and/or realigns it based on the
input parameters that you specify. To realign the input waveform in time, enter a
nonzero value in initial sample offset. Positive or negative offset values push the
output complex waveform forward or backward in time, respectively, relative to the
input complex waveform.

56 ni.com

NI-RFSG

Inputs/Outputs

•

 initial sample offset (sec) —

initial sample offset specifies the initial sample offset, in seconds. This positive value specifies
the location in time of the first output point relative to the first input point. The default is 0.00.

•

 desired sample rate (Hz) —

desired sample rate specifies the desired sample rate, in hertz, of the output complex waveform
data. This value can be an integer or a non-integer multiple of the input data sample rate. The
default value is 100 MHz.

•

 input complex waveform —

input complex waveform specifies the complex baseband waveform data.

•

•

 t0 —

t0 specifies the trigger (start) time of the acquired Y array.

 dt —

dt specifies the time interval between the samples in the acquired Y array. dt is the
reciprocal of the I/Q rate.

•

 Y —

Y specifies the complex-valued signal-only baseband modulated waveform. The real and
imaginary parts of this complex data array correspond to the in-phase (I) and quadrature-
phase (Q) data, respectively.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 reset? (T) —

© National Instruments 57

NI-RFSG

reset? specifies whether this VI continues resampling using the previous iteration states. reset?
must be set to TRUE (default) whenever you want to restart fractional resampling.

•

 output complex waveform —

output complex waveform returns the resampled complex baseband waveform data.

•

•

•

 t0 —

t0 returns the time of the first value in the Y array.

 dt —

dt returns the time between values in the Y array. dt is the reciprocal of the I/Q rate.

 Y —

Y outputs the complex-valued signal-only baseband modulated waveform. The real and
imaginary parts of this complex data array correspond to the in-phase (I) and quadrature-
phase (Q) data, respectively.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

To resample a waveform, enter a desired sample rate that differs from the existing
sample rate of input complex waveform. To realign a waveform without changing the
sample rate, specify a desired sample rate equal to the existing sample rate. To
resample a waveform without changing the relative timing offset between the input
and output complex waveforms, specify an initial sample offset of 0.

Note The sample rate of your waveform corresponds to the IQ Rate (S/s)
property in NI-RFSG.

Resampling and Phase Continuity

58 ni.com

NI-RFSG

Resampling can disturb phase continuity. For example, if a sine wave sampled at four
samples per cycle in a four-sample long phase-continuous array, is resampled at a rate
of 4.5 samples per cycle, the resulting five samples are no longer phase-continuous.
Phase continuity is preserved only if an integer number of samples in the original array
becomes an integer number of samples in the resampled array. The following figure
shows a four-sample waveform resampled to 4.5 samples. The rate change should
produce 4.5 samples, but the resampler can return only an integer number of samples.

Address this issue by repeating the original array. If you copy and concatenate the
original array, the new phase-continuous array contains eight samples. The frequency
content of the new array is exactly the same as the frequency content of the original
array. If you perform resampling from 4 samples per cycle to 4.5 samples per cycle, the
eight samples become nine samples. Because nine is an integer, phase continuity is
preserved. The Resample and Write example for NI-RFSG shows this strategy. The
following figure shows both sample rates phase-continuous on two waveform cycles.

Note You can use the rfsg_Resample and Write VI to ensure that the signal's
phase continuity is maintained while resampling.

© National Instruments 59

NI-RFSG

niRFSG Fractional Resampling (CWDT) VI
niRFSG Fractional Resampling (CWDT) VI

Inputs a complex-valued waveform and resamples and/or realigns it based on the
input parameters that you specify. To realign the input waveform in time, enter a
nonzero value in initial sample offset. Positive or negative offset values push the
output complex waveform forward or backwards in time, respectively, relative to input
complex waveform.

Inputs/Outputs

•

 initial sample offset (sec) —

initial sample offset specifies the initial sample offset, in seconds. This positive value specifies
the location in time of the first output point relative to the first input point. The default is 0.00.

•

 desired sample rate (Hz) —

desired sample rate specifies the desired sample rate, in hertz, of the output complex waveform
data. This value can be an integer or a non-integer multiple of the input data sample rate. The
default value is 100 MHz.

•

•

 input complex waveform —

input complex waveform specifies the complex baseband waveform data.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 reset? (T) —

reset? specifies whether this VI continues resampling using the previous iteration states. reset?
must be set to TRUE (default) whenever you want to restart fractional resampling.

•

 output complex waveform —

60 ni.com

NI-RFSG

output complex waveform returns the resampled complex baseband waveform data.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

To resample a waveform, enter a desired sample rate that differs from the existing
sample rate of input complex waveform. To realign a waveform without changing the
sample rate, specify a desired sample rate equal to the existing sample rate. To
resample a waveform without changing the relative timing offset between the input
and output complex waveforms, specify an initial sample offset of 0.

Note The sample rate of your waveform corresponds to the IQ Rate (S/s)
property in NI-RFSG.

Resampling and Phase Continuity

Resampling can disturb phase continuity. For example, if a sine wave sampled at four
samples per cycle in a four-sample long phase-continuous array, is resampled at a rate
of 4.5 samples per cycle, the resulting five samples are no longer phase-continuous.
Phase continuity is preserved only if an integer number of samples in the original array
becomes an integer number of samples in the resampled array. The following figure
shows a four-sample waveform resampled to 4.5 samples. The rate change should
produce 4.5 samples, but the resampler can return only an integer number of samples.

Address this issue by repeating the original array. If you copy and concatenate the

© National Instruments 61

NI-RFSG

original array, the new phase-continuous array contains eight samples. The frequency
content of the new array is exactly the same as the frequency content of the original
array. If you perform resampling from 4 samples per cycle to 4.5 samples per cycle, the
eight samples become nine samples. Because nine is an integer, phase continuity is
preserved. The Resample and Write example for NI-RFSG shows this strategy. The
following figure shows both sample rates phase-continuous on two waveform cycles.

Note You can use the rfsg_Resample and Write VI to ensure that the signal's
phase continuity is maintained while resampling.

niRFSG Fractional Resampling (I-Q) VI
niRFSG Fractional Resampling (I-Q) VI

Accepts a complex-valued waveform and resamples and/or realigns it based on the
input parameters that you specify. To realign the input waveform in time, enter a
nonzero value in initial sample offset.

Inputs/Outputs

•

 initial sample offset (sec) —

initial sample offset specifies the initial sample offset, in seconds. This positive value specifies
the location in time of the first output point relative to the first input point. The default is 0.00.

62 ni.com

NI-RFSG

•

 desired sample rate (Hz) —

desired sample rate specifies the desired sample rate, in hertz, of the output complex waveform
data. This value can be an integer or a non-integer multiple of the input data sample rate. The
default value is 100 MHz.

•

•

•

•

 I —

I specifies the in-phase (I) component of the complex baseband signal.

 Q —

Q specifies the quadrature-phase (Q) component of the complex baseband signal.

 input sample rate —

input sample rate specifies the sample rate of the input data. This value is expressed in hertz.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 reset? (T) —

reset? specifies whether this VI continues resampling using the previous iteration states. reset?
must be set to TRUE (default) whenever you want to restart fractional resampling.

•

•

•

 I out —

I out returns the resampled complex baseband in-phase (I) data.

 Q out —

Q out returns the resampled complex baseband quadrature-phase (Q) data.

 error out —

error out contains error information. This output provides standard error out functionality.

Details

To resample a waveform, enter a desired sample rate that differs from the existing

© National Instruments 63

NI-RFSG

sample rate of input complex waveform. To realign a waveform without changing the
sample rate, specify a desired sample rate equal to the existing sample rate. To
resample a waveform without changing the relative timing offset between the input
and output complex waveforms, specify an initial sample offset of 0.

Note The sample rate of your waveform corresponds to the IQ Rate (S/s)
property in NI-RFSG.

Resampling and Phase Continuity

Resampling can disturb phase continuity. For example, if a sine wave sampled at four
samples per cycle in a four-sample long phase-continuous array, is resampled at a rate
of 4.5 samples per cycle, the resulting five samples are no longer phase-continuous.
Phase continuity is preserved only if an integer number of samples in the original array
becomes an integer number of samples in the resampled array. The following figure
shows a four-sample waveform resampled to 4.5 samples. The rate change should
produce 4.5 samples, but the resampler can return only an integer number of samples.

Address this issue by repeating the original array. If you copy and concatenate the
original array, the new phase-continuous array contains eight samples. The frequency
content of the new array is exactly the same as the frequency content of the original
array. If you perform resampling from 4 samples per cycle to 4.5 samples per cycle, the
eight samples become nine samples. Because nine is an integer, phase continuity is
preserved. The Resample and Write example for NI-RFSG shows this strategy. The
following figure shows both sample rates phase-continuous on two waveform cycles.

64 ni.com

NI-RFSG

Note You can use the rfsg_Resample and Write VI to ensure that the signal's
phase continuity is maintained while resampling.

niRFSG Select Arb Waveform VI
niRFSG Select Arb Waveform VI

Specifies the waveform that is generated upon a call to the niRFSG Initiate VI when the
generation mode input of the niRFSG Configure Generation Mode VI is set to Arb
Waveform. You must specify a waveform name in the name input if you have written
multiple waveforms. The NI-RFSG device must be in the Configuration state before you
call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Assigning Properties or Attributes to a Waveform

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 name —

© National Instruments 65

NI-RFSG

name specifies the name of the stored waveform to generate. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Signal Bandwidth VI
niRFSG Configure Signal Bandwidth VI

Configures the signal bandwidth of the arbitrary waveform. The NI-RFSG device must
be in the Configuration state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 signal bandwidth (Hz) —

signal bandwidth specifies the signal bandwidth used by NI-RFSG for generating an RF output

66 ni.com

NI-RFSG

signal. NI-RFSG sets the Signal Bandwidth (Hz) property to this value.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

NI-RFSG defines signal bandwidth as twice the maximum baseband signal deviation
from 0 Hz. Usually, the baseband signal center frequency is 0 Hz. In such cases, the
signal bandwidth is simply the baseband signal's minimum frequency subtracted from
its maximum frequency, or f max - f min. NI-RFSG uses this value to optimally configure
the center frequency of the upconverter to help minimize phase noise. The generated
signal is not filtered to achieve the set bandwidth. However, specifying a bandwidth
smaller than the actual bandwidth of the signal could potentially result in spectral
distortion.

Note Based on your signal bandwidth, NI-RFSG may configure the
upconverter center frequency on the PXI-5670/5671 or PXIe-5672 in
increments of 1 MHz or 5 MHz. Failure to configure signal bandwidth may
result in the signal being placed outside the upconverter passband.

niRFSG Set Arb Waveform Next Write Position VI
niRFSG Set Arb Waveform Next Write Position VI

Configures the start position to use for writing a waveform before calling the niRFSG
Write Arb Waveform VI. This VI allows you to write to arbitrary locations within the
waveform. These settings apply only to the next write to the waveform specified by the

© National Instruments 67

NI-RFSG

name input of the niRFSG Allocate Arb Waveform VI or niRFSG Write Arb Waveform VI.
Subsequent writes to that waveform begin where the last write ended, unless this VI is
called again.

Note If you use this VI to write the waveform that is currently generating, an
undefined output may result.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Inputs/Outputs

•

 name —

name specifies the name of the waveform. This string is case-insensitive and alphanumeric, and
it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 relative to —

relative to specifies the reference position in the waveform. The position and offset together
determine where to start loading data into the waveform.

Start of Waveform
Current Position

The reference position is relative to the start of the waveform.
The reference position is relative to the current position.

•

 offset —

offset specifies the offset from the relative to parameter at which to start loading the data into
the waveform.

68 ni.com

NI-RFSG

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Power Level Type VI
niRFSG Configure Power Level Type VI

Specifies the way the driver interprets the value of the Power Level (dBm) property. In
average power mode, NI-RFSG automatically scales waveform data to use the
maximum dynamic range. In peak power mode, waveforms are scaled according to the
Software Scaling Factor property.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Spurious Performance

Optimizing for Low Power Generation

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from

© National Instruments 69

NI-RFSG

either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 power level type —

power level type specifies the way the driver interprets the value of the Power Level (dBm)
property. NI-RFSG sets the Power Level Type property to this value.

Average
Power
(default)

Peak
Power

Indicates the desired power averaged in time. The driver maximizes the dynamic range
by scaling the I/Q waveform so that its peak magnitude is equal to one. If your write
more than one waveform, NI-RFSG scales each waveform without preserving the power
level ratio between the waveforms. This value is not valid for the PXIe-5820.
Indicates the maximum power level of the RF signal averaged over one period of the RF
carrier frequency (the peak envelope power). This setting requires the magnitude of the
I/Q waveform be less than or equal to one. When using peak power, the power level of
the RF signal matches the specified power level at moments when the magnitude of the
I/Q waveform equals one. If you write more than one waveform, the relative scaling
between waveforms is preserved. In peak power mode, waveforms are scaled
according to the Software Scaling Factor property.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Allocate Arb Waveform VI
niRFSG Allocate Arb Waveform VI

Allocates onboard memory space for the arbitrary waveform. Use this VI to specify the
total size of a waveform before writing the data. Use this VI only if you are calling the
niRFSG Write Arb Waveform VI multiple times to write a large waveform in smaller
blocks. The NI-RFSG device must be in the Configuration state before you call the
niRFSG Allocate Arb Waveform VI.

70 ni.com

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

NI-RFSG

Related Topics

Streaming Waveform Data

Inputs/Outputs

•

 name —

name specifies the name used to store the waveform. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 size in samples —

size in samples specifies the size of the waveform to allocate in samples. Each I/Q pair is
considered one sample.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

© National Instruments 71

Burst Location
Burst Location

Use the waveform burst VIs on this palette to configure NI-RFSG waveform burst
locations.

NI-RFSG

niRFSG Set Waveform Burst Start Locations VI
niRFSG Set Waveform Burst Start Locations VI

Configures the start location of the burst in samples where the burst refers to the
active portion of a waveform.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 locations —

locations specifies the burst start locations, in samples, to store in the NI-RFSG session.

 error in —

•

•

72 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Set Waveform Burst Stop Locations VI
niRFSG Set Waveform Burst Stop Locations VI

Configures the stop location of the burst in samples where the burst refers to the
active portion of a waveform.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 locations —

© National Instruments 73

NI-RFSG

locations specifies the burst stop locations, in samples, to store in the NI-RFSG session.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Waveform Burst Start Locations VI
niRFSG Get Waveform Burst Start Locations VI

Returns the burst start locations of the waveform stored in the NI-RFSG session.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from

74 ni.com

NI-RFSG

either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 locations —

locations returns the burst start locations stored in the NI-RFSG session for the waveform you
specified in the channel name parameter. This value is expressed in samples.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Waveform Burst Stop Locations VI
niRFSG Get Waveform Burst Stop Locations VI

Returns the burst stop locations of the waveforms stored in the NI-RFSG session.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

© National Instruments 75

NI-RFSG

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 locations —

locations returns the burst stop locations stored in the NI-RFSG session for the waveform you
specified in the channel name parameter. This value is expressed in samples.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Marker Event
Marker Event

Use the marker VIs on this palette to configure NI-RFSG marker events.

niRFSG Set Waveform Marker Event Locations VI
niRFSG Set Waveform Marker Event Locations VI

Configures the marker locations associated with waveform and marker in the NI-RFSG
session.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

76 ni.com

NI-RFSG

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 locations —

locations specifies the marker location, in samples, to store in the NI-RFSG session.

 error in —

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Waveform Marker Event Locations VI
niRFSG Get Waveform Marker Event Locations VI

Returns the marker locations associated with the waveform and the marker stored in
the NI-RFSG session.

© National Instruments 77

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

NI-RFSG

Inputs/Outputs

•

 channel name —

channel name specifies the waveform name and the marker name.

Example:

"waveform::waveform0/marker0"

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 locations —

locations returns the marker locations stored in the NI-RFSG session for the channel you
specified in the channel name parameter. This value is expressed in samples.

•

 error out —

error out contains error information. This output provides standard error out functionality.

78 ni.com

niRFSG Get All Named Waveform Names VI
niRFSG Get All Named Waveform Names VI

Returns an array of strings containing the names of waveforms present in memory.

Supported Devices:PXIe-5830/5831/5840/5841/5842

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 waveform names —

waveform names returns an array of strings having waveform names.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get All Script Names VI
niRFSG Get All Script Names VI

Returns an array of strings containing the names of scripts present in memory.

Supported Devices:PXIe-5830/5831/5840/5841/5842

© National Instruments 79

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 script names —

script names returns an array of strings having script names.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Script VI
niRFSG Get Script VI

Returns the content of specified script.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Scripting Instructions

Common Scripting Use Cases

80 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 script name —

script name specifies the name of the script. This string is case-insensitive.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 script —

script returns the script.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Delete Script VI
niRFSG Delete Script VI

Deletes a specified script from the pool of currently defined scripts. The NI-RFSG
device must be in the Configuration state before you call this VI.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

© National Instruments 81

NI-RFSG

Scripting Instructions

Common Scripting Use Cases

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 script name —

script name specifies the name of the script to delete. This string is case-insensitive.

 error in —

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Configuration List
Configuration List

Use the configuration list VIs to use RF list mode.

82 ni.com

NI-RFSG

niRFSG Create Configuration List VI
niRFSG Create Configuration List VI

Creates an empty configuration list. Use the Active Configuration List property to
enable a configuration list created by this VI. Call the niRFSG Create Configuration List
Step VI to add steps to the configuration list.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652/5653/5654/5654 with
PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860, PXIe-5842
with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860 with S-
parameters

Related Topics

RF List Mode

Using RF List Mode

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from either the niRFSG Initializ
With Options VI.

•

 list name —

list name specifies the name of the configuration list. This string is case-insensitive and alphanumeric, and it c
reserved words.

•

 configuration list properties —

configuration list properties specifies the properties that you intend to change between configuration list steps. Calling the
Configuration List VI allocates space for each of the configuration list properties. When you use the niRFSG Property Node t
configuration list properties, that property is set as one of the configuration list steps. Use the Active Configur

© National Instruments 83

which configuration list step to configure.

You can include the following properties in your configuration list based on your device:

NI-RFSG

Property

PXIe-5644/
5646

PXIe-5645

PXIe-5650/
5651/5652

PXIe-5653 PXIe-5654

PXIe-5673E PXIe-5820

PXIe-5830/
5831/5832

PXIe-5654
with
PXIe-5696

ALC Control
Amp Path
Amplitude
Settling
Attenuator
Setting (dB)
Automatic
Power
Search
Digital Gain
(dB)
External
Gain
Frequency
(Hz)
Frequency
Settling
IQ Out Port
Carrier
Frequency
IQ Out Port
Common
Mode Offset
IQ Out Port

✓

✓

✓

✓

✓

✓

✓

84 ni.com

✓
✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

NI-RFSG

Property

PXIe-5644/
5646

PXIe-5645

PXIe-5650/
5651/5652

PXIe-5653 PXIe-5654

PXIe-5673E PXIe-5820

PXIe-5830/
5831/5832

PXIe-5654
with
PXIe-5696

Level
IQ Out Port
Offset
LO Source
Output
Enabled
Phase
Offset
(Degrees)
Power Level
(dBm)
Pre-filter
Gain (dB)
Pulse
Modulation
Enabled
RF In LO
Export
Enabled
Selected
Ports
Signal
Bandwidth
(Hz)
Timer Event
Interval (s)
Upconverter
Center

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

✓

© National Instruments 85

NI-RFSG

PXIe-5653 PXIe-5654

PXIe-5673E PXIe-5820

PXIe-5830/
5831/5832

PXIe-5654
with
PXIe-5696

Property

PXIe-5644/
5646

PXIe-5645

PXIe-5650/
5651/5652

Frequency
(Hz)
Upconverter
Frequency
Offset (Hz)
Upconverter
Frequency
Offset Mode

•

 set as active list —

•

•

set as active list sets this list as the active configuration list when this parameter is enabled. NI recommends tha
when creating the list.

 error in —

error in describes error conditions that occur before this node runs. This input provides standard error in func

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument handle out is ob
Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

86 ni.com

NI-RFSG

niRFSG Create Configuration List Step VI
niRFSG Create Configuration List Step VI

Creates a new configuration list step in the configuration list specified by the Active
Configuration List property. When you create a configuration list step, a new instance
of each property specified by the configuration list properties is created. Configuration
list properties are specified when a configuration list is created. The new instance of a
property can be accessed with a property node using the Active Configuration List and
Active Configuration List Step properties to index the desired instance of the property.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Related Topics

RF List Mode

Using RF List Mode

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 set as active step —

set as active step sets this step as the Active Configuration List Step property for the list
specified by the Active Configuration List property. The default value is TRUE. NI recommends
that you keep this parameter set to TRUE when creating the list steps.

•

 error in —

© National Instruments 87

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Delete Configuration List VI
niRFSG Delete Configuration List VI

Deletes a previously created configuration list and all the configuration list steps in the
configuration list. When a configuration list step is deleted, all the instances of the
properties associated with the configuration list step are also removed. When you
delete the active configuration list, NI-RFSG automatically resets the Active
Configuration List property to "" (empty string), which indicates no list is active, and
the Active Configuration List Step property to 0.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Related Topics

RF List Mode

Inputs/Outputs

•

 instrument handle —

88 ni.com

NI-RFSG

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 list name —

list name specifies the name of the configuration list. This string is case-insensitive and
alphanumeric, and it cannot contain spaces or use reserved words.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Check If Configuration List Exists VI
niRFSG Check If Configuration List Exists VI

Returns whether the configuration list that you specify as list name exists.

Supported Devices: PXI/PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696,
PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

RF List Mode

Inputs/Outputs

•

 instrument handle —

© National Instruments 89

NI-RFSG

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 list name —

list name specifies the name of the configuration list. This string is case-insensitive.

 error in —

•

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 list exists? —

list exists? returns TRUE if the configuration list exists.

 error out —

error out contains error information. This output provides standard error out functionality.

Configure Trigger
Configure Trigger

Use the Trigger Configuration VIs to configure NI-RFSG triggers.

niRFSG Configure Trigger VI
niRFSG Configure Trigger VI

Configures the Start Triggers and Script Triggers. The NI-RFSG device must be in the
Configuration state before you call this VI. This polymorphic VI has ten instances.

Related Topics

90 ni.com

Triggers

Trigger Types

RF List Mode

NI-RFSG

niRFSG Configure Start Trigger Digital Edge VI
niRFSG Configure Start Trigger Digital Edge VI

Configures the Start Trigger for digital edge triggering.

Note For the PXIe-5654/5654 with PXIe-5696, the Start Trigger is valid only
with a timer-based list when RF list mode is enabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 source —

source specifies the trigger source terminal for the digital edge Start Trigger. NI-RFSG sets the
Digital Edge Start Trigger Source property to this value. Refer to this property for possible values.

•

 edge —

edge specifies the active edge for the digital edge Start Trigger. NI-RFSG sets the Digital Edge

© National Instruments 91

NI-RFSG

Start Trigger Edge property to this value.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Start Trigger Software VI
niRFSG Configure Start Trigger Software VI

Configures the Start Trigger for software triggering. Refer to the niRFSG Send Software
Edge Trigger VI for more information about using a software trigger.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

92 ni.com

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Disable Start Trigger VI
niRFSG Disable Start Trigger VI

Configures the device not to wait for a Start Trigger. This VI is necessary only if you
previously configured a Start Trigger and now want it disabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

© National Instruments 93

NI-RFSG

niRFSG Configure Script Trigger Digital Edge VI
niRFSG Configure Script Trigger Digital Edge VI

Configures a specified Script Trigger for digital edge triggering.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

•

 trigger id —

trigger id specifies the Script Trigger to configure.

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 source —

source specifies the trigger source terminal for the digital edge Script Trigger. NI-RFSG sets the
Digital Edge Script Trigger Source property to this value. Refer to this property for possible
values.

•

 edge —

edge specifies the active edge for the digital edge Script Trigger. NI-RFSG sets the Digital Edge
Script Trigger Edge property to this value.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument

94 ni.com

NI-RFSG

handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Script Trigger Digital Level VI
niRFSG Configure Script Trigger Digital Level VI

Configures a specified Script Trigger for digital level triggering.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

•

 trigger id —

trigger id specifies the Script Trigger to configure.

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 source —

source specifies the trigger source terminal for the digital level Script Trigger. NI-RFSG sets the
Digital Level Script Trigger Source property to this value. Refer to this property for possible
values.

•

 level —

level specifies the active level for the digital level Script Trigger. NI-RFSG sets the Digital Level
Script Trigger Active Level property to this value. Refer to this property for possible values.

© National Instruments 95

NI-RFSG

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Script Trigger Software VI
niRFSG Configure Script Trigger Software VI

Configures a specified Script Trigger for software triggering.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

•

 trigger id —

trigger id specifies the Script Trigger to configure.

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

96 ni.com

NI-RFSG

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Disable Script Trigger VI
niRFSG Disable Script Trigger VI

Configures the device not to wait for the specified Script Trigger. Call this VI only if you
previously configured a Script Trigger and now want it disabled.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

•

 trigger id —

trigger id specifies the Script Trigger to configure.

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument

© National Instruments 97

NI-RFSG

handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Configuration List Step Trigger Digital Edge VI
niRFSG Configure Configuration List Step Trigger Digital Edge VI

Configures the configuration list step trigger for digital edge triggering.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 source —

source specifies the trigger source terminal for the digital edge configuration list step trigger. NI-
RFSG sets the Configuration List Step Trigger Digital Edge Source property to this value. Refer to
this property for possible values.

•

 edge —

edge specifies the active edge for the digital edge configuration list step trigger. NI-RFSG sets the
Configuration List Step Trigger Digital Edge property to this value.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

98 ni.com

NI-RFSG

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Disable Configuration List Step Trigger VI
niRFSG Disable Configuration List Step Trigger VI

Configures the device not to receive triggers for the configuration list. The
configuration list does not advance steps if this trigger is disabled. Call this VI only if a
previously configured trigger needs to be disabled.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

© National Instruments 99

NI-RFSG

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Start Trigger P2P Endpoint Fullness VI
niRFSG Configure Start Trigger P2P Endpoint Fullness VI

Configures the Start Trigger to detect peer-to-peer endpoint fullness. Generation
begins when the number of samples in the peer-to-peer endpoint reaches the
threshold specified by the level parameter.

Note Due to an additional internal FIFO in the RF signal generator, the writer
peer actually writes 2,304 bytes more than the quantity of data specified by
this VI to satisfy the trigger level.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 level —

level specifies the quantity of data in the FIFO endpoint that asserts the trigger, in samples per
channel. The default value is -1, which allows NI-RFSG to select the appropriate fullness value.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument

100 ni.com

NI-RFSG

handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Send Software Edge Trigger VI
niRFSG Send Software Edge Trigger VI

Forces a trigger to occur. The specified trigger generates regardless of whether the
trigger has been configured as a software trigger.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Triggers

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 trigger type —

trigger type specifies the type of trigger to send. NI-RFSG can send a Start Trigger or a Script
Trigger.

•

 trigger ID —

trigger ID specifies the Script Trigger to configure. This parameter is valid only when you set the
trigger type control to Script Trigger.

© National Instruments 101

NI-RFSG

scriptTrigger0
scriptTrigger1
scriptTrigger2
scriptTrigger3

•

 error in —

Specifies Script Trigger 0.
Specifies Script Trigger 1.
Specifies Script Trigger 2.
Specifies Script Trigger 3.

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Export Signal VI
niRFSG Export Signal VI

Routes signals (triggers, clocks, and events) to a specified output terminal. The NI-
RFSG device must be in the Configuration state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Related Topics

Triggers

Events

PFI Lines

PXI Trigger Lines

102 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 signal —

signal specifies the type of signal to route.

Start Trigger
Script Trigger
Marker Event

Ref Clock

Exports a Start Trigger.
Exports a Script Trigger.
Exports a Marker Event.
Routes the onboard 10 MHz synchronization clock (PXI chassis
only).
Exports a Started Event.
Exports a Done Event.

Started Event
Done Event
Configuration List Step
Trigger
Configuration Settled Event  Exports a Configuration Settled Event.

Exports a Configuration List Step Trigger.

•

 signal identifier —

signal identifier specifies the Script Trigger or Marker Event to configure. This parameter is
useful when the signal parameter is set to Script Trigger or Marker Event. Otherwise, set this
parameter to None.

scriptTrigger0
scriptTrigger1
scriptTrigger2
scriptTrigger3
marker0
marker1
marker2
marker3

Specifies Script Trigger 0.
Specifies Script Trigger 1.
Specifies Script Trigger 2.
Specifies Script Trigger 3.
Specifies Marker 0.
Specifies Marker 1.
Specifies Marker 2.
Specifies Marker 3.

© National Instruments 103

NI-RFSG

None

Does not export a signal.

•

 output terminal —

output terminal specifies the terminal where the signal will be exported. You can choose not to
export any signal. For the PXIe-5841 with PXIe-5655, the signal is exported to the terminal on the
PXIe-5841.

Do not
export
signal
RefOut
RefOut2
ClkOut
PFI0
PFI1
PFI4
PFI5
PXI_Trig0
PXI_Trig1
PXI_Trig2
PXI_Trig3
PXI_Trig4
PXI_Trig5
PXI_Trig6

PXI_Star

PXIe_DStarC

TrigOut

Does not export a signal.

Exports a signal to the REF OUT terminal.
Exports a signal to the REF OUT2 terminal.
Exports a signal to the CLKOUT terminal.
Exports a signal to the PFI 0 terminal.
Exports a signal to the PFI 1 terminal.
Exports a signal to the PFI 4 terminal.
Exports a signal to the PFI 5 terminal.
Exports a signal to the PXI trigger line 0 terminal.
Exports a signal to the PXI trigger line 1 terminal.
Exports a signal to the PXI trigger line 2 terminal.
Exports a signal to the PXI trigger line 3 terminal.
Exports a signal to the PXI trigger line 4 terminal.
Exports a signal to the PXI trigger line 5 terminal.
Exports a signal to the PXI trigger line 6 terminal.
Exports a signal to the PXI star trigger line terminal. This value is not supported by
the PXIe-5644/5645/5646.
Exports a signal to the PXIe DStar C trigger line terminal. This value is supported on
only the PXIe-5820/5830/5831/5832/5840/5841/5842.
Exports a signal to the TRIG IN/OUT terminal.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

104 ni.com

NI-RFSG

error out contains error information. This output provides standard error out functionality.

Details

If you export a signal with this VI and commit the session with the niRFSG Commit VI,
the signal is routed to the output terminal you specify. If you then reconfigure the
signal to have a different output terminal, the previous output terminal is tristated
when the session is next committed. If you change the output terminal to Do Not
Export and commit the session, the previous output terminal is tristated.

Any signals exported within a session persist after the session closes to prevent signal
glitches between sessions. If you want to tristate the exported output terminal that the
signal was exported to when the session closes, first change the value of the output
terminal for the exported signal to Do Not Export, and then commit the session again
before closing it.

You can also tristate all PFI lines by setting the reset device input in the niRFSG
Initialize VI.

niRFSG Get Terminal Name VI
niRFSG Get Terminal Name VI

Returns the fully-qualified name of the specified signal. The fully-qualified name is
helpful when you want to automatically route signals in a multi-segment chassis.

Supported Devices:PXI/PXIe-5650/5651/5652, PXIe-5653/5654/5654 with PXIe-5696,
PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/
5860

Related Topics

Triggers

Events

Syntax for Terminal Names

© National Instruments 105

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 signal —

signal specifies the signal to query.

Start Trigger
Script Trigger
Marker Event
Ref Clock
Started Event
Done Event
Configuration List Step Trigger
Configuration Settled Event

Queries the Start Trigger.
Queries a Script Trigger.
Queries a Marker Event.
Queries the Reference Clock.
Queries the Started Event.
Queries the Done Event.
Queries the Configuration List Step Trigger.
Queries the Configuration Settled Event.

•

 signal identifier —

signal identifier specifies the Script Trigger or Marker Event to query. This parameter is
necessary when you set the signal parameter to Script Trigger or Marker Event. Otherwise, set
this parameter to None.

Specifies Script Trigger 0.
Specifies Script Trigger 1.
Specifies Script Trigger 2.
Specifies Script Trigger 3.
Specifies Marker 0.
Specifies Marker 1.
Specifies Marker 2.
Specifies Marker 3.
Does not specify a signal identifier.

scriptTrigger0
scriptTrigger1
scriptTrigger2
scriptTrigger3
marker0
marker1
marker2
marker3
None

•

 error in —

106 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 terminal name —

terminal name returns the fully-qualified string.

 error out —

error out contains error information. This output provides standard error out functionality.

Configure Clock
Configure Clock

Use the Clock Configuration VIs to configure the clocks.

niRFSG Configure Ref Clock VI
niRFSG Configure Ref Clock VI

Configures the NI-RFSG device Reference Clock. The Reference Clock ensures that the
NI-RFSG devices are operating from a common timebase. The NI-RFSG device must be
in the Configuration state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Related Topics

PXIe-5672 Timing Configurations

PXIe-5673 Timing Configurations

© National Instruments 107

NI-RFSG

PXIe-5673E Timing Configurations

PXIe-5830 Timing Configurations

PXIe-5831/5832 Timing Configurations

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 ref clock source —

ref clock source specifies the source of the Reference Clock signal.

Uses the onboard Reference Clock as the clock source.

PXIe-5830/5831/5832â€”For the PXIe-5830, connect the PXIe-5820 REF IN
connector to the PXIe-3621 REF OUT connector. For the PXIe-5831, connect the
PXIe-5820 REF IN connector to the PXIe-3622 REF OUT connector. For the
PXIe-5832, connect the PXIe-5820 REF IN connector to the PXIe-3623 REF OUT
connector.

Onboard
Clock
(default)

PXIe-5831 with PXIe-5653â€”Connect the PXIe-5820 REF IN connector to the
PXIe-3622 REF OUT connector. Connect the PXIe-5653 REF OUT (10 MHz)
connector to the PXIe-3622 REF IN connector.

PXIe-5832 with PXIe-5653â€”Connect the PXIe-5820 REF IN connector to the
PXIe-3623 REF OUT connector. Connect the PXIe-5653 REF OUT (10 MHz)
connector to the PXIe-3623 REF IN connector.

PXIe-5841 with PXIe-5655â€”Lock to the PXIe-5655 onboard clock. Connect the
REF OUT connector on the PXIe-5655 to the PXIe-5841 REF IN connector.

108 ni.com

NI-RFSG

PXIe-5842â€”Lock to the associated PXIe-5655 onboard clock. Cables between
modules are required as shown in the Getting Started Guide for the instrument.

Uses the clock signal present at the front panel REF IN connector as the clock
source.

PXIe-5830/5831/5832â€”For the PXIe-5830, connect the PXIe-5820 REF IN
connector to the PXIe- 3621 REF OUT connector. For the PXIe-5831, connect the
PXIe-5820 REF IN connector to the PXIe-3622 REF OUT connector. For the
PXIe-5832, connect the PXIe-5820 REF IN connector to the PXIe-3623 REF OUT
connector. For the PXIe-5830, lock the external signal to the PXIe-3621 REF IN
connector. For the PXIe-5831, lock the external signal to the PXIe-3622 REF IN
connector. For the PXIe-5832, lock the external signal to the PXIe-3623 REF IN
connector.

RefIn

PXIe-5831 with PXIe-5653â€”Connect the PXIe-5820 REF IN connector to the
PXIe-3622 REF OUT connector. Connect the PXIe-5653 REF OUT (10 MHz)
connector to the PXIe-3622 REF IN connector. Lock the external signal to the
PXIe-5653 REF IN connector.

PXIe-5832 with PXIe-5653â€”Connect the PXIe-5820 REF IN connector to the
PXIe-3623 REF OUT connector. Connect the PXIe-5653 REF OUT (10 MHz)
connector to the PXIe-3623 REF IN connector. Lock the external signal to the
PXIe-5653 REF IN connector.

PXIe-5841 with PXIe-5655â€”Lock to the signal at the REF IN connector on the
associated PXIe-5655. Connect the PXIe-5655 REF OUT connector to the
PXIe-5841 REF IN connector.

PXIe-5842â€”Lock to the signal at the REF IN connector on the associated
PXIe-5655. Cables between modules are required as shown in the Getting Started
Guide for the instrument.

PXI Clock

Uses the PXI_CLK signal, which is present on the PXI backplane, as the clock
source.

This value is valid on only the PXIe-5831 with PXIe-5653 and the PXIe-5832 with
PXIe-5653.

PXI_ClkMaster

PXIe-5831 with PXIe-5653â€”NI-RFSG configures the PXIe-5653 to export the

© National Instruments 109

NI-RFSG

Reference clock and configures the PXIe-5820 and PXIe-3622 to use PXI_Clk as
the Reference Clock source. Connect the PXIe-5653 REF OUT (10 MHz) connector
to the PXI chassis REF IN connector.

PXIe-5832 with PXIe-5653â€”NI-RFSG configures the PXIe-5653 to export the
Reference clock and configures the PXIe-5820 and PXIe-3623 to use PXI_Clk as
the Reference Clock source. Connect the PXIe-5653 REF OUT (10 MHz) connector
to the PXI chassis REF IN connector.

•

 ref clock rate (Hz) —

ref clock rate specifies the Reference Clock rate, in hertz (Hz), of the signal present at the REF IN
or CLK IN connector. This parameter is only valid when the ref clock source parameter is set to
RefIn. The default value is Auto (-1.0), which allows NI-RFSG to use the default Reference Clock
rate for the device or automatically detect the Reference Clock rate, if supported. Refer to the
Reference Clock Rate property for possible values.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure PXI Chassis Clk10 VI
niRFSG Configure PXI Chassis Clk10 VI

Specifies the signal to drive the 10 MHz Reference Clock on the PXI backplane. This
option can only be configured when the PXI-5610 is in Slot 2 of the PXI chassis. The NI-
RFSG device must be in the Configuration state before you call this VI.

Supported Devices: PXI-5610, PXI-5670/5671

110 ni.com

NI-RFSG

Related Topics

Timing Configurations

System Reference Clock

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 PXI Clk10 source —

PXI Clk10 source specifies the source of the Reference Clock signal.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Peer To Peer
Peer To Peer

Use the peer-to-peer VIs to configure peer-to-peer streaming.

© National Instruments 111

NI-RFSG

niRFSG Get Stream Endpoint Handle VI
niRFSG Get Stream Endpoint Handle VI

Returns a reader endpoint handle that can be used with NI-P2P to configure a peer-to-
peer stream with an RF signal generator endpoint.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Configuring a Peer-to-Peer Endpoint

Configuring Flow Control

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 stream endpoint —

stream endpoint indicates which stream resources to use.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 reader handle —

112 ni.com

NI-RFSG

reader handle returns the reader endpoint handle that is used with NI-P2P to create a stream
with the NI-RFSG device as an endpoint.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Write P2P Endpoint (I16) VI
niRFSG Write P2P Endpoint (I16) VI

Writes an array of 16-bit integer data to the peer-to-peer endpoint. Use this VI to write
initial data from the host to the endpoint before starting generation to avoid
underflow when you start the generation.

Supported Devices: PXIe-5673E

Related Topics

Configuring a Peer-to-Peer Stream—Refer to this topic for more information about
configuring a stream.

Configuring Flow Control

Starting Peer-to-Peer Generation

Reconfiguring a Stream

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 stream endpoint —

© National Instruments 113

NI-RFSG

stream endpoint is the stream endpoint FIFO to configure.

•

 interleaved IQ Data —

interleaved IQ Data specifies the array of data to write into the endpoint FIFO. The binary data is
left-justified.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 stream endpoint out —

stream endpoint out specifies which stream resources to use.

 error out —

error out contains error information. This output provides standard error out functionality.

De-embedding
De-embedding

Use the NI-RFSG De-embedding VIs to de-embed measurements.

Related Topics

De-embedding Overview

niRFSG Create De-embedding S-parameter Table VI
niRFSG Create De-embedding S-parameter Table VI

Creates an S-parameter de-embedding table for the port.

114 ni.com

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

NI-RFSG

Related Topics

De-embedding Overview

S-parameters

niRFSG Create De-embedding S-parameter Table (S2P file) VI
niRFSG Create De-embedding S-parameter Table (S2P file) VI

Creates an S-parameter de-embedding table for the port based on the specified S2P
file.

If you only create one table for a port, NI-RFSG automatically selects that table to de-
embed the generation.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

 table name —

© National Instruments 115

NI-RFSG

table name specifies the name of the table. The name must be unique for a given port, but not
across ports. If you use the same name as an existing table, the table is replaced.

•

 S2P file path —

S2P file path specifies the path to the S2P file that contains de-embedding information for the
specified port.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 S-parameters orientation —

S-parameters orientation specifies the orientation of the data in the S2P file relative to the port
on the DUT port. The default value is Port2 Towards DUT.

Port1 Towards DUT (24000)

Port 1 of the S2P is oriented towards the DUT
port.

Port2 Towards DUT (24001)

Port 2 of the S2P is oriented towards the DUT
port.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Create De-embedding S-parameter Table (array) VI
niRFSG Create De-embedding S-parameter Table (array) VI

Creates an s-parameter de-embedding table for the port from the input data.

If you only create one table for a port, NI-RFSG automatically selects that table to de-
embed the generation.

116 ni.com

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

NI-RFSG

Inputs/Outputs

•

 S-parameter table —

S-parameter table specifies the S-parameters for each frequency. The first index indicates which
frequency the entry is for. The second index is the target port for the S-parameter and the third
index is the the source port. For example, to index the s21 parameter for the fourth frequency in
the table, you would use {3, 1, 0} as the indexes since they are zero-based.

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

 table name —

table name specifies the name of the table. The name must be unique for a given port, but not
across ports. If you use the same name as an existing table, the table is replaced.

•

 frequencies —

frequencies specifies the frequencies for the S-parameter table rows. Frequencies must be
unique and in ascending order.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 S-parameters orientation —

© National Instruments 117

NI-RFSG

S-parameters orientation specifies the orientation of the data in the S2P file relative to the port
on the DUT port. The default value is Port2 Towards DUT.

Port1 Towards DUT (24000)

Port 1 of the S2P is oriented towards the DUT
port.

Port2 Towards DUT (24001)

Port 2 of the S2P is oriented towards the DUT
port.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Delete De-embedding Table VI
niRFSG Delete De-embedding Table VI

Deletes the selected de-embedding table for a given port.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

118 ni.com

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

NI-RFSG

•

•

 table name —

table name specifies the name of the table.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Delete All De-embedding Tables VI
niRFSG Delete All De-embedding Tables VI

Deletes all configured de-embedding tables for the session.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

© National Instruments 119

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Select De-embedding Table VI
niRFSG Select De-embedding Table VI

Selects the de-embedding table to apply to measurements made with the port.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

•

 table name —

table name specifies the name of the table.

 error in —

120 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure De-embedding Table Interpolation VI
niRFSG Configure De-embedding Table Interpolation VI

Specifies the interpolation method to use when interpolating parameters from the de-
embedding table. Linear interpolation is the default.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

niRFSG Configure De-embedding Table Interpolation (Nearest) VI
niRFSG Configure De-embedding Table Interpolation (Nearest) VI

Selects the nearest interpolation method.

The parameters of the table nearest to the carrier frequency are used for de-
embedding.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

© National Instruments 121

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

•

 table name —

table name specifies the name of the table.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure De-embedding Table Interpolation (Linear) VI
niRFSG Configure De-embedding Table Interpolation (Linear) VI

Selects the linear interpolation method.

If the carrier frequency does not match a row in the de-embedding table, NI-RFSG
performs a linear interpolation based on the entries in the de-embedding table to
determine the parameters used for de-embedding.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

122 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

•

 table name —

table name specifies the name of the table.

 format —

format specifies the format of parameters to interpolate. The default value is Real and
Imaginary.

Real and Imaginary (4000)

Magnitude and Phase (4001)

Magnitude(dB) and Phase (4002)

•

 error in —

Results in a linear interpolation of the real
portion of the complex number and a separate
linear interpolation of the complex portion.

Results in a linear interpolation of the
magnitude and a separate linear interpolation
of the phase.

Results in a linear interpolation of the
magnitude, in decibels, and a separate linear
interpolation of the phase.

© National Instruments 123

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure De-embedding Table Interpolation (Spline) VI
niRFSG Configure De-embedding Table Interpolation (Spline) VI

Selects the spline interpolation method.

If the carrier frequency does not match a row in the de-embedding table, NI-RFSG
performs a spline interpolation based on the entries in the de-embedding table to
determine the parameters used for de-embedding.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 port —

port specifies the name of the port. The only valid value for the PXIe-5840/5841 is "" (empty
string).

•

 table name —

124 ni.com

NI-RFSG

table name specifies the name of the table.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get De-embedding S-parameters VI
niRFSG Get De-embedding S-parameters VI

Returns the S-parameters used for de-embedding a measurement on the selected
port. This includes interpolation of the parameters based on the configured carrier
frequency. This VI returns an empty array if no de-embedding is completed.

Note The port orientation for the returned S-parameters is normalized to
Port2 Towards DUT.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

© National Instruments 125

NI-RFSG

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 S-parameters —

S-parameters returns an array of S-parameters. The first index indicates the target port for the S-
parameter and the second index is the source port.

For example, to index the s21 parameter, use {1, 0} for the indexes since they are zero-based.

•

 number of ports —

number of ports returns the number of S-parameter ports. The S-parameter array is always n x
n, where n is the number of ports.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Abort VI
niRFSG Abort VI

Stops signal generation.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Programming State Model

126 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. The default is no error.
This node passes the error in input to the error out output. This node will run regardless of
whether an error occurred before it.

This input contains status, code, and source, which provide standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Utility
Utility

Use the utility VIs to access additional features of the NI-RFSG instrument driver.

niRFSG Initialize With Options VI
niRFSG Initialize With Options VI

Opens a session to the device you specify as the resource name and returns an
instrument handle that you use to identify the instrument in all subsequent NI-RFSG
VIs. This VI also configures the device using the option string input.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,

© National Instruments 127

NI-RFSG

PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Driver Setup Options

Simulating an NI RF Signal Generator

Inputs/Outputs

•

 resource name —

resource name specifies the resource name of the device to initialize.

Note For multichannel devices such as the PXIe-5860, the resource name must
include the channel number to use. The channel number is specified by appending
/ChannelNumber to the device name, where ChannelNumber is the channel
number (0, 1, etc.). For example, if the device name is PXI1Slot2 and you want to
use channel 0, use the resource name PXI1Slot2/0.

•

 option string —

option string sets the initial value of certain properties for the session.

You can set the following properties using this parameter:

•  Range Check
•  Query Instrument Status
•  Cache
•  Coercions
•  Simulate
•  Driver Setup
 id query —

•

id query specifies whether NI-RFSG performs an ID query. Set this parameter to TRUE to perform
an ID query. Set this parameter to FALSE to not perform an ID query.

128 ni.com

NI-RFSG

•

 reset device —

reset device specifies whether you want to reset the NI-RFSG device during the initialization
procedure. Set this parameter to TRUE to reset the device. Set this parameter to FALSE to not
reset the device.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle is obtained from the niRFSG Initialize VI or this VI and identifies a particular instrument
session.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Commit VI
niRFSG Commit VI

Programs the device with the correct settings. Calling this VI moves the NI-RFSG device
from the Configuration state to the Committed state. After this VI executes, a change to
any property reverts the NI-RFSG device to the Configuration state.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

NI-RFSG Programming State Model

© National Instruments 129

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Wait Until Settled VI
niRFSG Wait Until Settled VI

Waits until the RF output signal settles. This VI is useful for devices that support
changes while in the Generation state. Call this VI after making a dynamic change to
wait for the output signal to settle. You can also call this VI after calling the niRFSG
Commit VI to wait for changes to settle. The niRFSG Wait Until Settled VI is not required
after calling the niRFSG Initiate VI because the niRFSG Initiate VI automatically waits
for the output to settle.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

130 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 Max. time (ms) —

Max. time specifies the maximum time the VI waits for the output to settle. If the maximum time
is exceeded, this VI returns an error.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Configure Output Enabled VI
niRFSG Configure Output Enabled VI

Enables or disables signal output. Setting output enabled to FALSE while in the
Generation state attenuates the generated signal so that no signal is output.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Output Enabled

NI-RFSG Instrument Driver Programming Flow

© National Instruments 131

NI-RFSG

RF List Mode

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 output enabled —

output enabled specifies whether the RF output is enabled.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Self Test VI
niRFSG Self Test VI

Performs a self-test on the NI-RFSG device and returns the test results. This VI performs
a simple series of tests to determine whether the NI-RFSG device is powered up and
responding. This VI does not affect external I/O connections or connections between
devices. Complete functional testing and calibration are not performed by this VI. The
NI-RFSG device must be in the Configuration state before you call this VI.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/

132 ni.com

NI-RFSG

5832/5840/5841/5842/5860

Related Topics

Device Warm-Up

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 self test result —

self test result returns the value returned from the device self-test. A value of 0 indicates that the
device is powered-up and responding. A value of 1 indicates that the device failed the self test.

•

•

 self test message —

self test message returns the self-test response string from the NI-RFSG device.

 error out —

error out contains error information. This output provides standard error out functionality.

© National Instruments 133

NI-RFSG

niRFSG Reset VI
niRFSG Reset VI

Resets all properties to their default values and moves the NI-RFSG device to the
Configuration state. This VI aborts the signal generation, clears all routes, deletes all
de-embedding tables, and resets session properties to their initial values. During a
reset, routes of signals between this and other devices are released, regardless of
which device created the route.

Note This VI resets all configured routes for the PXIe-5644/5645/5646 and
PXIe-5820/5830/5831/5832/5840/5841/5842/5860 in NI-RFSA and NI-RFSG. To
avoid resetting routes on the device that are in use by NI-RFSA sessions, NI
recommends using the niRFSG Reset With Options VI with the steps to omit
parameter set to Routes.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

134 ni.com

NI-RFSG

error out contains error information. This output provides standard error out functionality.

niRFSG Reset With Options VI
niRFSG Reset With Options VI

Resets all properties to default values and specifies steps to omit during the reset
process, such as signal routes.

To avoid resetting routes on PXIe-5820/5830/5831/5832/5840/5841/5842/5860 that are
in use by NI-RFSA sessions, NI recommends using this VI instead of the niRFSG Reset VI,
with the steps to omit parameter set to Routes.

By default, this VI exhibits the same behavior as the niRFSG Reset VI. You can specify
steps to omit using the steps to omit parameter. For example, if you set the steps to
omit parameter to Routes, this VI does not release signal routes during the reset
process.

When routes of signals between two devices are released, they are released regardless
of which device created the route.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Related Topics

Triggers

Events

Inputs/Outputs

•

 instrument handle —

© National Instruments 135

NI-RFSG

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 steps to omit —

steps to omit specifies a list of steps to skip during reset process. The default value is an empty
array, which specifies that no steps are omitted during reset.

Waveforms Omits clearing waveforms.
Scripts

Routes

Omits clearing scripts.
Omits the routing reset step. Routing is preserved after a reset. However, routing
related properties are reset to default, and routing is released if the default
properties are committed after reset.

De-
embedding
Tables

Omits deleting de-embedding tables.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Reset Device VI
niRFSG Reset Device VI

Performs a hard reset on the device, which consists of the following actions:

- Signal generation is stopped.

- All routes are released.

- External bidirectional terminals are tristated.

136 ni.com

NI-RFSG

- FPGAs are reset.

- Hardware is configured to its default state.

- All session properties are reset to their default states.

Supported Devices:PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E

Related Topics

Thermal Shutdown

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

During a device reset, routes of signals between this and other devices are released,

© National Instruments 137

NI-RFSG

regardless of which device created the route. For example, a trigger signal exported to
a PXI trigger line that is used by another device is no longer exported.

•  PXI-5610, PXI-5670/5671, PXIe-5672: After calling this VI, the device requires

25 seconds before returning to full functionality. NI-RFSG enforces this condition
by adding a wait, if needed, the next time you try to access the device.

niRFSG Save Configurations To File VI
niRFSG Save Configurations To File VI

Saves the configurations of the session to the specified file.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 channel name —

channel name specifies the name of the channel. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

•

 file path —

file path specifies the absolute path of the file to which the NI-RFSG saves the configurations.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

138 ni.com

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Load Configurations From File VI
niRFSG Load Configurations From File VI

Loads the configurations from the specified file to the NI-RFSG driver session. The VI
does an implicit reset before loading the configurations from the file.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 channel name —

channel name specifies the name of the channel. This string is case-insensitive and
alphanumeric, and it cannot use reserved words.

•

•

 file path —

file path specifies the absolute path of the file from which the NI-RFSG loads the configurations.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

© National Instruments 139

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Perform Power Search VI
niRFSG Perform Power Search VI

Performs a power search if the ALC Control property is disabled. Calling this VI disables
modulation for a short time while the device levels the output signal.

Note Power search temporarily enables the ALC, so ensure the appropriate
included cable is connected between the PXIe-5654 ALC IN connector and the
PXIe-5696 ALC OUT connector to successfully perform a power search.

Supported Devices:PXIe-5654 with PXIe-5696

Related Topics

Power Search

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

140 ni.com

NI-RFSG

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Session Reference VI
niRFSG Get Session Reference VI

Extracts a session that can be passed to NI-TClk VIs. Session References are of generic
data type, which means that the corresponding wires are blue-green, unlike the wires
for regular instrument driver sessions.

Supported Devices: PXIe-5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/
5860

Note NI-RFSG does not support NI-TClk when driver session debugging is
enabled.

Related Topics

NI-TClk Overview

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

© National Instruments 141

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 session reference —

session reference returns a reference to the device session that can be passed to NI-TClk VIs.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Revision Query VI
niRFSG Revision Query VI

Returns the revision numbers of the NI-RFSG driver and the instrument firmware.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

142 ni.com

NI-RFSG

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 instrument driver revision —

instrument driver revision returns the instrument driver software revision numbers in the form
of a string. The value of the Revision property is returned.

•

 firmware revision —

firmware revision returns the instrument firmware revision numbers in the form of a string. The
value of the Firmware Revision property is returned.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Query Arb Waveform Capabilities VI
niRFSG Query Arb Waveform Capabilities VI

Queries and returns the arbitrary waveform capabilities of the NI-RFSG device. These
capabilities are related to the current device configuration. The NI-RFSG device must
be in the Configuration or Generation state before you call this VI.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

© National Instruments 143

NI-RFSG

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 maximum number of waveforms —

maximum number of waveforms returns the maximum number of arbitrary waveforms, as
specified in the Max. Number Waveforms property, that you can write.

•

 maximum waveform size (samples) —

maximum waveform size returns the value of the Max. Waveform Size property. The number of
samples that you write must be less than or equal to this value.

•

 minimum waveform size (samples) —

minimum waveform size returns the value of the Min. Waveform Size property. The number of
samples that you write must be greater than or equal to this value.

•

•

 error out —

error out contains error information. This output provides standard error out functionality.

 waveform quantum —

waveform quantum returns the quantum value the signal generator uses. The value of the
Waveform Quantum property is returned.

niRFSG Perform Thermal Correction VI
niRFSG Perform Thermal Correction VI

Corrects for any signal drift due to temperature variation when generating the same
signal for extended periods of time without a parameter change. Under normal
circumstances of short-term signal generation, NI-RFSG performs thermal correction
automatically by ensuring stable power levels, and you do not need to call this VI. Use
this VI when generating the same signal for a long period of time in a temperature-
fluctuating environment. The NI-RFSG device must be in the Generation state before

144 ni.com

you call this VI.

Supported Devices: PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/5654 with
PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5830/5831/5832/5840/5841/
5842/5860

NI-RFSG

Related Topics

Thermal Management

Impairment Calibration

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Error Message VI
niRFSG Error Message VI

Converts a error code returned by an NI-RFSG VI into a user-readable string. Instead of

© National Instruments 145

using this VI, most applications will use an Error Out control or the Simple Error
Handler in LabVIEW to display error information.

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

 error code —

error code specifies the error code returned from any NI-RFSG VI. The default value is 0.

 error in —

•

•

error in can accept error information wired from VIs previously called. The pop-up option Explain
Error (or Explain Warning) gives more information about the error displayed.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error message —

error message returns user-readable message string that corresponds to the error code you
specify.

•

 error out —

error out passes error or warning information out of a VI to be used by other VIs. The pop-up
option Explain Error (or Explain Warning) gives more information about the error displayed.

niRFSG Get Max Settable Power VI
niRFSG Get Max Settable Power VI

Returns the maximum settable output power level for the current configuration.

146 ni.com

Supported Devices:PXIe-5830/5831/5832/5840/5841/5842/5860

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

•

 max settable power —

max settable power returns maximum settable power level in dBm.

 error out —

error out contains error information. This output provides standard error out functionality.

Calibration
Calibration

Use the Calibration VIs to calibrate your device. Refer to the calibration procedure for
your device for more information about device calibration.

© National Instruments 147

Self Calibration
Self Calibration

Use the Self Calibration VIs to perform self-calibration and to obtain information about
previous calibrations.

NI-RFSG

niRFSG Self Cal VI
niRFSG Self Cal VI

Performs an internal self-calibration on the device and associated modules that
support self-calibration. If the calibration is successful, new calibration data and
constants are stored in the onboard nonvolatile memory of the module.

Supported Devices: PXI-5610, PXIe-5653, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

PXIe-5830 Self-Calibration

PXIe-5831/5832 Self-Calibration

PXIe-5840 Self-Calibration

PXIe-5841 Self-Calibration

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

148 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

Open NI-RFSA Session for the PXIe-5820/5830/5831/5832/5840/5841/5842/5860

If there is an existing NI-RFSA session open for the same PXIe-5820/5830/5831/5832/
5840/5841/5842/5860 while this VI runs, it may remain open but cannot be used for
operations that access the hardware, for example niRFSA Commit or niRFSA Initiate.
For the existing open session to use the new self-calibration data, the session will need
to be closed and reopened.

PXIe-5860

While this VI is running on one channel, if there are any existing NI-RFSG or NI-RFSA
sessions open on the other channel, they may remain open but cannot be used for
operations that access the hardware, for example niRFSG Commit or niRFSG Initiate or
niRFSA Commit or niRFSA Initiate. For the existing open session to use the new self-
calibration data, the session will need to be closed and reopened.

PXIe-5841 with PXIe-5655

The PXIe-5841 maintains separate self-calibration data for both the PXIe-5841
standalone and when associated with the PXIe-5655. Use this VI once for each
intended configuration.

© National Instruments 149

NI-RFSG

niRFSG Self Calibrate Range VI
niRFSG Self Calibrate Range VI

Self-calibrates all configurations within the specified frequency and peak power level
limits.

NI recommends that no external signals are present on the RF In or IQ In ports during
the calibration.

Note This VI does not update self calibration date and temperature.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 steps to omit —

steps to omit specifies which calibration steps to skip during the self-calibration process. The
default value is an empty array, which specifies that all calibration steps are performed.

LO Self Cal

Power Level
Accuracy
Residual LO
Power
Image

Omits the LO Self Cal step. If you omit this step, the power level of the LO is not
adjusted.
Omits the Power Level Accuracy step. If you omit this step, the power level
accuracy of the device is not adjusted.
Omits the Residual LO Power step. If you omit this step, the Residual LO Power
performance is not adjusted.
Omits the Image Suppression step. If you omit this step, the Residual Sideband

150 ni.com

NI-RFSG

Suppression
Synthesizer
Alignment

Image performance is not adjusted.
Omits the Voltage Controlled Oscillator (VCO) Alignment step. If you omit this
step, the LO PLL is not adjusted.

•

 min frequency (Hz) —

min frequency specifies the minimum frequency to calibrate.

Note For the PXIe-5830/5831/5832, only the applicable ports within the specified
frequency range are calibrated.

 max frequency (Hz) —

max frequency specifies the maximum frequency to calibrate.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 min peak power level (dBm) —

min peak power level specifies the minimum power level to calibrate.

 max peak power level (dBm) —

max peak power level specifies the maximum power level to calibrate.

 instrument handle out —

•

•

•

•

•

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

Details

Recommendation for Best Results

© National Instruments 151

NI-RFSG

For best results, NI recommends that you perform self-calibration without omitting
any steps. However, if certain aspects of performance are less important for your
application, you can omit certain steps for faster calibration.

Open NI-RFSA Sessions

•  If there is an existing NI-RFSA session open for the same PXIe-5644/5645/5646, it

may remain open but cannot be used while this VI runs.

•  If there is an existing NI-RFSA session open for the same PXIe-5820/5830/5831/

5832/5840/5841/5842 while this VI runs, it may remain open but cannot be used for
operations that access the hardware, for example niRFSA Commit or niRFSA
Initiate.

Clearing Self Calibration Range Data

Self calibration range data is valid until you restart the system or call the niRFSG Clear
Self Calibrate Range VI.

niRFSG Get Self Calibration Date and Time VI
niRFSG Get Self Calibration Date and Time VI

Returns the date and time of the last successful self-calibration. The time returned is
24-hour local time. For example, if the device was calibrated at 2:30 PM, this VI returns
14 for the hours and 30 for the minutes.

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXIe-5653, PXI-5670/5671,
PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI, the niRFSG Initialize With Options VI, or the niRFSG Initialize
External Calibration VI.

152 ni.com

NI-RFSG

•

 module —

module specifies from which stand-alone module to retrieve the last successful self-calibration
date and time.

Primary Module (default) The stand-alone device or the main module in a multi-module device.
AWG
LO

The AWG associated with the primary module.
The LO associated with the primary module.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from either the niRFSG Initialize VI, the niRFSG Initialize With Options VI,
or the niRFSG Initialize External Calibration VI.

•

•

 self calibration date and time —

self calibration date and time returns the date and time of the last successful self-calibration.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get Self Calibration Temperature VI
niRFSG Get Self Calibration Temperature VI

Returns the temperature, in degrees Celsius, of the device at the last successful self-
calibration.

Supported Devices: PXI-5610, PXIe-5653, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831(IF only)/5832 (IF only)/5840/5841/5842/5860

© National Instruments 153

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI, the niRFSG Initialize With Options VI, or the niRFSG Initialize
External Calibration VI.

•

 module —

module specifies from which stand-alone module to retrieve the last successful self-calibration
temperature.

Primary Module (default) The stand-alone device or the main module in a multi-module device.
AWG
LO

The AWG associated with the primary module.
The LO associated with the primary module.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from either the niRFSG Initialize VI, the niRFSG Initialize With Options VI,
or the niRFSG Initialize External Calibration VI.

•

 self calibration temperature —

self calibration temperature returns the temperature, in degrees Celsius, of the device at the
last successful self-calibration.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Clear Self Calibrate Range VI
niRFSG Clear Self Calibrate Range VI

Clears the data obtained from the niRFSG Self Calibrate Range VI.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842

154 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from the niRFSG Initialize VI or the niRFSG Initialize With Options VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5840 Align LO Daisy Chain VI
niRFSG 5840 Align LO Daisy Chain VI

Performs an external LO alignment by adjusting the LO IN Power property settings for
optimal use with the PXIe-5653.

Ensure the PXIe-5840 is unassociated from the PXIe-5653 in Measurement &
Automation Explorer before calling this VI.

Supported Devices: PXIe-5840

© National Instruments 155

NI-RFSG

Inputs/Outputs

•

 use external LO? (T) —

•

•

•

•

•

use external LO? specifies whether the PXIe-5653 is used as the external LO. The default value is
TRUE.

 external LO —

external LO specifies the resource name of the PXIe-5653.

 daisy chain —

daisy chain specifies the daisy-chained PXIe-5840 to perform external LO alignment on.

•

•

 resource name —

resource name specifies the resource name of the daisy-chained PXIe-5840 device.

 port type —

port type specifies the port type of the daisy-chained PXIe-5840.

Specifies the PXIe-5840 RF IN port. This value is not supported as the first element of
an array.

Specifies the PXIe-5840 RF OUT port.

RF In

RF
Out

 start frequency (Hz) —

start frequency specifies the lower limit of a span of frequencies, in hertz (Hz).

 stop frequency (Hz) —

stop frequency specifies the upper limit of a span of frequencies, in hertz (Hz).

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

156 ni.com

NI-RFSG

This input contains status, code, and source, which provide standard error in functionality.

•

 error out —

error out contains error information. This output provides standard error out functionality.

External Calibration
External Calibration

Use the External Calibration VIs to calibrate your device. Refer to the calibration
procedure for your device for more information about device calibration.

niRFSG Initialize External Calibration VI
niRFSG Initialize External Calibration VI

Creates and initializes an NI-RFSG external calibration session.

Supported Devices: PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654, PXIe-5673/
5673E, PXIe-5696

Inputs/Outputs

•

•

 resource name —

resource name specifies the resource name of the device to initialize.

 password —

password specifies the calibration password required to open an external calibration session to
the device. Refer to the calibration procedure for your device for more information about the
default password.

© National Instruments 157

•

 option string —

option string sets the initial value of certain properties for the session.

You can set the following properties using this parameter:

NI-RFSG

•  Range Check
•  Query Instrument Status
•  Cache
•  Coercions
•  Simulate
•  Driver Setup
 error in —

•

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle —

instrument handle passes a reference to your instrument session to the next VI. instrument
handle is obtained from this VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Close External Calibration VI
niRFSG Close External Calibration VI

Writes the calibration values from the current driver session to the device. On
PXIe-5611 and PXIe-5673/5673E devices, this VI also writes the current date and time
as the last external calibration date and time.

Supported Devices: PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654, PXIe-5673/
5673E, PXIe-5696

158 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 write calibration to hardware? —

write calibration to hardware? specifies whether the calibration values from the current driver
session are stored to the device EEPROM. Set this parameter to TRUE to overwrite the EEPROM.
Set this parameter to FALSE to discard the current calibration values.

•

 error in —

error in describes error conditions that occur before this node runs. The default is no error.
This node passes the error in input to the error out output. This node will run regardless of
whether an error occurred before it.

This input contains status, code, and source, which provide standard error in functionality.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Get External Calibration Last Date and Time VI
niRFSG Get External Calibration Last Date and Time VI

Returns the date and time of the last successful external calibration. The time returned
is 24-hour (military) local time. For example, if the device was calibrated at 2:30 PM,
this VI returns 14 for the hours and 30 for the minutes.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5696,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

© National Instruments 159

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI, the niRFSG Initialize With Options VI, or the niRFSG Initialize
External Calibration VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from either the niRFSG Initialize VI, the niRFSG Initialize With Options VI,
or the niRFSG Initialize External Calibration VI.

•

 last external calibration date and time —

last external calibration date and time specifies the date and time of the last successful external
calibration.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Change External Calibration Password VI
niRFSG Change External Calibration Password VI

Changes the external calibration password of the device. This VI works with a regular
NI-RFSG session or an NI-RFSG calibration session.

Supported Devices: PXIe-5611, PXIe-5653/5654, PXIe-5673/5673E, PXIe-5696,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

160 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument session. instrument handle is obtained from
either the niRFSG Initialize VI, the niRFSG Initialize With Options VI, or the niRFSG Initialize
External Calibration VI.

 password —

password is the old (current) external calibration password. This password is case sensitive.

 new password —

new password is the new (desired) external calibration password. The password can be no
longer than four characters.

•

•

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI. instrument
handle out is obtained from this VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG Update External Calibration Temperature VI
niRFSG Update External Calibration Temperature VI

Updates the temperature of the last external calibration to the current temperature.

Supported Devices: PXIe-5653/5654, PXIe-5696

© National Instruments 161

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG Update External Calibration Date And Time VI
niRFSG Update External Calibration Date And Time VI

Updates the date and time of the last external calibration to the date and time that this
VI is called.

Supported Devices: PXIe-5653/5654, PXIe-5696

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides

162 ni.com

NI-RFSG

•

•

standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

NI PXIe-5611 Calibration
NI PXIe-5611 Calibration

Use the NI PXIe-5611 Calibration VIs to calibrate your PXIe-5611 device. Refer to the
calibration procedure for your device for more information about device calibration.

niRFSG 5611 Initialize LO Filter Calibration VI
niRFSG 5611 Initialize LO Filter Calibration VI

Generates external calibration constants for calibrating the LO filter DAC.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 filter to calibrate —

filter to calibrate specifies which filter to calibrate. The default value is All Filters. If you choose

© National Instruments 163

not to calibrate all filters, you must repeat the entire adjustment procedure on all filters to
complete a full calibration.

NI-RFSG

All Filters
Filter166
Filter630
Filter323
Filter1147
Filter2088

Specifies all filters.
Specifies the Filter166 filter.
Specifies the Filter630 filter.
Specifies the Filter323 filter.
Specifies the Filter1147 filter.
Specifies the Filter2088 filter.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5611 Configure LO Filter Calibration VI
niRFSG 5611 Configure LO Filter Calibration VI

Configures the device for the next LO filter DAC calibration point and waits for the
output signal to settle.

Supported Devices: PXIe-5611, PXIe-5673/5673E

164 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 external LO settings —

external LO settings indicates the options to set if an LO source is used instead of the PXI/
PXIe-5652.

•

•

 LO In Frequency (Hz) —

LO In Frequency indicates the tone frequency to generate with the LO source.

 LO In Power (dBm) —

LO In Power indicates the output power to generate with the LO source.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Adjust LO Filter Calibration VI
niRFSG 5611 Adjust LO Filter Calibration VI

Calculates calibration information pertaining to the LO filter DAC. This information is
based on user-supplied measurements. The calibration information is stored in driver

© National Instruments 165

session, and you can later write this information to the device.

Supported Devices: PXIe-5611, PXIe-5673/5673E

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 measured LO OUT power (dBm) —

measured LO OUT power specifies the power measured at the frequency indicated by the
frequency to measure output of the niRFSG 5611 Configure LO Gain Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 LO filter calibration complete —

LO filter calibration complete indicates whether the LO filter calibration is complete.

 error out —

error out contains error information. This output provides standard error out functionality.

166 ni.com

niRFSG 5611 Initialize LO Gain Calibration VI
niRFSG 5611 Initialize LO Gain Calibration VI

Generates external calibration constants for calibrating the LO gain.

Supported Devices: PXIe-5611, PXIe-5673/5673E

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 5611:LO filter —

5611:LO filter specifies which LO filter to calibrate. The default value is All Filters.

Filter6600
Filter1147
Filter630
Filter166
Filter323
Filter2088
Filter2923
Filter4092
All Filters

Specifies the Filter6600 filter.
Specifies the Filter1147 filter.
Specifies the Filter630 filter.
Specifies the Filter166 filter.
Specifies the Filter323 filter.
Specifies the Filter2088 filter.
Specifies the Filter2923 filter.
Specifies the Filter4092 filter.
Specifies all of the preceding filters.

The default value of 5611:LO filter is All Filters. If you choose not to calibrate all filters, repeat
the entire adjustment procedure on each filter to complete a full calibration.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

© National Instruments 167

NI-RFSG

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Configure LO Gain Calibration VI
niRFSG 5611 Configure LO Gain Calibration VI

Configures the device for the next LO gain calibration point and waits for the output
signal to settle.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

168 ni.com

NI-RFSG

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 external LO settings —

external LO settings indicates the options to set if an LO source is used instead of the PXI/
PXIe-5652.

•

•

 LO In Frequency (Hz) —

LO In Frequency indicates the tone frequency to generate with the LO source.

 LO In Power (dBm) —

LO In Power indicates the output power to generate with the LO source.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Adjust LO Gain Calibration VI
niRFSG 5611 Adjust LO Gain Calibration VI

Calculates calibration information pertaining to the LO gain of the device based on
user-supplied measurements. The calibration information is stored in the driver
session and can later be written to the device.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

© National Instruments 169

NI-RFSG

•

 measured LO OUT power (dBm) —

measured LO OUT power specifies the power measured at the frequency indicated by the
frequency to measure output of the niRFSG 5611 Configure LO Gain Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 LO gain calibration complete —

LO gain calibration complete indicates whether the LO gain calibration is complete.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Initialize Impairment Calibration VI
niRFSG 5611 Initialize Impairment Calibration VI

Initializes an impairment calibration section.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Related Topics

Impairment Calibration

170 ni.com

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 modulator to calibrate —

modulator to calibrate specifies which modulator to calibrate.

Lower Frequency
Modulator
Higher Frequency
Modulator

Specifies the lower frequency modulator to calibrate.

Specifies the higher frequency modulator to calibrate.

Both Modulators (default)

Specifies the lower frequency and higher frequency modulator to
calibrate.

If you do not calibrate both modulators, you must repeat the entire adjustment procedure for
each modulator to complete a full calibration.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5611 Configure Impairment Calibration VI
niRFSG 5611 Configure Impairment Calibration VI

Configures the device for the next impairment calibration point and waits for the
output signal to settle.

© National Instruments 171

Supported Devices: PXIe-5611, PXIe-5673/5673E

Related Topics

Impairment Calibration

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

 spectrum analyzer reference level (dBm) —

spectrum analyzer reference level returns the value at which to set the spectrum analyzer
reference level.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 external LO settings —

172 ni.com

NI-RFSG

external LO settings indicates the options to set if an LO source is used instead of the PXI/
PXIe-5652.

•

•

 LO In Frequency (Hz) —

LO In Frequency indicates the tone frequency to generate with the LO source.

 LO In Power (dBm) —

LO In Power indicates the output power to generate with the LO source.

•

 external AWG settings —

external AWG settings indicates the options to set if an arbitrary waveform generator (AWG) is
used instead of the PXIe-5450.

•

•

•

 Offset Frequency (Hz) —

Offset Frequency indicates the tone frequency to generate with the AWG.

 Power (dBm) —

Power indicates the output power to generate with the AWG.

 Impairments —

Impairments indicates the properties to apply to the I/Q signal to achieve desirable
calibration results.

•

•

•

 I Offset (V) —

I Offset specifies the DC offset to generate on the I signal.

 Q Offset (V) —

Q Offset specifies the DC offset to generate on the Q signal.

 Gain Imb (I/Q) —

Gain Imb specifies the power ratio (I power / Q power) to generate.

© National Instruments 173

NI-RFSG

•

 Qtr Skew (°) —

Qtr Skew specifies the adjustment of the phase angle between the I and Q vectors. If
the skew is zero, the phase angle is 90 degrees.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Adjust Impairment Calibration VI
niRFSG 5611 Adjust Impairment Calibration VI

Calculates calibration information pertaining to the impairments of the device based
on user-supplied measurements. The calibration information is stored in the driver
session and can later be written to the device.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Related Topics

Impairment Calibration

Inputs/Outputs

•

•

•

 max carrier leakage (dBc) —

 max sideband image (dBc) —

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is

174 ni.com

NI-RFSG

obtained from the niRFSG Initialize External Calibration VI.

•

 measured RF OUT power (dBm) —

measured RF OUT power specifies the power measured at the frequency indicated by the
frequency to measure parameter in the niRFSG 5611 Configure Impairment Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 impairment calibration complete —

impairment calibration complete indicates whether or not the impairment calibration is
successful. If impairment calibration complete returns a value of TRUE, impairment calibration
is successfully complete.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Initialize RF Gain Calibration VI
niRFSG 5611 Initialize RF Gain Calibration VI

Generates external calibration constants for calibrating the RF gain.

Supported Devices: PXIe-5611, PXIe-5673/5673E

© National Instruments 175

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 filter to calibrate —

filter to calibrate specifies which filter to calibrate. The default value is All Filters. If you choose
not to calibrate all filters, you must repeat the entire adjustment procedure on all eight filters to
complete a full calibration.

All Filters
LoFreqMod226
LoFreqMod300
LoFreqMod442
LoFreqMod709
LoFreqMod1221
LoFreqMod2500
LoFreqMod4000
HiFreqMod

Specifies all filters.
Specifies the LoFreqMod226 filter.
Specifies the LoFreqMod300 filter.
Specifies the LoFreqMod442 filter.
Specifies the LoFreqMod709 filter.
Specifies the LoFreqMod1221 filter.
Specifies the LoFreqMod2500 filter.
Specifies the LoFreqMod4000 filter.
Specifies the HiFreqMod filter.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5611 Configure RF Gain Calibration VI
niRFSG 5611 Configure RF Gain Calibration VI

Configures the device for the next RF gain calibration point and waits for the output

176 ni.com

signal to settle.

Supported Devices: PXIe-5611, PXIe-5673/5673E

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 instrument transition power (dBm) —

instrument transition power specifies the approximate bottom of the power meter's range
where it becomes either too slow or too inaccurate.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

 spectrum analyzer reference level (dBm) —

spectrum analyzer reference level returns the value at which to set the spectrum analyzer
reference level.

•

 measurement instrument —

measurement instrument specifies the instrument(s) to use for measuring the output power.

Power Meter (default)
Power Meter & Spectrum Analyzer

Specifies the power meter.
Specifies the power meter and spectrum analyzer.

© National Instruments 177

NI-RFSG

Spectrum Analyzer

Specifies the spectrum analyzer.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 external LO settings —

external LO settings indicates the options to set if an LO source is used instead of the PXI/
PXIe-5652.

•

•

 LO In Frequency (Hz) —

LO In Frequency indicates the tone frequency to generate with the LO source.

 LO In Power (dBm) —

LO In Power indicates the output power to generate with the LO source.

•

 external AWG settings —

external AWG settings indicates the options to set if an arbitrary waveform generator (AWG) is
used instead of the PXIe-5450.

•

•

•

 Offset Frequency (Hz) —

Offset Frequency indicates the tone frequency to generate with the AWG.

 Power (dBm) —

Power indicates the output power to generate with the AWG.

 Impairments —

Impairments indicates the properties to apply to the I/Q signal to achieve desirable
calibration results.

178 ni.com

NI-RFSG

•

•

•

•

 I Offset (V) —

I Offset specifies the DC offset to generate on the I signal.

 Q Offset (V) —

Q Offset specifies the DC offset to generate on the Q signal.

 Gain Imb (I/Q) —

Gain Imb specifies the power ratio (I power / Q power) to generate.

 Qtr Skew (°) —

Qtr Skew specifies the adjustment of the phase angle between the I and Q vectors. If
the skew is zero, the phase angle is 90 degrees.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5611 Adjust RF Gain Calibration VI
niRFSG 5611 Adjust RF Gain Calibration VI

Calculates calibration information pertaining to the RF gain of the device based on
user-supplied measurements. The calibration information is stored in the driver
session and can later be written to the device.

Supported Devices: PXIe-5611, PXIe-5673/5673E

Inputs/Outputs

•

 instrument handle —

© National Instruments 179

NI-RFSG

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 power meter measurement (dBm) —

power meter measurement specifies the measurement read from the power meter after it has
been compensated for splitter loss and cable loss between the PXIe-5611 RF OUT front panel
connector and the power meter.

power meter measurement is ignored if the power meter is not specified by the measurement
instrument output of the niRFSG 5611 Configure RF Gain Calibration VI.

•

 spectrum analyzer measurement (dBm) —

spectrum analyzer measurement specifies the measurement read from the spectrum analyzer.
No compensation is required for this parameter.

spectrum analyzer measurement is ignored if the spectrum analyzer is not specified by the
measurement instrument output of the niRFSG 5611 Configure RF Gain Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 RF gain calibration complete —

RF gain calibration complete specifies whether or not RF gain calibration is complete. If RF gain
calibration complete returns a value of TRUE, RF calibration is successful.

•

 error out —

error out contains error information. This output provides standard error out functionality.

180 ni.com

NI PXIe-5653 Calibration
NI PXIe-5653 Calibration

Use the NI PXIe-5653 Calibration VIs to calibrate your PXIe-5653 device. Refer to the
calibration procedure for your device for more information about device calibration.

NI-RFSG

niRFSG 5653 Initialize Reference Clock Calibration VI
niRFSG 5653 Initialize Reference Clock Calibration VI

Generates external calibration constants for calibrating the 10 MHz OCXO reference.

Supported Devices: PXIe-5653

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

© National Instruments 181

niRFSG 5653 Configure Reference Clock Calibration VI
niRFSG 5653 Configure Reference Clock Calibration VI

Configures the PXIe-5653 with specific settings for calibrating the 10 MHz reference.

Supported Devices: PXIe-5653

NI-RFSG

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 spectrum analyzer reference level (dBm) —

spectrum analyzer reference level returns the value at which to set the spectrum analyzer
reference level.

•

 spectrum analyzer center frequency (Hz) —

spectrum analyzer center frequency returns the value at which to set the spectrum analyzer
center frequency.

•

 error out —

error out contains error information. This output provides standard error out functionality.

182 ni.com

NI-RFSG

niRFSG 5653 Adjust Reference Clock Calibration VI
niRFSG 5653 Adjust Reference Clock Calibration VI

Calculates the PXIe-5653 10 MHz reference calibration information. This calculation is
based on user-supplied measurements. The calibration information is stored in the
driver session, and you can later write this information to the device.

Supported Devices: PXIe-5653

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured REF OUT frequency peak (Hz) —

measured REF OUT frequency peak specifies the frequency measured at the 10 MHz REF OUT
front panel connector.

•

 measured REF OUT power (dBm) —

measured REF OUT power specifies the power measured at the frequency indicated by the
measured REF OUT frequency peak input.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 reference clock calibration complete —

© National Instruments 183

NI-RFSG

reference clock calibration complete indicates whether the Reference Clock calibration is
complete.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5653 Initialize YIG Frequency Calibration VI
niRFSG 5653 Initialize YIG Frequency Calibration VI

Generates external calibration constants for calibrating the YIG frequency.

Supported Devices: PXIe-5653

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

184 ni.com

niRFSG 5653 Configure YIG Frequency Calibration VI
niRFSG 5653 Configure YIG Frequency Calibration VI

Configures the PXIe-5653 with specific settings for calibrating the YIG frequency.

Supported Devices: PXIe-5653

NI-RFSG

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 spectrum analyzer frequency span (Hz) —

spectrum analyzer center frequency span returns the value at which to set the spectrum
analyzer center frequency span.

•

 spectrum analyzer center frequency (Hz) —

spectrum analyzer center frequency returns the value at which to set the spectrum analyzer
center frequency.

•

 error out —

error out contains error information. This output provides standard error out functionality.

© National Instruments 185

NI-RFSG

niRFSG 5653 Adjust YIG Frequency Calibration VI
niRFSG 5653 Adjust YIG Frequency Calibration VI

Calculates the PXIe-5653 YIG frequency calibration information. This calculation is
based on user-supplied measurements. The calibration information is stored in the
driver session, and you can later write this information to the device.

Supported Devices: PXIe-5653

Inputs/Outputs

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured LO1 frequency (Hz) —

measured LO1 frequency specifies the frequency measured by the spectrum analyzer.

 measured LO1 power (dBm) —

measured LO1 power specifies the power measured at the frequency indicated by the measured
LO1 frequency parameter.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 YIG frequency calibration complete —

186 ni.com

NI-RFSG

YIG frequency calibration complete indicates whether the YIG frequency calibration is
complete.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5653 Initialize LO Gain Calibration VI
niRFSG 5653 Initialize LO Gain Calibration VI

Generates external calibration constants for calibrating one of the three LO gains.
Specify the LO output to calibrate using the LO to Calibrate input.

Supported Devices: PXIe-5653

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 LO to calibrate —

LO to calibrate specifies which filter to calibrate. The default value is LO1.

LO1
LO2
LO3

Specifies the LO1 filter.
Specifies the LO2 filter.
Specifies the LO3 filter.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

© National Instruments 187

NI-RFSG

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5653 Configure LO Gain Calibration VI
niRFSG 5653 Configure LO Gain Calibration VI

Configures the PXIe-5653 for the next LO gain calibration point and waits for the output
signal to settle.

Supported Devices: PXIe-5653

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 calibration frequency (Hz) —

188 ni.com

NI-RFSG

calibration frequency returns the frequency at which the power is calibrated.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5653 Adjust LO Gain Calibration VI
niRFSG 5653 Adjust LO Gain Calibration VI

Calculates the PXIe-5653 LO gain calibration information. This calculation is based on
user-supplied measurements. The calibration information is stored in the driver
session, and you can later write this information to the device.

Supported Devices: PXIe-5653

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured LO power (dBm) —

measured LO power specifies the power measured at the frequency indicated by the calibration
frequency output of the niRFSG 5653 Configure LO Gain Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

© National Instruments 189

NI-RFSG

•

•

 LO gain calibration complete —

LO gain calibration complete indicates whether the LO gain calibration is complete.

 error out —

error out contains error information. This output provides standard error out functionality.

NI 5652 Calibration
NI 5652 Calibration

Use the NI 5652 Calibration VIs to calibrate your PXI/PXIe-5650/5651/5652 device. Refer
to the calibration procedure for your device for more information about device
calibration.

niRFSG 5652 Initialize ALC Calibration VI
niRFSG 5652 Initialize ALC Calibration VI

Generates external calibration constants for calibrating the automatic leveling control
(ALC).

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 measurement range —

measurement range specifies the measurement range to calibrate.

190 ni.com

NI-RFSG

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5652 Configure ALC Calibration VI
niRFSG 5652 Configure ALC Calibration VI

Configures the PXI/PXIe-5650/5651/5652 for the next automatic leveling control (ALC)
calibration point and waits for the output signal to settle.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

 instrument handle out —

© National Instruments 191

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

•

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5652 Adjust ALC Calibration VI
niRFSG 5652 Adjust ALC Calibration VI

Calculates calibration information pertaining to the ALC of the PXI/PXIe-5650/5651/
5652. This calculation is based on user-supplied measurements. The calibration
information is stored in the driver session, and you can later write this information to
the device.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured RF OUT power (dBm) —

measured RF OUT power specifies the power measured at the frequency indicated by the
frequency to measure output of the niRFSG 5652 Configure ALC Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless

192 ni.com

NI-RFSG

of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 ALC calibration complete —

ALC calibration complete indicates whether the ALC calibration is complete.

 error out —

•

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5652 Initialize Attenuator Calibration VI
niRFSG 5652 Initialize Attenuator Calibration VI

Generates external calibration constants for calibrating the attenuator.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

•

 measurement range —

measurement range specifies the measurement range to calibrate.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no

© National Instruments 193

NI-RFSG

error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5652 Configure Attenuator Calibration VI
niRFSG 5652 Configure Attenuator Calibration VI

Configures the PXI/PXIe-5650/5651/5652 for the next attenuator calibration point and
waits for the output signal to settle.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

 instrument handle out —

194 ni.com

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

•

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5652 Adjust Attenuator Calibration VI
niRFSG 5652 Adjust Attenuator Calibration VI

Calculates calibration information pertaining to the selected attenuator on the PXI/
PXIe-5650/5651/5652. This calculation is based on user-supplied measurements. The
calibration information is stored in the driver session, and you can later write this
information to the device.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured RF OUT power (dBm) —

measured RF OUT power specifies the power measured at the frequency indicated by the
frequency to measure output of the niRFSG 5652 Configure Attenuator Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless

© National Instruments 195

NI-RFSG

of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 attenuator calibration complete —

attenuator calibration complete indicates whether the attenuator calibration is complete.

 error out —

•

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5652 Validate ALC Limits Table VI
niRFSG 5652 Validate ALC Limits Table VI

Validates the PXI/PXIe-5650/5651/5652 ALC limits table, which determines the
attenuator and path NI-RFSG uses for each frequency and power combination.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

196 ni.com

NI-RFSG

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 ALC poly range data present? —

ALC poly range data present? indicates whether the ALC poly range data is present on the device
EEPROM. If the ALC poly range data is not present, this VI cannot validate the ALC limits table.
The ALC poly range data was added to the EEPROM in NI-RFSG 15.0.3, so this parameter returns a
value of FALSE if the device was last calibrated using an earlier version of NI-RFSG.

•

 invalid limits —

invalid limits returns the invalid limits in the ALC limits table. If the ALC limits table is valid, this
parameter is empty. If the ALC limits table is invalid, this parameter returns the invalid limits and
corresponding invalid frequencies.

•

•

 limit name —

 frequencies where invalid —

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5652 Initialize Reference Clock Calibration VI
niRFSG 5652 Initialize Reference Clock Calibration VI

Generates external calibration constants for calibrating the 10 MHz reference.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

© National Instruments 197

NI-RFSG

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5652 Configure Reference Clock Calibration VI
niRFSG 5652 Configure Reference Clock Calibration VI

Configures the PXI/PXIe-5650/5651/5652 with specific settings for calibrating the 10
MHz OCXO reference.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no

198 ni.com

NI-RFSG

error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 center frequency (Hz) —

center frequency returns the value at which to set the spectrum analyzer center frequency.

 frequency span (Hz) —

frequency span returns the value at which to set the spectrum analyzer frequency span.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

•

•

niRFSG 5652 Adjust Reference Clock Calibration VI
niRFSG 5652 Adjust Reference Clock Calibration VI

Calculates calibration information pertaining to the 10 MHz OCXO reference of the PXI/
PXIe-5650/5651/5652. This calculation is based on user-supplied measurements. The
calibration information is stored in the driver session, and you can later write this
information to the device.

Supported Devices: PXI/PXIe-5650/5651/5652

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session.

© National Instruments 199

NI-RFSG

•

 measured REF OUT frequency (Hz) —

measured REF OUT frequency specifies the frequency measured at the REF OUT front panel
connector.

•

 measured REF OUT power (dBm) —

measured REF OUT power specifies the power measured at the frequency indicated by the
measured REF OUT frequency input.

•

 error in (no error) —

error in(no error) describes error conditions that occur before this node runs. The default is no
error. This node does not pass the error in(no error) input to the error out output. Regardless
of whether an error occurred before this node runs, the node returns no error.

This input contains status, code, and source, which provide standard error in functionality.

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 reference clock calibration complete —

reference clock calibration complete indicates whether the Reference Clock calibration is
complete.

•

 error out —

error out contains error information. This output provides standard error out functionality.

NI PXIe-5654 Calibration
NI PXIe-5654 Calibration

Use the NI PXIe-5654 Calibration VIs to calibrate your PXIe-5654 device. Refer to the
calibration procedure for your device for more information about device calibration.

200 ni.com

niRFSG 5654 Power Cal Initialize VI
niRFSG 5654 Power Cal Initialize VI

Prepares the device for calibrating the power.

Supported Devices: PXIe-5654

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5654 Power Cal Configure VI
niRFSG 5654 Power Cal Configure VI

Configures the PXIe-5654 for the next power calibration point and waits for the output
signal to settle.

Supported Devices: PXIe-5654

© National Instruments 201

NI-RFSG

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5654 Power Cal Adjust VI
niRFSG 5654 Power Cal Adjust VI

Calculates calibration information pertaining to the RF output power on the PXIe-5654.
This calculation is based on user-supplied measurements. The calibration information
is stored in the driver session, and you can later write this information to the device.

Supported Devices: PXIe-5654

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session.

202 ni.com

NI-RFSG

•

 measured power (dBm) —

measured power specifies the power measured at the frequency indicated by the niRFSG 5654
Power Cal Configure VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 power calibration complete —

power calibration complete indicates whether the power calibration is complete.

 error out —

•

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5654 OCXO Cal Initialize VI
niRFSG 5654 OCXO Cal Initialize VI

Prepares the device for calibrating the 100 MHz oven-controlled crystal oscillator
(OCXO) reference.

Supported Devices: PXIe-5654

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 error in —

© National Instruments 203

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5654 OCXO Cal Configure VI
niRFSG 5654 OCXO Cal Configure VI

Configures the PXIe-5654 with specific settings for calibrating the 100 MHz oven-
controlled crystal oscillator (OCXO) reference.

Supported Devices: PXIe-5654

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

204 ni.com

NI-RFSG

niRFSG 5654 OCXO Cal Adjust VI
niRFSG 5654 OCXO Cal Adjust VI

Calculates calibration information pertaining to the 100 MHz oven-controlled crystal
oscillator (OCXO) reference of the PXIe-5654. This calculation is based on user-supplied
measurements. The calibration information is stored in the driver session, and you can
later write this information to the device.

Supported Devices: PXIe-5654

Inputs/Outputs

•

•

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured frequency (Hz) —

measured frequency specifies the measured frequency, in hertz.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 OCXO calibration complete —

OCXO calibration complete indicates whether the OCXO calibration is complete.

 error out —

error out contains error information. This output provides standard error out functionality.

© National Instruments 205

NI PXIe-5696 Calibration
NI PXIe-5696 Calibration

Use the NI PXIe-5696 Calibration VIs to calibrate your PXIe-5696 device. Refer to the
calibration procedure for your device for more information about device calibration.

NI-RFSG

niRFSG 5696 Attenuator Path Cal Initialize VI
niRFSG 5696 Attenuator Path Cal Initialize VI

Prepares the device for calibrating the attenuator path.

Supported Devices: PXIe-5696

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 NI 5654 resource name —

NI 5654 resource name specifies the resource name of the PXIe-5654 RF signal generator to
initialize.

•

 measurement port —

measurement port specifies the port that the power meter is connected to. To reduce error, the
calibration procedure measures the PXIe-5696 input power as well as the PXIe-5696 output
power.

Input Power
Output Power

Specifies the PXIe-5696 input power.
Specifies the PXIe-5696 output power.

206 ni.com

NI-RFSG

•

 input power file —

input power file specifies the file where the input power measurements are stored. This file is
written when you set measurement port to Input Power. This file is read when you set
measurement port to Output Power.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 Attenuator Path Cal Configure VI
niRFSG 5696 Attenuator Path Cal Configure VI

Configures the PXIe-5696 for the next attenuator path calibration point and waits for
the output signal to settle.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

© National Instruments 207

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

•

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 Attenuator Path Cal Adjust VI
niRFSG 5696 Attenuator Path Cal Adjust VI

Calculates calibration information pertaining to the attenuator path on the PXIe-5696.
This calculation is based on user-supplied measurements. The calibration information
is stored in the driver session, and you can later write this information to the device.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured power (dBm) —

measured power specifies the power measured at the frequency indicated by the niRFSG 5696
Attenuator Path Cal Configure VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

208 ni.com

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

 attenuator calibration complete —

attenuator calibration complete indicates whether the attenuator calibration is complete.

 error out —

•

•

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 Attenuator Cal Initialize VI
niRFSG 5696 Attenuator Cal Initialize VI

Prepares the device for calibrating the attenuator.

Supported Devices: PXIe-5696

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 NI 5654 resource name —

NI 5654 resource name specifies the resource name of the PXIe-5654 RF signal generator to
initialize.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

© National Instruments 209

•

 error out —

error out contains error information. This output provides standard error out functionality.

NI-RFSG

niRFSG 5696 Attenuator Cal Configure VI
niRFSG 5696 Attenuator Cal Configure VI

Configures the PXIe-5696 for the next attenuator calibration point and waits for the
output signal to settle.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

210 ni.com

NI-RFSG

niRFSG 5696 Attenuator Cal Adjust VI
niRFSG 5696 Attenuator Cal Adjust VI

Calculates calibration information pertaining to the selected attenuator on the
PXIe-5696. This calculation is based on user-supplied measurements. The calibration
information is stored in the driver session, and you can later write this information to
the device.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured power (dBm) —

measured power specifies the power measured at the frequency indicated by the niRFSG 5696
Attenuator Cal Configure VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 attenuator calibration complete —

attenuator calibration complete indicates whether the attenuator calibration is complete.

 error out —

•

•

•

error out contains error information. This output provides standard error out functionality.

© National Instruments 211

niRFSG 5696 Amplifier Cal Initialize VI
niRFSG 5696 Amplifier Cal Initialize VI

Prepares the device for calibrating the amplifier.

Supported Devices: PXIe-5696

NI-RFSG

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 NI 5654 resource name —

NI 5654 resource name specifies the resource name of the PXIe-5654 RF signal generator to
initialize.

•

 path to calibrate —

path to calibrate specifies which amplifier path to calibrate.

High Power
Low Harmonic

Specifies the high power path.
Specifies the low harmonic path.

•

 measurement port —

measurement port specifies the port that the power meter is connected to. To reduce error, the
calibration procedure measures the PXIe-5696 input power as well as the PXIe-5696 output
power.

Input Power
Output Power

Specifies the PXIe-5696 input power.
Specifies the PXIe-5696 output power.

•

 error in —

212 ni.com

NI-RFSG

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 input power file —

input power file specifies the file where the input power measurements are stored. This file is
written when you set measurement port to Input Power. This file is read when you set
measurement port to Output Power.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 error out —

error out contains error information. This output provides standard error out functionality.

•

•

niRFSG 5696 Amplifier Cal Configure VI
niRFSG 5696 Amplifier Cal Configure VI

Configures the PXIe-5696 for the next amplifier calibration point and waits for the
output signal to settle.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

© National Instruments 213

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

•

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 Amplifier Cal Adjust VI
niRFSG 5696 Amplifier Cal Adjust VI

Calculates calibration information pertaining to the selected amplifier on the
PXIe-5696. This calculation is based on user-supplied measurements. The calibration
information is stored in the driver session, and you can later write this information to
the device.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured power (dBm) —

measured power specifies the power measured at the frequency indicated by the niRFSG 5696
Amplifier Cal Configure VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

214 ni.com

NI-RFSG

•

•

•

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 amp calibration complete —

amp calibration complete indicates whether the amplifier calibration is complete.

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 ALC Cal Initialize VI
niRFSG 5696 ALC Cal Initialize VI

Prepares the device for calibrating the automatic leveling control (ALC).

Supported Devices: PXIe-5696

Inputs/Outputs

•

 instrument handle —

instrument handle identifies your instrument calibration session. instrument handle is
obtained from the niRFSG Initialize External Calibration VI.

•

 NI 5654 resource name —

NI 5654 resource name specifies the resource name of the PXIe-5654 RF signal generator to
initialize.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

•

 instrument handle out —

© National Instruments 215

NI-RFSG

instrument handle out passes a reference to your instrument session to the next VI.

•

 error out —

error out contains error information. This output provides standard error out functionality.

niRFSG 5696 ALC Cal Configure VI
niRFSG 5696 ALC Cal Configure VI

Configures the PXIe-5696 for the next automatic leveling control (ALC) calibration point
and waits for the output signal to settle.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 frequency to measure (Hz) —

frequency to measure indicates the frequency of the generated signal. This value is expressed in
hertz. The power of the generated signal should be measured.

•

 error out —

error out contains error information. This output provides standard error out functionality.

216 ni.com

NI-RFSG

niRFSG 5696 ALC Cal Adjust VI
niRFSG 5696 ALC Cal Adjust VI

Calculates calibration information pertaining to the automatic leveling control (ALC) of
the PXIe-5696. This calculation is based on user-supplied measurements. The
calibration information is stored in the driver session, and you can later write this
information to the device.

Supported Devices: PXIe-5696

Inputs/Outputs

•

•

 instrument handle —

instrument handle identifies your instrument calibration session.

 measured power (dBm) —

measured power specifies the power measured at the frequency indicated by the niRFSG 5696
ALC Cal Configure VI.

•

 error in —

error in describes error conditions that occur before this node runs. This input provides
standard error in functionality.

 instrument handle out —

instrument handle out passes a reference to your instrument session to the next VI.

 ALC calibration complete —

ALC calibration complete indicates whether the ALC calibration is complete.

 error out —

•

•

•

error out contains error information. This output provides standard error out functionality.

© National Instruments 217

niRFSG Properties

niRFSG Properties
niRFSG Properties

Use the niRFSG Property Node to get (read) or set (write) NI-RFSG properties. When
you read a property, NI-RFSG analyzes the current configuration to return the coerced
value for that property. NI-RFSG verifies many properties upon reading, thereby either
transitioning the session to the verified state or alerting you of an invalid
configuration. Setting a property transitions the session to an unverified state.

© 2004–2025 National Instruments Corporation. All rights reserved.

Active Channel
Active Channel

Specifies the channel name used to access all subsequent channel-based properties in
this property node. Set the channel before setting channel-based properties.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Active Channel

Write Only

N/A

No

No

Arb:Advanced:Compensate for Filter Group Delay
Arb:Advanced:Compensate for Filter Group Delay

Enables or disables compensation for filter group delay on the AWG module. This
property also accounts for the upconverter group delay and aligns the RF output with

218 ni.com

the Started Event, Done Event, and Marker Events.

At a low I/Q rate, the group delay can become so large that some devices may not be
able to align the events with the RF output, in which case you must increase the I/Q
rate or disable this property.

niRFSG Properties

Supported Devices: PXIe-5672

Default Value: FALSE

TRUE

FALSE

Enables compensation for filter group delay.

Disables compensation for filter group delay.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Compensate for Filter Group Delay

Read/Write

N/A

No

Yes

Arb:Advanced:Digital Gain (dB)
Arb:Advanced:Digital Gain (dB)

Specifies the digital gain, in decibels. The digital gain is applied to the waveform data
after filtering. Use this property to adjust the output power of the device while keeping
the analog path fixed. This may cause clipping, overflows, or quantization noise if used
improperly.

To set this property, the NI-RFSG device must be in the Configuration or Generation
state.

© National Instruments 219

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

niRFSG Properties

Default Value: 0 dB

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Digital Gain (dB)

Read/Write

N/A

No

Yes

Arb:Advanced:Overflow Error Reporting
Arb:Advanced:Overflow Error Reporting

Configures error reporting for onboard signal processing (OSP) overflows. Overflows
lead to clipping of the waveform.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: Warning

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

220 ni.com

Overflow Error Reporting

Read/Write

N/A

No

Resettable

Yes

niRFSG Properties

Warning  1301  NI-RFSG returns a warning when an OSP overflow occurs.

Disabled  1302  NI-RFSG does not return an error or a warning when an OSP overflow occurs.

Arb:Arb Carrier Frequency (Hz)
Arb:Arb Carrier Frequency (Hz)

Indicates the carrier frequency generated by the AWG module.

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/
5673E, PXIe-5830/5831/5832/5840/5841/5842/5860

The specified carrier frequency is related to the RF output as shown in the following
equations:

Device

Equation

PXI-5610, PXI-5670/5671,
PXIe-5672

RF Frequency = Upconverter Center Frequency + Arb Carrier Frequency -
25 MHz

RF Frequency = Upconverter Center Frequency + Arb Carrier Frequency

PXIe-5644/5645/5646,
PXIe-5673/5673E,
PXIe-5830/5831/5832/
5840/5841/5842

Note The Upconverter Center Frequency (Hz) property and
this property cannot be set at the same time. The only time
the carrier frequency is non-zero on these devices is when in-
band retuning is used.

Note Use this property to associate a carrier frequency with a waveform.

Note This property is read-only on the PXI-5670/5671 and PXIe-5672.

Related Topics

© National Instruments 221

niRFSG Properties

Assigning Properties or Attributes to a Waveform—Refer to this topic for more
information about using this property to associate a carrier frequency with a
waveform.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Arb Carrier Frequency (Hz)

Read/Write

N/A

No

Yes

Arb:Arb Power (dBm)
Arb:Arb Power (dBm)

Indicates the average output power from the PXI-5421, PXI-5441, PXIe-5442, and
PXIe-5450 AWG modules. If an arbitrary waveform is being generated, this property
specifies either the average power or the peak power of the signal, depending on the
Power Level Type property setting.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

222 ni.com

Arb Power (dBm)

Read Only

N/A

No

niRFSG Properties

Resettable

No

Arb:Data Transfer:Advanced:Host DMA Buffer Size
Arb:Data Transfer:Advanced:Host DMA Buffer Size

Specifies the size of the DMA buffer in computer memory, in bytes. To set this property,
the NI-RFSG device must be in the Configuration state.

A sufficiently large host DMA buffer improves performance by allowing large writes to
be transferred more efficiently.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: 8 MB

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Host DMA Buffer Size

Read/Write

N/A

Yes

Yes

Arb:Data Transfer:Advanced:Maximum In-Flight Read Requests
Arb:Data Transfer:Advanced:Maximum In-Flight Read Requests

Specifies the maximum number of concurrent PCI Express read requests the RF signal
generator can issue.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

When transferring data from computer memory to device onboard memory across the
PCI Express bus, the RF signal generator can issue multiple memory reads at the same
time. In general, the larger the number of read requests, the more efficiently the device

© National Instruments 223

niRFSG Properties

uses the bus because the multiple read requests keep the data flowing, even in a PCI
Express topology that has high latency due to PCI Express switches in the data path.
Most NI devices can issue a large number of read requests (typically 8 or 16). By
default, this property is set to the highest value the RF signal generator supports.

If other devices in your system cannot tolerate long data latencies, it may be helpful to
decrease the number of in-flight read requests the RF signal generator issues. This
change helps to reduce the amount of data the signal generator reads at one time.

Related Topics

Improving Streaming Performance

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Maximum In-Flight Read Requests

Read/Write

N/A

No

Yes

Arb:Data Transfer:Advanced:Preferred Packet Size
Arb:Data Transfer:Advanced:Preferred Packet Size

Specifies the preferred size of the data field in a PCI Express read request packet.

In general, the larger the packet size, the more efficiently the device uses the bus. By
default, RF signal generators use the largest packet size allowed by the system.
However, due to different system implementations, some systems may perform better
with smaller packet sizes.

Recommended values for this property are powers of two between 64 and 512.

224 ni.com

niRFSG Properties

Note In some cases, the RF signal generator generates packets smaller than
the preferred size you set with this property.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

Related Topics

Improving Streaming Performance

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Preferred Packet Size

Read/Write

N/A

No

Yes

Arb:Data Transfer:Data Transfer Block Size
Arb:Data Transfer:Data Transfer Block Size

Indicates the number of samples at a time to download to onboard memory. This
property is useful when the total data to be transferred to onboard memory is large.

Supported Devices: PXIe-5672/5673/5673E

Default Value: 1 MS

Remarks

The following table lists the characteristics of this property.

Short Name

Data Transfer Block Size

© National Instruments 225

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

Yes

Arb:Data Transfer:Direct Download
Arb:Data Transfer:Direct Download

Specifies whether the niRFSG Write Arb Waveform VI immediately writes waveforms to
the device or copies the waveform to host memory for later download. NI-RFSG reads
and validates this property when an arbitrary waveform is first allocated.

For the PXI-5670, direct download is always disabled. For all other devices, direct
download is always enabled.

PXI-5671: To increase performance when using large waveforms, enable direct
download. To maximize reconfigurability, disable direct download.

Perform the following steps to enable direct download:

1.  Set the I/Q rate to less than or equal to 8.33 MS/s with the IQ Rate property.
2.  Set the Power Level Type property to Peak Power.
3.  Disable the IQ Swap Enabled property.
4.  Disable the Digital Equalization Enabled property.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

226 ni.com

Direct Download

Read/Write

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

Yes

Disable

Enable

0

1

Disables direct download.

Enables direct download.

Arb:Data Transfer:Maximum Bandwidth
Arb:Data Transfer:Maximum Bandwidth

Specifies the maximum amount of bus bandwidth to use for data transfers.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

Related Topics

Improving Streaming Performance

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Maximum Bandwidth

Read/Write

N/A

No

Yes

© National Instruments 227

niRFSG Properties

Arb:Data Transfer:Streaming:Space Available In Streaming Waveform (Samples)
Arb:Data Transfer:Streaming:Space Available In Streaming Waveform (Samples)

Indicates the space available, in samples, in the streaming waveform for writing new
data. For optimal performance, write new data to the waveform in a fixed size that is
an integer divisor of the total size of the streaming waveform. This waveform size
ensures that writes do not have to wrap around from the end to the beginning of the
waveform buffer.

To read this property, the NI-RFSG device must be in the Committed state.

Supported Devices: PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Related Topics

Streaming

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

SpaceAvailInStreamingWfm

Read Only

N/A

No

No

Arb:Data Transfer:Streaming:Streaming Enabled
Arb:Data Transfer:Streaming:Streaming Enabled

Enables or disables continuous streaming of waveform data.

Supported Devices: PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Default Value: Disabled

228 ni.com

niRFSG Properties

Enables streaming.

Disables streaming.

Enabled

Disabled

Related Topics

Streaming

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Streaming Enabled

Read/Write

N/A

No

Yes

Arb:Data Transfer:Streaming:Streaming Waveform Name
Arb:Data Transfer:Streaming:Streaming Waveform Name

Specifies the name of the waveform used to continuously stream data during
generation.

Supported Devices: PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Default Value: "" (empty string)

Related Topics

Streaming

Streaming Waveform Data

© National Instruments 229

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Streaming Waveform Name

Read/Write

N/A

No

Yes

Arb:Data Transfer:Streaming:Streaming Write Timeout
Arb:Data Transfer:Streaming:Streaming Write Timeout

Indicates the maximum amount of time allowed to complete a streaming write
operation.

Supported Devices: PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Default Value: 10.0 seconds

Remarks

The following table lists the characteristics of this property.

Streaming Write Timeout

Read/Write

N/A

No

Yes

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

230 ni.com

niRFSG Properties

Arb:Device Instantaneous Bandwidth (Hz)
Arb:Device Instantaneous Bandwidth (Hz)

Specifies the instantaneous bandwidth of the device. The instantaneous bandwidth is
the effective real-time bandwidth of the signal path for your configuration.

The signal bandwidth, centered at the RF frequency, must fit within the device
instantaneous bandwidth, which is centered at the upconverter center frequency.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

PXIe-5830 Frequency and Bandwidth Selection

PXIe-5831/5832 Frequency and Bandwidth Selection

PXIe-5841 Frequency and Bandwidth Selection

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Device Instantaneous Bandwidth (Hz)

Read/Write

N/A

Yes

Yes

Arb:Digital Equalization Enabled
Arb:Digital Equalization Enabled

When this property is enabled, NI-RFSG equalizes the waveform data to correct for
variations in the response of the NI-RFSG device. Enabling digital equalization
improves the modulation error ratio (MER) and error vector magnitude (EVM) for
signals with large bandwidths (>500 kHz), but it increases tuning times.

© National Instruments 231

niRFSG Properties

This property only applies when the Generation Mode property is set to Arb Waveform
or Script. To set this property, the NI-RFSG device must be in the Configuration state.

On the PXI-5670/5671, equalization is performed in the software, so tuning time is
increased. On the PXIe-5672, equalization is performed in the hardware so that there is
no compromise in performance.

PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842/5860: Enable is the
only supported value for this device.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672, PXIe-5820/5830/
5831/5832/5840/5841/5842/5860

Default Values:

PXI-5670/5671: Disable

PXIe-5644/5645/5646, PXIe-5672, PXIe-5820/5830/5831/5832/5840/5841/5842/5860:
Enable

Related Topics

Response and Software Equalization—Refer to this topic for more information about
equalization performed in the software.

Frequency Tuning Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

232 ni.com

Digital Equalization Enabled

Read/Write

N/A

No

niRFSG Properties

Resettable

Yes

Disable

0

Disables digital equalization.

Enable

1

Enables digital equalization.

Arb:Digital Pattern
Arb:Digital Pattern

Enables or disables digital pattern on the PXI-5421/5441 AWG module. This property
must be set to TRUE to enable signal routing to and from the Digital Data & Control
connector.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXI-5670/5671

Default Value: FALSE

Enables signal routing.

Disables signal routing.

TRUE

FALSE

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Digital Pattern

Read/Write

N/A

No

Yes

© National Instruments 233

niRFSG Properties

Arb:Generation Mode
Arb:Generation Mode

Specifies whether to generate a continuous wave (CW) signal, the arbitrary waveform
specified by the Selected Waveform property, or the script specified by the Selected
Script property, upon calling the niRFSG Initiate VI.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696 (CW support only), PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: CW

Related Topics

Assigning Properties or Attributes to a Waveform

Scripting Instructions

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Generation Mode

Read/Write

niRFSG Configure Generation Mode

No

Yes

CW

1000  Configures the RF signal generator to generate a CW signal.

234 ni.com

niRFSG Properties

Arb
Waveform

1001  Configures the RF signal generator to generate arbitrary waveforms.

Script

1002

Configures the RF signal generator to generate arbitrary waveforms as directed
by scripts.

Arb:IQ Rate (S/s)
Arb:IQ Rate (S/s)

This property specifies the I/Q rate of the arbitrary waveform. The I/Q rate is coerced to
a value the hardware can achieve. Read this value back after setting it to see the actual
I/Q rate. NI-RFSG internally uses an FIR filter with flat response up to (0.4 Ã— IQ rate).
Given a desired signal with the maximum frequency content f, sample the signal at an
I/Q rate greater than or equal to (f/0.4).

This property only applies when the Generation Mode property is set to Arb Waveform
or Script.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

The following table lists available I/Q rates.

Device

Available Rates

PXIe-5644/5645

Up to 120 MS/s.

PXIe-5646

PXI-5670

PXI-5671

Up to 250 MS/s.

50 MS/s, 100 MS/s

50 MS/s, 100 MS/s, and (100 MS/s)/n, where n is divisible by 2 between 12
to 512, and divisible by 4 between 512 to 1,024 (n = 12,14,16, ...,512, 516,
520, ...,1024). Setting the I/Q rate to one of these values enables the DUC.

PXIe-5672

Up to 100 MS/s.

PXIe-5673/5673E

Up to 200 MS/s.

© National Instruments 235

Device

Available Rates

niRFSG Properties

Note If an PXIe-5450 with module revisions A or B is used as
part of your PXIe-5673/5673E, the NI-FGEN Compensate for
Filter Group Delay property is disabled if the requested I/Q
rate is less than 1.5 MS/s.

PXIe-5820/5830/5831/
5832/5840/5841/5860

PXI-5842 (500 MHz, 1
GHz, and 2 GHz
bandwidth options)

PXIe-5842 (4 GHz
bandwidth option)
using the Standard
personality

PXIe-5842 (4 GHz
bandwidth option)
using the 4 GHz
Bandwidth personality

Up to 1.25 GS/s.

Up to 2.5 GS/s.

Up to 2.5 GS/s.

5 GS/s only.

Setting this property to 50 MS/s on the PXI-5670/5671, PXIe-5672 has the following
implications:

•  The NI-RFSG driver is forced to place the carrier frequency at 18 MHz Â± 1 MHz to
avoid aliasing. Forcing the carrier frequency to that point implies that NI-RFSG
does not have the freedom to pick a carrier frequency that could optimize the
waveform size if phase continuity is enabled.

•  Output signal bandwidth must be less than 5 MHz to avoid aliasing.
•  Close-in phase noise is higher.

Note Use this property to associate an I/Q rate with a waveform.

Related Topics

Streaming

236 ni.com

Assigning Properties or Attributes to a Waveform—Refer to this topic for more
information about using this property to associate an I/Q rate with a waveform.

niRFSG Properties

Digital Upconverter

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Rate (S/s)

Read/Write

niRFSG Write Arb Waveform

No

Yes

Arb:IQ Swap Enabled
Arb:IQ Swap Enabled

Enables or disables the inverse phase rotation of the I/Q signal by swapping the I and
Q inputs.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842

Default Value: FALSE

TRUE

Applies noninverse phase rotation of the I/Q signal.

FALSE

Applies inverse phase rotation of the I/Q signal.

Remarks

The following table lists the characteristics of this property.

© National Instruments 237

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Swap Enabled

Read/Write

N/A

No

Yes

Arb:Memory Size
Arb:Memory Size

The total amount of memory on the RF signal generator in bytes.

Note Not all onboard memory can be used for waveform storage. A portion
of onboard memory stores scripts that specify how the waveforms are
generated. These scripts typically require less than 1 KB of onboard memory.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Memory Options

Phase Continuity

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

238 ni.com

Memory Size

Read Only

N/A

niRFSG Properties

Channel-based

Resettable

No

No

Arb:Phase Continuity Enabled
Arb:Phase Continuity Enabled

Specifies whether the driver maintains phase continuity in the arbitrary waveforms.
When this property is set to Enable, NI-RFSG may increase the waveform size, and the
Frequency Tolerance (Hz) property specifies the maximum allowable frequency error
that can be introduced when keeping the signal phase-continuous. To set the Phase
Continuity Enabled property, the NI-RFSG device must be in the Configuration state.
This property only applies when the Generation Mode property is set to Arb Waveform
or Script.

PXI-5671: When using the PXI-5671 with I/Q rates less than or equal to 8.33 MS/s, an
input phase-continuous signal is always phase-continuous upon output, and this
property has no effect.

PXIe-5644/5645/5646, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860: Phase continuity is always enabled on these devices.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

The following table describes the Phase Continuity Enabled property settings with I/Q
rates greater than 8.33 MS/s.

Related Topics

Phase Continuity

Arb Waveform Mode Tuning Speed Factors

Remarks

The following table lists the characteristics of this property.

Short Name

Phase Continuity Enabled

© National Instruments 239

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

Yes

When the Generation Mode property is set to Arb Waveform, the arbitrary waveform
may be repeated to ensure phase continuity after upconversion. This setting could
cause waveform size to increase.

Auto

-1

When the Generation Mode property is set to Script, the Phase Continuity Enabled
property indicates a warning condition. NI-RFSG cannot guarantee a phase-
continuous output signal in Script mode. Phase continuity is automatically disabled in
script mode, and the arbitrary waveform plays back without regard to any possible
phase discontinuities introduced by upconversion.

Disable  0

Enable  1

When the Generation Mode property is set to Arb Waveform, the arbitrary waveform is
played back without regard to any possible phase discontinuities introduced by
upconversion. The time duration of the original waveform is maintained.

When the Generation Mode property is set to Script, the arbitrary waveform plays back
without regard to any possible phase discontinuities introduced by upconversion. The
time duration of the original waveform is maintained.

When the Generation Mode property is set to Arb Waveform, the arbitrary waveform
may be repeated to ensure phase continuity after upconversion. Enabling this
property could cause waveform size to increase.

When the Generation Mode property is set to Script, the arbitrary waveform plays back
without regard to any possible phase discontinuities introduced by upconversion. The
time duration of the original waveform is maintained.

240 ni.com

niRFSG Properties

Arb:Pre-filter Gain (dB)
Arb:Pre-filter Gain (dB)

Specifies the AWG prefilter gain. The prefilter gain is applied to the waveform data
before any other signal processing. Reduce this value to prevent overflow in the AWG
interpolation filters. Other gains on the NI-RFSG device are automatically adjusted to
compensate for nonunity AWG prefilter gain. The PXI-5671, PXIe-5672, and PXIe-5860
must be in the Configuration state to use this property. However, the PXIe-5644/5645/
5646, PXIe-5673/5673E, and PXIe-5820/5830/5831/5832/5840/5841/5842 can be in
either the Configuration or the Generation state to use this property.

Note On the PXI-5671, this property applies only when the I/Q rate is set to a
value less than or equal to 8.33 MS/s. On the PXIe-5644/5645/5646,
PXIe-5672/5673/5673E, and PXIe-5820/5830/5831/5832/5840/5841/5842/
5860, this property is always applicable.

Supported Devices: PXIe-5644/5645/5646, PXI-5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: 0 dB

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Pre-filter Gain (dB)

Read/Write

N/A

No

Yes

Arb:Pulse Shaping:Filter Type
Arb:Pulse Shaping:Filter Type

Specifies the pulse-shaping filter type for the FIR filter. You can use this property only

© National Instruments 241

with signal generators that support onboard signal processing (OSP). NI-RFSG returns
an error if you use this property with a device that does not support OSP.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

niRFSG Properties

Default Value: None

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Filter Type

Read/Write

N/A

No

Yes

None

10000  No filter type is applied.

Root
Raised
Cosine

10001

Applies a root-raised cosine filter to the data with the alpha value specified
with the Root Raised Cosine Filter Alpha property.

Raised
Cosine

10002

Applies a raised cosine filter to the data with the alpha value specified with the
Raised Cosine Filter Alpha property.

Arb:Pulse Shaping:Raised Cosine Alpha
Arb:Pulse Shaping:Raised Cosine Alpha

Specifies the alpha value to use when calculating the pulse-shaping FIR filter
coefficients. You can use this property only when the Filter Type property is set to
Raised Cosine and with signal generators that support onboard signal processing

242 ni.com

(OSP). NI-RFSG returns an error if you use this property with a device that does not
support OSP.

niRFSG Properties

Supported Devices: PXI-5671, PXIe-5672/5673/5673E

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Raised Cosine Filter Alpha

Read/Write

N/A

No

Yes

Arb:Pulse Shaping:Root Raised Cosine Alpha
Arb:Pulse Shaping:Root Raised Cosine Alpha

Specifies the alpha value to use when calculating the pulse-shaping FIR filter
coefficients. You can use this property only when the Filter Type property is set to Root
Raised Cosine and with signal generators that support onboard signal processing
(OSP). NI-RFSG returns an error if you use this property with a device that does not
support OSP.

Supported Devices: PXI-5671, PXIe-5672/5673/5673E

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Root Raised Cosine Filter Alpha

Read/Write

N/A

© National Instruments 243

niRFSG Properties

Channel-based

Resettable

No

Yes

Arb:Selected Script
Arb:Selected Script

Specifies the script in onboard memory to generate upon calling the niRFSG Initiate VI
when the Generation Mode property is set to Script. The Selected Script property is
ignored when the Generation Mode property is set to Arb Waveform or CW.

To set the Selected Script property, the NI-RFSG device must be in the Configuration
state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Assigning Properties or Attributes to a Waveform

Scripting Instructions

Remarks

The following table lists the characteristics of this property.

Selected Script

Read/Write

N/A

No

Yes

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

244 ni.com

niRFSG Properties

Arb:Signal Bandwidth (Hz)
Arb:Signal Bandwidth (Hz)

Specifies the bandwidth of the arbitrary signal. This value must be less than or equal
to (0.8 Ã— I/Q rate).

NI-RFSG defines signal bandwidth as twice the maximum I/Q signal deviation from 0
Hz. Usually, the baseband signal center frequency is 0 Hz. In such cases, the bandwidth
is simply the I/Q signal's minimum frequency subtracted from its maximum frequency
or f max - f min.

This property applies only when the Generation Mode property is set to Arb Waveform
or Script, except for when using the PXIe-5830/5831/5832/5840/5841/5842/5860, which
supports setting this property in all supported generation modes. To set the Signal
Bandwidth property, the NI-RFSG device must be in the Configuration state.

PXI-5670/5671, PXIe-5672: Based on your signal bandwidth, NI-RFSG decides whether
to configure the upconverter center frequency in increments of 1 MHz or 5 MHz. Failure
to configure this property may result in the signal being placed outside the
upconverter passband.

PXIe-5644/5645/5646, PXIe-5673/5673E: This property is used only for error checking
purposes. Otherwise, this property is ignored.

PXIe-5820/5830/5831/5832/5840/5841/5842/5860: Based on your signal bandwidth, NI-
RFSG decides the equalized bandwidth. If this property is not set, NI-RFSG uses the
maximum available signal bandwidth. For the PXIe-5840/5841/5842/5860, the
maximum allowed signal bandwidth depends on the upconverter center frequency.
Refer to the specifications document for your device for more information about signal
bandwidth. The device specifications depend on the signal bandwidth.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI-5670/5671,
PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Phase-Locked Loop Bandwidth

Frequency Tuning Times

© National Instruments 245

niRFSG Properties

PXIe-5830 Frequency and Bandwidth Selection

PXIe-5831/5832 Frequency and Bandwidth Selection

PXIe-5841 Frequency and Bandwidth Selection

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Signal Bandwidth (Hz)

Read/Write

N/A

No

Yes

Arb:Software Scaling Factor
Arb:Software Scaling Factor

Specifies how much to scale the data before writing it with the niRFSG Write Arb
Waveform VI. The resulting waveform must be smaller than 1.0 in complex magnitude.
This property is supported only if you set the Power Level Type property to Peak
Power.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: 1.0

Related Topics

Spurious Performance

Remarks

The following table lists the characteristics of this property.

246 ni.com

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Software Scaling Factor

Read/Write

N/A

No

Yes

Arb:Waveform Attributes:Waveform IQ Rate (S/s)
Arb:Waveform Attributes:Waveform IQ Rate (S/s)

Specifies the I/Q rate of the waveform. To set this property, the NI-RFSG device must be
in the Configuration state.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Streaming

Assigning Properties or Attributes to a Waveform—Refer to this topic for more
information about using this property to associate an I/Q rate with a waveform.

Digital Upconverter

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform IQ Rate (S/s)

Read/Write

N/A

Yes

No

© National Instruments 247

niRFSG Properties

Arb:Waveform Attributes:Waveform PAPR (dB)
Arb:Waveform Attributes:Waveform PAPR (dB)

Specifies the peak-to-average power ratio (PAPR).

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform PAPR (dB)

Read/Write

N/A

Yes

No

Arb:Waveform Attributes:Waveform RF Blanking
Arb:Waveform Attributes:Waveform RF Blanking

Enables or disables RF blanking.

RF Blanking Source

RF
Blanking

Behaviour

"" (empty string)

Disable  No blanking performed.

"" (empty string)

Enable

Blanking performed based on burst start and stop values and
blanking source set to private marker.

marker0, marker1,
marker2, or marker3

Disable

Blanking performed based on the marker locations for the
marker that the user set in the blanking source.

marker0, marker1,
marker2, or marker3

Enable

Error is shown.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

248 ni.com

niRFSG Properties

Note For PXIe-5830/5831/5832, the RF Blanking reserves a PXI trigger line. If
you are calling any niRFSG Reset or niRFSA Reset on the same device, NI
recommends calling it before committing blanking properties. Alternatively,
you can call niRFSG Reset With Options or niRFSA Reset With Options. Select
Routes in the steps to omit parameter.

Default Values: Disabled

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform RF Blanking

Read/Write

N/A

Yes

Yes

Disable

Enable

0

1

RF blanking is disabled.

RF blanking is enabled.

Arb:Waveform Attributes:Waveform Runtime Scaling
Arb:Waveform Attributes:Waveform Runtime Scaling

Specifies the waveform runtime scaling. The waveform runtime scaling is applied to
the waveform data before any other signal processing.

Units: dB

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

© National Instruments 249

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform Runtime Scaling

Read/Write

N/A

Yes

No

Arb:Waveform Attributes:Waveform Signal Bandwidth (Hz)
Arb:Waveform Attributes:Waveform Signal Bandwidth (Hz)

Specifies the bandwidth of the arbitrary signal. This value must be less than or equal
to (0.8 Ã— I/Q rate).

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform Signal Bandwidth (Hz)

Read/Write

N/A

Yes

No

Arb:Waveform Attributes:Waveform Size
Arb:Waveform Attributes:Waveform Size

Specifies the size of the waveform specified by active channel

250 ni.com

niRFSG Properties

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform Size

Read Only

N/A

Yes

No

Arb:Waveform Capabilities:Max Number Waveforms
Arb:Waveform Capabilities:Max Number Waveforms

Specifies the maximum number of waveforms the NI-RFSG device can hold in memory.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Max Number Waveforms

Read Only

High-level VIs

niRFSG Query Arb Waveform Capabilities

Channel-based

Resettable

No

No

© National Instruments 251

niRFSG Properties

Arb:Waveform Capabilities:Max Waveform Size
Arb:Waveform Capabilities:Max Waveform Size

Specifies the size of the largest waveform that is allowed.

To read this property, the NI-RFSG device must be in the Configuration state.

PXI-5671, PXIe-5672: The value of this property depends on the I/Q rate. Set the I/Q rate
before reading this property.

PXIe-5673/5673E: The maximum waveform size is reduced to account for the amount
of device memory currently used.

Note Not all onboard memory is available for waveform storage. A portion of
onboard memory stores scripts that specify how the waveforms are
generated. These scripts typically require less than 1 KB of onboard memory.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Max Waveform Size

Read Only

High-level VIs

niRFSG Query Arb Waveform Capabilities

Channel-based

Resettable

No

No

Arb:Waveform Capabilities:Min Waveform Size
Arb:Waveform Capabilities:Min Waveform Size

Specifies the smallest allowable waveform size.

252 ni.com

PXI-5671, PXIe-5672: The value of this property depends on the I/Q rate. Set the I/Q rate
before reading this property.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Min Waveform Size

Read Only

High-level VIs

niRFSG Query Arb Waveform Capabilities

Channel-based

Resettable

No

No

Arb:Waveform Capabilities:Selected Waveform
Arb:Waveform Capabilities:Selected Waveform

Specifies the waveform in onboard memory to generate upon calling the niRFSG
Initiate VI when the Generation Mode property is set to Arb Waveform. The Selected
Waveform property is ignored when the Generation Mode property is set to Script or
CW. To set the Selected Waveform property, the NI-RFSG device must be in the
Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: "" (empty string)

Related Topics

Assigning Properties or Attributes to a Waveform

© National Instruments 253

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Selected Waveform

Read/Write

niRFSG Select Arb Waveform

No

Yes

Arb:Waveform Capabilities:Waveform Quantum
Arb:Waveform Capabilities:Waveform Quantum

Returns the waveform quantum for the device. The number of samples in a waveform
must be an integer multiple of the waveform quantum. The other restrictions on the
length of the waveform are the minimum and maximum arbitrary waveform sizes.

PXI-5671, PXIe-5672: The value of this property depends on the I/Q rate. Set the I/Q
Rate property before reading this property.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Waveform Quantum

Read Only

High-level VIs

niRFSG Query Arb Waveform Capabilities

Channel-based

Resettable

No

No

254 ni.com

niRFSG Properties

Arb:Waveform Repeat Count
Arb:Waveform Repeat Count

Specifies the repeat count of a waveform when you set the Waveform Repeat Count Is
Finite property to TRUE. This property is valid only when you set the Generation Mode
property to Arb Waveform. To set this property, the NI-RFSG device must be in the
Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: 1

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform Repeat Count

Read/Write

N/A

No

Yes

Arb:Waveform Repeat Count Is Finite
Arb:Waveform Repeat Count Is Finite

Specifies the repetition mode of a waveform when you set the Generation Mode
property to Arb Waveform. If you set this property to TRUE, the number of repetitions
is determined by the Waveform Repeat Count property. To set this property, the NI-
RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: FALSE

© National Instruments 255

niRFSG Properties

TRUE

Repeats the waveform a finite number of times.

FALSE

Repeats the waveform continuously until you abort the generation.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Waveform Repeat Count Is Finite

Read/Write

N/A

No

Yes

Arb:Write Waveform Burst Detection:Enabled
Arb:Write Waveform Burst Detection:Enabled

Enables the detection of burst start and burst stop locations in the waveform. Set this
property to Enable before writing a waveform to NI-RFSG memory for detecting bursts.
You can read the detected burst start and burst stop locations using niRFSG Get
Waveform Burst Start Locations and niRFSG Get Waveform Burst Stop Locations VIs
respectively.

Note When you download a waveform using niRFSG Read and Download
Waveform From File (TDMS) VI and if RF Blanking property is enabled, you
must set the Write Waveform Burst Detection property to Disable.

Note For PXIe-5830/5831/5832, the RF Blanking reserves a PXI trigger line. If
you are calling any niRFSG Reset or niRFSA Reset on the same device, NI
recommends calling it before committing blanking properties. Alternatively,
you can call niRFSG Reset With Options or niRFSA Reset With Options. Select
Routes in the steps to omit parameter.

Default Value: Disable

256 ni.com

niRFSG Properties

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Write Waveform Burst Detection

Read/Write

N/A

Yes

Yes

Disable

Enable

0

1

Burst detection is disabled.

Burst detection is enabled.

Arb:Write Waveform Burst Detection:Mode
Arb:Write Waveform Burst Detection:Mode

Specifies the algorithm that NI-RFSG uses to detect the burst start and burst stop
locations in the waveform when burst detection is enabled using the Write Waveform
Burst Detection property. When you set Write Waveform Burst Detection Mode to Auto,
NI-RFSG automatically detects the burst start and burst stop locations by analyzing the
waveform. To fine-tune the burst detection process parameters yourself, you can set
this property to Manual and specify the burst detection parameters using the
Minimum Quiet Time , Power Threshold , and Minimum Burst Time properties.

Default Values: Auto

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

© National Instruments 257

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Write Waveform Burst Detection Mode

Read/Write

N/A

Yes

Yes

Auto

-1

NI-RFSG automatically detects the burst start and burst stop locations by analyzing the
waveform.

Manual  0  User sets the burst detection parameters.

Arb:Write Waveform Burst Detection:Power Threshold
Arb:Write Waveform Burst Detection:Power Threshold

Specifies the relative power level at which burst start or stop locations are detected.
The threshold is relative to the peak power in the waveform. NI-RFSG detects burst
start (or burst stop) locations when the signal exceeds (or falls below) the level
specified by this property. This property is ignored when you disable the Write
Waveform Burst Detection property or when you set the Write Waveform Burst
Detection Mode property to Auto.

Units: dB

Default Value: 0

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

258 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Power Threshold

Read/Write

N/A

Yes

Yes

Arb:Write Waveform Normalization
Arb:Write Waveform Normalization

Specifies whether to perform the normalization on a waveform.

Note You can not set Write Waveform Normalization and Power Level Type
properties at the same time.

Units: dB

Default Value: Disable

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Write Waveform Normalization

Read/Write

N/A

© National Instruments 259

niRFSG Properties

Channel-based

Resettable

Yes

Yes

Disable  0  Disables normalization on the waveform.

Enable  1

Enables normalization on a waveform to transform the waveform data so that its
maximum is 1.00 and its minimum is -1.00.

Clock:Advanced:Arb Oscillator Phase DAC Value
Clock:Advanced:Arb Oscillator Phase DAC Value

Specifies the oscillator phase digital-to-analog converter (DAC) value on the arbitrary
waveform generator (AWG). Use this property to reduce the trigger jitter when
synchronizing multiple devices with NI-TClk. This property can also help maintain
synchronization repeatability by writing a previous measurement's phase DAC value to
the current session. This property is applicable only when the Arb Sample Clock
Source property is set to ClkIn.

Supported Devices: PXIe-5673/5673E

Related Topics

NI-TClk Overview

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

260 ni.com

Arb Oscillator Phase DAC Value

Read/Write

N/A

No

niRFSG Properties

Resettable

Yes

Clock:Arb Onboard Sample Clock Mode
Clock:Arb Onboard Sample Clock Mode

Specifies the Sample Clock mode on the device. To set this property, the NI-RFSG
device must be in the Configuration state.

PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842/5860: Divide Down
is the only supported value for this device.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Values:

PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672, PXIe-5820/5830/5831/5832/5840/
5841/5842/5860: Divide Down

PXIe-5673/5673E: High Resolution

Related Topics

Clocking Modes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Arb Onboard Sample Clock Mode

Read/Write

N/A

No

Yes

© National Instruments 261

niRFSG Properties

Generates sample rates with the high-resolution clock.

High
Resolution

6000

Note Use of the high resolution clock may result in increased
phase noise.

Divide Down

6001  Generates sample rates dividing the source frequency.

Clock:Arb Sample Clock Rate (Hz)
Clock:Arb Sample Clock Rate (Hz)

Returns the rate of the Sample Clock on the device.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Arb Sample Clock Rate (Hz)

Read Only

N/A

No

No

Clock:Arb Sample Clock Source
Clock:Arb Sample Clock Source

Specifies the Sample Clock source for the device. To set this property, the NI-RFSG
device must be in the Configuration state.

PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842/5860:

262 ni.com

OnboardClock is the only supported value for this device.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Default Value: OnboardClock

Related Topics

Timing Configurations

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Arb Sample Clock Source

Read/Write

N/A

No

Yes

OnboardClock  OnboardClock  Uses the AWG module onboard clock as the clock source.

ClkIn

ClkIn

Uses an external clock as the clock source.

Clock:PXI Chassis Clk 10 Source
Clock:PXI Chassis Clk 10 Source

Specifies the clock source for driving the PXI 10 MHz backplane Reference Clock. This
property is configurable if the PXI-5610 upconverter module is installed in only Slot 2
of a PXI chassis. To set this property, the NI-RFSG device must be in the Configuration
state.

© National Instruments 263

niRFSG Properties

Supported Devices: PXI-5610, PXI-5670/5671

Only certain combinations of this property and the Reference Clock Source property
are valid, as shown in the following table.

PXI Chassis Clk 10 Source Property Setting

None, OnBoard Clock

None, RefIn

None (PXI 10 MHz oscillator), RefIn (Reference signal connected to the REF_IN
connector of the upconverter; backplane locked to REF_IN; upconverter
locked to backplane)

Valid Reference
Clock Source
Property Setting

OnBoard Clock

RefIn

PXI_CLK

Related Topics

Timing Configurations

System Reference Clock

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

PXI Chassis Clk 10 Source

Read/Write

niRFSG Configure PXI Chassis Clk10

No

Yes

None

None

Do not drive the PXI_CLK signal.

264 ni.com

niRFSG Properties

OnboardClock  OnboardClock

Uses the highly stable oven-controlled onboard Reference Clock to
drive the PXI_CLK signal.

RefIn

RefIn

Uses the clock present at the front panel REF IN connector to drive
the PXI_CLK signal.

Clock:Reference Clock Export Output Terminal
Clock:Reference Clock Export Output Terminal

Specifies the destination terminal for exporting the Reference Clock on the RF signal
generators. To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/
5860

Default Value: Do not export signal

Defined
Output
Terminal
Values

Supported on
PXIe-5644/5645/5646,
PXIe-5820/5830/5831/
5832/5840/5841/
5842/5860

Supported
on PXI/
PXIe-5650/
5651/
56521

Supported
on
PXIe-5653

Supported
on
PXIe-5654,
PXIe-5654
with
PXIe-5696

Supported
on
PXIe-5673

Supported
on
PXIe-5673E

RefOut

RefOut2  X

ClkOut

X

Do not
export
signal

X

X

X

X

X

X

1The RefOut2 output terminal value is valid for only the PXIe-5650/5651/5652, not the
PXI-5650/5651/5652.

Related Topics

© National Instruments 265

niRFSG Properties

Interconnecting Multiple PXIe-5673E Modules

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not export
signal

Reference Clock Export Output Terminal

Read/Write

N/A

No

Yes

The Reference Clock signal is not exported.

RefOut

RefOut

Exports the Reference Clock signal to the REF OUT connector of the
device.

RefOut2

RefOut2

Exports the Reference Clock signal to the REF OUT2 connector of the
device.

ClkOut

ClkOut

Exports the Reference Clock signal to the CLK OUT connector of the
device.

Clock:Reference Clock Exported Rate (Hz)
Clock:Reference Clock Exported Rate (Hz)

Specifies the Reference Clock Rate, in Hz, of the signal sent to the Reference Clock
Export Output Terminal. To set this attribute, the NI-RFSG device must be in the
Configuration state.

Default Value: 10 MHz

266 ni.com

niRFSG Properties

Valid Values:

PXIe-5820/5830/5831/5832/5840/5841: 10 MHz

PXIe-5842: 10 MHz, 100 MHz, 1 GHz

PXIe-5860: 10 MHz, 100 MHz

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Reference Clock Exported Rate (Hz)

Read/Write

N/A

Yes

Yes

10MHz

10000000

Exports a 10 MHz Reference Clock.

100MHz

100000000

Exports a 100 MHz Reference Clock.

1GHz

1000000000

Clock:Reference Clock Rate (Hz)
Clock:Reference Clock Rate (Hz)

Specifies the Reference Clock rate, in Hz, of the signal present at the REF IN or CLK IN
connector. This property is only valid when the Reference Clock Source property is set
to ClkIn, or RefIn.

© National Instruments 267

niRFSG Properties

To set this property, the NI-RFSG device must be in the Configuration state. If you are
using the PXIe-5654/5654 with PXIe-5696, the NI-RFSG device must be in the
Committed state to read this property. When you read this property, it returns the
frequency the device is locked to during the Committed state.

If you set this property to Auto, NI-RFSG uses the default Reference Clock rate for the
device or automatically detects the Reference Clock rate if automatic detection is
supported by the device.

Note Automatic detection of the Reference Clock rate is supported on only
the PXIe-5654/5654 with PXIe-5696. For all other supported devices, NI-RFSG
uses the default Reference Clock rate of 10 MHz.

Valid Values:

PXIe-5654/5654 with PXIe-5696: Values between 1 MHz to 20 MHz in 1 MHz steps are
supported in addition to the Auto and 10MHz values.

PXIe-5841 with PXIe-5655/PXIe-5842: 10 MHz, 100 MHz, 270 MHz, and 3.84 MHz * y,
where y is 4, 8, 16, 24, 25, or 32.

PXIe-5860: 10 MHz, 100 MHz.

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: Auto

Related Topics

Timing Configurations

Remarks

The following table lists the characteristics of this property.

268 ni.com

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Reference Clock Rate (Hz)

Read/Write

niRFSG Configure Ref Clock

No

Yes

Auto

-1

Uses the default Reference Clock rate for the device or automatically detects
the Reference Clock rate if the device supports it.

10MHz  10000000  Uses a 10 MHz Reference Clock rate.

Clock:Reference Clock Source
Clock:Reference Clock Source

Specifies the Reference Clock source. To set this property, the NI-RFSG device must be
in the Configuration state.

Note The PXI-5670/5671 and PXIe-5672 devices also allow you to drive the
PXI 10 MHz backplane clock with the PXI Chassis Clk 10 Source property.

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: Onboard Clock

Related Topics

Timing Configurations

© National Instruments 269

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Reference Clock Source

Read/Write

niRFSG Configure Ref Clock

No

Yes

Uses the onboard Reference Clock as the clock source.

PXIe-5830/5831—For the PXIe-5830, connect the PXIe-5820 REF IN
connector to the PXIe-3621 REF OUT connector. For the PXIe-5831/
5832, connect the PXIe-5820 REF IN connector to the PXIe-3622 REF
OUT connector.

Onboard
Clock

OnboardClock

PXIe-5831/5832 with PXIe-5653—Connect the PXIe-5820 REF IN
connector to the PXIe-3622 REF OUT connector. Connect the
PXIe-5653 REF OUT (10 MHz) connector to the PXIe-3622 REF IN
connector.

PXIe-5841 with PXIe-5655—Lock to the PXIe-5655 onboard clock.
Connect the REF OUT connector on the PXIe-5655 to the PXIe-5841
REF IN connector.

PXIe-5842—Lock to the associated PXIe-5655 onboard clock.
Cables between modules are required as shown in the Getting
Started Guide for the instrument.

RefIn

RefIn

Uses the clock signal present at the front panel REF IN connector
as the clock source.

PXIe-5830/5831—For the PXIe-5830, connect the PXIe-5820 REF IN
connector to the PXIe-3621 REF OUT connector. For the PXIe-5831,

270 ni.com

niRFSG Properties

connect the PXIe-5820 REF IN connector to the PXIe-3622 REF OUT
connector. For the PXIe-5830, lock the external signal to the
PXIe-3621 REF IN connector. For the PXIe-5831/5832, lock the
external signal to the PXIe-3622 REF IN connector.

PXIe-5831/5832 with PXIe-5653—Connect the PXIe-5820 REF IN
connector to the PXIe-3622 REF OUT connector. Connect the
PXIe-5653 REF OUT (10 MHz) connector to the PXIe-3622 REF IN
connector. Lock the external signal to the PXIe-5653 REF IN
connector.

PXIe-5841 with PXIe-5655—Lock to the signal at the REF IN
connector on the associated PXIe-5655. Connect the PXIe-5655 REF
OUT connector to the PXIe-5841 REF IN connector.

PXIe-5842—Lock to the signal at the REF IN connector on the
associated PXIe-5655. Cables between modules are required as
shown in the Getting Started Guide for the instrument.

PXI Clock

PXI_CLK

Uses the PXI_CLK signal, which is present on the PXI backplane, as
the clock source. Cables between modules are required as shown
in the Getting Started Guide for the instrument.

ClkIn

ClkIn

RefIn2

RefIn2

PXI_ClkMaster  PXI_ClkMaster

Uses the clock signal present at the front panel CLK IN connector
as the clock source. This value is not valid for the PXIe-5644/5645/
5646 or PXIe-5820/5830/5831/5831/5832 with PXIe-5653/5840/
5841/5841 with PXIe-5655.

This value is valid on only the PXIe-5831/5832 with PXIe-5653.

PXIe-5831/5832 with PXIe-5653—NI-RFSG configures the
PXIe-5653 to export the Reference clock and configures the
PXIe-5820 and PXIe-3622 to use PXI_Clk as the Reference Clock
source. Connect the PXIe-5653 REF OUT (10 MHz) connector to the
PXI chassis REF IN connector.

© National Instruments 271

niRFSG Properties

Configuration List:Active List
Configuration List:Active List

Specifies the name of the configuration list to make active. When a property is get or
set and that property is in the configuration list properties of the active list, the
property is set to or get from the active list step of the active list. If the Active
Configuration List property is set to "" (empty string), no list is active.

Note For the PXIe-5650/5651/5652 and PXIe-5673E, when this property is set
to a valid list name, the Frequency Settling Units property only supports
Seconds After I/O as a valid value.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Default Value: "" (empty string)

Related Topics

RF List Mode

Using RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Active Configuration List

Read/Write

niRFSG Create Configuration List

No

Yes

272 ni.com

niRFSG Properties

Configuration List:Active Step
Configuration List:Active Step

Specifies the active step of the list defined by the Active Configuration List property.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Default Value: 0

Related Topics

RF List Mode

Using RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Active Configuration List Step

Read/Write

niRFSG Create Configuration List

No

Yes

Configuration List:Configuration List Is Done
Configuration List:Configuration List Is Done

Returns whether the configuration list is still running or done. To read this property,
the device must be in the Generation state.

Supported Devices: PXIe-5650/5651/5652, PXIe-5653/5654/5654 with PXIe-5696,
PXIe-5673E

© National Instruments 273

niRFSG Properties

TRUE

FALSE

The configuration list is done.

The configuration list is still running.

Related Topics

RF List Mode

Using RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Configuration List Is Done

Read Only

N/A

No

No

Configuration List:Configuration List Repeat
Configuration List:Configuration List Repeat

Specifies whether the configuration list runs only once or continuously.

Supported Devices: PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696, PXIe-5673E

Default Value: Continuous

Related Topics

RF List Mode

Using RF List Mode

274 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Configuration List Repeat

Read/Write

N/A

No

Yes

Continuous

0  NI-RFSG runs the configuration list continuously.

Single

1  NI-RFSG runs the configuration list only once.

Configuration List:Step In Progress
Configuration List:Step In Progress

Returns the configuration list step that is currently programmed to the hardware. The
list is zero-indexed. You can query this property only when a list is executed.

PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696, PXIe-5673E: This property can
be read only when a configuration list is running.

PXIe-5644/5645/5646: This property always returns 0 when the configuration list is not
running.

PXIe-5820/5830/5831/5832/5840/5841/5842/5860, PXIe-5842 with S-parameters,
PXIe-5842 with 54GHz Frequency Extension, PXIe-5860 with S-parameters: If the
configuration list is not running, this property returns the last step of a configuration
list that is programmed to the hardware. If the device was last initiated without an
active configuration list, this property returns 0.

© National Instruments 275

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

niRFSG Properties

Related Topics

RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Configuration List Step In Progress

Read Only

N/A

No

No

De-embedding:Compensation Gain
De-embedding:Compensation Gain

Returns the de-embedding gain applied to compensate for the mismatch on the
specified port. Use the Active Channel property to specify the name of the port to
configure for de-embedding.

If de-embedding is enabled, NI-RFSG uses the returned compensation gain to remove
the effects of the external network between the instrument and the DUT.

Supported Devices: PXIe-5830/5831/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

276 ni.com

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

De-embedding Compensation Gain

niRFSG Properties

Read Only

N/A

Yes

No

De-embedding:Selected Table
De-embedding:Selected Table

Selects the de-embedding table to apply to the generations on the specified port. Use
the Active Channel property to specify the name of the port to configure for de-
embedding.

If de-embedding is enabled, NI-RFSG uses the specified table to remove the effects of
the external network between the instrument and the DUT. Use the niRFSG Create S-
parameter Table VI to create tables.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

De-embedding Selected Table

Read/Write

N/A

Yes

Yes

© National Instruments 277

niRFSG Properties

De-embedding:Type
De-embedding:Type

Specifies the type of de-embedding to apply to generations on the specified port. Use
the Active Channel property to specify the name of the port to configure for de-
embedding.

If you set this property to Scalar or Vector, NI-RFSG adjusts the instrument settings to
remove the effects of the external network between the instrument and the DUT.

PXIe-5830/5832/5840/5841/5842/5860: Valid values for this property are Scalar or
None.

PXIe-5831: Valid values for this property are Vector, Scalar, or None. Vector is only
supported for TRX Ports in a Semiconductor Test System (STS).

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Default Value: Scalar

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

De-embedding Type

Read/Write

N/A

Yes

Yes

None

25000  De-embedding is not applied to the generation.

278 ni.com

niRFSG Properties

Scalar

25001  De-embeds the generation using only the gain term.

Vector  25002  De-embeds the generation using the gain term and the reflection term.

Device Characteristics:AE Temperature (Degrees C)
Device Characteristics:AE Temperature (Degrees C)

Returns the amplitude extender module temperature in degrees Celsius.

Supported Devices: PXIe-5654 with PXIe-5696

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AE Temperature (Degrees C)

Read Only

N/A

No

No

Device Characteristics:AWG Temperature (Degrees C)
Device Characteristics:AWG Temperature (Degrees C)

Returns the AWG module temperature in degrees Celsius.

PXIe-5820/5840/5841: If you query this property during RF list mode, list steps may
take longer to complete during list execution.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5840/5841/
5842/5860

© National Instruments 279

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AWG Temperature (Degrees C)

Read Only

N/A

No

No

Device Characteristics:Device Temperature (Degrees C)
Device Characteristics:Device Temperature (Degrees C)

Returns the device temperature. If the NI-RFSG session is controlling multiple devices,
this property returns the temperature of the primary RF device. The NI-RFSG session is
opened using the primary RF device name.

Serial signals between the sensor and the system control unit can potentially
modulate the signal being generated, thus causing phase spurs. After the device
thoroughly warms up, its temperature varies only slightly (less than 1 degree Celsius)
and slowly, and it is not necessary to constantly poll this temperature sensor.

PXIe-5644/5645/5646, PXIe-5820/5840/5841: If you query this property during RF list
mode, list steps may take longer to complete during list execution.

PXIe-5830/5831/5832: To use this property, you must first set the Active Channel
property using the appropriate string for your instrument configuration. Setting the
Active Channel property is not required for the PXIe-3621/3622. Refer to the following
table to determine which strings are valid for your configuration.

Hardware Module

PXIe-3621/3622

PXIe-5820

TRX Port Type

Active Channel String

—

—

if or "" empty string

fpga

First connected mmRH-5582

DIRECT TRX PORTS Only

rf0

280 ni.com

niRFSG Properties

Hardware Module

TRX Port Type

Active Channel String

SWITCHED TRX PORTS [0-7]

rf0switch0

SWITCHED TRX PORTS [8-15]

rf0switch1

Second connected mmRH-5582

DIRECT TRX PORTS Only

rf1

SWITCHED TRX PORTS [0-7]

rf1switch0

SWITCHED TRX PORTS [8-15]

rf1switch1

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Temperature Monitoring

Thermal Shutdown

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Device Temperature (Degrees C)

Read Only

N/A

Yes

No

Device Characteristics:FPGA Target Name
Device Characteristics:FPGA Target Name

Returns a string containing the name of the FPGA target being used. This name can be
used with the RIO open session to open a reference to the FPGA.

© National Instruments 281

niRFSG Properties

This property is channel dependent if multiple targets are supported.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

FPGA Target Name

Read Only

N/A

Yes

No

Device Characteristics:FPGA Temperature (Degrees C)
Device Characteristics:FPGA Temperature (Degrees C)

Returns the FPGA temperature in degrees Celsius.

Serial signals between the sensor and the system control unit can potentially
modulate the signal being generated, thus causing phase spurs. After the device
thoroughly warms up, its temperature varies only slightly (less than 1 degree Celsius)
and slowly, and it is not necessary to constantly poll this temperature sensor.

Note If you query this property during RF list mode, list steps may take
longer to complete during list execution.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

FPGA Temperature (Degrees C)

282 ni.com

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read Only

N/A

No

No

Device Characteristics:LO Temperature (Degrees C)
Device Characteristics:LO Temperature (Degrees C)

Returns the LO module temperature in degrees Celsius.

PXIe-5840/5841: If you query this property during RF list mode, list steps may take
longer to complete during list execution.

Supported Devices: PXIe-5673/5673E, PXIe-5840/5841/5842

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Temperature (Degrees C)

Read Only

N/A

No

No

Device Characteristics:Module Power Consumption (W)
Device Characteristics:Module Power Consumption (W)

Returns the total power consumption of the device, in watts.

Note If you query this property during RF list mode, list steps may take
longer to complete during list execution.

© National Instruments 283

niRFSG Properties

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Module Power Consumption (W)

Read Only

N/A

No

No

Device Characteristics:Module Revision
Device Characteristics:Module Revision

Returns the module revision letter. If the NI-RFSG session is controlling multiple
modules, this property returns the revision letter of the primary RF module. The NI-
RFSG session is opened using the primary RF module name.

Supported Devices: PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXIe-5673/5673E, PXIe-5820/5830/5831/5832/
5840/5841/5842/5860

Related Topics

Identifying Module Revision

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

284 ni.com

Module Revision

Read Only

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

No

Device Characteristics:Options:Fast Tuning Option
Device Characteristics:Options:Fast Tuning Option

Returns whether the RF signal generator has the fast tuning option available.

Supported Devices: PXIe-5654/5654 with PXIe-5696

TRUE

The RF signal generator has the fast 100 microsecond tuning option.

FALSE

The RF signal generator has the 1 millisecond tuning option.

Related Topics

Frequency Tuning Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Fast Tuning

Read Only

N/A

No

No

Device Characteristics:Serial Number
Device Characteristics:Serial Number

Returns the serial number of the RF module. If the NI-RFSG session is controlling
multiple modules, this property returns the serial number of the primary RF module.

© National Instruments 285

niRFSG Properties

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Serial Number

Read Only

N/A

No

No

Device Characteristics:Temperature Read Interval
Device Characteristics:Temperature Read Interval

Specifies the minimum time, in seconds, between temperature sensor readings.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Temperature Read Interval

Read/Write

N/A

No

Yes

286 ni.com

niRFSG Properties

Device Specific:Vector Signal Transceiver:Device Characteristics:FPGA Bitfile
Device Specific:Vector Signal Transceiver:Device Characteristics:FPGA Bitfile
Path
Path

Returns a string containing the path to the location of the current NI-RFSG instrument
driver FPGA extensions bitfile, a .lvbitx file, that is programmed on the device. You can
specify the bitfile location using the Driver Setup string in the options string input of
the niRFSG Initialize With Options VI.

NI-RFSG instrument driver FPGA extensions enable you to use pre-compiled FPGA bit
files to customize the behavior of the vector signal transceiver FPGA while maintaining
the functionality of the NI-RFSG instrument driver.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Related Topics

NI-RFSG Instrument Driver FPGA Extensions

Driver Setup Options

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

FPGA Bitfile Path

Read Only

N/A

No

No

Device Specific:Vector Signal Transceiver:Events:Events Delay
Device Specific:Vector Signal Transceiver:Events:Events Delay

Specifies the delay, in seconds, applied to the Started Event, Done Event, and all

© National Instruments 287

niRFSG Properties

Marker Events with respect to the analog output of the RF signal generator. To set this
property, the NI-RFSG device must be in the Configuration or Generation state.

Note If you decrease the event delay during generation, some markers may
be dropped.

By default, markers and events are delayed to align with the waveform data generated
from the device. This property adds an additional delay to markers and events. Use
this property to adjust the time delay between events and the corresponding data.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/5842

Valid Values:

PXIe-5644/5645: -1.217 us to 67.050 us

PXIe-5646: -0.896 us to 64.640 us

PXIe-5820/5830/5831/5832/5840/5841: 0 us to 3.276 us

PXIe-5842: 0 us to 6.5534 us

Related Topics

Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

288 ni.com

Events Delay

Read/Write

N/A

No

niRFSG Properties

Resettable

Yes

Device Specific:Vector Signal Transceiver:IQ Out Port:Carrier Frequency
Device Specific:Vector Signal Transceiver:IQ Out Port:Carrier Frequency

Specifies the frequency, in Hz, of the I/Q OUT port signal. The onboard signal
processing (OSP) applies the specified frequency shift to the I/Q data before the data is
sent to the digital-to-analog converter (DAC). To set this property, the NI-RFSG device
must be in the Configuration state.

Note For the PXIe-5820, NI recommends using the Frequency (Hz) property.

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

Supported Devices: PXIe-5645, PXIe-5820

Valid Values:

PXIe-5645: -60 MHz to 60 MHz

PXIe-5820: -500 MHz to 500 MHz

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Out Port Carrier Frequency

Read/Write

N/A

No

Yes

© National Instruments 289

niRFSG Properties

Device Specific:Vector Signal Transceiver:IQ Out Port:Common Mode Offset
Device Specific:Vector Signal Transceiver:IQ Out Port:Common Mode Offset

Specifies the common-mode offset, in volts, applied to the signals generated at each
differential output terminal. This property is valid only when you set the IQ Out Port
Terminal Configuration property to Differential. Common-mode offset shifts both
positive and negative terminals in the same direction.

To use this property, you must use the Active Channel property to specify the name of
the channel you are configuring. For the PXIe-5645, you can configure the I and Q
channels by using I or Q as the channel string, or set the channel string to "" (empty
string) to configure both channels. For the PXIe-5820, the only valid value for the
channel string is "" (empty string).

To set this property, the NI-RFSG device must be in the Configuration state.

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

Supported Devices: PXIe-5645, PXIe-5820

Valid Values:

PXIe-5645: -0.8 V to 0.8 V if you set the IQ Out Port Load Impedance property to
50 ohms. -1.2 V to 1.2 V if you set the IQ Out Port Load Impedance property to
100 ohms.

PXIe-5820: -0.25 V to 1.5 V

Note The valid range is dependent on the load impedance.

Remarks

The following table lists the characteristics of this property.

IQ Out Port Common Mode Offset

Short Name

Data type

290 ni.com

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:IQ Out Port:Level
Device Specific:Vector Signal Transceiver:IQ Out Port:Level

Specifies the amplitude of the generated signal in volts, peak-to-peak (Vpk-pk). For
example, if you set this property to 1.0, the output signal ranges from -0.5 volts to
0.5 volts.

To use this property, you must use the Active Channel property to specify the name of
the channel you are configuring. For the PXIe-5645, you can configure the I and Q
channels by using I or Q as the channel string, or set the channel string to "" (empty
string) to configure both channels. For the PXIe-5820, the only valid value for the
channel string is "" (empty string).

To set this property, the NI-RFSG device must be in the Configuration state.

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

Refer to the specifications document for your device for allowable output levels.

Supported Devices: PXIe-5645, PXIe-5820

Default Value: 0.5 volts

Valid Values:

PXIe-5645: 1 Vpk-pk maximum if you set the IQ Out Port Terminal Configuration
property to Differential, and 0.5 Vpk-pk maximum if you set the IQ Out Port Terminal
Configuration property to Single-Ended.

PXIe-5820: 3.4 Vpk-pk maximum for signal bandwidth less than 160 MHz, and 2 Vpk-pk
maximum for signal bandwidth greater than 160 MHz.

© National Instruments 291

niRFSG Properties

Note The valid values are only applicable when you set the IQ Out Port Load
Impedance property to 50 ohms and when you set the IQ Out Port Offset
property to 0.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Out Port Level

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:IQ Out Port:Load Impedance
Device Specific:Vector Signal Transceiver:IQ Out Port:Load Impedance

Specifies the load impedance, in ohms, connected to the I/Q OUT port. To set this
property, the NI-RFSG device must be in the Configuration state.

To use this property, you must use the Active Channel property to specify the name of
the channel you are configuring. For the PXIe-5645, you can configure the I and Q
channels by using I or Q as the channel string, or set the channel string to "" (empty
string) to configure both channels. For the PXIe-5820, the only valid value for the
channel string is "" (empty string).

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

Supported Devices: PXIe-5645, PXIe-5820

Default Value: 50 ohms if you set the IQ Out Port Terminal Configuration property to
Single-Ended, and 100 ohms if you set the IQ Out Port Terminal Configuration to
Differential.

292 ni.com

Valid Values: Any value greater than 0. Values greater than or equal to 1 megaohms are
interpreted as high impedance.

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Out Port Load Impedance

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:IQ Out Port:Offset
Device Specific:Vector Signal Transceiver:IQ Out Port:Offset

Specifies the value, in volts, that the signal generator adds to the I and Q signals. To set
this property, the NI-RFSG device must be in the Configuration state.

To use this property, you must use the Active Channel property to specify the name of
the channel you are configuring. For the PXIe-5645, you can configure the I and Q
channels by using I or Q as the channel string, or set the channel string to "" (empty
string) to configure both channels. For the PXIe-5820, the only valid value for the
channel string is "" (empty string).

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

PXIe-5645: The waveform may be scaled in DSP prior to adding offset and the device
state may be changed in order to accommodate the requested offset.

PXIe-5820: The waveform is not automatically scaled in DSP. To prevent DSP overflows,
use the Pre-filter Gain (dB) property to scale the waveform to provide additional
headroom for offsets.

Supported Devices: PXIe-5645, PXIe-5820

© National Instruments 293

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Out Port Offset

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:IQ Out Port:Temperature (Degrees C)
Device Specific:Vector Signal Transceiver:IQ Out Port:Temperature (Degrees C)

Returns the temperature, in degrees Celsius, of the I/Q Out circuitry on the device.

Note If you query this property during RF list mode, list steps may take
longer to complete during list execution.

Supported Devices: PXIe-5645, PXIe-5820

Remarks

The following table lists the characteristics of this property.

IQ Out Port Temperature (Degrees C)

Read Only

N/A

No

No

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

294 ni.com

niRFSG Properties

Device Specific:Vector Signal Transceiver:IQ Out Port:Terminal Configuration
Device Specific:Vector Signal Transceiver:IQ Out Port:Terminal Configuration

Specifies whether to use the I/Q OUT port for Differential configuration or Single-
Ended configuration. If you set this property to Single-Ended, you must terminate the
negative I and Q output connectors with a 50 Ohm termination.

If you set this property to Single-Ended, the positive I and Q connectors generate the
resulting waveform. If you set this property to Differential, both the positive and
negative I and Q connectors generate the resulting waveform.

To use this property, you must use the Active Channel property to specify the name of
the channel you are configuring. For the PXIe-5645, you can configure the I and Q
channels by using I or Q as the channel string, or set the channel string to "" (empty
string) to configure both channels. For the PXIe-5820, the only valid value for the
channel string is "" (empty string).

Note For the PXIe-5645, this property is ignored if you are using the RF ports.

To set this property, the NI-RFSG device must be in the Configuration state.

PXIe-5820: The only valid value for this property is Differential.

Supported Devices: PXIe-5645, PXIe-5820

Default Value: Differential

Related Topics

Differential and Single-Ended Operation (I/Q Interface)

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

IQ Out Port Terminal Configuration

© National Instruments 295

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

Differential

15000

Sets the terminal configuration to differential.

Single-Ended

15001

Sets the terminal configuration to single-ended.

Device Specific:Vector Signal Transceiver:Signal Path:Absolute Delay
Device Specific:Vector Signal Transceiver:Signal Path:Absolute Delay

Specifies the sub-Sample Clock delay, in seconds, to apply to the I/Q waveform. Use
this property to reduce the trigger jitter when synchronizing multiple devices with NI-
TClk. This property can also help maintain synchronization repeatability by writing the
absolute delay value of a previous measurement to the current session.

To set this property, the NI-RFSG device must be in the Configuration state.

Note If this property is set, NI-TClk cannot perform any sub-Sample Clock
adjustment.

Note The resolution of this property is a function of the I/Q sample period at
15E(-6) times that sample period.

Supported Devices: PXIe-5820/5840/5841/5842

Valid Values: Plus or minus half of one Sample Clock period

Remarks

The following table lists the characteristics of this property.

296 ni.com

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Absolute Delay

Read/Write

N/A

No

Yes

Device Specific:Vector Signal
Device Specific:Vector Signal
Transceiver:Signal Path:Available
Transceiver:Signal Path:Available
Paths:Available Paths
Paths:Available Paths

Returns a comma separated list of the configurable paths available for use based on
your instrument configuration.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Available Paths

Read Only

N/A

Yes

No

Device Specific:Vector Signal Transceiver:Signal Path:Available Ports
Device Specific:Vector Signal Transceiver:Signal Path:Available Ports

Returns a CSV of the available ports for your hardware configuration.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/

© National Instruments 297

niRFSG Properties

5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Available Ports

Read Only

N/A

No

No

Device Specific:Vector Signal Transceiver:Signal Path:Fixed Group Delay Across
Device Specific:Vector Signal Transceiver:Signal Path:Fixed Group Delay Across
Ports
Ports

Specifies a comma-separated list of ports for which to fix the group delay.

Supported Devices: PXIe-5831/5832

Default Value:

PXIe-5831/5832: "" (empty string), which specifies that the group delay will not be
fixed for any port.

Valid Values:

PXIe-5831/5832: rf<0-1>/port<x> , where 0-1 indicates one (0 ) or two (1 )
mmRH-5582 connections and x is the port number on the mmRH-5582 front panel.

Remarks

The following table lists the characteristics of this property.

Short Name

Fixed Group Delay Across Ports

298 ni.com

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:Signal Path:Interpolation Delay
Device Specific:Vector Signal Transceiver:Signal Path:Interpolation Delay

Specifies the delay, in seconds, to apply to the I/Q waveform. To set this property, the
NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646

Valid Values: Plus or minus half of one I/Q sample period

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Interpolation Delay

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Signal Path:LO Frequency Step Size
Device Specific:Vector Signal Transceiver:Signal Path:LO Frequency Step Size
(Hz)
(Hz)

Specifies the step size for tuning the local oscillator (LO) phase-locked loop (PLL).

When the LO PLL Fractional Mode Enabled property is set to Enabled, the specified
step size affects the fractional spur performance of the device. When the LO PLL

© National Instruments 299

Fractional Mode Enabled property is set to Disabled, the specified step size affects the
phase noise performance of the device.

Supported Devices: PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842

niRFSG Properties

Default Values:

PXIe-5644/5645/5646: 200 kHz

PXIe-5830: 2 MHz

PXIe-5831/5832 (RF port): 8 MHz

PXIe-5831/5832 (IF port): 2 MHz, 4 MHz

PXIe-5840/5841:

•  Fractional mode: 500 kHz
•  Integer mode: 10 MHz for frequencies less than or equal to 4 GHz. 20 MHz for

frequencies greater than 4 GHz.

PXIe-5841 with PXIe-5655: 500 kHz

PXIe-5842: 1 Hz

Valid Values:

The valid values for this property depend on the LO PLL Fractional Mode Enabled
property.

PXIe-5644/5645/5646—If you set the LO PLL Fractional Mode Enabled property to
Disabled, the specified value is coerced to the nearest valid value.

PXIe-5840/5841—If you set the LO PLL Fractional Mode Enabled property to Disabled,
the specified value is coerced to the nearest valid value that is less than or equal to the
desired step size.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the

300 ni.com

niRFSG Properties

name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

Note For any PXIe-5842 instrument without frequency extension (i.e. no
RMM-5585 remote measurement module connected), the only valid value for
the channel string is "" (empty string).

LO PLL
Fractional
Mode
Enabled
Property
Setting

LO Frequency
Step Size
Property Valid
Values on
PXIe-5644/
5645

LO
Frequency
Step Size
Property
Valid Values
on PXIe-5646

LO Frequency
Step Size
Property Valid
Values on
PXIe-5840/
5841

LO Frequency
Step Size
Property Valid
Values on
PXIe-5830/
5831/5832

LO Frequency Step
Size Property Valid
Values on
PXIe-5841 with
PXIe-5655,
PXIe-5842*

1 nHz to 50 MHz

1 nHz to 50 MHz

Enabled

50 kHz to 24
MHz

50 kHz to 25
MHz

50 kHz to 100
MHz

LO1: 8 Hz to 400
MHz

LO2: 4 kHz to
400 MHz

Disabled

4 MHz, 5 MHz,
6 MHz, 12
MHz, 24 MHz

2 MHz, 5
MHz, 10 MHz,
25 MHz

1 MHz, 5 MHz,
10 MHz, 25
MHz, 50 MHz,
100 MHz

LO1: --

LO2: --

Note * Values up to 100 MHz are coerced to 50 MHz.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

LO Frequency Step Size (Hz)

Read/Write

N/A

© National Instruments 301

niRFSG Properties

Channel-based

Resettable

Yes

Yes

Device Specific:Vector Signal Transceiver:Signal Path:LO PLL Fractional Mode
Device Specific:Vector Signal Transceiver:Signal Path:LO PLL Fractional Mode
Enabled
Enabled

Specifies whether to use fractional mode for the local oscillator (LO) phase-locked
loop (PLL). This property enables or disables fractional frequency tuning in the LO.
Fractional mode provides a finer frequency step resolution and allows smaller values
for the LO Frequency Step Size property. However, fractional mode may introduce non-
harmonic spurs.

This property is valid only if you set the LO Source property to Onboard.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

Note For the PXIe-5841 with PXIe-5655, this property is ignored if the
PXIe-5655 is used as the LO source. For the PXIe-5842, this property is
ignored.

Supported Devices: PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842

Default Value: Enabled

Related Topics

Refer to the local oscillators topic appropriate to your device for more information
about using fractional mode.

302 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO PLL Fractional Mode Enabled

Read/Write

N/A

Yes

Yes

Disabled

0

Disables fractional mode for the LO PLL.

Enabled

1

Enables fractional mode for the LO PLL.

Device Specific:Vector Signal Transceiver:Signal Path:LO Source
Device Specific:Vector Signal Transceiver:Signal Path:LO Source

Specifies whether to use the internal or external local oscillator (LO) source. If this
property is set to "" (empty string), NI-RFSG uses the internal LO source. To set this
property, the NI-RFSG device must be in the Configuration state.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

Note For the PXIe-5841 with PXIe-5655, RF list mode is not supported when
this property is set to SG SA Shared.

© National Instruments 303

niRFSG Properties

Note For any PXIe-5842 instrument without frequency extension (i.e. no
RMM-5585 remote measurement module connected), the only valid value for
the channel string is "" (empty string).

Supported Devices: PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842

Default Value: Onboard

Related Topics

PXIe-5830 LO Sharing Using NI-RFSA and NI-RFSG

PXIe-5831/5832 LO Sharing Using NI-RFSA and NI-RFSG

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Source

Read/Write

N/A

Yes

Yes

Uses an internal LO as the LO source. The LO is generated
inside the device itself.

Onboard  Onboard

PXIe-5831/5832—This configuration uses the onboard LO
of the PXIe-3622, using the LO2 stage.

PXIe-5831/5832 with PXIe-5653—This configuration uses
the onboard LO of the PXIe-5653 when associated with the
PXIe-3622.

304 ni.com

niRFSG Properties

PXIe-5841 with PXIe-5655—This configuration uses the
onboard LO of the PXIe-5655.

PXIe-5842—This configuration uses the onboard LO of the
PXIe-5655. Cables between modules are required as
shown in the Getting Started Guide for the instrument.

LO In

LO_In

Uses an external LO as the LO source. Connect a signal to
the LO IN connector on the device and use the
Upconverter Center Frequency (Hz) property to specify the
LO frequency.

Secondary  Secondary

Uses the PXIe-5831 internal LO as the LO source. This value
is valid on only the PXIe-5831/5832 with PXIe-5653 (LO1
stage only).

SG SA
Shared

SG_SA_Shared

Uses the same internal LO during NI-RFSA and NI-RFSG
sessions. NI-RFSG selects an internal synthesizer and the
synthesizer signal is switched to both the RF In and RF Out
mixers. This value is valid on only the PXIe-5830/5831/
5832/5841 with PXIe-5655/5842.

Automatic
SG SA
Shared

Automatic_SG_SA_Shared

NI-RFSG internally makes the configuration to share the
LO between NI-RFSA and NI-RFSG. This value is valid only
on the PXIe-5820/5830/5831/5832/5840/5841/5842.

Device Specific:Vector Signal Transceiver:Signal Path:LO VCO Frequency Step
Device Specific:Vector Signal Transceiver:Signal Path:LO VCO Frequency Step
Size (Hz)
Size (Hz)

Specifies the step size for tuning the internal voltage-controlled oscillator (VCO) used
to generate the LO signal.

Supported Devices: PXIe-5830/5831/5832

© National Instruments 305

niRFSG Properties

Default Value: 1 MHz

Valid Values:

LO1: 1 Hz to 50 MHz

LO2: 1 Hz to 100 MHz

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO VCO Frequency Step Size (Hz)

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Signal Path:Output Port
Device Specific:Vector Signal Transceiver:Signal Path:Output Port

Specifies the connector(s) to use to generate the signal. To set this property, the NI-
RFSG device must be in the Configuration state.

You must write complex I and Q data for all options. The Q data has no effect if you set
this property to I Only and set the IQ Out Port Carrier Frequency property to 0. If you
set the IQ Out Port Carrier Frequency property to a value other than 0, the onboard
signal processing (OSP) frequency shifts I and Q as a complex value and outputs the
real portion of the result on the I connector(s) of the device.

If you set the Output Port property to I Only or IQ Out, the IQ Out Port Terminal
Configuration property applies.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

306 ni.com

niRFSG Properties

Default Values:

PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842/5860: RF Out

PXIe-5820: IQ Out

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Output Port

Read/Write

N/A

No

Yes

RF Out  14000  Enables the RF OUT port. This value is not valid for the PXIe-5820.

IQ Out  14001  Enables the I/Q OUT port. This value is valid on only the PXIe-5645 and PXIe-5820.

Cal
Out

14002  Enables the CAL OUT port.

I Only

14003

Enables the I connectors of the I/Q OUT port. This value is valid on only the
PXIe-5645.

Device Specific:Vector Signal Transceiver:Signal Path:RF Blanking Source
Device Specific:Vector Signal Transceiver:Signal Path:RF Blanking Source

Specifies the Marker Event at which RF blanking occurs. RF blanking quickly attenuates
the RF OUT signal. Use Marker Events to toggle the state of RF blanking. The RF Output
always starts in the unblanked state.

© National Instruments 307

niRFSG Properties

To set this property, the NI-RFSG device must be in the Configuration state.

You can specify Marker Events by using scripts to trigger blanking at a certain point in a
waveform. For example, if you set this property to marker0, and marker0 occurs on
samples 1,000 and 2,000 of a script, then the RF Output will be blanked (attenuated)
between samples 1,000 and 2,000.

Note The shortest supported blanking interval is eight microseconds.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Note For the PXIe-5840/5841, RF blanking does not occur for frequencies
less than 120 MHz.

Note For PXIe-5830/5831/5832, the RF Blanking reserves a PXI trigger line. If
you are calling any niRFSG Reset or niRFSA Reset on the same device, NI
recommends calling it before committing blanking properties. Alternatively,
you can call niRFSG Reset With Options or niRFSA Reset With Options. Select
Routes in the steps to omit parameter.

Supported Devices: PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842

Default Value: "" (empty string)

Valid Values:

"" (empty string)

RF blanking is disabled.

RF blanking is tied to marker0 event.

RF blanking is tied to marker1 event.

RF blanking is tied to marker2 event.

RF blanking is tied to marker3 event.

marker0

marker1

marker2

marker3

308 ni.com

niRFSG Properties

Related Topics

Marker Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

RF Blanking Source

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Signal Path:Relative Delay
Device Specific:Vector Signal Transceiver:Signal Path:Relative Delay

Specifies the delay, in seconds, to apply to the I/Q waveform.

Relative delay allows for delaying the generated signal from one device relative to the
generated signal of another device after those devices have been synchronized. You
can achieve a negative relative delay by delaying both synchronized devices by the
same value (1 us) before generation begins and then changing the relative delay to a
smaller amount than the initial value on only one of the devices.

Note To obtain a negative relative delay when synchronizing the PXIe-5840/
5841/5842 with a module that does not support this property, use the NI-TClk
Sample Clock Delay property.

To set this property, the NI-RFSG device must be in the Configuration or Generation
state.

Note The resolution of this property is a function of the I/Q sample period at
15E(-6) of the sample period but not worse than one Sample Clock period.

© National Instruments 309

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Valid Values:

PXIe-5820/5830/5831/5832/5840/5841: 0 us to 3.2 us

niRFSG Properties

PXIe-5842: 0 us to 6.5 us

Related Topics

NI-TClk Overview

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Relative Delay

Read/Write

N/A

No

Yes

Device Specific:Vector Signal
Device Specific:Vector Signal
Transceiver:Signal Path:Selected
Transceiver:Signal Path:Selected
Path:Selected Path
Path:Selected Path

Specifies which path to configure to generate a signal.

Related Topics

Available Paths property

310 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Selected Path

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:Signal Path:Selected Ports
Device Specific:Vector Signal Transceiver:Signal Path:Selected Ports

Specifies the port to configure.

Note When using RF list mode, ports cannot be shared with NI-RFSA.

Supported Devices: PXIe-5644/5645/5646, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860

Default Value:

PXIe-5644/5645/5646, PXIe-5820/5840/5841/5842/5860: "" (empty string)

PXIe-5830/5831/5832: if0

PXIe-5842 VST with 54 GHz Frequency Extension: rmm0/port0

Valid Values:

PXIe-5644/5645/5646, PXIe-5820/5840/5841/5842/5860: "" (empty string)

PXIe-5830: if0, if1

PXIe-5831/5832: if0, if1, rf<0-1>/port<x> , where 0-1 indicates one (0 ) or

© National Instruments 311

two (1 ) mmRH-5582 connections and x is the port number on the mmRH-5582 front
panel.

PXIe-5842 VST with 54 GHz Frequency Extension: rfinout0, rfinout1, rmm0/
port0, rmm0/port1

niRFSG Properties

Related Topics

Available Ports property

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Selected Ports

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock Dist Line
Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock Dist Line

Specifies which external trigger line distributes the Sample Clock sync signal. When
synchronizing the Sample Clock between multiple devices, configure all devices to use
the same Sample Clock sync distribution line.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5646

Default Value: "" (empty string)

Valid Values: PXI_Trig0, PXI_Trig1, PXI_Trig2, PXI_Trig3, PXI_Trig4, PXI_Trig5, PXI_Trig6,
PXI_Trig7, PFI0

312 ni.com

Related Topics

Synchronization Using NI-RFSA and NI-RFSG—Refer to this topic for more information
about PXIe-5646 device synchronization.

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Sample Clock Dist Line

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock Master
Device Specific:Vector Signal Transceiver:Triggers:Sync Sample Clock Master

Specifies whether the device is the master device when synchronizing the Sample
Clock between multiple devices. The master device distributes the Sample Clock sync
signal to all devices in the system through the Sample Clock sync distribution line.

When synchronizing the Sample Clock, one device must always be designated as the
master. The master device actively drives the Sample Clock sync distribution line.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5646

Default Value: FALSE

TRUE

The device is the master device for synchronizing the Sample Clock.

FALSE

The device is not the master device for synchronizing the Sample Clock.

Related Topics

© National Instruments 313

Synchronization Using NI-RFSA and NI-RFSG—Refer to this topic for more information
about PXIe-5646 device synchronization.

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Sample Clock Master

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger Dist Line
Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger Dist Line

Specifies which external trigger line distributes the synchronized Script Trigger signal.
Use the Active Channel property to specify the name of the Script Trigger you are
configuring. When synchronizing the Script Trigger, configure all devices to use the
same Script Trigger distribution line.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646

Default Value: "" (empty string)

Valid Values: PXI_Trig0, PXI_Trig1, PXI_Trig2, PXI_Trig3, PXI_Trig4, PXI_Trig5, PXI_Trig6,
PXI_Trig7, PFI0

Related Topics

Script Trigger

Synchronizing Sample Clock and Sampled Reference Clock Signals

314 ni.com

Refer to the Synchronization Using NI-RFSA and NI-RFSG topic appropriate to your
device for more information about device synchronization for vector signal
transceivers.

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Script Trigger Dist Line

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger Master
Device Specific:Vector Signal Transceiver:Triggers:Sync Script Trigger Master

Specifies whether the device is the master device when synchronizing the Script
Trigger between multiple devices. Use the Active Channel property to specify the name
of the Script Trigger you are configuring.

The master device distributes the synchronized Script Trigger to all devices in the
system through the Script Trigger distribution line.

When synchronizing the Script Trigger, one device must always be designated as the
master. The master device actively drives the Script Trigger distribution line. For slave
devices, set the Script Trigger Type property to Digital Edge, and set the Script Trigger
Digital Edge Source property to sync_script.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646

Default Value: FALSE

© National Instruments 315

TRUE

The device is the master device for synchronizing the Script Trigger.

FALSE

The device is not the master device for synchronizing the Script Trigger.

niRFSG Properties

Related Topics

Script Trigger

Synchronizing Sample Clock and Sampled Reference Clock Signals

Refer to the Synchronization Using NI-RFSA and NI-RFSG topic appropriate to your
device for more information about device synchronization for vector signal
transceivers.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Script Trigger Master

Read/Write

N/A

Yes

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger Dist Line
Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger Dist Line

Specifies which external trigger line distributes the synchronized Start Trigger signal.
When synchronizing the Start Trigger, configure all devices to use the same Start
Trigger distribution line.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646

Default Value: "" (empty string)

316 ni.com

Valid Values: PXI_Trig0, PXI_Trig1, PXI_Trig2, PXI_Trig3, PXI_Trig4, PXI_Trig5, PXI_Trig6,
PXI_Trig7, PFI0

niRFSG Properties

Related Topics

Start Trigger

Refer to the Synchronization Using NI-RFSA and NI-RFSG topic appropriate to your
device for more information about device synchronization for vector signal
transceivers.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Start Trigger Dist Line

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger Master
Device Specific:Vector Signal Transceiver:Triggers:Sync Start Trigger Master

Specifies whether the device is the master device when synchronizing the Start Trigger
between multiple devices. The master device distributes the synchronized Start
Trigger to all devices in the system through the Start Trigger distribution line.

When synchronizing the Start Trigger, one device must always be designated as the
master. The master device actively drives the Start Trigger distribution line. For slave
devices, set the Start Trigger Type property to Digital Edge, and set the Start Trigger
Digital Edge Source property to sync_start.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646

© National Instruments 317

Default Value: FALSE

TRUE

The device is the master device for synchronizing the Start Trigger.

FALSE

The device is not the master device for synchronizing the Start Trigger.

niRFSG Properties

Related Topics

Start Trigger

Refer to the Synchronization Using NI-RFSA and NI-RFSG topic appropriate to your
device in the NI RF Signal Generators Help for more information about device
synchronization for vector signal transceivers.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Sync Start Trigger Master

Read/Write

N/A

No

Yes

Device Specific:Vector Signal Transceiver:Upconverter:Frequency Offset (Hz)
Device Specific:Vector Signal Transceiver:Upconverter:Frequency Offset (Hz)

This property offsets the Upconverter Center Frequency (Hz) from the RF frequency.
Use this property to keep the local oscillator (LO) leakage at a determined offset from
the RF signal.

Note You cannot set the Upconverter Center Frequency (Hz) property or the
Arb Carrier Frequency (Hz) property at the same time as the Upconverter
Frequency Offset (Hz) property.

318 ni.com

Note Resetting this property disables the upconverter frequency offset.

Supported Devices: PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842

niRFSG Properties

Valid Values:

PXIe-5644/5645: -42 MHz to +42 MHz

PXIe-5646: -100 MHz to +100 MHz

PXIe-5830/5831/5832/5840: -500 MHz to +500 MHz

PXIe-5841 (200 MHz bandwidth option): -100 MHz to +100 MHz

PXIe-5841 (1 GHz bandwidth option): -500 MHz to +500 MHz

PXI-5842 (500 MHz bandwidth option): -250 MHz to +250 MHz

PXI-5842 (1 GHz bandwidth option): -500 MHz to +500 MHz

PXI-5842 (2 GHz bandwidth option): -1 GHz to +1 GHz

PXI-5842 (4 GHz bandwidth option) using the Standard personality: -1 GHz to +1 GHz

PXI-5842 (4 GHz bandwidth option) using the 4 GHz Bandwidth personality: -2 GHz to
+2 GHz

Related Topics

PXIe-5830 Frequency and Bandwidth Selection

PXIe-5831/5832 Frequency and Bandwidth Selection

PXIe-5841 Frequency and Bandwidth Selection

Remarks

The following table lists the characteristics of this property.

© National Instruments 319

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Upconverter Frequency Offset (Hz)

niRFSG Properties

Read/Write

N/A

No

Yes

Events:Configuration Settled Event Export Output Terminal
Events:Configuration Settled Event Export Output Terminal

Specifies the destination terminal for exporting the Configuration Settled event. To set
this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5654/5654 with PXIe-5696, PXIe-5820/5830/5831/5832/5840/
5841/5842/5860, PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency
Extension, PXIe-5860 with S-parameters

Related Topics

Triggers

Events

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

ConfigurationSettledEvent.ExportOutputTerm

Data type

Permissions

Read/Write

High-level VIs

Channel-based

N/A

No

320 ni.com

niRFSG Properties

Resettable

Yes

Do not
export signal

The signal is not exported.

PXI_Trig0

PXI_Trig0

PXI trigger line 0

PXI_Trig1

PXI_Trig1

PXI trigger line 1

PXI_Trig2

PXI_Trig2

PXI trigger line 2

PXI_Trig3

PXI_Trig3

PXI trigger line 3

PXI_Trig4

PXI_Trig4

PXI trigger line 4

PXI_Trig5

PXI_Trig5

PXI trigger line 5

PXI_Trig6

PXI_Trig6

PXI trigger line 6

PXIe_DStarC  PXIe_DStarC

PXIe DStar C trigger line. This value is valid on only the PXIe-5820/
5830/5831/5832/5840/5841/5842/5860.

TrigOut

TrigOut

TRIG IN/OUT

Events:Configuration Settled Event Terminal Name
Events:Configuration Settled Event Terminal Name

Returns the fully qualified signal name as a string.

© National Instruments 321

niRFSG Properties

Supported Devices: PXIe-5654/5654 with PXIe-5696, PXIe-5820/5830/5831/5832/5840/
5841

Default Values:

PXIe-5654/5654 with PXIe-5696: /ModuleName/ConfigurationSettledEvent,
where ModuleName is the name of your device in MAX.

PXIe-5830/5831/5832: /BasebandModule/ao/0/
ConfigurationSettledEvent, where BasebandModule is the name of the
baseband module for your device in MAX.

PXIe-5820/5840/5841: /ModuleName/ao/0/ConfigurationSettledEvent,
where ModuleName is the name of your device in MAX.

Related Topics

Events

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ConfigurationSettledEvent.TerminalName

Read Only

N/A

No

No

Events:Done Event Export Output Terminal
Events:Done Event Export Output Terminal

Specifies the destination terminal for exporting the Done event. To set this property,
the NI-RFSG device must be in the Configuration state.

322 ni.com

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Related Topics

Triggers

Events

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

DoneEvent.ExportOutputTerm

Read/Write

niRFSG Export Signal

No

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PFI4

PFI4

The signal is exported to the PFI 4 connector.

© National Instruments 323

niRFSG Properties

PFI5

PFI5

The signal is exported to the PFI 5 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The signal is exported to the PXIe DStar C trigger line. This value is valid
on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

324 ni.com

niRFSG Properties

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Events:Done Event Terminal Name
Events:Done Event Terminal Name

Returns the fully qualified signal name as a string.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Default Values:

PXI-5670/5671, PXIe-5672/5673/5673E: /AWGName/DoneEvent, where AWGName is
the name of your associated AWG module in MAX.

PXIe-5830/5831/5832: /BasebandModule/ao/0/DoneEvent, where
BasebandModule is the name of the baseband module for your device in MAX.

PXIe-5820/5840/5841/5842: /ModuleName/ao/0/DoneEvent, where
ModuleName is the name of your device in MAX.

PXIe-5860: /ModuleName/ao/ChannelNumber/DoneEvent, where
ModuleName is the name of your device in MAX and ChannelNumber is the channel
number (0 or 1).

© National Instruments 325

niRFSG Properties

Related Topics

Events

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

DoneEvent.TerminalName

Read Only

niRFSG Get Terminal Name

No

No

Events:Marker:Output Behavior
Events:Marker:Output Behavior

Specifies the output behavior for the Marker Event. To set this property, the NI-RFSG
device must be in the Configuration state.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Default Value: Pulse

Related Topics

Marker Events

Remarks

The following table lists the characteristics of this property.

Short Name

MarkerEvent.OutputBehavior

326 ni.com

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

Pulse

23000

Specifies the Marker Event output behavior as pulse.

Toggle

23001

Specifies the Marker Event output behavior as toggle.

Events:Marker:Output Terminal
Events:Marker:Output Terminal

Specifies the destination terminal for exporting the Marker Event. To set this property,
the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Marker Events

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

MarkerEvent.ExportOutputTerm

© National Instruments 327

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

Read/Write

N/A

Yes

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PFI4

PFI4

The signal is exported to the PFI 4 connector.

PFI5

PFI5

The signal is exported to the PFI 5 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

328 ni.com

niRFSG Properties

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The signal is exported to the PXIe DStar C trigger line. This value is valid
on only the PXIe-5820/5830/5831/5832/5840/5841/5842.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Events:Marker:Pulse:Width Units
Events:Marker:Pulse:Width Units

Specifies the pulse width units for the Marker Event. This property is valid only when
the Marker Event Output Behavior property is set to Pulse.

© National Instruments 329

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

niRFSG Properties

Default Value: Seconds

Related Topics

Marker Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

MarkerEvent.Pulse.WidthUnits

Read/Write

N/A

Yes

Yes

Seconds

22000  Specifies the Marker Event pulse width units as seconds.

Sample Clock
Periods

22001

Specifies the Marker Event pulse width units as Sample Clock
periods.

Events:Marker:Pulse:Width Value
Events:Marker:Pulse:Width Value

Specifies the pulse width value for the Marker Event. Use the Marker Event Pulse Width
Units property to set the units for the pulse width value. This property is valid only
when the Marker Event Output Behavior property is set to Pulse.

To set this property, the NI-RFSG device must be in the Configuration state.

330 ni.com

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

niRFSG Properties

Default Value: 200 ns

Related Topics

Marker Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

MarkerEvent.Pulse.WidthValue

Read/Write

N/A

Yes

Yes

Events:Marker:Terminal Name
Events:Marker:Terminal Name

Returns the fully qualified signal name as a string.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Default Values:

PXI-5670/5671, PXIe-5672/5673/5673E: /AWGName/MarkerXEvent, where
AWGName is the name of your associated AWG module in MAX and X is Marker Event 0
through 3.

PXIe-5830/5831/5832: /BasebandModule/ao/0/MarkerXEvent, where
BasebandModule is the name of the baseband module for your device in MAX and X is
Marker Event 0 through 3.

© National Instruments 331

PXIe-5820/5840/5841/5842: /ModuleName/ao/0/MarkerXEvent, where
ModuleName is the name of your device in MAX and X is Marker Event 0 through 3.

niRFSG Properties

Related Topics

Events

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

MarkerEvent.TerminalName

Read Only

niRFSG Get Terminal Name

Yes

No

Events:Marker:Toggle:Initial State
Events:Marker:Toggle:Initial State

Specifies the initial state for the Marker Event when the Marker Event Output Behavior
property is set to Toggle.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Default Value: Digital Low

Related Topics

Marker Events

332 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

MarkerEvent.Toggle.InitialState

Read/Write

N/A

Yes

Yes

Digital Low  21000  Specifies the initial state of the Marker Event toggle behavior as digital low.

Digital High  21001  Specifies the initial state of the Marker Event toggle behavior as digital high.

Events:Pulse Modulation:Exported Pulse Modulation Event Active
Events:Pulse Modulation:Exported Pulse Modulation Event Active
Level
Level

Specifies the active level of the exported Pulse Modulation Event. When
`NIRFSG_ATTR_PULSE_MODULATION_ENABLED` is Enabled,
`NIRFSG_ATTR_PULSE_MODULATION_ACTIVE_LEVEL` is
`NIRFSG_VAL_ACTIVE_HIGH`,
`NIRFSG_ATTR_EXPORTED_PULSE_MODULATION_EVENT_OUTPUT_TERMINAL` is
`PulseOut`, and this property is `NIRFSG_VAL_ACTIVE_HIGH`, then the Pulse
Modulation Event will transition from Low to High after the the Pulse In signal is set to
logic high, and the RF Output has settled. To set this property, the NI-RFSG device must
be in the Configuration state.

Supported Devices: PXIe-5842

Default Value: Active High

© National Instruments 333

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Exported Pulse Modulation Event Active Level

Data type

Permissions

Read/Write

High-level VIs

Channel-based

Resettable

N/A

Yes

Yes

Active High

9000  When the trigger has started, the active level is high.

Active Low

9001  When the trigger has started, the active level is low.

Events:Pulse Modulation:Exported Pulse Modulation Event Output
Events:Pulse Modulation:Exported Pulse Modulation Event Output
Terminal
Terminal

Specifies the destination terminal for exporting the Pulse Modulation Event. The Pulse
Modulation Event tracks the RF Envelope when Pulse Modulation is Enabled. If this
property is set to a value other than `NIRFSG_VAL_DO_NOT_EXPORT_STR`, calling NI-
RFSG Commit will cause the output terminal to be pulled to the logic level that is the
inverse of `NIRFSG_ATTR_EXPORTED_PULSE_MODULATION_EVENT_ACTIVE_LEVEL`.
You can tri-state this terminal by setting this property to
`NIRFSG_VAL_DO_NOT_EXPORT_STR` or by calling `niRFSG Reset`. To set this
property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5842

Default Value: PulseOut

334 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Exported Pulse Modulation Event Output Terminal

Data type

Permissions

Read/Write

High-level VIs

Channel-based

Resettable

N/A

Yes

Yes

Do not export signal

Do not export the pulse video signal.

PulseOut

PulseOut

Export the pulse video signal to the pulse out terminal.

Events:Started Event Export Output Terminal
Events:Started Event Export Output Terminal

Specifies the destination terminal for exporting the Started Event. To set this property,
the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Events

PFI Lines

PXI Trigger Lines

© National Instruments 335

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

StartedEvent.ExportOutputTerm

Read/Write

N/A

No

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PFI4

PFI4

The signal is exported to the PFI 4 connector.

PFI5

PFI5

The signal is exported to the PFI 5 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

336 ni.com

niRFSG Properties

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The trigger is exported to the PXIe DStar C trigger line. This value is
valid on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

© National Instruments 337

niRFSG Properties

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Events:Started Event Terminal Name
Events:Started Event Terminal Name

Returns the fully qualified signal name as a string.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Default Values:

PXI-5670/5671, PXIe-5672/5673/5673E: /AWGName/StartedEvent, where
AWGName is the name of your associated AWG module in MAX.

PXIe-5830/5831/5832: /BasebandModule/ao/0/StartedEvent, where
BasebandModule is the name of the baseband module for your device in MAX.

PXIe-5820/5840/5841/5842: /ModuleName/ao/0/StartedEvent, where
ModuleName is the name of your device in MAX.

PXIe-5860: /ModuleName/ao/ChannelNumber/StartedEvent, where
ModuleName is the name of your device in MAX and ChannelNumber is the channel
number (0 or 1).

Related Topics

Events

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

Short Name

StartedEvent.TerminalName

338 ni.com

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Events:Timer:Interval
Events:Timer:Interval

Read Only

niRFSG Get Terminal Name

No

No

Specifies the time, in seconds, before the timer emits an event after the task is started
and specifies the time interval between timer events after the first event.

Note For the PXIe-5820/5840/5841, this property must be set for the timer to
start. If you do not set this property, the timer is disabled.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841

Default Value: 0

Related Topics

Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Timer Event Interval

Read/Write

N/A

No

Yes

© National Instruments 339

niRFSG Properties

External Calibration:Last External Calibration Temperature
External Calibration:Last External Calibration Temperature

Indicates the temperature, in degrees Celsius, of the device at the time of the last
external calibration.

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Last External Cal Temp

Read Only

N/A

No

No

External Calibration:Recommended Interval
External Calibration:Recommended Interval

Indicates, in months, the recommended interval between each external calibration of
the device.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Recommended Interval

Short Name

Data type

340 ni.com

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read Only

N/A

No

No

IQ Impairment:Enabled
IQ Impairment:Enabled

Enables or disables I/Q impairment. The I Offset, Q Offset, and IQ Skew properties are
ignored when the Impairment Enabled property is disabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Default Value: Enabled

Enabled

Disabled

Remarks

Enables I/Q impairment.

Disables I/Q impairment.

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Impairment Enabled

Read/Write

N/A

No

Yes

IQ Impairment:Gain Imbalance (dB)
IQ Impairment:Gain Imbalance (dB)

Specifies the gain imbalance of the I/Q modulator (I versus Q).

© National Instruments 341

niRFSG Properties

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Valid Values: -6 dB to 6 dB

Gain imbalance is calculated with the following equation:

Related Topics

Impairment Calibration

Spurious Performance

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Gain Imbalance (dB)

Read/Write

N/A

No

Yes

IQ Impairment:I Offset
IQ Impairment:I Offset

When using an NI AWG module or vector signal transceiver (VST) device, this property
specifies the I-signal DC offset. Units are either percent (%) or volts (V), depending on
the Offset Units property setting.

PXIe-5673/5673E: Actual AWG signal offset is equal to the I/Q modulator offset
correction plus the value specified by this property. When using an external AWG (non-
NI AWG), this property is read-only and indicates the I/Q modulator I-offset. Units are

342 ni.com

niRFSG Properties

volts, as specified by the Offset Units property.

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Valid Values: -100% to 100% or -0.2 V to 0.2 V

Related Topics

Impairment Calibration

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

I Offset

Read/Write

N/A

No

Yes

IQ Impairment:IQ Skew (Degrees)
IQ Impairment:IQ Skew (Degrees)

Specifies the adjustment of the phase angle between the I and Q vectors. If this skew is
zero, the phase angle is 90 degrees.

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Valid Values: -30 degrees to 30 degrees

Related Topics

Impairment Calibration

© National Instruments 343

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

IQ Skew (Degrees)

Read/Write

N/A

No

Yes

IQ Impairment:Offset Units
IQ Impairment:Offset Units

Specifies the units of the I Offset property and the Q Offset property. Offset units are
either percent (%) or volts (V).

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Default Value: Percent

The AWG or VST offset is the specified percentage of the AWG or VST peak power level
when the Offset Units property is set to Percent. Given perfect carrier leakage
suppression, the following equation is satisfied:

or equivalently,

If the I Offset property is set to 100%, the Q Offset property is set to 0%, and the Power
Level (dBm) property is set to 0 dBm, the desired RF signal is at 0 dBm and the carrier
leakage is also at 0 dBm.

344 ni.com

niRFSG Properties

Note For any devices except PXIe-5820, if the Offset Units property is set to
Volts, a 0.1 I offset results in a 0.1 V offset in the output. For PXIe-5820
devices, 0.1 I offset results in a 10% offset in the output.

The AWG or VST peak power level changes when settings change in other properties
such as the Power Level (dBm), Frequency (Hz), IQ Skew (Degrees), Gain Imbalance
(dB), Attenuator Hold Enabled, and Arb Pre-filter Gain (dB) properties. When the Offset
Units property is set to Percent, the actual AWG or VST offset changes as the AWG or
VST peak power level changes in order to satisfy the preceding equations. These
changes are useful if you are intentionally adding carrier leakage to test the tolerance
of a receiver. When the Offset Units property is set to Percent, the carrier leakage, in
dBc, remains at a consistent level.

If you are trying to eliminate residual carrier leakage due to calibration inaccuracies or
drift, set the Offset Units property to volts. Offset correction voltage is applied to the
I/Q modulator or VST, regardless of changes to the AWG or VST peak power level.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Offset Units

Read/Write

N/A

No

Yes

Percent

11000

Specifies the I Offset and Q Offset property units as percent.

Volts

11001

Specifies the I Offset and Q Offset property units as volts.

© National Instruments 345

niRFSG Properties

IQ Impairment:Q Offset
IQ Impairment:Q Offset

When using a NI AWG module or VST device, this property specifies the Q-signal DC
offset. Units are either percent (%) or volts (V), depending on the Offset Units property
setting.

PXIe-5673/5673E: Actual AWG signal offset is equal to the I/Q modulator offset
correction plus the value specified by this property. When using an external AWG, this
property is read-only and indicates the I/Q modulator Q-offset. Units are volts, as
indicated by the Offset Units property.

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842

Valid Values: -100% to 100% or -0.2 V to 0.2 V

Related Topics

Impairment Calibration

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Q Offset

Read/Write

N/A

No

Yes

Inherent IVI Attributes:Advanced Session Information:Logical Name
Inherent IVI Attributes:Advanced Session Information:Logical Name

Returns a string that contains the logical name you specified when opening the current
IVI session.

346 ni.com

niRFSG Properties

You can pass a logical name to the niRFSG Initialize VI or the niRFSG Initialize with
Options VI. The IVI Configuration Utility must contain an entry for the logical name.
The logical name entry refers to a driver session section in the IVI Configuration file.
The driver session section specifies a physical device and initial user options.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Logical Name

Read Only

N/A

No

No

Inherent IVI Attributes:Advanced Session Information:Resource
Inherent IVI Attributes:Advanced Session Information:Resource
Descriptor
Descriptor

Returns a string that contains the resource descriptor NI-RFSG uses to identify the
physical device. If you initialize NI-RFSG with a logical name, this property contains the
resource name that corresponds to the entry in the IVI Configuration Utility. If you
initialize NI-RFSG with the resource name, this property contains that value.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

© National Instruments 347

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Resource Descriptor

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Capabilities:Class Group Capabilities
Inherent IVI Attributes:Driver Capabilities:Class Group Capabilities

Returns a string that contains a comma-separated list of class-extension groups that
NI-RFSG implements.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Class Group Capabilities

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Capabilities:Supported Instrument
Inherent IVI Attributes:Driver Capabilities:Supported Instrument
Models
Models

Returns a string that contains a model code of the NI-RFSG device. For drivers that
support more than one device, this property contains a comma-separated list of

348 ni.com

supported devices.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Supported Instrument Models

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Identification:Class Specification Major
Inherent IVI Attributes:Driver Identification:Class Specification Major
Version
Version

Returns the major version number of the class specification with which NI-RFSG is
compliant.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Class Specification Major Version

Read Only

© National Instruments 349

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

No

Inherent IVI Attributes:Driver Identification:Class Specification Minor
Inherent IVI Attributes:Driver Identification:Class Specification Minor
Version
Version

Returns the minor version number of the class specification with which NI-RFSG is
compliant.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Class Specification Minor Version

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Identification:Description
Inherent IVI Attributes:Driver Identification:Description

Returns a string that contains a brief description of NI-RFSG. This property returns
National Instruments RF Signal Generator Instrument Driver.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

350 ni.com

Remarks

The following table lists the characteristics of this property.

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Description

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Identification:Driver Prefix
Inherent IVI Attributes:Driver Identification:Driver Prefix

Returns a string that contains the prefix for NI-RFSG. The name of each user-callable VI
in NI-RFSG starts with this prefix. This property returns niRFSG.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Driver Prefix

Read Only

N/A

No

No

© National Instruments 351

niRFSG Properties

Inherent IVI Attributes:Driver Identification:Driver Vendor
Inherent IVI Attributes:Driver Identification:Driver Vendor

Returns a string that contains the name of the vendor that supplies NI-RFSG. This
property returns National Instruments.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Driver Vendor

Read Only

N/A

No

No

Inherent IVI Attributes:Driver Identification:Revision
Inherent IVI Attributes:Driver Identification:Revision

Returns a string that contains additional version information about NI-RFSG. For
example, NI-RFSG can return Driver: NI-RFSG 14.5.0, Compiler: MSVC
9.00, Components: IVI Engine 4.00, VISA-Spec 4.00 as the value of
this property.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

352 ni.com

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

niRFSG Properties

Revision

Read Only

N/A

No

No

Inherent IVI Attributes:Instrument Identification:Firmware Revision
Inherent IVI Attributes:Instrument Identification:Firmware Revision

Returns a string that contains the firmware revision information for the NI-RFSG device
you are currently using.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Firmware Revision

Read Only

niRFSG Revision Query

No

No

Inherent IVI Attributes:Instrument Identification:Manufacturer
Inherent IVI Attributes:Instrument Identification:Manufacturer

Returns a string that contains the name of the manufacturer for the NI-RFSG device
you are currently using.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/

© National Instruments 353

niRFSG Properties

5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Manufacturer

Read Only

N/A

No

No

Inherent IVI Attributes:Instrument Identification:Model
Inherent IVI Attributes:Instrument Identification:Model

Returns a string that contains the model number or name of the NI-RFSG device you
are currently using.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

354 ni.com

Model

Read Only

N/A

No

No

niRFSG Properties

Inherent IVI Attributes:User Options:Cache
Inherent IVI Attributes:User Options:Cache

Specifies whether to cache the value of properties. When caching is enabled, NI-RFSG
tracks the current NI-RFSG device settings and avoids sending redundant commands
to the device. NI-RFSG can always cache or never cache particular properties,
regardless of the setting of this property. Call the niRFSG Initialize With Options VI to
override the default value.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

TRUE

FALSE

Remarks

Enables caching.

Disables caching.

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Cache

Read/Write

N/A

No

No

Inherent IVI Attributes:User Options:Interchange Check
Inherent IVI Attributes:User Options:Interchange Check

Specifies whether to perform interchangeability checking and retrieve
interchangeability warnings.

Note Enabling interchangeability check is not supported.

© National Instruments 355

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

niRFSG Properties

TRUE

FALSE

Enables interchange check.

Disables interchange check.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Interchange Check

Read/Write

N/A

No

No

Inherent IVI Attributes:User Options:Query Instrument Status
Inherent IVI Attributes:User Options:Query Instrument Status

Specifies whether the NI-RFSG instrument driver queries the device status after each
operation. Querying the device status is useful for debugging. After you validate your
program, you can set this property to FALSE to disable status checking and maximize
performance. NI-RFSG can choose to ignore status checking for particular properties,
regardless of the setting of this property. Call the niRFSG Initialize With Options VI to
override the default value.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

TRUE

Queries the instrument status after each operation.

FALSE

Does not query the instrument status.

356 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Query Instrument Status

Read/Write

N/A

No

No

Inherent IVI Attributes:User Options:Range Check
Inherent IVI Attributes:User Options:Range Check

Specifies whether to validate property values and VI parameters. Range-checking
parameters is very useful for debugging. After you validate your program, you can set
this property to FALSE to disable range checking and maximize performance. NI-RFSG
can choose to ignore range checking for particular properties, regardless of the setting
of this property. Call the niRFSG Initialize With Options VI to override the default value.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

TRUE

Validates the parameter values that you pass to NI-RFSG VIs.

FALSE

Does not validate the parameter values.

Default Value: TRUE

Remarks

The following table lists the characteristics of this property.

Short Name

Range Check

© National Instruments 357

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

No

Inherent IVI Attributes:User Options:Record Value Coercions
Inherent IVI Attributes:User Options:Record Value Coercions

Specifies whether the IVI engine keeps a list of the value coercions it makes for integer
and real type properties.

Note Enabling record value coercions is not supported.

Supported Devices: PXI-5610, PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

The IVI engine keeps a list of coercions.

The IVI engine does not keep a list of coercions.

TRUE

FALSE

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

358 ni.com

Record Value Coercions

Read/Write

N/A

No

No

niRFSG Properties

Inherent IVI Attributes:User Options:Simulate
Inherent IVI Attributes:User Options:Simulate

Specifies whether NI-RFSG simulates I/O operations. This property is useful for
debugging applications without using hardware. After a session is opened, you cannot
change the simulation state. Call the niRFSG Initialize With Options VI to enable
simulation.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Simulation is enabled.

Simulation is disabled.

TRUE

FALSE

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Simulate

Read Only

N/A

No

No

Load Configurations:Load Options
Load Configurations:Load Options

Specifies the configurations to skip while loading from a file.

Default Values: Skip None

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

© National Instruments 359

Remarks

The following table lists the characteristics of this property.

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Load Options

Read/Write

N/A

Yes

Yes

Skip None

0  NI-RFSG loads all the configurations to the session.

Skip Waveforms

1  NI-RFSG skips loading the waveform configurations to the session.

Skip Scripts

2  NI-RFSG skips loading the scripts to the session.

Load Configurations:Reset Options
Load Configurations:Reset Options

Specifies the configurations to skip to reset while loading configurations from a file.

Default Values: Skip None

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Reset Options

360 ni.com

niRFSG Properties

Data type

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

Skip Waveforms

1  NI-RFSG skips resetting the waveform configurations.

Skip De-embedding Tables  8  NI-RFSG skips resetting the de-embedding tables configurations.

Skip Scripts

2  NI-RFSG skips resetting the scripts configurations.

Skip None

0  NI-RFSG resets all the configurations.

Modulation:Analog:AM Sensitivity
Modulation:Analog:AM Sensitivity

Specifies an uncalibrated digital-to-analog converter (DAC) value that scales the input
signal before the signal modulates the carrier. A value of 0 completely attenuates the
signal, and a value of 100 passes the full-scale signal to the modulator.

When using the PXIe-5654with PXIe-5696, NI-RFSG may coerce AM sensitivity. Coercing
the AM sensitivity prevents overpower conditions at the PXIe-5696 input. Read this
property to determine the coerced value.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: 100

Valid Values: 0 to 100

Related Topics

© National Instruments 361

niRFSG Properties

Amplitude Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.AM Sensitivity

Read/Write

N/A

No

Yes

Modulation:Analog:FM Band
Modulation:Analog:FM Band

Specifies the analog modulation frequency modulation (FM) band to use. Wideband
FM allows for modulating signals higher than 100 kHz. Narrowband FM allows for
modulating lower frequency signals.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: Wideband

Related Topics

Frequency Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

362 ni.com

AnlgMod.FM Band

Read/Write

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

Yes

Narrowband

17000

Specifies narrowband frequency modulation.

Wideband

17001

Specifies wideband frequency modulation.

Modulation:Analog:FM Deviation (Hz)
Modulation:Analog:FM Deviation (Hz)

Specifies the deviation to use in frequency modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 1 kHz

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.FMDev (Hz)

Read/Write

N/A

No

Yes

© National Instruments 363

niRFSG Properties

Modulation:Analog:FM Narrowband Integrator
Modulation:Analog:FM Narrowband Integrator

Specifies the narrowband frequency modulation (FM) range to apply by sending the
signal through an integrator.

This property is valid only when you set the Modulation Type property to FM and the
FM Band property to Narrowband.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: 100 Hz to 1 kHz

Related Topics

Frequency Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.FM Narrowband Integrator

Read/Write

N/A

No

Yes

100Hz to 1kHz

18000

Specifies a range from 100 Hz to 1 kHz

1kHz to 10kHz

18001

Specifies a range from 1 kHz to 10 kHz

10kHz to 100kHz

18002

Specifies a range from 10 kHz to 100 kHz

364 ni.com

niRFSG Properties

Modulation:Analog:FM Sensitivity
Modulation:Analog:FM Sensitivity

Specifies an uncalibrated digital-to-analog converter (DAC) value that scales the input
signal before the signal modulates the carrier. A value of 0 completely attenuates the
signal, and a value of 100 passes the full-scale signal to the modulator.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: 100

Valid Values: 0 to 100

Related Topics

Frequency Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.FM Sensitivity

Read/Write

N/A

No

Yes

Modulation:Analog:Modulation Type
Modulation:Analog:Modulation Type

Specifies the analog modulation format to use.

Supported Devices: PXI/PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696

Default Value: None

Related Topics

© National Instruments 365

niRFSG Properties

Modulation

PXI/PXIe-5650/5651/5652 Modulation Schemes

PXIe-5654/5654 with PXIe-5696 Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.Type

Read/Write

N/A

No

Yes

None

0

Disables analog modulation.

FM

2000

Specifies that the analog modulation type is FM.

PM

2001

Specifies that the analog modulation type is PM.

AM

2002

Specifies that the analog modulation type is AM.

Modulation:Analog:PM Deviation (Degrees)
Modulation:Analog:PM Deviation (Degrees)

Specifies the deviation to use in phase modulation, in degrees.

Supported Devices: PXI/PXIe-5650/5651/5652, PXIe-5653

366 ni.com

Default Value: 90 degrees

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.PMDev (Degrees)

Read/Write

N/A

No

Yes

Modulation:Analog:PM Mode
Modulation:Analog:PM Mode

Specifies the phase modulation (PM) mode to use.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: Low Phase Noise

Related Topics

Phase Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

AnlgMod.PM Mode

niRFSG Properties

© National Instruments 367

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

Yes

High
Deviation

19000

Specifies high deviation. High deviation comes at the expense of a higher
phase noise.

Low Phase
Noise

19001

Specifies low phase noise. Low phase noise comes at the expense of a lower
maximum deviation.

Modulation:Analog:PM Sensitivity
Modulation:Analog:PM Sensitivity

Specifies an uncalibrated digital-to-analog converter (DAC) value that scales the input
signal before the signal modulates the carrier. A value of 0 completely attenuates the
signal, and a value of 100 passes the full-scale signal to the modulator.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Value: 100

Valid Values: 0 to 100

Related Topics

Phase Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

368 ni.com

AnlgMod.PM Sensitivity

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

Yes

Modulation:Analog:Waveform Frequency (Hz)
Modulation:Analog:Waveform Frequency (Hz)

Specifies the frequency of the waveform to use as the message signal in analog
modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 1 kHz

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.WfmFreq (Hz)

Read/Write

N/A

No

Yes

Modulation:Analog:Waveform Type
Modulation:Analog:Waveform Type

Specifies the type of waveform to use as the message signal for analog modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

© National Instruments 369

niRFSG Properties

Default Value: Sine

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

AnlgMod.WfmType

Read/Write

N/A

No

Yes

Sine

3000

Specifies that the analog modulation waveform type is sine.

Square

3001

Specifies that the analog modulation waveform type is square.

Triangle

3002

Specifies that the analog modulation waveform type is triangle.

Modulation:Digital:FSK Deviation (Hz)
Modulation:Digital:FSK Deviation (Hz)

Specifies the deviation to use in FSK modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 1 kHz

370 ni.com

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

DigMod.FskDev (Hz)

Read/Write

N/A

No

Yes

Modulation:Digital:Modulation Type
Modulation:Digital:Modulation Type

Specifies the digital modulation format to use.

Supported Devices: PXI/PXIe-5650/5651/5652

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

DigMod.Type

Read/Write

N/A

No

niRFSG Properties

© National Instruments 371

niRFSG Properties

Resettable

Yes

None  0

Disables digital modulation.

FSK

4000  Specifies that the digital modulation type is frequency-shift keying (FSK).

OOK

4001  Specifies that the digital modulation type is on-off keying (OOK).

PSK

4002  Specifies that the digital modulation type is phase-shift keying (PSK).

Modulation:Digital:PRBS Order
Modulation:Digital:PRBS Order

Specifies the order of the pseudorandom bit sequence ( PRBS) internally generated by
hardware and used as the message signal in digital modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 16

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

372 ni.com

DigMod.PrbsOrder

Read/Write

N/A

niRFSG Properties

Channel-based

Resettable

No

Yes

Modulation:Digital:PRBS Seed
Modulation:Digital:PRBS Seed

Specifies the seed of the internally generated pseudorandom bit sequence (PRBS).

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 1

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

DigMod.PrbsSeed

Read/Write

N/A

No

Yes

Modulation:Digital:Symbol Rate
Modulation:Digital:Symbol Rate

Specifies the symbol rate of the bit stream for digital modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: 1 kHz

Related Topics

© National Instruments 373

niRFSG Properties

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

DigMod.Symbol Rate

Read/Write

N/A

No

Yes

Modulation:Digital:Waveform Type
Modulation:Digital:Waveform Type

Specifies the type of waveform to use as the message signal in digital modulation.

Supported Devices: PXI/PXIe-5650/5651/5652

Default Value: PRBS

Related Topics

Modulation Schemes

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

374 ni.com

DigMod.WfmType

Read/Write

N/A

No

Resettable

Yes

niRFSG Properties

PRBS

5000  Specifies that the digital waveform type is pseudorandom bit sequence (PRBS).

User
Defined

5001

Specifies that the digital waveform type is user-defined. To specify the user-defined
waveform, call the niRFSG Configure Digital Modulation User Defined Waveform VI.

Modulation:Pulse:Pulse Modulation Active Level
Modulation:Pulse:Pulse Modulation Active Level

Specifies the active level of the pulse modulation signal when pulse modulation is
enabled. To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5842

Default Value: Active High

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Pulse Modulation Active Level

Read/Write

N/A

Yes

Yes

Active High

9000  When the trigger has started, the active level is high.

© National Instruments 375

niRFSG Properties

Active Low

9001  When the trigger has started, the active level is low.

Modulation:Pulse:Pulse Modulation Enabled
Modulation:Pulse:Pulse Modulation Enabled

Enables or disables pulse modulation.

PXIe-5654/5654 with PXIe-5696: If this property is enabled and the signal at the
PULSE IN front panel connector is high, the device generates a signal. If the signal is
low, output generation is disabled.

PXIe-5673/5673E: If this property is enabled and the signal at the PLS MOD front panel
connector is high, the device generates a signal. If the signal is low, output generation
is disabled.

PXIe-5842: If this property is enabled and the signal at the PLS MOD front panel
connector is high, the device generates a signal. If the signal is low, output generation
is disabled.This behavior can be modified by setting
`NIRFSG_ATTR_PULSE_MODULATION_ACTIVE_LEVEL`

Supported Devices: PXIe-5654/5654 with PXIe-5696, PXIe-5673/5673E/5842

Related Topics

Pulse Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

376 ni.com

Pulse Modulation Enabled

Read/Write

N/A

No

niRFSG Properties

Resettable

Yes

Modulation:Pulse:Pulse Modulation Mode
Modulation:Pulse:Pulse Modulation Mode

This property allows you to choose a tradeoff between switching speed and On/Off
Ratio when using pulse modulation. Refer to the product specifications document for
the switching characteristics of each mode. This property is settable while the device is
generating, but some output pulses may be dropped.

Supported Devices: PXIe-5842/5654/5654 with PXIe-5696

Default Value: Analog

Related Topics

Pulse Modulation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Pulse Modulation Mode

Read/Write

N/A

No

Yes

Optimal
Match

20000

Provides for a more optimal power output match for the device during the off
cycle of the pulse mode operation. This is not supported on PXIe-5842

High
Isolation

20001  Allows for the best on/off power ratio of the pulsed signal.

© National Instruments 377

niRFSG Properties

Analog

20002

Analog switch blanking. Balance between switching speed and on/off power
ratio of the pulsed signal.

Digital

20003

Digital only modulation. Provides the best on/off switching speed of the pulsed
signal at the cost of signal isolation.

Modulation:Pulse:Pulse Modulation Source
Modulation:Pulse:Pulse Modulation Source

Specifies the source of the pulse modulation signal. When Pulse In in used, the pulse
modulation is applied with the lowest latency and jitter, but is not aligned to any
particular waveform sample. When a marker is used, the RF pulse is aligned to a
specific sample in the arbitrary waveform. To set this property, the NI-RFSG device
must be in the Configuration state.

Supported Devices: PXIe-5842

Default Value: PulseIn

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Pulse Modulation Source

Read/Write

N/A

Yes

Yes

Do not drive signal

Do not drive pulse modulation.

378 ni.com

PulseIn

PulseIn  Use the PULSE IN terminal to drive pulse modulation of the signal.

niRFSG Properties

Marker0

Marker0  Uses Marker0 to drive pulse modulation of the signal.

Marker1

Marker1  Uses Marker1 to drive pulse modulation of the signal.

Marker2

Marker2  Uses Marker2 to drive pulse modulation of the signal.

Marker3

Marker3  Uses Marker3 to drive pulse modulation of the signal.

Peer-to-Peer:Data Transfer Permission Initial Credits
Peer-to-Peer:Data Transfer Permission Initial Credits

Specifies the initial amount of data, in samples per channel, that the writer peer is
allowed to transfer over the bus into the configured endpoint when the peer-to-peer
data stream is enabled. If this property is not set and the endpoint is empty, credits
equal to the full size of the endpoint are issued to the writer peer. If data has been
written to the endpoint using the niRFSG Write P2P Endpoint (I16) VI prior to enabling
the stream, credits equal to the remaining space available in the endpoint are issued
to the writer peer. This property is coerced up by NI-RFSG to 8 byte boundaries. This
property is endpoint-based.

Supported Devices: PXIe-5673E

Default Value: 1,024 samples per channel

Related Topics

Configuring a Peer-to-Peer Endpoint

Configuring Flow Control

© National Instruments 379

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Data Transfer Permission Initial Credits

Read/Write

N/A

No

No

Peer-to-Peer:Data Transfer Permission Interval
Peer-to-Peer:Data Transfer Permission Interval

Specifies the interval, in samples per channel, at which the RF signal generator issues
credits to allow the writer peer to transfer data over the bus into the configured
endpoint. This property is coerced up by NI-RFSG to the nearest 128 byte boundary.
This property is endpoint-based.

Supported Devices: PXIe-5673E

Related Topics

Configuring a Peer-to-Peer Endpoint

Configuring Flow Control

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

380 ni.com

Data Transfer Permission Interval

Read/Write

N/A

niRFSG Properties

Channel-based

Resettable

No

No

Peer-to-Peer:Enabled
Peer-to-Peer:Enabled

Specifies whether the device reads data from the peer-to-peer endpoint. This property
is endpoint-based.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Default Value: FALSE

TRUE

FALSE

Peer-to-peer data streaming is enabled.

Peer-to-peer data streaming is disabled.

Related Topics

Configuring a Peer-to-Peer Endpoint

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

P2P Enabled

Read/Write

N/A

Yes

Yes

Peer-to-Peer:Endpoint Count
Peer-to-Peer:Endpoint Count

Returns the number of peer-to-peer FIFO endpoints supported by the device.

© National Instruments 381

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

niRFSG Properties

Related Topics

Configuring a Peer-to-Peer Endpoint

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

P2P Endpoint Count

Read Only

N/A

No

No

Peer-to-Peer:Endpoint Size
Peer-to-Peer:Endpoint Size

Returns the size, in samples, of the device's endpoint. This property is endpoint-based.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Configuring a Peer-to-Peer Endpoint

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

382 ni.com

P2P Endpoint Size

Read Only

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

Yes

No

Peer-to-Peer:Generation FIFO Sample Quantum
Peer-to-Peer:Generation FIFO Sample Quantum

Returns how many samples NI-RFSG pulls from the peer-to-peer FIFO per read. You can
use this property to determine how many samples to send across the peer-to-peer bus
to ensure that no samples are ignored. If you send a number of samples that is not a
multiple of this value, the remaining samples are not read from the FIFO during
generation. This property is endpoint-based.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

P2P Generation FIFO Sample Quantum

Read Only

N/A

Yes

No

Peer-to-Peer:Is Finite Generation
Peer-to-Peer:Is Finite Generation

Specifies whether peer-to-peer should continuously generate data from the peer-to-
peer stream or from only a finite number of samples, according to the Number Of
Samples To Generate property. To use this property, peer-to-peer must be enabled.
This property is endpoint-based.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

© National Instruments 383

niRFSG Properties

Default Value: FALSE

TRUE

Data is generated from only a finite number of samples.

FALSE

Data is continuously generated from the peer-to-peer stream.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Is Finite P2P Generation

Read/Write

N/A

Yes

Yes

Peer-to-Peer:Most Space Available in Endpoint
Peer-to-Peer:Most Space Available in Endpoint

Returns the largest number of samples per channel available in the endpoint since this
property was last read. You can use this property to determine how much endpoint
space to use as a buffer against bus traffic latencies by reading the property and
keeping track of the largest value returned. This property is endpoint-based.

If you want to minimize the latency for data to move through the endpoint and be
generated by the RF signal generator, use the Data Transfer Permission Initial Credits
property to grant fewer initial credits than the default of the entire endpoint size.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Configuring a Peer-to-Peer Endpoint

384 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

P2P Most Space Available In Endpoint

Read Only

N/A

Yes

No

Peer-to-Peer:Number Of Samples To Generate
Peer-to-Peer:Number Of Samples To Generate

Specifies how many samples are generated from the peer-to-peer subsystem when it is
enabled. To use this property, peer-to-peer must be enabled and set to finite
generation. This property is endpoint-based.

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Configuring a Peer-to-Peer Endpoint

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Number Of P2P Samples To Generate

Read/Write

N/A

Yes

Yes

© National Instruments 385

niRFSG Properties

Peer-to-Peer:Space Available In Endpoint
Peer-to-Peer:Space Available In Endpoint

Returns the current space available in the endpoint in samples per channel. You can
use this property when priming the endpoint with initial data through the niRFSG
Write P2P Endpoint (I16) VI to determine how many samples you can write. You can
also use this property to characterize the performance and measure the latency of the
peer-to-peer stream as data moves across the bus. This property is endpoint-based.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Configuring a Peer-to-Peer Endpoint

Starting Peer-to-Peer Generation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

P2P Space Available In Endpoint

Read Only

N/A

Yes

No

RF:ALC Control
RF:ALC Control

Enables or disables the automatic leveling control (ALC).

PXIe-5654 with PXIe-5696: If this property is enabled, the ALC is closed (closed-loop
mode) and allows for better amplitude accuracy and wider amplitude dynamic range.
If this property is disabled, the ALC is open (open-loop mode), which is ideal when
using modulation. Disabling the ALC Control property also allows NI-RFSG to perform

386 ni.com

niRFSG Properties

an automatic power search.

PXIe-5654: Disable is the only supported value for this device. The PXIe-5654 does not
support the ALC when used as a stand-alone device.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Values:

PXIe-5654: Disable

PXIe-5654 with PXIe-5696: Enable

Related Topics

Power Level Adjustment

ALC Closed Loop Versus Open Loop

Power Search

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ALC Control

Read/Write

N/A

No

Yes

Disable

0

Disables the ALC.

© National Instruments 387

niRFSG Properties

Enable

1

Enables the ALC.

RF:Advanced:Amp Path
RF:Advanced:Amp Path

Specifies the amplification path to use. The low harmonic path provides greater
second and third harmonic spurious response, and the high power path provides
higher output power.

NI-RFSG automatically sets the value of this property based on power and frequency
settings. Setting this property overrides the value chosen by NI-RFSG.

Note Resetting this property reverts back to the default unset behavior.

Supported Devices: PXIe-5654 with PXIe-5696

Default Value: Low Harmonic

Related Topics

Low Harmonic Path Versus High Power Path

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

388 ni.com

Amp Path

Read/Write

N/A

No

Yes

niRFSG Properties

High Power

16000

Sets the amplification path to use the high power path.

Low Harmonic

16001

Sets the amplification path to use the low harmonic path.

RF:Advanced:Correction Temperature
RF:Advanced:Correction Temperature

Specifies the temperature, in degrees Celsius, to use for adjusting the device settings
to correct for temperature changes. If you set this property, NI-RFSG uses the value you
specify and therefore no longer uses the actual device temperature as the correction
temperature. If you do not set this property, NI-RFSG checks the current device
temperature in the Committed state and automatically sets the value of this property.

Note Resetting this property reverts back to the default unset behavior.

Note Use this property only when your application requires the same
settings to be used every time, regardless of the temperature variation. In
these cases, it is best to ensure that the temperature does not vary too much.

PXIe-5820/5830/5831/5832/5840/5841/5842/5860: This property is read only.

Supported Devices: PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653, PXIe-5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Correction Temperature

Read/Write

N/A

© National Instruments 389

niRFSG Properties

Channel-based

Resettable

No

Yes

RF:Advanced:Ref PLL Bandwidth
RF:Advanced:Ref PLL Bandwidth

Configures the loop bandwidth of the reference PLL.

Note Setting this property to Narrow allows the PXIe-5653 to lock to a
reference with worse phase noise than the PXIe-5653 and utilize the better
phase noise of the PXIe-5653. Setting this property to Wide on the PXIe-5653
allows the reference PLL to lock to a better reference with better phase noise
than the PXIe-5653 and utilize the better phase noise of the reference.

Supported Devices: PXIe-5653

Default Value: Narrow

Related Topics

Phase-Locked Loop Bandwidth

Remarks

The following table lists the characteristics of this property.

Ref PLL Bandwidth

Read/Write

N/A

No

Yes

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

390 ni.com

niRFSG Properties

Narrow

0  Uses the narrowest loop bandwidth setting for the PLL.

Medium

1  Uses the medium loop bandwidth setting for the PLL.

Wide

2  Uses the widest loop bandwidth setting for the PLL.

RF:Advanced:Thermal Correction Headroom Range (Degrees C)
RF:Advanced:Thermal Correction Headroom Range (Degrees C)

Specifies the expected thermal operating range of the instrument from the self-
calibration temperature, in degrees Celsius, returned from the Device Temperature
property.

For example, if this property is set to 5.0, and the device is self-calibrated at 35 degrees
Celsius, then you can expect to run the device from 30 degrees Celsius to 40 degrees
Celsius with corrected accuracy and no overflows. Setting this property with a smaller
value can result in improved dynamic range, but you must ensure thermal stability
while the instrument is running. Operating the instrument outside of the specified
range may cause degraded performance or DSP overflows.

Supported Devices: PXIe-5830/5831/5832/5840/5841/5842/5860

Default Value:

PXIe-5830/5831/5832/5842/5860: 5

PXIe-5840/5841: 10

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Thermal Correction Headroom Range

© National Instruments 391

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

Yes

Yes

RF:Advanced:Thermal Correction Temperature Resolution (Degrees C)
RF:Advanced:Thermal Correction Temperature Resolution (Degrees C)

Specifies the temperature change, in degrees Celsius, that is required before NI-RFSG
recalculates the thermal correction settings when entering the Generation state.

Supported Devices: PXIe-5830/5831/5832/5840/5841

Default Values:

PXIe-5830/5831/5832/5842/5860: 0.2

PXIe-5840/5841: 1.0

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Thermal Correction Temperature Resolution

Read/Write

N/A

No

Yes

RF:Advanced:YIG Main Coil Drive
RF:Advanced:YIG Main Coil Drive

Adjusts the dynamics of the current driving the YIG main coil.

392 ni.com

niRFSG Properties

Note Setting this property to Fast on the PXIe-5653 allows the frequency to
settle significantly faster for some frequency transitions at the expense of
increased phase noise.

Supported Devices: PXIe-5653

Default Value: Normal

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

YIG Main Coil Drive

Read/Write

N/A

No

Yes

Normal

0  Adjusts the YIG main coil for an underdamped response.

Fast

1  Adjusts the YIG main coil for an overdamped response.

RF:Allow Out Of Specification User Settings
RF:Allow Out Of Specification User Settings

Enables or disables warnings or errors when you set frequency, power, and bandwidth
values beyond the limits of the NI-RFSG device specifications. When you enable this
property, the driver does not report out-of-specification warnings or errors.

To set this property, the NI-RFSG device must be in the Configuration state.

© National Instruments 393

niRFSG Properties

Note Accuracy cannot be guaranteed outside of device specifications, and
results may vary by module.

Supported Devices: PXI/PXIe-5650/5651/5652, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841

Default Value: Disable

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Allow Out Of Specification User Settings

Read/Write

N/A

No

Yes

Disable

0

Disables out of specification user settings.

Enable

1

Enables out of specification user settings.

RF:Amplitude Settling
RF:Amplitude Settling

Configures the amplitude settling accuracy in decibels. NI-RFSG waits until the RF
power settles within the specified accuracy level after calling the niRFSG Initiate VI or
niRFSG Wait Until Settled VI or prior to advancing to next step if using RF list mode.

Any specified amplitude settling value that is above the acceptable minimum value is
coerced down to the closest valid value.

394 ni.com

PXI/PXIe-5650/5651/5652: This property is for NI internal use only.

Supported Devices: PXIe-5654/5654 with PXIe-5696, PXIe-5820/5830/5831/5832/5840/
5841/5842/5860

niRFSG Properties

Default Values:

PXIe-5654: 4

PXIe-5654 with PXIe-5696 (ALC disabled): 4

PXIe-5654 with PXIe-5696 (ALC enabled): 0.2

PXIe-5820/5830/5831/5832/5840/5841/5842/5860: 0.5

Valid Values:

PXIe-5654: 1.5, 2, 4

PXIe-5654 with PXIe-5696 (ALC disabled): 1.5, 2, 4

PXIe-5654 with PXIe-5696 (ALC enabled): 0.2, 0.5

PXIe-5820/5830/5831/5832/5840/5841/5842/5860: 0.01 to 1

Related Topics

Amplitude Settling Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Amplitude Settling

Read/Write

N/A

© National Instruments 395

niRFSG Properties

Channel-based

Resettable

No

Yes

RF:Attenuator Hold Enabled
RF:Attenuator Hold Enabled

Enables or disables attenuator hold. While this property is set to TRUE, changing the
power level causes NI-RFSG to scale the digital data sent to the AWG instead of
adjusting the attenuators. Changing power levels in this manner allows the device to
increase or decrease the power level in more accurate increments but may affect
signal-to-noise ratios (noise density).

Setting the Attenuator Hold Enabled property to TRUE limits the power levels that can
be attained. With attenuator hold enabled, the power level must satisfy the following
conditions:

•  Power level less than or equal to Attenuator Hold Max Power
•  Power level greater than or equal to (Attenuator Hold Max Power - 70 dB)
•  Power level greater than or equal to -145 dBm

To set this property, the NI-RFSG device must be in the Configuration state.

Note The frequency cannot be changed on the PXI-5670/5671 or PXIe-5672
while the Attenuator Hold Enabled property is set to TRUE.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

Default Value: FALSE

TRUE

FALSE

Enables attenuator hold.

Disables attenuator hold.

Related Topics

Attenuator Hold

396 ni.com

niRFSG Properties

Settling Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Attenuator Hold Enabled

Read/Write

N/A

No

Yes

RF:Attenuator Hold Max Power (dBm)
RF:Attenuator Hold Max Power (dBm)

Specifies the maximum power level of the RF output signal when the Attenuator Hold
Enabled property is set to TRUE.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E

Default Values:

PXI-5670/5671, PXIe-5672: 17 dBm

PXIe-5673/5673E: 10 dBm

Related Topics

Attenuator Hold

Settling Times

© National Instruments 397

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Attenuator Hold Max Power (dBm)

Read/Write

N/A

No

Yes

RF:Attenuator Setting (dB)
RF:Attenuator Setting (dB)

Specifies the level of attenuation in the attenuator path. Setting this property
overrides the value chosen by NI-RFSG. Not all power levels are achievable if you set
this property.

Note Resetting this property reverts back to the default unset behavior.

Supported Devices: PXIe-5654 with PXIe-5696

Valid Values: 0 dB to 110 dB in steps of 10

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

398 ni.com

Attenuator Setting

Read/Write

N/A

No

niRFSG Properties

Resettable

Yes

RF:Automatic Power Search
RF:Automatic Power Search

Enables or disables automatic power search. When this property is enabled, a power
search performs after the device is initiated, after output power is enabled, or when
the frequency or power level changes while the device is generating. When this
property is disabled, NI-RFSG does not perform a power search unless you call the
niRFSG Perform Power Search VI.

This property is ignored when the ALC Control property is enabled.

PXIe-5654: Disable is the only supported value for this device.

Supported Devices: PXIe-5654/5654 with PXIe-5696

Default Values:

PXIe-5654: Disable

PXIe-5654 with PXIe-5696: Enable

Related Topics

Power Search

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Automatic Power Search

Read/Write

N/A

No

© National Instruments 399

niRFSG Properties

Resettable

Yes

Disable

0

Disables automatic power search.

Enable

1

Enables automatic power search.

RF:Automatic Thermal Correction
RF:Automatic Thermal Correction

Enables or disables automatic thermal correction. When this property is enabled,
changes to settings cause NI-RFSG to check whether the device temperature has
changed and adjust the settings as needed. When this property is disabled, you must
explicitly call the niRFSG Perform Thermal Correction VI to adjust the device for
temperature changes.

Supported Devices: PXIe-5611, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/5654 with
PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/
5841/5842/5860

Default Value: Enable

Related Topics

Temperature Monitoring

Settling Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Automatic Thermal Correction

Read/Write

400 ni.com

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

Yes

Disable

0

Disables automatic thermal correction.

Enable

1

Enables automatic thermal correction.

RF:External Gain (dB)
RF:External Gain (dB)

Specifies the external amplification or attenuation, if any, between the RF signal
generator and the device under test.

Positive values for this property represent amplification, and negative values for this
property represent attenuation.

Note Setting this property adjusts the actual device output power to
compensate for any amplification or attenuation between the RF signal
generator and the device under test.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXIe-5673/
5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Valid Values: -INF dB to +INF dB

Default Value: 0 dB

© National Instruments 401

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

RF:Frequency (Hz)
RF:Frequency (Hz)

External Gain (dB)

Read/Write

N/A

No

Yes

Specifies the frequency of the generated RF signal. For arbitrary waveform generation,
this property specifies the center frequency of the signal.

The PXI-5670/5671, PXIe-5672, and PXIe-5820/5860 must be in the Configuration state
to use this property. However, the PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653/5654/5654 with PXIe-5696, PXIe-5673/5673E, and PXIe-5830/5831/5832/
5840/5841/5842 can be in the Configuration or the Generation state to use this
property.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Refer to the specifications document for your device for allowable frequency settings.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Default Values:

PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5654/5654 with PXIe-5696,

402 ni.com

niRFSG Properties

PXI-5670/5671, PXIe-5672/5673/5673E: 100 MHz

PXIe-5653: 4 GHz

PXIe-5820: 0 Hz

PXIe-5830/5831/5832: 6.5 GHz

PXIe-5840/5841/5860, PXIe-5842 (500 MHz, 1 GHz, and 2 GHz bandwidth options):
1 GHz

PXIe-5842 (4 GHz bandwidth option) using the Standard personality: 1 GHz

PXIe-5842 (4 GHz bandwidth option) using the 4 GHz Bandwidth personality: 6.5 GHz

Related Topics

NI-RFSG Instrument Driver Programming Flow

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Frequency (Hz)

Read/Write

niRFSG Configure RF

No

Yes

RF:Frequency Settling
RF:Frequency Settling

Configures the frequency settling time. Interpretation of this value depends on the
Frequency Settling Units property.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/

© National Instruments 403

5654 with PXIe-5696, PXIe-5673/5673E, PXIe-5830/5831/5832/5840/5841/5842

niRFSG Properties

Default Value: 1.0

Valid Values:

Frequency
Settling
Units
Property
Value

PXIe-5644/5645/
5646, PXI/
PXIe-5650/5651/
5652, PXIe-5673/
5673E

PXIe-5653

PXIe-5654/
5654 with
PXIe-5696

PXIe-5830/
5831/5832/
5840/5841/
5842

PXIe-5831/
5832 with
PXIe-5653
(using
PXIe-3622
LO)3

PXIe-5831/5832
with PXIe-5653
(using
PXIe-5653 LO)3

Seconds
After Lock

2 microseconds1
to
80 milliseconds,
resolution of
approximately
2 microseconds

2 microseconds1
to
80 milliseconds,
resolution of
approximately
2 microseconds

Not supported

1
microsecond1
to 10
seconds,
resolution of
1
microsecond

1
microsecond1
to 10
seconds,
resolution of
1
microsecond

2
microseconds1
to 80
milliseconds,
resolution of
approximately
2 microseconds

Seconds
After I/O

0 microseconds
to
80 milliseconds2,
resolution of 1
microsecond

0 microseconds
to
80 milliseconds2,
resolution of 1
microsecond

0
microseconds
to 65,535
microseconds,
resolution of 1
microsecond

0
microseconds
to 10
seconds,
resolution of
1
microsecond

0
microseconds
to 10
seconds,
resolution of
1
microsecond

0 microseconds
to
80 milliseconds,
resolution of 1
microsecond

PPM

1.0, 0.1, 0.01

1.0, 0.1, 0.01,
0.001

1.0, 0.1, 0.01

1.0 to 0.01

1.0 to 0.01

1.0 to 0.01

1To ensure that the PLL lock stabilizes when the Frequency Settling Units property is
set to Seconds After Lock, NI recommends a settling time of 128 microseconds,
minimum, if the Loop Bandwidth property is set to Narrow. NI recommends a settling
time of 16 microseconds, minimum, if the Loop Bandwidth property is set to Wide.

2Any specified PPM value that is above the acceptable minimum value is coerced down
to the closest valid value.

3The valid values for this configuration depend on the module used as the LO source.
Refer to the LO Source property for more information.

404 ni.com

niRFSG Properties

Related Topics

Settling Times

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Frequency Settling

Read/Write

N/A

No

Yes

RF:Frequency Settling Units
RF:Frequency Settling Units

Determines the interpretation of the value passed to the Frequency Settling property.

PXIe-5650/5651/5652/5653, PXIe-5673E: When the Active Configuration List property is
set to a valid list name, the Frequency Settling Units property supports only Seconds
After I/O as a valid value.

PXIe-5654/5654 with PXIe-5696: The Frequency Settling Units property supports only
Seconds After I/O and PPM as valid values.

Note If you set this property to Seconds After I/O, the definition of settled
for the Configuration Settled event changes.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXIe-5673/5673E, PXIe-5830/5831/5832/5840/5841/5842

Default Value: PPM

© National Instruments 405

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Frequency Settling Units

Read/Write

N/A

No

Yes

Seconds
After Lock

12000  Specifies the time to wait after the frequency PLL locks.

Seconds
After I/O

12001

Specifies the time to wait after all the input and output occurs to change the
frequency.

PPM

12002

Specifies the minimum frequency accuracy when settling completes. Units
are in parts per million (PPM or 1E-6).

RF:Frequency Tolerance (Hz)
RF:Frequency Tolerance (Hz)

Specifies the allowable frequency error introduced during the software upconversion
process. NI-RFSG may introduce a frequency error up to the specified amount to
optimize computational speed and onboard memory usage while upconverting phase-
continuous signals.

If the Phase Continuity Enabled property is set to Disable, the Frequency Tolerance
(Hz) property is ignored and the driver does not introduce a frequency error. On
devices that do not use software upconversion, this property is ignored. The PXI-5670
always uses software upconversion, and the PXI-5671 uses software upconversion for
I/Q rates greater than 8.33 MS/s. To set this property, the NI-RFSG device must be in the

406 ni.com

niRFSG Properties

Configuration state.

Supported Devices: PXI-5670/5671

Default Value: 50 Hz

Related Topics

Phase Continuity

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Frequency Tolerance (Hz)

Read/Write

N/A

No

Yes

RF:LO Frequency (Hz)
RF:LO Frequency (Hz)

Specifies the frequency of the LO source.

Note This property is read/write if you are using an external LO. Otherwise,
this property is read-only.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

© National Instruments 407

niRFSG Properties

Supported Devices: PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Upconverter Center Frequency property

PXIe-5830 Frequency and Bandwidth Configuration

PXIe-5831/5832 Frequency and Bandwidth Configuration

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Frequency (Hz)

Read/Write

N/A

Yes

Yes

RF:LO In Power (dBm)
RF:LO In Power (dBm)

Specifies the power level of the signal at the LO IN front panel connector.

Note This property is read/write if you are using an external LO. Otherwise,
this property is read-only.

Note For the PXIe-5644/5645/5646, this property is always read-only.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to

408 ni.com

configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5830/5831/5832/
5840/5841/5842

niRFSG Properties

Related Topics

LO OUT

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

RF:LO Out Enabled
RF:LO Out Enabled

LO In Power (dBm)

Read/Write

N/A

Yes

Yes

Specifies whether the local oscillator signal is present at the LO OUT front panel
connector. The local oscillator signal remains at the LO OUT front panel connector
until this property is set to FALSE even if the Output Enabled property is set to FALSE,
the niRFSG Abort VI is called, or the NI-RFSG session is closed.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

© National Instruments 409

niRFSG Properties

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5830/5831/5832/
5840/5841/5842

Default Value: FALSE

TRUE

The local oscillator is present at the LO OUT front panel connector.

FALSE

The local oscillator is not present at the LO OUT front panel connector.

Related Topics

LO OUT

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Out Enabled

Read/Write

N/A

Yes

Yes

RF:LO Out Export Configure From RFSA
RF:LO Out Export Configure From RFSA

Specifies whether to allow NI-RFSA to control the NI-RFSG LO out export.

Set this property to Enabled to allow NI-RFSA to control the LO out export.

Use the NI-RFSA RF Out LO Export Enabled property to control the LO out export from
NI-RFSA.

Supported Devices: PXIe-5840/5841

Default Value: Disabled

410 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Out Export Configure From RFSA

Read/Write

N/A

No

Yes

Disabled

0  NI-RFSA cannot control the exporting of the NI-RFSG local oscillator.

Enabled

1  Enables NI-RFSA to control the exporting of the NI-RFSG local oscillator.

RF:LO Out Power (dBm)
RF:LO Out Power (dBm)

Specifies the power level of the signal at the LO OUT front panel connector.

Note For the PXIe-5644/5645/5646 and PXIe-5673/5673E, this property is
always read-only.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel
string is "" (empty string).

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5830/5831/5832/
5840/5841/5842

© National Instruments 411

niRFSG Properties

Related Topics

LO OUT

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

LO Out Power (dBm)

Read/Write

N/A

Yes

Yes

RF:Loop Bandwidth
RF:Loop Bandwidth

Configures the loop bandwidth of the tuning PLLs. This property is ignored on the
PXI-5610, PXI-5670/5671, and PXIe-5672 for signal bandwidths greater than or equal to
10 MHz. This property is ignored on the PXI/PXIe-5650/5651/5652 for RF frequencies
less than 50 MHz.

Note Setting this property to Wide on the PXIe-5644/5645/5646, PXI/
PXIe-5650/5651/5652, or the PXIe-5673/5673E allows the frequency to settle
significantly faster at the expense of increased phase noise. Setting this
property to Medium is not a valid option on the PXI/PXIe-5650/5651/5652 or
PXIe-5673/5673E. Medium is the only supported value for the PXIe-5840/
5841/5842.

To use this property for the PXIe-5830/5831/5832 and PXIe-5842 VST with 54 GHz
Frequency Extension, you must first use the Active Channel property to specify the
name of the channel you are configuring. You can configure LO1 and LO2 channels by
using lo1 or lo2 as the channel string, or set the channel string to lo1,lo2 to
configure both channels. For all other devices, the only valid value for the channel

412 ni.com

niRFSG Properties

string is "" (empty string).

Supported Devices: PXI-5610, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5830/5831/5832/5840/5841/5842

Default Values:

PXIe-5644/5645/5646, PXIe-5830/5831/5832/5840/5841/5842: Medium

PXI/PXIe-5650/5651/5652, PXIe-5673/5673E: Narrow

Related Topics

Phase-Locked Loop Bandwidth

Modulation Implementation

Sinusoidal Tone Versus Modulation Operation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Loop Bandwidth

Read/Write

N/A

Yes

Yes

Narrow

0  Uses the narrowest loop bandwidth setting for the PLL.

Medium

1  Uses the medium loop bandwidth setting for the PLL.

© National Instruments 413

niRFSG Properties

Wide

2  Uses the widest loop bandwidth setting for the PLL.

RF:Output Enabled
RF:Output Enabled

Enables or disables signal output. Setting the Output Enabled property to FALSE while
in the Generation state stops signal output although generation continues internally.
For the PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,
PXIe-5653, PXI-5670/5671, and PXIe-5672/5673/5673E, setting the Output Enabled
property while in the Committed state does not transition the device to the
Configuration state, but output changes immediately.

Note For the PXIe-5653, this property controls only the LO1 terminal.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Note When the Active Configuration List property is set to a valid list name,
setting the Output Enabled property transitions the device to the
Configuration state.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI/PXIe-5650/5651/
5652, PXIe-5653/5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: TRUE

TRUE

FALSE

Enables signal output.

Disables signal output.

Related Topics

Output Enabled

414 ni.com

niRFSG Properties

NI-RFSG Instrument Driver Programming Flow

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Output Enabled

Read/Write

niRFSG Configure Output Enabled

No

Yes

RF:Peak Envelope Power (dBm)
RF:Peak Envelope Power (dBm)

Specifies the maximum instantaneous power of the RF output signal.

Note The Digital Gain (dB) property is not included in the calculation of the
Peak Envelope Power (dBm) property.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Peak Envelope Power (dBm)

Read Only

N/A

No

© National Instruments 415

niRFSG Properties

Resettable

No

RF:Peak Power Adjustment (dB)
RF:Peak Power Adjustment (dB)

Adjusts the Power Level (dBm) property. This property is valid only when you set the
Power Level Type property to Peak Power. The value of the Peak Power Adjustment
(dB) property adds to the Power Level (dBm) property. The Peak Power Adjustment
(dB) property typically specifies the peak-to-average power ratio (PAPR) of a
waveform. If the PAPR is specified, the specified power level becomes the average
power level of the waveform, even if the Power Level Type property is set to Peak
Power.

Note For the PXIe-5673/5673E only, use this property to associate a peak
power adjustment with a waveform.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Supported Devices: PXIe-5644/5645/5646, PXIe-5673/5673E, PXIe-5830/5831/5832/
5840/5841/5842/5860

Related Topics

Assigning Properties or Attributes to a Waveform—Refer to this topic for more
information about using this property to associate a peak power adjustment with a
waveform.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Peak Power Adjustment (dB)

Read/Write

416 ni.com

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

Yes

RF:Peak Power Adjustment Inheritance
RF:Peak Power Adjustment Inheritance

Determines the inheritance behavior of the Peak Power Adjustment property when a
script inherits values from specified waveforms.

Supported Devices: PXIe-5673/5673E

Default Value: Exact Match

Related Topics

Assigning Properties or Attributes to a Waveform

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

PPA Inheritance

Read/Write

N/A

No

Yes

Exact Match

0  Errors out if different values are detected in the script.

Minimum

1  Uses the minimum value found in the script.

© National Instruments 417

niRFSG Properties

Maximum

2  Uses the maximum value found in the script.

RF:Phase Offset (Degrees)
RF:Phase Offset (Degrees)

Changes the phase of the RF output signal. Use this property to align the phase of the
RF output with the phase of the RF output of another device as long as the two devices
are phase-coherent.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653,
PXIe-5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Related Topics

Phase Synchronization and Phase Coherency

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Phase Offset (Degrees)

Read/Write

N/A

No

Yes

RF:Power Level (dBm)
RF:Power Level (dBm)

Specifies either the average power level or peak power level of the generated RF
signal, depending on the Power Level Type property setting.

The PXI-5670/5671 PXIe-5672, and PXIe-5860 must be in the Configuration state to use
this property. However, the PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652,

418 ni.com

PXIe-5654/5654 with PXIe-5696, PXIe-5673/5673E and PXIe-5830/5831/5832/5840/
5841/5842 can be in the Configuration or the Generation state to use this property.

Refer to the specifications document for your device for allowable power level
settings.

niRFSG Properties

Note For the PXIe-5653, this property is read-only.

Note For the PXIe-5645, this property is ignored if you are using the I/Q
ports.

Supported Devices: PXIe-5644/5645/5646, PXI/PXIe-5650/5651/5652, PXIe-5653/5654/
5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5830/5831/5832/
5840/5841/5842/5860

Default Values:

PXIe-5644/5645/5646, PXIe-5673/5673E: -100 dBm

PXI/PXIe-5650/5651/5652: -90 dBm

PXIe-5654: -7 dBm

PXIe-5654 with PXIe-5696: -110 dBm

PXI-5670/5671, PXIe-5672: -145 dBm

PXIe-5830/5831/5832/5840/5841/5842/5860: -174 dBm

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

Power Level (dBm)

Read/Write

© National Instruments 419

niRFSG Properties

High-level VIs

Channel-based

Resettable

niRFSG Configure RF

No

Yes

RF:Power Level Type
RF:Power Level Type

Specifies the way the driver interprets the value of the Power Level property. The
Power Level Type property also affects how waveforms are scaled.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Values:

PXIe-5820: Peak Power

All other devices: Average Power

PXI-5670/5671: While in Script mode, if the Power Level Type property is set to Average
Power, the driver scales each waveform so that all waveforms have the same average
power. The average power level of each waveform matches the value set in the Power
Level property. You can disable this scaling operation by setting the Power Level Type
property to Peak Power.

PXIe-5644/5645/5646, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842/5860: This property must be set to Peak Power when the Generation Mode
property is set to Script.

Converting from Average Power to Peak Power

Typically, the Power Level Type property is set to Average Power. However, some
instrument modes require this property to be set to Peak Power. Use the following
equations to calculate the equivalent peak power given the desired average power for
your waveform:

420 ni.com

niRFSG Properties

Where 1 is the highest possible magnitude in the waveform.

Related Topics

Spurious Performance

Optimizing for Low Power Generation

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Power Level Type

Read/Write

niRFSG Configure Power Level Type

No

Yes

Average
Power

7000

Indicates the desired power averaged in time. The driver maximizes the dynamic
range by scaling the I/Q waveform so that its peak magnitude is equal to one. If
your write more than one waveform, NI-RFSG scales each waveform without
preserving the power level ratio between the waveforms. This value is not valid for
the PXIe-5820.

Peak
Power

7001  Indicates the maximum power level of the RF signal averaged over one period of

© National Instruments 421

niRFSG Properties

the RF carrier frequency (the peak envelope power). This setting requires that the
magnitude of the I/Q waveform must always be less than or equal to one. When
using peak power, the power level of the RF signal matches the specified power
level at moments when the magnitude of the I/Q waveform equals one. If you write
more than one waveform, the relative scaling between waveforms is preserved. In
peak power mode, waveforms are scaled according to the Software Scaling Factor
property. The Peak Power Adjustment (dB) property can be used in conjunction
with the Power Level property when the Power Level Type property is set to Peak
Power.

RF:RF In LO Export Enabled
RF:RF In LO Export Enabled

Specifies whether to enable the RF IN LO OUT terminal on the PXIe-5840/5841.

Set this property to Enabled to export the LO signal from the RF IN LO OUT terminal.

This property cannot be enabled or disabled unless an NI-RFSA session on the
PXIe-5840/5841 has set the NI-RFSA LO Out Export Configure From RFSG property to
Enabled.

When this property is enabled, if the LO Source property is set to LO In and you do not
set the LO Frequency or Upconverter Center Frequency properties, NI-RFSG rounds the
LO frequency to approximately an LO step size as if the source was Onboard. This
ensures that when you configure NI-RFSA and NI-RFSG with compatible settings that
result in the same LO frequency, the rounding also is compatible.

Supported Devices: PXIe-5840/5841

Default Value: Unspecified

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

422 ni.com

RF In LO Export Enabled

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

N/A

No

Yes

Unspecified  -2

The RF In local oscillator signal may or may not be present at the front panel LO
OUT connector, because NI-RFSA may be controlling it.

Disabled

0

The RF In local oscillator signal is not present at the front panel LO OUT
connector.

Enabled

1  The RF In local oscillator signal is present at the front panel LO OUT connector.

RF:Upconverter:Center Frequency (Hz)
RF:Upconverter:Center Frequency (Hz)

Indicates the center frequency of the passband containing the upconverted RF signal.
Writing a value to this property while using the PXIe-5644/5645/5646, PXIe-5672/5673/
5673E, or PXIe-5820/5840/5841/5842 enables in-band retuning. In-band retuning
increases the speed of frequency sweeps by reducing the amount of upconverter
retunes.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI-5670/5671,
PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Note This property is read/write on the PXI-5610, PXIe-5611, PXIe-5644/
5645/5646, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/
5842 and read-only on the PXI-5670/5671.

Note Resetting this property disables in-band retuning, however, for the
PXIe-5820, in-band retuning is always enabled.

© National Instruments 423

niRFSG Properties

Note For the PXIe-5820, the only valid value for this property is 0.

Note Setting this property while the PXIe-5644/5645/5646, PXIe-5673/5673E,
or PXIe-5820/5830/5831/5832/5840/5841/5842 device is generating has no
effect until a dynamic property is set.

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Upconverter Center Frequency (Hz)

Read/Write

N/A

No

Yes

RF:Upconverter:Frequency Offset Mode
RF:Upconverter:Frequency Offset Mode

Specifies whether to allow NI-RFSG to select the upconverter frequency offset. You can
either set an offset yourself or let NI-RFSG select one for you.

Placing the upconverter center frequency outside the bandwidth of your waveform
can help avoid issues such as LO leakage.

To set an offset yourself, set this property to Automatic or User-Defined and set either
the Upconverter Center Frequency or the Upconverter Frequency Offset properties.

To allow NI-RFSG to automatically select the upconverter frequency offset, set this
property to Automatic or Enabled and set the Signal Bandwidth property to describe
the bandwidth of your waveform. The signal bandwidth must be no greater than half
the value of the Device Instantaneous Bandwidth property, minus a device-specific
guard band. Do not set the Upconverter Center Frequency or Upconverter Frequency
Offset properties. If all conditions are met, NI-RFSG places the upconverter center

424 ni.com

niRFSG Properties

frequency outside the signal bandwidth. Set this property to Enabled if you want to
receive an error any time NI-RFSG is unable to apply automatic offset.

When you set an offset yourself or do not use an offset, the reference frequency for
gain is near the upconverter center frequency, and Upconverter Frequency Offset
Mode returns User-Defined. When NI-RFSG automatically sets an offset, the reference
frequency for gain is near the RF frequency, and Upconverter Frequency Offset Mode
returns Enabled. Refer to the specifications document for your device for more
information about gain, flatness, and reference frequencies.

Note Below 120 MHz, the PXIe-5841 does not use an LO and Enabled is
unavailable. Refer to the PXIe-5841 Automatic Frequency Offset topic for
more information about using an automatic offset with an external LO.

Supported Devices: PXIe-5830/5831/5832/5841/5842

Default Value: Automatic

Related Topics

PXIe-5830 Automatic Frequency Offset

PXIe-5831/5832 Automatic Frequency Offset

PXIe-5841 Automatic Frequency Offset

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Upconverter Frequency Offset Mode

Read/Write

N/A

Yes

© National Instruments 425

Resettable

Yes

niRFSG Properties

Automatic  -1

NI-RFSG places the upconverter center frequency outside of the signal
bandwidth if the Signal Bandwidth property has been set and can be avoided.

Enabled

1

NI-RFSG places the upconverter center frequency outside of the signal
bandwidth if the Signal Bandwidth property has been set and can be avoided.
NI-RFSG returns an error if the Signal Bandwidth property has not been set, or if
the signal bandwidth is too large.

User-
Defined

5001

NI-RFSG uses the offset that you specified with the Upconverter Frequency
Offset or Upconverter Center Frequency properties.

RF:Upconverter:Gain (dB)
RF:Upconverter:Gain (dB)

Indicates the gain that the upconverter applies to the signal.

Note This property is read/write on the PXI-5610 and PXIe-5611. This
property is read-only on the PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/
5673/5673E, and PXIe-5820/5830/5831/5832/5840/5841/5842.

Supported Devices: PXI-5610, PXIe-5611, PXIe-5644/5645/5646, PXI-5670/5671,
PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

426 ni.com

Upconverter Gain (dB)

Read/Write

niRFSG Properties

High-level VIs

Channel-based

Resettable

N/A

No

Yes

Self Calibration:Last Self Calibration Temperature
Self Calibration:Last Self Calibration Temperature

Indicates, in degrees Celsius, the temperature of the device at the time of the last self
calibration.

Supported Devices: PXIe-5644/5645/5646

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Last Self Cal Temp

Read Only

N/A

No

No

Triggers:Configuration List Step:Digital Edge:Edge
Triggers:Configuration List Step:Digital Edge:Edge

Specifies the active edge for the Configuration List Step Trigger. This property is valid
only when the Configuration List Step Trigger Type property is set to Digital Edge. To
set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Related Topics

© National Instruments 427

niRFSG Properties

RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ConfigListTrig.DigEdge.Edge

Read/Write

N/A

No

Yes

Rising
Edge

0

Specifies the rising edge as the active edge. The rising edge occurs when the signal
transitions from low level to high level.

Triggers:Configuration List Step:Digital Edge:Source
Triggers:Configuration List Step:Digital Edge:Source

Specifies the source terminal for the Configuration List Step Trigger. This property is
valid only when the Configuration List Step Trigger Type property is set to Digital Edge.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Related Topics

RF List Mode

PFI Lines

PXI Trigger Lines

428 ni.com

niRFSG Properties

Marker Events

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ConfigListTrig.DigEdge.Source

Read/Write

N/A

No

Yes

PFI0

PFI0

The trigger is received on PFI 0. For the PXIe-5841 with PXIe-5655,
the trigger is received on the PXIe-5841 PFI 0.

PFI1

PFI1

The trigger is received on PFI 1.

PXI_Trig0

PXI_Trig0

The trigger is received on PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The trigger is received on PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The trigger is received on PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The trigger is received on PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The trigger is received on PXI trigger line 4.

© National Instruments 429

niRFSG Properties

PXI_Trig5

PXI_Trig5

The trigger is received on PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The trigger is received on PXI trigger line 6.

PXI_Trig7

PXI_Trig7

The trigger is received on PXI trigger line 7.

PXI_Star

PXI_Star

The trigger is received on the PXI star trigger line. This value is not
valid for the PXIe-5644/5645/5646.

PXIe_DStarB  PXIe_DStarB

The trigger is received on the PXIe DStar B trigger line. This value is
valid on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

Marker0Event  Marker0Event  The trigger is received from the Marker 0 Event.

Marker1Event  Marker1Event  The trigger is received from the Marker 1 Event.

Marker2Event  Marker2Event  The trigger is received from the Marker 2 Event.

Marker3Event  Marker3Event  The trigger is received from the Marker 3 Event.

TimerEvent

TimerEvent

The trigger is received from the Timer Event.

TrigIn

TrigIn

The trigger is received on the TRIG IN/OUT terminal. This value is
valid on only the PXIe-5654/5654 with PXIe-5696.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

430 ni.com

niRFSG Properties

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Triggers:Configuration List Step:Export Output Terminal
Triggers:Configuration List Step:Export Output Terminal

Specifies the destination terminal for exporting the Configuration List Step Trigger. To
set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXIe-5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860, PXIe-5842 with S-parameters,
PXIe-5842 with 54GHz Frequency Extension, PXIe-5860 with S-parameters

Related Topics

RF List Mode

PFI Lines

PXI Trigger Lines

© National Instruments 431

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

ConfigListTrig.ExportOutputTerm

Read/Write

N/A

No

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

432 ni.com

niRFSG Properties

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The signal is exported to the PXIe DStar C trigger line. This value is valid
on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

TrigOut

TrigOut

The signal is exported to the TRIG IN/OUT terminal. This value is valid
on only the PXIe-5654/5654 with PXIe-5696.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

© National Instruments 433

niRFSG Properties

Triggers:Configuration List Step:Terminal Name
Triggers:Configuration List Step:Terminal Name

Returns the fully qualified signal name as a string.

Supported Devices: PXI/PXIe-5650/5651/5652, PXIe-5653/5654/5654 with PXIe-5696,
PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860, PXIe-5842 with S-
parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860 with S-parameters

Default Values:

PXI/PXIe-5650/5651/5652, PXIe-5653/5654/5654 with PXIe-5696:
/ModuleName/ConfigurationListStepTrigger, where ModuleName is the
name of your device in MAX.

PXIe-5673E: /AWGName/ConfigurationListStepTrigger, where AWGName is
the name of your associated AWG module in MAX.

PXIe-5820/5830/5831/5832/5840/5841/5842/5860, PXIe-5842 with S-parameters,
PXIe-5842 with 54GHz Frequency Extension, PXIe-5860 with S-parameters:
/ModuleName/ao/0/ConfigurationListStepTrigger, where ModuleName
is the name of your device in MAX.

Related Topics

Triggers

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

ConfigListTrig.TerminalName

Read Only

niRFSG Get Terminal Name

434 ni.com

niRFSG Properties

Channel-based

Resettable

No

No

Triggers:Configuration List Step:Type
Triggers:Configuration List Step:Type

Specifies the type of trigger to use as the Configuration List Step Trigger.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXIe-5650/5651/5652, PXIe-5653/5654/5654
with PXIe-5696, PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860,
PXIe-5842 with S-parameters, PXIe-5842 with 54GHz Frequency Extension, PXIe-5860
with S-parameters

Related Topics

RF List Mode

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ConfigListTrig.Type

Read/Write

N/A

No

Yes

None

0  Generation starts immediately but the list does not advance.

Digital
Edge

1  Data operation does not start until a digital edge is detected. The source of the digital

© National Instruments 435

edge is specified in the Configuration List Step Digital Edge Source property and the
active edge is always rising.

niRFSG Properties

Triggers:Script:Digital Edge:Edge
Triggers:Script:Digital Edge:Edge

Specifies the active edge for the Script Trigger. This property requires that you use the
Active Channel property to specify the name of the Script Trigger you are configuring.
This property is used when Script Trigger Type property is set to Digital Edge.

To set this property, the NI-RFSG device must be in the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Script Trigger

Digital Edge Trigger

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ScriptTrig.DigEdge.Edge

Read/Write

niRFSG Configure Trigger

Yes

Yes

Rising Edge

0  Occurs when the signal transitions from low level to high level.

436 ni.com

niRFSG Properties

Falling Edge

1  Occurs when the signal transitions from high level to low level.

Triggers:Script:Digital Edge:Source
Triggers:Script:Digital Edge:Source

Specifies the source terminal for the Script Trigger. This property requires that you use
the Active Channel property to specify the name of the Script Trigger you are
configuring. This property is used only when the Script Trigger Type property is set to
Digital Edge.

To set the Script Trigger Digital Edge Source property, the NI-RFSG device must be in
the Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Script Trigger

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ScriptTrig.DigEdge.Source

Read/Write

niRFSG Configure Trigger

Yes

Yes

© National Instruments 437

PFI0

PFI0

The trigger is received on PFI 0. For the PXIe-5841 with PXIe-5655, the
trigger is received on the PXIe-5841 PFI 0.

niRFSG Properties

PFI1

PFI1

The trigger is received on PFI 1.

PFI2

PFI2

The trigger is received on PFI 2.

PFI3

PFI3

The trigger is received on PFI 3.

PXI_Trig0

PXI_Trig0

The trigger is received on PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The trigger is received on PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The trigger is received on PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The trigger is received on PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The trigger is received on PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The trigger is received on PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The trigger is received on PXI trigger line 6.

PXI_Trig7

PXI_Trig7

The trigger is received on PXI trigger line 7.

438 ni.com

niRFSG Properties

PXI_Star

PXI_Star

The trigger is received on the PXI star trigger line. This value is not valid
for the PXIe-5644/5645/5646.

PXIe_DStarB  PXIe_DStarB

The trigger is received on the PXIe DStar B trigger line. This value is
valid on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

PulseIn

PulseIn

The trigger is received on the PULSE IN terminal. This value is valid on
only the PXIe-5842.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

© National Instruments 439

niRFSG Properties

Triggers:Script:Digital Level:Active Level
Triggers:Script:Digital Level:Active Level

Specifies the active level for the Script Trigger. This property is used when the Script
Trigger Type property is set to Digital Level.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Script Trigger

Digital Level Trigger

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ScriptTrig.DigLevel.ActiveLevel

Read/Write

niRFSG Configure Trigger

Yes

Yes

Active High

9000  When the trigger has started, the active level is high.

Active Low

9001  When the trigger has started, the active level is low.

Triggers:Script:Digital Level:Source
Triggers:Script:Digital Level:Source

Specifies the source terminal for the Script Trigger. This property is used when the

440 ni.com

Script Trigger Type property is set to Digital Level.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Related Topics

Script Trigger

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

ScriptTrig.DigLevel.Source

Read/Write

niRFSG Configure Trigger

Yes

Yes

PFI0

PFI0

The trigger is received on PFI 0. For the PXIe-5841 with PXIe-5655, the
trigger is received on the PXIe-5841 PFI 0.

PFI1

PFI1

The trigger is received on PFI 1.

PFI2

PFI2

The trigger is received on PFI 2.

© National Instruments 441

niRFSG Properties

PFI3

PFI3

The trigger is received on PFI 3.

PXI_Trig0

PXI_Trig0

The trigger is received on PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The trigger is received on PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The trigger is received on PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The trigger is received on PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The trigger is received on PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The trigger is received on PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The trigger is received on PXI trigger line 6.

PXI_Trig7

PXI_Trig7

The trigger is received on PXI trigger line 7.

PXI_Star

PXI_Star

The trigger is received on the PXI star trigger line. This value is not valid
for the PXIe-5644/5645/5646.

PXIe_DStarB  PXIe_DStarB

The trigger is received on the PXIe DStar B trigger line. This value is
valid on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

PulseIn

PulseIn

The trigger is received on the PULSE IN terminal. This value is valid on
only the PXIe-5842.

442 ni.com

niRFSG Properties

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Triggers:Script:Export Output Terminal
Triggers:Script:Export Output Terminal

Specifies the destination terminal for exporting the Script Trigger. This property
requires that you use the Active Channel property to specify the name of the Script
Trigger you are configuring. To set this property, the NI-RFSG device must be in the
Configuration state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Script Trigger

© National Instruments 443

niRFSG Properties

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

ScriptTrig.ExportOutputTerm

Read/Write

N/A

Yes

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PFI4

PFI4

The signal is exported to the PFI 4 connector.

PFI5

PFI5

The signal is exported to the PFI 5 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

444 ni.com

niRFSG Properties

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The signal is exported to the PXIe DStar C trigger line. This value is valid
on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

© National Instruments 445

niRFSG Properties

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Triggers:Script:Terminal Name
Triggers:Script:Terminal Name

Returns the fully qualified signal name as a string.

Supported Devices: PXI-5670/5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/
5832/5840/5841/5842/5860

Default Values:

PXI-5670/5671, PXIe-5672/5673/5673E: /AWGName/ScriptTriggerX , where
AWGName is the name of your associated AWG module in MAX and X is Script Trigger 0
through 3.

PXIe-5830/5831/5832: /BasebandModule/ao/0/ScriptTrigger, where
BasebandModule is the name of the baseband module for your device in MAX and X is
Script Trigger 0 through 3.

PXIe-5820/5840/5841/5842: /ModuleName/ao/0/ScriptTriggerX , where
ModuleName is the name of your device in MAX and X is Script Trigger 0 through 3.

PXIe-5860: /ModuleName/ao/ChannelNumber/ScriptTrigger, where
ModuleName is the name of your device in MAX, ChannelNumber is the channel
number (0 or 1), and X is Script Trigger 0 through 3.

Related Topics

Triggers

Syntax for Terminal Names

446 ni.com

niRFSG Properties

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Triggers:Script:Type
Triggers:Script:Type

ScriptTrig.TerminalName

Read Only

niRFSG Get Terminal Name

Yes

No

Specifies the type of trigger to use as the Script Trigger. This property requires that you
use the Active Channel property to specify the name of the Script Trigger you are
configuring. To set this property, the NI-RFSG device must be in the Configuration
state.

Supported Devices: PXIe-5644/5645/5646, PXI-5670/5671, PXIe-5672/5673/5673E,
PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: None

Related Topics

Script Trigger

Trigger Types

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

ScriptTrig.Type

© National Instruments 447

niRFSG Properties

Permissions

High-level VIs

Channel-based

Resettable

Read/Write

niRFSG Configure Trigger

Yes

Yes

None

0

Generation starts immediately. No trigger is configured.

Digital
Edge

1

The data operation does not start until a digital edge is detected. The source of
the digital edge is specified in the Digital Edge Script Trigger Source property, and
the active edge is specified in Digital Edge Script Trigger Edge property.

Digital
Level

8000

The data operation does not start until the digital level is detected. The source of
the digital level is specified in the Digital Level Source property, and the active
level is specified in the Digital Level Active Level property.

Software  2

The data operation does not start until a software event occurs. You can create a
software event by calling the niRFSG Send Software Edge Trigger VI with
ScriptTrigger as the trigger name and TriggerID as the Script Trigger
identifier.

Triggers:Start:Digital Edge:Edge
Triggers:Start:Digital Edge:Edge

Specifies the active edge for the Start Trigger. This property is used when the Start
Trigger Type property is set to Digital Edge. To set this property, the NI-RFSG device
must be in the Configuration state.

PXIe-5654/5654 with PXIe-5696: The Start Trigger is valid only with a timer-based list
when RF list mode is enabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

448 ni.com

niRFSG Properties

Default Value: Rising Edge

Related Topics

Start Trigger

Digital Edge Trigger

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

StartTrig.DigEdge.Edge

Read/Write

niRFSG Configure Trigger

No

Yes

Rising Edge

0  Occurs when the signal transitions from low level to high level.

Falling Edge

1  Occurs when the signal transitions from high level to low level.

Triggers:Start:Digital Edge:Source
Triggers:Start:Digital Edge:Source

Specifies the source terminal for the Start Trigger. This property is used when the Start
Trigger Type property is set to Digital Edge. To set the Start Trigger Digital Edge Source
property, the NI-RFSG device must be in the Configuration state.

PXIe-5654/5654 with PXIe-5696: The Start Trigger is valid only with a timer-based list
when RF list mode is enabled.

© National Instruments 449

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

niRFSG Properties

Related Topics

Start Trigger

PFI Lines

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

StartTrig.DigEdge.Source

Read/Write

niRFSG Configure Trigger

No

Yes

PFI0

PFI0

The trigger is received on PFI 0. For the PXIe-5841 with PXIe-5655, the
trigger is received on the PXIe-5841 PFI 0.

PFI1

PFI1

The trigger is received on PFI 1.

PFI2

PFI2

The trigger is received on PFI 2.

PFI3

PFI3

The trigger is received on PFI 3.

450 ni.com

niRFSG Properties

PXI_Trig0

PXI_Trig0

The trigger is received on PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The trigger is received on PXI trigger line 1.

PXI_Trig2

PXI_Trig2

The trigger is received on PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The trigger is received on PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The trigger is received on PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The trigger is received on PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The trigger is received on PXI trigger line 6.

PXI_Trig7

PXI_Trig7

The trigger is received on PXI trigger line 7.

PXI_Star

PXI_Star

The trigger is received on the PXI star trigger line. This value is not valid
for the PXIe-5644/5645/5646.

PXIe_DStarB  PXIe_DStarB

The trigger is received on the PXIe DStar B trigger line. This value is
valid on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

TrigIn

TrigIn

The trigger is received on the TRIG IN/OUT terminal. This value is valid
on only the PXIe-5654/5654 with PXIe-5696.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

© National Instruments 451

niRFSG Properties

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Triggers:Start:Export Output Terminal
Triggers:Start:Export Output Terminal

Specifies the destination terminal for exporting the Start trigger. To set this property,
the NI-RFSG device must be in the Configuration state.

PXIe-5654/5654 with PXIe-5696: The Start Trigger is valid only with a timer-based list
when RF list mode is enabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Related Topics

Start Trigger

PFI Lines

452 ni.com

niRFSG Properties

PXI Trigger Lines

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Do not
export
signal

StartTrig.ExportOutputTerm

Read/Write

N/A

No

Yes

The signal is not exported.

PFI0

PFI0

The signal is exported to the PFI 0 connector.

PFI1

PFI1

The signal is exported to the PFI 1 connector.

PFI4

PFI4

The signal is exported to the PFI 4 connector.

PFI5

PFI5

The signal is exported to the PFI 5 connector.

PXI_Trig0

PXI_Trig0

The signal is exported to the PXI trigger line 0.

PXI_Trig1

PXI_Trig1

The signal is exported to the PXI trigger line 1.

© National Instruments 453

niRFSG Properties

PXI_Trig2

PXI_Trig2

The signal is exported to the PXI trigger line 2.

PXI_Trig3

PXI_Trig3

The signal is exported to the PXI trigger line 3.

PXI_Trig4

PXI_Trig4

The signal is exported to the PXI trigger line 4.

PXI_Trig5

PXI_Trig5

The signal is exported to the PXI trigger line 5.

PXI_Trig6

PXI_Trig6

The signal is exported to the PXI trigger line 6.

PXIe_DStarC  PXIe_DStarC

The signal is exported to the PXIe DStar C trigger line. This value is valid
on only the PXIe-5820/5830/5831/5832/5840/5841/5842/5860.

TrigOut

TrigOut

The signal is exported to the TRIG IN/OUT terminal. This value is valid
on only the PXIe-5654/5654 with PXIe-5696.

DIO/PFI0

DIO/PFI0

The signal is exported to the PFI 0 on the DIO front panel connector

DIO/PFI1

DIO/PFI1

The signal is exported to the PFI 1 on the DIO front panel connector

DIO/PFI2

DIO/PFI2

The signal is exported to the PFI 2 on the DIO front panel connector

DIO/PFI3

DIO/PFI3

The signal is exported to the PFI 3 on the DIO front panel connector

DIO/PFI4

DIO/PFI4

The signal is exported to the PFI 4 on the DIO front panel connector

454 ni.com

niRFSG Properties

DIO/PFI5

DIO/PFI5

The signal is exported to the PFI 5 on the DIO front panel connector

DIO/PFI6

DIO/PFI6

The signal is exported to the PFI 6 on the DIO front panel connector

DIO/PFI7

DIO/PFI7

The signal is exported to the PFI 7 on the DIO front panel connector

Triggers:Start:P2P Endpoint Fullness:Level
Triggers:Start:P2P Endpoint Fullness:Level

Specifies the number of samples needed to be received by the endpoint before the
device starts generation. This property applies only when the Start Trigger Type
property is set to P2P Endpoint Fullness.

Supported Devices: PXIe-5673E, PXIe-5820/5830/5831/5832/5840/5841/5842

Default Value: -1, which allows NI-RFSG to select the appropriate fullness level.

Related Topics

Start Trigger

Remarks

The following table lists the characteristics of this property.

Short Name

StartTrig.P2PEndpointFullness.Level

Data type

Permissions

Read/Write

High-level VIs

niRFSG Configure Start Trigger P2P Endpoint Fullness

Channel-based

Resettable

No

Yes

© National Instruments 455

niRFSG Properties

Triggers:Start:Terminal Name
Triggers:Start:Terminal Name

Returns the fully qualified signal name as a string.

PXIe-5654/5654 with PXIe-5696: The Start Trigger is valid only with a timer-based list
when RF list mode is enabled.

Supported Devices: PXIe-5654/5654 with PXIe-5696, PXI-5670/5671, PXIe-5672/5673/
5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Values:

PXIe-5654/5654 with PXIe-5696: /ModuleName/StartTrigger, where
ModuleName is the name of your device in MAX.

PXI-5670/5671, PXIe-5672/5673/5673E: /AWGName/StartTrigger, where
ModuleName is the name of your associated AWG module in MAX.

PXIe-5830/5831/5832: /BasebandModule/ao/0/StartTrigger, where
BasebandModule is the name of the baseband module for your device in MAX.

PXIe-5820/5840/5841/5842: /ModuleName/ao/0/StartTrigger, where
ModuleName is the name of your device in MAX.

PXIe-5860: /ModuleName/ao/ChannelNumber/StartTrigger, where
ModuleName is the name of your device in MAX and ChannelNumber is the channel
number (0 or 1).

Related Topics

Triggers

Syntax for Terminal Names

Remarks

The following table lists the characteristics of this property.

456 ni.com

niRFSG Properties

Short Name

Data type

Permissions

High-level VIs

Channel-based

Resettable

Triggers:Start:Type
Triggers:Start:Type

StartTrig.TerminalName

Read Only

niRFSG Get Terminal Name

No

No

Specifies the Start Trigger type. Depending upon the value of this property, more
properties may be needed to fully configure the trigger. To set this property, the NI-
RFSG device must be in the Configuration state.

PXIe-5654/5654 with PXIe-5696: The Start Trigger is valid only with a timer-based list
when RF list mode is enabled.

Supported Devices: PXIe-5644/5645/5646, PXIe-5654/5654 with PXIe-5696, PXI-5670/
5671, PXIe-5672/5673/5673E, PXIe-5820/5830/5831/5832/5840/5841/5842/5860

Default Value: None

Related Topics

Start Trigger

Trigger Types

Remarks

The following table lists the characteristics of this property.

Short Name

Data type

Permissions

StartTrig.Type

Read/Write

© National Instruments 457

niRFSG Properties

High-level VIs

Channel-based

Resettable

niRFSG Configure Trigger

No

Yes

None

0  Generation starts immediately. No trigger is configured.

Digital
Edge

1

Data operation does not start until a digital edge is detected. The source of the digital
edge is specified in the Digital Edge Start Trigger Source property and the active edge
is specified in Digital Edge Start Trigger Edge property.

Software  2

Data operation does not start until a software event occurs. You can create a software
event by calling the niRFSG Send Software Edge Trigger VI with StartTrigger as
the trigger name.

P2P
Endpoint
Fullness

3

Data operation does not start until the endpoint reaches a threshold specified in the
P2P Endpoint Fullness Start Trigger Level property.

458 ni.com

© 2026 National Instruments Corporation.

