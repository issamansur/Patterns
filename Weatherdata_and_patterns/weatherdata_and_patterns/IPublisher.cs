using System;
using System.Collections.Generic;
using System.Text;

namespace weatherstation_and_patterns
{
    public interface IPublisher
    {
        // methods for actions with list of subscribers
        public void AddSubscriber(ISubscriber sub);
        public void DeleteSubscriber(ISubscriber sub);
        public void NotifySubscriber();
    }
}
