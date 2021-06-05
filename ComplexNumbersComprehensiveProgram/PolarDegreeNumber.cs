using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public class PolarDegreeNumber
    {
        public double Magnitude;
        public double Argument;

        public PolarDegreeNumber(double magnitude, double argument)
        {
            this.Magnitude = magnitude;
            this.Argument = AngleOperations.DegreeNormalization(argument);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            PolarDegreeNumber comparePolar = obj as PolarDegreeNumber;
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
