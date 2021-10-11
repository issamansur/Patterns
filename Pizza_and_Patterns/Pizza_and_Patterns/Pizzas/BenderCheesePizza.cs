using System;

namespace Fabric_and_Patterns
{
    class BenderCheesePizza : Pizza
    {
        public BenderCheesePizza()
        {
            Name = "Bender Style Cheese Pizza";
            dough = benderFactory.CreateDough();
            sauce = benderFactory.CreateSauce();
            cheese = benderFactory.CreateCheese();
            veggies.Add(new Garlic());
        }
    }
}
