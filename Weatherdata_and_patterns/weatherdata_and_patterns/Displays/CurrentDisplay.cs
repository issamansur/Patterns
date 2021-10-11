using System;
using System.Collections.Generic;
using System.Text;

namespace weatherstation_and_patterns.Displays
{
    public class CurrentDisplay : ISubscriber, IDisplay
    {
        // weather indicators
        private float temperature;
        private float humidity;
        private float pressure;
        // list of subscibers of updating indicators (our displays)
        private IPublisher sub_list;

        // constructor for CD adding itself (display)
        // to list of subscribers (AUTOMATICALLY)
        public CurrentDisplay(IPublisher sub_list)
        {
            this.sub_list = sub_list;
            sub_list.AddSubscriber(this);
        }

        // method for updating the indicators 
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            // Display indicators right after updating
            Display();
        }

        // method for displaying
        public void Display()
        {
            Console.WriteLine("Current indicators:");
            Console.WriteLine("Temperature: {0}C degrees", temperature );
            Console.WriteLine("Humidity: {0}%", humidity);
            Console.WriteLine("Pressure: {0}mm of mercury", pressure);
        }
    }
}
