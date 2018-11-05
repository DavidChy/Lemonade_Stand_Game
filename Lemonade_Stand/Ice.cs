using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Ice : Commodity
    {
        public static double price = 0.01;

        public Ice() :
            base("ice")
        {
        }
    }
}
