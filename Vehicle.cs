using System;
namespace Training1
{
    class Vehicle
    {
        public string brand {get; set;}
        public int year {get; set;}
        public Vehicle(string brand, int year){this.brand=brand;this.year=year;}
        public virtual void Info()
        {
            System.Console.WriteLine($"Бренд: {this.brand}, Год выпуска: {this.year}");
        }
    }
}