using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.SmartId
{
    [DataContract]
    public enum SmartIdSMSTemplate
    {
        [EnumMember]
        SCHOOL_IN = 0,
        [EnumMember]
        SCHOOL_OUT = 1,
        [EnumMember]
        SCHOOL_ABSENT_SUMMARY = 2
            
    }   

}
