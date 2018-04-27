using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.SmartTrack
{
    [DataContract]
    public enum SmartTrackSMSTemplate
    {
        [EnumMember]
        TRANSPORT_TO_REACHING_STOP = 0,
        [EnumMember]
        TRANSPORT_TO_PICKED = 1,
        [EnumMember]
        TRANSPORT_TO_MISSED = 2,
        [EnumMember]
        TRANSPORT_TO_REACHED_SCHOOL = 3,
        [EnumMember]
        TRANSPORT_FROM_BOARDED = 4,
        [EnumMember]
        TRANSPORT_FROM_MISSED = 5,
        [EnumMember]
        TRANSPORT_FROM_REACHING_STOP = 6,
        [EnumMember]
        TRANSPORT_FROM_DROPPED = 7


    }

    [DataContract]
    public enum ViolationCategory
    {
        [EnumMember]
        Speeding = 1,
        [EnumMember]
        Breaking = 2,
        [EnumMember]
        GeoFence = 3,
        [EnumMember]
        TransportPanicButton = 4


    }
    [DataContract]
    public enum SmartTrackPlan
    {
        [EnumMember]
        Bronze = 0, // Minimum with only GPS and CCTV
        [EnumMember]
        Silver = 1, // Include student tracking for transport in addition to bronze
        [EnumMember]
        Gold = 2, // Include attendance tracking with limited machines in addition to Silver
        [EnumMember]
        Custom = 3
    }

    [DataContract]
    public enum TransportRouteRunDirection
    {
        [EnumMember]
        ToSchool = 1,
        [EnumMember]
        FromSchool = 2
    }
}
