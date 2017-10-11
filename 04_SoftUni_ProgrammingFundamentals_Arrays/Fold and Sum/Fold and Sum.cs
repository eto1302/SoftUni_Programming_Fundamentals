using System;
using System.Linq;
namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int ind = 0;
            int[] arl = new int[numbers.Length / 4];
            int[] arm = new int[numbers.Length / 2];
            int[] arr = new int[numbers.Length / 4];
            
            for (int i = 0; i < numbers.Length/4; i++)
            {
                arl[i] = numbers[i];
            }
            for (int i = numbers.Length/4*3; i < numbers.Length;  i++)
            {
                arr[ind] = numbers[i];
                ind ++;
                
            }
            ind= 0;
            for (int i = numbers.Length / 4; i < numbers.Length/4*3; i++)
            {
                arm[ind] = numbers[i];
                ind++;
                
            }
            Array.Reverse(arr);
            Array.Reverse(arl);
            
            for (int i = 0; i < arm.Length/2; i++)
            {
                Console.Write("{0} ", arl[i] + arm[i]);


            }
            ind = 0;
            for (int i = arm.Length/2; i < arm.Length; i++)
            {
               
                Console.Write("{0} ", arr[ind] + arm[i]);
                ind++;

            }



        }
    }
}