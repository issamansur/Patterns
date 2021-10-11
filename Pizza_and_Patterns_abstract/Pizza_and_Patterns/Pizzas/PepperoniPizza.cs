using System;

namespace Fabric_and_Patterns
{
    class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing", Name);

            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();

            veggies = ingredientFactory.CreateVeggies();

            dough.Display();
            sauce.Display();
            cheese.Display();
            pepperoni.Display();
            foreach (IVeggies x in veggies)
            {
                x.Display();
            }
        }
    }
}
