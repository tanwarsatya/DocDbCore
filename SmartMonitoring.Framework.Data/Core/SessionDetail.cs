using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class SessionDetail : BaseModel
    {
        [DataMember]
        public string SessionName { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public List<BreakDetail> SessionBreak { get; set; }
        [DataMember]
        public List<TermDetail> SessionTerm { get; set; }
        [DataMember]
        public WeekDetail WeekDays { get; set; }
        [DataMember]
        public string Status { get; set; }

    }
}

