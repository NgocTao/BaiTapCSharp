using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    internal class ShapeTest
    {
        ShapeManage shapeManage = new ShapeManage();
        internal ShapeTest()
        {
            while (true)
            {
                Console.WriteLine("Menu method:");
                Console.WriteLine
                    ("1. Add a new shape\n" +
                    "2. Print all shapes\n" +
                    "3. Show square\n" +
                    "4. Display circles which have maximum area\n" +
                    "5. Display circles which have minimum perimeter\n" +
                    "6. Exit");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Add Circle: 0\nAdd Rectangele: 1");
                        int n = int.Parse(Console.ReadLine());
                        switch (n)
                        {
                            case 0:
                                Circle circle = new Circle();
                                shapeManage.shapes.Add(circle);
                                break;
                            case 1:
                                Rectangele rectangele = new Rectangele();
                                shapeManage.shapes.Add(rectangele);
                                break;
                        }
                        break;
                    case 2:
                        for (int i = 0; i < shapeManage.shapes.Count; i++)
                        {
                            Console.WriteLine(shapeManage.shapes[i]);
                        }
                        break;
                    case 3:
                        shapeManage.showSquare();
                        break;
                    case 4:
                        shapeManage.displayMaxArea();
                        break;
                    case 5:
                        shapeManage.displayMinPerimeter();
                        break;
                }
            }
        }
    }
}
