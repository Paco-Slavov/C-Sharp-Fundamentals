using System;

Dictionary<string, double[]> orders =
    new Dictionary<string, double[]>();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] cmdArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string product = cmdArg[0];
    double price = double.Parse(cmdArg[1]);
    double quantity = double.Parse(cmdArg[2]);

    if (!orders.ContainsKey(product))
    {
        orders[product] = new double[2] { price , quantity};
    }
    else
    {
        orders[product][0] = price;
        orders[product][1] += quantity;
    }

    input = Console.ReadLine();
}

foreach (var kvp in orders)
{
    double totalPrice = kvp.Value[0] * kvp.Value[1];

    Console.WriteLine($"{kvp.Key} -> {totalPrice:f2}");
}