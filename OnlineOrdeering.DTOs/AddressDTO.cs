
using Newtonsoft.Json;

namespace OnlineOrdering.DTOs
{
    public class AddressDTO
    {
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
		public decimal Latitude { get; set; } = 0;

		[JsonProperty("longitude")]
		public decimal Longitude { get; set; } = 0;
    }
}