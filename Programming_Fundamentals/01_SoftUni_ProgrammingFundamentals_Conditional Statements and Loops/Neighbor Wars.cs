using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var h = 100;
            var h1 = 100;

            for (int i = 1; i < 300; i++)
            {
                if (i % 2 == 0)
                {
                    h = h - b; if (h <= 0) { Console.WriteLine("Gosho won in {0}th round.", i); break; }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", h);

                }
                if (i % 2 != 0)
                {
                    h1 = h1 - a; if (h1 <= 0) { Console.WriteLine("Pesho won in {0}th round.", i); break; }
                    Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", h1);


                }
                if (i % 3 == 0)
                {
                    h = h + 10;
                    h1 = h1 + 10;
                }


            }


        }
    }
}