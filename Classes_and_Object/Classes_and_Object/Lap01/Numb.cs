using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class Numb
    {
        private int Number1;
        private int Number2;
        public Numb()
        {

        }
        public Numb(int numb1, int numb2)
        {
            Number1 = numb1;
            Number2 = numb2;
        }
        public void inputInfo()
        {
            Console.WriteLine("Input number 1: ");
            Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            Number2 = int.Parse(Console.ReadLine());
        }
        public void printInfo()
        {
            Console.WriteLine(Number1);
            Console.WriteLine(Number2);
        }
        public void addition(int x)
        {
            int a = 0;
            Console.WriteLine("Add number 1: 0\nAdd number 2: 1");
            if (int.Parse(Console.ReadLine()) == 0)
                a = x + Number1;
            else if (int.Parse(Console.ReadLine()) == 1)
                a = x + Number2;
            Console.WriteLine("a = {0} ", a);
        }
        public void subtract(int x)
        {
            int a = 0;
            Console.WriteLine("Subtract number 1: 0\nSubtract number 2: 1");
            if (int.Parse(Console.ReadLine()) == 0)
                a = x - Number1;
            else if (int.Parse(Console.ReadLine()) == 1)
                a = x - Number2;
            Console.WriteLine("a = {0} ", a);

        }
        public void multi(int x)
        {
            int a = 0;
            Console.WriteLine("Multi number 1: 0\nMulti number 2: 1");
            if (int.Parse(Console.ReadLine()) == 0)
                a = x * Number1;
            else if (int.Parse(Console.ReadLine()) == 1)
                a = x * Number2;
            Console.WriteLine("a = {0} ", a);
        }
        public void division(int x)
        {
            int a = 0;
            Console.WriteLine("Division number 1: 0\nDivision number 2: 1");
            if (int.Parse(Console.ReadLine()) == 0)
                a = x / Number1;
            else if (int.Parse(Console.ReadLine()) == 1)
                a = x / Number2;
            Console.WriteLine("a = {0} ", a);
        }
    }

}
