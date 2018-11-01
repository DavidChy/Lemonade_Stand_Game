using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public Player player1;
        public Random random;

        public void RunGame()
        {
            random = new Random();
            UserInterface.ShowWelcome();
            GetName();
            UserInterface.ShowRules(player1);
            //GetMenu();
        }

        private void GetName()
        {
            
            player1 = new Player("David Chy", random);
            
            Console.WriteLine("We need to let the kids on the block know who has the best lemonade!");
            Console.WriteLine("Please enter your street name, son. And press [Enter]...");
            player1.Name = Console.ReadLine();
            Console.Clear();

        }

    }
}
