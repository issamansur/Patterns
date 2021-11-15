using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Rectangle : Figure
    {
        public double Side1 { get; }
        public double Side2 { get; }

        public Rectangle(double S1, double S2)
        {
            try
            {
                if (1 <= 0 || S2 <= 0)
                    throw new ArgumentOutOfRangeException();
                this.Side1 = S1;
                this.Side2 = S2;
                Console.WriteLine("Объект создан!");           
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Объект не создан! Стороны должны быть выражены положительными числами.");
                this.Side1 = 1;
                this.Side2 = 1;
            }
        }

        public override string Type()
        {
            if (Side1 == Side2)
                return "Квадрат";
            else
                return "Прямоугольник";
        }

        public override double Perimetr()
        {
            return (Side1 + Side2) * 2;
        }

        public override double Square()
        {
            return Side1 * Side2;
        }


        public override bool Equals(Object obj)
        {
            Rectangle o = (Rectangle)obj;
            if (obj == null || !(obj is Rectangle))
                return false;
            else
                return
                    (Type() == o.Type()
                    && Side1 == o.Side1
                    && Side2 == o.Side2 
                    && Perimetr() == o.Perimetr()
                    && Square() == o.Square());
        }

        public override int GetHashCode()
        {
            int hashCode = (int)Math.Ceiling(
                Side1 * Side2 * (Side1 + Side2) *
                Perimetr() * Square() * (Perimetr() + Square())
                );
            return (hashCode);
        }
    }
}
