using System;
using weatherstation_and_patterns.Displays;

namespace weatherstation_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add WeatherData and Displays
            WeatherData data = new WeatherData();
            CurrentDisplay d1 = new CurrentDisplay(data);
            StatisticsDisplay d2 = new StatisticsDisplay(data);

            // for each day in these 7 days adding indicators(10 y.e.)
            // for each day in these 7 days must give result (current: 10, average: 10*7 / 7)
            for (int i=0; i < 7; i++)
            {
                data.GetTemperature(10);
                data.GetHumidity(10);
                data.GetPressure(10);
                data.NotifySubscriber();
                Console.WriteLine();
            }

            //for 8th day add indicators(45 y.e)
            // must give result (current: 45, average: (10*6+45)/7 = 105 / 7 = 15
            data.GetTemperature(45);
            data.GetHumidity(45);
            data.GetPressure(45);
            data.NotifySubscriber();
        }
    }
}