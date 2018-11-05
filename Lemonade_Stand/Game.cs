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
                Console.WriteLine($"Today is {day.Name}.");
                day.DisplayWeather();
                playerOne.Lemonade.DecideRecipe();
                playerOne.Inventory.DisplayInventory();
                playerOne.DecideIfBuyingItems();

                RunDay(day);

                runningTotalProfit += day.Profit;
                overallNumberOfCupsSold += day.NumberOfCupsSold;

                UserInterface.DisplayDailyProfit(day.Profit, day.NumberOfCupsSold);
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
            Console.WriteLine("This week's weather forecast is...");

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
            int numberOfCupsSold = 0;
            if (haveAPitcher)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    bool boughtLemonade = customers[i].ChanceToBuy(day, pricePerCup, i);
                    if (boughtLemonade)
                    {
                        playerOne.Inventory.RemoveItems("cup", 1);
                        numberOfCupsSold += 1;

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
                        Console.WriteLine("You are SOLD OUT for today! You ran out of at least one item.");
                        playerOne.Inventory.DisplayInventory();
                        break;
                    }
                }
            }

            double loss = numberOfPitchersMade * playerOne.Lemonade.PriceOfPitcher() + numberOfCupsSold * Cup.price;
            double revenue = numberOfCupsSold * pricePerCup;
            playerOne.Money += revenue - loss;
            day.SaveDay(revenue - loss, numberOfCupsSold);
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
