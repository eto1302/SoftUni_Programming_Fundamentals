using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        string matchedString = "";
        jump++;
        
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump;

                if (i + endIndex > text.Length)
                {
                     matchedString = text.Substring(i);
                }
                else
                {
                     matchedString = text.Substring(i, endIndex);
                }
                Console.WriteLine(matchedString);
                i += jump-1;
            }
        }

        if (hasMatch == false)
        {
            Console.WriteLine("no");
        }
    }
}
