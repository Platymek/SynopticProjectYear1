using System;
using System.Collections.Generic;
using System.Text;

namespace synopticProject.Source
{
    public abstract class Organism
    {
        public enum SeverityType
        {
            LeastConcern,
            Vulnerable,
            Endangered
        }

        public enum DangerType
        {
            High,
            Medium,
            Low
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public Relationship[] Relationships { get; private set; }
        public Organism[] DependentOrganisms { get; private set; }
        public SeverityType Severity { get; private set; }
        public DangerType Danger { get; private set; }

        public string SeverityToString()
        {
            string message;
            message = "The " + Name + " is ";

            switch (Severity)
            {
                case SeverityType.LeastConcern: return message + "not concerning";
                case SeverityType.Vulnerable: return message + "vulnerable";
                case SeverityType.Endangered: return message + "endangered";
                default: return null;
            }
        }

        public string DangerToString()
        {
            string message;
            message = "The " + Name + " is ";

            switch (Severity)
            {
                case SeverityType.LeastConcern: return message + "not dangerous";
                case SeverityType.Vulnerable: return message + "somewhat dangerous";
                case SeverityType.Endangered: return message + "highly dangerous";
                default: return null;
            }
        }

        public abstract string DangerDescriptionToString();

        /// <summary>
        /// The Abstract class for fauna and flora
        /// </summary>
        /// <param name="name">Organism Name</param>
        /// <param name="description">Organism Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this organism is</param>
        /// <param name="danger">How dangerous this organism is</param>
        /// <param name="relationships">The relationships this organism has with others</param>
        public Organism(
            string name,
            string description,
            SeverityType severity,
            DangerType danger,
            Relationship[] relationships)
        {
            Name = name;
            Description = description;
            Severity = severity;
            Danger = danger;
            Relationships = relationships;
        }

        /// <summary>
        /// The Abstract class for fauna and flora for those who do not wish to write at all specific relationships
        /// </summary>
        /// <param name="name">Organism Name</param>
        /// <param name="description">Organism Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this organism is</param>
        /// <param name="danger">How dangerous this organism is</param>
        /// <param name="dependentOrganisms">The organisms this organism depends on</param>
        public Organism(
            string name,
            string description,
            SeverityType severity,
            DangerType danger,
            Organism[] dependentOrganisms)
        {
            Name = name;
            Description = description;
            Severity = severity;
            Danger = danger;
            DependentOrganisms = dependentOrganisms;
        }

        /// <summary>
        /// The Abstract class for fauna and flora for those who do not wish to write at all specific relationships and full enums
        /// </summary>
        /// <param name="name">Organism Name</param>
        /// <param name="description">Organism Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this organism is in integer form</param>
        /// <param name="danger">How dangerous this organism is in integer form</param>
        /// <param name="dependentOrganisms">The organisms this organism depends on</param>
        public Organism(
            string name,
            string description,
            int severity,
            int danger,
            Organism[] dependentOrganisms)
        {
            Name = name;
            Description = description;
            Severity = (SeverityType)severity;
            Danger = (DangerType)danger;
            DependentOrganisms = dependentOrganisms;
        }

        /// <summary>
        /// The Abstract class for fauna and flora for those who do not wish to write at all specific relationships and full enums
        /// </summary>
        /// <param name="name">Organism Name</param>
        /// <param name="description">Organism Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this organism is in integer form</param>
        /// <param name="danger">How dangerous this organism is in integer form</param>
        /// <param name="dependentOrganisms">The organisms this organism depends on</param>
        public Organism(
            string name,
            string description,
            int severity,
            int danger)
        {
            Name = name;
            Description = description;
            Severity = (SeverityType)severity;
            Danger = (DangerType)danger;
            DependentOrganisms = new Organism[] { };
        }
    }
}
