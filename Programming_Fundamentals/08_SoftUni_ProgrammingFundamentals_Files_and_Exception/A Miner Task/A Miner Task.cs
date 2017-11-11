using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, long>();
            string[] input = File.ReadAllText("input.txt").Split('\n').ToArray();
            string s = input[0];
            long n = 0;
            int k = 2;
            if (s != "stop\r") n = long.Parse(input[1]);
            while (s != "stop\r")
            {

                if (dict.ContainsKey(s)) dict[s] = dict[s] + n;
                else dict.Add(s, n);
                s = input[k];
                if (s != "stop\r") n = long.Parse(input[k+1]);
                k = k + 2;


            }
            string[] res = new string[dict.Count];
            int ind = 0;
            foreach (var item in dict)
            {
                res[ind] = item.Key.ToString();
                res[ind] = res[ind] + " -> ";
                res[ind] = res[ind] + item.Value.ToString();
                ind++;
            }
            File.WriteAllText("output.txt",string.Join(Environment.NewLine, res));
        }
    }
}