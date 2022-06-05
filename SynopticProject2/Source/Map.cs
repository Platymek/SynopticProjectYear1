using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace synopticProject.Source
{
    internal class Map
    {
        public Vector2 Position { get; private set; }

        public Organism GetOrganism(string name)
        {
            foreach (Organism o in Organisms) if (o.Name.Equals(name)) return o;
            throw new OrganismNotFoundException(name);
        }

        public Location GetNearestLocation(Vector2 position)
        {
            Location nearestLocation = Locations[0];

            foreach (Location currentLocation in Locations)
            {
                float d1 = Vector2.DistanceSquared(position, nearestLocation.Position) - nearestLocation.Radius;
                float d2 = Vector2.DistanceSquared(position, currentLocation.Position) - currentLocation.Radius;

                if (d1 < d2) nearestLocation = currentLocation;
            }

            return nearestLocation;
        }

        public static Organism[] Organisms { get; private set; } = new Organism[]
        {
            // TODO: Add all organisms
        };

        public static Location[] Locations { get; private set; } = new Location[]
        {
            // TODO: Add all locations
        };
    }

}
