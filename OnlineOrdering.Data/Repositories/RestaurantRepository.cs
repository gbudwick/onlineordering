using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineOrdering.Data.DbContexts;
using OnlineOrdering.Data.Interfaces;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Data.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
	    private readonly OOContext _context;

	    public RestaurantRepository(OOContext context)
	    {
		    _context = context;
	    }

	    public async Task<Restaurant> SaveAsync(Restaurant model)
	    {
		    _context.Restaurants.Add(model);
		    await _context.SaveChangesAsync();
		    return model;
	    }
    }
}
