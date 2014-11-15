using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using NUnit.Framework;
using CalculadoraString;

namespace TestString
{
    public class SumaStringTest
    {

        private CalculaSuma calculaSuma { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            calculaSuma = new CalculaSuma();
        }

        [Test]
        public void TestStringSuma15y15y5y10()
        {
            // Act
            var result = calculaSuma.CalculadoraString("15,15,5,10");

            // Assert
            Assert.AreEqual("45", result);
        }

        [Test]
        public void TestStringSumaNada()
        {
            // Act
            var result = calculaSuma.CalculadoraString("");

            // Assert
            Assert.AreEqual("0", result);
        }

        [Test]
        public void TestStringSuma15y15y1000y5y10()
        {
            // Act
            var result = calculaSuma.CalculadoraString("15,15,1000,5,10");

            // Assert
            Assert.AreEqual("45", result);
        }

        [Test]
        public void TestStringSuma15y15yMenos3y5y10()
        {
            // Act
            var result = calculaSuma.CalculadoraString("15,15,-3,5,10");

            // Assert
            Assert.AreEqual(new InvalidDataException(), result);
        }

        [Test]
        public void TestStringSuma15y15y5000y5y10()
        {
            // Act
            var result = calculaSuma.CalculadoraString("15,15,5000,5,10");

            // Assert
            Assert.AreEqual("45", result);
        }
    }
}
