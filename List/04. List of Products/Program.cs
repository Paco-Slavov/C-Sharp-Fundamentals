int n = int.Parse(Console.ReadLine());

List<string> products = new List<string>();

for (int i = 0; i < n; i++)
{
    string currentProduct = Console.ReadLine();
    products.Add(currentProduct);
}

products.Sort();

for (int j = 0; j < products.Count; j++)
{
    Console.WriteLine($"{j + 1}.{products[j]}");
}
Console.WriteLine(products);