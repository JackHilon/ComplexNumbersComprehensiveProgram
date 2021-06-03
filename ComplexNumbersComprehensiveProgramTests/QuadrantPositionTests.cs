using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class QuadrantPositionTests
    {
        // --- Y Positive -------------------------------------------------------------------

        [TestMethod()]
        public void GetQuadrantPositionTest1()
        {

            // Arrange
            double xPositive = 9;
            double yPositive = 1.2;
            string expected = "First quadrant";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xPositive, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest2()
        {

            // Arrange
            double xNegative = -9;
            double yPositive = 1.2;
            string expected = "Second quadrant";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xNegative, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest3()
        {

            // Arrange
            double xZero = 0;
            double yPositive = 1.2;
            string expected = "Positive part of Y-Axis";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xZero, yPositive);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        // --- Y Negative -------------------------------------------------------------------

        [TestMethod()]
        public void GetQuadrantPositionTest4()
        {

            // Arrange
            double xPositive = 3;
            double yNegative = -7;
            string expected = "Fourth quadrant";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xPositive, yNegative);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest5()
        {

            // Arrange
            double xNegative = -9;
            double yNegative = -33;
            string expected = "Third quadrant";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xNegative, yNegative);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest6()
        {

            // Arrange
            double xZero = 0;
            double yNegative = -18;
            string expected = "Negative part of Y-Axis";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xZero, yNegative);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        // --- Y zero --------------------------------------------------------------------

        [TestMethod()]
        public void GetQuadrantPositionTest7()
        {

            // Arrange
            double xPositive = 9;
            double yZero = 0;
            string expected = "Positive part of X-Axis";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xPositive, yZero);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest8()
        {

            // Arrange
            double xNegative = -9;
            double yZero = 0;
            string expected = "Negative part of X-Axis";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xNegative, yZero);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }

        [TestMethod()]
        public void GetQuadrantPositionTest9()
        {

            // Arrange
            double xZero = 0;
            double yZero = 0;
            string expected = "Origin";

            //Act
            string actual = QuadrantPosition.GetQuadrantPosition(xZero, yZero);

            //Assert
            Assert.AreEqual(expected, actual, "Error quadrant position");
        }
    }
}