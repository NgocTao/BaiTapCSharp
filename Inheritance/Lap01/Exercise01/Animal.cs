using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    internal class Animal
    {
        internal string Name { get; set; }
        internal bool Eyes;
        internal bool Legs;
        internal bool Run;
        internal bool Sleep;
        internal Animal()
        {
            Name = string.Empty;
            Eyes = true;
            Legs = true;
            Sleep = true;
        }
        internal Animal(string name, bool eyes, bool legs, bool run, bool sleep)
        {
            Name = name;
            Eyes = eyes;
            Legs = legs;
            Run = run;
            Sleep = sleep;
        }
    }
}
