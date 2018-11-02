using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {
        private Inventory inventory;
        private Random random;
        private Player playerOne;
        private double money;
        private int daysCount;

        public Store(Random Random, Player Player1)
        {
            random = Random;
            inventory = new Inventory();
            money = 500;
            daysCount = 1;
            playerOne = Player1;
        }
    }
}
