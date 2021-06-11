using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class ConjugateTests
    {
        [TestMethod()]
        public void GetConjugateTest()
        {
            // Arrange
            PolarDegreeNumber number = new PolarDegreeNumber(2, 30);
            PolarDegreeNumber expected = new PolarDegreeNumber(2, 360-30);

            //Act
            PolarDegreeNumber actual = Conjugate.GetConjugate(number);

            //Assert
            Assert.AreEqual(expected, actual, "Error complex conjugate");
        }
    }
}