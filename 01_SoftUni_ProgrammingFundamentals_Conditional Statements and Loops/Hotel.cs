using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var n = double.Parse(Console.ReadLine());


            if (s == "May")
            {
                if (n > 7) Console.WriteLine("Studio: {0} lv.", (0.95 * 50 * n).ToString("F2"));
                else Console.WriteLine("Studio: {0} lv.", (50 * n).ToString("F2"));

                Console.WriteLine("Double: {0} lv.", (65 * n).ToString("F2"));

                Console.WriteLine("Suite: {0} lv.", (75 * n).ToString("F2"));

            }


            if (s == "June")
            {

                Console.WriteLine("Studio: {0} lv.", (60 * n).ToString("F2"));
                if (n > 14) Console.WriteLine("Double: {0} lv.", (0.90 * 72 * n).ToString("F2"));
                else Console.WriteLine("Double: {0} lv.", (72 * n).ToString("F2"));

                Console.WriteLine("Suite: {0} lv.", (82 * n).ToString("F2"));

            }


            if (s == "July")
            {

                Console.WriteLine("Studio: {0} lv.", (68 * n).ToString("F2"));

                Console.WriteLine("Double: {0} lv.", (77 * n).ToString("F2"));
                if (n > 14) Console.WriteLine("Suite: {0} lv.", (0.85 * 89 * n).ToString("F2"));
                else Console.WriteLine("Suite: {0} lv.", (89 * n).ToString("F2"));

            }
            if (s == "August")
            {
                Console.WriteLine("Studio: {0} lv.", (68 * n).ToString("F2"));

                Console.WriteLine("Double: {0} lv.", (77 * n).ToString("F2"));
                if (n > 14) Console.WriteLine("Suite: {0} lv.", (0.85 * 89 * n).ToString("F2"));
                else Console.WriteLine("Suite: {0} lv.", (89 * n).ToString("F2"));

            }
            if (s == "September")
            {
                if (n > 7) Console.WriteLine("Studio: {0} lv.", (60 * (n - 1)).ToString("F2"));
                else Console.WriteLine("Studio: {0} lv.", (60 * n).ToString("F2"));
                if (n > 14) Console.WriteLine("Double: {0} lv.", (0.90 * 72 * n).ToString("F2"));
                else Console.WriteLine("Double: {0} lv.", (72 * n).ToString("F2"));

                Console.WriteLine("Suite: {0} lv.", (82 * n).ToString("F2"));

            }
            if (s == "October")
            {
                if (n > 7) Console.WriteLine("Studio: {0} lv.", (0.95 * 50 * (n - 1)).ToString("F2"));
                else Console.WriteLine("Studio: {0} lv.", (50 * n).ToString("F2"));

                Console.WriteLine("Double: {0} lv.", (65 * n).ToString("F2"));

                Console.WriteLine("Suite: {0} lv.", (75 * n).ToString("F2"));

            }
            if (s == "December")
            {
                Console.WriteLine("Studio: {0} lv.", (68 * n).ToString("F2"));

                Console.WriteLine("Double: {0} lv.", (77 * n).ToString("F2"));
                if (n > 14) Console.WriteLine("Suite: {0} lv.", (0.85 * 89 * n).ToString("F2"));
                else Console.WriteLine("Suite: {0} lv.", (89 * n).ToString("F2"));

            }


        }
    }
}