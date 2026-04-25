using System;
namespace Training1
{
    class Calculator
    {
       
        public void Culculate(int a, int b)
        {
            int res = a+b;
            System.Console.WriteLine(res);            
        }
        public void Culculate(int a, int b, int c)
        {
            int res = a+b+c;
            System.Console.WriteLine(res);            
        }
        public void Culculate(double d, double g)
        {
            double res = d+g;
            System.Console.WriteLine(res);            
        }
        public void Culculate(string str1, string str2)
        {
            string res = str1+str2;
            System.Console.WriteLine(res);            
        }
    }
}