namespace OnlineOrdering.Data.Models
{
	public class RestaurantUser : BaseEntity
	{
		public OOUser User { get; set; } // Not NULL
		public Restaurant Restaurant { get; set; } // Not NULL
		public UserAccessType UserAccessType { get; set; } // Not NULL, default Employee
	}
}