using System;
namespace Training1
{
    class Dog : Animal
    {
        public Dog(string name, int age): base(name,age){}
        public override void Makesound()
        {
            System.Console.WriteLine($"Name {this.name}, age {this.age}, Woof");
        }
        
    }
}