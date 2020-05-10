namespace OnlineOrdering.Data.Models
{
	public class RestaurantDeliveryTimeSlot : TimeSlot
	{
		public Restaurant Restaurant { get; set; } // Not NULL
	}
}