using System.Runtime.Serialization;

namespace Car_Dealer.Models
{
	[DataContract]
	public class Payment
	{
		[DataMember]
		public Guid PaymentId { get; set; }
		[DataMember]
		public Guid RentalId { get; set; }
		[DataMember]
		public DateTime PaymentDate { get; set; }
		[DataMember]
		public decimal? PaymentAmount { get; set; }
		[DataMember]
		public string? PaymentMethod { get; set; }
		[DataMember]
        public string? PayStatus { get; set; }
    }
}
