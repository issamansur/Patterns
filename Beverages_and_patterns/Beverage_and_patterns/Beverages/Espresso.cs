using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
