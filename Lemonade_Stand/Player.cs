using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        public Inventory inventory;
        public Recipe recipe;
        
        public Player()
        {
            this.inventory = new Inventory();
            this.recipe = new Recipe();
        }
    }
    // set recipe and sale price
}
