int countOfOrders = int.Parse(Console.ReadLine());
double pricePerCapsule = 0;
int days = 0;
int capsulesCount = 0;

double totalPrice = 0;

for (int i = 0; i < countOfOrders; i++)
{
    pricePerCapsule = double.Parse(Console.ReadLine());
    days = int.Parse(Console.ReadLine());
    capsulesCount = int.Parse(Console.ReadLine());

    double temp = 0;

    temp += ((days * capsulesCount) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${temp:f2}");

    totalPrice += temp;
}
Console.WriteLine($"Total: ${totalPrice:f2}");