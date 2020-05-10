namespace OnlineOrdering.Data.Models
{
	public class DeliveryFeeTaxRate : BaseEntity
	{
		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}