using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFLTest.Models
{
    public partial class RoadCorridor
    {
        /// <summary>
        /// The Id of the Corridor e.g. "A406"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The display name of the Corridor e.g. "North Circular (A406)". This
        /// <br/>            may be identical to the Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The group name of the Corridor e.g. "Central London". Most corridors are not grouped, in which case this field can be null.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Group { get; set; }

        /// <summary>
        /// Standard multi-mode status severity code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusSeverity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusSeverity { get; set; }

        /// <summary>
        /// Description of the status severity as applied to RoadCorridors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusSeverityDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusSeverityDescription { get; set; }

        /// <summary>
        /// The Bounds of the Corridor, given by the south-east followed by the north-west co-ordinate
        /// <br/>            pair in geoJSON format e.g. "[[-1.241531,51.242151],[1.641223,53.765721]]"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bounds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bounds { get; set; }

        /// <summary>
        /// The Envelope of the Corridor, given by the corner co-ordinates of a rectangular (four-point) polygon
        /// <br/>            in geoJSON format e.g. "[[-1.241531,51.242151],[-1.241531,53.765721],[1.641223,53.765721],[1.641223,51.242151]]"
        /// </summary>
        [Newtonsoft.Json.JsonProperty("envelope", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Envelope { get; set; }

        /// <summary>
        /// The start of the period over which status has been aggregated, or null if this is the current corridor status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusAggregationStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatusAggregationStartDate { get; set; }

        /// <summary>
        /// The end of the period over which status has been aggregated, or null if this is the current corridor status.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statusAggregationEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StatusAggregationEndDate { get; set; }

        /// <summary>
        /// URL to retrieve this Corridor.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

    }
}
