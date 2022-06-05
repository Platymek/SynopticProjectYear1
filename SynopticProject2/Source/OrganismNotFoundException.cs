using System;
using System.Collections.Generic;
using System.Text;

namespace synopticProject.Source
{
    internal class OrganismNotFoundException : Exception
    {
        private readonly string Name;

        public OrganismNotFoundException(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "The organism, the " + Name + " was not found. " + base.ToString();
        }
    }
}
