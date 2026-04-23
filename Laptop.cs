using System;
namespace Training1
{
    class Laptop : Device
    {
        public int ram{get;set;}
        public Laptop(string brand, int ram) :base(brand){this.ram=ram;}
        public override void Show()
        {
            System.Console.WriteLine($"Бренд планшета {this.brand}, Память {ram} gb");
        }
    }
    
    
}