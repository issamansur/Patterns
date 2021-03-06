using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Ellipse : Figure
    {
        public double Radius1 { get; }
        public double Radius2 { get; }

        public Ellipse(double R1, double R2)
        {
            try
            {
                if (R1 < 0 || R2 < 0 && (R1*R2!=0))
                    throw new ArgumentOutOfRangeException();
                this.Radius1 = R1;
                this.Radius2 = R2;
                Console.WriteLine("Объект создан!");           
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Объект не создан! Стороны должны быть выражены положительными числами.");
                this.Radius1 = 1;
                this.Radius2 = 1;
            }
        }
        public override string Type()
        {
            if (Radius1*Radius2 == 0)
                return "Точка";
            else if (Radius1 == Radius2)
                return "Круг";
            else
                return "Эллипс";
        }

        public override double Perimetr()
        {
            double up = Math.PI * Radius1 * Radius2 + Math.Pow((Math.Max(Radius1, Radius2) - Math.Min(Radius1, Radius2)), 2);
            double down = Radius1 + Radius2;

            return 4*(up/down);
        }

        public override double Square()
        {
            return Math.PI*Radius1 * Radius2;
        }


        public override bool Equals(Object obj)
        {
            Ellipse o = (Ellipse)obj;
            if (obj == null || !(obj is Ellipse))
                return false;
            else
                return
                    (Type() == o.Type() 
                    && Radius1 == o.Radius1
                    && Radius2 == o.Radius2
                    && Perimetr() == o.Perimetr()
                    && Square() == o.Square());
        }

        public override int GetHashCode()
        {
            int hashCode = (int)Math.Ceiling(
                Radius1 * Radius2 * (Radius1 + Radius2) *
                Perimetr() * Square() * (Perimetr() + Square())
                );
            return (hashCode);
        }
    }
}
