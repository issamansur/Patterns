using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_and_patterns
{
    public class ChocolateBoiler
    {
        private static
            ChocolateBoiler uniqueInstance;

        private static object 
            syncRoot = new Object();

        /*u can don't use lock and syncRoot if do this:
            private static ChocolateBoiler uniqueInstance = 
                new ChocolateBoiler();
        */

        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (syncRoot)
                {
                    if (uniqueInstance == null)
                        uniqueInstance = new ChocolateBoiler();
                }
            }

            return uniqueInstance;
        }

        private bool empty;
        private bool boiled;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void Fill()
        {
            if (empty)
            {
                empty = boiled = false;
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
                empty = true;
        }

        public void Boil()
        {
            if (!empty && !boiled)
                boiled = true;
        }
    }
}
