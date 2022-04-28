using System;
using System.Text;

namespace ENUMERATION_STATIC
{
    internal class Program
    {
        /*static void Main1(string[] args)
        {
            //////Product:
            Product product1 = new Product("AABB", 2, 300);
            product1.Show();
            Product product2 = new Product("ACCB", 3, 400);
            product2.Show();
            Product product3 = new Product("ACGG", 3, 200);
            product3.Show();
            Console.WriteLine("Sum price: {0}", product1.SumPrice() + product2.SumPrice() + product3.SumPrice())
        }*/
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Currence:
            // Conver to VNĐ
            Console.WriteLine("Nhập số tiền muốn chuyển đổi sang VNĐ:");
            string Value = Console.ReadLine();
            Currency currency = new Currency();
            if (currency.CheckInput(Value))
                Console.WriteLine("Vui lòng nhập lại số tiền sang VNĐ:");
            else if (!currency.ConvertInput(Value))
                Console.WriteLine("Bạn cần nhập số tiền kiểu số, vd: 12312");
            else
            {
                Console.Write("Chọn loại ngoại tệ cần chuyển đổi \n: USD: 0\n, BAHT: 1\n, EUR: 2\n, HKD: 3\n, YEN: 4\n, WON: 5\n");
                //Parse string to enum
                CurrencyType a = (CurrencyType)Enum.Parse(typeof(CurrencyType), Console.ReadLine());
                int NumbCurrence = int.Parse(Value);
                Console.WriteLine("{0} VNĐ", currency.ConvertToVND(NumbCurrence, a));

            }

            // Convert from VND
            Console.WriteLine("Nhập số tiền muốn chuyển đổi từ VNĐ:");
            string Value1 = Console.ReadLine();
            if (currency.CheckInput(Value1))
                Console.WriteLine("Vui lòng nhập lại số tiền từ VNĐ:");
            else if (!currency.ConvertInput(Value1))
                Console.WriteLine("Bạn cần nhập số tiền kiểu số, vd: 12312");
            else
            {
                Console.Write("Chọn loại ngoại tệ cần chuyển đổi \n: USD: 0\n, BAHT: 1\n, EUR: 2\n, HKD: 3\n, YEN: 4\n, WON: 5\n");
                //Parse string to enum
                CurrencyType b = (CurrencyType)Enum.Parse(typeof(CurrencyType), Console.ReadLine());
                int NumbCurrence1 = int.Parse(Value1);

                if (b == CurrencyType.USD)
                    Console.WriteLine("{0} USD", currency.ConvertFromVND(NumbCurrence1, b));
                else if (b == CurrencyType.BAHT)
                    Console.WriteLine("{0} BAHT", currency.ConvertFromVND(NumbCurrence1, b));
                else if (b == CurrencyType.EUR)
                    Console.WriteLine("{0} EUR", currency.ConvertFromVND(NumbCurrence1, b));
                else if (b == CurrencyType.HKD)
                    Console.WriteLine("{0} HKD", currency.ConvertFromVND(NumbCurrence1, b));
                else if (b == CurrencyType.YEN)
                    Console.WriteLine("{0} YEN", currency.ConvertFromVND(NumbCurrence1, b));
                else if (b == CurrencyType.WON)
                    Console.WriteLine("{0} WON", currency.ConvertFromVND(NumbCurrence1, b));
            }
            Console.Write("Chọn loại ngoại tệ để xem mệnh giá \n: USD: 0\n, BAHT: 1\n, EUR: 2\n, HKD: 3\n, YEN: 4\n, WON: 5\n");
            CurrencyType c = (CurrencyType)Enum.Parse(typeof(CurrencyType), Console.ReadLine());
            Console.WriteLine("{0} VNĐ", currency.FindForeignExchange(c));
            Console.WriteLine(currency.showForeignExchangeList());
        }
    }
}

