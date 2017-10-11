using System;
using System.Linq;
namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rot = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            for (int j = 0; j < rot; j++)
            {



                int r = numbers[numbers.Length - 1];
                for (int i = numbers.Length - 1; i > 0; i--)
                {

                    numbers[i] = numbers[i - 1];
                    sum[i] += numbers[i];
                }
                numbers[0] = r;
                sum[0] += numbers[0];
            }
            Console.WriteLine($"{string.Join(" ",sum)}");

        }
       
    }
}