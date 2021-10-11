using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns.Additions
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
