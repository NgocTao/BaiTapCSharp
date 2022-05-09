using System;

namespace Practice01
{
    internal class Product
    {
        private string _name;
        private int _quantity;
        private int _price;

        private static int _totalPrice;
        public static int TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Product(string name, int quantity, int price)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
        }
        public void Show()
        {
            Console.WriteLine("{0} \t, {1}, \t {2}", _name, _quantity, _price);
        }
        public int CalculatorPrice()
        {
            int a = _quantity * _price;
            _totalPrice += a;
            return a;
        }
    }


}
