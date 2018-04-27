using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class Patron : BaseModel
    {
        // Properties
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PatronNumber { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public int Class { get; set; }
        [DataMember]
        public string ImgUrl { get; set; }
        [DataMember]
        public string Section { get; set; }
        [DataMember]
        public int RollNo { get; set; }
        [DataMember]
        public bool IsActive { get; set; }

        [JsonIgnore,DataMember]
        public string StatusMessage { get; set; }
        [DataMember]
        public string TransportRouteId { get; set; }
        [DataMember]
        public string StoppageId { get; set; }
        // Associations with other entities
        [DataMember]
        public List<Person> Persons { get; set; }

        

        [JsonIgnore,DataMember]
        public Organization Organization { get; set; }

        [DataMember]
        public List<Authentication> Authentications { get; set; }
        [DataMember]
        public int _ts { get; set; }


    }
    /*
    public class PatronStoppageSummary : BaseModel
    {
        public  string StoppageName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PatronClass { get; set; }

        public string Section { get; set; }

        public string RollNumber { get; set; }

    }
    */

}
