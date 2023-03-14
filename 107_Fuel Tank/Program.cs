using System;

namespace _107_Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double liter = double.Parse(Console.ReadLine());
            string type;
            bool correct = true;

            if (liter >= 25)
            {
                switch (s)
                {
                    case "Diesel":
                        type = "diesel";
                        break;
                    case "Gasoline":
                        type = "gasoline";
                        break;
                    case "Gas":
                        type = "gas";
                        break;
                    default:
                        type = "Invalid fuel!";
                        correct = false;
                        Console.WriteLine(type);
                        break;

                }
                if (correct) Console.WriteLine("You have enough " + type + ".");
            }

            else
            {
                switch (s)
                {
                    case "Diesel":
                        type = "diesel";
                        break;
                    case "Gasoline":
                        type = "gasoline";
                        break;
                    case "Gas":
                        type = "gas";
                        break;
                    default:
                        type = "Invalid fuel!";
                        correct = false;
                        Console.WriteLine(type);
                        break;

                }
                if (correct) Console.WriteLine("Fill your tank with " + type + "!");
            }
        }
    }
}
