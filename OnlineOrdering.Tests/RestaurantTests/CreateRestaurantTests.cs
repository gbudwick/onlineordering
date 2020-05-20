using System;
using System.Linq;
using System.Threading.Tasks;
using OnlineOrdeering.DTOs;
using OnlineOrdering.Data.Interfaces;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Data.Repositories;
using OnlineOrdering.DTOs.Restaurants;
using OnlineOrdering.Services.Services;
using Xunit;
namespace OnlineOrdering.Tests.RestaurantTests
{
    public class CreateRestaurantTests
    {
	    #region Repository

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

	    [Fact]
	    public void Can_Get_Restuarant_By_ExternalId()
	    {
		    var context = TestingSetup.GetContext();
		    var repo = new RestaurantRepository(context);
			    
			var restaurant = new Restaurant()
			{
				Name = "New Restaurant"
			};

			context.Restaurants.Add(restaurant);
			context.SaveChanges();

			var existingRestaurant = context.Restaurants.First();

			Task task = repo.GetRestaruantByExternalIdAsync(existingRestaurant.ExternalId)
				.ContinueWith(innerTask =>
				{
					var result = innerTask.Result;
					Assert.Equal("New Restaurant", result.Name);
				});
	    }

	    #endregion

		#region Services

		[Fact]
		public void Svc_Can_Save_CreateRestaurantDTO()
		{
			var restaurant = new CreateRestaurantDTO();
			var context = TestingSetup.GetContext();
			IRestaurantRepository repo = new RestaurantRepository(context);
			var svc = new RestaurantService(repo);

			Task task = svc.SaveRestaurantAsync(restaurant)
				.ContinueWith(innerTask =>
				{
					var result = innerTask.Result;
					Assert.Equal("America/New York", result.TimeZone);
				});

			Assert.Single(context.Restaurants);
		}

		[Fact]
		public void Can_Get_RestaurantDTO()
		{
			var context = TestingSetup.GetContext();
			IRestaurantRepository repo = new RestaurantRepository(context);

			var restaurant = new Restaurant()
			{
				Name = "New Restaurant"
			};

			context.Restaurants.Add(restaurant);
			context.SaveChanges();

			var svc = new RestaurantService(repo);

			Task task = svc.GetRestaurantByIdAsync(restaurant.ExternalId)
				.ContinueWith(innerTask =>
				{
					var result = innerTask.Result;
					Assert.IsType<RestaurantDTO>(result);
					Assert.Equal("America/New York", result.TimeZone);
					Assert.Equal("New Restaurant", result.Name);
				});
		}

		#endregion	
	}
}
