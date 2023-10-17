using System;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmd = input.Split();

                string token = cmd[0];
                switch (token)
                {
                    case "swap":
                        int index1 = int.Parse(cmd[1]);
                        int index2 = int.Parse(cmd[2]);

                        if (index1 >= 0 && index1 < numbers.Length && index2 >= 0 && index2 < numbers.Length) ;
                        {
                            int temp = numbers[index1];
                            numbers[index1] = numbers[index2];
                            numbers[index2] = temp;
                        }
                        break;

                    case "multiply":
                        index1 = int.Parse(cmd[1]);
                        index2 = int.Parse(cmd[2]);

                        if (index1 >= 0 && index1 < numbers.Length && index2 >= 0 && index2 < numbers.Length) ;
                        {
                            int temp = numbers[index1] * numbers[index2];
                            numbers[index2] = temp;
                        }
                        break;

                    case "decrease":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            int temp = numbers[i] - 1;
                            numbers[i] = temp;
                        }
                        break;
                }

                input = Console.ReadLine();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.WriteLine(", ");
                }
            }
        }
    }
}