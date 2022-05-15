using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise02
{
    internal class Square : Rectangle
    {
        private int _edge;

        public int Edge
        {
            get
            {
                return _edge;
            }
            set
            {
                if (Edge < 0)
                    _edge = 0;
                else
                    _edge = value;
            }
        }

        public Square()
        {
            _edge = Width;
            _edge = Lenght;
        }

        public Square(int edge)
        {
            base.Width = edge;
            base.Lenght = edge;
            _edge = edge;
        }
        public override string ToString()
        {
            return String.Format("Area square is: {0}, Perimeter square is: {1}", getArea(), getPerimeter());
        }
    }
}
