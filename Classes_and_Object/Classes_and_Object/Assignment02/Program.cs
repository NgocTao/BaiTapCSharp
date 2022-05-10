using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.inputInfo();
            employee.printInfo();
            employee.calculateBonus();
        }
    }
}
