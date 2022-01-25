using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    class DinerMenuIterator : IIterator<MenuItem>
    {
        readonly MenuItem[] list;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] list)
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
            return !(position >= list.Length || list[position] == null);
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
                for (int i = position - 1; i < (list.Length - 1); i++)
                {
                    list[i] = list[i + 1];
                }
                list[list.Length - 1] = null;
            }
        }
    }
}
