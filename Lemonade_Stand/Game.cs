using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public Player playerOne;
        public Random random;

        public void RunGame()
        {
            random = new Random();
            UserInterface.ShowWelcome();
            GetName();
            UserInterface.ShowRules(playerOne);
            PickDayGame();
        }

        private void GetName()
        {
            
            playerOne = new Player("David Chy", random);
            
            Console.WriteLine("We need to let the kids on the block know who has the best lemonade!");
            Console.WriteLine("Please enter your street name, son. And press [Enter]...");
            playerOne.Name = Console.ReadLine();
            Console.Clear();

        }

        private void PickDayGame()
        {
            Console.WriteLine("PICK NUMBER OF DAYS");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Choose either [7] day or [30] day game.");
            getGame = Console.ReadLine();
            if(getGame == "7")
            {
                SevenDayGame();
            }
            else if(getGame == "30")
            {
                ThirtyDayGame();
            }
            if(getGame != "7" && getGame != "30")
            {
                Console.WriteLine("Invalid input. Please enter either [7] or [30].");
                PickDayGame();
            }
        }

        private void SevenDayGame()
        {
            while(playerOne.Store.Day != 8)
            {
                if (player1.Store.DaysOpen == 1)
                {
                    Console.WriteLine();
                    RunOneDay();
                }
                else if (player1.Store.Money >= 0 && player1.Store.Inventory.Cups != 0)
                {
                    Console.WriteLine();
                    RunOneDay();
                }
                else
                {
                    break;
                }
            }
            UserInterface.DisplayEndResults(8, player1, 7);
            RequestNewGame();
        }

    }
}
