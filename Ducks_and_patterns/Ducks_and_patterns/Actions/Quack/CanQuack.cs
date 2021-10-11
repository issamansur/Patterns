using System;

namespace Ducks_and_patterns.Actions.Quack
{
    class CanQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка умеет крякать :)");
        }
    }
}
