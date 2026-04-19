using System;
namespace Training1
{
    class Car : Vehicle
    {
        public int door {get; set;}
        public Car(string brand, int year, int door) : base(brand, year)
        {
            this.door = door;
        }
        public override void Info()
        {
            System.Console.WriteLine($"Бренд: {this.brand}, Год выпуска: {this.year}, Дверей: {this.door}");;
        }
    }
}