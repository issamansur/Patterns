using System;

namespace Fabric_and_Patterns
{
    class TiraspolIngredientFactory : IPizzaIngredientFactory
    {
        public string Name { get; set; }
     
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggies[] CreateVeggies()
        {
            IVeggies[] veggies = {
                new BlackOlives(), new Spinach(),
                new Eggplant()
            };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClams CreateClam()
        {
            return new FrozenClams();
        }
    }
}
