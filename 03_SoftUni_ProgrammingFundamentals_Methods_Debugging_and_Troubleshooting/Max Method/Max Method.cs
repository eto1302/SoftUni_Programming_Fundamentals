using System;

namespace Methods_Debugging_and_Troubleshooting
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Solve( Solve(a, b) , c));

        }
        public static int Solve(int a, int  b)
        {
            if (a > b) return a;
            else return b;

        }

    }
}