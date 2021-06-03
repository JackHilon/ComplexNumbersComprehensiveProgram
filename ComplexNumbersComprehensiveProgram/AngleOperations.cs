using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    static class AngleOperations
    {

        // --- (Degree <---> Radian) convertions Part -------------------------------------------
        public static double Rad2Deg(double rad)
        {
            return 360 * rad / (2 * Math.PI);
        }
        public static double Deg2Rad(double deg)
        {
            return (2 * Math.PI) * deg / 360;
        }
        

        // --- Radian part ----------------------------------------------------------------------
        public static double RadianNormalization(double angle)
        {
            double oneCycleRad = 2 * Math.PI;

            if (angle < 0)
            {
                return (angle + 1 + oneCycleRad * (GetNumberOfCyclesRad(angle)));
            }

            else if (angle >= oneCycleRad)
            {
                return (angle - oneCycleRad * (GetNumberOfCyclesRad(angle)));
            }

            else return angle;
        }

        private static int GetNumberOfCyclesRad(double Theta)
        {
            double oneCycleRad = 2 * Math.PI;

            if (Math.Abs(Theta) >= oneCycleRad)
                return (int)Math.Floor(Theta / oneCycleRad);

            else return 0;
        }

        // --- Degree Part ------------------------------------------------------------------
        public static double DegreeNormalization(double argument)
        {
            if (argument < 0)
            {
                return (argument + 1 + 360 * (GetNumberOfCyclesDeg(argument)));
            }

            else if (argument >= 360)
            {
                return (argument - 360 * (GetNumberOfCyclesDeg(argument)));
            }

            else return argument;
        }

        private static int GetNumberOfCyclesDeg(double Theta)
        {
            if (Math.Abs(Theta) >= 360)
                return (int)Math.Floor(Theta / 360);
            else return 0;
        }

    }
}
