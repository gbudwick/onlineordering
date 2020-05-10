namespace OnlineOrdering.Data.Models
{
	public class Category : BaseEntity
	{
		public string Name { get; set; } // Default empty string
		public string Description { get; set; } // Default empty string
		public int SortOrder { get; set; } // Default 0
		public bool InheritDeliveryTimeSlots { get; set; } // Default true
		public bool InheritPickUpTimeSlots { get; set; } // Default true
		public Restaurant Restaurant { get; set; } // Not NULL
		public CategoryDeliveryTimeSlot[] DeliveryTimeSlots { get; set; }
		public CategoryPickUpTimeSlot[] PickUpTimeSlots { get; set; }
		public Item[] Items { get; set; }
	}
}