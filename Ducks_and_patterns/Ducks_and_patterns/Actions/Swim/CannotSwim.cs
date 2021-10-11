using System;

namespace Ducks_and_patterns.Actions.Swim
{
    class CannotSwim : ISwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("Эта уточка не умеет плавать :(");
        }
    }
}