using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class PersonLeaveDetail : BaseModel
    {
        [JsonIgnore]
        public Person Person { get; set; }
        [DataMember]
        public string PersonId { get; set; }
        [DataMember]
        public bool FirstHalf { get; set; }

        [DataMember]
        public bool SecondHalf { get; set; }
        [DataMember]
        public string RoleId { get; set; }
        [DataMember]
        public string RoleName { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public LeaveType NatureOfLeave { get; set; }
        [DataMember]
        public bool Approved { get; set; }
        [DataMember]

        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public int NumberOfDays { get; set; }
        [DataMember]
        public bool Status { get; set; }
        [DataMember]
        public string Remark { get; set; }
        
    }
}
