using System;

namespace Facade_and_patterns
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Экран поднят");
        }

        public void Down()
        {
            Console.WriteLine("Экран опущен");
        }
    }
}