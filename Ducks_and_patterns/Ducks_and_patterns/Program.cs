using System;

namespace Ducks_and_patterns
{
    class Program
    {
        static void Main()
        {
            Duck mallard = new MallardDuck();
            Duck redhead = new RedheadDuck();
            Duck decoy = new DecoyDuck();
            Duck rubber = new RubberDuck();

            redhead.Display();
            Console.WriteLine();

            mallard.Display();
            Console.WriteLine();

            decoy.Display();
            Console.WriteLine();

            rubber.Display();
            Console.WriteLine();

            Console.WriteLine("Убийство рыжей уточки");
            redhead.Dead();
            redhead.Display();
        }
    }
}
