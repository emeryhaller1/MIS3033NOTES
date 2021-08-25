using System;

namespace Loops
    //format specifiers example .ToString("P2") or .ToString("C0") etc.
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter your score for Exam {i + 1}.");
                sum += Convert.ToDouble(Console.ReadLine());
                //sum = sum + ...
            }

            double average = sum / 300; //need to divide by 3*100 so that the percentage is correct
            Console.WriteLine($"Your average exam grade is {average.ToString("P2")}.");

        }
    }
}
