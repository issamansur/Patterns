using System;

namespace Ducks_and_patterns.Actions.Swim
{
    class CanSwim : ISwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("Эта уточка умеет плавать :)");
        }
    }
}