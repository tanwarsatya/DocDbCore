
using Newtonsoft.Json;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public class EventTracking : BaseModel
    {

        
        [JsonIgnore]
        public Authentication Authentication { get; set; }
        [DataMember]

        public string AuthenticationId { get; set; }
        [DataMember]

        public string PatronId { get; set; }
        [DataMember]

        public string PersonId { get; set; }
        [DataMember]

        public string TrackingDate { get; set; }
        [DataMember]

        public string TrackingTime { get; set; }
        [DataMember]

        [JsonIgnore]
        public Event Event { get; set; }
        [DataMember]

        public string EventId { get; set; }
    }

    
    

}
