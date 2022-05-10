using System;

namespace Lap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    internal class EmployeeTest
    {
        EmployeeManage employeeManage = new EmployeeManage();
        internal EmployeeTest()
        {
            while (true)
            {
                Console.WriteLine("Menu method:");
                Console.WriteLine
                    ("1. Add a new employee\n" +
                    "2. Print all employee\n" +
                    "3. Show part time employees\n" +
                    "4. Search employee by id\n" +
                    "5. Exit");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        employeeManage.addEmpoyee();
                        break;
                    case 2:
                        employeeManage.printEmployees();
                        break;
                    case 3:
                        employeeManage.showEmployeePartime();
                        break;
                    case 4:
                        Console.WriteLine("Input ID search:");
                        employeeManage.searchEmployeeById(Console.ReadLine());
                        break;
                    case 5:
                        break;
                }
            }
        }
	}
}
