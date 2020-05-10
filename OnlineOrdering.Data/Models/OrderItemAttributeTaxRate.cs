namespace OnlineOrdering.Data.Models
{
	public class OrderItemAttributeTaxRate : TaxRate
	{
		public OrderItemAttribute OrderItemAttribute { get; set; } // Not NULL
		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}