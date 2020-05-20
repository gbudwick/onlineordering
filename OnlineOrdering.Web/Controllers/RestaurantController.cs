using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineOrdeering.DTOs;
using OnlineOrdering.DTOs.Restaurants;

namespace OnlineOrdering.Web.Controllers
{
    [Route("api/restaurants")]
    public class RestaurantController : Controller
    {
        [Route("default")]
	    public IActionResult Default()
	    {
            return new JsonResult(new CreateRestaurantDTO());
	    }
    }
}
