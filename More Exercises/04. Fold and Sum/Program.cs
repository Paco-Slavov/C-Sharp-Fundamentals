int[] array = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int k = array.Length / 4;
int[] newArray = new int[2 * k];

for (int i = 0; i < k; i++)
{
    newArray[i] = array[k - (i + 1)] + array[k + i];
    newArray[newArray.Length - 1 - i] = array[newArray.Length - 1 - i + k] + array[(newArray.Length - 1 - i) + (k + 2 * i + 1)];
}
Console.WriteLine(string.Join(" ", newArray));