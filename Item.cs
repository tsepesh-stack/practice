using System;
namespace Training1
{
    class Item
    {
        private string name;
        private double price;
        public static double totali;
        public Item(string name, double price)
        {
            this.name=name;
            this.price=price;
            totali++;
        }
        public Item(string name) : this(name,0){}
        public Item() : this("Неизвестно"){}
        public void Print()
        {
            System.Console.WriteLine($"Item name-{name}, item price-{price}");
        }
        public static void PrintInfo()
        {
            System.Console.WriteLine($"Item total-{totali}");
        }

    }
}