using System;

namespace cube_propertiess
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            Solve(s, n);

        }
        public static void Solve(string s, double x)
        {
            if (s == "face") Console.WriteLine(Math.Sqrt(x * x + x * x).ToString("F2")); 
            else if (s == "space") Console.WriteLine(Math.Sqrt(x * x + x * x+x*x).ToString("F2"));
            else if (s == "volume") Console.WriteLine((x*x*x).ToString("F2"));
            else if (s == "area") Console.WriteLine((6*x*x).ToString("F2"));

        }
    }
}