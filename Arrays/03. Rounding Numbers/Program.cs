//using System.Globalization;

//double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
//int[] roundedNums = new int[inputNumbers.Length];
//for (int i = 0; i < inputNumbers.Length; i++)
//{
//    roundedNums[i] = (int)Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero);
//}
//Console.WriteLine(roundedNums);
//Console.WriteLine(roundedNums);

//double[] inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

//for (int i = 0; i < inputNumbers.Length; i++)
//{
//    Console.WriteLine($"{inputNumbers[i]} => {Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero)}");
//}

double[] array = Console.ReadLine()
    .Split(' ')
    .Select(double.Parse)
    .ToArray();

foreach (double number in array)
{
    int rounded = (int)Math.Round(number, MidpointRounding.AwayFromZero);
    Console.WriteLine("{0} => {1}", number, rounded);
}