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

        public static Location GetNearestLocation(Vector2 position)
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
            
            new Fauna("Wallabie",           "", 0, 0, new Organism[]{ }),
            new Fauna("Antilopine Wallaroo","", 0, 0, new Organism[]{ }),
            new Fauna("Spotted Cuscus",     "", 0, 0, new Organism[]{ }),
            new Fauna("Saltwater Crocodile","", 0, 1, new Organism[]{ }),
            new Fauna("Cane Toad",          "", 0, 1, new Organism[]{ }),
            new Fauna("Dingo",              "", 1, 1, new Organism[]{ }),
            new Fauna("Possum",             "", 0, 0, new Organism[]{ }),
            new Fauna("Feral Cattle",       "", 0, 0, new Organism[]{ }),
            new Fauna("Feral Horse",        "", 0, 0, new Organism[]{ }),
            new Fauna("Feral Pig",          "", 0, 2, new Organism[]{ }),
            new Fauna("Tree Kangaroos",     "", 0, 0, new Organism[]{ }),
            new Fauna("Tree Frog",          "", 1, 0, new Organism[]{ }),
            new Fauna("Sunbird",            "", 1, 0, new Organism[]{ }),
            new Fauna("Bush Turkey" ,       "", 0, 0, new Organism[]{ }),
            new Fauna("Amethystine Python", "", 0, 0, new Organism[]{ }),
            new Fauna("Imperial Pigeons",   "", 0, 0, new Organism[]{ }),
            new Fauna("Morepork",           "", 0, 0, new Organism[]{ }),
            new Fauna("Riflemen",           "", 0, 0, new Organism[]{ }),
            new Fauna("Bare-Rumped SheathTail Bat", "", 0, 0, new Organism[]{ }),
            new Fauna("Cassowary",          "", 1, 2, new Organism[]{ }),
            new Fauna("Electus Parrot",     "", 0, 0, new Organism[]{ }),
            new Fauna("Skink",              "", 0, 0, new Organism[]{ }),
            new Fauna("Buff Breasted Kingfisher","", 0, 0, new Organism[]{ }),
            
            new Flora("Ant Plant",          "", 1, 0, new Organism[]{ }),
            new Flora("Ancient Cycad",      "", 1, 2, new Organism[]{ }),
            new Flora("Ironbark Eucalyptus","", 1, 0, new Organism[]{ }),
            new Flora("Wild Cherry",        "", 0, 0, new Organism[]{ }),
            new Flora("Fan Palm",           "", 0, 0, new Organism[]{ }),
            new Flora("Stinging Tree",      "", 0, 0, new Organism[]{ }),
            new Flora("Melaleuca",          "", 0, 0, new Organism[]{ }),
            new Flora("Stringybark",        "", 0, 1, new Organism[]{ }),
            new Flora("Wattle",             "", 0, 0, new Organism[]{ }),
            new Flora("Termite Mounds",     "", 0, 0, new Organism[]{ }),
            new Flora("Ferns",              "", 0, 0, new Organism[]{ }),
            new Flora("orchid",             "", 0, 0, new Organism[]{ }),
        };

        public static Location[] Locations { get; private set; } = new Location[]
        {
            // TODO: Add all locations
        };
    }

}
