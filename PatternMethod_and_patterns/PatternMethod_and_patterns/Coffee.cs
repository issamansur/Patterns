using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMethod_and_patterns
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee " +
                "through filter");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
