using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();

            Figures figures = new Figures();

            for (int i = 1; i <=5; i++)
            {
                int p1, p2, p3;
                p1 = rand.Next(3) + 1;
                p2 = rand.Next(3) + 1;
                p3 = rand.Next(3) + 1;

                Figure a = new Rectangle(p1, p2);
                Figure b = new Triangle(p1, p2, p3);
                Figure c = new Ellipse(p1, p2);

                figures.Add(a);
                figures.Add(b);
                figures.Add(c);
            }

            foreach (Figure x in Figures)
            {
                Console.WriteLine(x.Type());
            }
        }
    }
}
