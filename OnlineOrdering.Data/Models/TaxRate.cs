namespace OnlineOrdering.Data.Models
{
	public abstract class TaxRate : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public decimal Rate { get; set; } // Default 0, > 0, < 1
	}
}