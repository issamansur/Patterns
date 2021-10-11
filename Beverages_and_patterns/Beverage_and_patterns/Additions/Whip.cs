using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Additions
{
    class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
