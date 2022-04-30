using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practice03
{
    internal class Classmate
    {
        private string Name = "";
        private string Position = "";
        public int NameGroup;
        private int Quantity;
        private ArrayList Group = new ArrayList();
        private ArrayList Student = new ArrayList();
        public string NameTecher = "";
        public void GetInfo(string name, string poisition, int nameGroup)
        {
            Name = name;
            Position = poisition;
            NameGroup = nameGroup;
            ArrayList Student = new ArrayList { Name, Position, NameGroup };
            if (NameGroup.Equals(1))
            {
                ArrayList Group1 = new ArrayList();
                Group1.AddRange(Student);
                Group.AddRange(Group1);
            }
            else if (NameGroup.Equals(2))
            {
                ArrayList Group2 = new ArrayList();
                Group2.AddRange(Student);
                Group.AddRange(Group2);
            }
            else if (NameGroup.Equals(3))
            {
                ArrayList Group3 = new ArrayList();
                Group3.AddRange(Student);
                Group.AddRange(Group3);
            }
            else if (NameGroup.Equals(4))
            {
                ArrayList Group4 = new ArrayList();
                Group4.AddRange(Student);
                Group.AddRange(Group4);
            }
            else if (NameGroup.Equals(2))
            {
                ArrayList Group5 = new ArrayList();
                Group5.AddRange(Student);
                Group.AddRange(Group5);
            }
            Quantity++;
        }
        public void GreateGroup(int numbGroup)
        {
            for (int i = 0; i < Group.Count; i++)
            {
                if (i == numbGroup )
                {
                    Console.WriteLine(Group[i]);
                }
            }
        }
    }
}
