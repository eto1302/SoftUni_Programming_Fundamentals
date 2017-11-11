using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            int a = 5;
            int b = 10;
            r = a;
            a = b;
            b = r;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",b);
            Console.WriteLine("b = {0}",a);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
        }
    }
}