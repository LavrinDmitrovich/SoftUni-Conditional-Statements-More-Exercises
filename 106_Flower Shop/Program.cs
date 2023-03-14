using System;

namespace _106_Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fl1 = double.Parse(Console.ReadLine());
            double fl2 = double.Parse(Console.ReadLine());
            double fl3 = double.Parse(Console.ReadLine());
            double fl4 = double.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            double money = (3.25 * fl1 + 4 * fl2 + 3.5 * fl3 + 8 * fl4) * 0.95;

            if (money >= present)
            {
                Console.WriteLine($"She is left with {Math.Floor(money - present)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(present - money)} leva.");
            }
        }
    }
}
