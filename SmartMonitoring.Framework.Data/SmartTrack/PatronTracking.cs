
using Newtonsoft.Json;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{



    public class PatronTracking : BaseModel
    {


        [JsonIgnore]
        public Patron Patron { get; set; }

        public string PatronId { get; set; }

        public string TrackingDate { get; set; }

        public string FirstHalfTrackingTime { get; set; }

        public string SecondHalfTrackingTime { get; set; }
        [JsonIgnore]
        public Authentication Authentication { get; set; }

        public string FirstHalfAuthenticationId { get; set; }

        public string SecondHalfAuthenticationId { get; set; }

        public string Class { get; set; }

        public bool IsAbscond { get; set; }

        public string Section { get; set; }

        public int RollNumber { get; set; }

        public string OutTime { get; set; }
    }

    public class PeriodDetail : BaseModel //check
    {
        public string PeriodName { get; set; }
        public string PeriodNumber { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

    }
    public class PeriodTracking : BaseModel
    {
        public string PatronId { get; set; }
        public string PeriodId { get; set; }
        public string PeriodNumber { get; set; }
        public string AuthenticationId { get; set; }
        public string TrackingTime { get; set; }
        public string TrackingDate { get; set; }
        public string Class { get; set; }
        //public bool IsMarkedAbsent { get; set; }        
        public bool IsAbscond { get; set; }
        public string Section { get; set; }
        public int RollNumber { get; set; }

    }

    public class PatronTrackingSummary : BaseModel
    {

        public int TotalPatrons { get; set; }
        public int PresentPatrons { get; set; }

        public int AbsentPatrons { get; set; }

        public int AbscondedPatrons { get; set; }

        public int PatronsOnLeave { get; set; }

        public string TrackingDate { get; set; }

    }

}


