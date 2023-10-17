int lines = int.Parse(Console.ReadLine());
long leftSum = 0;
long rightSum = 0;
for (int a = 0; a < lines; a++)
{
    string input = Console.ReadLine();
    long[] currentLine = input.Split().Select(long.Parse).ToArray();
    long left = currentLine[0];
    long right = currentLine[1];
    string left2 = left.ToString();
    string right2 = right.ToString();
    for (int b = 0; b <= left2.Length - 1; b++)
    {
        if (left2[b] >= 48 && left2[b] <= 57)
        {
            leftSum += left2[b] - 48;
        }
    }
    for (int c = 0; c <= right2.Length - 1; c++)
    {
        if (right2[c] >= 48 && right2[c] <= 57)
        {
            rightSum += right2[c] - 48;
        }
    }
    if (left > right)
    {
        Console.WriteLine(leftSum);
    }
    else
    {
        Console.WriteLine(rightSum);
    }
    leftSum = 0;
    rightSum = 0;
    }