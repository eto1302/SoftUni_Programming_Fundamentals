using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int br = 0;
            for(int i = 0; i< numbers.Length;i++)
            {
                for(int i1 = i; i1<numbers.Length;i1++)
                {
                    if (numbers[i1] == numbers[i] + k || numbers[i1] == numbers[i] - k) br++;
                }
            }
            Console.WriteLine(br);
        }
    }
}