using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            if (center(x, y, x1, y1) == 1) Console.WriteLine("({0}, {1})", x1, y1);
            else if (center(x, y, x1, y1) == 0) Console.WriteLine("({0}, {1})", x, y);
        }
        public static int center(double x, double y, double x1, double y1)
        {
            if (x < 0) x1 = x1 * -1;
            if (y < 0) y = y * -1;
            if (x1 < 0) x1 = x1 * -1;
            if (y1 < 0) y1 = y1 * -1;
            if (Math.Sqrt(x * x + y * y) > Math.Sqrt(x1 * x1 + y1 * y1)) return 1;
            return 0;
        }
    }
}