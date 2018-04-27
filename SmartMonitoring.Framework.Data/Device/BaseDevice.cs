using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMonitoring.Framework.Models.Core;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Device
{
    [DataContract]
    // Base Device Classs all other device class will inherit from this
    public class BaseDevice : BaseModel
    {
        [DataMember]
        public string DeviceID { get; set; }

        [DataMember]
        public bool Enabled { get; set; }

        [DataMember]
        public List<HardwareSensor> HardwareSensors { get; set; }

       
    }
    
}
