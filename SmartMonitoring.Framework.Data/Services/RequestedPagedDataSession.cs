using System;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Services
{
    [DataContract]
    public class RequestedPagedDataSession
    {
        [DataMember]
        public PagingId SessionId { get; set; }
        [DataMember]
        public int OriginDataSize { get; set; }
        [DataMember]
        public Uri OriginUri { get; set; }
    }
}