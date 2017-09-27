using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var br = 0;
            try
            {
                while (1 > 0)
                {
                    var n = int.Parse(Console.ReadLine());
                    br++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(br);
            }
        }
    }
}