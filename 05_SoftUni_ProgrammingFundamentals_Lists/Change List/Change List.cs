using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string s = Console.ReadLine();
            string s1;
            int[] ar = new int[3];
            while(s[0]!='O'&&s[0]!='E')
            {
                s1 = s.Substring(7, s.Length-7);
                
                ar = s1.Split(' ').Select(int.Parse).ToArray();
                
                if(s[0]=='D')
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list.Remove(ar[0]);
                    }
                    
                }
                if (s[0] == 'I')
                {
                    list.Insert(ar[1], ar[0]);
                }
                s = Console.ReadLine();
            }
            if(s=="Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0) Console.Write("{0} ", list[i]);
                }
                
            }
            if (s == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0) Console.Write("{0} ",list[i]);
                }
            }
        }
    }
}