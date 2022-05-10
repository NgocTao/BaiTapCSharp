using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    public abstract class Shape
    {
        public abstract double getArea();
        public abstract double getPerimeter();
    }
    public class Circle : Shape
    {
        public string Color = "";
        public bool Filled;
        public double Radius;
        public Circle()
        {
            Color = "Green";
            Filled = true;
            Radius = 1.0;
        }
        public Circle(double r)
        {
            Color = "Green";
            Filled = true;
            Radius = r;
        }
        public Circle(string color, bool filled, double r)
        {
            Radius = r;
            Color = color;
            Filled = filled;
        }
        public override double getArea()
        {
            return Radius * Radius * 3.14;
        }
        public override double getPerimeter()
        {
            return Radius * 2 * 3.14;
        }
        public override string ToString()
        {
            string a = "";
            string nameFilled = "filled";
            if (!Filled)
                nameFilled = "non-filled";
            a += String.Format("A circle with radius = {0}, A shape with color of {1} and {2}", Radius, Color, nameFilled);
            return a;
        }
    }

    public class Rectangele : Shape
    {
        public string Color = "";
        public bool Filled;
        public double Width;
        public double Length;
        public Rectangele()
        {
            Color = "Green";
            Filled = true;
            Width = 1.0;
            Length = 1.0;
        }
        public Rectangele(double w, double l)
        {
            Color = "Green";
            Filled = true;
            Width = w;
            Length = l;
        }
        public Rectangele(double w, double l, string color, bool filled)
        {
            Width = w;
            Length = l;
            Color = color;
            Filled = filled;
        }
        public override double getArea()
        {
            return Width * Length;
        }
        public override double getPerimeter()
        {
            return (Width + Length) * 2;
        }
        public override string ToString()
        {
            string a = "";
            string nameFilled = "filled";
            if (!Filled)
                nameFilled = "non-filled";
            a += String.Format("A Rectangle with width = {0}, length = {1},  A shape with color of {2} and {3}", Width, Length, Color, nameFilled);
            return a;
        }
    }





}
