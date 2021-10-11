using System;

namespace Fabric_and_Patterns
{
    public class BenderPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;

            type.ToLower();
            switch (type)
            {
                case "cheese":
                    pizza = new BenderCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new BenderPepperoniPizza();
                    break;
                case "clam":
                    pizza = new BenderClamPizza();
                    break;
                case "veggie":
                    pizza = new BenderVeggiePizza();
                    break;
                default:
                    throw new ArgumentNullException("This type of Pizza not founded!");
            }

            return pizza;
        }
    }
}
