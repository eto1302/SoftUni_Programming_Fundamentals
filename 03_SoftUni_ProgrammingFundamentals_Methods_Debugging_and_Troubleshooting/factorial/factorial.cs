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
            BigInteger sum = 1;
            for(BigInteger i = 2;i<=n;i++)
            {
                sum = sum * i;
            
            }
            Console.WriteLine(sum);
        }
    }
}