using System;
namespace Training1
{
    class Lamp : ISwithcable
    {
        public string name{get;set;}
        public Lamp(string name){this.name=name;}
        public void TurnOn(){System.Console.WriteLine($"{name} включено");}
        public void TurnOff(){System.Console.WriteLine($"{name} выключено");}
    }
    
    
}