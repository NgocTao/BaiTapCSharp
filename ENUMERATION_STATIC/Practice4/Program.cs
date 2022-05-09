using System;
using System.Text;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DOWConverter dOWConverter = new DOWConverter();
            // Tìm thứ của ngày tháng năm sinh
            Console.WriteLine(dOWConverter.ConvertDaytoWeek(22, 12, 1993));

            //Tìm Ngày của Mẹ
            string dow = dOWConverter.ConvertDaytoWeek(1, 5, 2025);
            if (dow.Equals("Sunday"))
                Console.WriteLine(" Day Mom is: 8/5/");
            else if (dow.Equals("Monday"))
                Console.WriteLine(" Day Mom is: 14/5");
            else if (dow.Equals("Tuesday"))
                Console.WriteLine(" Day Mom is: 13/5");
            else if (dow.Equals("Wednesday"))
                Console.WriteLine(" Day Mom is: 12/5");
            else if (dow.Equals("Thursday"))
                Console.WriteLine(" Day Mom is: 11/5");
            else if (dow.Equals("Friday"))
                Console.WriteLine(" Day Mom is: 10/5");
            else if (dow.Equals("Saturday"))
                Console.WriteLine(" Day Mom is: 09/");

            //Tìm Ngày của ba
            string dow1 = dOWConverter.ConvertDaytoWeek(1, 6, 2022);
            Console.WriteLine(dow1);
            if (dow1.Equals("Sunday"))
                Console.WriteLine(" Day Dad is: 15/6/2022");
            else if (dow1.Equals("Monday"))
                Console.WriteLine(" Day Dad is: 21/6/2022");
            else if (dow1.Equals("Tuesday"))
                Console.WriteLine(" Day Dad is: 20/6/2022");
            else if (dow1.Equals("Wednesday"))
                Console.WriteLine(" Day Dad is: 19/6/2022");
            else if (dow1.Equals("Thursday"))
                Console.WriteLine(" Day Dad is: 18/6/2022");
            else if (dow1.Equals("Friday"))
                Console.WriteLine(" Day Dad is: 17/6/2022");
            else if (dow1.Equals("Saturday"))
                Console.WriteLine(" Day Dad is: 16/6/2022");
            Console.ReadLine();
        }
    }
}
