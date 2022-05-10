using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    public abstract class Animal
    {
        public abstract void Display();
        public abstract void TaklAnimal();
    }

    public class Tiger : Animal
    {
        public string Name = "";
        public int Age;
        public string Describe = "";

        public Tiger()
        {

        }

        public Tiger(string name)
        {
            Name = name;
        }

        public Tiger(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Tiger(string name, int age, string describe)
        {
            Name = name;
            Age = age;
            Describe = describe;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}\n,Age: {1}\n,Describe: {2}", Name, Age, Describe);
        }

        public override void TaklAnimal()
        {
            Console.WriteLine("Gru ...Gru");
        }
    }

    public class Dog : Animal
    {
        public string Name = "";
        public int Age;
        public string Describe = "";

        public Dog()
        {

        }

        public Dog(string name)
        {
            Name = name;
        }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog(string name, int age, string describe)
        {
            Name = name;
            Age = age;
            Describe = describe;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}\n,Age: {1}\n,Describe: {2}", Name, Age, Describe);
        }

        public override void TaklAnimal()
        {
            Console.WriteLine("Gâu ...Gâu");
        }
    }

    public class Cat : Animal
    {
        public string Name = "";
        public int Age;
        public string Describe = "";

        public Cat()
        {

        }

        public Cat(string name)
        {
            Name = name;
        }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Cat(string name, int age, string describe)
        {
            Name = name;
            Age = age;
            Describe = describe;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}\n,Age: {1}\n,Describe: {2}", Name, Age, Describe);
        }

        public override void TaklAnimal()
        {
            Console.WriteLine("Meo ...Meo");
        }
    }
}
