using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise03
{
    internal class _3D : _2D
    {
        private float _z;
        public float Z
        {
            get { return _z; }
            set { _z = value; }
        }

        public _3D(float x, float y, float z) : base(x, y)
        {
            _z = z;
        }

        public _3D(float z)
        {
            base.X = 0;
            base.Y = 0;
            z = _z;
        }

        public _3D()
        {

        }

        public override void Display()
        {
            Console.WriteLine("Poisition : ({0},{1},{2})", X, Y, _z);
        }
    }
}
