using System;
using Ducks_and_patterns.Actions.Swim;
using Ducks_and_patterns.Actions.Fly;
using Ducks_and_patterns.Actions.Quack;

namespace Ducks_and_patterns
{
    class DecoyDuck : Duck
    {
        public string name = "Приманка";
        public DecoyDuck()
            : base(new FlyNoWay(), new CanQuack(), new CanSwim())
        {

        }

        public override void Display()
        {
            Console.WriteLine(name);
            base.Display();
        }
    }
}
