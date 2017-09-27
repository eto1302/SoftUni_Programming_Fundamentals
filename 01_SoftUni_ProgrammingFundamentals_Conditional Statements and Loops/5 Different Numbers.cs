using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var n1 = int.Parse(Console.ReadLine());
            if (Math.Abs(n - n1) < 5) Console.WriteLine("No");
            else
            {
                for (int i = n; i <= n1; i++)
                {
                    for (int j = n; j <= n1; j++)
                    {
                        for (int k = n; k <= n1; k++)
                        {
                            for (int l = n; l <= n1; l++)
                            {
                                for (int s = n; s <= n1; s++)
                                {
                                    if (j <= i || k <= j || l <= k || s <= l) continue;
                                    else
                                        Console.WriteLine("{0} {1} {2} {3} {4}", i, j, k, l, s);
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}