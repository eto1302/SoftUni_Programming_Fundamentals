using System;

namespace Methods_Debugging_and_Troubleshooting
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Solve(s);


        }
        public static void Solve(string s)
        {
            for (int i = s.Length-1; i >=0; --i)
            {
                Console.Write(s[i]);
            }

        }

    }
}