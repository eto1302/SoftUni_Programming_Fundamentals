using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sum = 0;
            var br = 0;

            var flag = 0;
            for (int i = a; i <= b; i++)
            {
                for (int i1 = a; i1 <= b; i1++)
                {
                    sum = i + i1;
                    br++;
                    if (sum == c) { Console.WriteLine("Number found! {0} + {1} = {2}", i1, i, c); flag = 1; break; }

                }
                if (flag == 1) { break; }
            }

            if (flag == 0)
            {
                Console.Write("{0} combinations - ", br);
                Console.WriteLine("neither equals {0}", c);
            }


        }
    }
}