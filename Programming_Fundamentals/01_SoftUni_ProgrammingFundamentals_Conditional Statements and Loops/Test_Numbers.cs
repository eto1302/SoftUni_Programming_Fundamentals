using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var sum = 0;
            var br = 0;

            var flag = 0;
            for (int i = a; i > 0; i--)
            {
                for (int i1 = 1; i1 <= b; i1++)
                {
                    sum = sum + 3 * (i * i1);
                    br++;
                    if (sum >= c) { break; flag = 1; }
                    //Console.WriteLine("{0} {1}", i, i1);
                    //Console.WriteLine(sum);
                }
                if (sum >= c) { break; flag = 1; }
            }
            Console.WriteLine("{0} combinations", br);
            //Console.WriteLine(flag);
            if (sum >= c) Console.WriteLine("Sum: {0} >= {1}", sum, c);
            else Console.WriteLine("Sum: {0}", sum);

        }
    }
}