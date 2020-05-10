namespace OnlineOrdering.Data.Models
{
	public class ItemAttributeTaxRate : BaseEntity
	{
		public ItemAttribute ItemAttribute { get; set; } // Not NULL
		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}