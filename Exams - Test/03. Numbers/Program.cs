using System;
using System.Globalization;

namespace _03._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int sum = 0;
            int count = 0;
            double average = 0;

            if (number.Length == 0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    for (int j = i + 1; j < number.Length; j++) //
                    {
                        if (number[i] < number[j])
                        {
                            int top = number[i];
                            number[i] = number[j];
                            number[j] = top;
                        }
                    }
                }
                average = (double)sum / (double)count;
                int printCount = 0;

                for (int i = 0; i < number.Length; i++)
                {
                    printCount++;

                    if (number[i] > average && printCount <= 5)
                    {
                        Console.Write($"{number[i]}");
                    }
                }
            }
        }
    }
}