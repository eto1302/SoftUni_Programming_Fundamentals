using System;

namespace Methods_Debugging_and_Troubleshooting
{
    class Program
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            if (n < 0) n = n * -1;

            Console.WriteLine(Solve(n));


        }
        public static bool Solve(long n)
        {
            if (n == 0 || n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;

        }

    }
}