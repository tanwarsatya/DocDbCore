
using SmartMonitoring.Framework.Models.Core;
using SmartMonitoring.Framework.Models.SmartId;
using SmartMonitoring.Framework.Models.SmartTrack;
namespace SmartMonitoring.Framework.Models.Device
{
    public class SetupDevice : BaseModel
    {
        public string Name { get; set; }

        public string Class { get; set; }

        public string Section { get; set; }

        public EstablishmentType EstablishmentType { get; set; }

        public Event Event { get; set; }
        public string EventId { get; set; }

        public string InstalledAt { get; set; }

        public bool Status { get; set; }

        public string UpdatedBy { get; set; }
        

        public TransportRoute TransportRoute { get; set; }

        public string TransportRouteId { get; set; }
    }
}
