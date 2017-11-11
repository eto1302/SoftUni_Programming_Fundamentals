using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int rem = 0;
            if (n != 0)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    int a = int.Parse(s[i].ToString());

                    list.Add(((a * n) + rem) % 10);
                    rem = ((a * n) + rem) / 10;


                }

                list.Reverse();

                if (rem != 0)
                {
                    list.Add(0);
                    for (int i = list.Count - 1; i > 0; i--)
                    {
                        list[i] = list[i - 1];


                    }


                    list[0] = rem;
                }

                Console.WriteLine(string.Join("", list).TrimStart('0'));
            }
            else Console.WriteLine(0);
        }
    }
}
