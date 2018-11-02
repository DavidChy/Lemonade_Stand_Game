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
            Console.WriteLine("At the end of the game, you will see your financial stats. The profit or loss is your score.");
            Console.ReadLine();

        }
        public static void DisplayInventory()
        {
            Console.WriteLine("RULES");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Buy your ingredients.");
            Console.WriteLine("Set your recipe.");
            Console.WriteLine("Set your price.");
            Console.WriteLine("Start Game.");
            Console.WriteLine(".");
        }
    }
}
