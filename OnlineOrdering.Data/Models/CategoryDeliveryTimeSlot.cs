namespace OnlineOrdering.Data.Models
{
	public class CategoryDeliveryTimeSlot : TimeSlot
	{
		public Category Category { get; set; } // Not NULL
	}
}