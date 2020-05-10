namespace OnlineOrdering.Data.Models
{
	public abstract class Address : BaseEntity
	{
		public string Address1 { get; set; } // Default empty string
		public string Address2 { get; set; } // Default empty string
		public string Locality { get; set; } // Default empty string
		public string Region { get; set; } // Default empty string
		public string PostalCode { get; set; } // Default empty string
		public string Country { get; set; } // Default empty string
		public decimal Latitude { get; set; } // Default 0
		public decimal Longitude { get; set; } // Default 0
	}
}