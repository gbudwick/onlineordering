using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.DTOs.Restaurants
{
    public class RestaurantDTO
    {
	    public string ExternalId { get; set; }
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
		public string Address1 { get; set; } // Default empty string
		public string Address2 { get; set; } // Default empty string
		public string Locality { get; set; } // Default empty string
		public string Region { get; set; } // Default empty string
		public string PostalCode { get; set; } // Default empty string
		public string Country { get; set; } // Default empty string
		public decimal Latitude { get; set; } // Default 0
		public decimal Longitude { get; set; } // Default 0

	}
}
