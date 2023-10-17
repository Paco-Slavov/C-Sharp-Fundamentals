using System;
using System.Threading;

internal class Program
{
    static void Main()
    {
        int[] numbers = { 10 };
        IncrementNumberArray(numbers);
        Console.WriteLine(numbers[0]);
    }

    static void IncrementNumberArray(int[] numbers)
    {
        numbers[0] += 10;
    }
    static void IncrementNumber(int number)
    {
        number += 10;
    }
}
