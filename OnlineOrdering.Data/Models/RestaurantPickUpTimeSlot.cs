namespace OnlineOrdering.Data.Models
{
	public class RestaurantPickUpTimeSlot : TimeSlot
	{
		public Restaurant Restaurant { get; set; } // Not NULL
	}
}