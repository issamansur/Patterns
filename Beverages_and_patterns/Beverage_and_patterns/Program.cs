using System;
using Starbuzz_and_patterns;
using Starbuzz_and_patterns.Beverages;
using Starbuzz_and_patterns.Additions;

namespace Starbuzz_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine(beverage.Cost() + "$");

            Beverage beverage_2 = new Espresso();
            beverage_2 = new Milk(beverage_2);
            Console.WriteLine(beverage_2.GetDescription());
            Console.WriteLine(beverage_2.Cost() + "$");

            beverage_2 = new Mocha(beverage_2);
            beverage_2 = new Whip(beverage_2);
            beverage_2 = new Soy(beverage_2);
            Console.WriteLine(beverage_2.GetDescription());
            Console.WriteLine(beverage_2.Cost() + "$");
        }
    }
}
