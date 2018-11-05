using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public static class UserInterface
    {
        public static void ShowWelcome()
        {
            Console.WriteLine("LEMONADE STAND GAME");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the Lemonade Stand Game! The Lemonade Market is booming right now! Great time to get in!");
            Console.WriteLine("How are you doing today? Guess what? No one cares. We're here to make some filthy money!");
            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadLine();
            Console.Clear();

        }
        public static void ShowRules(Player playerOne)
        {
            Console.WriteLine("RULES");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Yo! My homie {playerOne.Name}! Your objective is to make as much money as possible by selling ''lemonade'' at your new stand!");
            Console.WriteLine("1. Pick a 7 day or 30 day game.");
            Console.WriteLine("2. Buy cups, ice, lemons, and sugar at the store to restock your inventory. You start with $100 and zero inventory.");
            Console.WriteLine("3. Make the recipe.");
            Console.WriteLine("4. Set the price.");
            Console.WriteLine("5. Start slanging some lemonade! \n\n");
            Console.WriteLine("TIPS");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Price and recipe should reflect on the weather and customer buying habits.");
            Console.WriteLine("Use the preset recipe and price to get a feel of it, then vary from there.");
            Console.WriteLine("At the end of the game, you will see your financial stats. The profit or loss is your score. \n\n");
            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        public static string GetUserItem()
        {
            string itemName = string.Empty;
            do
            {
                Console.WriteLine("Please choose an item: 'cup', 'ice', 'lemon', or 'sugar'.");
                string input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "cup":
                    case "ice":
                    case "lemon":
                    case "sugar":
                        itemName = input;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input.");
                        break;
                }
            } while (itemName == string.Empty);

            return itemName;
        }

        public static string GetUserYesOrNo(string prompt)
        {
            string response = string.Empty;

            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "no")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Please enter a valid input.");
                return GetUserYesOrNo(prompt);
            }
        }

        public static int GetUserPositiveNumber(string prompt)
        {
            int positiveNumber = 0;
            Console.WriteLine(prompt);
            try
            {
                positiveNumber = int.Parse(Console.ReadLine());
                if (positiveNumber > 0)
                {
                    return positiveNumber;
                }
                else
                {
                    Console.WriteLine("Please enter a number above 0.");
                    return GetUserPositiveNumber(prompt);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number above 0.");
                return GetUserPositiveNumber(prompt);
            }
        }

        public static double GetPricePerCup()
        {
            Console.WriteLine("Set the price each cup of lemonade. Please enter a price above $0.00.");
            try
            {
                double pricePerCup = Math.Round(double.Parse(Console.ReadLine()), 2);
                if (pricePerCup > 0)
                {
                    return pricePerCup;
                }
                else
                {
                    Console.WriteLine("Please enter a price above $0.00.");
                    return GetPricePerCup();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a price above $0.00.");
                return GetPricePerCup();
            }
        }

        public static void DisplayDailyProfit(double profit, int numberOfCupsSold)
        {
            Console.WriteLine($"Today, you made ${profit} and sold {numberOfCupsSold} cups.");
        }

        public static void DisplayTotalProfit(double runningTotalProfit, int overallNumberOfCupsSold)
        {
            Console.WriteLine($"In the entire 7 days, you made ${runningTotalProfit} and your stand sold {overallNumberOfCupsSold} cups of lemonade.");
        }
    }
}
