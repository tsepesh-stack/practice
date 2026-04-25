using System;
namespace Training1
{
    class Animal
    {
        public string name{get; set;}
        public int age {get; set;}
        public Animal(string name, int age)

        {
            this.age=age;
            this.name = name;
        }
        public virtual void Makesound()
        {
            System.Console.WriteLine($"Name {this.name}, age {this.age}, Some sound");
        }
    }
}