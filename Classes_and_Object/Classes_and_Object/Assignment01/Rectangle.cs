using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    internal class Rectangle
    {
        internal int Width;
        internal int Lenght;
        internal Rectangle(int width, int lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        internal Rectangle()
        {

        }
        internal int CalArea()
        {
            return Width * Lenght;
        }
        internal int CalPerimeter()
        {
            return (Width + Lenght) * 2;
        }
        internal void Input()
        {
            Console.WriteLine("input width:");
            Width = int.Parse(Console.ReadLine());
            Console.WriteLine("input lenght:");
            Lenght = int.Parse(Console.ReadLine());
        }
        internal void ShowInfo()
        {
            Console.WriteLine("Width: {0}\nLenght{1}\nArea: {2}\nPerimeter: {3}", Width, Lenght, CalArea(), CalPerimeter());
        }
    }
}
