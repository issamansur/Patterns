using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz_and_patterns.Additions
{
    public class Cola : CondimentDecorator
    {
        public Cola(Beverage beverage)
        {
            if (beverage == null)
                throw new ArgumentNullException();
            else
                this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Cola by xaarxyx";
        }

        public override double Cost()
        {
            return 5000 + beverage.Cost();
        }
    }
}
