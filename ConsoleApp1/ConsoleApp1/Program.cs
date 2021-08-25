using System;

namespace ConsoleApp1
{
    //Conditionals Review
    class Program
    {

        const double COG_COST = 79.99;
        const double GEAR_COST = 250.00;
        const double SALES_TAX = 0.089;
        const double STANDARD_MARKUP_PERCENTAGE = 0.15;
        const double DISCOUNTED_MARKUP_PERCENTAGE = 0.125;

        static void Main(string[] args)
        {

            Console.WriteLine($"Please enter the # of gears? >> ");
            string answer = Console.ReadLine();

            int cogs;
            int gears;

            if (int.TryParse(answer,out gears) == false)
            {
                Console.WriteLine("Invalide entry for # of gears. Goodbye.");
                Environment.Exit(-5); 
            }

            Console.WriteLine($"Please enter the # of cogs? >> ");
             answer = Console.ReadLine();

            if (int.TryParse(answer, out cogs) == false)
            {
                Console.WriteLine("Invalide entry for # of cogs. Goodbye.");
                Environment.Exit(-5);
            }

            double markup;

            if (cogs >= 10)
            {
                markup = DISCOUNTED_MARKUP_PERCENTAGE;
            }
            else if (gears >= 10)
            {
                markup = DISCOUNTED_MARKUP_PERCENTAGE;
            }
            else
            {
                if ((gears + cogs)>= 16)
                {
                    markup = DISCOUNTED_MARKUP_PERCENTAGE;
                }
                else
                {
                    markup = STANDARD_MARKUP_PERCENTAGE;
                }
            }

            double cogCostAtStandard = COG_COST * (1+ STANDARD_MARKUP_PERCENTAGE);
            double cogCostAtMarkup = COG_COST * (1 + markup);

            double gearCostAtStandard = GEAR_COST * (1 + STANDARD_MARKUP_PERCENTAGE);
            double gearCostAtMarkup =GEAR_COST * (1 + markup);

            double cogTOTAL = cogCostAtMarkup * cogs;
            double gearTOTAL = gearCostAtMarkup * gears;

            double CogSaving = (cogCostAtStandard * cogs) - cogTOTAL;
            double gearSaving = (gearCostAtStandard * gears) - gearTOTAL;
            double savings = CogSaving + gearSaving;

            double salesTax = (cogTOTAL + gearTOTAL) * SALES_TAX;

            Console.WriteLine($"Cogs @ {cogCostAtMarkup.ToString("C")}X {cogs} = {cogTOTAL.ToString("C")}");
            Console.WriteLine($"Gears @ {gearCostAtMarkup.ToString("C")}X {gears} = {gearTOTAL.ToString("C")}");
            Console.WriteLine($"Total: {(cogTOTAL + gearTOTAL).ToString("C")}");
            Console.WriteLine($"Total: {(cogTOTAL + gearTOTAL).ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Savings: {savings.ToString("C")}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Sales Tax: {salesTax.ToString("C")}");

            
        }
    }
}
