using System;
namespace Training1
{
    class Instrument
    {
        public string name {get; set;}
        public virtual void Play()
        {
            System.Console.WriteLine("Playing instrument");
        }
    }
}