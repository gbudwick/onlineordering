using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineOrdering.DTOs;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Data.Repositories;
using OnlineOrdering.DTOs.Restaurants;
using OnlineOrdering.Services.Services;
using OnlineOrdering.Web.Controllers;
using Xunit;

namespace OnlineOrdering.Tests.RestaurantTests
{
    public class RestaurantControllerTests
    {
	    [Fact]
	    public void Can_Get_Default_Restaurant_DTO()
	    {
		    var context = TestingSetup.GetContext();

		    var controller =
			    new RestaurantController(
				    new RestaurantService(
					    new RestaurantRepository(context)));
		    dynamic result = (JsonResult)controller.Default();
			Assert.Equal(90, result.Value.MinutesInAdvanceAllowDelivery);
	    }

	    [Fact]
	    public void Can_Get_Restaurant_By_ExternalId()
	    {
		    var context = TestingSetup.GetContext();

		    var restaurant = new Restaurant()
		    {
			    ExternalId = "31e045af-cc46-4e28-a783-71d456d86400",
			    Name = "New Restaurant"
		    };

		    context.Restaurants.Add(restaurant);
		    context.SaveChanges();

			var controller =
			    new RestaurantController(
				    new RestaurantService(
					    new RestaurantRepository(context)));

			var task = controller.GetRestaurantByExternalId("31e045af-cc46-4e28-a783-71d456d86400")
				.ContinueWith(innerTask =>
				{
					var result = innerTask.Result;
					Assert.IsType<RestaurantDTO>(result);
					Assert.Equal("31e045af-cc46-4e28-a783-71d456d86400", result.ExternalId );
				});
	    }

	    [Fact]
	    public void Post_New_Restuarant()
	    {
		    var context = TestingSetup.GetContext();

		    var controller =
			    new RestaurantController(
				    new RestaurantService(
					    new RestaurantRepository(context)));

		    var restaurant = new CreateRestaurantDTO();
		    restaurant.Name = "Mike's Diner";

		    var task = controller.CreateRestaurant(restaurant)
			    .ContinueWith(innterTask =>
			    {
				    var result = innterTask.Result;
				    Assert.IsType<RestaurantDTO>(result);
					Assert.Equal("Mike's Diner", result.Name);
			    });
	    }
    }
}
