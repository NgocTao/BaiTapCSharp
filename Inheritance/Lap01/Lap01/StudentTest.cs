using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lap01
{
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
                StudentList.Add(student);
                StudentList[i].InputInfo();

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
                if (StudentList[i].MediumScore >= Max)
                {
                    Max = StudentList[i].MediumScore;
                }
                if (StudentList[i].MediumScore <= Min)
                {
                    Min = StudentList[i].MediumScore;
                }
            }
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].MediumScore.Equals(Max))
                {
                    Console.WriteLine("Studen have best medium score is: ");
                    StudentList[i].ShowInfo();
                }
                if (StudentList[i].MediumScore.Equals(Min))
                {
                    Console.WriteLine("Studen have lowest  medium score is: ");
                    StudentList[i].ShowInfo();
                }
            }
        }
        public void FindbySeri(string seriStudent)
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (seriStudent.Equals(StudentList[i].SeriStudent))
                {
                    StudentList[i].ShowInfo();
                }
            }
        }
        public void Scholarship()
        {
            for (int i = 0; i < StudentList.Count; i++)
            {
                if (StudentList[i].MediumScore > 8.0)
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
                    if (StudentList[i].MediumScore < StudentList[j].MediumScore)
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
