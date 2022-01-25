using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        readonly List<MenuItem> list;
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> list)
        {
            this.list = list;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = list[position];
            position += 1;
            return menuItem;
        }

        public bool HasNext()
        {
            return !(position >= list.Count || list[position] == null);
        }

        public void Remove()
        {
            if (position <= 0)
            {
                throw new IndexOutOfRangeException
                ("You can’t remove an item until you’ve done at least one next()");
            }
            if (list[position - 1] != null)
            {
                list.RemoveAt(position - 1);
            }
        }
    }
}
