using System;
namespace Training1
{
    class Book
    {
        private string title;
        private string author;
        private int year;
        public static int totalBook;
        public Book(string title, string author, int year)
        {
            this.title=title;
            this.author=author;
            this.year=year;
            totalBook++;
        }
            public Book(string title, string author) : this(title, author, 0) { }
            public Book() : this("Неизвестно", "Неизвестно") { }
        public void Print()
        {
            System.Console.WriteLine($"Name of book:{this.title},Author:{this.author},year:{this.year}");
        }
        public static void TotalPrint()
        {
            System.Console.WriteLine($"Book - {totalBook}");
        }
    }
}