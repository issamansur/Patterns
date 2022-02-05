using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz_and_patterns.Beverages
{
    public class Viski : Beverage
    {
        public Viski()
        {
            description = "(Кофе) Виски by xaarxyx";
        }

        public override double Cost()
        {
            return 4;
        }
    }
}
