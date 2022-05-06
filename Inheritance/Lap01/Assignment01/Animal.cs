using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    public class Animal
    {
        public string Name = "";
        public int Age;
        public string Describe = "";
        public Animal()
        {

        }
        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name, int age)
        {
            Name = name; Age = age;
        }
        public Animal(string name, int age, string describe)
        {
            Name = name; Age = age; Describe = describe; 
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}\n,Age: {1}\n,Describe: {2}", Name, Age, Describe);
        }
        public virtual void TaklAnimal()
        {
            Console.WriteLine("Silence");
        }
    }
    public class Tiger : Animal
    {
        
        public override void TaklAnimal()
        {
            Console.WriteLine("Gru ...Gru");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
    public class Dog : Animal
    {
        public override void TaklAnimal()
        {
            Console.WriteLine("Gâu ...Gâu");

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
    public class Cat : Animal
    {
        public override void TaklAnimal()
        {
            Console.WriteLine("Meo ...Meo");

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
