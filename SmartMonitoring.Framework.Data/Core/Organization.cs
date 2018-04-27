using SmartMonitoring.Framework.Models.SmartTrack;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class Organization : BaseModel
    {    
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string ZipCode { get; set; }

        [DataMember]
        public string LogoURL { get; set; }

        [DataMember]
        public EstablishmentType EstablishmentType { get; set; }
        [DataMember]
        public SmartTrackPlan Plan { get; set; }

        [DataMember]
        public List<Patron> Patrons { get; set; }

        [DataMember]
        public SmartTrackSettings SmartTrackSettings { get; set; }

        [DataMember]
        public SmartIdSettings SmartIdSettings { get; set; }

        [DataMember]
        public Notifications Notifications { get; set; }

        [DataMember]
        public GeoCoordinate Location { get; set; }

        [DataMember]
        public string StartTime { get; set; } // for checking TransportRouteRun Direction
        [DataMember]
        public string EndTime { get; set; } // For Checking TransportRunDirection

        [DataMember]
        public int StoppageRadius { get; set; } // Radius in meters for creating a stoppage

        [DataMember]
        public int AllowedSpeed { get; set; } // Speed Limit Default to be populated for each route
        [DataMember]
        public int _ts { get; set; }
    }

    [DataContract]
    public class Notifications
    {

        #region Notifications for Parents
        [DataMember]
        public bool NotifyParentWhenWalkerRequestByAdmin { get; set; }
        [DataMember]
        public bool NotifyParentWhenWalkerRequestAcknowledgedByAdmin { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronBoardedBus { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronBoardedBusFromOtherStop { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronMissBus { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronReachedSchool { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronDropped { get; set; }
        [DataMember]
        public bool NotifyParentWhenPatronDroppedAtOtherStop { get; set; }
        [DataMember]
        public bool NotifyParentWhenBusReachingInSomeTime { get; set; }
        [DataMember]
        public bool NotifyParentWhenBusDelayBySomeTime { get; set; }
        [DataMember]
        public bool NotifyParentWhenBusReachedStop { get; set; }
        [DataMember]
        public bool NotifyParentForPatronAbscond { get; set; }
        [DataMember]
        public bool NotifyParentForPatronLeftSchool { get; set; }
        //public bool NotifyParentWhenPatronBoardedBusFromSchool { get; set; }


        //public bool NotifyParentForWhenTransportReachingStop { get; set; }
        //public bool NotifyParentForWhenTransportReachedStop { get; set; }

        //public bool NotifyParentForWhenTransportDelayed { get; set; }

        //public bool NotifyParentForWhenPatronBoardedBus { get; set; }

        //public bool NotifyParentForWhenPatronBoardedBusFromOtherStoppage { get; set; }

        //public bool NotifyParentForWhenTransportReachedSchool { get; set; }

        //public bool NotifyParentForWhenTransportLeftSchool { get; set; }

        //public bool NotifyParentForPatronReachedSchool { get; set; }

        //public bool NotifyParentForPatronLeftSchool { get; set; }

        //public bool NotifyParentForWhenPatronDropped { get; set; }
        //public bool NotifyParentForWhenPatronDroppedOnOtherStoppage { get; set; }

        //public bool NotifyParentForPatronAbsent { get; set; }

        //public bool NotifyParentForPatronAbscond { get; set; }

        //public bool NotifyParentForAcknowledgingWalkerRequest { get; set; }

        #endregion

        #region Admin Notifications
        [DataMember]
        public bool NotifyAdminForPatronWalkerRequest { get; set; }
        [DataMember]
        public bool NotifyAdminForPatronLeaveRequest { get; set; }
        [DataMember]
        public bool NotifyAdminForRouteStartedForPick { get; set; }
        [DataMember]
        public bool NotifyAdminForRouteCompletedForPick { get; set; }
        [DataMember]
        public bool NotifyAdminForRouteStartedForDrop { get; set; }
        [DataMember]
        public bool NotifyAdminForRouteCompletedForDrop { get; set; }
        [DataMember]
        public bool NotifyAdminForWhenPatronBoardedBusFromOtherStop { get; set; }
        [DataMember]
        public bool NotifyAdminForPatronAbsent { get; set; }
        [DataMember]
        public bool NotifyAdminForWhenPatronDroppedOnOtherStop { get; set; }
        [DataMember]
        public bool NotifyAdminForWhenPatronCountUnMatchedForStop { get; set; }
        [DataMember]

        public bool NotifyAdminForWhenTransportReachedAtSchool { get; set; }
        [DataMember]

        public bool NotifyAdminForWhenTransportCrossingSpeed { get; set; }
        [DataMember]
        public bool NotifyAdminForWhenTransportDelayed { get; set; }
        [DataMember]
        public bool NotifyAdminForWhenTransportReachedStop { get; set; }

       

        #endregion

       

    }


    // SmartId Settings

    [DataContract]
    public class SmartTrackSettings
    {
        

        // To track stop drop of patrons
        [DataMember]
        public bool TrackTransportStopDrop { get; set; }

        [DataMember]
        public bool EnableSMSNotificaions { get; set; }

        [DataMember]
        public bool TrackPatrons { get; set; } = true; // This is to track patrons during the transport

        // Violation Specific Settings
        [DataMember]
        public bool TrackGeoFence { get; set; } = true;

        [DataMember]
        public bool TrackSpeedViolation { get; set; } = true;

        [DataMember]
        public bool TrackHarshBreaking { get; set; } = true;

        [DataMember]
        public bool TrackPanicButton { get; set; } = true;

        [DataMember]
        public SmartTrackAllowedSMS AllowedSms { get; set; } 
        
    }
    [DataContract]
    public class SmartTrackAllowedSMS
    {
        [DataMember]
        public bool TRANSPORT_TO_REACHING_STOP { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_TO_PICKED { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_TO_MISSED { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_TO_REACHED_SCHOOL { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_FROM_BOARDED { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_FROM_MISSED { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_FROM_REACHING_STOP { get; set; } = false;
        [DataMember]
        public bool TRANSPORT_FROM_DROPPED { get; set; } = false;
    }


    // SmartId Settings

    [DataContract]
    public class SmartIdSettings
    {
        // Used to track patrons when school ends ( Via transport and without transport )
        [DataMember]
        public bool TrackSessionStart { get; set; }
        // Used to track patrons when school ends ( Via transport and without transport )
        [DataMember]
        public bool TrackSessionEnd { get; set; }
        // Track half sessions
        [DataMember]
        public bool TrackHalfSession { get; set; }

        [DataMember]
        public bool TrackPeriods { get; set; }

        [DataMember]
        public bool TrackLocation { get; set; }

        [DataMember]
        public bool TrackEvent { get; set; }

        [DataMember]
        public SmartIdAllowedSMS AllowedSms { get; set; }

        [DataMember]
        public bool EnableSMSNotificaions { get; set; }
    }

    [DataContract]
    public class SmartIdAllowedSMS
    {

        // To Parents
        [DataMember]
        public bool SCHOOL_IN { get; set; } = false;

        [DataMember]
        public bool SCHOOL_OUT { get; set; } = false;

        [DataMember]
        // To Teachers 
        public bool ABSENT_SUMMARY_TO_TEACHER { get; set; } = false;
        
        
    }


}
