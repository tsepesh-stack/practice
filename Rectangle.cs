using System;
namespace Training1
{
    class Rectangle : Shape
    {
        public double widht {get; set;}
        public double height {get; set;}
        public Rectangle(double widht, double height)
        {
            this.widht = widht;
            this.height = height;
        }
        public override double GetArea()
        {
            return widht*height;
        }
    }
}