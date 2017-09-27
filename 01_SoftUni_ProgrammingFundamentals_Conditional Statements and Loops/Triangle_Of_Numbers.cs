using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int i1 = 0; i1 < i; i1++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
    }
}