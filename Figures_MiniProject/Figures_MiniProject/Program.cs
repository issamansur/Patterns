using System;

namespace Figures
{
    class Program
    {
        static void Main()
        {
            Rectangle a = new Rectangle(1, 1);
            Console.WriteLine(a.Perimetr().ToString() + a.Square().ToString() + a.Type().ToString());
            Triangle b = new Triangle(1, 1, 2);
            Console.WriteLine(b.Perimetr().ToString() + b.Square().ToString() + b.Type().ToString());
            Ellipse c = new Ellipse(1, 2);
            Console.WriteLine(c.Perimetr().ToString() + c.Square().ToString() + c.Type().ToString());

        }
    }
}
