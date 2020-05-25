using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineOrdering.DTOs;
using OnlineOrdering.DTOs.Restaurants;
using OnlineOrdering.Services.Interfaces;

namespace OnlineOrdering.Web.Controllers
{
	[Route("api/restaurants")]
	public class RestaurantController : Controller
	{
		private readonly IRestaurantService _restaurantService;

		public RestaurantController(IRestaurantService restaurantService)
		{
			_restaurantService = restaurantService;
		}

		[Route("default")]
		public IActionResult Default()
		{
			return new JsonResult(new CreateRestaurantDTO());
		}

		[HttpGet("{id}")]
		public async Task<RestaurantDTO> GetRestaurantByExternalId(string id)
		{
			var result = await _restaurantService.GetRestaurantByIdAsync(id);
			return result;
		}

		[HttpPost]
		public async Task<RestaurantDTO> CreateRestaurant([FromBody] CreateRestaurantDTO model)
		{
			return await _restaurantService.CreateNewRestaurant(model);
		}
	}
}
