using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = 100000000;
            List<int> list = new List<int>();
            int n1 = 0;
            int maxbr = 0;
            int br = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    br++; if (br > maxbr) { maxbr = br; n1 = numbers[i]; }

                }
                else { n = numbers[i]; br = 0; }
            }
            for (int i = 0; i < maxbr + 1; i++)
            {
                list.Add(n1);
            }
            File.WriteAllText("output.txt", string.Join(" ", list));
        }
    }
}