using System;
namespace Training1
{
    class Truck : Vehicle
    {
        public double LoadCapacity {get; set;}
        public Truck(string brand, int year, double LoadCapacity) : base(brand, year)
        {
            this.LoadCapacity = LoadCapacity;
        }
        public override void Info()
        {
            System.Console.WriteLine($"Бренд: {this.brand}, Год выпуска: {this.year}, Грузоподъемность: {this.LoadCapacity}");;
        }
        
    }
}