using System;
using System.Collections.Generic;
using System.Linq;
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
            int n = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            List<Student> res = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                
                string[] s = Console.ReadLine().Split(' ').ToArray();
                List<double> dlist = new List<double>();
               
                for (int i1 = 1; i1 < s.Length; i1++)
                {
                    dlist.Add(Convert.ToDouble(s[i1]));
                }
                /*Console.WriteLine(string.Join(" ",dlist));*/
                list.Add(new Student { Name = s[0], Grades = dlist.ToArray(), Average = dlist.Average() });

            }
             res = list.Where(c => c.Average >= 5.00).OrderBy(c => c.Name).ThenByDescending(c => c.Average).ToList();
            
                 
            for (int i = 0; i < res.Count(); i++)
            {
                Console.WriteLine("{0} -> {1}",res[i].Name,res[i].Average.ToString("F2"));
            }
                
                
        }
    }
}