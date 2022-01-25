using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{
    public class Waitress
    {
        readonly IMenu pancakeHouseMenu;
        readonly IMenu dinerMenu;
        readonly IMenu cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, 
            IMenu dinerMenu, IMenu cafeMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            this.cafeMenu = cafeMenu;
        }

        public void PrintMenu()
        {
            IIterator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator<MenuItem> dinerIterator = dinerMenu.CreateIterator();
            IIterator<MenuItem> cafeIterator = cafeMenu.CreateIterator();

            Console.Write("MENU\n----\nBREAKFAST\n");
            PrintMenu(pancakeIterator);
            Console.Write("\nLUNCH\n");
            PrintMenu(dinerIterator);
            Console.Write("\nDINNER\n");
            PrintMenu(cafeIterator);
        }

        private void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine(menuItem.GetName() + ", ");
                Console.Write(menuItem.GetPrice() + " -- ");
                Console.WriteLine(menuItem.GetDescription());
            }
        }
    }
}
