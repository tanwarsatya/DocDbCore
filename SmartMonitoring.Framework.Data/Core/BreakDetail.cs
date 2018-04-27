using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class BreakDetail : BaseModel
    {

        [DataMember]
        public string BreakName { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public string Tag { get; set; }
    }
}
