using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WlanRfAmpTest.Core
{
    /// <summary>
    /// SI-style engineering prefixes (powers of 10³): y, z, a, f, p, n, u, m, (none), k, M, G, T, P, E, Z, Y.
    /// Micro uses ASCII <c>u</c> per common lab tooling. Logarithmic units (dB, dBm) use decimal form without SI prefixes on the mantissa.
    /// </summary>
    public static class ScientificNumberFormat
    {
        /// <summary>Prefixes for exponents −24 … +24 in steps of 3 (index 0 = y at 10⁻²⁴).</summary>
        static readonly string[] SiPrefixes =
        {
            "y", "z", "a", "f", "p", "n", "u", "m", "",
            "k", "M", "G", "T", "P", "E", "Z", "Y"
        };

        const int SiCenterIndex = 8;

        /// <summary>Axis tick labels (compact general; chart control has no SI callback).</summary>
        public const string ChartAxis = "G3";

        /// <summary>Formats <paramref name="valueInBaseUnits"/> with an SI prefix and <paramref name="unit"/> (e.g. Hz → <c>2.412 GHz</c>).</summary>
        public static string FormatSi(double valueInBaseUnits, string unit, int significantDigits = 4)
        {
            if (double.IsNaN(valueInBaseUnits) || double.IsInfinity(valueInBaseUnits))
                return valueInBaseUnits.ToString(CultureInfo.InvariantCulture);
            unit = unit?.Trim() ?? "";

            if (valueInBaseUnits == 0)
                return "0 " + unit;

            double sign = Math.Sign(valueInBaseUnits);
            double abs = Math.Abs(valueInBaseUnits);
            double log10 = Math.Log10(abs);

            // Nearest power-of-1000 exponent (engineering-style) so mantissa is usually in ~[0.1, 1000).
            int exp3 = (int)Math.Round(log10 / 3.0) * 3;
            if (exp3 < -24)
                exp3 = -24;
            else if (exp3 > 24)
                exp3 = 24;

            double scaled = valueInBaseUnits / Math.Pow(10, exp3);
            while (Math.Abs(scaled) >= 1000 - 1e-12)
            {
                exp3 += 3;
                if (exp3 > 24)
                    return FallbackScientific(valueInBaseUnits, unit);
                scaled /= 1000;
            }
            while (Math.Abs(scaled) > 0 && Math.Abs(scaled) < 0.1 - 1e-15)
            {
                exp3 -= 3;
                if (exp3 < -24)
                    return FallbackScientific(valueInBaseUnits, unit);
                scaled *= 1000;
            }

            int prefixIndex = SiCenterIndex + exp3 / 3;
            if (prefixIndex < 0 || prefixIndex >= SiPrefixes.Length)
                return FallbackScientific(valueInBaseUnits, unit);

            string prefix = SiPrefixes[prefixIndex];
            string num = Math.Abs(scaled).ToString("G" + significantDigits, CultureInfo.InvariantCulture);
            if (sign < 0)
                num = "-" + num;
            if (string.IsNullOrEmpty(unit))
                return num + " " + prefix;
            return num + " " + prefix + unit;
        }

        static string FallbackScientific(double valueInBaseUnits, string unit)
        {
            string n = valueInBaseUnits.ToString("G4", CultureInfo.InvariantCulture);
            return string.IsNullOrEmpty(unit) ? n : n + " " + unit;
        }

        /// <summary>Parses Hz as a plain/scientific number, or SI form like <c>2.412 GHz</c> / <c>2412 MHz</c>.</summary>
        public static bool TryParseFrequencyHz(string text, out double hz)
        {
            hz = 0;
            if (string.IsNullOrWhiteSpace(text))
                return false;
            text = text.Trim();
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out hz))
                return true;

            // Normalize micro sign to ASCII u for prefix matching
            text = text.Replace('\u00b5', 'u');

            var m = Regex.Match(text, @"^([+-]?\d+(?:\.\d+)?(?:[eE][+-]?\d+)?)\s*([yzafpnumkMGTPEZY]?)\s*Hz\s*$", RegexOptions.CultureInvariant);
            if (!m.Success)
                return false;
            if (!double.TryParse(m.Groups[1].Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double mant))
                return false;
            string p = m.Groups[2].Value;
            if (string.IsNullOrEmpty(p))
            {
                hz = mant;
                return true;
            }
            if (!PrefixExponent.TryGetValue(p, out int exp))
                return false;
            hz = mant * Math.Pow(10, exp);
            return true;
        }

        static readonly Dictionary<string, int> PrefixExponent = new Dictionary<string, int>
        {
            ["y"] = -24, ["z"] = -21, ["a"] = -18, ["f"] = -15, ["p"] = -12, ["n"] = -9,
            ["u"] = -6, ["m"] = -3,
            ["k"] = 3, ["M"] = 6, ["G"] = 9, ["T"] = 12, ["P"] = 15, ["E"] = 18, ["Z"] = 21, ["Y"] = 24
        };

        /// <summary>Decibel-family values: no SI prefix on the number (e.g. <c>-32.5 dB</c>, <c>10.2 dBm</c>).</summary>
        public static string FormatDb(double valueDb, string unitSuffix)
        {
            if (double.IsNaN(valueDb) || double.IsInfinity(valueDb))
                return "—";
            return valueDb.ToString("0.###", CultureInfo.InvariantCulture) + " " + unitSuffix.Trim();
        }

        /// <summary>Legacy name: formats with SI when <paramref name="unit"/> is set; otherwise uses <see cref="FormatSi"/> with empty unit for raw magnitudes, or use overloads.</summary>
        public static string FormatDouble(double value, string format = "G4")
        {
            return value.ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>Finite value with SI base units, or placeholder for NaN/Inf.</summary>
        public static string FormatSiOrPlaceholder(double valueInBaseUnits, string unit, string placeholder = "—", int significantDigits = 4)
        {
            if (double.IsNaN(valueInBaseUnits) || double.IsInfinity(valueInBaseUnits))
                return placeholder;
            return FormatSi(valueInBaseUnits, unit, significantDigits);
        }

        /// <summary>Finite dB-family value or placeholder.</summary>
        public static string FormatDbOrPlaceholder(double valueDb, string unitSuffix, string placeholder = "—")
        {
            if (double.IsNaN(valueDb) || double.IsInfinity(valueDb))
                return placeholder;
            return FormatDb(valueDb, unitSuffix);
        }
    }
}
