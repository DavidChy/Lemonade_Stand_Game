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
            GetDayGame();
        }

        private void GetName()
        {
            
            playerOne = new Player("David Chy", random);
            
            Console.WriteLine("We need to let the kids on the block know who has the best lemonade!");
            Console.WriteLine("Please enter your street name, son. And press [Enter]...");
            playerOne.Name = Console.ReadLine();
            Console.Clear();

        }

        private void GetGameDay()
        {
            Console.WriteLine("PICK NUMBER OF DAYS");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Choose either [7] day or [30] day game.");
            gameDay = Console.ReadLine();
            if(gameDay == "7")
            {
                SevenDayGame();
            }
            else if(gameDay == "30")
            {
                ThirtyDayGame();
            }
            if(gameDay != "7" && gameDay != "30")
            {
                Console.WriteLine("Invalid input. Please enter either [7] or [30].");
                GetGameDay();
            }
        }

        private void SevenDayGame()
        {
            while(playerOne.Store.Day != 8)
            {
                if (playerOne.Store.DayCount == 1)
                {
                    Console.WriteLine();
                    StartDay();
                }
                else if (playerOne.Store.Money >= 0 && playerOne.Store.Inventory.Cups != 0)
                {
                    Console.WriteLine();
                    StartDay();
                }
                else
                {
                    break;
                }
            }
            UserInterface.DisplayEndResults(8, player1, 7);
            RequestNewGame();
        }

        private void ThirtyDayGame()
        {
            while (playerOne.Store.DayCount != 22)
            {
                if (playerOne.Store.DayCount == 1)
                {
                    Console.WriteLine();
                    StartDay();
                }
                else if (playerOne.Store.Money >= 0 && playerOne.Store.Inventory.Cups != 0)
                {
                    Console.WriteLine();
                    StartDay();
                }
                else
                {
                    break;
                }
            }
            
        }
}
