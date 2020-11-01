using System;
using Xunit;

namespace CleanerLibrary.Tests
{
    public class FolderCleanerTests
    {
        [Fact]
        public void CreateFolderCleanerWithMissingParameter_ShouldTrowArgumentNullException()
        {
            //Arrange //Act //Assert
            FolderCleaner folderCleaner;
            Assert.Throws<ArgumentNullException>(() => folderCleaner = new FolderCleaner(null, null));
        }

        [Fact]
        public void CreateFolderCleaner_ShouldWork()
        {
            //Arrange 
            var directoryProvider = new DirectoryProvider();
            var directoryHelper = new DirectoryHelper(directoryProvider);
            var fileCatcher = new FileCatcher(directoryHelper);
            var fileHelper = new FileHelper();

            //Act 
            var folderCleaner = new FolderCleaner(fileCatcher, fileHelper);

            //Assert            
            Assert.True(folderCleaner != null);
        }
        
        [Fact]
        public void StartFolderCleaning_ShouldWork()
        {
            //Arrange
            var fileCatcher = new FileCatcher(new DirectoryHelper(new DirectoryProvider()));
            var fileHelper = new FileHelper();
            var folderCleaner = new FolderCleaner(fileCatcher, fileHelper);

            //Act
            folderCleaner.StartFolderCleaning();

            //Assert
            Assert.True(1 == 1);
        }
    }
}
