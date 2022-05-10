using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class EmployeeManage
    {
        internal Emloyee[] empList;
        internal int maxEmp;
        internal int nextEmp;

        internal EmployeeManage()
        {
            empList = new Emloyee[maxEmp];
            maxEmp = 50;
            nextEmp = 0;
        }

        internal EmployeeManage(Emloyee[] emloyee, int max, int next)
        {
            empList = emloyee;
            maxEmp = max;
            nextEmp = next;
        }

        internal void addEmpoyee()
        {
            if (nextEmp == maxEmp)
            {
                Console.WriteLine("Can't add employee");
            }
            else
            {
                Console.WriteLine("Add employee fulltime: 0/nAdd employee partime: 1");
                int type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 0:
                        EmployeeFullTime employeeFullTime = new EmployeeFullTime();
                        employeeFullTime.inputInfo();
                        empList[nextEmp] = employeeFullTime;
                        break;
                    case 1:
                        EmployeePartTime employeePartTime = new EmployeePartTime();
                        employeePartTime.inputInfo();
                        empList[nextEmp] = employeePartTime;
                        break;
                }
            }
        }
        internal void showEmployee()
        {
            for (int i = 0; i <= nextEmp; i++)
            {
                Console.WriteLine(empList[i]);
            }
        }

        internal void showEmployeePartime()
        {
            for (int i = 0; i <= nextEmp; i++)
            {
                if (empList[i].GetType() == typeof (EmployeePartTime))
                {
                    Console.WriteLine(empList[i]);
                }
            }
        }
    }
}
