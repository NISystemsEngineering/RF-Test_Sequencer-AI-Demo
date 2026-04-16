using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NationalInstruments.DataStore.Utilities
{
    /// <summary>
    /// Isolated Measurement Data Services local store (SQLite + data files). Mirrors NI datastore-dotnet examples.
    /// </summary>
    public sealed class DataStoreContext : IDisposable
    {
        const string DiscoveryServiceClusterIdEnvVar = "NIDiscovery_ClusterId";
        const string DataStoreDatabasePathEnvVar = "NIDATASTORE_DATASTORESETTINGS__SQLITEDATABASEPATH";
        const string DataStoreDataFilesDirectoryPathEnvVar = "NIDATASTORE_DATASTORESETTINGS__DATAFILESDIRECTORY";
        const string DataStoreIngestDirectoryPathEnvVar = "NIDATASTORE_DATASTORESETTINGS__INGESTDIRECTORY";
        const string DataStoreFailedIngestDirectoryPathEnvVar = "NIDATASTORE_DATASTORESETTINGS__FAILEDINGESTDIRECTORY";
        const string DataStoreTdmsExpirationSecondsEnvName = "NIDATASTORE_DATASTORESETTINGS__TDMSFILECACHEEXPIRATIONSECONDS";

        readonly string? _baseDirectoryPath;
        readonly Dictionary<string, string?> _originalEnvironment = new();
        bool _disposed;

        public DataStoreContext(string? baseDirectoryPath = null)
        {
            _baseDirectoryPath = baseDirectoryPath;
            SaveOriginalEnvironment();
            InitializeClusterId();
            InitializeDataStorePaths();
        }

        public void Dispose()
        {
            if (_disposed)
                return;
            foreach (var kv in _originalEnvironment)
                Environment.SetEnvironmentVariable(kv.Key, kv.Value);
            _disposed = true;
        }

        void SaveOriginalEnvironment()
        {
            foreach (string name in new[]
                     {
                         DiscoveryServiceClusterIdEnvVar,
                         DataStoreDatabasePathEnvVar,
                         DataStoreDataFilesDirectoryPathEnvVar,
                         DataStoreIngestDirectoryPathEnvVar,
                         DataStoreFailedIngestDirectoryPathEnvVar,
                         DataStoreTdmsExpirationSecondsEnvName
                     })
                _originalEnvironment[name] = Environment.GetEnvironmentVariable(name);
        }

        void InitializeClusterId()
        {
            Environment.SetEnvironmentVariable(DiscoveryServiceClusterIdEnvVar, GetClusterId());
        }

        void InitializeDataStorePaths()
        {
            string baseDirectoryPath = GetBaseDirectoryPath();
            Environment.SetEnvironmentVariable(DataStoreDatabasePathEnvVar, Path.Combine(baseDirectoryPath, "MetadataStore.db"));
            Environment.SetEnvironmentVariable(DataStoreDataFilesDirectoryPathEnvVar, Path.Combine(baseDirectoryPath, "DataFiles"));
            Environment.SetEnvironmentVariable(DataStoreIngestDirectoryPathEnvVar, Path.Combine(baseDirectoryPath, "Ingest"));
            Environment.SetEnvironmentVariable(DataStoreFailedIngestDirectoryPathEnvVar, Path.Combine(baseDirectoryPath, "FailedIngest"));
            Environment.SetEnvironmentVariable(DataStoreTdmsExpirationSecondsEnvName, "0");
        }

        string GetClusterId()
        {
            string baseDirectoryPath = GetBaseDirectoryPath();
            string resolvedPath = Path.GetFullPath(baseDirectoryPath);
            using var sha256 = SHA256.Create();
            byte[] pathBytes = Encoding.UTF8.GetBytes(resolvedPath);
            byte[] hashBytes = sha256.ComputeHash(pathBytes);
            var sb = new StringBuilder();
            for (int i = 0; i < Math.Min(16, hashBytes.Length); i++)
                sb.Append(hashBytes[i].ToString("x2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        string GetBaseDirectoryPath()
        {
            if (!string.IsNullOrEmpty(_baseDirectoryPath))
                return _baseDirectoryPath;

            string local = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "WlanRfAmpVstTest",
                "MeasurementDataServices");
            return local;
        }
    }
}
