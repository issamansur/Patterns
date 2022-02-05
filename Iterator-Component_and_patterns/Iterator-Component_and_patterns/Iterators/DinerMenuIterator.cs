using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    class DinerMenuIterator : IIterator<MenuItem>
    {
        public MenuItem[] List { get; private set; }
        private int position = 0;

        public DinerMenuIterator(MenuItem[] list)
        {
            this.List = list;
        }

        public MenuItem Next()
        {
            MenuItem menuItem = List[position];
            position += 1;
            return menuItem;
        }

        public bool HasNext()
        {
            return !(position >= List.Length || List[position] == null);
        }

        public void Remove()
        {
            if (position <= 0)
            {
                throw new IndexOutOfRangeException
                ("You can’t remove an item until you’ve done at least one next()");
            }
            if (List[position - 1] != null)
            {
                for (int i = position - 1; i < (List.Length - 1); i++)
                {
                    List[i] = List[i + 1];
                }
                List[List.Length - 1] = null;
            }
        }
    }
}
