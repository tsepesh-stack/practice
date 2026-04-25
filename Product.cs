using System;
namespace Training1
{
    class Product
    {
        public string Name {get; set;}
        private double price;

        public Product(string name, double price)
        {
            this.Name=name;
            this.price=price;
        }
        public Product(string name) : this(name, 0){}
        public Product() : this("неизвестно"){}

        
        public double Price
        {
            get
            {
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
            System.Console.WriteLine($"Товар: {Name}, Цена: {price}");
        }
    }
}