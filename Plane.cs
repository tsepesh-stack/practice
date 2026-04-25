using System;
namespace Training1
{
    class Plane : Vehicle
    {
        public Plane(string name, int speed) :  base(name,speed){}
        public override void GetInfo()
        {
            System.Console.WriteLine("Самолёт (устаревшее — аэроплан) — летательный аппарат тяжелее воздуха, предназначенный для полётов в атмосфере с помощью силовой установки, создающей тягу, и крыльев, создающих подъёмную силу.");
        }
        public override void Move()
        {
            base.Move();
        }
        
    }
}