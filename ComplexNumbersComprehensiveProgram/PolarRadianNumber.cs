using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    class PolarRadianNumber
    {
        public double Magnitude;
        public double Argument;

        public PolarRadianNumber(double magnitude, double argument)
        {
            this.Magnitude = magnitude;
            this.Argument = AngleOperations.RadianNormalization(argument);
        }
    }
}
