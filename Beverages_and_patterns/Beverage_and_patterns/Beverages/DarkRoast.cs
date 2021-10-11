using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }

    }
}
