using System;
namespace Training1
{
    class Smartphone : Device
    {
        public double Screen{get;set;}
        public Smartphone(string brand, double Screen) :base(brand){this.Screen=Screen;}
        public override void Show()
        {
            System.Console.WriteLine($"Бренд телефона {this.brand}, Screen {this.Screen} inches");
        }
    }
    
    
}