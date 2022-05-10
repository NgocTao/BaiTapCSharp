using System;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
    internal class Emloyee
    {
        internal string Id = "";
        internal string Name = "";
        internal string Address = "";

        internal Emloyee()
        {

        }

        internal Emloyee(string id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }

        internal virtual void inputInfo()
        {
            Console.WriteLine("Inpur ID: ");
            Id = Console.ReadLine();
            Console.WriteLine("Inpur Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Inpur Address: ");
            Address = Console.ReadLine();
        }

        internal virtual void printInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nAddress: {2}", Id, Name, Address);
        }
        
        public override string ToString()
        {
            string a = "";
            a = string.Format("ID: {0}\nName: {1}\nAddress: {2}", Id, Name, Address);
            return a;
        }
        internal virtual double calculateSalaty()
        {
            double salary = 0;
            return salary;
        }
    }
}
