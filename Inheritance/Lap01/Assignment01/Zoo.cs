using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    internal class Zoo
    {
        /*List<Tiger> tigers = new List<Tiger>();
        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();*/

        List<Animal> list = new List<Animal>();
        public void addAnimal(string name)
        {
            if (name.IndexOf('T') == 0)
            {
                Tiger tiger = new Tiger();
                Console.WriteLine("Input Name");
                tiger.Name = Console.ReadLine();
                Console.WriteLine("Input age");
                tiger.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input describe");
                tiger.Describe = Console.ReadLine();
                list.Add(tiger);
            }
            else if (name.IndexOf('D') == 0)
            {
                Dog dog = new Dog();
                Console.WriteLine("Input Name");
                dog.Name = Console.ReadLine();
                Console.WriteLine("Input age");
                dog.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input describe");
                dog.Describe = Console.ReadLine();
                list.Add(new Dog());
            }
            else if (name.IndexOf('C') == 0)
            {
                Cat cat = new Cat();
                Console.WriteLine("Input Name");
                cat.Name = Console.ReadLine();
                Console.WriteLine("Input age");
                cat.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Input describe");
                cat.Describe = Console.ReadLine();
                list.Add(new Cat());
            }
        }
        public void Show()
        {
            for (int i = 0; i < list.Count; i++)
                list[i].DisplayInfo();
            /*for (int i = 0; i < dogs.Count; i++)
                dogs[i].DisplayInfo();
            for (int i = 0; i < cats.Count; i++)
                cats[i].DisplayInfo();*/
        }
        public void searchAnimal(string name)
        {
            if (name.IndexOf('T') == 0)
            {
                foreach (Tiger tiger in list)
                {
                    if (name.Equals(tiger.Name))
                    {
                        tiger.DisplayInfo();
                    }
                }
            }
            else if (name.IndexOf('D') == 0)
            {
                foreach (Dog dog in list)
                {
                    if (name.Equals(dog.Name))
                    {
                        dog.DisplayInfo();
                    }
                }
            }
            else if (name.IndexOf('C') == 0)
            {
                foreach (Cat cat in list)
                {
                    if (name.Equals(cat.Name))
                    {
                        cat.DisplayInfo();
                    }
                }
            }
            else
            {
                Console.WriteLine("The name is'nt exist");
            }

        }
    }
}
