using System;
namespace Training1
{
    class Device
    {
        public string brand{get;set;}
        public Device(string brand){this.brand=brand;}
        public virtual void Show(){System.Console.WriteLine($"Модель устройства {brand}");}
    }
}