using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Sugar : Commodity
    {
        public static double price = 0.15;

        public Sugar() :
            base("sugar")
        {
        }
    }
}
