using System;

namespace Facade_and_patterns
{
    class Program
    {
        static void Main()
        {
            DVDPlayer player = new DVDPlayer();
            Projector projector = new Projector(player);
            TheaterLights theaterLights = new TheaterLights();
            Screen screen = new Screen();

            HomeTheaterFacade facade = new HomeTheaterFacade(player, projector, screen, theaterLights);

            facade.WatchMovie("Фокус");
            Console.WriteLine();
            facade.EndMovie();
        }
    }
}
