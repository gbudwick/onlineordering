namespace OnlineOrdering.Data.Models
{
	public class RestaurantTaxRate : TaxRate
	{
		public Restaurant Restaurant { get; set; } // Not NULL
	}
}