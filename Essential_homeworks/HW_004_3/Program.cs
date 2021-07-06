using System;

namespace HW_004_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Playable();
            playable.Play();
            playable.Pause();
            playable.Stop();

            IRecodable recodable = new Playable();
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
    }
}
