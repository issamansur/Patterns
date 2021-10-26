using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Ellipse : IFigures
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
        public string Type()
        {
            if (Radius1*Radius2 == 0)
                return "Figures: Точка";
            else if (Radius1 == Radius2)
                return "Figures: Круг";
            else
                return "Figures: Эллипс";
        }

        public double Perimetr()
        {
            double up = Math.PI * Radius1 * Radius2 + Math.Pow((Math.Max(Radius1, Radius2) - Math.Min(Radius1, Radius2)), 2);
            double down = Radius1 + Radius2;

            return 4*(up/down);
        }

        public double Square()
        {
            return Math.PI*Radius1 * Radius2;
        }
    }
}
