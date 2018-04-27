using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SmartMonitoring.Framework.DocumentDB.Models
{
    public class SPCountResponse : Microsoft.Azure.Documents.Resource
    {
        [JsonProperty("count")]
        public int count { get; set; }

        [JsonProperty("continuationToken")]
        public string continuationToken { get; set; }
    }
}
