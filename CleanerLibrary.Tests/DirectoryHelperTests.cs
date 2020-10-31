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
            var directoryProvider = new DirectoryProvider();
            directoryProvider.DownloadFolder = "";
            var directoryHelper = new DirectoryHelper(directoryProvider);

            //Act Assert
            Assert.Throws<ArgumentNullException>(() => directoryHelper.DirectoryExists());
            //var exception = Assert.Throws<ArgumentNullException>(() => directoryHelper.DirectoryExists());

            //var directoryExists = directoryHelper.DirectoryExists();

            ////Assert
            //Assert.False(directoryExists);
        }
    }
}
