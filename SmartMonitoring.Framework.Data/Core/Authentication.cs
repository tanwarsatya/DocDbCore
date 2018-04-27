using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class Authentication : BaseModel
    {

        [DataMember]
        public AuthenticationMode Mode { get; set; }

        [DataMember]
        public string HashValue { get; set; }

        [DataMember]
        public string ModeType { get; set; }

        [JsonIgnore]
        public Patron Patron { get; set; }

        [DataMember]
        public string PatronId { get; set; }

        [DataMember]
        public string Remark { get; set; }
    }
}
