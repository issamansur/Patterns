using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
    class Figures : IEnumerable
    {
        List<Figure> figures = new List<Figure>();

        public int Count { get; private set; }

        public void Add(Figure figure)
        {
            figures.Add(figure);
            this.Count++;
        }

        public Figure this[int index]
        {
            get
            {
                return figures[index];
            }
        }


        public IEnumerator GetEnumerator()
        {
            return figures.GetEnumerator();
        }

        public List<Figure> Sort()
        {
            figures.Sort();
            return figures;
        }

        public List<Figure> SortByName(string letter)
        {
            var figuresSorted = figures.Where(t => 
            t.Type().ToUpper().StartsWith(letter)).OrderBy(t => t);
            figures = new List<Figure>() { };
            foreach (Figure figure in figuresSorted)
                figures.Add(figure);
            return figures;
        }

        public List<Figure> SortByNumber()
        {
            var figuresSorted = figures.OrderBy(t =>
            t.GetNumber());
            figures = new List<Figure>() { };
            foreach (Figure figure in figuresSorted)
                figures.Add(figure);
            return figures;
        }
    }
}
