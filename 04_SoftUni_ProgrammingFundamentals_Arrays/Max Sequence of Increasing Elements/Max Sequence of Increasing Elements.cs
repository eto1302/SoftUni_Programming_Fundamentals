using System;
using System.Linq;
namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int start = 0;
            int length = 1;
            int maxlength = 0;
            int bs = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers[i - 1] + 1) { length++;}
                else { start = i; length = 1; }
                if (length > maxlength) { maxlength = length; bs = start; }
                
            }
            
            for (int i = bs; i < bs+maxlength; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
    }
}