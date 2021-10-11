using System;

namespace Fabric_and_Patterns
{
    class TiraspolPepperoniPizza : Pizza
    {
        public TiraspolPepperoniPizza()
        {
            Name = "Tiraspol Style Pepperoni Pizza";
            dough = tiraspolFactory.CreateDough();
            sauce = tiraspolFactory.CreateSauce();
            cheese = tiraspolFactory.CreateCheese();
            pepperoni = tiraspolFactory.CreatePepperoni();
            veggies.Add(new Spinach());
            veggies.Add(new BlackOlives());
            veggies.Add(new Eggplant());
        }
    }
}
