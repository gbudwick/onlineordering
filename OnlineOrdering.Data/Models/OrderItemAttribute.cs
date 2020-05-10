namespace OnlineOrdering.Data.Models
{
	public class OrderItemAttribute : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public decimal Price { get; set; } // Default 0
		public OrderItemAttributeGroup OrderItemAttributeGroup { get; set; } // Not NULL
		public OrderItemAttributeTaxRate[] OrderItemAttributeTaxRates { get; set; }
	}
}