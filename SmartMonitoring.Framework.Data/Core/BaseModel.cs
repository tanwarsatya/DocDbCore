using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Runtime.Serialization;

using SmartMonitoring.Framework.Models.Device;
using System.Reflection;
using System.Linq;
using SmartMonitoring.Framework.Models.Interfaces;
namespace SmartMonitoring.Framework.Models.Core
{
   
    [DataContract]
    [KnownType("DerivedTypes")]
    public abstract class BaseModel 
    {
        private static Type[] DerivedTypes()
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(_ => _.IsSubclassOf(typeof(BaseModel))).ToArray();
        }

        public BaseModel()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [DataMember]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [DataMember]
        public string organizationid { get; set; }

        
        [JsonProperty(PropertyName = "type")]
        public string type
        {
            get { return this.GetType().Name; }
           
        }


        [DataMember]
        public DateTime createdate { get; set; }
        [DataMember]
        public DateTime lastupdated { get; set; }
        [DataMember]
        public string lastupdatedby { get; set; }
       
        
    }
}