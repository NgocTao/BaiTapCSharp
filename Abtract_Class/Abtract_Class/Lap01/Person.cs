using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    public abstract class Person
    {
        public abstract void InputInfo();
        public abstract void ShowInfo();
    }

    internal class Student : Person
    {
        internal string Name = "";
        internal string Sex = "";
        internal string Birthday = "";
        internal string Address = "";
        public string ID = "";
        public float Average_Score;
        public string Email = "";

        internal Student()
        {

        }

        internal Student(string name, string sex, string birthday, string address)
        {
            Name = name;
            Sex = sex;
            Birthday = birthday;
            Address = address;
        }

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
            Console.WriteLine("Input Medium score (0.0 - 10.0): ");
            Average_Score = float.Parse(Console.ReadLine());
            Console.WriteLine("Input Seri student(8 char):");
            ID = Console.ReadLine();
            Console.WriteLine("Input Email:");
            Email = Console.ReadLine();
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name: {0}\n,Sex: {1}\n,Birday: {2}\n,Address: {3}\nMedium Score: {4}\nSeri Student: {5}\nEmail: {6}", Name, Sex, Birthday, Address, Average_Score, ID, Email);
        }
        public void Check()
        {
            if (Average_Score >= 8.0)
            {
                Console.WriteLine("Have scholarship");
            }
        }
    }
}

