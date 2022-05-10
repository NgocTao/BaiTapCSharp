using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    internal class Person
    {
        internal int ID;
        internal string Name = "";
        internal int Birthdate;
        internal string Address = "";
        internal Person()
        {

        }
        internal Person(int id, string name, int birthdate, string address)
        {
            ID = id;
            Name = name;
            Birthdate = birthdate;
            Address = address;
        }
        internal void inputInfo()
        {
            Console.WriteLine("Input ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Input name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input birthdate: ");
            Birthdate = int.Parse(Console.ReadLine());
            Console.WriteLine("Input address: ");
            Address = Console.ReadLine();
        }
        internal void showInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nBirhtdate: {2}\nAddress: {3}", ID, Name, Birthdate, Address);
        }
    }
}
