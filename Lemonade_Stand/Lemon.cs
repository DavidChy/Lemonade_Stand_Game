using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Lemon : Commodity
    {
        public static double price = 0.25;

        public Lemon() :
            base("lemon")
        {
        }
    }
}
