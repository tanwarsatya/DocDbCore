
using Newtonsoft.Json;
using System.Runtime.Serialization;
using SmartMonitoring.Framework.Models.Core;
using System.Collections.Generic;

namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public class Tracking : BaseModel
    {      
        [DataMember]
        public string PatronId { get; set; }
        [DataMember]
        public string PersonId { get; set; }
        [DataMember]
        public List<TrackedItem> TrackedItems { get; set; }

        [DataMember]
        public int RollNo { get; set; }

        [DataMember]
        public int Class { get; set; }

        [DataMember]
        public string Section { get; set; }
                 
        [DataMember]
        public string Date { get; set; }       
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        // If Sms is sent and notification generated for School In
        public bool InNotificationGenerated { get; set; }

        [DataMember]
        // If Sms is sent and notification generated for School Out
        public bool OutNotificationGenerated { get; set; }

    }
    public class TrackedItem 
    {
        [DataMember]
        public string LocationId { get; set; }
        [DataMember]
        public string Time { get; set; }
        [DataMember]
        public string SmartId { get; set; }

    }



    }
