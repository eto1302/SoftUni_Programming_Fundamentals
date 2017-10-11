using System;

using System.Linq;


namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var br1 = 0;
            var n = 0;
            var br = new int[65535];
            var k = 0;
            

            for (int i = 0; i < numbers.Length; i++)
            {
                br[numbers[i]]++;
            }

            var max = br.Max();
            for (int i = 0; i < br.Length; i++)
            {
                if (max == br[i])
                {
                    n = i;
                    br1++;

                }
            }

            if (br1 > 1)
            {
                for (int j = 0; j < numbers.Length; j++)
                {

                    if (numbers[j] == n)
                    {
                        if (j < k)
                        {
                            k = j;
                        }


                    }
                }
                Console.WriteLine(numbers[k]);
            }

            else Console.WriteLine(n);


        }
    }
}

