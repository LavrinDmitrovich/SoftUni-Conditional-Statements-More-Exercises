using System;

namespace _105_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double totalKg = double.Parse(Console.ReadLine());
            double kg1 = double.Parse(Console.ReadLine());
            double kg2 = double.Parse(Console.ReadLine());
            double gr3 = double.Parse(Console.ReadLine());

            double needFood = (kg1 + kg2 + gr3 / 1000) * days;

            if (totalKg >= needFood)
            {
                Console.WriteLine($"{Math.Floor(totalKg - needFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(needFood - totalKg)} more kilos of food are needed.");
            }
        }
    }
}
