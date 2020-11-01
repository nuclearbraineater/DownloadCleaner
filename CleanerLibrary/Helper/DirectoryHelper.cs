using System;
using System.IO;

namespace CleanerLibrary
{
    public class DirectoryHelper : IDirectoryHelper
    {
        DirectoryProvider _directoryProvider;

        public DirectoryHelper(DirectoryProvider directoryProvider)
        {
            _directoryProvider = directoryProvider ?? throw new ArgumentNullException($"{nameof(DirectoryProvider)} is not given");
        }

        public bool DirectoryExists()
        {
            if (String.IsNullOrEmpty(_directoryProvider.DownloadFolder))
                throw new ArgumentNullException("path is not given");

            if (Directory.Exists(_directoryProvider.DownloadFolder))
                return true;

            return false;
        }

        public string[] GetFiles()
        {
            var fileEntries = Directory.GetFiles(_directoryProvider.DownloadFolder);

            return fileEntries;
        }
    }
}
