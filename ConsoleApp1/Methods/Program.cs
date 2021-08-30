using System;

namespace Methods

    //do not put a method inside of a method!!!!
    //only use ; in a FOR loop
{
    class Program
    {
        static void Main(string[] args)
        {
            double SpongeBob = LineValueForY(.75, 0, 0);

            Console.WriteLine($"y = (.75)7 + 0 ==> {SpongeBob.ToString("N2")}");

            int val1 = Factorial(5);
            Console.WriteLine($"5! = {val1.ToString("n0")}");

            Console.WriteLine("Please enter a number to calculate the factorial of >>");
            Console.WriteLine($"Thet value is {Factorial(Convert.ToInt32(Console.ReadLine()))}");
        }

        /// <summary>
        /// Calculate the Y value of a line
        /// </summary>
        /// <param name="m">the slope of the line</param>
        /// <param name="x">the x-value of the line</param>
        /// <param name="b">the y-value of the line</param>
        /// <returns></returns>

        static double LineValueForY(double m, double x, double b)
        {
            double y = 0;

            y = m*x + b;

            return y;
        }

        /// <summary>
        /// Calculates the factorial of a value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>



        static int Factorial (int number)
        {
            int value = 1;

            for (int i = number; i > 0; i--) //-- means decrement not increment ++
            {
                value *= i;
            }
            return value;
        }

    }
}
