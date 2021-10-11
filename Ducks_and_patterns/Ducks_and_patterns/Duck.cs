using System;
using Ducks_and_patterns.Actions.Swim;
using Ducks_and_patterns.Actions.Fly;
using Ducks_and_patterns.Actions.Quack;

namespace Ducks_and_patterns
{
    public abstract class Duck
    {
        private IFlyBehaviour flying;
        private IQuackBehaviour quacking;
        private ISwimBehaviour swimming;

        public Duck(IFlyBehaviour flying, IQuackBehaviour quacking, ISwimBehaviour swimming)
        {
            this.flying = flying ?? throw new ArgumentNullException("Параметр не может быть равен null!", nameof(flying));
            this.quacking = quacking ?? throw new ArgumentNullException("Параметр не может быть равен null!", nameof(quacking));
            this.swimming = swimming ?? throw new ArgumentNullException("Параметр не может быть равен null!", nameof(swimming));
        }

        public virtual void Display()
        {
            Fly();
            Quack();
            Swim();
        }

        public void Fly()
        {
            flying.Fly();
        }

        public void Swim()
        {
            swimming.Swim();
        }

        public void Quack()
        {
            quacking.Quack();
        }

        public void Dead()
        {
            Console.WriteLine("Уточка мертва");
            flying = new FlyNoWay();
            swimming = new CannotSwim();
            quacking = new CannotQuack();
        }
    }
}
