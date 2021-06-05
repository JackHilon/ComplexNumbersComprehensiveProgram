using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexNumbersComprehensiveProgram;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram.Tests
{

    [TestClass()]
    public class AngleOperationsTests
    {
        public static double qaurter = (double)Math.PI / 2;
        public static double halfCycle = Math.PI;
        public static double threeQaurter = (double)Math.PI * 1.5;
        public static double fullCycle = 2 * Math.PI;

        [TestMethod()]
        public void RadianNormalizationTest1()
        {
            // Arrange
            double angle = 0;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest2()
        {
            // Arrange
            double angle = qaurter;
            double expected = qaurter;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest3()
        {
            // Arrange
            double angle = halfCycle;
            double expected = halfCycle;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest4()
        {
            // Arrange
            double angle = threeQaurter;
            double expected = threeQaurter;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest5()
        {
            // Arrange
            double angle = 5 * fullCycle;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest6()
        {
            // Arrange
            double angle = 8 * fullCycle;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest7()
        {
            // Arrange
            double angle = -1 * fullCycle;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest8()
        {
            // Arrange
            double angle = -1 * qaurter;
            double expected = threeQaurter;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest9()
        {
            // Arrange
            double angle = -1 * halfCycle;
            double expected = halfCycle;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest10()
        {
            // Arrange
            double angle = -1 * (1.5*Math.PI) - 5 * 2*Math.PI;
            double expected = Math.PI/2;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest11()
        {
            // Arrange
            double angle = -5 * fullCycle;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }

        [TestMethod()]
        public void RadianNormalizationTest12()
        {
            // Arrange
            double angle = -8 * fullCycle;
            double expected = 0;

            //Act
            double actual = AngleOperations.RadianNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-radian normalization");
        }







        //===========================================================================
        //================== Degree Normalization Test ==============================
        //===========================================================================

        [TestMethod()]
        public void DegreeNormalizationTest1()
        {
            // Arrange
            double angle = 360;
            double expected = 0;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest2()
        {
            // Arrange
            double angle = 365;
            double expected = 5;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest3()
        {
            // Arrange
            double angle = 455;
            double expected = 95;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest4()
        {
            // Arrange
            double angle = 545;
            double expected = 185;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest5()
        {
            // Arrange
            double angle = 1005;
            double expected = 285;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest6()
        {
            // Arrange
            double angle = 1830;
            double expected = 30;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }
        [TestMethod()]
        public void DegreeNormalizationTest7()
        {
            // Arrange
            double angle = 360;
            double expected = 0;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest8()
        {
            // Arrange
            double angle = -25;
            double expected = 360 - 25;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest9()
        {
            // Arrange
            double angle = -95;
            double expected = 270 - 5;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }
        [TestMethod()]
        public void DegreeNormalizationTest10()
        {
            // Arrange
            double angle = -195;
            double expected = 180 - 15;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest11()
        {
            // Arrange
            double angle = -300;
            double expected = 60;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest12()
        {
            // Arrange
            double angle = -90 - 7 * 360;
            double expected = 270;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest13()
        {
            // Arrange
            double angle = -180;
            double expected = 180;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest14()
        {
            // Arrange
            double angle = -360 * 3;
            double expected = 0;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest15()
        {
            // Arrange
            double angle = -360;
            double expected = 0;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest16()
        {
            // Arrange
            double angle = 17 * 360;
            double expected = 0;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest17()
        {
            // Arrange
            double angle = 17 * 360 + 90;
            double expected = 90;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest18()
        {
            // Arrange
            double angle = 17 * 360 + 180;
            double expected = 180;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest19()
        {
            // Arrange
            double angle = 17 * 360 + 30;
            double expected = 30;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest20()
        {
            // Arrange
            double angle = 17 * 360 + 90;
            double expected = 90;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        [TestMethod()]
        public void DegreeNormalizationTest21()
        {
            // Arrange
            double angle = -17 * 360 + 6;
            double expected = 6;

            //Act
            double actual = AngleOperations.DegreeNormalization(angle);

            //Assert
            Assert.AreEqual(expected, actual, "Error angle-degree normalization");
        }

        
    }
}