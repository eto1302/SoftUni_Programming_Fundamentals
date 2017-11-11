using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            string[] input = File.ReadAllText("input.txt").Split('\n');
            string s = input[0];
            string[] s1 = new string[8];
            int k = 2;
            if (s != "stop\r") s1 = input[1].Split('.').ToArray();
            while (s != "stop\r")
            {
                s1[1] = string.Concat(".", s1[1]);
                if (s1[1].ToLower() != ".us\r" && s1[1].ToLower() != ".uk\r") dict.Add(s, string.Concat(s1[0], s1[1]));
                s = input[k];
                if (s != "stop\r") s1 = input[k+1].Split('.').ToArray();
                k += 2;
            }
            List<string> res = new List<string>();
            int br = 0;
            foreach (var ind in dict)
            {
                res.Add("");
                res[br] = ind.Key.ToString();
                res[br] = res[br] + " -> ";
                res[br] = res[br] + ind.Value.ToString();
                br++;
            }
            File.WriteAllText("output.txt", string.Join(Environment.NewLine, res));
        }
    }
}
