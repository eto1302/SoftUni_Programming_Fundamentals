using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            switch (s)
            {
                case ("Athlete"):
                    Console.WriteLine("Water");
                    break;
                case ("Businessman"):
                    Console.WriteLine("Coffee");
                    break;
                case ("Businesswoman"):
                    Console.WriteLine("Coffee");
                    break;
                case ("SoftUni Student"):
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }

        }
    }
}