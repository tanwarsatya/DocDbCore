
using Newtonsoft.Json;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{



    public class PatronTracking_Old : BaseModel
    {


        [JsonIgnore]
        public Patron Patron { get; set; }

        public string PatronId { get; set; }

        public string TrackingDate { get; set; }

        public string TrackingTime { get; set; }
        [JsonIgnore]
        public Authentication Authentication { get; set; }

        public string AuthenticationId { get; set; }

        public string Class { get; set; }

        public bool IsMarkedAbsent { get; set; }

        public bool IsAbsconed { get; set; }

        public string Section { get; set; }

        public int RollNumber { get; set; }

        public AttendanceType AttendanceType { get; set; }

        public string Subject { get; set; }
    }

    public class PatronAttendanceSummary_Old : BaseModel
    {

        public int TotalPatrons { get; set; }
        public int PresentPatrons { get; set; }

        public int AbsentPatrons { get; set; }

        public int PatronsOnLeave { get; set; }

        public string TrackingDate { get; set; }

    }





}
