using System;
using System.Diagnostics;
using Xunit;

namespace Figures.Tests
{
    public class EllipseTests
    {
        [Fact]
        public void Creating_objects_1000()
        {
            //Arrange
            Random random = new Random();
            Stopwatch counter = new Stopwatch();

            //Act
            counter.Start();
            for (int i = 0; i < 1000; i++)
            {
                int parametr_1 = random.Next(5) + 1;
                int parametr_2 = random.Next(5) + 1;
                Figure figure = new Ellipse(parametr_1, parametr_2);
            }
            counter.Stop();

            //Assert
            long min = counter.ElapsedMilliseconds / 60000;
            long sec = counter.ElapsedMilliseconds / 1000 % 60;
            long ms = counter.ElapsedMilliseconds % 1000;
            Console.WriteLine("Затрачено времени: {0} минут" +
                "{1} секунд {2} миллисекунд", min, sec, ms);
            Assert.InRange(counter.ElapsedMilliseconds, 0, 60000);
        }

        [Fact]
        public void Creating_objects_10000()
        {
            //Arrange
            Random random = new Random();
            Stopwatch counter = new Stopwatch();

            //Act
            counter.Start();
            for (int i = 0; i < 10000; i++)
            {
                int parametr_1 = random.Next(5) + 1;
                int parametr_2 = random.Next(5) + 1;
                Figure figure = new Ellipse(parametr_1, parametr_2);
            }
            counter.Stop();

            //Assert
            long min = counter.ElapsedMilliseconds / 60000;
            long sec = counter.ElapsedMilliseconds / 1000 % 60;
            long ms = counter.ElapsedMilliseconds % 1000;
            Console.WriteLine("Затрачено времени: {0} минут" +
                "{1} секунд {2} миллисекунд", min, sec, ms);
            Assert.InRange(counter.ElapsedMilliseconds, 0, 60000);
        }

        [Fact]
        public void Creating_objects_100000()
        {
            //Arrange
            Random random = new Random();
            Stopwatch counter = new Stopwatch();

            //Act
            counter.Start();
            for (int i = 0; i < 100000; i++)
            {
                int parametr_1 = random.Next(5) + 1;
                int parametr_2 = random.Next(5) + 1;
                Figure figure = new Ellipse(parametr_1, parametr_2);
            }
            counter.Stop();

            //Assert
            long min = counter.ElapsedMilliseconds / 60000;
            long sec = counter.ElapsedMilliseconds / 1000 % 60;
            long ms = counter.ElapsedMilliseconds % 1000;
            Console.WriteLine("Затрачено времени: {0} минут" +
                "{1} секунд {2} миллисекунд", min, sec, ms);
            Assert.InRange(counter.ElapsedMilliseconds, 0, 60000);
        }
    }
}
