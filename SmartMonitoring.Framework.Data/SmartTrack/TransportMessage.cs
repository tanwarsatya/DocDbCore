using System.Runtime.Serialization;
using System.Collections.Generic;

using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class TransportMessage :BaseModel
    {
        [DataMember]
        public string BroadcastTo { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string SenderId { get; set; }
        [DataMember]
        public string SenderName { get; set; }
        [DataMember]
        public string SenderImage { get; set; }
        [DataMember]
        public string SenderRole { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public List<string> PatronId { get; set; }
        [DataMember]
        public List<string> RouteId { get; set; }
        [DataMember]
        public List<string> StopId { get; set; }
        [DataMember]
        public List<string> PersonId { get; set; }
        [DataMember]
        public string MessageTime { get; set; }
        [DataMember]
        public string MessageDate { get; set; }
        [DataMember]
        public int _ts { get; set; }

    }
}
