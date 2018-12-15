using System;
using System.Linq;
using System.Collections.Generic;
namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int n = 100000000;
            int n1 = 0;
            int maxbr = 0;
            int br = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == n)
                {
                    br++; if (br > maxbr) { maxbr = br; n1 = numbers[i]; }

                }
                else { n = numbers[i]; br = 0; }
            }
            if (maxbr != 0)
            {
                for (int i = 0; i < maxbr + 1; i++)
                {
                    Console.Write("{0} ", n1);
                }
            }
            else Console.WriteLine(numbers[0]);
        }
    }
}