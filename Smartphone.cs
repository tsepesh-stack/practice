using System;
namespace Training1
{
    class Smartphone
    {
        private string model;
        private string version;
        private int storage;
        static int totalPhone;
        public Smartphone(string model, string version, int storage)
        {
            this.model=model;
            this.version=version;
            this.storage=storage;
            totalPhone++;
        }
        public void Print()
        {
            System.Console.WriteLine($"{model} {version}, {storage} ГБ");
        }
        public static void printTotal()
        {
            System.Console.WriteLine($"Phone total - {totalPhone}");
        }
    }
}