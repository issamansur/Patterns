using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position += 1;
            return menuItem;
        }

        public bool HasNext()
        {
            return !(position >= items.Length || items[position] == null);
        }
    }
}
