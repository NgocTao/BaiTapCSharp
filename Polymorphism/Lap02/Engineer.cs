using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal class Engineer : Cadres
    {
        internal string Career = "";

        internal Engineer()
        {

        }

        internal Engineer(string career)
        {
            Career = career;
        }

        internal override void inputInfo()
        {
            base.inputInfo();
            Console.WriteLine("Input career: ");
        }

        internal override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Carreer: {0}", Career);
        }
        public override string ToString()
        {
            return String.Format("Carreer: {0}", Career) + base.ToString();
        }
    }
}
