using System;

namespace Fabric_and_Patterns
{
    public class TiraspolPizzaStore : PizzaStore
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
                    pizza.Name = "Tiraspol Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Tiraspol Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Tiraspol Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Tiraspol Style Veggie Pizza";
                    break;
                default:
                    throw new ArgumentNullException("This type of Pizza not founded!");
            }

            return pizza;
        }
    }
}
