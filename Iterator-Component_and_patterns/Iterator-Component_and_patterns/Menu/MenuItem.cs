using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Vegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, string description,
        bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsVegetarian()
        {
            return Vegetarian;
        }

        public override void Print()
        {
            Console.Write(" " + GetName());
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine(" -- " + GetDescription());
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            return new NullIterator();
        }
    }
}
