using System;
namespace Training1
{
    class Bike : Transport
    {
        public int gears {get; set;}
        
        public Bike(string model, int speed, int gears) :base(model,speed){this.gears=gears;}
        public override void Show()
        {
            System.Console.WriteLine($"Велосипед: {this.model}, {this.speed} км/ч, передач {this.gears}");;
        }
    }
}