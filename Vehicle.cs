using System;
namespace Training1
{
    abstract class Vehicle
    {
        public string brand {get; set;}
        public int speed {get; set;}
        public Vehicle(string brand, int speed){this.brand=brand;this.speed=speed;}
        public abstract void GetInfo();
        public virtual void Move(){System.Console.WriteLine($"{brand} движется со скоростью {speed} км/ч");}
        
    }
}