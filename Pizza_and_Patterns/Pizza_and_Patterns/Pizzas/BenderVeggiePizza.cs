using System;

namespace Fabric_and_Patterns
{
    class BenderVeggiePizza : Pizza
    {
        public BenderVeggiePizza()
        {
            Name = "Bender Style Veggie Pizza";
            dough = benderFactory.CreateDough();
            sauce = benderFactory.CreateSauce();
            cheese = benderFactory.CreateCheese();
            veggies.Add(new Mushroom());
            veggies.Add(new Onion());
            veggies.Add(new RedPapper());
        }
    }
}
