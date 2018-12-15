using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
namespace Book_Library
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();
            string[] input = File.ReadAllText("input.txt").Split('\n');
            int n = int.Parse(input[0]);
            for (int i = 0; i < n; i++)
            {
                string[] s = input[i+1].Split(' ').ToArray();

                dict[s[0]] = DateTime.ParseExact(s[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            }
            var res = dict.OrderBy(c => c.Value).ThenBy(c => c.Key);
            DateTime d = DateTime.ParseExact(input[n+1], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<string> lines = new List<string>();
            int ind = 0;
            foreach (KeyValuePair<string, DateTime> kvp in res)
            {

                if (kvp.Value > d)
                {
                   
                    lines.Add("");
                    lines[ind] = kvp.Key;
                    lines[ind] += " -> ";
                    lines[ind] += kvp.Value.Day.ToString();
                    lines[ind] += ".";
                    lines[ind] += kvp.Value.Month.ToString("D2");
                    lines[ind] += ".";
                    lines[ind] += kvp.Value.Year.ToString();
                    ind++;
                }
            }
            File.WriteAllText("output.txt", string.Join(Environment.NewLine, lines));
        }
    }
}

