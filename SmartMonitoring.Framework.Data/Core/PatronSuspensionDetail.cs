using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class PatronSuspensionDetail : BaseModel
    {
        [DataMember]
        public string PatronId { get; set; }
        [DataMember]
        public string Class { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public string RollNumber { get; set; }
        [DataMember]
        public string StartDate { get; set; }
        [DataMember]
        public string EndDate { get; set; }
        [DataMember]
        public string Remark { get; set; }
    }
}
