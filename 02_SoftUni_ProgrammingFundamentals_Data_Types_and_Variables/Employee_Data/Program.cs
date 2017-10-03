using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            long l= long.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}",s);
            Console.WriteLine("Last name: {0}", s1);
            Console.WriteLine("Age: {0}", n);
            Console.WriteLine("Gender: {0}", c);
            Console.WriteLine("Personal ID: {0}", l);
            Console.WriteLine("Unique Employee number: {0}", n1);

        }
    }
}