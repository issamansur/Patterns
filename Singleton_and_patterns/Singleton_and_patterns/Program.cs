using System;

namespace Singleton_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler =
                ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler1 =
                new ChocolateBoiler();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();
        }
    }
}
