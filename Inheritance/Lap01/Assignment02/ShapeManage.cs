using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class ShapeManage
    {
        internal List<Circle> circles;
        internal List<Rectangele> rectangeles;
        public ShapeManage()
        {
            circles = new List<Circle>();
            rectangeles = new List<Rectangele>();
        }
        public void addCircle()
        {
            Circle c = new Circle();
            circles.Add(c);
        }
        public void addRectangele()
        {
            Rectangele r = new Rectangele();
            rectangeles.Add(r);
        }
        public void printDetail()
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
        }
        public void showSquare()
        {
            for (int i = 0; i < rectangeles.Count; i++)
            {
                if (rectangeles[i].Width == rectangeles[i].Length)
                {
                    Console.WriteLine(rectangeles[i]);
                }
            }
        }
        public void displayMaxArea()
        {
            double Max = 0;
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].getArea() > Max)
                {
                    Max = circles[i].getArea();
                }
            }
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].getArea().Equals(Max))
                {
                    Console.WriteLine(circles[i]);
                }
            }
        }
        public void displayMinPerimeter()
        {
            double Min = double.MaxValue;
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].getPerimeter() < Min)
                {
                    Min = circles[i].getPerimeter();
                }
            }
            for (int i = 0; i < circles.Count; i++)
            {
                if (circles[i].getPerimeter().Equals(Min))
                {
                    Console.WriteLine(circles[i]);
                }
            }
        }
    }
}
