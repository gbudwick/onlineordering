using System;

namespace OnlineOrdering.Data.Models
{
	public class Order : Address
	{
		public OrderType OrderType { get; set; } // Default PickUp
		public OrderStatus OrderStatus { get; set; } // Default Pending
		public DateTime OrderDate { get; set; } // Default UTC now
		public decimal DeliveryFee { get; set; } // Default from Restaurant.DeliveryFee
		public string CompanyName { get; set; } // Clone User.CompanyName, default empty string
		public string FirstName { get; set; } // Clone User.FirstName, default empty string
		public string LastName { get; set; } // Clone User.LastName, default empty string
		public string Email { get; set; } // Clone User.Email, default empty string
		public string PhoneNumber { get; set; } // Default empty string
		public string Notes { get; set; } // Default empty string
		public OOUser User { get; set; } // Not NULL
		public Restaurant Restaurant { get; set; } // Not NULL
		public OrderDeliveryFeeTaxRate[] DeliveryFeeTaxRates { get; set; } // Clone from Restaurant.DeliveryFeeTaxRates
		public OrderItem[] OrderItems { get; set; }
	}
}