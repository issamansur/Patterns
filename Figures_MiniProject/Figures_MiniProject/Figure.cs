using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public abstract class Figure : IComparable<Figure>
    {
        int Number = 0;
        public abstract string Type();
        public abstract double Perimetr();
        public abstract double Square();
        public void SetNumber(int number)
        {
            Number = number;
        }

        public int GetNumber()
        {
            if (Number != 0)
                return Number;
            else
                throw new InvalidOperationException();
        }

        public int CompareTo(Figure second)
        {
            double firstPerimetr = this.Perimetr();
            double secondPerimetr = second.Perimetr();
            return firstPerimetr.CompareTo(secondPerimetr);
        }
    }
}
