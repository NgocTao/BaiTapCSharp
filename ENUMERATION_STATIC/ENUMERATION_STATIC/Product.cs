using System;
using System.Collections.Generic;
using System.Text;

namespace Practice01
{
    internal class Product
    {
        private string Name;
        private int Quantity;
        private int Price;
        public int  Sum_Price;
        public Product(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;

        }
        public void Show()
        {
            Console.WriteLine("{0} \t, {1}, \t {2}",Name, Quantity, Price);
        }
        public int SumPrice()
        {
            return Sum_Price += Quantity * Price;
        }
    }


}
