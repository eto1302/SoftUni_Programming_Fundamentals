using System;
using System.Collections.Generic;
using System.Linq;
namespace Intersection_of_circles
{
    class Program
    {
        public class Circle
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Radius { get; set; }
        }
        static void Main(string[] args)
        {
            
            var ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle first = new Circle() { X = ar[0], Y = ar[1], Radius = ar[2] };
            ar = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle second = new Circle() { X = ar[0], Y = ar[1], Radius = ar[2] };
            double a, b, c;
            a = Math.Abs(first.X - second.X);
            b = Math.Abs(first.Y - second.Y);
            c = Math.Sqrt(a * a + b * b);
            if (c <= first.Radius + second.Radius) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
            
        
    }
}