using System.Reflection;
using System.Runtime.Serialization;

namespace Car_Dealer.Models
{
	[DataContract]
	public class Car
	{
		[DataMember]
		public Guid CarID { get; set; }
		[DataMember]
		public string? Make { get; set; }
		[DataMember]
		public string? Model { get; set; }
		[DataMember]
		public int? Year {  get; set; }
		[DataMember]
		public decimal? RegistrationNumber { get; set; }
		[DataMember]
		public string? Color { get; set; }
		[DataMember]
		public decimal? Mileage { get; set; }
		[DataMember]
		public decimal? DailyRentalRate { get; set; }
		[DataMember]
		public string? Description { get; set; }
		[DataMember]
		public string? AvailabilityStatus { get; set; }
	}
}
