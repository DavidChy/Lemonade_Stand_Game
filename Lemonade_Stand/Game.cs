using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {
        public Player playerOne;
        public Random random;
        public List<Day> days = new List<Day>();
        public Weather weather;
        private List<string> daysOfTheWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public void RunGame()
        {
            random = new Random();
            UserInterface.ShowWelcome();
            GetName();
            UserInterface.ShowRules(playerOne);
            //GetDayGame();
            GetWeatherForecast();

            double runningTotalProfit = 0;
            int overallNumberOfCupsSold = 0;
            foreach (Day day in days)
            {
                Console.WriteLine($"Today is {day.Name}. \n ");
                day.DisplayWeather();
                playerOne.Lemonade.DecideRecipe();
                playerOne.Inventory.DisplayInventory();
                playerOne.DecideIfBuyingItems();

                RunDay(day);

                runningTotalProfit += day.Profit;
                overallNumberOfCupsSold += day.CupsSold;

                UserInterface.DisplayDailyProfit(day.Profit, day.CupsSold);
            }

            UserInterface.DisplayTotalProfit(runningTotalProfit, overallNumberOfCupsSold);
            Console.ReadLine();
        }
        public Game()
        {
            this.weather = new Weather();

            foreach (string dayName in daysOfTheWeek)
            {
                days.Add(new Day(dayName, this.weather));
            }
        }

        private void GetName()
        {

            playerOne = new Player("David Chy");

            Console.WriteLine("We need to let the kids on the block know who has the best lemonade!");
            Console.WriteLine("Please enter your street name, son. And press [Enter]...");
            playerOne.Name = Console.ReadLine();
            Console.Clear();

        }

        public void GetWeatherForecast()
        {
            Console.WriteLine("This next 7 day weather forecast is... \n");

            foreach (Day day in days)
            {
                day.DisplayWeather();
            }
        }

        private void RunDay(Day day)
        {
            double pricePerCup = UserInterface.GetPricePerCup();
            List<Customer> customers = CreateCustomers();

            int numberOfPitchersMade = 0;
            bool haveAPitcher = playerOne.MakeAPitcher();

            if (haveAPitcher)
            {
                numberOfPitchersMade += 1;
            }

            int remainingCupsInPitcher = 10;
            int cupsSold = 0;
            if (haveAPitcher)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    bool boughtLemonade = customers[i].LuckOfPurchase(day, pricePerCup, i);
                    if (boughtLemonade)
                    {
                        playerOne.Inventory.RemoveItems("cup", 1);
                        cupsSold += 1;

                        remainingCupsInPitcher -= 1;
                        if (remainingCupsInPitcher == 0)
                        {
                            haveAPitcher = playerOne.MakeAPitcher();
                            if (haveAPitcher)
                            {
                                numberOfPitchersMade += 1;
                                remainingCupsInPitcher = 10;
                            }
                        }
                    }

                    if (!haveAPitcher || playerOne.Inventory.cups.Count == 0)
                    {
                        Console.WriteLine("You are SOLD OUT at least one item for today! Or you got robbed. \n");
                        playerOne.Inventory.DisplayInventory();
                        break;
                    }
                }
            }

            double loss = numberOfPitchersMade * playerOne.Lemonade.PriceOfPitcher() + cupsSold * Cup.price;
            double revenue = cupsSold * pricePerCup;
            playerOne.Money += revenue - loss;
            day.SaveDay(revenue - loss, cupsSold);
        }

        private List<Customer> CreateCustomers()
        {
            Random random = new Random();
            int numberOfDayCustomers = random.Next(50, 100);

            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < numberOfDayCustomers; i++)
            {
                customers.Add(new Customer());
            }

            return customers;
        }

        
    }
}
