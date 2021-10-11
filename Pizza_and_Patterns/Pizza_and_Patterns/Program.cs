using System;

namespace Fabric_and_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new TiraspolPizzaStore();
            store.OrderPizza("pepperoni");
        }
    }
}
