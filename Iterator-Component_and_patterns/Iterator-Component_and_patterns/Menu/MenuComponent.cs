using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new InvalidOperationException();
        }
        public abstract string GetName();
        public abstract string GetDescription();
        public virtual double GetPrice()
        {
            throw new InvalidOperationException();
        }
        public virtual bool IsVegetarian()
        {
            throw new InvalidOperationException();
        }
        public abstract void Print();
        public abstract IEnumerator<MenuComponent> CreateIterator();
    }
}
