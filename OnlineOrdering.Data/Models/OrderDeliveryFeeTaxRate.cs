namespace OnlineOrdering.Data.Models
{
	public class OrderDeliveryFeeTaxRate : TaxRate
	{
		public Order Order { get; set; } // Not NULL
		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}