using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Book_Library
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            string[] input = File.ReadAllText("input.txt").Split('\n').ToArray();
            int n = int.Parse(input[0]);
            for (int i = 0; i < n; i++)
            {
                string[] s = input[i+1].Split(' ').ToArray();
                if (dict.ContainsKey(s[1]))
                {
                    dict[s[1]] = dict[s[1]] + Convert.ToDouble(s[5]);
                }
                else dict[s[1]] = Convert.ToDouble(s[5]);
            }
            var res = dict.OrderByDescending(c => c.Value).ThenBy(c => c.Key);
            List<string> list = new List<string>();
            int br = 0;
            foreach (KeyValuePair<string, double> kvp in res)
            {
                list.Add("");
                list[br] = kvp.Key;
                list[br] = list[br] + " -> ";
                list[br] = list[br] + kvp.Value.ToString("F2");
                br++;
            }
            File.WriteAllText("output.txt", string.Join(Environment.NewLine, list));
        }
    }
}