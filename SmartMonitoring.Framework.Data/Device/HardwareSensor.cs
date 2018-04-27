using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMonitoring.Framework.Models;
using SmartMonitoring.Framework.Models.Core;

namespace SmartMonitoring.Framework.Models.Device
{
    public class HardwareSensor : BaseModel
    {
        public string HardwareID { get; set; }

        public string HardwareType { get; set; }

        public bool Enabled { get; set; }

    }
}
