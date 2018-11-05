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

        public bool ChanceToBuy(Day day, double price, int seed)
        {
            Random rand = new Random(seed);
            int chanceToBuy = rand.Next(0, 100);

            int totalChanceWithModifiers = 50
                + ChanceToBuyTemperatureModifer(day.Temperature)
                + ChanceToBuyConditionModifier(day.Condition)
                + ChanceToBuyPriceModifier(price);

            if (chanceToBuy < totalChanceWithModifiers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ChanceToBuyTemperatureModifer(int temperature)
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

        public int ChanceToBuyConditionModifier(string condition)
        {
            switch (condition)
            {
                case "rainy":
                    return -15;
                case "overcast":
                    return -10;
                case "hazy":
                    return -5;
                case "sunny":
                    return 10;
                case "cloudy":
                default:
                    return 0;
            }
        }

        public int ChanceToBuyPriceModifier(double price)
        {
            if (price > 1)
            {
                return -20;
            }
            else if (price > 0.75)
            {
                return -10;
            }
            else if (price > 0.50)
            {
                return -5;
            }
            else if (price > 0.25)
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
