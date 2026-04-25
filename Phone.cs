using System;
namespace Training1
{
    class Phone : ISwithcable,IChargeable
    {
        public string name{get;set;}
        public Phone(string name){this.name=name;}
        public void TurnOn(){System.Console.WriteLine($"{name} включено");}
        public void TurnOff(){System.Console.WriteLine($"{name} выключено");}
        public void Charge(){System.Console.WriteLine($"{name} заряжается...");}
    }
    
    
}