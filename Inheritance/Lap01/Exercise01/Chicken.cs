using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    internal class Chicken : Animal
    {
        internal bool Wing;
        internal string Talk_acction;
        internal string Acction ;

        internal Chicken(): base()
        {
            Name = "Dog";
            Wing = true;
            Acction = "wing wagging";
            Talk_acction = "Fly";
        }

        public Chicken(string name, bool eyes, bool legs, bool run, bool sleep, bool tail, string talk, string acction) : base( name,  eyes,  legs,  run,  sleep)
        {
            Wing = tail;
            Talk_acction = talk;
            Acction = acction;
        }

    }
}
