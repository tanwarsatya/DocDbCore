using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public  class WeekDetail:BaseModel
    {
        [DataMember]
        public string dayofweek { get; set; }
    }
}
