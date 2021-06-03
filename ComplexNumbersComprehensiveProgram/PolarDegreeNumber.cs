using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    class PolarDegreeNumber
    {
        public double Magnitude;
        public double Argument;

        public PolarDegreeNumber(double magnitude, double argument)
        {
            this.Magnitude = magnitude;
            this.Argument = AngleOperations.DegreeNormalization(argument);
        }
    }
}
