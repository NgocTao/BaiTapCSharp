using System;

namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] c = n.ToCharArray();
            //int x = ;
            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.Write(c[i]);
            }
            Console.ReadLine();
            // Console.WriteLine(c);
        }
    }
}
