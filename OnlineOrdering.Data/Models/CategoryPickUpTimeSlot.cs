namespace OnlineOrdering.Data.Models
{
	public class CategoryPickUpTimeSlot : TimeSlot
	{
		public Category Category { get; set; } // Not NULL
	}
}