using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
     public static class Logarithm
    {
        public static XYFormNumber Loge(XYFormNumber number)
        {
            var res1 = ComplexNumberConverts.XY2PolarRadian(number);
            var res2 = LogeFirstStep(res1);
            return res2;
        }

        public static PolarDegreeNumber Loge(PolarDegreeNumber number)
        {
            var res1 = ComplexNumberConverts.PolarDegree2PolarRadian(number);
            var res2 = LogeFirstStep(res1);
            var result = ComplexNumberConverts.XY2PolarDegree(res2);
            return result;
        }

        public static PolarRadianNumber Loge(PolarRadianNumber number)
        {
            var res = LogeFirstStep(number);
            var result = ComplexNumberConverts.XY2PolarRadian(res);
            return result;
        }

        public static XYFormNumber LogBaseDouble(XYFormNumber number, double logBase)
        {
            var res1 = Loge(number);
            var res2=RealLogBase(Math.E, logBase);
            var res3 = BasicFourOperationsXY.ScalarMult(res1, res2);
            return res3;
        }

        public static PolarDegreeNumber LogBaseDouble(PolarDegreeNumber number, double logBase)
        {
            var res1 = Loge(number);
            var res2 = RealLogBase(Math.E, logBase);
            var res3 = BasicFourOperationsPolarDegree.ScalarMult(res1, res2);
            return res3;
        }

        public static PolarRadianNumber LogBaseDouble(PolarRadianNumber number, double logBase)
        {
            var res1 = Loge(number);
            var res2 = RealLogBase(Math.E, logBase);
            var res3 = BasicFourOperationsPolarRadian.ScalarMult(res1, res2);
            return res3;
        }

        public static XYFormNumber Log10(XYFormNumber number)
        {
            return LogBaseDouble(number, 10);
        }

        public static PolarDegreeNumber Log10(PolarDegreeNumber number)
        {
            return LogBaseDouble(number, 10);
        }
        public static PolarRadianNumber Log10(PolarRadianNumber number)
        {
            return LogBaseDouble(number, 10);
        }

        // === Private Part ===============================================
        private static XYFormNumber LogeFirstStep(PolarRadianNumber number)
        {
            var mag = number.GetMagnitude();
            mag = Math.Abs(mag);
            double real = 0;
            double image = 0;
            if (mag == 0)
            {
                real = double.NegativeInfinity;
                image = double.NaN;
            }
            else
            {
                real = Math.Log(mag);
                image = number.GetArgument();
            }
            var res = new XYFormNumber(real, image);
            return res;
        }
        private static double RealLogBase(double number, double logBase)
        {
            double res = Math.Log(number, logBase);
            return res;
                // ####################################################
                //One of the values in the following table. (+Infinity denotes System.Double.PositiveInfinity, -Infinity denotes System.Double.NegativeInfinity, and NaN denotes System.Double.NaN.)
                //anewBase Return value a> 0(0 < newBase < 1) - or - (newBase > 1) lognewBase(a)

                //a < 0(any value) NaN
                //(any value) newBase < 0 NaN
                //a != 1 newBase = 0 NaN
                //a != 1 newBase = +Infinity NaN
                //a = NaN(any value) NaN
                //(any value) newBase = NaN NaN
                //(any value) newBase = 1 NaN
                //a = 0 0 < newBase < 1 + Infinity
                //a = 0 newBase > 1 - Infinity
                //a = +Infinity 0 < newBase < 1 - Infinity
                //a = +Infinity newBase > 1 + Infinity
                //a = 1 newBase = 0 0
                //a = 1 newBase = +Infinity 0
                // ###################################################
        }
    }
}
