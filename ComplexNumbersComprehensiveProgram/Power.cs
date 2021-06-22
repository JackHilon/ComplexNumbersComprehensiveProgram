using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class Power
    {
        public static PolarRadianNumber RealPower(PolarRadianNumber number, double power)
        {
            double mag = number.GetMagnitude();
            double arg = number.GetArgument();
            double magNew = Math.Pow(mag, power);
            double argNew = arg * power;
            var res = new PolarRadianNumber(magNew, argNew);
            return res;
        }

        public static PolarRadianNumber RealNumberComplexPower(double number, PolarRadianNumber pwr)
        {
            double mag = pwr.GetMagnitude();
            double arg = pwr.GetArgument();

            // step(1): Calculate A = (number)^r
            double A = Math.Pow(number, mag);

            // step(2): convert e^(jw) to the form (X + j.Y)
            var pwr1 = new PolarRadianNumber(1, arg);
            var pwr2 = ComplexNumberConverts.PolarRadian2XY(pwr1);
            var x1 = pwr2.GetRealPart();
            var y1 = pwr2.GetImaginaryPart();

            // calculate fac1 = (A)^(x1)
            var fac1 = Math.Pow(A, x1);

            // calculate fac2 = (A)^(j.y1)
            var fac2 = RealNumberPureImaginaryPower(A, y1);

            // calculate result = fac1 * fac2
            //           result = ScalarMult(fac1, fac2);

            var result = BasicFourOperationsPolarRadian.ScalarMult(fac1, fac2);
            return result;
        }

        private static PolarRadianNumber RealNumberPureImaginaryPower(double number, double pwr)
        {
            // calculate (number)^(j.pwr)

            // the conditions discussion

            // the strongest condition
            if (pwr == 0)
            {
                var res5 = new PolarRadianNumber(1, 0);
                return res5;
            }

            // the weakest condition
            if (number < 0) // I must review this condition later
            {
                var res1 = new PolarRadianNumber(double.NaN, double.NaN);
                return res1;
            }
            else if (number == 0)
            {
                if (pwr > 0)
                {
                    var res2 = new PolarRadianNumber(1, double.NegativeInfinity);
                    return res2;
                }
                if (pwr == 0)
                {
                    var res3 = new PolarRadianNumber(1, 0);
                    return res3;
                }
                else // pwr < 0
                {
                    var res4 = new PolarRadianNumber(1, double.PositiveInfinity);
                    return res4;
                }
            }
            else // number > 0
            {

                // first step: calculate Loge(number)
                double fac1 = Math.Log(number);

                // second step: calculate fac2 = Loge(number) * pwr
                double fac2 = fac1 * pwr;

                // third step: result is complex polar-form-radian (1, fac2)
                var res = new PolarRadianNumber(1, fac2);

                return res;
            }
        }

        public static PolarRadianNumber ComplexPower(PolarRadianNumber number, PolarRadianNumber pwr)
        {
            // step(1) calculate fac1= (R_number)^pwr 
            double R_number = number.GetMagnitude();
            var fac1 = RealNumberComplexPower(R_number, pwr);

            // step(2) calculate fac2 = (e)^mult3
            //                   mult3 = mult2 * pwr
            //                   mult2 = (polar-form-radian) mult1
            //                   mult1 = (0 + j.Phi_number)
            double Phi_number = number.GetArgument();
            var mult1 = new XYFormNumber(0, Phi_number);
            var mult2 = ComplexNumberConverts.XY2PolarRadian(mult1);
            var mult3 = BasicFourOperationsPolarRadian.Mult(mult2, pwr);
            double e = Math.E;
            var fac2 = RealNumberComplexPower(e, mult3);

            // step(3) reslut = fac1 * fac2
            var res = BasicFourOperationsPolarRadian.Mult(fac1, fac2);
            return res;
        }

        // ======================================================================================
        // ======================================================================================
        // ====================== XY-Form =======================================================
        // ======================================================================================
        // ======================================================================================
        // ======================================================================================

        public static XYFormNumber RealPower(XYFormNumber number, double power)
        {
            var num = ComplexNumberConverts.XY2PolarRadian(number);
            var res1 = RealPower(num, power);
            var res2 = ComplexNumberConverts.PolarRadian2XY(res1);
            return res2;
        }
        public static XYFormNumber RealNumberComplexPower(double number, XYFormNumber power)
        {
            var pwr = ComplexNumberConverts.XY2PolarRadian(power);
            var res1 = RealNumberComplexPower(number, pwr);
            var res2 = ComplexNumberConverts.PolarRadian2XY(res1);
            return res2;
        }

        public static XYFormNumber ComplexPower(XYFormNumber number, XYFormNumber power)
        {
            var num = ComplexNumberConverts.XY2PolarRadian(number);
            var pwr = ComplexNumberConverts.XY2PolarRadian(power);
            var res1 = ComplexPower(num, pwr);
            var res2 = ComplexNumberConverts.PolarRadian2XY(res1);
            return res2;
        }


        // ######################################################################################
        // ######################################################################################
        // ######################################################################################
        // ######################### Polar-Form-Degree ##########################################
        // ######################################################################################
        // ######################################################################################
        // ######################################################################################

        public static PolarDegreeNumber RealPower(PolarDegreeNumber number, double power)
        {
            var num = ComplexNumberConverts.PolarDegree2PolarRadian(number);
            var res1 = RealPower(num, power);
            var res2 = ComplexNumberConverts.PolarRadian2PolarDegree(res1);
            return res2;
        }
        public static PolarDegreeNumber RealNumberComplexPower(double number, PolarDegreeNumber power)
        {
            var pwr = ComplexNumberConverts.PolarDegree2PolarRadian(power);
            var res1 = RealNumberComplexPower(number, pwr);
            var res2 = ComplexNumberConverts.PolarRadian2PolarDegree(res1);
            return res2;
        }

        public static PolarDegreeNumber ComplexPower(PolarDegreeNumber number, PolarDegreeNumber power)
        {
            var num = ComplexNumberConverts.PolarDegree2PolarRadian(number);
            var pwr = ComplexNumberConverts.PolarDegree2PolarRadian(power);
            var res1 = ComplexPower(num, pwr);
            var res2 = ComplexNumberConverts.PolarRadian2PolarDegree(res1);
            return res2;
        }


    }
}
