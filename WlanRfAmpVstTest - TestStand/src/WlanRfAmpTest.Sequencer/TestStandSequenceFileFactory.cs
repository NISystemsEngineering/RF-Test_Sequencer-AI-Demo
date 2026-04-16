using System;
using System.IO;
using NationalInstruments.TestStand.Interop.API;
using WlanRfAmpTest.Core;

namespace WlanRfAmpTest.Sequencer
{
    /// <summary>Creates a TestStand <c>.seq</c> file using <see cref="Engine.NewSequenceFile"/> and <see cref="SequenceFile.Save"/>.</summary>
    public static partial class TestStandSequenceFileFactory
    {
        /// <summary>Writes a sequence file with <c>MainSequence</c> and WLAN hook parameters (empty body — add steps in the Sequence Editor).</summary>
        public static void Create(string outputPath)
        {
            if (string.IsNullOrWhiteSpace(outputPath))
                throw new ArgumentException("Output path is required.", nameof(outputPath));

            using (var sta = new StaExecutionQueue())
            {
                sta.Invoke(() => CreateOnStaThread(outputPath));
            }
        }

        static void CreateOnStaThread(string outputPath)
        {
            Engine engine = new Engine();
            engine.CurrentUser = engine.GetUser("Administrator");
            SequenceFile sequenceFile = null;
            try
            {
                sequenceFile = engine.NewSequenceFile();
                while (sequenceFile.NumSequences > 0)
                    sequenceFile.DeleteSequence(0);

                Sequence sequence = engine.NewSequence();
                sequence.Name = "MainSequence";
                sequence.Type = SequenceTypes.SeqType_Normal;

                PropertyObject parameters = sequence.Parameters;
                AddNumber(parameters, TestStandWlanSequenceParameterNames.PointIndex, 0);
                AddNumber(parameters, TestStandWlanSequenceParameterNames.CenterFrequencyHz, 2.412e9);
                AddNumber(parameters, TestStandWlanSequenceParameterNames.BandwidthMHz, 20);
                AddString(parameters, TestStandWlanSequenceParameterNames.StandardLabel, "802.11ac");
                AddString(parameters, TestStandWlanSequenceParameterNames.BandLabel, "2.4GHz");
                AddString(parameters, TestStandWlanSequenceParameterNames.WaveformPath, "");
                AddString(parameters, TestStandWlanSequenceParameterNames.ResourceName, "5841");
                AddString(parameters, TestStandWlanSequenceParameterNames.OptionsString, "");

                sequenceFile.InsertSequenceEx(0, sequence);

                string full = Path.GetFullPath(outputPath);
                string dir = Path.GetDirectoryName(full);
                if (!string.IsNullOrEmpty(dir))
                    Directory.CreateDirectory(dir);

                sequenceFile.Save(full);
            }
            finally
            {
                if (sequenceFile != null)
                    engine.ReleaseSequenceFileEx(sequenceFile);
            }
        }

        static void AddNumber(PropertyObject parameters, string name, double defaultValue)
        {
            parameters.NewSubProperty(
                name,
                PropertyValueTypes.PropValType_Number,
                false,
                "",
                PropertyOptions.PropOption_NoOptions);
            parameters.SetValNumber(name, PropertyOptions.PropOption_NoOptions, defaultValue);
        }

        static void AddString(PropertyObject parameters, string name, string defaultValue)
        {
            parameters.NewSubProperty(
                name,
                PropertyValueTypes.PropValType_String,
                false,
                "",
                PropertyOptions.PropOption_NoOptions);
            parameters.SetValString(name, PropertyOptions.PropOption_NoOptions, defaultValue ?? "");
        }
    }
}
