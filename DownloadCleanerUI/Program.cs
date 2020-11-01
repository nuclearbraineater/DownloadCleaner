using CleanerLibrary;
using System;

namespace DownloadCleanerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var directoryHelper = new DirectoryHelper(new DirectoryProvider());
            var fileCatcher = new FileCatcher(directoryHelper);
            var fileHelper = new FileHelper();
            FolderCleaner downloadfolderCleaner = new FolderCleaner(fileCatcher, fileHelper);
            Console.WriteLine("Start DownloadCleaner");

            downloadfolderCleaner.StartFolderCleaning();


        }
    }
}
