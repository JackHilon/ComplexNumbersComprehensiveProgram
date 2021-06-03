using System;

namespace ComplexNumbersComprehensiveProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Arrange
            double[] xArray = new double[9] { 3, 4, 6, -7, -11, -28, 0, 0, 0 };
            double[] yArray = new double[9] { 1, -4, 0, 9, -2, 0, 13, -21, 0 };
            string[] expected = new string[9] {"First quadrant","Fourth quadrant","Positive part of X-Axis",
                "Second quadrant","Third quadrant","Negative part of X-Axis","Positive part of Y-Axis",
            "Negative part of Y-Axis","Origin" };

            //Act


            string[] actual = new string[xArray.Length];

            for (int i = 0; i < xArray.Length; i++)
            {
                actual[i] = QuadrantPosition.GetQuadrantPosition(xArray[i], yArray[i]);
            }

            //Assert
            for (int i = 0; i < actual.Length; i++)

            {
                if (actual[i]!=expected[i])
                {
                    Console.WriteLine("dsdfsdf");
                }
                
                    
            }
        }
    }
}

