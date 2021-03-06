using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class PancakeHouseMenu : IMenu
    {
        public List<MenuItem> MenuItems { get; private set; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();
            AddItem("K & B’s Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99);
            AddItem("Regular Pancake Breakfast",
            "Pancakes with fried eggs, sausage",
            false,
            2.99);
            AddItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            true,
            3.49);
            AddItem("Waffles",
            "Waffles, with your choice of blueberries or strawberries",
            true,
            3.59);
        }
        public void AddItem(string name, string description,
        bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }
        public IIterator<MenuItem> CreateIterator()
        {
            return new PancakeHouseMenuIterator(MenuItems);
        }
    }
}
