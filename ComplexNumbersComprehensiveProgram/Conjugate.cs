using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public class Conjugate
    {
        public static XYFormNumber GetConjugate(XYFormNumber number)
        {
            double real = number.GetRealPart();
            double image = -1 * number.GetImaginaryPart();

            var res = new XYFormNumber(real, image);
            return res;
        }

        public static PolarRadianNumber GetConjugate(PolarRadianNumber number)
        {
            double mag = number.GetMagnitude();
            double arg = -1 * number.GetArgument();

            var res = new PolarRadianNumber(mag, arg);
            return res;
        }

        public static PolarDegreeNumber GetConjugate(PolarDegreeNumber number)
        {
            double mag = number.GetMagnitude();
            double arg = -1 * number.GetArgument();

            var res = new PolarDegreeNumber(mag, arg);
            return res;
        }
    }
}
