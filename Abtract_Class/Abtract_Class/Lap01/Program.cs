using System;
using System.Collections.Generic;

namespace Lap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    internal class StudentTest
    {
        List<Student> StudentList = new List<Student>();
        public void GetInput()
        {
            Console.WriteLine("Quantity student input:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Input information student {0}", i + 1);
                Student student = new Student();
                student.InputInfo();
                StudentList.Add(student);
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("-------------------------------------------");

            for (int i = 0; i < StudentList.Count; i++)
            {
                Console.WriteLine("Information student {0}", i + 1);
                StudentList[i].ShowInfo();
            }
        }
        public void ShowMediumScore()
        {
            float Max = 0;
            float Min = 10.0f;
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].Average_Score >= Max)
                {
                    Max = StudentList[i].Average_Score;
                }
                if (StudentList[i].Average_Score <= Min)
                {
                    Min = StudentList[i].Average_Score;
                }
            }
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].Average_Score.Equals(Max))
                {
                    Console.WriteLine("Studen have best medium score is: ");
                    StudentList[i].ShowInfo();
                }
                if (StudentList[i].Average_Score.Equals(Min))
                {
                    Console.WriteLine("Studen have lowest  medium score is: ");
                    StudentList[i].ShowInfo();
                }
            }
        }

        public void ShowMediumScore1()
        {
            Student best = StudentList[0];
            Student worst = StudentList[0];
            foreach (var sv in StudentList)
            {
                if (sv.Average_Score > best.Average_Score)
                    best = sv;
                if (sv.Average_Score < worst.Average_Score)
                    worst = sv;
            }
        }

        public void FindbySeri(string seriStudent)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (seriStudent.Equals(StudentList[i].ID))
                {
                    StudentList[i].ShowInfo();
                }
            }
        }
        public void Scholarship()
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].Average_Score > 8.0)
                {
                    StudentList[i].ShowInfo();
                }
            }
        }
        public void Sort()
        {
            for (int i = 0; i <= StudentList.Count - 1; i++)
            {
                for (int j = i + 1; j < StudentList.Count; j++)
                {
                    if (StudentList[i].Average_Score < StudentList[j].Average_Score)
                    {
                        Student a = StudentList[i];
                        StudentList[i] = StudentList[j];
                        StudentList[j] = a;
                    }
                }
            }
        }
    }
}
