using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class PowerTests
    {
        [TestMethod()]
        public void RealPowerTest1()
        {
            // Arrange
            XYFormNumber num = new XYFormNumber(0, 0);
            double p = 0;
            XYFormNumber expected = new XYFormNumber(1, 0);

            //Act
            XYFormNumber actual = Power.RealPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error real power (XY-Form)");
        }

        [TestMethod()]
        public void RealPowerTest2()
        {
            // Arrange
            XYFormNumber num = new XYFormNumber(3, 7);
            double p = 0;
            XYFormNumber expected = new XYFormNumber(1, 0);

            //Act
            XYFormNumber actual = Power.RealPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error real power (XY-Form)");
        }

        [TestMethod()]
        public void RealPowerTest3()
        {
            // Arrange
            XYFormNumber num = new XYFormNumber(0, 0);
            double p = 9;
            XYFormNumber expected = new XYFormNumber(0, 0);

            //Act
            XYFormNumber actual = Power.RealPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error real power (XY-Form)");
        }

        [TestMethod()]
        public void RealNumberComplexPowerTest1()
        {
            // Arrange
            XYFormNumber p = new XYFormNumber(0, 0);
            double num = 0;
            XYFormNumber expected = new XYFormNumber(1, 0);

            //Act
            XYFormNumber actual = Power.RealNumberComplexPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error Real Number Complex Power (XY-Form)");
        }

        [TestMethod()]
        public void RealNumberComplexPowerTest2()
        {
            // Arrange
            XYFormNumber p = new XYFormNumber(0, 0);
            double num = 5;
            XYFormNumber expected = new XYFormNumber(1, 0);

            //Act
            XYFormNumber actual = Power.RealNumberComplexPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error Real Number Complex Power (XY-Form)");
        }

        [TestMethod()]
        public void RealNumberComplexPowerTest3()
        {
            // Arrange
            XYFormNumber p = new XYFormNumber(8, 9);
            double num = 0;
            XYFormNumber expected = new XYFormNumber(0, 0);

            //Act
            XYFormNumber actual = Power.RealNumberComplexPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Error Real Number Complex Power (XY-Form)");
        }

        [TestMethod()]
        public void ComplexPowerTest()
        {

            // Arrange
            XYFormNumber p = new XYFormNumber(8, 9);
            var num = new XYFormNumber(0, 0);
            XYFormNumber expected = new XYFormNumber(0, 0);

            //Act
            XYFormNumber actual = Power.ComplexPower(num, p);

            //Assert
            Assert.AreEqual(expected, actual, "Complex Power (XY-Form)");
        }
    }
}