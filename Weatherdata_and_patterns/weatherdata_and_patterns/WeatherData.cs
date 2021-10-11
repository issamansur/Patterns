using System;
using System.Collections.Generic;

namespace weatherstation_and_patterns
{
    public class WeatherData : IPublisher
    {
        // weather indicators
        private float temperature;
        private float humidity;
        private float pressure;
        // list of subscibers for updating indicators (our displays)
        private static List<ISubscriber> subs;

        // constructor of WD generate new list of subscribers
        public WeatherData()
        {
            subs = new List<ISubscriber>();
        }

        // method for adding a new subscriber in the list
        public void AddSubscriber(ISubscriber sub)
        {
            if (!subs.Contains(sub))
                subs.Add(sub);
            else Console.WriteLine("Такой подписчик уже существует.");
        }

        // method for deleting a subscriber from the list
        public void DeleteSubscriber(ISubscriber sub)
        {
            if (subs.Contains(sub))
                subs.Remove(sub);
            else Console.WriteLine("Такого подписчика не существует.");
        }

        // method for notify all of subscribers about changes
        public void NotifySubscriber()
        {
            foreach (ISubscriber sub in subs)
            {
                ISubscriber sub_item = sub;
                sub_item.Update(temperature, humidity, pressure);
            }
        }


        // methods for getting indicators
        public void GetTemperature(float temperature)
        {
            this.temperature = temperature;
        }

        public void GetHumidity(float humidity)
        {
            this.humidity = humidity;
        }

        public void GetPressure(float pressure)
        {
            this.pressure = pressure;
        }
    }
}
