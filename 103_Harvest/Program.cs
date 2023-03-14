using System;

namespace _103_Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double e = a * b * 0.4 / 2.5;

            if (e >= c)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(e)} liters.");
                Console.WriteLine($"{Math.Ceiling(e - c)} liters left -> {Math.Ceiling((e - c) / d)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(c - e)} liters wine needed.");
            }
        }
    }
}
