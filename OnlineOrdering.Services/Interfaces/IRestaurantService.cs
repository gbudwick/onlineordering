using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineOrdering.DTOs.Restaurants;

namespace OnlineOrdering.Services.Interfaces
{
    public interface IRestaurantService
    {
	    Task<RestaurantDTO> GetRestaurantByIdAsync(string id);

	    Task<RestaurantDTO> CreateNewRestaurant(CreateRestaurantDTO restaurant);
    }
}
