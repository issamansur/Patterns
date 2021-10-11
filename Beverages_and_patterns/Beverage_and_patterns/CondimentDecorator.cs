using System;
using Starbuzz_and_patterns;

namespace Starbuzz_and_patterns
{
    // Decorator for additions of beverage
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
    }
}
