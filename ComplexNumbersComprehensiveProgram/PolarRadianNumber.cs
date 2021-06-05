using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public class PolarRadianNumber
    {
        public double Magnitude;
        public double Argument;

        public PolarRadianNumber(double magnitude, double argument)
        {
            this.Magnitude = magnitude;
            this.Argument = AngleOperations.RadianNormalization(argument);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            PolarRadianNumber comparePolar = obj as PolarRadianNumber;
            if (comparePolar != null &&
                this.Magnitude == comparePolar.Magnitude &&
                this.Argument == comparePolar.Argument)
                return true;

            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
