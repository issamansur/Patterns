using System;

namespace Fabric_and_Patterns
{
    class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing", Name);

            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();

            dough.Display();
            sauce.Display();
            cheese.Display();
            clam.Display();
        }
    }
}
