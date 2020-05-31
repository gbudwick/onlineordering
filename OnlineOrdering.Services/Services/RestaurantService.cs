using OnlineOrdering.Data.Interfaces;
using OnlineOrdering.DTOs.Restaurants;
using System.Threading.Tasks;
using AutoMapper;
using OnlineOrdering.Data.Models;
using OnlineOrdering.Services.Interfaces;

namespace OnlineOrdering.Services.Services
{
    public class RestaurantService : IRestaurantService
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

        public async Task<RestaurantDTO> CreateNewRestaurant(CreateRestaurantDTO createRestaurant)
        {
	        var restaurant = _mapper.Map<Restaurant>(createRestaurant);
	        await _restaurantRepository.AddNewRestaurant(restaurant);
	        return _mapper.Map<RestaurantDTO>(restaurant);
        }
	}
}