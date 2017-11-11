using System;
using System.Collections.Generic;


class LInRange
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        int n1 = int.Parse(Console.ReadLine());


        // Invoke the Solve() method
        List<int> l = Solve(n, n1);


        // Printing the list
        for (int i = 0; i < l.Count; i++)
        {
            Console.Write(l[i]);
            if (i == l.Count - 1)
            {
                Console.WriteLine();
                break;
            }
            Console.Write(", ");
        }
    }


    public static List<int> Solve(int s, int end)
    {
        List<int> l = new List<int>();


        if (s < 2)
        {
            s = 2;
        }


        for (int i = s; i <= end; i++)
        {


            bool Solve = true;
            for (int j = 2; (j * j) <= i; j++)
            {
                if ((i % j) == 0)
                {
                    Solve = false;
                    break;
                }
            }
            if (Solve)
            {
                l.Add(i);
            }
        }
        return l;
    }
}

