using System;
namespace Training1
{
    class Student
    {
        private string name;
        private int grade;
        static int totalStudents;
        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
            totalStudents++;
        }
        public void PrintInfo()
        {
            System.Console.WriteLine($"Student Name: {name}, Grade: {grade}");
        }   
        public static void PrintTotal()
        {
            System.Console.WriteLine($"Total Students: {totalStudents}");
        }
    }
}