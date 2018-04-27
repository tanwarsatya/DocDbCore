using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartMonitoring.Framework.Models.Core;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public class Event : BaseModel
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Remarks { get; set; }
        [DataMember]

        public List<string> PatronId { get; set; }
        [DataMember]
        public List<string> PersonId { get; set; }
        [DataMember]
        public List<DeclineRequest> DeclineRequest { get; set; }

        [DataMember]
        public Interval Occurence { get; set; }
        [DataMember]
        public string OccurenceType { get; set; }
        [DataMember]

        public string DayOfWeek { get; set; }
        [DataMember]

        public string DayOfMonth { get; set; }

        [DataMember]
        public string StartTime { get; set; }
        [DataMember]

        public string EndTime { get; set; }
        [DataMember]

        public string StartDate { get; set; }
        [DataMember]

        public string EndDate { get; set; }
       

    }
    [DataContract]
    public class DeclineRequest 
    {
        [DataMember]
        public string DeclinedPatron { get; set; }
        [DataMember]

        public string DeclinedPerson { get; set; }
        [DataMember]
        public string DeclineMode { get; set; }
        [DataMember]
        public string DeclineReason { get; set; }
       
    }
}
