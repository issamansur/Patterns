using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Triangle : IFigures
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double S1, double S2, double S3)
        {
            try
            {
                if (S1 <= 0 || S2 <= 0 || S3 <=0)
                    throw new ArgumentOutOfRangeException();
                if (S1 + S2 <= S3 || S1 + S3 <= S2 || S2 + S3 <= S1)
                    throw new ArgumentException();
                this.Side1 = S1;
                this.Side2 = S2;
                this.Side3 = S3;
                Console.WriteLine("Объект создан!");           
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Объект не создан! Стороны должны быть выражены положительными числами.");
                this.Side1 = 1;
                this.Side2 = 1;
                this.Side3 = 1;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Объект не создан! Невозможно создать треугольник с такими длинами.");
                this.Side1 = 1;
                this.Side2 = 1;
                this.Side3 = 1;
            }
        }
        public string Type()
        {
            if (Side1 == Side2 && Side1 == Side3)
            {
                return "Figures: Равносторонний треугольник";
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
            {
                return "Равнобедренный треугольник";
            }
            else
            {
                return "Разносторонний треугольник";
            }
        }

        public double Perimetr()
        {
            return (Side1 + Side2 + Side3);
        }

        public double Square()
        {
            double p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p*(p-Side1)*(p-Side2)*(p-Side3));
        }
    }
}
