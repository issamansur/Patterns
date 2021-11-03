using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Figures : IEnumerable
    {
        List<Figure> figures = new List<Figure>();

        public IEnumerator GetEnumerator()
        {
            return figures.GetEnumerator();
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }
    }
}
