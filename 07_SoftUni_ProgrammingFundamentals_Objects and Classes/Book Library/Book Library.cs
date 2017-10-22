using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ').ToArray();
                if (dict.ContainsKey(s[1]))
                {
                    dict[s[1]] = dict[s[1]]+Convert.ToDouble(s[5]);
                }
                else dict[s[1]] = Convert.ToDouble(s[5]);
            }
            var res = dict.OrderByDescending(c => c.Value).ThenBy(c => c.Key);
            foreach (KeyValuePair<string,double> kvp in res)
            {
               
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value.ToString("F2"));
            }
        }
    }
}