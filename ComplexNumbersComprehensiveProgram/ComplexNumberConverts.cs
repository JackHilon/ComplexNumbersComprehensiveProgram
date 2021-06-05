using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class ComplexNumberConverts
    {
        public static PolarRadianNumber XY2PolarRadian(XYFormNumber number)
        {
            double real = number.RealPart;
            double image = number.ImaginaryPart;
            double magnitude = PythagoreanTheorem.GetHypotenuse(real, image);
            double argument = InverseTrigonometricFunctions.ArcTanRadian(real, image);
            PolarRadianNumber polarNumber = new PolarRadianNumber(magnitude,argument);
            return polarNumber;
        }

        public static PolarDegreeNumber XY2PolarDegree(XYFormNumber number)
        {
            double real = number.RealPart;
            double image = number.ImaginaryPart;
            double magnitude = PythagoreanTheorem.GetHypotenuse(real, image);
            double argument = InverseTrigonometricFunctions.ArcTanDegree(real, image);
            PolarDegreeNumber polarNumber = new PolarDegreeNumber(magnitude, argument);
            return polarNumber;
        }

        public static XYFormNumber PolarRadian2XY(PolarRadianNumber number)
        {
            double magnitude = number.Magnitude;
            double argument = number.Argument;
            double real = magnitude * TrigonometricFunctions.CosRadian(argument);
            double image = magnitude * TrigonometricFunctions.SinRadian(argument);
            XYFormNumber result = new XYFormNumber(real,image);
            return result;
        }
        public static XYFormNumber PolarDegree2XY(PolarDegreeNumber number)
        {
            double magnitude = number.Magnitude;
            double argument = number.Argument;
            double real = magnitude * TrigonometricFunctions.CosDegree(argument);
            double image = magnitude * TrigonometricFunctions.SinDegree(argument);
            XYFormNumber result = new XYFormNumber(real, image);
            return result;
        }

        public static PolarRadianNumber PolarDegree2PolarRadian(PolarDegreeNumber number)
        {
            double magnitude = number.Magnitude;
            double argDegree = number.Argument;
            double argRadian = AngleOperations.Deg2Rad(argDegree);
            PolarRadianNumber result = new PolarRadianNumber(magnitude, argRadian);
            return result;
        }

        public static PolarDegreeNumber PolarRadian2PolarDegree(PolarRadianNumber number)
        {
            double magnitude = number.Magnitude;
            double argRadian = number.Argument;
            double argDegree = AngleOperations.Rad2Deg(argRadian);
            PolarDegreeNumber result = new PolarDegreeNumber(magnitude, argDegree);
            return result;
        }
    }
}
