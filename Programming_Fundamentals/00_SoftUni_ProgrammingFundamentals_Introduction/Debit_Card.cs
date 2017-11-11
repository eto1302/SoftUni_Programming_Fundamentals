using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[4];
            for (int i = 0; i < 4; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                if (ar[i] < 10) Console.Write("000{0} ", ar[i]);
                else if (ar[i] < 100) Console.Write("00{0} ", ar[i]);
                else if (ar[i] < 1000) Console.Write("0{0} ", ar[i]);
                else if (ar[i] < 10000) Console.Write("{0} ", ar[i]);
            }
            Console.ReadLine();
        }


    }
}