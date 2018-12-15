using System;
using System.Collections.Generic;
using System.Linq;
namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list1 = new List<int>();
            int[] ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < ar[0]; i++)
            {
                list1.Add(list[i]);
            }
            for (int i = 0; i < ar[1]; i++)
            {
                list1.Remove(list[i]);
            }
            if (list1.Contains(ar[2])) Console.WriteLine("YES!");
            else Console.WriteLine("NO!");

        }
    }
}