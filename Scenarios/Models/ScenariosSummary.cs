using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Scenarios.Models
{
    public class ScenarioSummary
    {
        ///<summary>
        /// Gets or sets Scenarios.
        ///</summary>
        public List<Scenario> ScenarioDetails { get; set; }

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }
    }
}