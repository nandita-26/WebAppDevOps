using NUnit.Framework;
using MagicFilesLib;
using Moq;
using System.IO;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";
        private Program _program;
        private Mock<IDirectoryExplorer> _directoryExplorer;
        private ICollection<string> result;

        [SetUp]
        public void Setup()
        {
            _directoryExplorer = new Mock<IDirectoryExplorer>(); //instance 
            _program = new Program(_directoryExplorer.Object);
            _directoryExplorer.Setup(fr => fr.GetFiles(It.IsAny<string>())).Returns(new string[] { _file1, _file2 });
            result = _program.GetAllFiles("abc.txt");
        }

        [Test]
        public void GetFiles_WhenCalled_ReturnsCollection()
        {
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void GetFiles_WhenCalled_ReturnsCountValueTwo()
        {
            Assert.That(result.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetFiles_WhenCalled_ReturnsCollectionWithFile1()
        {
            Assert.That(result, Does.Contain(_file1));
        }
    }
}
