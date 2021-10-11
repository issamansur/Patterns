using System;

namespace Fabric_and_Patterns
{
    class TiraspolClamPizza : Pizza
    {
        public TiraspolClamPizza()
        {
            Name = "Tiraspol Style Clam Pizza";
            dough = tiraspolFactory.CreateDough();
            sauce = tiraspolFactory.CreateSauce();
            cheese = tiraspolFactory.CreateCheese();
            clam = tiraspolFactory.CreateClam();
        }
    }
}
