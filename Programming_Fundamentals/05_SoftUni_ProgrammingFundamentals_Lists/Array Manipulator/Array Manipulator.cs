using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalProgramming
{
    class Startup
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "print")
            {
                var tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "addMany":
                        AddMany(numbers, int.Parse(tokens[1]), tokens);
                        break;
                    case "contains":
                        Console.WriteLine(numbers.IndexOf(int.Parse(tokens[1])));
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "shift":
                        ShiftPositions(numbers, int.Parse(tokens[1]));
                        break;
                    case "sumPairs":
                        SumPairs(numbers);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", numbers));
        }

        private static void SumPairs(List<int> numbers)
        {
            int countInputNumbers = numbers.Count;
            for (int i = 0; i < countInputNumbers / 2; i++)
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
            }
        }

        private static void ShiftPositions(List<int> numbers, int positions)
        {
            for (int i = 0; i < positions; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        private static void AddMany(List<int> numbers, int index, string[] tokens)
        {
            var elementsToAdd = tokens.Skip(2).Select(int.Parse).ToList();
            numbers.InsertRange(index, elementsToAdd);
        }
    }
}