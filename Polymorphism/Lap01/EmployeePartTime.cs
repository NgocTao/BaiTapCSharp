using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class EmployeePartTime : Emloyee
    {
        internal int Work_Hour;

        internal EmployeePartTime()
        {

        }

        internal EmployeePartTime(int work_hour)
        {
            Work_Hour = work_hour;
        }

        internal override void inputInfo()
        {
            base.inputInfo();
            Console.WriteLine("Input work hour: ");
            Work_Hour = int.Parse(Console.ReadLine());
        }

        internal override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Work hour : {0}", Work_Hour);
        }
        internal override double calculateSalaty()
        {
            double salary = Work_Hour * 15;
            return base.calculateSalaty() + salary;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format("Work hour : {0}\nSalary: ", Work_Hour, calculateSalaty());
        }
    }
}
