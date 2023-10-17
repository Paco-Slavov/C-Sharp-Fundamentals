//using System;

//namespace GamingStore
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double budget = double.Parse(Console.ReadLine());
//            string game = string.Empty;
//            double moneySpend = 0;
//            while ((game = Console.ReadLine()) != "Game Time")
//            {


//                if (game == "OutFall 4")
//                {
//                    if (budget >= 39.99)
//                    {
//                        budget -= 39.99;
//                        moneySpend += 39.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }

//                }
//                else if (game == "CS: OG")
//                {
//                    if (budget >= 15.99)
//                    {
//                        budget -= 15.99;
//                        moneySpend += 15.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }
//                }
//                else if (game == "Zplinter Zell")
//                {
//                    if (budget >= 19.99)
//                    {
//                        budget -= 19.99;
//                        moneySpend += 19.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }
//                }
//                else if (game == "RoverWatch")
//                {
//                    if (budget >= 29.99)
//                    {
//                        budget -= 29.99;
//                        moneySpend += 29.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }
//                }
//                else if (game == "Honored 2")
//                {
//                    if (budget >= 59.99)
//                    {
//                        budget -= 59.99;
//                        moneySpend += 59.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }
//                }
//                else if (game == "RoverWatch Origins Edition")
//                {
//                    if (budget >= 39.99)
//                    {
//                        budget -= 39.99;
//                        moneySpend += 39.99;
//                        Console.WriteLine($"Bought {game}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("Too Expensive"); continue;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Not Found");
//                }
//                if (budget <= 0)
//                {
//                    Console.WriteLine("Out of money!"); return;
//                }
//            }
//            Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${budget:f2}");
//        }
//    }
//}

using System;

namespace GamingStore

{
    class program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double gamePrice = 0;
            double balance = budget;
            double totalMoney = 0;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: GO":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "Rover Watch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (gamePrice > budget)
                {
                    Console.WriteLine("Too Expensive");
                    gamePrice = 0;
                    game = Console.ReadLine();
                    continue;
                }

                balance -= gamePrice;

                if (budget >= 0)
                {
                    Console.WriteLine($"Bought {game}");
                }

                if (budget < 0)
                {
                    Console.WriteLine("Out of money!");
                }

                game = Console.ReadLine();
            }

            if (budget > 0)
            {
                Console.WriteLine($"Total spent: ${(budget - balance):F2}. Remaining: ${(balance):F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}