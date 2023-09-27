using System.Runtime.Serialization;

namespace Car_Dealer.Models
{
	[DataContract]
	public class Rental
	{
        [DataMember]
        public Guid RentalID { get; set; }
		[DataMember]
		public Guid UserID { get; set;}
		[DataMember]
		public Guid CarID { get; set;}
		[DataMember]
		public DateOnly? RentalStartDate { get; set;}
		[DataMember]
		public DateOnly? RentalEndDate { get; set; }
		[DataMember]
		public decimal? TotalCost { get; set;}
		[DataMember]
		public string? Status { get; set;}
	}
}
