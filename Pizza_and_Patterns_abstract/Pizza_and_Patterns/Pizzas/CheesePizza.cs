using System;

namespace Fabric_and_Patterns
{
    class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);

            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

            dough.Display();
            sauce.Display();
            cheese.Display();
        }
    }
}
