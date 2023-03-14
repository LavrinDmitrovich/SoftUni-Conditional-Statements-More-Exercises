using System;

namespace _102_Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vacdays = int.Parse(Console.ReadLine());
            int playhours = (365 - vacdays) * 63 + vacdays * 127;

            if (playhours > 30000)
            {
                int hour = (playhours - 30000) / 60;
                int minutes = (playhours - 30000) % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour} hours and {minutes} minutes more for play");
            }
            else
            {
                int hour = (30000 - playhours) / 60;
                int minutes = (30000 - playhours) % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {minutes} minutes less for play");
            }
        }
    }
}
