using System;
using System.IO;

namespace CleanerLibrary
{
    public class Logger : ILogger
    {
        private const string logFilePath = @"C:\Users\skoeh\Documents\downloadCleanerLog.txt";
        public void Log(string text)
        {
            if (!File.Exists(logFilePath))
                File.Create(logFilePath);

            text = $"{DateTime.UtcNow} - {text} {Environment.NewLine}";
            File.AppendAllText(logFilePath, text);
        }
    }
}
