using System;

namespace Methods_Debugging_and_Troubleshooting
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Solve(n);


        }
        public static void Solve(int n)
        {
            int a,a1,r;
            a = 0;
            a1 = 1;
            for (int i = 0; i<n;i++)
            {
                r = a1;
                a1 = a + a1;
                a = r;
            }
            Console.WriteLine(a1);

        }

    }
}