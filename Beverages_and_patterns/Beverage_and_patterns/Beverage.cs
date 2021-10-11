using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns
{
    public abstract class Beverage
    {
        // set default description of beverage (None)
        public string description;

        // method for returning description of beverage 
        public virtual string GetDescription()
        {
            return description;
        }

        // method for calculating cost of order
        public abstract double Cost();
    }
}
