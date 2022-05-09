using System;
using System.Collections.Generic;
using System.Text;

namespace Practice03
{
    internal class ManageClassmate
    {
        public List<Classmate> Classmates;

        public ManageClassmate()
        {
            Classmates = new List<Classmate>(50);

        }

        public void Show()
        {
            for (int i = 0; i < Classmates.Count; i++)
            {
                Classmates[i].ShowInfo();
            }
        }
    }
}
