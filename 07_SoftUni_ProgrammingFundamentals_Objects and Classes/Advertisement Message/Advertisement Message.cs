using System;

namespace Advertisement_Message
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            

            string[] phrases = new string[7];
            string[] events = new string[6];
            string[] names = new string[9];
            string[] cities = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of its category";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can't live without this product.";
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles. I am happy of the results!";
            events[3] = "I cannot believe but now I feel aweseome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";
            names[0] = "Diana";
            names[1] = "Petya";
            names[2] = "Stella";
            names[3] = "Elena";
            names[4] = "Katya";
            names[5] = "Iva";
            names[6] = "Annie";
            names[7] = "Eva";
            cities[0] = "Burgas";
            cities[0] = "Sofia";
            cities[0] = "Plovdiv";
            cities[0] = "Varna";
            cities[0] = "Ruse";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}",phrases[random.Next(0,phrases.Length)], events[random.Next(0, events.Length)], names[random.Next(0, names.Length)], cities[random.Next(0, cities.Length)]);
            }

        }
    }
}