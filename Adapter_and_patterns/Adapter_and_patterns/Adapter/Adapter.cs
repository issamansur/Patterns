using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_and_patterns
{
    public class Adapter : IDuck
    {
        public ITurkey turkey;

        public Adapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            turkey.Fly();
        }
    }
}
