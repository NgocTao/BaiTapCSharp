using System;
using System.Collections.Generic;
using System.Text;
using Lap01;


namespace Lap02
{
    public class Teacher : Person
    {
        public string Name = "";
        public string Sex = "";
        public string Birthday = "";
        public string Address = "";
        public string NameClass = "";
        public int WageOnHour;
        public int QuantityHourTeach;

        public override void InputInfo()
        {
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input Sex: ");
            Sex = Console.ReadLine();
            Console.WriteLine("Input Birday: ");
            Birthday = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Input name class (Name class begin by key: G, H, I, K, L, M): ");
            NameClass = Console.ReadLine();
            Console.WriteLine("Input  Wage on hour");
            WageOnHour = int.Parse(Console.ReadLine());
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Name: {0}\n,Sex: {1}\n,Birday: {2}\n,Address: {3}\nName Class: {4}\nWage On Hour: {5}}", Name, Sex, Birthday, Address, NameClass, WageOnHour);
        }

        public int GetWage()
        {
            int wage = 0;
            if (NameClass.IndexOf('L') == 0 || NameClass.IndexOf('M') == 0)
                wage = WageOnHour * QuantityHourTeach + 200000;
            else if (NameClass.IndexOf('G') == 0 || NameClass.IndexOf('H') == 0 || NameClass.IndexOf('I') == 0 || NameClass.IndexOf('K') == 0)
                wage = WageOnHour * QuantityHourTeach;
            return wage;
        }
    }
}
