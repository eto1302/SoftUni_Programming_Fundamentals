using System;

namespace cube_propertiess
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string s = Console.ReadLine();
            double n = double.Parse(Console.ReadLine());
            if (s == "triangle" || s == "rectangle") { double n1 = double.Parse(Console.ReadLine()); Solve1(s, n,n1); }
            else Solve(s, n);

        }
        public static void Solve(string s, double x)
        {
            if (s == "square") Console.WriteLine((x * x).ToString("F2"));
            else Console.WriteLine((x * x * Math.PI).ToString("F2"));

        }
        public static void Solve1(string s, double x,double x1)
        {
            if (s == "triangle") Console.WriteLine((x * x1 / 2).ToString("F2"));
            else Console.WriteLine((x*x1).ToString("F2"));

        }
    }
} 