using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[1000000];
            
            ar[0] = 1;
            ar[1] = 1;
            
            for (int i = 2; i <= n; i++)
            {
                if (ar[i] == 1) continue;
                else
                {
                    for (int j = 2; j <= n; j++)
                    {
                        ar[j * i] = 1;
                        
                    }
                }
                
            }
            for (int i = 2; i <= n; i++)
            {
                if (ar[i] == 0) Console.Write("{0} ", i);
            }
          
        }
    }
}