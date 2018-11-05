using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Inventory
    {

        public List<Lemon> lemons = new List<Lemon>();
        public List<Ice> ice = new List<Ice>();
        public List<Sugar> sugar = new List<Sugar>();
        public List<Cup> cups = new List<Cup>();

        public Inventory()
        {
        }

        public void AddItems(List<Commodity> items)
        {
            foreach (Commodity item in items)
            {
                switch (item.Name)
                {
                    case "lemon":
                        lemons.Add((Lemon)item);
                        break;
                    case "sugar":
                        sugar.Add((Sugar)item);
                        break;
                    case "ice":
                        ice.Add((Ice)item);
                        break;
                    case "cup":
                        cups.Add((Cup)item);
                        break;
                }
            }

            Console.WriteLine($"You have increased your {items[0].Name} inventory by {items.Count}.");
            DisplayInventory();
        }

        public void RemoveItems(string itemName, int numberOfItems)
        {
            switch (itemName)
            {
                case "lemon":
                    lemons.RemoveRange(0, numberOfItems);
                    break;
                case "sugar":
                    sugar.RemoveRange(0, numberOfItems);
                    break;
                case "ice":
                    ice.RemoveRange(0, numberOfItems);
                    break;
                case "cup":
                    cups.RemoveRange(0, numberOfItems);
                    break;
            }
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"You currently have {lemons.Count} lemons, {sugar.Count} sugar, {ice.Count} ice, and {cups.Count} cups.");
        }
        //private List<Cup> cupsList;
        //private List<Ice> iceList;
        //private List<Lemon> lemonsList;
        //private List<Sugar> sugarList;

        //public List<Cup> CupsList { get { return cupsList; } set { cupsList = value; } }
        //public List<Ice> IceList { get { return iceList; } set { iceList = value; } }
        //public List<Lemon> LemonsList { get { return lemonsList; } set { lemonsList = value; } }
        //public List<Sugar> SugarList { get { return sugarList; } set { sugarList = value; } }
        //public int Cups { get { return cupsList.Count; } }
        //public int Ice { get { return iceList.Count; } }
        //public int Lemons { get { return lemonsList.Count; } }
        //public int Sugar { get { return sugarList.Count; } }

        //public Inventory()
        //{
        //    cupsList = new List<Cup>();
        //    iceList = new List<Ice>();
        //    lemonsList = new List<Lemon>();
        //    sugarList = new List<Sugar>();
        //}
    }
}
