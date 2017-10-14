using System;
using System.Collections.Generic;
using System.Linq;
namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n=0;
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                while(list[i]!=0)
                {
                    n = n * 10 + list[i] % 10;
                    list[i] = list[i] / 10;
                }
               
                sum = sum + n;
                n = 0;
            }
            Console.WriteLine(sum);
        }
    }
}