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
            UserInterface.DisplayRules(player1);
            GetName();
        }

        private void GetName()
        {
            
            player1 = new Player("David Chy", random);
            Console.WriteLine("We need to let the kids on the block know who has the best lemonade!");
            Console.WriteLine("What's your street name: ");
            player1.Name = Console.ReadLine();
            
        }

    }
}
