using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;

namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public class TransportStoppage : BaseModel
    {
        [DataMember]
        public int Sequence { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<string> PatronId { get; set; }

        [DataMember]
        public string Lattitude { get; set; }

        [DataMember]
        public string Longitude { get; set; }

        [DataMember]
        public string PickupTime { get; set; }
        [DataMember]
        public string DropTime { get; set; }
        [DataMember]
        public string Description { get; set; }

        [JsonIgnore]
        
        public GeoCoordinate Location {
            get {
                return (new GeoCoordinate( double.Parse(Lattitude) , double.Parse(Longitude) ));
                }
           }


    }
}
