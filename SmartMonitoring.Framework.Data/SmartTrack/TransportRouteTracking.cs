using SmartMonitoring.Framework.Models.Core;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class TransportRouteTracking : BaseModel
    {
        [DataMember]
        public string RouteNumber { get; set; }
        [DataMember]

        public string RouteId { get; set; }
        [DataMember]

        public string RouteStaffId { get; set; }
        [DataMember]
        public string DriverId { get; set; }
        [DataMember]

        public string CoordinatorId { get; set; }
        [DataMember]

        public string PatronId { get; set; }
        [DataMember]
        public string EmployeeId { get; set; }
        [DataMember]

        public string StoppageId { get; set; }
        [DataMember]

        public string TrackingDate { get; set; }
        [DataMember]

        public string TrackingTime { get; set; }
        [DataMember]

        public string Lattitude { get; set; }
        [DataMember]

        public string Longitude { get; set; }


    }
}