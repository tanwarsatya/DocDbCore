using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public class GradeDetail : BaseModel
    {
        [DataMember]
        public string Grade  { get; set; }
        [DataMember]
        public string Section { get;set;  }
        [DataMember]
        public AttendanceType AttendanceType { get; set; }
        [DataMember]
        public string PersonId { get; set; }
        [DataMember]
        public string StartTime { get; set; }
        [DataMember]
        public string EndTime { get; set; }
    }
}
