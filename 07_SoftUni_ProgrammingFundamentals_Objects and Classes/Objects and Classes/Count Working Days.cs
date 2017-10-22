using System;
using System.Globalization;

namespace Objects_and_Classes
{
    class Program
    {
        
        static void Main(string[] args)
        {

            DateTime[] ar = new DateTime [11];
            
        
            ar[0] = new DateTime(1, 1, 1);
            ar[1] = new DateTime(1, 3, 3);
            ar[2] = new DateTime(1, 5, 1);
            ar[3] = new DateTime(1, 5, 6);
            ar[4] = new DateTime(1, 5, 24);
            ar[5] = new DateTime(1, 9, 6);
            ar[6] = new DateTime(1, 9, 22);
            ar[7] = new DateTime(1, 11, 1);
            ar[8] = new DateTime(1, 12, 24);
            ar[9] = new DateTime(1, 12, 25);
            ar[10] = new DateTime(1, 12, 26);


            DateTime begin = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            
            bool flag = false;
            int br = 0;
            for (DateTime i = begin; i <= end; i=i.AddDays(1))
            {
                flag = false;
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday) { continue; }
                else
                {
                    for (int i1 = 0; i1 < ar.Length; i1++)
                    {
                        
                        
                        if (i.Day == ar[i1].Day&&i.Month==ar[i1].Month) { flag = true;  break; }
                        
                    }
                    if (flag == false)
                    { br++;  }
                }
                
            
            }
            Console.WriteLine(br);



        }
    }
}