using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    public class Shape
    {
        public string Color = "";
        public bool Filled;
        public Shape()
        {
            Color = "Green";
            Filled = true;
        }
        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }
        public override string ToString()
        {
            string a = "";
            a += String.Format("A shape with color of {0} and filled", Color);
            return a;
        }
    }
    public class Circle : Shape
    {
        public double Radius;
        public Circle()
        {
            Radius = 1.0;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public Circle(string color, bool filled, double r)
        {
            Radius = r;
            Color = color;
            Filled = filled;
        }
        public double getArea()
        {
            return Radius * Radius * 3.14;
        }
        public double getPerimeter()
        {
            return Radius * 2 * 3.14;
        }
        public override string ToString()
        {
            string a = "";
            a += String.Format("A circle with radius = {0}, which is a subclass of ", Radius) + base.ToString();
            return a;
        }
    }
    public class Rectangele : Shape
    {
        public double Width;
        public double Length;
        public Rectangele()
        {
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangele(double w, double l)
        {
            Width = w;
            Length = l;
        }
        public Rectangele(double w, double l, string color, bool filled)
        {
            Width = w;
            Width = l;
            Color = color;
            Filled = filled;
        }
        public double getArea()
        {
            return Width * Length;
        }
        public double getPerimeter()
        {
            return (Width + Length) * 2;
        }
        public override string ToString()
        {
            string a = "";
            a += String.Format("A Rectangle with width = {0}, length = {1}, which is a subclass of ", Width, Length) + base.ToString();
            return a;
        }
    }

}
