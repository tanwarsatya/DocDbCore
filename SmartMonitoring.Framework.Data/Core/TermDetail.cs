using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class TermDetail : BaseModel
    {
        [DataMember]
        public string TermName { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public string Tag { get; set; }
    }
}
