namespace OnlineOrdering.Data.Models
{
	public class ItemTaxRate : BaseEntity
	{
		public Item Item { get; set; } // Not NULL

		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}