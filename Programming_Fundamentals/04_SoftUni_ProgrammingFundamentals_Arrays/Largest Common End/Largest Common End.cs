using System;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] s1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int br = common(s, s1);
            Array.Reverse(s);
            Array.Reverse(s1);
            int br1 = common(s, s1);
            Console.WriteLine(Math.Max(br, br1));
        }
        private static int common (string[] s, string[] s1)

            {
            int length = Math.Min(s.Length, s1.Length);
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (s[i] == s1[i]) count++;
                else break;
            }
            return count;
            }
        
    }
}