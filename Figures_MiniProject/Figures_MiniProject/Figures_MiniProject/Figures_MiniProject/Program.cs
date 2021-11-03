using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main()
        {
            start:
            Random rand = new Random();

            Console.WriteLine("Введите тип фигуры, который будет использоваться:");
            Console.WriteLine("1 - треугольник\n2 - прямоугольник(квадрат\n3 - эллипс(круг)");
            string stringOfFigure = Console.ReadLine();
            int numberOfFigure;
            try
            {
                numberOfFigure = int.Parse(stringOfFigure);
                if (numberOfFigure < 1 || numberOfFigure > 3)
                    throw new ArgumentException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Обнаружены недопустимые знаки");
                goto start;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Введите число от 1 до 3!");
                goto start;
            }

            Figures figures = new Figures();
            for (int i=1; i<=10; i++)
            {
                int parametr_1 = rand.Next(3) + 1;
                int parametr_2 = rand.Next(3) + 1;
                Figure figure;
                switch (numberOfFigure)
                {
                    case 1:
                        int parametr_3 = rand.Next(3) + 1;
                        figure = new Triangle(parametr_1, parametr_2, parametr_3);
                        break;
                    case 2:
                        figure = new Rectangle(parametr_1, parametr_2);
                        break;
                    case 3:
                        figure = new Ellipse(parametr_1, parametr_2);
                        break;
                    default:
                        figure = new Rectangle(parametr_1, parametr_2);
                        break;
                }
                figures.Add(figure);
            }

            int k = 0;
            Console.WriteLine("{0,2} | {1,30} | {2,10:0.##} | {3,10:0.##}",
                "N", "Type of figure", "Perimetr", "Square");
            string forTable = new string('_', 61);
            Console.WriteLine(forTable);
            foreach (Figure figure in figures)
            {
                k++;
                Console.WriteLine("{0,2} | {1,30} | {2,10:0.##} | {3,10:0.##}",
                    k, figure.Type(), figure.Perimetr(), figure.Square());
            }
        }
    }
}
