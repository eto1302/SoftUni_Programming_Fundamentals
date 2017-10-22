using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ').ToArray();
               
                dict[s[0]] = DateTime.ParseExact(s[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            var res = dict.OrderBy(c => c.Value).ThenBy(c => c.Key);
            DateTime d = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);
            foreach (KeyValuePair<string, DateTime> kvp in res)
            {

                if(kvp.Value>d)Console.WriteLine("{0} -> {1}.{2}.{3}", kvp.Key, kvp.Value.Day,kvp.Value.Month.ToString("D2"),kvp.Value.Year);
            }
        }
    }
}
/*
5
LOTR Tolkien GeorgeAllen 29.07.1954 0395082999 30.00
Hobbit Tolkien GeorgeAll 21.09.1937 0395082888 10.25
HP1 JKRowling Bloomsbury 26.06.1997 0395082777 15.50
HP7 JKRowling Bloomsbury 21.07.2007 0395082666 20.00
AC OBowden PenguinBooks 20.11.2009 0395082555 14.00
30.07.1954
*/