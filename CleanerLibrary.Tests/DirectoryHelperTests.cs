using System;
using Xunit;

namespace CleanerLibrary.Tests
{
    public class DirectoryHelperTests
    {
        [Fact]
        public void FolderExists_ShouldReturnTrue()
        {
            //Arrange
            var directoryProvider = new DirectoryProvider();
            var directoryHelper = new DirectoryHelper(directoryProvider);

            //Act
            var directoryExists = directoryHelper.DirectoryExists();

            //Assert
            Assert.True(directoryExists);
        }

        [Fact]
        public void FolderExists_ShouldReturnFalse()
        {
            //Arrange
            var directoryProvider = new DirectoryProvider
            {
                DownloadFolder = ""
            };
            var directoryHelper = new DirectoryHelper(directoryProvider);

            //Act //Assert
            Assert.Throws<ArgumentNullException>(() => directoryHelper.DirectoryExists());
        }

        [Fact]
        public void GetFilesFromDownloadDirectory_ShouldReturnFiles()
        {
            //Arrange
            var directoryProvider = new DirectoryProvider();
            var directoryHelper = new DirectoryHelper(directoryProvider);
            var files = new string[0];

            //Act
            files = directoryHelper.GetFiles();

            //Assert
            Assert.True(files.Length > 0);
        }
    }
}
