string[] words = Console.ReadLine()
    .Split();

Dictionary<string, int> allWords
    = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordToLower = word.ToLower();

    if (!allWords.ContainsKey(wordToLower))
    {
        allWords.Add(wordToLower, 0);
    }
    allWords[wordToLower]++;
}

//foreach (var word in allWords)
//{
//    if (word.Value % 2 != 0)
//    {
//        Console.Write(word.Key + " ");
//    }
//}

var result = allWords
    .Where(x => x.Value % 2 != 0)
    .Select(x => x.Key)
    .ToList();
Console.WriteLine(String.Join(" ", result));



