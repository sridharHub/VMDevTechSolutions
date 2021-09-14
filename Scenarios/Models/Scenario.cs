using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scenarios.Models
{
    [Serializable]
    public class Scenario
    {
        /// <summary>
        /// Gets or Sets ScenarioID
        /// </summary>
        public int ScenarioID { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Forename
        /// </summary>
        public string Forename { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// Gets or Sets SampleDate
        /// </summary>
        public DateTime? SampleDate { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets NumMonths
        /// </summary>
        public int? NumMonths { get; set; }

        /// <summary>
        /// Gets or Sets MarketID
        /// </summary>
        public int? MarketID { get; set; }

        /// <summary>
        /// Gets or Sets NetworkLayerID
        /// </summary>
        public int? NetworkLayerID { get; set; }

    }
}