using System;
using System.Collections.Generic;
using System.Text;
using SmartMonitoring.Framework.Models.Device;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.SmartTrack;
namespace SmartMonitoring.Framework.Models.Device
{
    [DataContract]
    public class SmartIdDevice : BaseDevice
    {

        [DataMember]
        public string LocationId { get; set; } // Use to store where the device is installed // based on location object stored for a device


    }


}
