using System;
using System.Collections.Generic;
using System.Linq;
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();
            string s = Console.ReadLine();
            long n=0;
            if(s!="stop")  n = long.Parse(Console.ReadLine());
            while(s!="stop")
            {
                
                if (dict.ContainsKey(s)) dict[s] = dict[s] + n;
                else dict.Add(s, n);
                 s = Console.ReadLine();
                if (s != "stop") n = long.Parse(Console.ReadLine());
                 


            }
            foreach (var item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}