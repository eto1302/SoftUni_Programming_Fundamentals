﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int c;
            for (int i = 0; i < s.Length; i++)
            {
                c = (int)s[i];
                Console.Write("\\u{0}", c.ToString("x4"));
            }
        }
    }
}
