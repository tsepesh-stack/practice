using System;
namespace Training1
{
    class Worker : Employee
    {
        public double HourlyRate{get; set;}
        public int HoursWorked{get; set;}
        
        public Worker(string name,Double HourlyRate, int HoursWorked){this.name=name; this.HourlyRate=HourlyRate;this.HoursWorked=HoursWorked;}
        public Worker(){}
        public override double GetSalary()
        {
            return HourlyRate*HoursWorked;
        }
    }
}