List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> result = new List<int>();

foreach (var item in numbers)
{
    if (item >= 0)
    {
        result.Add(item);
    }
}
numbers.Reverse();

Console.WriteLine(string.Join(" ", result));