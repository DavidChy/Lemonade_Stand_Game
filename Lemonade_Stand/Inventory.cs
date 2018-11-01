using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {
        private List<Cup> cupsList;
        private List<Ice> iceList;
        private List<Lemon> lemonsList;
        private List<Sugar> sugarList;

        public List<Cup> CupsList { get { return cupsList; } set { cupsList = value; } }
        public List<Ice> IceList { get { return iceList; } set { iceList = value; } }
        public List<Lemon> LemonsList { get { return lemonsList; } set { lemonsList = value; } }
        public List<Sugar> SugarList { get { return sugarList; } set { sugarList = value; } }
        public int Cups { get { return cupsList.Count; } }
        public int Ice { get { return iceList.Count; } }
        public int Lemons { get { return lemonsList.Count; } }
        public int Sugar { get { return sugarList.Count; } }

        public Inventory()
        {
            cupsList = new List<Cup>();
            iceList = new List<Ice>();
            lemonsList = new List<Lemon>();
            sugarList = new List<Sugar>();
        }
    }
}
