using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> items;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items)
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
            return !(position >= items.Count || items[position] == null);
        }
    }
}
