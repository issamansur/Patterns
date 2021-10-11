using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Additions
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
