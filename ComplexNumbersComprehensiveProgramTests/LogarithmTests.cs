using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class LogarithmTests
    {
        [TestMethod()]
        public void Log10Test()
        {
            // Arrange
            PolarRadianNumber number = new PolarRadianNumber(10, 3);
            var res1 = new XYFormNumber(1, 3 * Math.Log10(Math.E));
            PolarRadianNumber expected = ComplexNumberConverts.XY2PolarRadian(res1);

            //Act
            PolarRadianNumber actual = Logarithm.Log10(number);

            //Assert
            Assert.AreEqual(expected, actual, "Error complex logarithm base: 10");
        }
    }
}