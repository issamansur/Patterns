using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_and_patterns
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
        
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
