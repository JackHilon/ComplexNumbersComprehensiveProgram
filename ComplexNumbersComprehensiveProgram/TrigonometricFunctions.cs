using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class TrigonometricFunctions
    {
        public static double CosRadian(double radian)
        {
            double deg0 = 0;
            double deg90 = Math.PI / 2;
            double deg180 = Math.PI;
            double deg270 = (1.5) * Math.PI;
            double deg360 = 2 * Math.PI;
            if (radian == deg90 || radian == deg270)
                return 0;
            if (radian == deg180)
                return -1;
            if (radian == deg360 || radian==deg0)
                return 1;

            double result = Math.Cos(radian);
            return result;
        }
        public static double SinRadian(double radian)
        {
            double deg0 = 0;
            double deg90 = Math.PI / 2;
            double deg180 = Math.PI;
            double deg270 = (1.5) * Math.PI;
            double deg360 = 2 * Math.PI;
            if (radian == deg90)
                return 1;
            if (radian == deg270)
                return -1;
            if (radian == deg180 || radian == deg0 || radian == deg0)
                return 0;


            double result = Math.Sin(radian);
            return result;
        }

        public static double CosDegree(double degree)
        {
            double radian = AngleOperations.Deg2Rad(degree);
            double result= CosRadian(radian);
            return result;
        }
        public static double SinDegree(double degree)
        {
            double radian = AngleOperations.Deg2Rad(degree);
            double result = SinRadian(radian);
            return result;
        }
    }
}
