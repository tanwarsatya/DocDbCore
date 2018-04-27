
using Newtonsoft.Json;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{



    public class PersonTracking : BaseModel
    {
        [JsonIgnore]
        public Person Person { get; set; }

        public string PersonId { get; set; }

        public string TrackingDate { get; set; }
        public string EmailId { get; set; }
        public string PrimaryMobile { get; set; }
        public string Role { get; set; }
        public string TrackingTime { get; set; }
        [JsonIgnore]
        public Authentication Authentication { get; set; }

        public string AuthenticationId { get; set; }

        public AttendanceType AttendanceType { get; set; }

        public string Subject { get; set; }
    }

    public class PersonAttendanceSummary : BaseModel
    {

        public int TotalPersons { get; set; }
        public int PresentPersons { get; set; }

        public int AbsentPersons { get; set; }

        public int PersonsOnLeave { get; set; }

        public string TrackingDate { get; set; }

    }
}
