using System;
using System.Threading.Tasks;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Data.Repositories;
using OnlineOrdering.DTOs.Restaurants;
using Xunit;
namespace OnlineOrdering.Tests.RestaurantTests
{
    public class CreateRestaurantTests
    {
	    [Fact]
	    public void Restaurant_Has_Default_Values()
	    {
		    var restaurant = new CreateRestaurantDTO();

			Assert.Equal(5, restaurant.DeliveryRadius);
			Assert.Equal("America/New York", restaurant.TimeZone);
			Assert.Equal(90, restaurant.MinutesInAdvanceAllowDelivery);
			Assert.Equal(90, restaurant.MinutesInAdvanceAllowPickUp);
			Assert.Equal(0, restaurant.Latitude);
			Assert.Equal(string.Empty, restaurant.Name);
			Assert.Equal(string.Empty, restaurant.Email);
			Assert.Equal(string.Empty, restaurant.PhoneNumber);
			Assert.Equal(string.Empty, restaurant.Address1);
			Assert.Equal(string.Empty, restaurant.Address2);
	    }

	    

		[Fact]
	    public void Can_Save_Restaurant()
	    {
		    var context = TestingSetup.GetContext();
		    var repo = new RestaurantRepository(context);
		    var restaurant = new Restaurant();

		    Task task = repo.SaveAsync(restaurant)
			    .ContinueWith(innerTask =>
			    {
				    var result = innerTask.Result;
					Assert.IsType<Restaurant>(result);
			    });

			Assert.Single(context.Restaurants);
	    }
    }
}
