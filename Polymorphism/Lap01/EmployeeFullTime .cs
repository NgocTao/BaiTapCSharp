using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class EmployeeFullTime : Emloyee
    {
        internal double Basic_Salary;
        internal int Overtime;
        internal int TypeOfPosition;

        internal EmployeeFullTime()
        {

        }

        internal EmployeeFullTime(double basic_Salary, int overtime, int typeOfPosition)
        {
            Basic_Salary = basic_Salary; ;
            Overtime = overtime;
            TypeOfPosition = typeOfPosition;
        }

        internal override void inputInfo()
        {
            base.inputInfo();
            Console.WriteLine("Input basic salary:");
            Basic_Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Input overtime:");
            Overtime = int.Parse(Console.ReadLine());
            Console.WriteLine("Input position (1: Staff, 2: Director,, 3: Manager");
            TypeOfPosition = int.Parse(Console.ReadLine());
        }

        internal override void printInfo()
        {
            base.printInfo();
            Console.WriteLine("Basic salary: {0}\nOvertime: {1}", Basic_Salary, Overtime);
            switch (TypeOfPosition)
            {
                case 1:
                    Console.WriteLine("Position: Staff");
                    break;
                case 2:
                    Console.WriteLine("Position: Director");
                    break;
                case 3:
                    Console.WriteLine("Position: Manager");
                    break;
            }
        }

        internal override double calculateSalaty()
        {
            double salary = 0;
            switch (TypeOfPosition)
            {
                case 1:
                    salary = Basic_Salary + 200 + Overtime * 50;
                    break;
                case 2:
                    salary = Basic_Salary + 500 + Overtime * 50;
                    break;
                case 3:
                    salary = Basic_Salary + 300 + Overtime * 50;
                    break;
            }
            return base.calculateSalaty() + salary;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + String.Format("Basic salary: {0}\nOvertime: {1}\n nSalary: {2}", Basic_Salary, Overtime, calculateSalaty());
        }
    }
}
