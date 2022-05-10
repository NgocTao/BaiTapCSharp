using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal class Book
    {
        internal string Code = "";
        internal string Title = "";
        internal int Price;
        internal string Authors = "";
        internal Book(string code, string title, int price, string suthor)
        {
            Code = code;
            Title = title;
            Price = price;
            Authors = suthor;
        }
        internal Book()
        {

        }
        internal void Display()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",Code,Title,Price,Authors);
        }
    }
}
