using System;
using Ducks_and_patterns.Actions.Swim;
using Ducks_and_patterns.Actions.Fly;
using Ducks_and_patterns.Actions.Quack;

namespace Ducks_and_patterns
{
    class MallardDuck : Duck
    {
        public string name = "Дикая утка";
        public MallardDuck()
            : base(new FlyWithWings(), new CanQuack(), new CanSwim())
        {

        }

        public override void Display()
        {
            Console.WriteLine(name);
            base.Display();
        }
    }
}
