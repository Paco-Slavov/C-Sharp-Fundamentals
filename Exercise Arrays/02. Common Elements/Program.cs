string[] firstArray = Console.ReadLine().Split();
string[] secondtArray = Console.ReadLine().Split();

for (int i = 0; i < secondtArray.Length; i++)
{
    string currentElement = secondtArray[i];
    
    for (int j = 0; j < firstArray.Length; j++)
    {
        if (firstArray.Contains(currentElement))
        {
            Console.Write(currentElement + " ");
        }
    }
}