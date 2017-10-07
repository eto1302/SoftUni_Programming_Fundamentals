using System;
using System.Numerics;
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = long.Parse(Console.ReadLine());
            solve(n);
        }
        public static void solve(BigInteger n)
        {
            BigInteger br = 0;
            BigInteger sum = 1;
            for (BigInteger i = 2; i <= n; i++)
            {
                sum = sum * i;

            }
            while (true)
            {
                if (sum % 10 == 0) { br++; sum = sum / 10; }
                else break;
            }
            Console.WriteLine(br);
        }
    }
}