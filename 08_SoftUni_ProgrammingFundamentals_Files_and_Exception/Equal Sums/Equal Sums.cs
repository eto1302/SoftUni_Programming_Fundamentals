﻿using System;
using System.Linq;
using System.IO;
namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            int sum1 = 0;
            bool flag = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int i1 = 0; i1 < i; i1++)
                {
                    sum = sum + numbers[i1];
                }
                if (i + 1 >= numbers.Length)
                {
                    sum1 = 0;
                }
                else
                {
                    for (int i1 = i + 1; i1 < numbers.Length; i1++)
                    {
                        sum1 = sum1 + numbers[i1];
                    }
                }
                if (sum == sum1) { flag = true; File.WriteAllText("output.txt",i.ToString()); }
                sum = 0;
                sum1 = 0;

            }
            if (flag == false) File.WriteAllText("output.txt", "no");
        }
    }
}