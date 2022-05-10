using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
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
