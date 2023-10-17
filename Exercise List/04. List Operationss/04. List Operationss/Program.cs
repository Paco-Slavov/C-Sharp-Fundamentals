List<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command;

while ((command = Console.ReadLine()) != "End")
{
    string[] cmdArgs = command
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArgs[0];

    if (cmdType == "Add")
    {
        int numberToAdd = int.Parse(cmdArgs[1]);
        numbers.Add(numberToAdd);
    }
    else if (cmdType == "Insert")
    {
        int number = int.Parse(cmdArgs[1]);
        int index = int.Parse(cmdArgs[2]);

        if (IsIndexInvalid(numbers, index))
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        numbers.Insert(index, number);
    }
    else if (cmdType == "Remove")
    {
        int removeIndex = int.Parse(cmdArgs[1]);

        if (IsIndexInvalid(numbers, removeIndex))
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        numbers.RemoveAt(removeIndex);
    }
    else if (cmdType == "Shift")
    {
        string direction = cmdArgs[1];
        int count = int.Parse(cmdArgs[2]);

        if (direction == "left")
        {
            ShiftListleft(numbers, count);
        }
        else
        {
            ShiftListright(numbers, count);
        }
    }
}

Console.WriteLine(string.Join(' ', numbers));

static bool IsIndexInvalid(List<int> numbers, int index)
=> index < 0 || index >= numbers.Count;

static void ShiftListleft(List<int> numbers, int count)
{
    for (int i = 0; i < count; i++)
    {
        int firstNumber = numbers[0];
        numbers.RemoveAt(0);
        numbers.Add(firstNumber);
    }
}

static void ShiftListright(List<int> numbers, int count)
{
    for (int i = 0; i < count; i++)
    {
        int lastNumber = numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Insert(0, lastNumber);
    }
}