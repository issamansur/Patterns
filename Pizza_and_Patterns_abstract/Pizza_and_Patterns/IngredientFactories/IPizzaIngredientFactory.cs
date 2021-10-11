using System;
using System.Collections.Generic;
using System.Text;

namespace Fabric_and_Patterns
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();
        public ISauce CreateSauce();
        public ICheese CreateCheese();
        public IVeggies[] CreateVeggies();
        public IPepperoni CreatePepperoni();
        public IClams CreateClam();
    }
}
