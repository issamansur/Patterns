using System;

namespace Fabric_and_Patterns
{
    public class BenderPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;
            IPizzaIngredientFactory ingredientFactory
                = new BenderIngredientFactory();

            type.ToLower();
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Bender Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Bender Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Bender Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Bender Style Veggie Pizza";
                    break;
                default:
                    throw new ArgumentNullException("This type of Pizza not founded!");
            }

            return pizza;
        }
    }
}
