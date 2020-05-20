using Newtonsoft.Json;

namespace OnlineOrdering.DTOs.Restaurants
{
    public class CreateRestaurantDTO
    {
		[JsonProperty("name")]
	    public string Name { get; set; } = string.Empty;

		[JsonProperty("email")]
		public string Email { get; set; } = string.Empty;

		[JsonProperty("phoneNumber")]
		public string PhoneNumber { get; set; } = string.Empty;

		[JsonProperty("timeZone")]
		public string TimeZone { get; set; } = "America/New York";

		[JsonProperty("deliveryRadius")]
		public decimal DeliveryRadius { get; set; } = 5;

		[JsonProperty("deliveryFee")]
		public decimal DeliveryFee { get; set; }

		[JsonProperty("deliveryMinimum")]
		public decimal DeliveryMinimum { get; set; }

		[JsonProperty("daysInAdvanceAllowDelivery")]
		public int DaysInAdvanceAllowDelivery { get; set; }

		[JsonProperty("minutesInAdvanceAllowDelivery")]
		public int MinutesInAdvanceAllowDelivery { get; set; } = 90;

		[JsonProperty("PickUpMinimum")]
		public decimal PickUpMinimum { get; set; }

		[JsonProperty("daysInAdvanceAllowPickUp")]
		public int DaysInAdvanceAllowPickUp { get; set; }

		[JsonProperty("minutesInAdvanceAllowPickUp")]
		public int MinutesInAdvanceAllowPickUp { get; set; } = 90;

		[JsonProperty("address1")]
		public string Address1 { get; set; } = string.Empty;

		[JsonProperty("address2")]
		public string Address2 { get; set; } = string.Empty;

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }


		[JsonProperty("locality")]
		public string Locality { get; set; } = string.Empty;

		[JsonProperty("region")]
		public string Region { get; set; } = string.Empty;

		[JsonProperty("postalCode")]
		public string PostalCode { get; set; } = string.Empty;

		[JsonProperty("country")]
		public string Country { get; set; } = string.Empty;

		[JsonProperty("latitude")]
		public decimal Latitude { get; set; }

		[JsonProperty("longitude")]
		public decimal Longitude { get; set; }
	}
}