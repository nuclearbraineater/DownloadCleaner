using System;
using System.IO;

namespace CleanerLibrary
{
    public class FileHelper : IFileHelper
    {
        public void Delete(string path)
        {
            File.Delete(path);
        }

        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        public DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }
    }
}
