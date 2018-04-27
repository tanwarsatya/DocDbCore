using System;
using System.Collections.Generic;
using System.Text;
using SmartMonitoring.Framework.Models.Device;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.SmartTrack;
namespace SmartMonitoring.Framework.Models.Device
{
    [DataContract]
    public class SmartTrackDevice : BaseDevice
    {

        [DataMember]
        public string TransportRouteId { get; set; }

        [DataMember]
        public GeoCoordinate LastKnownLocation { get; set; }
    }
}
