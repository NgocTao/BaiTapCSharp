using System;

namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    internal class TeacherTest
    {
        ManageTeacher manageTeacher = new ManageTeacher();

        public void AddNewTeacher()
        {
            Teacher t = new Teacher();
            manageTeacher.AddTeacher(t);
        }
        public void ShowAllTeacher()
        {
            manageTeacher.ShowInfo();
        }
        public void SearchByName(string name)
        {
            manageTeacher.searchByName(name);
        }
        public void Display()
        {
            manageTeacher.displaySalary();
        }
    }
}
