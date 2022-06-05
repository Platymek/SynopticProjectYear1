using System;
using System.Collections.Generic;
using System.Text;

namespace synopticProject.Source
{
    internal class Fauna : Organism
    {
        /// <summary>
        /// The constructer for animals/fauna
        /// </summary>
        /// <param name="name">Animal Name</param>
        /// <param name="description">Animal Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this animal is</param>
        /// <param name="danger">How dangerous this animal is</param>
        /// <param name="relationships">The relationships this animal has with others</param>
        public Fauna(
            string name, 
            string description, 
            SeverityType severity, 
            DangerType danger, 
            Relationship[] relationships) 
            : base(name, description, severity, danger, relationships)
        {}

        /// <summary>
        /// The constructer for animals/fauna for those who do not wish to write at all specific relationships
        /// </summary>
        /// <param name="name">Animal Name</param>
        /// <param name="description">Animal Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this animal is</param>
        /// <param name="danger">How dangerous this animal is</param>
        /// <param name="dependentOrganisms">The organisms this animal depends on</param>
        public Fauna(
            string name,
            string description,
            SeverityType severity,
            DangerType danger,
            Organism[] dependentOrganisms)
            : base(name, description, severity, danger, dependentOrganisms)
        {}

        public override string DangerDescriptionToString()
        {
            switch (Danger)
            {
                case DangerType.Low: 
                    return "The animal is completely harmless, it will not hurt.";
                case DangerType.Medium: 
                    return "The animal is only harmful if provoked, do not get too close or alarm in any way.";
                case DangerType.High: 
                    return "The animal is dangerous. It will attack on sight, steer very clear of these animals.";
                default: return null;
            }
        }
    }
}
