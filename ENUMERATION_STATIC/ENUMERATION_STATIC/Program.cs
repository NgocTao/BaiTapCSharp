using System;
using System.Text;

namespace Practice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //////Product:
            Product product1 = new Product("AABB", 2, 300);
            product1.Show();
            Product product2 = new Product("ACCB", 3, 400);
            product2.Show();
            Product product3 = new Product("ACGG", 3, 200);
            product3.Show();
            product1.CalculatorPrice();
            product2.CalculatorPrice();
            product3.CalculatorPrice();
            Console.WriteLine("TOng tien = {0}", Product.TotalPrice);
        }

    }
}

