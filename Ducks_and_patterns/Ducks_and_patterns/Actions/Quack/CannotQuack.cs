using System;

namespace Ducks_and_patterns.Actions.Quack
{
    class CannotQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка не умеет крякать :(");
        }
    }
}
