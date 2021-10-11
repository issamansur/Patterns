using System;

namespace Fabric_and_Patterns
{
    public class TiraspolPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza;

            type.ToLower();
            switch (type)
            {
                case "cheese":
                    pizza = new TiraspolCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new TiraspolPepperoniPizza();
                    break;
                case "clam":
                    pizza = new TiraspolClamPizza();
                    break;
                case "veggie":
                    pizza = new TiraspolVeggiePizza();
                    break;
                default:
                    throw new ArgumentNullException("This type of Pizza not founded!");
            }

            return pizza;
        }
    }
}
