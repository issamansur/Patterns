using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class NullIterator : IEnumerator<MenuComponent> 
    {
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public MenuComponent Current
        {
            get
            {
                return null;
            }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Remove()
        {
            throw new InvalidOperationException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
