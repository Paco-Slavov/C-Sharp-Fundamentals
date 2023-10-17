string input = Console.ReadLine();
string encryptedString = string.Empty;

foreach (char currChar in input)
{
    int currPosition = currChar;
    currPosition += 3;
    encryptedString += (char)currPosition;
}
Console.WriteLine(encryptedString);