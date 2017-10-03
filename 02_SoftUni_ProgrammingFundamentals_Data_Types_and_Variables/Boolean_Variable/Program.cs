using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool b;
            b = Convert.ToBoolean(s);
            if (b == true) Console.WriteLine("Yes");
            else if (b == false) Console.WriteLine("No");
        }
    }
}