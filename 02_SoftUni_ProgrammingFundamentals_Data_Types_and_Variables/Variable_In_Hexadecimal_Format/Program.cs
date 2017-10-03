using System;

namespace Variable_In_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(s, 16));
        }
    }
}