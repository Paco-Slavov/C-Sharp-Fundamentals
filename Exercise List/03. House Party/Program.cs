List<string> guestList = new List<string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmdArgs = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string name = cmdArgs[0];

    if (cmdArgs.Length == 3)
    {
        if (guestList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }
        guestList.Add(name);
    }
    else if (cmdArgs.Length == 4)
    {
        if (!guestList.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");
            continue;
        }
        guestList.Remove(name);
    }
}
PrintGuestList(guestList);

static void PrintGuestList(List<string> guestList)
{
    foreach (string name in guestList)
    {
        Console.WriteLine(name);
    }
}

//List<string> guestList = new List<string>();

//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    string[] input = Console.ReadLine()
//        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
//    string name = input[0];

//    if (input.Length == 3)
//    {
//        if (guestList.Contains(name))
//        {
//            Console.WriteLine($"{name} is already in the list!");
//            continue;
//        }
//            guestList.Add(name);
//    }
//    else if (input.Length == 4)
//    {
//        if (guestList.Contains(name))
//        {
//            Console.WriteLine($"{name} is not in the list!");
//            continue;
//        }
//            guestList.Remove(name);
//    }
//}

//Console.WriteLine(string.Join(Environment.NewLine, guestList));