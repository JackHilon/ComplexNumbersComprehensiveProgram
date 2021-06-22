using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class Exponential
    {
        public static PolarRadianNumber ExponentialFunction(PolarRadianNumber number)
        {
            var res = Power.RealNumberComplexPower(Math.E, number);
            return res;
        }

        public static PolarDegreeNumber ExponentialFunction(PolarDegreeNumber number)
        {
            var res = Power.RealNumberComplexPower(Math.E, number);
            return res;
        }

        public static XYFormNumber ExponentialFunction(XYFormNumber number)
        {
            var res = Power.RealNumberComplexPower(Math.E, number);
            return res;
        }
    }
}
