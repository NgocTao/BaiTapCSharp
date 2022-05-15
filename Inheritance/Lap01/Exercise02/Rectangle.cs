using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    internal class Rectangle
    {
        private int _lenght;

        public int Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (Lenght < 0)
                    _lenght = 0;
                else
                    _lenght = value;
            }
        }

        private int _width;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (Width < 0)
                    _width = 0;
                else
                    _width = value;
            }
        }
        public Rectangle()
        {

        }
        public Rectangle(int lenght, int width)
        {
            _lenght = lenght;
            _width = width;
        }

        public int getArea()
        {
            return _lenght * _width;
        }

        public int getPerimeter()
        {
            return (_lenght + _width) * 2;
        }

        public override string ToString()
        {
            return String.Format("Area rectangle is: {0}, Perimeter rectangle is: {1}", getArea(), getPerimeter());
        }
    }
}
