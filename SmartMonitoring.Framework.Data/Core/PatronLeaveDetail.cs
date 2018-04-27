using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class PatronLeaveDetail : BaseModel
    {
        
        [JsonIgnore]
        public Patron Patron { get; set; }

        [DataMember]
        public string PatronId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string NatureOfLeave { get; set; }

        [DataMember]
        public bool Approved { get; set; }

        [DataMember]
        public bool FirstHalf { get; set; }

        [DataMember]
        public bool SecondHalf { get; set; }

        [DataMember]
        public string StartDate { get; set; }

        [DataMember]
        public string EndDate { get; set; }

        [DataMember]
        public int NumberOfDays { get; set; }

        [DataMember]
        public string Class { get; set; }

        [DataMember]
        public string Section { get; set; }

        [DataMember]
        public string RollNumber { get; set; }

        [DataMember]
        public string Remark { get; set; }
    }
}
