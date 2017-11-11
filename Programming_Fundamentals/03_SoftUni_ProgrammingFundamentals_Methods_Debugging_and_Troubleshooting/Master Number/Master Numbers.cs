using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 230; i <= n; i++)
            {
                if (ispalindrome(i) == true && evennum(i) == true && sevensum(i) == true) Console.WriteLine(i);
            }
            
            
            
        }

        public static bool ispalindrome(int n)
        {

            string s = n.ToString();
            if (s.Length < 4 && s[0] == s[s.Length - 1]) return true;

             if (s.Length < 6 && (s[0] == s[s.Length - 1] && s[1] == s[s.Length - 2])) return true;


             if (s.Length < 8 && (s[0] == s[s.Length - 1] && s[1] == s[s.Length - 2] && s[2] == s[s.Length - 3])) return true;


            return false;


        }
        public static bool evennum(int n)
        {

            
            while(n!=0)
            {
                if (n % 10 == 0 || n % 10 == 2 || n % 10 == 4 || n % 10 == 6 || n % 10 == 8) return true;
                n = n / 10;
            }
            return false;

        }
        public static bool sevensum(int n)
        {
           
            long sum = 0;
            while(n!=0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            if (sum % 7 == 0) return true;
            return false;

        }
    }
}