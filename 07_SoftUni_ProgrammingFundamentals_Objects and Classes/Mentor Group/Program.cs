using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
namespace Mentor_Group
{
    class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public List<string> Comments { get; set; }
            public List<DateTime> Dates { get; set; }

        }
        static void Main(string[] args)
        {
            string[] s;
            List<Student> list = new List<Student>();
            List<string> str = new List<string>();
            int ind = 0;
            while (true)
            {
                s = Console.ReadLine().Split(' ', ',').ToArray();
                if (s[0] == "end"&&s[1] == "of"&& s[2] =="dates") break;
                list.Add(new Student { Name = "", Comments = new List<string>(), Dates = new List<DateTime>() });
                list[ind].Name = s[0];
                str.Add(s[0]);
                
                for (int i1 = 1; i1 < s.Length; i1++)
                {

                    
                    DateTime dt = DateTime.ParseExact(s[i1], "d/M/yyyy", CultureInfo.InvariantCulture);
                    list[ind].Dates.Add(dt);
                }
                ind++;
            }
            ind = 0;
            while (true)
            {
                s = Console.ReadLine().Split('-').ToArray();
                if (s[0] == "end of comments") break;
                if (!list.Contains(new Student { Name = s[0] }))
                {
                    string s1="";
                    for (int i = 1; i < s.Length; i++)
                    {
                        s1 = s1 + s[i];
                    }

                    

                    if (str.Contains(s[0]))
                    {
                        list[str.IndexOf(s1)+1].Comments.Add(s1);
                    }
                    
                    
                }
                
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Dates.Sort();
                list.OrderBy(c => c.Name);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
                Console.WriteLine("Comments:");
                for (int i1 = 0; i1 < list[i].Comments.Count; i1++)
                {
                    Console.WriteLine("- {0}",list[i].Comments[i1]);
                }
                Console.WriteLine("Dates attended:");
                for (int i1 = 0; i1 < list[i].Dates.Count; i1++)
                {
                    Console.WriteLine("-- {0}/{1}/{2}",list[i].Dates[i1].Day.ToString("D2"),list[i].Dates[i1].Month.ToString("D2"),list[i].Dates[i1].Year);
                }
            }
        }
    }
}
/*
nakov 22/08/2016,20/08/2016
simeon10 22/08/2016
end of dates
nakov-Excellent algorithmetic thinking.
Gesh4o-Total noob.
end of comments
*/