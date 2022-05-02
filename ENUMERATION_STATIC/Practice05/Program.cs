using System;

namespace Practice05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket("A", 5);
            Ticket ticket2 = new Ticket("C", 9);
            Ticket ticket3 = new Ticket("G", 7);
            Ticket ticket4 = new Ticket("F", 97);
            Console.WriteLine(ticket1.SetType());
            Console.WriteLine(ticket2.SetType());
            Console.WriteLine(ticket3.SetType());
            Console.WriteLine(ticket4.SetType());

            ticket1.ShowInfo();

            Console.ReadLine();
        }
    }
}
