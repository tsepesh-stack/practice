using System;
namespace Training1
{
    class Boat : Vehicle
    {
        public Boat(string name, int speed) :  base(name,speed){}
        public override void GetInfo()
        {
            System.Console.WriteLine("Корабль — это крупное морское судно, которое может выполнять различные задачи в зависимости от типа и назначения.");
        }
        public override void Move()
        {
            base.Move();
        }
    }
}