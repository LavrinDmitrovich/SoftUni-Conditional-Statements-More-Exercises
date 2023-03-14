using System;

namespace _104_Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            string when = Console.ReadLine();
            double price = 0;

            switch (when)
            {
                case "day":
                    {
                        if (km < 20)
                        {
                            price = 0.7 + 0.79 * km;
                        }
                        else if (km >= 20 && km < 100)
                        {
                            price = 0.09 * km;
                        }
                        else
                        {
                            price = 0.06 * km;
                        }
                        break;
                    }
                case "night":
                    {
                        if (km < 20)
                        {
                            price = 0.7 + 0.9 * km;
                        }
                        else if (km >= 20 && km < 100)
                        {
                            price = 0.09 * km;
                        }
                        else
                        {
                            price = 0.06 * km;
                        }
                        break;
                    }
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
