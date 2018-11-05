using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Cup : Commodity
    {
        public static double price = 0.05;

        public Cup() :
            base("cup")
        {
        }
    }
}

