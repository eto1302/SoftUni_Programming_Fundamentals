using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            for (int i = 0; i > -1; i++)
            {
                var s = Console.ReadLine();
                if (s == "Bake!") { Console.WriteLine("Preparing cake with {0} ingredients.", br); break; }
                Console.WriteLine("Adding ingredient {0}.", s);
                br++;


            }




        }
    }
}