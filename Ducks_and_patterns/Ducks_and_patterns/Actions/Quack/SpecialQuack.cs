using System;

namespace Ducks_and_patterns.Actions.Quack
{
    class SpecialQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка крякает необычно. Она резиновая ;)");
        }
    }
}
