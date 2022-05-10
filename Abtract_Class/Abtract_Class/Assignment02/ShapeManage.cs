using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class ShapeManage
    {
        internal List<Shape> shapes;
        public ShapeManage()
        {
            shapes = new List<Shape>();
        }
        public void addCircle(Circle c)
        {
            //Circle c = new Circle();
            shapes.Add(c);
        }
        public void addRectangele()
        {
            Rectangele r = new Rectangele();
            shapes.Add(r);
        }
        public void printDetail()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine(shapes[i]);
            }
        }
        public void showSquare()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].GetType() == typeof(Rectangele))
                {
                    var rectShape = shapes[i] as Rectangele;

                    if (rectShape.Width == rectShape.Length)
                        Console.WriteLine(shapes[i]);
                }
            }
        }
        public double displayMaxArea()
        {
            Circle maAreaCircle = null;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].GetType() == typeof(Circle))
                {
                    var circle = shapes[i] as Circle;
                    if (maAreaCircle == null)
                    {
                        maAreaCircle = circle;
                    }
                    else
                    {
                        if (circle.getArea() > maAreaCircle.getArea())
                        {
                            maAreaCircle = circle;
                        }
                    }
                }
            }
            return maAreaCircle.getArea();
        }
        public double displayMinPerimeter()
        {
            Circle PeAreaCircle = null;
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].GetType() == typeof(Circle))
                {
                    var circle = shapes[i] as Circle;
                    if (PeAreaCircle == null)
                    {
                        PeAreaCircle = circle;
                    }
                    else
                    {
                        if (circle.getArea() > PeAreaCircle.getPerimeter())
                        {
                            PeAreaCircle = circle;
                        }
                    }
                }
            }
            return PeAreaCircle.getPerimeter();
        }
    }
}
