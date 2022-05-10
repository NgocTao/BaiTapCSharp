using System;

namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("book1 code","book1 title",200, "book1 author");
            Book book2 = new Book("book2 code","book2 title",300, "book2 author");
            Book book3 = new Book("book3 code","book3 title",400, "book3 author");
            book1.Display();
            book2.Display();
            book3.Display();
            Book[] books = new Book[3];
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            Book bookmax = books[0];
            foreach (var item in books)
            {
                if (item.Price>bookmax.Price)
                {
                    bookmax = item;
                }
            }

            Console.WriteLine("-------------Book have price best-----------------");
            bookmax.Display();
        }
    }
}
