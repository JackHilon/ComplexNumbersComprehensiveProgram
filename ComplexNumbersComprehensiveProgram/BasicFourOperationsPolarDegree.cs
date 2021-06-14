using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class BasicFourOperationsPolarDegree
    {
        public static PolarDegreeNumber Add(PolarDegreeNumber number1, PolarDegreeNumber number2)
        {
            XYFormNumber n1 = ComplexNumberConverts.PolarDegree2XY(number1);
            XYFormNumber n2 = ComplexNumberConverts.PolarDegree2XY(number2);
            XYFormNumber n3 = BasicFourOperationsXY.Add(n1, n2);
            PolarDegreeNumber res = ComplexNumberConverts.XY2PolarDegree(n3);
            return res;
        }

        public static PolarDegreeNumber Mult(PolarDegreeNumber number1, PolarDegreeNumber number2)
        {
            double mag = number1.GetMagnitude() * number2.GetMagnitude();
            double arg = number1.GetArgument() + number2.GetArgument();

            var result = new PolarDegreeNumber(mag, arg);
            return result;
        }

        public static PolarDegreeNumber ScalarMult(double scalar, PolarDegreeNumber number)
        {
            double mag = scalar * number.GetArgument();
            double arg = number.GetArgument();

            var result = new PolarDegreeNumber(mag, arg);
            return result;
        }

        public static PolarDegreeNumber ScalarMult(PolarDegreeNumber number, double scalar)
        {
            return ScalarMult(scalar, number);
        }

        public static PolarDegreeNumber Subtract(PolarDegreeNumber number1, PolarDegreeNumber number2)
        {
            var number3 = ScalarMult(-1, number2);
            var result = Add(number1, number3);
            return result;
        }

        public static PolarDegreeNumber Reciprocal(PolarDegreeNumber number)
        {
            double mag = number.GetMagnitude();
            if (mag == 0)
                mag = double.PositiveInfinity;
            else
            {
                mag = (double)1 / mag;
            }
            double arg = -1 * number.GetArgument();
            var res = new PolarDegreeNumber(mag, arg);
            return res;
        }

        public static PolarDegreeNumber Division(PolarDegreeNumber number1, PolarDegreeNumber number2)
        {
            var number3 = Reciprocal(number2);
            var res = Mult(number1, number3);
            return res;
        }

        public static PolarDegreeNumber ScalarDivision(PolarDegreeNumber number, double scalar)
        {
            // we mean here ((mag|arg)/scalar)

            var mag = (double)number.GetMagnitude() / scalar;
            var arg = number.GetArgument();
            var res = new PolarDegreeNumber(mag, arg);
            return res;
        }
    }
}
