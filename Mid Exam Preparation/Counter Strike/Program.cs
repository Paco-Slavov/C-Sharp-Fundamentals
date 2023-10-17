namespace Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int battlesWon = 0;
            bool hasEnoughEnergy = true;
            

            while (command != "End of battle")
            {
                int distance = int.Parse(command);

                if (energy - distance < 0)
                {
                    hasEnoughEnergy = false;
                    break;
                }
                energy -= distance;
                battlesWon++;

                if (battlesWon % 3 == 0)
                {
                    energy += battlesWon;
                }
                command = Console.ReadLine();
            }
            if (hasEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Not enough Energy! Game ends with {battlesWon} battles and {energy} energy");
            }
        }
    }
}