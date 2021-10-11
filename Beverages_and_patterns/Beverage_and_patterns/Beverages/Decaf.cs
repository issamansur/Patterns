using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
