namespace WlanRfAmpTest.Core
{
    /// <summary>Sequence parameter names passed from the sequencer to TestStand via <c>Engine.NewExecution</c> and defined on the entry sequence.</summary>
    public static class TestStandWlanSequenceParameterNames
    {
        public const string PointIndex = "Wlan_PointIndex";
        public const string CenterFrequencyHz = "Wlan_CenterFrequencyHz";
        public const string BandwidthMHz = "Wlan_BandwidthMHz";
        public const string StandardLabel = "Wlan_StandardLabel";
        public const string BandLabel = "Wlan_BandLabel";
        public const string WaveformPath = "Wlan_WaveformPath";
        public const string ResourceName = "Wlan_ResourceName";
        public const string OptionsString = "Wlan_OptionsString";

        /// <summary>Path to waveforms.json for TestStand full-matrix and nested sequences.</summary>
        public const string CatalogPath = "Wlan_CatalogPath";

        /// <summary>CSV output path for generated TestStand runs.</summary>
        public const string CsvPath = "Wlan_CsvPath";

        /// <summary>Non-zero to include 2.4 GHz band (Number).</summary>
        public const string IncludeBand24 = "Wlan_IncludeBand24";

        /// <summary>Non-zero to include 5 GHz band (Number).</summary>
        public const string IncludeBand5 = "Wlan_IncludeBand5";

        /// <summary>Non-zero to run composite EVM + TxP (Number).</summary>
        public const string RunCompositeEvmTxp = "Wlan_RunCompositeEvmTxp";

        /// <summary>Non-zero to run SEM (Number).</summary>
        public const string RunSem = "Wlan_RunSem";

        /// <summary>Non-zero to include 20 MHz bandwidth in the matrix (Number).</summary>
        public const string Bw20 = "Wlan_Bw20";

        /// <summary>Non-zero to include 40 MHz bandwidth in the matrix (Number).</summary>
        public const string Bw40 = "Wlan_Bw40";

        /// <summary>Non-zero to include 80 MHz bandwidth in the matrix (Number).</summary>
        public const string Bw80 = "Wlan_Bw80";

        /// <summary>Non-zero to include 802.11ac in the matrix (Number).</summary>
        public const string StdAc = "Wlan_StdAc";

        /// <summary>Non-zero to include 802.11ax in the matrix (Number).</summary>
        public const string StdAx = "Wlan_StdAx";

        /// <summary>0 = default nested order (freq → standard → bandwidth); 1 = frequency → bandwidth → standard (Number).</summary>
        public const string SweepOrdering = "Wlan_SweepOrdering";

        /// <summary>Total test points for the flat loop (Number); must match the catalog + sweep selection.</summary>
        public const string TotalPoints = "Wlan_TotalPoints";

        /// <summary>Nested loop: number of bands in sweep (1 or 2).</summary>
        public const string BandCount = "Wlan_BandCount";

        /// <summary>Nested loop: frequency count for the first sweep band (Locals.BandIdx == 0).</summary>
        public const string FreqCountBand0 = "Wlan_FreqCountBand0";

        /// <summary>Nested loop: frequency count for the second sweep band (Locals.BandIdx == 1).</summary>
        public const string FreqCountBand1 = "Wlan_FreqCountBand1";

        /// <summary>Nested loop: standard count (802.11ac/ax selection).</summary>
        public const string StdCount = "Wlan_StdCount";

        /// <summary>Nested loop: bandwidth step count (20/40/80 MHz selection).</summary>
        public const string BwCount = "Wlan_BwCount";
    }
}
