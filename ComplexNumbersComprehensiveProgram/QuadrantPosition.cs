using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public static class QuadrantPosition
    {
        public static string GetQuadrantPosition(double xScale, double yScale)
        {
            if (xScale > 0)
            {
                if (yScale > 0)
                    return "First quadrant";
                else if (yScale == 0)
                    return "Positive part of X-Axis";
                else //if (yScale < 0)
                    return "Fourth quadrant";
            }
            else if (xScale < 0)
            {

                if (yScale > 0)
                    return "Second quadrant";
                else if (yScale == 0)
                    return "Negative part of X-Axis";
                else //if (yScale < 0)
                    return "Third quadrant";
            }
            else
            {
                if (yScale > 0)
                    return "Positive part of Y-Axis";
                else if (yScale == 0)
                    return "Origin";
                else //if (yScale < 0)
                    return "Negative part of Y-Axis";
            }
        }

    }
}
