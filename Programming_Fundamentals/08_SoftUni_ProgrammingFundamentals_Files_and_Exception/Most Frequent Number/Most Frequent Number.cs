using System;
using System.IO;
using System.Linq;


namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines("input.txt");

            string[] s = new string[lines.Length];
            var numbers = string.Join(" ", lines).Split(' ').Select(int.Parse).ToArray();
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
            File.WriteAllText("output.txt", "");
            s[0] = n.ToString();
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
            
            else File.WriteAllText("output.txt", string.Join("\n",s));
            
        
        }
    }
}
