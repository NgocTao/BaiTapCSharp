using System;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3D A = new _3D(1, 2, 3);
            _3D B = new _3D(0, 0, 6);
            _3D C = new _3D();
            A.Display();
            B.Display();
            C.Display();
            Console.ReadLine();
        }
    }
}
