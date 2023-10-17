string stops = Console.ReadLine();
string command = Console.ReadLine();

while (command != "Travel")
{
    string[] commands = command.Split(":");
    string instruction = commands.First();

    if (instruction == "Add Stop")
    {
        int index = int.Parse(commands[1]);
        string stop = commands.Last();

        if (index >= 0 && index < stops.Length)
        {
            stops = stops.Insert(index, stop);
        }
    }
    else if (instruction == "Remove stop")
    {
        int startIndex = int.Parse(commands[1]);
        int endIndex = int.Parse(commands[2]);

        if (startIndex >= 0 && startIndex <= stops.Length
            && endIndex >= 0 && endIndex <= stops.Length)
        {
            stops = stops.Remove(startIndex, endIndex - startIndex + 1);
        }
    }
    else if (instruction == "Switch")
    {
        string oldString = commands[1];
        string newString = commands[2];

        if (stops.Contains(oldString))
        {
            stops = stops.Replace (oldString, newString);
        }
    }
    Console.WriteLine(stops);
    command = Console.ReadLine();
}
Console.WriteLine($"Ready for world tour! Planned stops: {stops}");