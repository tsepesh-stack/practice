using System;
namespace Training1
{
    class Manager : Employee
    {
        public double BaseSalary {get; set;}
        public double Bonus {get; set;}
        public Manager(string name,double BaseSalary, double Bonus){this.name=name;this.BaseSalary=BaseSalary; this.Bonus=Bonus;}
        public Manager(string name, double BaseSalary) : this(name,BaseSalary,0){}
        public override double GetSalary()
        {
            return BaseSalary+Bonus;
        }
    }
}