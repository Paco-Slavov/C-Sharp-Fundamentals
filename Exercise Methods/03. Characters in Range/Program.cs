﻿using System.Runtime.ExceptionServices;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            if (first > second)
            {
                char temp = first;
                first = second;
                second = temp;
            }
            for (int i = first + 1; i < second; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}