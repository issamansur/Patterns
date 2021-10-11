using System;

namespace Fabric_and_Patterns
{
    class BenderClamPizza : Pizza
    {
        public BenderClamPizza()
        {
            Name = "Bender Style Clam Pizza";
            dough = benderFactory.CreateDough();
            sauce = benderFactory.CreateSauce();
            cheese = benderFactory.CreateCheese();
            clam = benderFactory.CreateClam();
        }
    }
}
