using System.Runtime.Serialization;
using System.Collections.Generic;

using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartConnect
{
    [DataContract]
    public class InhouseMessage : BaseModel
    {
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public List<DeviceDetail> DeviceDetail { get; set; }
        [DataMember]
        public string MessageCategory { get; set; }
        [DataMember]
        public string MessageTime { get; set; }
        [DataMember]
        public string MessageDate { get; set; }
        [DataMember]
        public string ExpiryDate { get; set; }
    }

}
public class DeviceDetail 
{
    public string deviceId { get; set; }
    public bool IsSent { get; set; }
    public bool IsRecieved { get; set; }
    public bool IsAcknowledge { get; set; }
    public string ReceivedBy { get; set; }

    public string ReceivedDate { get; set; }

    public string ReceivedTime { get; set; }
    public string AcknowledgeDate { get; set; }

    public string AcknowledgeTime { get; set; }

    public string SentDate { get; set; }

    public string SentTime { get; set; }

}
