using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class InverseTrigonometricFunctionsTests
    {
        [TestMethod()]
        public void ArcTanRadianTest1()
        {
            // Arrange
            double xPositive = 3;
            double yPositive = 4;
            double expected = Math.Atan2(4,3);

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanRadian(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }

        // ==========================================================================

        [TestMethod()]
        public void ArcTanDegreeTest1()
        {
            // Arrange
            double xPositive = 1;
            double yPositive = 1;
            double expected = 45;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
        [TestMethod()]
        public void ArcTanDegreeTest2()
        {
            // Arrange
            double xPositive = 0;
            double yPositive = 1;
            double expected = 90;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
        [TestMethod()]
        public void ArcTanDegreeTest3()
        {
            // Arrange
            double xPositive = 1;
            double yPositive = 0;
            double expected = 0;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
        [TestMethod()]
        public void ArcTanDegreeTest4()
        {
            // Arrange
            double xPositive = 0;
            double yPositive = 0;
            double expected = 0;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
        [TestMethod()]
        public void ArcTanDegreeTest5()
        {
            // Arrange
            double xPositive = -1;
            double yPositive = 0;
            double expected = 180;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
        [TestMethod()]
        public void ArcTanDegreeTest6()
        {
            // Arrange
            double xPositive = 0;
            double yPositive = -4;
            double expected = 270;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }

        [TestMethod()]
        public void ArcTanDegreeTest7()
        {
            // Arrange
            double xPositive = -1;
            double yPositive = -1;
            double expected = 270-45;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }

        [TestMethod()]
        public void ArcTanDegreeTest8()
        {
            // Arrange
            double xPositive = 1;
            double yPositive = -1;
            double expected = 270 + 45;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }

        [TestMethod()]
        public void ArcTanDegreeTest9()
        {
            // Arrange
            double xPositive = -1;
            double yPositive = -1;
            double expected = 270 - 45;

            //Act
            double actual = InverseTrigonometricFunctions.ArcTanDegree(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error arctan measure");
        }
    }
}