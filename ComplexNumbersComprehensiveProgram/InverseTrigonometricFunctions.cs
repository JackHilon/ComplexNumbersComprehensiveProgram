using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class InverseTrigonometricFunctions
    {
        public static double ArcTanRadian(double xScale, double yScale)
        {
            double angleRadian;

            double xScaleABS = Math.Abs(xScale);
            double yScaleABS = Math.Abs(yScale);
            double angleRadianABS = Math.Atan2(yScaleABS, xScaleABS);

            switch (QuadrantPosition.GetQuadrantPosition(xScale, yScale))
            {
                case "First quadrant":
                    angleRadian = angleRadianABS;
                    break;
                case "Second quadrant":
                    angleRadian = angleRadianABS + ((Math.PI) / 2);
                    break;
                case "Third quadrant":
                    angleRadian = angleRadianABS + Math.PI;
                    break;
                case "Fourth quadrant":
                    angleRadian = angleRadianABS + (Math.PI) * (1.5);
                    break;
                case "Positive part of X-Axis":
                    angleRadian = 0;
                    break;
                case "Negative part of X-Axis":
                    angleRadian = Math.PI;
                    break;
                case "Positive part of Y-Axis":
                    angleRadian = (Math.PI) / 2;
                    break;
                case "Negative part of Y-Axis":
                    angleRadian = (Math.PI) * 3 / 2;
                    break;
                default: // "Origin"
                    angleRadian = 0;
                    break;
            }
            return angleRadian;
        }

        public static double ArcTanDegree(double xScale, double yScale)
        {
            double angleRadian = InverseTrigonometricFunctions.ArcTanRadian(xScale, yScale);
            double angleDegree = AngleOperations.Rad2Deg(angleRadian);
            return angleDegree;
        }
    }
}
