namespace OnlineOrdering.Data.Models
{
	public abstract class TimeSlot : BaseEntity
	{
		public int StartMinute { get; set; } // Default 0, >= 0, <= 1439
		public int EndMinute { get; set; } // Default 1439, >= 0, <= 1439, > StartMinute
		public int DayOfWeek { get; set; } // Default 0, > 0, < 7
	}
}