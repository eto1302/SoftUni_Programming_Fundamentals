using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            int sz = Math.Max(s.Length, s1.Length);
            s = s.PadLeft(sz, '0');
            s1 = s1.PadLeft(sz, '0');
            
            int n = 0;
            List<int> list = new List<int>();
            int sum = 0;
            int a, b;
            for (int i = s.Length - 1; i >= 0; i--)
            {


                a = int.Parse(s[i].ToString());
                b = int.Parse(s1[i].ToString());

                sum = (a + b + n) % 10;
                n = (a + b + n) / 10;
                list.Add(sum);
                
            }
            list.Reverse();
            
            if (n != 0)
            {
                
                    list.Add(0);
                    for (int i = list.Count-1; i >0; i--)
                    {
                        list[i] = list[i - 1];
                    
                    
                    }
                    
                    
                    list[0] = 1;
                

            }
            Console.WriteLine(string.Join("", list).TrimStart('0'));
            

        }
    }
}