using System;
namespace Training1
{
    class Cat : Animal
    {
        public Cat(string name, int age): base(name,age){}
        public override void Makesound()
        {
            System.Console.WriteLine($"Name {this.name}, age {this.age}, Meow");
        }
        
    }
}