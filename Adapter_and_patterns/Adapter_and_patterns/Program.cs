using System;

namespace Adapter_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck =
                new MallardDuck();

            WildTurkey wildTurkey = new WildTurkey();
            
            IDuck fakeMallardDuck =
                new Adapter(wildTurkey);

            Console.WriteLine("Mallard Duck");
            mallardDuck.Quack();
            mallardDuck.Fly();

            Console.WriteLine("Wild Turkey");
            wildTurkey.Gobble();
            wildTurkey.Fly();

            Console.WriteLine("Fake Mallard Duck");
            fakeMallardDuck.Quack();
            fakeMallardDuck.Fly();
        }
    }
}
