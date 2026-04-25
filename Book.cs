using System;
namespace Training1
{
    class Book
    {
        public string title;
        public string author;
        public Book(string title, string author)
        {
            this.title=title;
            this.author=author;
        }
        public Book() : this("Неизвестно", "Неизвестно"){}
        public void Print()
        {
            System.Console.WriteLine($"Книга: {this.title}, Автор: {this.author}");
        }
    }
}