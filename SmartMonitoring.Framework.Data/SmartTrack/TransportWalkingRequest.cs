using SmartMonitoring.Framework.Models.Core;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class TransportWalkingRequest: BaseModel
    {
        [DataMember]
        public string PatronId { get; set; }

        [DataMember]
        public string RequestBy { get; set; }

        [DataMember]
        public string RequestMode { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string RequestDate { get; set; }

        [DataMember]
        public bool Pick { get; set; }

        [DataMember]

      
        public bool Drop { get; set; }

        [DataMember]
        public string RequestTime { get; set; }

        [DataMember]
        public bool IsAcknowledged { get; set;}

        [DataMember]
        public string TranspportRouteId { get; set;}

        [DataMember]
        public string StoppageId { get; set;}
    }
}
