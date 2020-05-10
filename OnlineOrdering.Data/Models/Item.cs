namespace OnlineOrdering.Data.Models
{
	public class Item : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public decimal Price { get; set; } // Default 0
		public int SortOrder { get; set; } // Default 0
		public Category Category { get; set; } // Not NULL
		public ItemTaxRate[] ItemTaxRates { get; set; }
		public ItemAttributeGroup[] ItemAttributeGroups { get; set; }
	}
}