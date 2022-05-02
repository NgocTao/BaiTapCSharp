using System;

namespace Lap01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentTest studentTest = new StudentTest();
            studentTest.GetInput();
            studentTest.ShowInfo();
            studentTest.ShowMediumScore();
            studentTest.FindbySeri("ádsadsad");
            studentTest.Scholarship();
            studentTest.Sort();
        } 
    }
}
