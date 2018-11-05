using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
    {
        public Inventory Inventory { get; set; }
        public Lemonade Lemonade { get; set; }
        public double Money { get; set; }
        public string Name { get; set; }

        public Player(string playerName)
        {
            this.Name = playerName;
            this.Inventory = new Inventory();
            this.Lemonade = new Lemonade();
            this.Money = 50.00;
        }

        public void DecideIfBuyingItems()
        {
            string prompt = $"You now have ${Money}. Do you want to purchase any ingredients? Please select 'yes' or 'no'.";
            string response = UserInterface.GetUserYesOrNo(prompt);
            if (response == "yes")
            {
                string item = UserInterface.GetUserItem();
                BuyItem(item);
            }
        }

        public void BuyItem(string itemName)
        {
            double price = 0;
            Console.WriteLine($"Prices: ${Lemon.price} per lemon, ${Sugar.price} per sugar, ${Ice.price} per ice, ${Cup.price} per cup.");

            string prompt = $"How many items would you like to purchase? Please enter a number greater than or equal to 0.";
            int numberOfItems = UserInterface.GetUserPositiveNumber(prompt);


            List<Commodity> items = new List<Commodity>();
            for (int i = 0; i < numberOfItems; ++i)
            {
                switch (itemName)
                {
                    case "cup":
                        price = Cup.price;
                        items.Add(new Cup());
                        break;
                    case "ice":
                        price = Ice.price;
                        items.Add(new Ice());
                        break;
                    case "lemon":
                        price = Lemon.price;
                        items.Add(new Lemon());
                        break;
                    case "sugar":
                        price = Sugar.price;
                        items.Add(new Sugar());
                        break;
                }
            }

            if (price * numberOfItems > Money)
            {
                Console.WriteLine($"You do not have enough money to buy {numberOfItems} {itemName}. It costs ${price * numberOfItems} and you have ${Money}");
            }
            else
            {
                Money -= price * numberOfItems;
                Console.WriteLine($"You have ${Money} after your purchase.");

                Inventory.AddItems(items);
            }

            DecideIfBuyingItems();
        }

        public bool MakeAPitcher()
        {
            if (Lemonade.numberOfLemons <= Inventory.lemons.Count
                && Lemonade.numberOfIce <= Inventory.ice.Count
                && Lemonade.numberOfSugar <= Inventory.sugar.Count
                && Inventory.cups.Count > 0)
            {
                Inventory.RemoveItems("lemon", Lemonade.numberOfLemons);
                Inventory.RemoveItems("sugar", Lemonade.numberOfSugar);
                Inventory.RemoveItems("ice", Lemonade.numberOfIce);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
