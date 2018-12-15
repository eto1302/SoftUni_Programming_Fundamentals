using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Exchangable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] s = Console.ReadLine().Split(' ').ToArray();
            bool flag = false;
            HashSet<char> firstWord = new HashSet<char>(s[0]);
            HashSet<char> secondWord = new HashSet<char>(s[1]);
            if (firstWord.Count == secondWord.Count) flag = true;
            Console.WriteLine(flag.ToString().ToLower());
        }
    }
}