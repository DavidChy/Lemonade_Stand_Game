using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public abstract class Commodity
    {
        public string Name { get; set; }

        public Commodity(string name)
        {
            this.Name = name;
        }
    }
}

