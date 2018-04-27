using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using SmartMonitoring.Framework.Models.Core;

namespace SmartMonitoring.Framework.Models.Device
{

 
    [DataContract]
    public class DeviceMessage : BaseModel
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string deviceid { get; set; }
        [DataMember]
        public string routeid { get; set; }
        [DataMember]
        public string hardwareid { get; set; }
        [DataMember]
        public string hardwaretype { get; set; }
        [DataMember]
        public string datestamp { get; set; }
        [DataMember]
        public string timestamp { get; set; }
        [DataMember]
        public string payload { get; set; }
        [DataMember]
        public string synced { get; set; }
        [DataMember]
        public string messagetype { get; set; }
        [DataMember]
        public string applicationname { get; set; }
        //public ApplicationName applicationname { get; set; }

    }

}
