using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class ManageTeacher
    {
        //List<Teacher> TeacherList = new List<Teacher>();
        Teacher[] teachers = new Teacher[50];

        public int maxTeacher;
        public int nextTeacher = 0;
        public void AddTeacher(Teacher t)
        {
            Console.WriteLine("Input  quantity Max Teacher: ");
            maxTeacher = int.Parse(Console.ReadLine());
            if (nextTeacher == maxTeacher)
            {
                Console.WriteLine("Can't add teacher");
            }
            else
            {
                Teacher teacher = new Teacher();
                teachers[nextTeacher] = teacher;
                nextTeacher++;
            }
        }
        public void ShowInfo()
        {
            for (int i = 0; i < maxTeacher; i++)
            {
                if (teachers[i] == null)
                    Console.WriteLine("The list teacher is emty");
                else
                    teachers[i].ShowInfo();
            }
        }
        public double maxSalary()
        {
            double max = 0;
            for (int i = 0; i < maxTeacher; i++)
            {
                if (teachers[i].GetWage() > max)
                {
                    max = teachers[i].GetWage();
                }
            }
            return max;
        }
        public void displaySalary()
        {
            ManageTeacher manageTeacher = new ManageTeacher();
            for (int i = 0; i < maxTeacher; i++)
            {
                if (teachers[i].GetWage().Equals(manageTeacher.maxSalary()))
                {
                    Console.WriteLine("Teacher have best salary is:");
                    teachers[i].ShowInfo();
                }
            }
        }
        public void searchByName(string nameTeacher)
        {
            for (int i = 0; i < maxTeacher; i++)
            {
                if (String.Compare(nameTeacher, teachers[i].Name) == 0)
                    teachers[i].ShowInfo();
                else
                    Console.WriteLine("Not found");
            }

        }
    }
}


