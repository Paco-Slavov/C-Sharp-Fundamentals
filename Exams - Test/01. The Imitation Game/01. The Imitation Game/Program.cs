string input = Console.ReadLine();
string command = Console.ReadLine();

while (command != "Decode")
{
    string[] comm = command
        .Split('|', StringSplitOptions.RemoveEmptyEntries);

    if (comm[0] == "Move")
    {
        int n = int.Parse(comm[1]);

        string substring = input.Substring(0, n);
        input = input.Remove(0, n);
        input += substring;
    }
    else if (comm[0] == "Insert")
    {
        int index = int.Parse(comm[1]);
        string value = comm[2];
        input = input.Insert(index, value);
    }
    else if (comm[0] == "ChangeAll")
    {
        string substring = comm[1];
        string replacement = comm[2];

        input = input.Replace(substring, replacement);
    }
    command = Console.ReadLine();
}

Console.WriteLine($"The decrypted message is: {input}");