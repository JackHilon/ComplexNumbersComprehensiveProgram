using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class BasicFourOperationsPolarRadianTests
    {
        [TestMethod()]
        public void ScalarMultTest()
        {
            // Arrange
            PolarRadianNumber number = new PolarRadianNumber(10, 3);
            var myScalar = 10;
            PolarRadianNumber expected = new PolarRadianNumber(100,3);

            //Act
            PolarRadianNumber actual = BasicFourOperationsPolarRadian.ScalarMult(number,myScalar);

            //Assert
            Assert.AreEqual(expected, actual, "Error polar-form-radian mult-scalar error");
        }
    }
}