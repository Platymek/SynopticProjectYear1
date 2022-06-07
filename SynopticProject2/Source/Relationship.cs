using System;
using System.Collections.Generic;
using System.Text;

namespace synopticProject.Source
{
    public class Relationship
    {
        public enum RelationshipType
        {
            PreyOf,
            Mutualistic,
            Commensalistic,
            Predatory,
            Parasitic,
            Competitive
        }

        public Organism Organism { get; private set; }
        public bool Positive { get; private set; }
        public RelationshipType Type { get; set; }

        public override string ToString()
        {
            string message;
            message = "This organism ";

            switch (Type)
            {
                case RelationshipType.PreyOf:
                    return message += "is the prey of the " + Organism.Name;
                case RelationshipType.Mutualistic:
                    return message += "benefits and gains benefit from the " + Organism.Name;
                case RelationshipType.Commensalistic:
                    return message += "benefits from but does not harm the " + Organism.Name;
                case RelationshipType.Predatory:
                    return message += "is the predator of the " + Organism.Name;
                case RelationshipType.Parasitic:
                    return message += "is a parasite of " + Organism.Name;
                case RelationshipType.Competitive:
                    return message += "is competitive with " + Organism.Name;
                default: return null;
            }
        }

        /// <summary>
        /// The relationship between two organisms, the organism that owns this, the parent, and the organism specified
        /// as a parameter
        /// </summary>
        /// <param name="organism">The organism the parent has a relationship with</param>
        /// <param name="relationshipType">The type of relationship</param>
        /// <param name="positive">Wether or not the relationship is positively impacting the parent</param>
        public Relationship(Organism organism, RelationshipType relationshipType, bool positive = true)
        {
            Organism = organism;
            Positive = positive;
            Type = relationshipType;
        }
    }
}
