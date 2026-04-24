# Missing Dependencies Setup Guide

## Overview
This project requires National Instruments (NI) software to be installed on your machine. The project references NI assemblies that are installed to the Global Assembly Cache (GAC) when you install the required NI software packages.

## Required Software

### 1. NI-RFmx WLAN (Version 25.5 or later)
Provides:
- `NationalInstruments.RFmx.WlanMX.Fx40.dll`
- `NationalInstruments.RFmx.InstrMX.Fx40.dll`

### 2. NI-RFSG (Version 25.5 or later)
Provides:
- `NationalInstruments.ModularInstruments.NIRfsg.Fx40.dll`
- `NationalInstruments.ModularInstruments.Common.dll`

### 3. NI-RFsg Playback
Provides:
- `NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40.dll`

### 4. IVI Shared Components
Provides:
- `Ivi.Driver.dll`

### 5. NI Common (typically included with other NI software)
Provides:
- `NationalInstruments.Common.dll`

## Installation Steps

### Option 1: Using NI Package Manager (Recommended)
1. Download and install **NI Package Manager** from [ni.com](https://www.ni.com/en-us/support/downloads/software-products/download.ni-package-manager.html)
2. Launch NI Package Manager
3. Search for and install the following packages:
   - **NI-RFmx WLAN** (version 25.5 or later)
   - **NI-RFSG** (version 25.5 or later)
4. Accept any additional dependencies that are automatically selected
5. Complete the installation

### Option 2: Manual Download
1. Visit the [National Instruments Downloads page](https://www.ni.com/en-us/support/downloads.html)
2. Search for each required component:
   - NI-RFmx WLAN
   - NI-RFSG
3. Download and install each package
4. Follow the installation wizard for each package

## Verifying Installation

After installation, you can verify the assemblies are available by checking the GAC:

### Windows GAC Locations:
- **C:\Windows\Microsoft.NET\assembly\GAC_MSIL\** (for .NET 4.0+ assemblies)
- **C:\Program Files (x86)\IVI Foundation\IVI\Microsoft.NET\Framework32\v4.0.30319\** (for IVI/NI assemblies)

Look for folders containing:
- NationalInstruments.RFmx.WlanMX.Fx40
- NationalInstruments.RFmx.InstrMX.Fx40
- NationalInstruments.ModularInstruments.NIRfsg.Fx40
- NationalInstruments.ModularInstruments.NIRfsgPlayback.Fx40

## After Installation

Once the NI software is installed:
1. Restart Visual Studio
2. Rebuild the solution
3. The assemblies should now resolve correctly from the GAC

## Alternative: Development Without Hardware

If you don't have access to NI hardware and just need the project to compile:
1. The NI software can be installed in "development" mode without requiring actual hardware
2. The assemblies will be available for compilation
3. Runtime execution will fail if hardware is not connected, but the code will compile successfully

## Troubleshooting

### Build Still Fails After Installation
- Verify the installed versions match the expected versions (25.5 or compatible)
- Check that Visual Studio was restarted after NI software installation
- Verify assemblies exist in GAC using the paths above

### NuGet Source Issues
If you encounter NuGet restore errors related to local sources:
```powershell
dotnet nuget list source
dotnet nuget disable source "SourceName"
```

## Contact

For issues with:
- **NI Software Installation**: Contact National Instruments Support at ni.com/support
- **Project Configuration**: Check the project repository or contact the development team

## License & Legal

National Instruments software is proprietary and requires appropriate licenses. Ensure you have the necessary licenses before installation.
