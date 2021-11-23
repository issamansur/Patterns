using System;

namespace PatternMethod_and_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}
