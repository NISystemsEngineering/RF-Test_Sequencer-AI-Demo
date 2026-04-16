using System;
using System.IO;

namespace WlanRfAmpTest.Launcher
{
    /// <summary>Resolves paths to sibling tool executables from typical Visual Studio output layouts.</summary>
    internal static class ExeLocator
    {
        public static string TryFind(string exeFileName)
        {
            if (string.IsNullOrWhiteSpace(exeFileName))
                return "";
            string baseDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(Path.DirectorySeparatorChar);
            string same = Path.Combine(baseDir, exeFileName);
            if (File.Exists(same))
                return same;

            // From ...\src\WlanRfAmpTest.Launcher\bin\x64\Debug\net48\ go up five levels to ...\src\
            string srcRoot = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "..", ".."));
            string[] projects =
            {
                "WlanRfAmpTest.Sequencer",
                "WlanRfAmpTest.ModuleRunner",
                "WlanRfAmpTest.Validation"
            };
            foreach (string folder in projects)
            {
                foreach (string cfg in new[] { "Debug", "Release" })
                {
                    string p = Path.Combine(srcRoot, folder, "bin", "x64", cfg, "net48", exeFileName);
                    if (File.Exists(p))
                        return p;
                }
            }

            return "";
        }
    }
}
