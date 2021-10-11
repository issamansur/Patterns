using System;
using Ducks_and_patterns.Actions.Swim;
using Ducks_and_patterns.Actions.Fly;
using Ducks_and_patterns.Actions.Quack;

namespace Ducks_and_patterns
{
    class RubberDuck : Duck
    {
        public string name = "Резиновая утка";
        public RubberDuck()
            : base( new FlyNoWay(), new SpecialQuack(), new CanSwim()) 
        {
        
        }

        public override void Display()
        {
            Console.WriteLine(name);
            base.Display();
        }
        
    }
}