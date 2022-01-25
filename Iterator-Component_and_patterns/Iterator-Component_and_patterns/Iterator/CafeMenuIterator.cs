using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class CafeMenuIterator : IIterator<MenuItem>
    {
        readonly MenuItem[] list;
        private int position = 0;

        public CafeMenuIterator(Dictionary<string, MenuItem>.ValueCollection dict)
        {
            list = new MenuItem[dict.Count];
            int i = 0;
            foreach (MenuItem x in dict){
                list[i] = x;
                i++;
            }
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
