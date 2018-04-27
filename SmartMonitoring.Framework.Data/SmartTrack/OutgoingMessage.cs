using System.Collections.Generic;
using SmartMonitoring.Framework.Models.Core;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class OutgoingMessage :BaseModel
    {
        [DataMember]
        public string BroadcastTo {get;set; }
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
        public  string Message { get; set; }
        [DataMember]
        public bool IsResponseNeed { get;set; }
        [DataMember]
        public List<string> PatronId { get; set; }
        [DataMember]

        public List<string> PersonId { get; set; }
        [DataMember]
        public string MessageTime { get; set; }
        [DataMember]
        public string MessageDate {get;set; }
        [DataMember]
        public bool IsSent {get;set;}
    }
}
