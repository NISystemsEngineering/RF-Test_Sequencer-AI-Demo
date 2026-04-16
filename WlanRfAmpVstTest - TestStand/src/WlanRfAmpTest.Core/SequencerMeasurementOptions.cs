namespace WlanRfAmpTest.Core
{
    /// <summary>Selects which RFmx measurement blocks run per sequencer point (RFSG playback is always used).</summary>
    public sealed class SequencerMeasurementOptions
    {
        /// <summary>OFDM ModAcc + TxP composite (single acquisition).</summary>
        public bool RunCompositeEvmTxp { get; set; } = true;

        /// <summary>Spectrum Emission Mask (separate acquisition).</summary>
        public bool RunSem { get; set; } = true;

        public bool IsValid => RunCompositeEvmTxp || RunSem;
    }
}
