int plantsCount = int.Parse(Console.ReadLine());

var plantAndRarity = new Dictionary<string, int>();

for (int i = 0; i < plantsCount; i++)
{
    string[] input = Console.ReadLine().Split("<->");
    string plantName = input[0];
    int plantRarity = int.Parse(input[1]);

    plantAndRarity.Add(plantName, plantRarity);
}

var plantAndRating = new Dictionary<string, List<int>>();

foreach (var plant in plantAndRarity)
{
    List<int> ratings = new List<int>();
    plantAndRating.Add(plant.Key, ratings);
}

string command = Console.ReadLine();

while (command != "Exhibition")
{
    string[] commandArray = command.Split(" ");

    if (command.Contains("Rate"))
    {
        string plantName = commandArray[1];
        int plantRating = int.Parse(commandArray[3]);

        if (plantAndRarity.ContainsKey(plantName))
        {
            plantAndRating[plantName].Add(plantRating);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command.Contains("Update"))
    {
        string plantName = commandArray[1];
        int newRarity = int.Parse(commandArray[3]);

        if (plantAndRarity.ContainsKey(plantName))
        {
            plantAndRarity[plantName] = newRarity;
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    else if (command.Contains("Reset"))
    {
        string plantName = commandArray[1];

        if (plantAndRating.ContainsKey(plantName))
        {
            plantAndRating[plantName].Clear();
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

Console.WriteLine("Plants for the exhibition:");

foreach (var currentPlant in plantAndRarity)
{
    int plantAndRatingsSum = plantAndRating[currentPlant.Key].Sum();
    int plantRatingsCount = plantAndRating[currentPlant.Key].Count();

    if (plantRatingsCount == 0)
    {
        plantAndRatingsSum = 0;
        Console.WriteLine($"- {currentPlant.Key}; Rarity: {currentPlant.Value}; Rating: {0:f2}");
    }
    else
    {
        double averageRate = plantAndRatingsSum / (double)plantRatingsCount;
        Console.WriteLine($"- {currentPlant.Key}; Rarity: {currentPlant.Value}; Rating: {averageRate:f2}");
    }
}