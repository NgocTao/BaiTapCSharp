using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class ManageTeacher
    {
        List<Teacher> TeacherList = new List<Teacher>();


        public int maxTeacher;
        public int nextTeacher;
        public void AddTeacher()
        {
            Console.WriteLine("Input  quantity Max Teacher: ");
            maxTeacher = int.Parse(Console.ReadLine());
            nextTeacher = TeacherList.Count;
            if (nextTeacher > maxTeacher)
                Console.WriteLine("The list teacher is full");
            else if (nextTeacher < maxTeacher)
            {
                for (int i = 0; i < maxTeacher; i++)
                {
                    Console.WriteLine("Input information teacher {0}", i + 1);
                    Teacher teacher = new Teacher();
                    TeacherList.Add(teacher);
                    TeacherList[i].InputInfo();
                }
            }
        }
        public void ShowInfo()
        {
            for (int i = 0; i < maxTeacher; i++)
            {
                if (TeacherList[i] == null)
                    Console.WriteLine("The list teacher is emty");
                else
                    TeacherList[i].ShowInfo();
            }
        }
        public double maxSalary()
        {
            double max = 0;
            for (int i = 0; i < maxTeacher; i++)
            {
                if (TeacherList[i].GetWage() > max)
                {
                    max = TeacherList[i].GetWage();
                }
            }
            return max;
        }
        public void displaySalary()
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            for (int i = 0; i < maxTeacher; i++)
            {
                if (TeacherList[i].GetWage().Equals(manageTeacher.maxSalary()))
                {
                    Console.WriteLine("Teacher have best salary is:");
                    TeacherList[i].ShowInfo();
                }
            }
        }
        public void searchByName(string nameTeacher)
        {
            for (int i = 0; i < maxTeacher; i++)
            {
                if (String.Compare(nameTeacher, TeacherList[i].Name) == 0)
                    TeacherList[i].ShowInfo();
                else
                    Console.WriteLine("Not found");
            }

        }
    }
}


