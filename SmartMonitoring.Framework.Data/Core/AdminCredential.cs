using System.Runtime.Serialization;

namespace SmartMonitoring.Framework.Models.Core
{
    [DataContract]
    public class AdminCredential : BaseModel
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        public string NewPassword { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string ImgUrl { get; set; }
        [DataMember]
        public string EmailId { get; set; }
        [DataMember]
        public string PrimaryContact { get; set; }
        [DataMember]
        public string Secondarycontact { get; set; }
    }
}
