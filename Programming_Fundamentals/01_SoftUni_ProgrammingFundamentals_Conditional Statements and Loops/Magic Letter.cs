using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            for (int i = (int)a; i <= (int)b; i++)
            {
                for (int i1 = (int)a; i1 <= (int)b; i1++)
                {
                    for (int i2 = (int)a; i2 <= (int)b; i2++)
                    {
                        if (i == (int)c || i1 == (int)c || i2 == (int)c) continue;
                        else Console.Write("{0}{1}{2} ", (char)i, (char)i1, (char)i2);
                    }
                }
            }



        }
    }
}