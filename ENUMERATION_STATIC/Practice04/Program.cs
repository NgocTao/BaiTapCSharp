using System;
using System.Text;

namespace Practice04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DOWConverter dOWConverter = new DOWConverter();
            Console.WriteLine(dOWConverter.ConvertDaytoWeek(8, 5, 2022));

            Console.ReadLine();
        }
    }
}
