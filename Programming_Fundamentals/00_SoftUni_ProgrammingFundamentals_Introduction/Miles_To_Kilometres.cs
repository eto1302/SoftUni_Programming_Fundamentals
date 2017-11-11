using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine((a * 1.60934).ToString("F2"));
        }
    }
}