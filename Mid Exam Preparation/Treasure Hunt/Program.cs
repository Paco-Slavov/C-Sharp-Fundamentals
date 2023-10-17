namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split('|')
                .ToList();

            string command = Console.ReadLine();

            while(command != "Yohoho")
            {
                string[] commandInfo = command.Split();

                if (commandInfo[0] == "Loot")
                {
                    //for (int i = 1; i < commandInfo.Length; i++)
                    //{
                    //    if (!items.Contains(commandInfo[i]))
                    //    {
                    //        items.Insert(0, commandInfo[i]);
                    //    }
                    //}

                    foreach (var item in commandInfo.Skip(1))
                    {
                        if (!items.Contains(item))
                        {
                            items.Insert(0, item);
                        }
                    }
                }
                else if (commandInfo[0] == "Drop")
                {
                    int index = int.Parse(commandInfo[1]);

                    if (index >= 0 && index < items.Count)
                    {
                        string currentElement = items[index];
                        items.RemoveAt(index);
                        items.Add(currentElement);
                    }
                }
                else if (commandInfo[0] == "Steal")
                {
                    List<string> elements = new List<string>();

                    int count = int.Parse(commandInfo[1]);
                    
                    while (count > 0 && items.Count > 0)
                    {
                        string currentElement = items[items.Count - 1];
                        elements.Add(currentElement);
                        items.RemoveAt(items.Count - 1);
                        count--;
                    }

                    elements.Reverse();
                    Console.WriteLine(string.Join(",",elements));
                }
                command = Console.ReadLine();
            }
            if (items.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                //int sum = 0;

                //foreach (var item in items)
                //{
                //    sum += item.Length;
                //}
                int sum = items.Sum(x => x.Length);
                double result = (double)sum / items.Count;
                Console.WriteLine($"Average treasure gain: {result:f2} pirate credits.");
            }
        }
    }
}