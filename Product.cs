using System;
namespace Training1
{
    class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name=name;
            this.price=price;
        }
        public Product(string name) : this(name, 0){}
        public Product() : this("неизвестно"){}

        public string Name {get; set;}
        public double Price
        {
            get
            {
                System.Console.WriteLine("результат: ");
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    this.price = 0;
                } else
                {
                    this.price = value;
                }
            }
        }
        public void Print()
        {
            System.Console.WriteLine($"Товар: {name}, Цена: {price}");
        }
    }
}