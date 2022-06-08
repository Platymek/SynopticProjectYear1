﻿using System;
using System.Collections.Generic;
using System.Text;

namespace synopticProject.Source
{
    internal class Flora : Organism
    {
        /// <summary>
        /// The constructer for plants/flora
        /// </summary>
        /// <param name="name">Plant Name</param>
        /// <param name="description">Plant Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this plant is</param>
        /// <param name="danger">How dangerous this plant is</param>
        /// <param name="relationships">The relationships this plant has with others</param>
        public Flora(
            string name,
            string description,
            SeverityType severity,
            DangerType danger,
            Relationship[] relationships)
            : base(name, description, severity, danger, relationships)
        { }

        /// <summary>
        /// The Abstract class for fauna and flora for those who do not wish to write at all specific relationships
        /// </summary>
        /// <param name="name">Plant Name</param>
        /// <param name="description">Plant Description e.g. describing what it looks like</param>
        /// <param name="severity">How severely endangered this plant is</param>
        /// <param name="danger">How dangerous this plant is</param>
        /// <param name="dependentOrganisms">The organisms this plant depends on</param>
        public Flora(
            string name,
            string description,
            int severity,
            int danger,
            Organism[] dependentOrganisms)
            : base(name, description, severity, danger, dependentOrganisms)
        { }

        public override string DangerDescriptionToString()
        {
            switch (Danger)
            {
                case DangerType.Low: 
                    return "The plant will not harm you in any way, is edible and not bad to touch.";
                case DangerType.Medium:
                    return "The plant will likely cause harm to touch or consumption but will not kill";
                case DangerType.High:
                    return "The plant is dangerous. Do not touch, let alone eat";
                default:
                    return null;
            }
        }
    }
}
