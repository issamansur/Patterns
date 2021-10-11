using System;
using System.Collections.Generic;
using System.Text;

namespace weatherstation_and_patterns.Displays
{
    class StatisticsDisplay : ISubscriber, IDisplay
    {
        // weather indicators
        private float temperature;
        private float humidity;
        private float pressure;
        // list for determine the average of indicators
        private static List<float> list_temperature= new List<float>();
        private static List<float> list_humidity = new List<float>();
        private static List<float> list_pressure = new List<float>();
        private float a_temperature;
        private float a_humidity;
        private float a_pressure;
        // list of subscibers of updating indicators (our displays)
        private IPublisher sub_list;

        // constructor for CD adding itself (display)
        // to list of subscribers (AUTOMATICALLY)
        public StatisticsDisplay(IPublisher sub_list)
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
            list_temperature.Add(temperature);
            list_humidity.Add(humidity);
            list_pressure.Add(pressure);
            if (list_temperature.Count > 7)
            {
                list_temperature.RemoveAt(0);
                list_humidity.RemoveAt(0);
                list_pressure.RemoveAt(0);
            }
            a_temperature = a_humidity = a_pressure = 0;
            for (int i=0; i<list_temperature.Count; i++)
            {
                a_temperature += list_temperature[i];
                a_humidity += list_humidity[i];
                a_pressure += list_pressure[i];
            }
            a_temperature /= list_temperature.Count;
            a_humidity /= list_humidity.Count;
            a_pressure /= list_pressure.Count;
            // Display indicators right after updating
            Display();
        }

        // method for displaying
        public void Display()
        {
            Console.WriteLine("Average indicators:");
            Console.WriteLine("Temperature: {0}C degrees", a_temperature);
            Console.WriteLine("Humidity: {0}%", a_humidity);
            Console.WriteLine("Pressure: {0}mm of mercury", a_pressure);
        }
    }
}
