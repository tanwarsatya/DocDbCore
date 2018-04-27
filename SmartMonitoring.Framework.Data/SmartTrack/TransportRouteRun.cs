using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    // This stores data for the Route Run for a specific date
    public class TransportRouteRun : BaseModel
    {
        [DataMember]
        public string TransportRouteId { get; set; }

        [DataMember]
        public string RouteNumber { get; set; }

        [DataMember]
        public string RegistrationNumber { get; set; }

        [DataMember]
        public string RouteStaffId { get; set; }

        [DataMember]
        public string DriverId { get; set; }

        [DataMember]
        public string CoordinatorId { get; set; }

        [DataMember]
        public string RunDate { get; set; }
        [DataMember]
        public string RunStartTime { get; set; }
        [DataMember]
        public string RunEndTime { get; set; }
        [DataMember]
        public TransportRouteRunDirection RunDirection { get; set; }
        [DataMember]
        public bool IsLeft { get; set; }

        // This will be used to show status if the bus is currently out of fence boundry
        [DataMember]
        public bool IsOutOfGeoFence { get; set; } = false;

        [DataMember]
        public bool IsOverSpeed { get; set; } = false;

        [DataMember]
        public List<string> PatronWalkers { get; set; }

        [DataMember]
        public List<string> EmployeeWalkers { get; set; }

        [DataMember]
        public List<string> PatronOnLeave { get; set; }

        [DataMember]
        public List<string> EmployeeOnLeave { get; set; }

        [DataMember]
        public List<string> Patrons { get; set; }

        [DataMember]
        public List<string> Employees { get; set; }

        // For now keeps the monitoring data seprate 
        //public List<TransportRouteMonitoring> Monitoring { get; set; }
        [DataMember]
        public List<TransportRouteRunStoppage> Stoppages { get; set; }

        [DataMember]
        public List<TransportRouteRunViolation> Violations { get; set; }

        [DataMember]
        public List<TransportRouteRunVideoRecording> Videos { get; set; }
    }

    [DataContract]
    public class TransportRouteRunStoppage : BaseModel
    {
        [DataMember]
        public string TransportRouteRunID { get; set; }
        [DataMember]
        public string TransportStoppageID { get; set; }
        [DataMember]
        public string ReachedTime { get; set; }
        [DataMember]
        public string TrackingDate { get; set; }
        [DataMember]
        public List<string> Patrons { get; set; }
        [DataMember]
        public List<string> Employees { get; set; }


    }


   

    [DataContract]
    public class TransportRouteRunViolation : BaseModel
    {
        [DataMember]
        public string TransportRouteRunID { get; set; }
        [DataMember]
        public string TransportRouteID { get; set; }
        [DataMember]
        public ViolationCategory ViolationCategory { get; set; }
        [DataMember]
        public GeoCoordinate Location { get; set; }
        [DataMember]
        public string ViolationStartTime { get; set; }
        [DataMember]
        public string ViolationEndTime { get; set; }

        // To Be Used for any special data to be stored
        [DataMember]
        public string ExtraData { get; set; }
    }

    [DataContract]
    public class TransportRouteRunMonitoring : BaseModel
    {
        [DataMember]
        public string TransportRouteRunID { get; set; }
        [DataMember]
        public string TransportRouteID { get; set; }
        [DataMember]
        public GeoCoordinate Location { get; set; }
        [DataMember]
        public string MonitoringDate { get; set; }
        [DataMember]
        public string MonitoringTime { get; set; }


    }
    [DataContract]
    public class TransportRouteRunVideoRecording : BaseModel
    {
        [DataMember]
        public string TransportRouteRunID { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string StartTime { get; set; }
        [DataMember]
        public string EndTime { get; set; }
        [DataMember]
        public string RecordingSize { get; set; }
        [DataMember]
        public string RecordingDuration { get; set; }
    }



   

  
}