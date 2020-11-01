using System;

namespace CleanerLibrary
{
    public interface IFileHelper
    {
        bool Exists(string path);
        void Delete(string path);
        DateTime GetLastWriteTime(string path);
    }
}
