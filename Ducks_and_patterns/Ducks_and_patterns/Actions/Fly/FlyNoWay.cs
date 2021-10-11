using System;

namespace Ducks_and_patterns.Actions.Fly
{
    class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Эта уточка не умеет летать :(");
        }
    }
}
