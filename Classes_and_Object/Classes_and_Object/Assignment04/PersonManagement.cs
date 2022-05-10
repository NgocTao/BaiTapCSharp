using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    internal class PersonManagement
    {
        internal Person[] list;
        internal int Max;
        internal int Next;
        internal PersonManagement()
        {
            list = new Person[Max];
            Max = 50;
            Next = 0;
        }
        internal void addPerson(Person person)
        {
            if (Next == Max)
            {
                Console.WriteLine("Can't add person");
            }
            else
            {
                list[Next] = person;
                Next++;
            }
        }
        internal void showInfo()
        {
            for (int i = 0; i < Next; i++)
            {
                list[i].showInfo();
            }
        }
        internal void serachID(int id)
        {
            for (int i = 0; i < Next; i++)
            {
                if (list[i].ID.Equals(id))
                {
                    list[i].showInfo();
                }
            }
        }
        internal void ShowByBirthdate()
        {
            for (int i = 0; i < Next; i++)
            {
                if (list[i].Birthdate >= 1995 && list[i].Birthdate <= 2000)
                {
                    list[i].showInfo();
                }
            }
        }
    }

}
