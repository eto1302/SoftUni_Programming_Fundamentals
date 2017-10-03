using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            double t = n1 * 3600 + n2 * 60 + n3;
            double h = t/3600;
            double m = n / 1609;
            double r = n / t;
            double r1 = n / 1000f / h;
            double r2 = m / h;
            Console.WriteLine(r.ToString("F6"));
            Console.WriteLine(r1.ToString("F5"));
            Console.WriteLine(r2.ToString("F5"));
            Console.ReadLine();
        }
    }
}