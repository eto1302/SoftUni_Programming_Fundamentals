using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            if (s.EndsWith("y")) { Console.WriteLine("{0}ies", s.Remove(s.Length - 1)); }
            else if (s.EndsWith("o") || s.EndsWith("s") || s.EndsWith("x") || s.EndsWith("z")) Console.WriteLine("{0}es", s);
            else if (s.EndsWith("sh") || s.EndsWith("ch")) { Console.WriteLine("{0}es", s); }
            else Console.WriteLine("{0}s", s);


        }
    }
}