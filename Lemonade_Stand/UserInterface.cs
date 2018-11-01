using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public static class UserInterface
    {
        public static void DisplayRules(Player player1)
        {
            Console.WriteLine("LEMONADE STAND GAME");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the Lemonade Stand Game! The Lemonade Market is booming right now! Great time to get in!");
            Console.WriteLine("Your primary objective is to make as much money as possible by selling lemonade at your new stand.");
            Console.WriteLine("Play 7 day or 30 day game.");
            Console.WriteLine("Start with $100 and zero inventory.");
            Console.WriteLine("Buy cups, lemons, sugar and ice at the store to restock your inventory.");
            Console.WriteLine("Set the price and recipe, which should reflect on the weather and customer buying habits.");
            Console.WriteLine("Use the preset recipe to get a feel of it, then vary from there.");
            Console.WriteLine("Start slanging some lemonade!");
            Console.WriteLine("At the end of the game, you will see your financial stats. The profit or loss is your score.");
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
