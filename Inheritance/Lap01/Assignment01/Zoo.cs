using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    internal class Zoo
    {
        List<Tiger> tigers = new List<Tiger>();
        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        public void addAnimal(string name)
        {
            if (name.IndexOf('T') == 0)
            {
            tigers.Add(new Tiger());
                for (int i = 0; i < tigers.Count; i++)
                {
                    Console.WriteLine("Input Name");
                    tigers[i].Name = Console.ReadLine();
                    Console.WriteLine("Input age");
                    tigers[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input describe");
                    tigers[i].Describe = Console.ReadLine();
                }
            }
            else if (name.IndexOf('D') == 0)
            {
            dogs.Add(new Dog());
                for (int i = 0; i < dogs.Count; i++)
                {
                    Console.WriteLine("Input Name");
                    dogs[i].Name = Console.ReadLine();
                    Console.WriteLine("Input age");
                    dogs[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input describe");
                    dogs[i].Describe = Console.ReadLine();
                }
            }
            else if (name.IndexOf('C') == 0)
            {
                cats.Add(new Cat());
                for (int i = 0; i < cats.Count; i++)
                {
                    Console.WriteLine("Input Name");
                    cats[i].Name = Console.ReadLine();
                    Console.WriteLine("Input age");
                    cats[i].Age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input describe");
                    cats[i].Describe = Console.ReadLine();
                }
            }
        }
        public void Show()
        {
            for (int i = 0; i < tigers.Count; i++)
                tigers[i].DisplayInfo();
            for (int i = 0; i < dogs.Count; i++)
                dogs[i].DisplayInfo();
            for (int i = 0; i < cats.Count; i++)
                cats[i].DisplayInfo();
        }
        public void searchAnimal(string name)
        {
            if (name.IndexOf('T')==0)
            {
                foreach (Tiger tiger in tigers)
                {
                    if (name.Equals(tiger.Name))
                    {
                        tiger.DisplayInfo();
                    }
                }
            }
            else if (name.IndexOf('D') == 0)
            {
                foreach (Dog dog in dogs)
                {
                    if (name.Equals(dog.Name))
                    {
                        dog.DisplayInfo();
                    }
                }
            }
            else if (name.IndexOf('C') == 0)
            {
                foreach (Cat cat in cats)
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
