using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexNumbersComprehensiveProgram
{
    public class XYFormNumber
    {
        public double RealPart;
        public double ImaginaryPart;

        public XYFormNumber(double realPart, double imaginaryPart)
        {
            this.RealPart = realPart;
            this.ImaginaryPart = imaginaryPart;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            XYFormNumber compareXY = obj as XYFormNumber;
            if (compareXY != null &&
                this.RealPart == compareXY.RealPart &&
                this.ImaginaryPart == compareXY.ImaginaryPart)
                return true;

            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
