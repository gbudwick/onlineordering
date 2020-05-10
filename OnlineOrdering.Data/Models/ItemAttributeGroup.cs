namespace OnlineOrdering.Data.Models
{
	public class ItemAttributeGroup : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public int SortOrder { get; set; } // Default 0
		public int Minimum { get; set; } // Default 0
		public int? Maximum { get; set; } // Default NULL, if non-null >= minimum
		public Item Item { get; set; } // Not NULL
	}
}