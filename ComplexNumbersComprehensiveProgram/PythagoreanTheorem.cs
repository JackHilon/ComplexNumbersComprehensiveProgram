using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    static class PythagoreanTheorem
    {
        public static double SquaredHypotenuse(double perpendicularSide, double baseSide)
        {
            double sqPerpendicular = perpendicularSide * perpendicularSide;
            double sqBase = baseSide * baseSide;
            double sqHypotenuse = sqPerpendicular + sqBase;
            return sqHypotenuse;
        }
        public static double GetHypotenuse(double perpendicularSide, double baseSide)
        {
            double sqHypotenuse = SquaredHypotenuse(perpendicularSide, baseSide);
            double hypotenuse = Math.Sqrt(sqHypotenuse);
            return hypotenuse;
        }
    }
}
