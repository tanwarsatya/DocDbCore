using System;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class LoginDetail : BaseModel
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string IpAddress { get; set; }
        [DataMember]
        public DateTime LastLogin { get; set; }

    }
}
