using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class Notification : BaseModel
    {
        [DataMember]
        public string PatronId { get; set; } // Notification for anyone conerned with this patron
        [DataMember]
        public string PersonId { get; set; }
        [DataMember]
        public string RouteId { get; set; } // Notification for anyone concerned with this route
        [DataMember]
        public string RouteRunId { get; set; } //Notification for anyone concerned with this routerun
        [DataMember]
        public string StoppageId { get; set; } // Notification for anyone concerned with this stoppage
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public bool IsActionRequired { get; set; }
        [DataMember]
        public string ActionItemId { get; set; }

        [DataMember]
        public NotificationCategory Category { get; set; }

        [DataMember]
        public ApplicationName ApplicationName { get; set; }


        [DataMember]
        public NotificationTo SentTo { get; set; }
        [DataMember]
        public string NotificationDate { get; set; }
        [DataMember]
        public string NotificationTime { get; set; }
        [DataMember]
        public int _ts { get; set; }

    }

    [DataContract]
    public class NotificationProcessorMessage
    {
        [DataMember]
        public BaseModel Data { get; set; }
        [DataMember]
        public NotificationCategory Category { get; set; }
    }

}
