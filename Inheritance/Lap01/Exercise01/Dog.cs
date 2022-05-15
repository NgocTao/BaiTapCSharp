using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    internal class Dog : Animal
    {
        internal bool Tail;
        internal string Talk_acction;
        internal string Acction ;

        internal Dog(): base()
        {
            Name = "Dog";
            Tail = true;
            Acction = "tail wagging";
            Talk_acction = "Gau Gau";
        }

        public Dog(string name, bool eyes, bool legs, bool run, bool sleep, bool tail, string talk, string acction) : base( name,  eyes,  legs,  run,  sleep)
        {
            Tail = tail;
            Talk_acction = talk;
            Acction = acction;
        }

    }
}
