using System;
using System.Collections.Generic;

namespace OnlineOrdering.Data.Models
{
	public class Restaurant : BaseEntity
	{
		public Restaurant()
		{
			ExternalId = Guid.NewGuid().ToString();
		}

		public string Name { get; set; } // Default empty string
		public string Email { get; set; } // Default empty string
		public string PhoneNumber { get; set; } // Default empty string
		public string TimeZone { get; set; } // Default America/New_York
		public decimal DeliveryRadius { get; set; } // Default 5
		public decimal DeliveryFee { get; set; } // Default 0
		public decimal DeliveryMinimum { get; set; } // Default 0
		public int DaysInAdvanceAllowDelivery { get; set; } // Default 0
		public int MinutesInAdvanceAllowDelivery { get; set; } // Default 90
		public decimal PickUpMinimum { get; set; } // Default 0
		public int DaysInAdvanceAllowPickUp { get; set; } // Default 0
		public int MinutesInAdvanceAllowPickUp { get; set; } // Default 90
		public Address Address { get; set; }
		public string UserId { get; set; }
		public IEnumerable<Category> Categories { get; set; }

		public OOUser User { get; set; }

		//public IEnumerable<DeliveryFeeTaxRate> DeliveryFeeTaxRates { get; set; }
		//public IEnumerable<RestaurantDeliveryTimeSlot> DeliveryTimeSlots { get; set; }
		//public IEnumerable<RestaurantPickUpTimeSlot> PickUpTimeSlots { get; set; }
	}
}