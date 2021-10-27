using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Figures
    {
        List<Figure> figures = new List<Figure>();

        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }
    }
    public class Enumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public Figure Current
        {
            get { return null; }
        }
    }
}
