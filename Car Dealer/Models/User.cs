using System.Runtime.Serialization;

namespace Car_Dealer.Models
{
	[DataContract]
	public class User
	{
		[DataMember]
		public Guid UserId { get; set; }
		[DataMember]
        public string? FirstName { get; set; }
		[DataMember]
        public string? LastName { get; set; }
		[DataMember]
		public string? Email { get; set; }
		[DataMember]
		public string? Password { get; set; }
		[DataMember]
		public string? Role { get; set; }
		[DataMember]
		public int? PhoneNumber { get; set;}
    }
}
