using System;

namespace Centuries_to_Nanos_econds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = n * 100;
            int n2 = (int)(n1 * 365.2422);
            int n3 = n2 * 24;
            long n4 = n3 * 60;
            long n5 = n4 * 60;
            ulong n6 = (ulong)n5 * 1000;
            ulong n7 = (ulong)n6 * 1000;
            string n8 = (n7).ToString();
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8}000 nanoseconds", n, n1, n2, n3, n4, n5, n6, n7, n7);
        }
    }
}