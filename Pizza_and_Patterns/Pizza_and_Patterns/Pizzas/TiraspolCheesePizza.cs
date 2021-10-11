using System;

namespace Fabric_and_Patterns
{
    class TiraspolCheesePizza : Pizza
    {
        public TiraspolCheesePizza()
        {
            Name = "Tiraspol Style Cheese Pizza";
            dough = tiraspolFactory.CreateDough();
            sauce = tiraspolFactory.CreateSauce();
            cheese = tiraspolFactory.CreateCheese();
        }
    }
}
