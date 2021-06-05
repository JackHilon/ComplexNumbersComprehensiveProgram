using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class AngleOperations
    {

        // --- (Degree <---> Radian) convertions Part -------------------------------------------
        public static double Rad2Deg(double rad)
        {
            return 360 * rad / (2 * Math.PI);
        }
        public static double Deg2Rad(double deg)
        {
            return (2 * Math.PI) * (double) deg / 360;
        }
        

        // --- Radian part ----------------------------------------------------------------------
        public static double RadianNormalization(double angle)
        {
            double oneCycleRad = 2 * Math.PI;

            if (angle < 0)
            {
                double argNew= (angle + oneCycleRad * (1+GetNumberOfCyclesRad(angle)));
                
                // to prevent negative full cycles
                // (becuase negative full cycles make argNew = 360 always)
                return RadianNormalization(argNew);
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
                double argNew=(argument + 360 * (1+GetNumberOfCyclesDeg(argument)));

                // to prevent negative full cycles
                // (becuase negative full cycles make argNew = 360 always)
                return DegreeNormalization(argNew); 
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
                return (int)Math.Floor(Math.Abs((double)Theta / 360));
            else return 0;
        }

    }
}
