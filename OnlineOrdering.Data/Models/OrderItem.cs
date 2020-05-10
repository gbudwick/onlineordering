namespace OnlineOrdering.Data.Models
{
	public class OrderItem : BaseEntity
	{
		public string Name { get; set; } // Default from Item.Name
		public string Description { get; set; } // Default from Item.Description
		public decimal Price { get; set; } // Default from Item.Price
		public decimal Quantity { get; set; } // Default 1
		public string Notes { get; set; } // Default empty string
		public Order Order { get; set; } // Not NULL
		public Category Category { get; set; } // Not NULL
		public Item Item { get; set; } // Not NULL
		public OrderItemTaxRate[] OrderItemTaxRates { get; set; } // Clone from Item.ItemTaxRates
		public OrderItemAttributeGroup[] OrderItemAttributeGroups { get; set; }
	}
}