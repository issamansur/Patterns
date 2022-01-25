using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public interface IMenu
    {
        public IIterator<MenuItem> CreateIterator();
    }
}
