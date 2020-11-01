using System;
using System.Collections.Generic;

namespace CleanerLibrary
{
    public class FileCatcher
    {
        private readonly DirectoryHelper _directoryHelper;
        
        public FileCatcher(DirectoryHelper directoryHelper)
        {
            _directoryHelper = directoryHelper ?? throw new ArgumentNullException($"{nameof(DirectoryHelper)} not given.");
        }

        public IEnumerable<string> GetFiles()
        {
            return _directoryHelper.GetFiles();
        }
    }
}
