using Newtonsoft.Json;

using System.Collections.Generic;

using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class TransportRoute : BaseModel
    {
        [DataMember]
        public string RouteNumber { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [JsonIgnore,DataMember]
        public Person Driver { get; set; }
        [DataMember]
        public string DriverId { get; set; }

        [JsonIgnore]
        [DataMember]
        public Person Coordinator { get; set; }

        [DataMember]
        public string CoordinatorId { get; set; }
        [JsonIgnore]
        [DataMember]
        public Person RouteStaff { get; set; }
        [DataMember]
        public string RouteStaffId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<TransportStoppage> TransportStoppages { get; set; }
        [DataMember]
        public string Remarks { get; set; }

        // To be used for RouteRun Generation
        // Populated automatically from Organization Start/End Time or can be specified different
        // This is to handle case where some routes have different timings
        [DataMember]
        public string OrganizationStartTime { get; set; }
        [DataMember]
        public string OrganizationEndTime { get; set; }

        // Will be used for speed warning/alerts default will be populated from organization
        [DataMember]
        public int AllowedSpeed { get; set; }
        [DataMember]
        public bool TrackGeoFence { get; set; }
        [DataMember]
        public bool TrackSpeedViolation { get; set; }
        [DataMember]
        public bool TrackHarshBreaking { get; set; }
        [DataMember]
        public List<GeoCoordinate> GeoFence { get; set; }
        [DataMember]
        public int _ts { get; set; }
    }
}
