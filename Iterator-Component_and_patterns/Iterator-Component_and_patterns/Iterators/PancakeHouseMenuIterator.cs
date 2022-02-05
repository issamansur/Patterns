using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class PancakeHouseMenuIterator : IIterator<MenuItem>
    {
        public List<MenuItem> List { get; private set; }
        private int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> list)
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
            return !(position >= List.Count || List[position] == null);
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
                List.RemoveAt(position - 1);
            }
        }
    }
}
