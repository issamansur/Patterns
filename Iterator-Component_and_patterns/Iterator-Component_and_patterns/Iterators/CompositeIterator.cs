using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        private Stack<IEnumerator<MenuComponent>> stack =
            new Stack<IEnumerator<MenuComponent>>();

        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            stack.Push(iterator);
        }

        public object Current {
            get
            {
                IEnumerator<MenuComponent> iterator =
                    stack.Peek();
                MenuComponent component = iterator.Current;
                if (component.GetType() == typeof(Menu))
                {
                    stack.Push(component.CreateIterator());
                }

                return component;
            }
        }

        MenuComponent IEnumerator<MenuComponent>.Current
        {
            get
            {
                return (MenuComponent)Current;
            }
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator<MenuComponent> iterator = stack.Peek();
                if (!iterator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            stack = new Stack<IEnumerator<MenuComponent>>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
