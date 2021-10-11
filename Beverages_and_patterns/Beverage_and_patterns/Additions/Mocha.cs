using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Additions
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }
}
