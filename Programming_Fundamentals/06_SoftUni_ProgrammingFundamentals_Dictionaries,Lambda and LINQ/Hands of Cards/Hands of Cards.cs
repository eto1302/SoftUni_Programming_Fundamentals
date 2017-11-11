using System;
using System.Linq;
using System.Collections.Generic;
namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();
            string s = Console.ReadLine();
            while(s!="JOKER")
            {
                var ar = s.Split(':');
                var name = ar[0];
                var card = ar[1].Trim().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                if(!people.ContainsKey(name))
                {
                    people.Add(name, new Dictionary<string, int>());
                    AddCards(people[name], card);
                }
                else
                {
                    AddCards(people[name], card);
                }
                s = Console.ReadLine();
            }
            foreach (var item in people)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value.Values.Sum());
            }
        }

        private static void AddCards(Dictionary<string,int> person, string[] card)
        {
            foreach (var item in card)
            {
                if(!person.ContainsKey(item))
                {
                    person.Add(item, GetCardValue(item));
                }
            }
        }

        private static int GetCardValue(string card)
        {
            int power = 0;

            switch(card[0])
            {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    power += (int)card[0] - 48;
                    break;
                case '1':
                    power += 10;
                    break;
                case 'J':
                    power += 11;
                    break;
                case 'Q':
                    power += 12;
                    break;
                case 'K':
                    power += 13;
                    break;
                case 'A':
                    power += 14;
                    break;

            }
            switch(card[card.Length-1])
            {
                case 'S':
                    power *= 4;
                    break;
                case 'H':
                    power *= 3;
                    break;
                case 'D':
                    power *= 2;
                    break;
                case 'C':
                    power *= 1;
                    break;
            }

            return power;
        }
    }
}