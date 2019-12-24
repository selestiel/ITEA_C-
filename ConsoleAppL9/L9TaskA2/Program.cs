using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9TaskA2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();

    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play");
            
        }
        void IPlayable.Pause()
        {

            Console.WriteLine("Pause play");
        }
        void IPlayable.Stop()
        {

            Console.WriteLine("Stop play");
        }
        public void Record()
        {

            Console.WriteLine("Record");
        }

        void IRecordable.Pause()
        {

            Console.WriteLine("Pause Record");
        }
        void IRecordable.Stop()
        {

            Console.WriteLine("Stop Record");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            IPlayable play = player as IPlayable;
            play.Play();
            play.Pause();
            play.Stop();
            IRecordable rec = player as IRecordable;
            rec.Record();
            rec.Pause();
            rec.Stop();
            Console.ReadKey();
        }
    }

}
