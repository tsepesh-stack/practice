using System;
namespace Training1
{
    class Car
    {
        
        private string model;
        private int year;
        static int totalCars;
        public Car(string model, int year)
        {
            this.model = model; this.year = year;
            System.Console.WriteLine($"Создана машина - {model}");
            totalCars++;
        }
        public void Print()
        {
            System.Console.WriteLine($"Model: {model}, Year: {year}");
        }
        public static void PrintTotal()
        {
            System.Console.WriteLine($"Всего машин {totalCars}");
        }
    }
}