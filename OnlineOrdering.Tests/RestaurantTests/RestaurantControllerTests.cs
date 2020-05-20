using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnlineOrdering.Web.Controllers;
using Xunit;

namespace OnlineOrdering.Tests.RestaurantTests
{
    public class RestaurantControllerTests
    {
	    [Fact]
	    public void Can_Get_Default_Restaurant_DTO()
	    {
		    var controller = new RestaurantController();
		    dynamic result = (JsonResult)controller.Default();
			Assert.Equal(90, result.Value.MinutesInAdvanceAllowDelivery);
	    }
    }
}
