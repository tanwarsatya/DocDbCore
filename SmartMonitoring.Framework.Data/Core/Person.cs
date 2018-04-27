using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class Person : BaseModel
    {

        public Person() { }
        
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public Patron Patron { get; set; }
        [DataMember]
        public string PatronId { get; set; }
        [DataMember]
        public List<Person> PersonObj { get; set; }
        //public Person PersonObj { get; set; }
        [DataMember]
        public string PersonId { get; set; }

        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }

        [DataMember]
        public string PrimaryMobile { get; set; }
        [DataMember]
        public string Role { get; set; }
        [DataMember]
        public string ImgUrl { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public bool IsPrimaryContact { get; set; }
        [DataMember]
        public bool IsHavingSmartPhone { get; set; }
        [DataMember]
        public string SecondaryMobile { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string Relation { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public List<Authentication> Authentications { get; set; }
        [DataMember]
        public Notifications Notifications { get; set; }
        [DataMember]
        public int _ts { get; set; }
        

    }


}