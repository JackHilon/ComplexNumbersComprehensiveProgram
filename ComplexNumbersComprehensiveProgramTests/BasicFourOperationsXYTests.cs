using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class BasicFourOperationsXYTests
    {
        [TestMethod()]
        public void AddTest()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(2, -7);
            XYFormNumber number2 = new XYFormNumber(3, 1);
            XYFormNumber expected = new XYFormNumber(5, -6);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.Add(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual, "Error add operation");
        }

        [TestMethod()]
        public void MultTest()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(2, -7);
            XYFormNumber number2 = new XYFormNumber(3, 1);
            XYFormNumber expected = new XYFormNumber(13, -19);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.Mult(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual, "Error mult operation");
        }

        [TestMethod()]
        public void ScalarMultTest()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(2, -7);
            double scalar = 3;
            XYFormNumber expected = new XYFormNumber(6, -21);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.ScalarMult(number1, scalar);

            //Assert
            Assert.AreEqual(expected, actual, "Error scalar-mult operation");
        }

        [TestMethod()]
        public void ScalarMultTest1()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(-2, -3);
            double scalar = 9;
            XYFormNumber expected = new XYFormNumber(-18, -27);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.ScalarMult(scalar, number1);

            //Assert
            Assert.AreEqual(expected, actual, "Error scalar-mult operation");
        }

        [TestMethod()]
        public void SubtractTest()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(0, -7);
            XYFormNumber number2 = new XYFormNumber(3, 1);
            XYFormNumber expected = new XYFormNumber(-3, -8);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.Subtract(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual, "Error subtract operation");
        }

        [TestMethod()]
        public void ReciprocalTest()
        {
            // Arrange
            XYFormNumber number = new XYFormNumber(3, -4);
            XYFormNumber expected = new XYFormNumber((double)3/25, (double)4/25);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.Reciprocal(number);

            //Assert
            Assert.AreEqual(expected, actual, "Error reciprocal operation");
        }

        [TestMethod()]
        public void DivisionTest()
        {
            // Arrange
            XYFormNumber number1 = new XYFormNumber(1, 1);
            XYFormNumber number2 = new XYFormNumber(1, 1);
            XYFormNumber expected = new XYFormNumber(1, 0);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.Division(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual, "Error add operation");
        }

        [TestMethod()]
        public void ScalarDivisionTest()
        {
            // Arrange
            XYFormNumber number = new XYFormNumber(2, -7);
            double scalar = 0;
            XYFormNumber expected = new XYFormNumber(
                double.PositiveInfinity, double.NegativeInfinity);

            //Act
            XYFormNumber actual = BasicFourOperationsXY.ScalarDivision(number, scalar);

            //Assert
            Assert.AreEqual(expected, actual, "Error add operation");
        }
    }
}