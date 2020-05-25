using System.Threading.Tasks;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Data.Interfaces
{
    public interface IRestaurantRepository
    {
	    Task<Restaurant> SaveAsync(Restaurant model);

	    Task<Restaurant> GetRestaruantByExternalIdAsync(string id);

	    Task<Restaurant> AddNewRestaurant(Restaurant restaurant);
    }
}