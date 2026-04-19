using System;
namespace Training1
{
    class Circle : Shape
    {
        public double radius {get; set;}
        public Circle(double radius)
        {
            this.radius =radius;
        }
        public override double GetArea()
        {
            return Math.PI*radius*radius;
        }
    }
}