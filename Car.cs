using System;
namespace Training1
{
    class Car : Vehicle
    {
        public Car(string name, int speed) :  base(name,speed){}
        public override void GetInfo()
        {
            System.Console.WriteLine("Машина — термин, который означает техническое устройство, выполняющее механические движения для преобразования энергии, материалов и информации.");
        }
        public override void Move()
        {
            base.Move();
        }
        
    }
}