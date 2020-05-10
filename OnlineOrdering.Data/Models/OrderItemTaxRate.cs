namespace OnlineOrdering.Data.Models
{
	public class OrderItemTaxRate : TaxRate
	{
		public OrderItem OrderItem { get; set; } // Not NULL
		public RestaurantTaxRate RestaurantTaxRate { get; set; } // Not NULL
	}
}