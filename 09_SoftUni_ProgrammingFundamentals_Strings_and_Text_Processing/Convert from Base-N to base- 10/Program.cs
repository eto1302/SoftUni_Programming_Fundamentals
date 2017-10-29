using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Convert_from_Bse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ').ToArray();
            uint n = uint.Parse(s[0]);
            BigInteger a = BigInteger.Parse(s[1]);
            BigInteger res = 0;
            BigInteger br = 0;
            BigInteger l = 1;
            if (n == 10) Console.WriteLine(s[1]);
            else
            {
                for (int i = s[1].Length - 1; i >= 0; i--)
                {
                    for (int i1 = 0; i1 < br; i1++)
                    {
                        l = l * n;
                    }

                    res = res + BigInteger.Parse(s[1][i].ToString()) * l;
                    l = 1;
                    br++;

                }
                Console.WriteLine(res);

            }


        }
    }
}
