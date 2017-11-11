using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ').ToArray();
            BigInteger sum = 0;
            for (int i = 0; i < Math.Min(s[0].Length, s[1].Length); i++)
            {
                sum = sum + ((int)s[0][i] * (int)s[1][i]);

            }
            if (s[0].Length < s[1].Length)
            {
                for (int i = s[0].Length; i < s[1].Length; i++)
                {
                    sum = sum + (int)s[1][i];
                }
            }
            if (s[0].Length > s[1].Length)
            {
                for (int i = s[1].Length; i < s[0].Length; i++)
                {
                    sum = sum + (int)s[0][i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
