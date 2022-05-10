using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            Rectangle rectangle2 = new Rectangle();
            Rectangle rectangle3 = new Rectangle();
            Rectangle[] rectangles = { rectangle1, rectangle2, rectangle3 };
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i].ShowInfo();
                if (rectangles[i].Lenght == rectangles[i].Width)
                {
                    Console.WriteLine("Rectangle {0} is square", i);
                    rectangles[i].ShowInfo();
                }
            }
        }
    }
}
