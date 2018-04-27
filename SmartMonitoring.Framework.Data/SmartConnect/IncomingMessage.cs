using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartConnect
{
    [DataContract]
    public class IncomingMessage : BaseModel
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string MessageId { get; set; }
        [DataMember]
        public string PatronId { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string MessageTime { get; set; }
        [DataMember]
        public string MessageDate { get; set; }
    }
}
