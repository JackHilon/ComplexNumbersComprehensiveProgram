using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public class PolarRadianNumber
    {
        private double Magnitude;
        private double Argument;

        public double GetMagnitude()
        {
            return this.Magnitude;
        }

        public double GetArgument()
        {
            return this.Argument;
        }

        public PolarRadianNumber(double magnitude, double argument)
        {
            this.Magnitude = Math.Abs(magnitude);
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
