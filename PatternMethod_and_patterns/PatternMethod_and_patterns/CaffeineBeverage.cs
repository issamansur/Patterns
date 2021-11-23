using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMethod_and_patterns
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void Brew();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void AddCondiments();
    }
}
