using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Component_and_patterns
{ 
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> menuComponents = new List<MenuComponent>();
        public string Name { get; private set; }
        public string Description { get; private set; }
        private IEnumerator<MenuComponent> iterator = null;
        
        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            if (menuComponent == null)
                throw new ArgumentNullException();
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            IEnumerator<MenuComponent> iterator = menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent menuComponent = iterator.Current;
                menuComponent.Print();
            }
        }

        public override bool IsVegetarian()
        {
            return false;
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if (iterator == null)
            {
                iterator = new CompositeIterator(menuComponents.GetEnumerator());
            }
            return iterator;
        }
    }
}
