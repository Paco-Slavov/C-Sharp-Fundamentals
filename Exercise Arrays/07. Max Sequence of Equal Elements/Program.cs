int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestSequenceStartIndex = 0;
int longestSequenceLength = 0;

for (int i = 0; i < numbers.Length; i++)
{
    int currentSequenceStartIndex = i;
    int currentSequenceLength = 1;

    while (i < numbers.Length - 1&& numbers[i + 1] == numbers[i])
    {
        currentSequenceLength ++;
        i++;
    }

    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceStartIndex = currentSequenceStartIndex;
    }
}

for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLength; i++)
{
    Console.Write($"{numbers[i]} ");
}