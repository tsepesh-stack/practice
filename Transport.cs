using System;
namespace Training1
{
    class Transport
    {
        public string model{get; set;}
        public int speed{get; set;}
        public Transport(string model, int speed){this.model=model;this.speed=speed;}
        public Transport(){}
        public virtual void Show(){System.Console.WriteLine($"Модель: {this.model}, {this.speed} км/ч");}
    }
}