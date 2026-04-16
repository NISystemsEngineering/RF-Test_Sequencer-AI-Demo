using System.Globalization;
using NationalInstruments;
using NationalInstruments.DataStore.Utilities;
using NationalInstruments.Measurements.Data.V1;
using NationalInstruments.Measurements.Metadata.V1;
using NationalInstruments.Protobuf.Types;

namespace WlanRfAmpTest.Mds
{
    /// <summary>Publishes one <see cref="MeasurementRowPayload"/> as a <see cref="TestResult"/> with scalar measurements (NI Measurement Data Services).</summary>
    public sealed class WlanMdsPublisher : IAsyncDisposable
    {
        DataStoreContext? _ctx;
        GrpcClientStubFactory? _factory;
        DataStoreService.DataStoreServiceClient? _data;
        MetadataStoreService.MetadataStoreServiceClient? _meta;
        string? _operatorId;
        string? _stationId;
        string? _softwareId;
        bool _initialized;

        public async Task InitializeAsync(CancellationToken cancellationToken = default)
        {
            if (_initialized)
                return;

            _ctx = new DataStoreContext();
            _factory = new GrpcClientStubFactory();
            _data = _factory.CreateClient<DataStoreService.DataStoreServiceClient>();
            _meta = _factory.CreateClient<MetadataStoreService.MetadataStoreServiceClient>();

            var op = new Operator
            {
                Name = "WlanRfAmpTest",
                Role = "Automated test"
            };
            _operatorId = await _meta.CreateOperatorAsync(op, cancellationToken: cancellationToken).ConfigureAwait(false);

            var station = new TestStation { Name = "WlanRfAmpTest_Station" };
            _stationId = await _meta.CreateTestStationAsync(station, cancellationToken: cancellationToken).ConfigureAwait(false);

            var sw = new SoftwareItem
            {
                Product = "WlanRfAmpVstTest",
                Version = typeof(WlanMdsPublisher).Assembly.GetName().Version?.ToString() ?? "1.0.0.0"
            };
            _softwareId = await _meta.CreateSoftwareItemAsync(sw, cancellationToken: cancellationToken).ConfigureAwait(false);

            _initialized = true;
        }

        public async Task PublishRowAsync(MeasurementRowPayload dto, CancellationToken cancellationToken = default)
        {
            if (!_initialized || _data == null || _meta == null || string.IsNullOrEmpty(_operatorId) || string.IsNullOrEmpty(_stationId) || string.IsNullOrEmpty(_softwareId))
                throw new InvalidOperationException("Call InitializeAsync first.");

            string name = string.Format(CultureInfo.InvariantCulture,
                "WLAN TestIndex={0} Band={1} Std={2} @ {3:o}",
                dto.TestIndex, dto.Band, dto.Standard, dto.TimestampUtc);

            var testResult = new TestResult
            {
                Name = name,
                OperatorId = _operatorId,
                TestStationId = _stationId
            };
            testResult.SoftwareItemIds.Add(_softwareId);

            string testResultId = await _data.CreateTestResultAsync(testResult, cancellationToken: cancellationToken).ConfigureAwait(false);

            var step = new Step
            {
                Name = "WlanRfAmp point",
                TestResultId = testResultId
            };
            string stepId = await _data.CreateStepAsync(step, cancellationToken: cancellationToken).ConfigureAwait(false);

            Outcome outcome = dto.Pass ? Outcome.Passed : Outcome.Failed;
            var when = PrecisionDateTime.FromDateTimeUtc(dto.TimestampUtc);

            if (dto.CenterFrequencyHz > 0)
                await PublishScalarAsync("CenterFrequency_Hz", dto.CenterFrequencyHz, "Hz", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.BandwidthMHz > 0)
                await PublishScalarAsync("Bandwidth_MHz", dto.BandwidthMHz, "MHz", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.EvmRmsDb.HasValue && !double.IsNaN(dto.EvmRmsDb.Value) && !double.IsInfinity(dto.EvmRmsDb.Value))
                await PublishScalarAsync("EVM_RMS_dB", dto.EvmRmsDb.Value, "dB", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.DataEvmRmsDb.HasValue && !double.IsNaN(dto.DataEvmRmsDb.Value) && !double.IsInfinity(dto.DataEvmRmsDb.Value))
                await PublishScalarAsync("DataEVM_RMS_dB", dto.DataEvmRmsDb.Value, "dB", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.PilotEvmRmsDb.HasValue && !double.IsNaN(dto.PilotEvmRmsDb.Value) && !double.IsInfinity(dto.PilotEvmRmsDb.Value))
                await PublishScalarAsync("PilotEVM_RMS_dB", dto.PilotEvmRmsDb.Value, "dB", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.TxpAverageDbm.HasValue && !double.IsNaN(dto.TxpAverageDbm.Value) && !double.IsInfinity(dto.TxpAverageDbm.Value))
                await PublishScalarAsync("TxP_Average_dBm", dto.TxpAverageDbm.Value, "dBm", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.TxpPeakDbm.HasValue && !double.IsNaN(dto.TxpPeakDbm.Value) && !double.IsInfinity(dto.TxpPeakDbm.Value))
                await PublishScalarAsync("TxP_Peak_dBm", dto.TxpPeakDbm.Value, "dBm", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (dto.SemMinMarginDb.HasValue && !double.IsNaN(dto.SemMinMarginDb.Value) && !double.IsInfinity(dto.SemMinMarginDb.Value))
                await PublishScalarAsync("SEM_MinMargin_dB", dto.SemMinMarginDb.Value, "dB", when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(dto.SemMeasurementStatus))
                await PublishStringScalarAsync("SEM_Status", dto.SemMeasurementStatus, when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(dto.Error))
                await PublishStringScalarAsync("Error", dto.Error, when, stepId, outcome, cancellationToken).ConfigureAwait(false);

            await PublishScalarAsync("Pass", dto.Pass ? 1.0 : 0.0, "", when, stepId, outcome, cancellationToken).ConfigureAwait(false);
        }

        async Task PublishScalarAsync(
            string measurementName,
            double value,
            string units,
            PrecisionDateTime when,
            string stepId,
            Outcome outcome,
            CancellationToken cancellationToken)
        {
            var scalar = new Scalar { DoubleValue = value, Units = units ?? "" };
            await _data!.PublishMeasurementAsync(measurementName, scalar, when, stepId, outcome: outcome, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        async Task PublishStringScalarAsync(
            string measurementName,
            string text,
            PrecisionDateTime when,
            string stepId,
            Outcome outcome,
            CancellationToken cancellationToken)
        {
            var scalar = new Scalar { StringValue = text ?? "" };
            await _data!.PublishMeasurementAsync(measurementName, scalar, when, stepId, outcome: outcome, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        public async ValueTask DisposeAsync()
        {
            if (_factory != null)
                await _factory.DisposeAsync().ConfigureAwait(false);
            _factory = null;
            _data = null;
            _meta = null;
            _ctx?.Dispose();
            _ctx = null;
            _initialized = false;
        }
    }
}
