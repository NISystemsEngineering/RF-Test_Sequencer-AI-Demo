using NationalInstruments.RFmx.WlanMX;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Instrument
{
    public static class WlanStandardMap
    {
        public static RFmxWlanMXStandard ToRfmx(WlanStandardKind standard)
        {
            return standard == WlanStandardKind.IEEE802_11ac
                ? RFmxWlanMXStandard.Standard802_11ac
                : RFmxWlanMXStandard.Standard802_11ax;
        }
    }
}
