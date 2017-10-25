using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace Average_Grades
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public double[] Grades { get; set; }
            public double Average { get; set; }

        }
        static void Main(string[] args)
        {
            string[] input = File.ReadAllText("input.txt").Split('\n');
            int n = int.Parse(input[0]);
            List<Student> list = new List<Student>();
            List<Student> res = new List<Student>();
            for (int i = 0; i < n; i++)
            {

                string[] s = input[i+1].Split(' ').ToArray();
                List<double> dlist = new List<double>();

                for (int i1 = 1; i1 < s.Length; i1++)
                {
                    dlist.Add(Convert.ToDouble(s[i1]));
                }
                
                list.Add(new Student { Name = s[0], Grades = dlist.ToArray(), Average = dlist.Average() });

            }
            res = list.Where(c => c.Average >= 5.00).OrderBy(c => c.Name).ThenByDescending(c => c.Average).ToList();

            string[] res1 = new string[n];
            for (int i = 0; i < res.Count(); i++)
            {

                res1[i] = res[i].Name;
                res1[i] = res1[i] + " -> ";
                res1[i] = res1[i] + res[i].Average.ToString("F2");
                
            }
            File.WriteAllText("output.txt",string.Join(Environment.NewLine,res1));


        }
    }
}