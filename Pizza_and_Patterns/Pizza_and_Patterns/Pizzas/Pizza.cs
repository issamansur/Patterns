using System;
using System.Collections.Generic;

namespace Fabric_and_Patterns
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public IDough dough;
        public ISauce sauce;
        public List<IVeggies> veggies = new List<IVeggies>();
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClams clam;


        public IPizzaIngredientFactory tiraspolFactory
            = new TiraspolIngredientFactory();

        public IPizzaIngredientFactory benderFactory
            = new BenderIngredientFactory();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (IVeggies veggie in veggies)
                veggie.Display();
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
