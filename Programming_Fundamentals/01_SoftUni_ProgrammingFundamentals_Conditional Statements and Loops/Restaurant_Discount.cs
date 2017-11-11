using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            if (n <= 50)
            {
                if (s == "Normal") { Console.WriteLine("We can offer you the Small Hall"); Console.WriteLine("The price per person is {0}$", (2850 / n).ToString("F2")); }
                if (s == "Gold") { Console.WriteLine("We can offer you the Small Hall"); Console.WriteLine("The price per person is {0}$", (2925 / n).ToString("F2")); }
                if (s == "Platinum") { Console.WriteLine("We can offer you the Small Hall"); Console.WriteLine("The price per person is {0}$", (2975 / n).ToString("F2")); }

            }
            else if (n > 50 && n <= 100)
            {
                if (s == "Normal") { Console.WriteLine("We can offer you the Terrace"); Console.WriteLine("The price per person is {0}$", (5225 / n).ToString("F2")); }
                if (s == "Gold") { Console.WriteLine("We can offer you the Terrace"); Console.WriteLine("The price per person is {0}$", (5175 / n).ToString("F2")); }
                if (s == "Platinum") { Console.WriteLine("We can offer you the Terrace"); Console.WriteLine("The price per person is {0}$", (5100 / n).ToString("F2")); }

            }
            else if (n > 100 && n <= 120)
            {
                if (s == "Normal") { Console.WriteLine("We can offer you the Great Hall"); Console.WriteLine("The price per person is {0}$", (7600 / n).ToString("F2")); }
                if (s == "Gold") { Console.WriteLine("We can offer you the Great Hall"); Console.WriteLine("The price per person is {0}$", (7425 / n).ToString("F2")); }
                if (s == "Platinum") { Console.WriteLine("We can offer you the Great Hall"); Console.WriteLine("The price per person is {0}$", (7225 / n).ToString("F2")); }

            }
            else Console.WriteLine("We do not have an appropriate hall.");


        }
    }
}