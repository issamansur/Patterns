using System;
using System.Collections.Generic;
using System.Text;

namespace weatherstation_and_patterns
{
    public interface ISubscriber
    {
        // method for updating the indicators 
        public void Update(float temperature, float humidity, float pressure);
    }
}
