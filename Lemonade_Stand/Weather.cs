using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {
        public List<string> conditions = new List<string>() { "sunny", "hazy", "cloudy", "overcast", "rainy" };
        private Random Random { get; set; }

        public Weather()
        {
            this.Random = new Random();
        }

        public string CreateDailyCondition()
        {
            int index = this.Random.Next(conditions.Count);
            string condition = conditions[index];

            return condition;
        }

        public int CreateDailyTemperature()
        {
            int dailyTemperature = this.Random.Next(50, 100);

            return dailyTemperature;
        }
    }
}
