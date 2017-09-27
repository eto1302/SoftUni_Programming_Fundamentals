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
            double k = d * b / 100;
            double l = c * b / 100;
            Console.WriteLine("{0}ml {1}:", b, a);
            Console.WriteLine("{0}kcal, {1}g sugars", l, k);
        }
    }
}