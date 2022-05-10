using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment03
{
    internal class Student
    {
        internal string ID = "";
        internal double AverageScore;
        internal int Age;
        internal string NameClass = "";
        internal Student()
        {

        }
        internal Student(string id, double avegageScore, int age, string nameClass)
        {
            ID = id;
            AverageScore = avegageScore;
            Age = age;
            NameClass = nameClass;
        }
        internal void inputInfo()
        {
            while (true)
            {
                Console.WriteLine("Input ID:");
                string a = Console.ReadLine();
                if (a.Length == 8)
                {
                    ID = a;
                    break;
                }
                else
                {
                    Console.WriteLine("ID is invalid, Input ID again");
                }
            }

            while (true)
            {
                Console.WriteLine("Input average:");
                double result = 0;
                bool a = double.TryParse(Console.ReadLine(), out result);
                if (a == true)
                {
                    if (result<0 || result>10)
                    {
                        Console.WriteLine("Average score is invalid, Input Average score again");
                    }
                    else
                    {
                        AverageScore = result;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Average score is invalid, Input Average score again");
                }
            }
            while (true)
            {
                Console.WriteLine("Input age:");
                int result = 0;
                bool a = int.TryParse(Console.ReadLine(), out result);
                if (a == true)
                {
                    if (result<18)
                    {
                        Console.WriteLine("Age is invalid, Input Age again");
                    }
                    else if(result >= 18)
                    {
                        Age = result;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Age is invalid, Input Age again");
                }
            }
            while (true)
            {
                Console.WriteLine("Input Name class:");
                string a = Console.ReadLine();
                a = a.ToUpper();
                if (a.IndexOf('A')==0 || a.IndexOf('C') == 0)
                {
                    NameClass = a;
                    break;
                }
                else
                {
                    Console.WriteLine("Name class is invalid, Input name class again");
                }
            }

        }
        internal void showInfo()
        {
            Console.WriteLine("ID: {0}\nAverage score: {1}\nAge: {2}\nName class: {3}", ID, AverageScore, Age, NameClass);
        }
    }
}
