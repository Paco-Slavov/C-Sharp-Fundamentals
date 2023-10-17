﻿namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - i];
                numbers.Add(currentSum);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}