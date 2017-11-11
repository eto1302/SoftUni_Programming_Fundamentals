using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            var d = double.Parse(Console.ReadLine());
            var e = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", a);
            Console.Write("Health: ");
            for (int i = 0; i < b + 1; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < c - b; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
            Console.WriteLine();
            Console.Write("Energy: ");
            for (int i = 0; i < d + 1; i++)
            {
                Console.Write("|");
            }
            for (int i = 0; i < e - d; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");

        }
    }
}