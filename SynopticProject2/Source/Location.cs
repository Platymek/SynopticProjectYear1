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
        public LocationIndex LocationType { get; private set; }

        public enum LocationIndex
        {
            NATIONAL_PARK,
            UNKNOWN
        }

        public Location(Organism[] organisms, Vector2 position, int radius, string name, LocationIndex locationType = LocationIndex.UNKNOWN)
        {
            Organisms = organisms;
            Position = position;
            Radius = radius;
            Name = name;
            LocationType = locationType;
        }

        // Since only a list of actors, I linear search through either fauna or flora and get them all and return them as a list.
        public Organism GetOrganism(string name)
        {
            foreach (Organism o in Organisms) if (o.Name.Equals(name)) return o;
            return null;
        }
    }
}
