using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class CafeMenuIterator : IIterator<MenuItem>
    {
        public MenuItem[] List { get; private set; }
        private int position = 0;

        public CafeMenuIterator(Dictionary<string, MenuItem>.ValueCollection dict)
        {
            List = new MenuItem[dict.Count];
            int i = 0;
            foreach (MenuItem x in dict){
                List[i] = x;
                i++;
            }
        }

        public MenuItem Next()
        {
            MenuItem menuItem = List[position];
            position++;
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
