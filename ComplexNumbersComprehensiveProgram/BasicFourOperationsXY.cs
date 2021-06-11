using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    class BasicFourOperationsXY
    {
        public static XYFormNumber Add(XYFormNumber number1, XYFormNumber number2)
        {
            double real = number1.GetRealPart() + number2.GetRealPart();
            double image = number1.GetImaginaryPart() + number2.GetImaginaryPart();

            var result = new XYFormNumber(real, image);
            return result;
        }

        public static XYFormNumber Mult(XYFormNumber number1, XYFormNumber number2)
        {
            double real = number1.GetRealPart() * number2.GetRealPart()
                - number1.GetImaginaryPart() * number2.GetImaginaryPart();

            double image = number1.GetRealPart() * number2.GetImaginaryPart()
                + number1.GetImaginaryPart() * number2.GetRealPart();

            var result = new XYFormNumber(real, image);
            return result;
        }

        public static XYFormNumber ScalarMult(double scalar, XYFormNumber number)
        {
            double real = scalar * number.GetRealPart();
            double image = scalar * number.GetImaginaryPart();

            var result = new XYFormNumber(real, image);
            return result;
        }

        public static XYFormNumber ScalarMult(XYFormNumber number, double scalar)
        {
            return ScalarMult(scalar, number);
        }

        public static XYFormNumber Subtract(XYFormNumber number1, XYFormNumber number2)
        {
            var number3 = ScalarMult(-1, number2);
            var result = Add(number1, number3);
            return result;
        }

        public static XYFormNumber Reciprocal(XYFormNumber number)
        {
            var number2 = Conjugate.GetConjugate(number);
            var scalar = PythagoreanTheorem.SquaredHypotenuse(
                number.GetRealPart(), number.GetImaginaryPart());

            var real = DivisionReturn(number2.GetRealPart(), scalar);
            var image = DivisionReturn(number2.GetImaginaryPart(), scalar);

            var res = new XYFormNumber(real, image);
            return res;
        }

        public static XYFormNumber Division(XYFormNumber number1, XYFormNumber number2)
        {
            var number3 = Reciprocal(number2);
            var res = Mult(number1, number3);
            return res;
        }

        public static XYFormNumber ScalarDivision( XYFormNumber number, double scalar)
        {
            // we mean here ((X + j.Y)/scalar)

            var real = DivisionReturn(number.GetRealPart(), scalar);
            var image = DivisionReturn(number.GetImaginaryPart(), scalar);
            var res = new XYFormNumber(real, image);
            return res;
        }



        //--- Private Section -------------------------------------------

        private static double DivisionReturn(double numerator, double denominator)
        {
            if (denominator != 0)
                return (double)numerator / denominator;
            else
            {
                if (numerator > 0)
                    return double.PositiveInfinity;
                else if (numerator < 0)
                    return double.NegativeInfinity;
                else
                    return double.NaN;
            }
        }
    }
}
