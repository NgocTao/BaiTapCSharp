using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class ShapeTest
    {
        ShapeManage shapeManage = new ShapeManage();
        List<Shape> shapes = new List<Shape>();
        internal ShapeTest()
        {
            while (true)
            {
                Console.WriteLine("Menu method:");
                Console.WriteLine
                    ("1. Add a new shape\n" +
                    "2.Print all shapes\n" +
                    "3.Show square\n" +
                    "4.Display circles which have maximum area\n" +
                    "5. Display circles which have minimum perimeter\n" +
                    "6. Exit");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Shape shape = new Shape();
                        shapes.Add(shape);
                        break;
                    case 2:
                        for (int i = 0; i < shapes.Count; i++)
                        {
                            Console.WriteLine(shapes[i]);
                        }
                        break;
                    case 3:
                        shapeManage.addRectangele();
                        shapeManage.showSquare();
                        break;
                    case 4:
                        shapeManage.addCircle();
                            shapeManage.displayMaxArea();
                        break;
                    case 5:
                        shapeManage.addCircle();
                        shapeManage.displayMinPerimeter();
                        break;
                    case 6:
                        break;
                }
            }

        }
    }
}
