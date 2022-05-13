using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal class Staff : Cadres
    {
        internal string Work_name;

        internal Staff()
        {

        }

        internal Staff(string work_name)
        {
            Work_name = work_name;
        }

        internal override void inputInfo()
        {
            base.inputInfo();
            Console.WriteLine("Inpur work name: ");
        }

        internal override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Work name: {0}", Work_name);
        }

        public override string ToString()
        {
            return String.Format("Work name: {0}", Work_name) + base.ToString();
        }
    }
}
