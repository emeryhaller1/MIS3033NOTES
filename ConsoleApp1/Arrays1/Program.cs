using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            fruits[0] = "Apples";
            fruits[1] = "Oranges";
            fruits[2] = "Bananas";
            fruits[3] = "Grapes";
            fruits[4] = "Blueberries";

            double[] prices = { 0.99, 0.50, 0.50, 2.99, 1.99 };

            Console.WriteLine("What fruit would you like the price for?");
            string fruit = Console.ReadLine().ToLower();

            int fruitIndex = -1; //indexes start at 0 and so we do -1 so that it is never that


            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == fruit)
                {
                    fruitIndex = i;
                    break;
                }
            }

            if (fruitIndex >= 0)
            {
                Console.WriteLine($"The price of {fruit}'s is {prices[fruitIndex].ToString("C")}");
            }
            else
            {
                Console.WriteLine($"We do not carry {fruit} here. Go elsewhere please.");
            }
        }
    }
}

