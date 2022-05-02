using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    public class Person
    {
        public string Name = "";
        public string Sex = "";
        public string Birday = "";
        public string Address = "";
        public virtual void InputInfo()
        {
            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input Sex: ");
            Sex = Console.ReadLine();
            Console.WriteLine("Input Birday: ");
            Birday = Console.ReadLine();
            Console.WriteLine("Input Address: ");
            Address = Console.ReadLine();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}\n,Sex: {1}\n,Birday: {2}\n,Address: {3}", Name, Sex, Birday, Address);
        }
    }
    public class Student : Person
    {
        public string SeriStudent = "";
        public float MediumScore;
        public string Email = "";
        public override void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Input Medium score (0.0 - 10.0): ");
            MediumScore = float.Parse(Console.ReadLine());
            Console.WriteLine("Input Seri student(8 char):");
            SeriStudent = Console.ReadLine();
            Console.WriteLine("Input Email:");
            Email = Console.ReadLine();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Medium score: {0}\n,Seri student: {1}\n,Email: {2}", MediumScore, SeriStudent, Email);
        }
        public void Check()
        {
            if (MediumScore >= 8.0)
            {
                Console.WriteLine("Have scholarship");
            }
        }
    }
}
