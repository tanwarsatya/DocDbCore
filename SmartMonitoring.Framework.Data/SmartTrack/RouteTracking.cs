using SmartMonitoring.Framework.Models.Core;

namespace SmartMonitoring.Framework.Models.SmartTrack
{
    public class RouteTracking : BaseModel
    {
        public string RouteNumber { get; set; }

        public string RouteStaffId { get; set; }
        public string DriverId { get; set; }

        public string CoordinatorId { get; set; }

        public string PatronId { get; set; }
        public string EmployeeId { get; set; }

        public string StoppageId { get; set; }
        
        public string TrackingDate { get; set; }

        public string TrackingTime { get; set; }

        public string Lattitude { get; set; }

        public string Longitude { get; set; }
    }
}
