using System;

namespace Singleton_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler =
                ChocolateBoiler.GetInstance();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();
        }
    }
}
