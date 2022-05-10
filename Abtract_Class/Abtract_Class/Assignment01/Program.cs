using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class ZooTest
    {
        Zoo zoo = new Zoo();
        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu:\n1. Add animal\n2.Show animal\n3.Search by name\n4. Exit");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Do you want add animal (Tiger, Dog, Cat): ");
                        string name = Console.ReadLine();
                        zoo.addAnimal(name);
                        break;
                    case 2:
                        zoo.Show();
                        break;
                    case 3:
                        Console.WriteLine("Input name animal: ");
                        string a = Console.ReadLine();
                        zoo.searchAnimal(a);
                        break;
                    case 4:
                        break;
                }
            }

        }
    }
}
