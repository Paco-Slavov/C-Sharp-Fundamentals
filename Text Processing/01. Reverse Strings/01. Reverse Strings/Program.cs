string input = Console.ReadLine();

while (input != "end")
{
    char[] reverseWord = input.Reverse().ToArray();

    Console.WriteLine($"{input} = {string.Join("", reverseWord)}");

    input = Console.ReadLine();
}