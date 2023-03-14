using System;

namespace _101_Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Vol = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double water = hours * (pipe1 + pipe2);
            double full = water * 100 / Vol;

            if (water > Vol)
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {(water - Vol):f2} liters.");
            }
            else
            {
                Console.WriteLine($"The pool is {(full):f2}% full. Pipe 1: {(pipe1 * 100 / (pipe1 + pipe2)):f2}%. Pipe 2: {(pipe2 * 100 / (pipe1 + pipe2)):f2}%.");
            }
        }
    }
}
