using System;

namespace CleanerLibrary
{
    public class FolderCleaner
    {
        private readonly FileCatcher _fileCatcher;
        private readonly FileHelper _fileHelper;
        private readonly Logger _logger;
        private DateTime sixMonthsInThePast = DateTime.UtcNow.AddMonths(-6);

        public FolderCleaner(FileCatcher fileCatcher, FileHelper fileHelper)
        {
            _fileCatcher = fileCatcher ?? throw new ArgumentNullException($"no {nameof(FileCatcher)} given.");
            _fileHelper = fileHelper ?? throw new ArgumentNullException($"no {nameof(FileHelper)} given.");
            _logger = new Logger();
        }

        public void StartFolderCleaning()
        {
            var files = _fileCatcher.GetFiles();
            foreach(var file in files)
            {
                var lastWriteTime = _fileHelper.GetLastWriteTime(file);
                if(lastWriteTime < sixMonthsInThePast)
                {
                    _logger.Log($"Deleting {file}");
                    _fileHelper.Delete(file);
                }
            }
        }
    }
}
