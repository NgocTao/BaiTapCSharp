using System;
using System.Collections.Generic;
using System.Text;

namespace Practice03
{
    internal class ManageClassmate
    {
        public ManageClassmate()
        {
            Classmate[] classmates = new Classmate[50];
            for (int i = 0; i < classmates.Length; i++)
            {
                classmates[i].GetInfo()
            }
        }
    }
}
