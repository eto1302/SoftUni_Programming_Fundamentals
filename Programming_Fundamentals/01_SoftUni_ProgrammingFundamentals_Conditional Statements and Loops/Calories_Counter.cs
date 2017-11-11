using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                if (s.ToLower() == "tomato sauce") sum += 150;
                if (s.ToLower() == "cheese") sum += 500;
                if (s.ToLower() == "salami") sum += 600;
                if (s.ToLower() == "pepper") sum += 50;

            }
            Console.WriteLine("Total calories: {0}", sum);
        }
    }
}