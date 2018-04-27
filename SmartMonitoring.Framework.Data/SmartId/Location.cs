
using Newtonsoft.Json;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public class Location : BaseModel
    {      
        [DataMember]
        public LocationType LocationType { get; set; }
        [DataMember]
        public string Remark { get; set; }
        
    }

    
    

}
