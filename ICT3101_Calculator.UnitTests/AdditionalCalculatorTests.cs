using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp] 
        public void Setup() 
        { 
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => 
                fr.Read(@"MagicNumbers.txt")).Returns(new string[5]{ "11","12","13","-14","-15"});
            _calculator = new Calculator(); 
        }

        [Test]
        [TestCase(1)]
        public void GetMagicNumber_WhenPositiveNumber_ReturnNumberInFile(int p0)
        {
            IFileReader fileReader = _mockFileReader.Object;
            Assert.That(_calculator.GenMagicNum(p0, fileReader), Is.EqualTo(24));
        }
        [Test]
        [TestCase(3)]
        public void GetMagicNumber_WhenInputNumber_ReturnNumberInFile(int p0)
        {
            //IFileReader fileReader = new FileReader();
            IFileReader fileReader = _mockFileReader.Object;
            Assert.That(_calculator.GenMagicNum(p0, fileReader), Is.EqualTo(28));
        }

    }
}
