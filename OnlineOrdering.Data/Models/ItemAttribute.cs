namespace OnlineOrdering.Data.Models
{
	public class ItemAttribute : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public decimal Price { get; set; } // Default 0
		public int SortOrder { get; set; } // Default 0
		public ItemAttributeGroup ItemAttributeGroup { get; set; } // Not NULL
		public ItemAttributeTaxRate[] ItemAttributeTaxRates { get; set; }
	}
}