string order = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

Orders(order, quantity);

void Orders (string order, int quantity)
{
    double result = 0;
    switch (order)
    {
        case "coffee":
            result = quantity * 1.50;
            break;
        case "water":
            result = quantity * 1.00;
            break;
        case "coke":
            result = quantity * 1.40;
            break;
        case "snacks":
            result = quantity * 2.00;
            break;
        default:
            break;
    }
    Console.WriteLine($"{result:f2}");
}