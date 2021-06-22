using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class BasicFourOperationsPolarRadian
    {
        public static PolarRadianNumber Add(PolarRadianNumber number1, PolarRadianNumber number2)
        {
            XYFormNumber n1 = ComplexNumberConverts.PolarRadian2XY(number1);
            XYFormNumber n2 = ComplexNumberConverts.PolarRadian2XY(number2);
            XYFormNumber n3 = BasicFourOperationsXY.Add(n1, n2);
            PolarRadianNumber res = ComplexNumberConverts.XY2PolarRadian(n3);
            return res;
        }

        public static PolarRadianNumber Mult(PolarRadianNumber number1, PolarRadianNumber number2)
        {
            double mag = number1.GetMagnitude() * number2.GetMagnitude();
            double arg = number1.GetArgument() + number2.GetArgument();

            var result = new PolarRadianNumber(mag, arg);
            return result;
        }

        public static PolarRadianNumber ScalarMult(double scalar, PolarRadianNumber number)
        {
            double mag = scalar * number.GetMagnitude();
            double arg = number.GetArgument();

            var result = new PolarRadianNumber(mag, arg);
            return result;
        }

        public static PolarRadianNumber ScalarMult(PolarRadianNumber number, double scalar)
        {
            return ScalarMult(scalar, number);
        }

        public static PolarRadianNumber Subtract(PolarRadianNumber number1, PolarRadianNumber number2)
        {
            var number3 = ScalarMult(-1, number2);
            var result = Add(number1, number3);
            return result;
        }

        public static PolarRadianNumber Reciprocal(PolarRadianNumber number)
        {
            double mag = number.GetMagnitude();
            if (mag == 0)
                mag = double.PositiveInfinity;
            else
            {
                mag = (double)1 / mag;
            }
            double arg = -1 * number.GetArgument();
            var res = new PolarRadianNumber(mag, arg);
            return res;
        }

        public static PolarRadianNumber Division(PolarRadianNumber number1, PolarRadianNumber number2)
        {
            var number3 = Reciprocal(number2);
            var res = Mult(number1, number3);
            return res;
        }

        public static PolarRadianNumber ScalarDivision(PolarRadianNumber number, double scalar)
        {
            // we mean here ((mag|arg)/scalar)

            var mag = (double)number.GetMagnitude() / scalar;
            var arg = number.GetArgument();
            var res = new PolarRadianNumber(mag, arg);
            return res;
        }
    }
}
