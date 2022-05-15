using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03
{
    internal class _2D
    {
        private float _x;
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }
        private float _y;
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public _2D(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public _2D()
        {

        }
        public virtual void Display()
        {
            Console.WriteLine("Poisition: ({0},{1})", _x, _y);
        }
    }
}
