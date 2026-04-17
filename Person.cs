using System;
namespace Training1
{
    class Person
    {
        public string Name {get; set;}
        private int age;
        public Person(string Name, int age){this.Name=Name; this.age=age;}
        
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    this.age=0;
                } else if (value > 120)
                {
                    this.age=0;
                } else
                {
                    this.age=value;
                }
            }
        }
        public bool IsAdult()
        {
            return age >= 18;
        }
        public void Print()
        {
            System.Console.WriteLine($"Name: {Name}, Age: {age} years");
        }
        
    }
}