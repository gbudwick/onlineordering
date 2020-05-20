using OnlineOrdeering.DTOs;
using OnlineOrdering.DTOs;
using Xunit;

namespace OnlineOrdering.Tests.AddressTests
{
    public class CreateAddressTests
    {
		[Fact]
		public void Address_Has_Default_Values()
		{
			var address = new AddressDTO();

			Assert.Equal(string.Empty, address.Address1);
			Assert.Equal(string.Empty, address.Address2);
			Assert.Equal(string.Empty, address.Locality);
			Assert.Equal(string.Empty, address.Region);
			Assert.Equal(string.Empty, address.PostalCode);
			Assert.Equal(string.Empty, address.Country);
			Assert.Equal(0, address.Latitude);
			Assert.Equal(0, address.Longitude);
		}
	}
}