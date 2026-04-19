using System;
namespace Training1
{
    class Animal
    {
        public string name{get; set;}
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual void Makesound()
        {
            System.Console.WriteLine("Some sound");
        }
    }
}