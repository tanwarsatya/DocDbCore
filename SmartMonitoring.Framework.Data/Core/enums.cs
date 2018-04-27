using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public enum AuthenticationMode
    {
        [EnumMember]
        Fingerscan = 1,
        [EnumMember]
        RFID = 2

    }


    [DataContract]
    public enum EstablishmentType
    {
        [EnumMember]
        School = 1,
        [EnumMember]
        Office = 2,
        [EnumMember]
        Shop = 3,
        [EnumMember]
        Hospital = 4,
        [EnumMember]
        FitnessCenter = 5
    }

    [DataContract]
    public enum Interval
    {
        [EnumMember]
        Adhoc = 0,
        [EnumMember]
        Daily = 1,
        [EnumMember]
        Weekly = 2,
        [EnumMember]
        Monthly = 3,
        [EnumMember]
        Yearly = 4  
    }


    [DataContract]
    public enum AttendanceType
    {
        [EnumMember]
        FullDay = 0,
        [EnumMember]
        FirstHalf = 1,
        [EnumMember]
        SecondHalf = 2,
        [EnumMember]
        Subject = 3
    }

    [DataContract]
    public enum NavigationKey
    {
        [EnumMember]
        patron = 1,
        [EnumMember]
        person = 2,
        [EnumMember]
        organization =3,
        [EnumMember]
        date =4,
        [EnumMember]
        patronClass =5,
        [EnumMember]
        section = 6,
        [EnumMember]
        attendanceType = 7,
        [EnumMember]
        persontracking =8,
        [EnumMember]
        transportroutetracking = 9,
        [EnumMember]
        deviceDetail =10,
        [EnumMember]
        removePatron = 11,
        [EnumMember]
        onLeavePatron =12,
        [EnumMember]
        allPresentPatron = 13,
        [EnumMember]
        walkerPatron =14,
        [EnumMember]
        inhouseMessageInfo = 15,
        [EnumMember]
        trackingMode = 16,
        [EnumMember]
        grades = 17
    }

    [DataContract]
    public enum NotificationCategory
    {
        
        // SmartTrack Category from 0 to 49
        [EnumMember]
        Walker = 0,
        [EnumMember]
        Route = 1,
        [EnumMember]
        Leave = 2,
        [EnumMember]
        Stoppage = 3,
        [EnumMember]
        PatronTracking = 4,
        [EnumMember]
        TransportMonitoring = 5,
        [EnumMember]
        Broadcast = 6, // Any message which is for everyone in the organization
        [EnumMember]
        SpeedViolationStart = 7, // Increased Speed Start
        [EnumMember]
        SpeedViolationEnd = 8, // Increased Speed End
        [EnumMember]
        GeoFenceViolationStart = 9, // GeoFence Start
        [EnumMember]
        GeoFenceViolationEnd = 10, // GeoFence End
        [EnumMember]
        HarshBreakApplied = 11, // Harsh Breaking Applied
        [EnumMember]
        TransportMessage = 12,  // Any Transport message 
        [EnumMember]
        TransportPanic = 13, // Transport Panic Button Pressed


        // SmartId Notifications 50 to 99

        [EnumMember]
        PatronIn = 50, // Patron Came In
        [EnumMember]
        PatronOut = 51, // Patron Went Out
        [EnumMember]
        PatronAbsent = 53,
        [EnumMember]
        PatronMissing = 54
    }

    

    [DataContract]
    public enum NotificationTo
    {
        [EnumMember]
        Parent = 0,
        [EnumMember]
        Admin = 1,
        [EnumMember]
        Teacher = 2,
        [EnumMember]
        ParentAdmin = 3,
        [EnumMember]
        Driver = 4
            
    }

    [DataContract]
    public enum ApplicationName
    {
        [EnumMember]
        SmartTrack = 1,
        [EnumMember]
        SmartID = 2,
        [EnumMember]
        SmartMonitoring = 3
            
    }
    [DataContract]
    public enum AttendanceMode
    {
        [EnumMember]
        Device = 0,
        [EnumMember]
        Manual = 1,


    }
    [DataContract]
    public enum AttendanceCaptureType
    {
        [EnumMember]
        In = 0,
        [EnumMember]
        Out = 1,

    }
    [DataContract]
    public enum LeaveType
    {
        [EnumMember]
        CL = 0,
        [EnumMember]
        PL = 1,
        [EnumMember]
        SL = 2,
        [EnumMember]
        RH = 3,

    }
    public enum LocationType
    {
        [EnumMember]
        Class = 0,
        [EnumMember]
        ScienceLab = 1,
        [EnumMember]
        Library = 2,
        [EnumMember]
        Corridor = 3,
        [EnumMember]
        ComputerLab = 4,
        [EnumMember]
        MusicLab = 5,
        [EnumMember]
        StaffRoom = 6,
        [EnumMember]
        BathRoom = 7,
        [EnumMember]
        AdminRoom = 8,
        [EnumMember]
        Reception = 9,

    }

}
