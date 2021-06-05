using System;

namespace ComplexNumbersComprehensiveProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrange
            double mag = 3;
            double argRad = Math.PI + (Math.PI / 3);
            PolarRadianNumber polarRad = new PolarRadianNumber(mag, argRad);
            double argDegree = 240;
            PolarDegreeNumber expected = new PolarDegreeNumber(mag, argDegree);

            //Act
            PolarDegreeNumber actual = ComplexNumberConverts.PolarRadian2PolarDegree(polarRad);
            Console.WriteLine(actual.Magnitude);
            Console.WriteLine(actual.Argument);
            Console.WriteLine(expected.Magnitude);
            Console.WriteLine(expected.Argument);



            Console.WriteLine("Hello");
        }
    }
}

