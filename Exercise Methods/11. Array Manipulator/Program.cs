using System.Security.Authentication;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (input.StartsWith("exchange"))
                {
                    int index = int.Parse(input.Split().Last());
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    array = Exchange(array, index);
                }
                else if (input.StartsWith("max && input.EndsWith(even)")
                {
                    var condition = input.Split().Last();
                    MaxIndexForCondition(array, condition == "even"))
                }
                else if (input.StartsWith("max") && input.EndsWith("even"))
                {
                    IndexForMaxEven(array);
                }
                else if (input.StartsWith("max") && input.EndsWith("odd"))
                {
                    IndexForMaxOdd(array);
                }
                else if (input.StartsWith("min"))
                {
                    var condition = input.Split().Last();
                    MinIndexForCondition(array, condition == "even");
                }
                else if (input.StartsWith("first"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    MinIndexForCondition(array, conditions, count);
                }
                else if (input.StartsWith("last"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    LastElementsForCondition(array, count, conditions.Last() == "even");
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void LastElementsForCondition(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] results = array.Where(number => isEven == (number % 2 == 0)).TakeLast(count).ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", results));
            }
        }

        private static void MinIndexForCondition(int[] array , int count , bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] results = array.Where(number => isEven == (number % 2 == 0)).Take(count).ToArray();
                Console.WriteLine("[{0}]", string.Join(", ", results));
            }
        }

        private static void MinIndexForCondition(int[] array, bool isEven)
        {
            if (array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = array.Where(number => isEven == (number % 2 == 0)).Max();
                Console.WriteLine(Array.LastIndexOf(array, min));
            }
        }

        private static void MaxIndexForCondition(int[] array, bool isEven)
        {
            if (isEven)
            {
                if (array.Any(number => isEven == (number % 2 == 0)))
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                int max = array.Where(number => isEven == (number % 2 == 0)).Max();
                Console.WriteLine(Array.LastIndexOf(array, max));
            }
        }

        private static int[] Exchange(int[] array, int index)
        {
            return array.Skip(index + 1).Take(array.Length - index).Concat(array.Take(index + 1)).ToArray();
        }
    }
}