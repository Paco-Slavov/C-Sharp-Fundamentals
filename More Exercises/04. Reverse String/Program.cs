﻿string input = Console.ReadLine();
string reverse = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    reverse += input[i];
}
Console.WriteLine(reverse);