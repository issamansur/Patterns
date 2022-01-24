using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public interface IIterator
    {
        Object Next();
        bool HasNext();
    }
}
