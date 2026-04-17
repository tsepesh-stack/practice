using System;
namespace Training1{
    class Employee
{
    private string name;
    private double salary;
    static int totalem;
    public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
            totalem++;
        }
        public void Print()
        {
            System.Console.WriteLine($"Name worker - {name}, and salary - {salary}");
        }
        public static void PrintTotal()
        {
            System.Console.WriteLine($"Total is - {totalem}");
        }
}
}