using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace synopticProject.Source
{
    public class Location
    {
        public Organism[] Organisms { get; private set; }
        public Vector2 Position { get; private set; }
        public int Radius { get; private set; }
        public string Name { get; private set; }

        public Location(string name, Vector2 position, int radius, Organism[] organisms)
        {
            Organisms = organisms;
            Position = position;
            Radius = radius;
            Name = name;
        }

        // Since only a list of actors, I linear search through either fauna or flora and get them all and return them as a list.
        public Organism GetOrganism(string name)
        {
            foreach (Organism o in Organisms) if (o.Name.Equals(name)) return o;
            return null;
        }
    }
}
