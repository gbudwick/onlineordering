using OnlineOrdering.Data.Interfaces;
using OnlineOrdering.DTOs.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OnlineOrdeering.DTOs;
using OnlineOrdering.Data.Models;

namespace OnlineOrdering.Services.Services
{
    public class RestaurantService
    {
	    private readonly IRestaurantRepository _restaurantRepository;
	    private IMapper _mapper;

		public RestaurantService(IRestaurantRepository restaurantRepository)
	    {
		    _restaurantRepository = restaurantRepository;
		    InitializeMapper();

	    }

	    private void InitializeMapper()
	    {
		    var configuration = new MapperConfiguration(cfg =>
		    {
			    cfg.CreateMap<Restaurant, CreateRestaurantDTO>().ReverseMap();
			    cfg.CreateMap<Restaurant, RestaurantDTO>().ReverseMap();
		    });

		    _mapper = configuration.CreateMapper();
	    }

        public async Task<RestaurantDTO> SaveRestaurantAsync(CreateRestaurantDTO model)
        {
	        var restaurantToSave = _mapper.Map<Restaurant>(model);
	        var restaurant = await _restaurantRepository.SaveAsync(restaurantToSave);
	        return _mapper.Map<RestaurantDTO>(restaurant);
        }

        public async Task<RestaurantDTO> GetRestaurantByIdAsync(string externalId)
        {
	        var restaurant = await _restaurantRepository.GetRestaruantByExternalIdAsync(externalId);
	        return _mapper.Map<RestaurantDTO>(restaurant);
        }
	}
}