using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Lemonade
    {
        public int numberOfLemons;
        public int numberOfIce;
        public int numberOfSugar;

        public Lemonade()
        {
            this.numberOfLemons = 4;
            this.numberOfSugar = 4;
            this.numberOfIce = 20;

        }

        public void DecideRecipe()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine($"Your current recipe needs {this.numberOfLemons} lemons, {this.numberOfSugar} sugar, and {this.numberOfIce} ice.\n" +
                    "Would you like to use this recipe or create a new recipe? Please enter 'same' or 'new'.");
                string input = Console.ReadLine();

                if (input == "new")
                {
                    this.numberOfLemons = GetItemsForRecipe("lemons");
                    this.numberOfSugar = GetItemsForRecipe("sugar");
                    this.numberOfIce = GetItemsForRecipe("ice");

                    isValid = true;
                }
                else if (input == "same")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Your input was invalid. Please enter a valid response.");
                }
            } while (!isValid);
        }

        public int GetItemsForRecipe(string itemName)
        {
            int numberOfItem = 0;
            do
            {
                try
                {
                    Console.WriteLine($"How many {itemName} would you like to use for a pitcher? Please enter a value greater than 0.");
                    numberOfItem = int.Parse(Console.ReadLine());

                    if (numberOfItem <= 0)
                    {
                        Console.WriteLine("Please enter a number greater than 0.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            } while (numberOfItem <= 0);

            return numberOfItem;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Your current recipe requires {this.numberOfLemons} lemons, {this.numberOfSugar} sugar, and {this.numberOfIce} ice for each pitcher of lemonade.");
        }

        public double PriceOfPitcher()
        {
            return numberOfLemons * Lemon.price + numberOfSugar * Sugar.price + numberOfIce * Ice.price;
        }
    }
}
