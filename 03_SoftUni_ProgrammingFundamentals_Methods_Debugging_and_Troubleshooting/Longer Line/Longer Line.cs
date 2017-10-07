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
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            if (line(x, y, x1, y1, x2, y2, x3, y3) == 1)
            {
                if (center(x2, y2, x3, y3) == 1) Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x2, y2); else Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x3, y3);
            }
            if (line(x, y, x1, y1, x2, y2, x3, y3) == 0)
            {
                if (center(x, y, x1, y1) == 1) Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x, y); else Console.WriteLine("({0}, {1})({2}, {3})", x, y, x1, y1);
            }
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
        public static int line(double x, double y , double x1, double y1, double x2, double y2, double x3, double y3)
        {
            
            double a, b, a1, b1;
            a = Math.Abs(x - x1);
            b = Math.Abs(y - y1);
            a1 = Math.Abs(x2 - x3);
            b1 = Math.Abs(y2 - y3);
            if (Math.Sqrt(a * a + b * b) < Math.Sqrt(a1 * a1 + b1 * b1)) return 1;
            return 0;
        }
    }
}