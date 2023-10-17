Dictionary<string, string> parking =
    new Dictionary<string, string>();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string command = cmdArg[0];
    string userName = cmdArg[1];

    if (command == "register")
    {
        string plateNumber = cmdArg[2];

        if (parking.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
        }

        else
        {
            parking[userName] = plateNumber;

            Console.WriteLine($"{userName} registered {plateNumber} successfully");
        }
    }

    else if (command == "unregister")
    {
        if (!parking.ContainsKey(userName))
        {
            Console.WriteLine($"ERROR: user {userName} not found");
        }

        else
        {
            parking.Remove(userName);
            Console.WriteLine($"{userName} unregistered successfully");
        }
    }
}

foreach (var kvp in parking)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}