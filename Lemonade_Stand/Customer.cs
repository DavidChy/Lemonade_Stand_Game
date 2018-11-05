using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Customer
    {

        public Customer()
        {
        }

        public bool LuckOfPurchase(Day day, double price, int real)
        {
            Random rand = new Random(real);
            int luckOfPurchase = rand.Next(0, 100);

            int totalLuck = 50
                + LuckOfPurchaseTemperature(day.Temperature)
                + LuckOfPurchaseCondition(day.Condition)
                + LuckOfPurchasePrice(price);

            if (luckOfPurchase < totalLuck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LuckOfPurchaseTemperature(int temperature)
        {
            if (temperature <= 70)
            {
                return -5;
            }
            else if (temperature <= 85)
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }

        public int LuckOfPurchaseCondition(string condition)
        {
            switch (condition)
            {
                case "snow":
                    return -15;
                case "rain":
                    return -10;
                case "windy":
                    return -5;
                case "sunny":
                    return 10;
                case "cloudy":
                default:
                    return 0;
            }
        }

        public int LuckOfPurchasePrice(double price)
        {
            if (price > 2.00)
            {
                return -20;
            }
            else if (price > 1.00)
            {
                return -10;
            }
            else if (price > 0.75)
            {
                return -5;
            }
            else if (price > 0.50)
            {
                return 5;
            }
            else
            {
                return 10;
            }
        }
    }
}
