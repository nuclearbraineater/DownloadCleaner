﻿namespace CleanerLibrary
{
    public interface IDirectoryHelper
    {
        public bool DirectoryExists();
        public string[] GetFiles();
    }
}
