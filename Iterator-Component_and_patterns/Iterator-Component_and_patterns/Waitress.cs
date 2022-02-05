using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class Waitress
    {
        public IMenu PancakeHouseMenu { get; private set; }
        public IMenu DinerMenu { get; private set; }
        public IMenu CafeMenu { get; private set; }
        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            PancakeHouseMenu = pancakeHouseMenu;
            DinerMenu = dinerMenu;
            CafeMenu = cafeMenu;
        }

        public void PrintMenu1()
        {
            IIterator<MenuItem> pancakeIterator = PancakeHouseMenu.CreateIterator();
            IIterator<MenuItem> dinerIterator = DinerMenu.CreateIterator();
            IIterator<MenuItem> cafeIterator = CafeMenu.CreateIterator();
            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterator);
            Console.WriteLine("\nDINNER");
            PrintMenu(cafeIterator);
        }

        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.Write(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }

        public MenuComponent AllMenus { get; private set; }
        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }


        public void PrintMenu()
        {
            AllMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> iterator = AllMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (InvalidOperationException e) {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
