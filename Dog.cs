using System;
namespace Training1
{
    class Dog : Animal
    {
        public Dog(string name): base(name)
        {
            
        }
        public override void Makesound()
        {
            System.Console.WriteLine("Woof");
        }
        
    }
}