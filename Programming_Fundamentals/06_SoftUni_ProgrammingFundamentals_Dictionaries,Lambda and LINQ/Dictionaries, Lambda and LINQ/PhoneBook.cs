using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries__Lambda_and_LINQ
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string[] s = Console.ReadLine().Split(' ').ToArray();

            while (s[0] != "END")
            {
                if (s[0] == "A")
                { 
                    if (dict.ContainsKey(s[1]))
                    {
                        dict[s[1]] = s[2];
                    }
                    else
                    {
                        dict.Add(s[1], s[2]);
                    }
                }
                if (s[0] == "S")
                {
                    if (dict.ContainsKey(s[1]))
                    {
                        Console.WriteLine("{0} -> {1}", s[1], dict[s[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", s[1]);
                    }
                }
                 s = Console.ReadLine().Split(' ').ToArray();
            }

        }
    }
}