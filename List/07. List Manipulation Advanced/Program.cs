List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string command = Console.ReadLine();

while (command != "end")
{
    command = Console.ReadLine();
    string[] commandInfo = command.Split();
    Console.WriteLine(string.Join(" ", numbers));

    if (commandInfo[0] == "Add")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Add(number);
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandInfo[0] == "Remove")
    {
        int number = int.Parse(commandInfo[1]);
        numbers.Remove(number);
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandInfo[0] == "RemoveAt")
    {
        int index = int.Parse(commandInfo[1]);
        numbers.RemoveAt(index);
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandInfo[0] == "Insert")
    {
        int number = int.Parse(commandInfo[1]);
        int index = int.Parse(commandInfo[2]);

        numbers.Insert(index, number);
        Console.WriteLine(string.Join(" ", numbers));
    }
    else if (commandInfo[0] == "Contains")
    {
        int number = int.Parse(commandInfo[1]);

        if (commandInfo[0] == "PrintEven")
        {
            Console.WriteLine(Yes);
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));