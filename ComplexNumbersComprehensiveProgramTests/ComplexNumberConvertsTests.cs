using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{
    [TestClass()]
    public class ComplexNumberConvertsTests
    {
        [TestMethod()]
        public void XY2PolarRadianTest()
        {

            // Arrange
            XYFormNumber xyNumber = new XYFormNumber(1, 1);
            double magnitude = (Math.Sqrt(2));
            double argRad = (double)(Math.PI) / 4;
            PolarRadianNumber expected = new PolarRadianNumber(magnitude, argRad);

            //Act
            PolarRadianNumber actual = ComplexNumberConverts.XY2PolarRadian(xyNumber);

            //Assert
            Assert.AreEqual(expected, actual, "Error XY-form to Polar-radian-form convertion");
        }
        
        [TestMethod()]
        public void XY2PolarDegreeTest()
        {
            // Arrange
            XYFormNumber xyNumber = new XYFormNumber(1, -1);
            double magnitude = (Math.Sqrt(2));
            double argDegree = 315;
            PolarDegreeNumber expected = new PolarDegreeNumber(magnitude, argDegree);

            //Act
            PolarDegreeNumber actual = ComplexNumberConverts.XY2PolarDegree(xyNumber);

            //Assert
            Assert.AreEqual(expected, actual, "Error XY-form to Polar-degree-form convertion");
        }

        [TestMethod()]
        public void PolarRadian2XYTest()
        {
            // Arrange
            double mag = 1;
            double arg = (double)(Math.PI) / 2;
            PolarRadianNumber polar = new PolarRadianNumber(mag,arg);
            double real = 0;
            double image=1;
            XYFormNumber expected = new XYFormNumber(real, image);

            //Act
            XYFormNumber actual = ComplexNumberConverts.PolarRadian2XY(polar);

            //Assert
            Assert.AreEqual(expected, actual, "Error Polar-radian-form to XY-form convertion");
        }

        [TestMethod()]
        public void PolarDegree2XYTest()
        {
            // Arrange
            double mag = 1;
            double arg = 180;
            PolarDegreeNumber polar = new PolarDegreeNumber(mag, arg);
            double real = -1;
            double image = 0;
            XYFormNumber expected = new XYFormNumber(real, image);

            //Act
            XYFormNumber actual = ComplexNumberConverts.PolarDegree2XY(polar);

            //Assert
            Assert.AreEqual(expected, actual, "Error Polar-degree-form to XY-form convertion");
        }

        
        [TestMethod()]
        public void PolarDegree2PolarRadianTest()
        {
            // Arrange
            double mag = 3;
            double argDeg = -60;
            PolarDegreeNumber polarDegree = new PolarDegreeNumber(mag, argDeg);
            double argRad = -((double) 1/3)*Math.PI;
            PolarRadianNumber expected = new PolarRadianNumber(mag, argRad);

            //Act
            PolarRadianNumber actual = ComplexNumberConverts.PolarDegree2PolarRadian(polarDegree);

            //Assert
            Assert.AreEqual(expected, actual, "Error Polar-degree-form to Polar-radian-form convertion");
        }
        
        [TestMethod()]
        public void PolarRadian2PolarDegreeTest()
        {
            // Arrange
            double mag = 3;
            double argRad = 4*(Math.PI)/3;
            PolarRadianNumber polarRad = new PolarRadianNumber(mag, argRad);
            //double argDegree =240;
            double argDegree = AngleOperations.Rad2Deg(argRad);
            PolarDegreeNumber expected = new PolarDegreeNumber(mag, argDegree);

            //Act
            PolarDegreeNumber actual = ComplexNumberConverts.PolarRadian2PolarDegree(polarRad);

            //Assert
            Assert.AreEqual(expected, actual, "Error Polar-radian-form to Polar-degree-form conversion");
        }

        [TestMethod()]
        public void PolarDegree2PolarRadianTest2()
        {
            // Arrange
            double mag = 3;
            double argDeg = 240;
            PolarDegreeNumber polarDegree = new PolarDegreeNumber(mag, argDeg);
            double argRad = 4 * (Math.PI) / 3;
            PolarRadianNumber expected = new PolarRadianNumber(mag, argRad);

            //Act
            PolarRadianNumber actual = ComplexNumberConverts.PolarDegree2PolarRadian(polarDegree);

            //Assert
            Assert.AreEqual(expected, actual, "Error Polar-degree-form to Polar-radian-form convertion");
        }


    }
}