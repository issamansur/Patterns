using System;

namespace Facade_and_patterns
{
    public class HomeTheaterFacade
    {
        public DVDPlayer dvdPlayer;
        public Projector projector;
        public Screen screen;
        public TheaterLights theaterLights;

        public HomeTheaterFacade(
            DVDPlayer dvdPlayer,
            Projector projector,
            Screen screen,
            TheaterLights theaterLights
            )
        {
            this.dvdPlayer = dvdPlayer;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
        }

        public void WatchMovie(string movie)
        {
            theaterLights.Dim(10);
            
            screen.Down();

            projector.On();
            projector.WideScreenMode();

            dvdPlayer.On();
            dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            theaterLights.Dim(70);

            dvdPlayer.Stop();
            
            projector.Off();
            
            screen.Up();
            
            dvdPlayer.Eject();
            dvdPlayer.Off();

            theaterLights.Dim(100);
        }
    }
}
