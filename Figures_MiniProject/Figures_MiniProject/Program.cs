using System;
using System.Collections.Generic;
using System.Linq;

namespace Figures
{
    class Program
    {
        static Figures Create()
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
            for (int i = 1; i <= 10; i++)
            {
                int parametr_1 = rand.Next(5) + 1;
                int parametr_2 = rand.Next(5) + 1;
                Figure figure;

                switch (numberOfFigure)
                {
                    case 1:
                        int min = Math.Min(parametr_1, parametr_2);
                        int max = Math.Max(parametr_1, parametr_2);

                        int parametr_3 = max - min + rand.Next(2 * min - 1) + 1;
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

                figure.SetNumber(i);
                figures.Add(figure);
            }
            Console.WriteLine();
            return figures;
        }

        // вывод через IEnumerable(+IEnumerator)
        // foreach
        static void Output(Figures figures) 
        {
            Console.WriteLine("{0,2} | {1,30} | {2,10:0.##} | {3,10:0.##}",
                "N", "Type of figure", "Perimetr", "Square");
            foreach (Figure figure in figures)
            {
                Console.WriteLine("{3,2} | {0,30} | {1,10:0.##} | {2,10:0.##}",
                    figure.Type(), figure.Perimetr(), figure.Square(), figure.GetNumber());
            }
            Console.WriteLine();
        }

        // вывод через IEnumerable(+IEnumerator)
        // while
        static void OutputWhile(Figures figures)
        {
            Console.WriteLine("{0,2} | {1,30} | {2,10:0.##} | {3,10:0.##}",
                "N", "Type of figure", "Perimetr", "Square");
            int i = 0;
            while (i < figures.Count)
            {
                Figure figure = figures[i];
                Console.WriteLine("{3,2} | {0,30} | {1,10:0.##} | {2,10:0.##}",
                    figure.Type(), figure.Perimetr(), figure.Square(), figure.GetNumber());
                i++;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // отсортировать список по периметру
            // через IComporable
            Figures figures1 = Create();
            Output(figures1); // вывод foreach
            
            figures1.Sort();
            OutputWhile(figures1); // вывод while
            
            // -------------------------------------
            // отсортировать список по имени
            // через IQueryable
            Figures figures2 = Create();
            Output(figures2);

            figures2.SortByName("П"); // п -прямоугольник
            Output(figures2);
            
            // -------------------------------------
            // поиск совпадений через GetHashCode
            Figures figures3 = Create();
            Output(figures3);

            bool repetition = false;
            for (int i = 0; i < figures3.Count-1; i++)
            {
                for (int j = i+1; j < figures3.Count; j++)
                {
                    repetition =
                        (figures3[i].GetHashCode() ==
                        figures3[j].GetHashCode());
                    if (repetition)
                        break;
                }
                if (repetition)
                    break;
            }
            if (repetition)
                Console.WriteLine("Повторения есть!");
            else
                Console.WriteLine("Повторений нет!");

            // -------------------------------------
            // поиск совпадений через Equal
            Figures figures4 = Create();
            Output(figures4);

            repetition = false;
            for (int i = 0; i < figures3.Count - 1; i++)
            {
                for (int j = i + 1; j < figures3.Count; j++)
                {
                    repetition =
                        figures3[i].Equals(figures3[j]);
                    if (repetition)
                        break;
                }
                if (repetition)
                    break;
            }
            if (repetition)
                Console.WriteLine("Повторения есть!");
            else
                Console.WriteLine("Повторений нет!");
        }
    }
}
