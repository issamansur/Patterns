using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public interface IIterator<Obj> where Obj : MenuItem
    {
        Obj Next();
        bool HasNext();
        void Remove();
    }
}
