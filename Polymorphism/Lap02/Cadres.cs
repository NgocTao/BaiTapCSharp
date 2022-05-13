using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal enum Sex
    {
        Male,
        Female
    }

    internal class Cadres
    {
        internal string Id = "";
        internal string FullName = "";
        internal string Birthdate = "";
        internal Sex Gender;
        internal int Basic_Salary;

        internal Cadres()
        {

        }

        internal Cadres(string id, string fullName, string birthdate, Sex sex, int basic_Salary)
        {
            Id = id;
            FullName = fullName;
            Birthdate = birthdate;
            Gender = sex;
            Basic_Salary = basic_Salary;
        }

        internal virtual void inputInfo()
        {
            Console.WriteLine("Input ID: ");
            Id = Console.ReadLine();
            Console.WriteLine("Input full name: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Input birthdate: ");
            Birthdate = Console.ReadLine();
            Console.WriteLine("Input gerder (0: Male, 1: Female");
            Sex Gender = (Sex)Enum.Parse(typeof(Sex), Console.ReadLine());
            Console.WriteLine("Input basic salary: ");
            Basic_Salary = int.Parse(Console.ReadLine());
        }

        internal virtual void showInfo()
        {
            Console.WriteLine("ID: {0}\nFull Name: {1}\nBrithdate: {2}\n Gender: {3}\nBasic salary: {4}", Id, FullName, Gender.ToString(), Basic_Salary);
        }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFull Name: {1}\nBrithdate: {2}\n Gender: {3}\nBasic salary: {4}", Id, FullName, Gender.ToString(), Basic_Salary);
        }
    }

}
