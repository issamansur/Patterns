using System;

namespace Fabric_and_Patterns
{
    class TiraspolVeggiePizza : Pizza
    {
        public TiraspolVeggiePizza()
        {
            Name = "Tiraspol Style Veggie Pizza";
            dough = tiraspolFactory.CreateDough();
            sauce = tiraspolFactory.CreateSauce();
            cheese = tiraspolFactory.CreateCheese();
            veggies.Add(new Spinach());
            veggies.Add(new BlackOlives());
            veggies.Add(new Eggplant());
        }
    }
}
