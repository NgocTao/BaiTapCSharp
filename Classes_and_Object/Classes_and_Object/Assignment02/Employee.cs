using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    internal class Employee
    {
        internal string Name = "";
        internal int Age;
        internal string Address = "";
        internal double Salary;
        internal int WorkingTime;

        internal Employee()
        {

        }

        internal Employee(string name, int age, string address, double salary, int workingTime)
        {
            Name = name;
            Age = age;
            Address = address;
            Salary = salary;
            WorkingTime = workingTime;
        }

        internal void inputInfo()
        {
            Console.WriteLine("Input name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input age: ");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Input address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Input salary: ");
            Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Input working time: ");
            WorkingTime = int.Parse(Console.ReadLine());
        }

        internal void printInfo()
        {
            Console.WriteLine("Name: {0}/nAge: {1}\nAddress: {2}\nSalary: {3}\nWorking time: {4}", Name, Age, Address, Salary, WorkingTime);
        }

        internal double calculateBonus()
        {
            double bonus = 0;
            if (WorkingTime > 200)
            {
                bonus = Salary * 0.2f;
            }
            else if (WorkingTime < 200 && WorkingTime >= 100)
            {
                bonus = Salary * 0.1f;

            }
            else if (WorkingTime < 100)
            {
                bonus = 0;
            }
            return bonus;
        }
    }
}
