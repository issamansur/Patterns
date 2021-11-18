using System;

namespace Facade_and_patterns
{
    public class DVDPlayer
    {
        public string Film { private set; get; }

        public void On()
        {
            Console.WriteLine("DVD-плеер включён");
        }

        public void Play(string movie)
        {
            this.Film = movie;
            Console.WriteLine($"Фильм {Film} теперь воспроизводство");
        }

        public void Pause()
        {
            Console.WriteLine($"Фильм {Film} поставлен на паузу");
        }

        public void Stop()
        {
            Console.WriteLine($"Фильм {Film} выключен");
        }

        public void Eject()
        {
            Console.WriteLine("Диск извлечён");
        }

        public void Off()
        {
            Console.WriteLine("DVD-плеер выключен");
        }
    }
}
