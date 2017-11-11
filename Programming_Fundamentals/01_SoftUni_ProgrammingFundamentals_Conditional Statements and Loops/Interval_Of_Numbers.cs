using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            int r = 0;
            if (n > n1) { r = n; n = n1; n1 = r; }
            for (int i = n; i <= n1; i++)
            {
                Console.WriteLine(i);
            }




        }
    }
}