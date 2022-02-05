﻿using System;

namespace Iterator_Component_and_patterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Iterator
            Console.WriteLine("For Iterator:");

            PancakeHouseMenu pancakeHouseMenu1 = new PancakeHouseMenu();
            DinerMenu dinerMenu1 = new DinerMenu();
            CafeMenu cafeMenu1 = new CafeMenu();
            Waitress waitress1 = new Waitress(pancakeHouseMenu1, dinerMenu1, cafeMenu1);
            waitress1.PrintMenu1();

            // Component
            Console.WriteLine("\n\n\nFor Component:");

            MenuComponent pancakeHouseMenu =
                new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu =
                new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu =
                new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu =
                new Menu("DESSERT MENU", "Dessert of course!");
            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");
            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K & B’s Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59));

            dinerMenu.Add(new MenuItem("Vegetarian BLT",
                "(Fakin’) Bacon with lettuce & tomato on whole wheat", 
                true, 
                2.99));
            dinerMenu.Add(new MenuItem("BLT",
                "Bacon with lettuce & tomato on whole wheat", 
                false, 
                2.99));
            dinerMenu.Add(new MenuItem("Soup of the day",
            "Soup of the day, with a side of potato salad", 
            false, 
            3.29));
            dinerMenu.Add(new MenuItem("Hotdog",
                "A hot dog, with saurkraut, relish, onions, topped with cheese",
                false, 
                3.05));
            dinerMenu.Add(new MenuItem("Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true, 
                3.89));


            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true,
                3.99));
            cafeMenu.Add(new MenuItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false,
                3.69));
            cafeMenu.Add(new MenuItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true,
                4.29));


            dinerMenu.Add(dessertMenu);
            dessertMenu.Add(new MenuItem("Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla icecream",
                true,
                1.59));
            
            Waitress waitress = new Waitress(allMenus);
            waitress.PrintMenu();
            waitress.PrintVegetarianMenu();
        }
    }
}
