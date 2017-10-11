using System;
using System.Linq;
namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] s1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            int flag = 8;
            for (int i = 0; i < Math.Min(s.Length,s1.Length); i++)
            {
                if (s[i] < s1[i]) flag = 1;
                else if (s[i] > s1[i]) flag = 2;
                else if (s[i] == s1[i]) continue;
            }
            if (flag == 1)
            {
                Console.WriteLine($"{string.Join("", s)}");
                Console.WriteLine($"{string.Join("", s1)}");
            }
            else if(flag == 2)
            {
                
                    Console.WriteLine($"{string.Join("", s1)}");
                    Console.WriteLine($"{string.Join("", s)}");
                
            }
            else if(flag == 8)
            {
                if(s.Length<=s1.Length)
                {
                    Console.WriteLine($"{string.Join("", s)}");
                    Console.WriteLine($"{string.Join("", s1)}");
                }
                if (s.Length > s1.Length)
                {
                    Console.WriteLine($"{string.Join("", s1)}");
                    Console.WriteLine($"{string.Join("", s)}");
                }
            }
        }
    }
}