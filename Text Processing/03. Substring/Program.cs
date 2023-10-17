string wordsToRemove = Console.ReadLine();
string words = Console.ReadLine();

while (words.Contains(wordsToRemove))
{
    int index = words.IndexOf(wordsToRemove);
    words = words.Remove(index, wordsToRemove.Length);
}

Console.WriteLine(words);