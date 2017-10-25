using System;
using System.Linq;
using System.IO;
namespace Indez_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ar = new char[26];
            ar.SetValue('a', 0);
            ar.SetValue('b', 1);
            ar.SetValue('c', 2);
            ar.SetValue('d', 3);
            ar.SetValue('e', 4);
            ar.SetValue('f', 5);
            ar.SetValue('g', 6);
            ar.SetValue('h', 7);
            ar.SetValue('i', 8);
            ar.SetValue('j', 9);
            ar.SetValue('k', 10);
            ar.SetValue('l', 11);
            ar.SetValue('m', 12);
            ar.SetValue('n', 13);
            ar.SetValue('o', 14);
            ar.SetValue('p', 15);
            ar.SetValue('q', 16);
            ar.SetValue('r', 17);
            ar.SetValue('s', 18);
            ar.SetValue('t', 19);
            ar.SetValue('u', 20);
            ar.SetValue('v', 21);
            ar.SetValue('w', 22);
            ar.SetValue('x', 23);
            ar.SetValue('y', 24);
            ar.SetValue('z', 25);
            string s = File.ReadAllText("input.txt");
         
            string[] lines = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                lines[i] = s[i].ToString();
                
               
                lines[i] = lines[i] + " -> ";
                
                
                lines[i] = lines[i] + Array.IndexOf(ar, s[i]);
                
                
            }
            File.WriteAllLines("output.txt", lines);

        }
    }
}