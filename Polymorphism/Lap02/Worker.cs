using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal class Worker : Cadres
    {
        internal string Rank = "";

        internal Worker()
        {

        }

        internal Worker(string rank)
        {
            Rank = rank;
        }

        internal override void inputInfo()
        {
            base.inputInfo();
            Console.WriteLine("Input rank: ");
            Rank = Console.ReadLine();
        }

        internal override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("Rank: {0}", Rank);
        }

        public override string ToString()
        {
            return String.Format("Rank: {0}", Rank) + base.ToString();
        }
    }
}


