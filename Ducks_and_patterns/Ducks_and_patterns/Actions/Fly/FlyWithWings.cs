using System;

namespace Ducks_and_patterns.Actions.Fly
{
    class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Эта уточка умеет летать :)");
        }
    }
}
