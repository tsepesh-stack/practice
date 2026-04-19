using System;
namespace Training1
{
    class Cat : Animal
    {
        public Cat(string name): base(name)
        {
            
        }
        public override void Makesound()
        {
            System.Console.WriteLine("Meow");
        }
        
    }
}