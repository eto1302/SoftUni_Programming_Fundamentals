using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var n = double.Parse(Console.ReadLine());
            switch (s)
            {
                case ("Athlete"):
                    Console.WriteLine("The Athlete has to pay {0}.", (n * 0.70).ToString("F2"));
                    break;
                case ("Businessman"):
                    Console.WriteLine("The Businessman has to pay {0}.", (n * 1.00).ToString("F2"));
                    break;
                case ("Businesswoman"):
                    Console.WriteLine("The Businesswoman has to pay {0}.", (n * 1.00).ToString("F2"));
                    break;
                case ("SoftUni Student"):
                    Console.WriteLine("The SoftUni Student has to pay {0}.", (n * 1.70).ToString("F2"));
                    break;
                default:
                    Console.WriteLine("The {0} has to pay {1}.", s, (n * 1.20).ToString("F2"));
                    break;
            }

        }
    }
}