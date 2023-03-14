using System;

namespace _108_Fuel_Tank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double pay = 0;
            double a = 0;
            double b = 0;
            double coef = 0;

            switch (type)
            {
                case "Gasoline":
                    a = 2.22;
                    b = 0.18;
                    break;

                case "Diesel":
                    a = 2.33;
                    b = 0.12;
                    break;

                case "Gas":
                    a = 0.93;
                    b = 0.08;
                    break;
            }

            if (liters >= 20 && liters <= 25)
            {
                coef = 0.92;
            }
            else if (liters > 25)
            {
                coef = 0.9;
            }
            else
            {
                coef = 1;
            }

            if (card == "Yes")
            {
                pay = (a - b) * liters * coef;
                Console.WriteLine($"{pay:f2} lv.");
            }
            else
            {
                pay = a * liters * coef;
                Console.WriteLine($"{pay:f2} lv.");
            }
        }
    }
}
