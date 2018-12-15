using System;
using System.Collections.Generic;
using System.Linq;
namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string s = Console.ReadLine();
            string[] s1 = new string[8];
            if (s != "stop")  s1 = Console.ReadLine().Split('.').ToArray();
            while(s!="stop")
            {
                s1[1] = string.Concat(".", s1[1]);
                if (s1[1].ToLower() != ".us" && s1[1].ToLower() != ".uk") dict.Add(s, string.Concat(s1[0],s1[1]));
                s = Console.ReadLine();
                if (s != "stop") s1 = Console.ReadLine().Split('.').ToArray();
            }
            foreach(var ind in dict)
            {
                Console.WriteLine("{0} -> {1}", ind.Key, ind.Value);
            }
        }
    }
}