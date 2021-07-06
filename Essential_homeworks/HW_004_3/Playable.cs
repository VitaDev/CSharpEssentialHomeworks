using System;
using System.Collections.Generic;
using System.Text;

namespace HW_004_3
{
    public class Playable : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Начать проигрывание");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Пауза");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Record()
        {
            Console.WriteLine("Запись");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Стоп проигрывание");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Стоп запись");
        }
    }
}
