using System;

namespace Fabric_and_Patterns
{
    class BenderPepperoniPizza : Pizza
    {
        public BenderPepperoniPizza()
        {
            Name = "Bender Style Pepperoni Pizza";
            dough = benderFactory.CreateDough();
            sauce = benderFactory.CreateSauce();
            cheese = benderFactory.CreateCheese();
            pepperoni = benderFactory.CreatePepperoni();
            veggies.Add(new Mushroom());
            veggies.Add(new Onion());
            veggies.Add(new RedPapper());
        }
    }
}
