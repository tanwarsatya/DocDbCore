using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartTrack
{
    public class TransportRouteMonitoring : BaseModel
    {       

        public string RouteNumber { get; set; }

        public string RegistrationNumber { get; set; }

        public string Lattitude { get; set; }

        public string Longitude { get; set; }
        public string MonitoringTime { get; set; }

        public string MonitoringDate { get; set; }
    }
}
